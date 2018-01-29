using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Match.Domain.BusinessParties;
using Match.Domain.Common.Geolocations;
using Match.Domain.Common.PartyBase;
using Match.Mia.Webapi.ViewModels.Client;
using Match.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Match.Mia.Webapi.Mappers;
using Match.Mia.Webapi.ViewModels.Common.SocialMedia;
using Match.Mia.Webapi.ViewModels.Contact;

namespace Match.Mia.Webapi.Controllers
{
    [Route("api/[controller]")]
    public class ClientsController : Controller
    {
        private readonly BusinessPartyDbContext _context;

        public ClientsController(BusinessPartyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get(int? pageNum, int page = 0)
        {
            var clientListQuery =
                _context.Client.Include(c => c.Party).Select(
                    c => new ClientListItemVm(c.Id, c.Party.Name, c.Party.PartyType, c.Party.OtherName)
                            // c.ToClientListItemVm()
                            );

            if (pageNum.HasValue) clientListQuery = clientListQuery.Skip(page).Take(pageNum.Value);

            return Json(clientListQuery);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var client1 = _context.Client
                .Include(c => c.Party.Contacts).ThenInclude(pc => pc.Contact).ThenInclude(ct => ct.SocialMediaAccounts).ThenInclude(s => s.Type)
                .Include(c => c.CurrentSalesPersons).ThenInclude(s => s.SalesPerson).ThenInclude(s => s.Employee).ThenInclude(e => e.Person)
                .Include(c => c.Party.Addresses).ThenInclude(pa => pa.Address)
                .Include(c => c.Party.BankAccounts).ThenInclude(ba => ba.Bank)
                .Include(c => c.Party.IdentityDocuments)
                .FirstOrDefault(c => c.Id == id);

            if (client1 == null) return NotFound();

            var client = client1.ToClientDetailsVm();

            return Json(client);
        }

        [HttpPost("Company")]
        public IActionResult Post([FromBody]CompanyClientNewVm newCompanyClient)
        {
            if (!ModelState.IsValid) return BadRequest();

            var sales = _context.SalesPerson.Find(newCompanyClient.SalesPersonId);
            if (sales == null) return new BadRequestResult();

            BusinessSection businessSection = null;
            if (newCompanyClient.BusinessSectionId.HasValue)
            {
                businessSection = _context.BusinessSection.Find(newCompanyClient.BusinessSectionId.Value);
            }

            var company = new Company(newCompanyClient.Name, newCompanyClient.OtherName, newCompanyClient.Tel, businessSection);
            var client = new Client(company);

            foreach (var contact in newCompanyClient.Contacts)
            {
                if (contact.PersonId != null && contact.PersonId != default(Guid))
                {
                    var person = _context.Party.OfType<Person>().FirstOrDefault(p => p.Id == contact.PersonId.Value);
                    if (person == null)
                    {
                        return BadRequest();
                    }
                    client.Party.AddContact(person);
                }
                else
                {
                    client.Party.AddContact(new Person(contact.Name, contact.OtherName, contact.Gender, contact.Tel, contact.Mobile,
                        contact.Email, contact.BirthDate));
                }
            }
            foreach (var addressVm in newCompanyClient.Addresses)
            {
                var addressType = _context.AddressType.Find(addressVm.TypeId);
                if (addressType == null) return BadRequest();
                client.Party.AddAddress(addressType, addressVm.ToAddress(_context));
            }

            client.AddSalesPerson(sales);

            _context.Add(client);
            _context.SaveChanges();

            return Ok(newCompanyClient);
        }

        [HttpPost("Person")]
        public async Task<IActionResult> Post(PersonClientNewVm newPersonClient)
        {
            var sales = _context.SalesPerson.Find(newPersonClient.SalesPersonId);
            if (sales == null) return new BadRequestResult();

            Country nationality = null;
            if (newPersonClient.NationalityId.HasValue)
            {
                nationality = _context.Country.Find(newPersonClient.NationalityId);
            }
            var person = new Person(newPersonClient.Name, newPersonClient.OtherName, newPersonClient.Gender, newPersonClient.Tel, newPersonClient.Mobile, newPersonClient.Email, newPersonClient.BirthDate, nationality);
            var client = new Client(person);
            client.AddSalesPerson(sales);

            _context.Add(client);
            await _context.SaveChangesAsync();

            return Ok(client);
        }
    }
}