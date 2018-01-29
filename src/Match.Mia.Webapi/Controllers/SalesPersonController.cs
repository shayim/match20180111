using System.Linq;
using Match.Mia.Webapi.ViewModels.SalesPerson;
using Match.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Match.Mia.Webapi.Controllers
{
    [Route("api/[controller]")]
    public class SalesPersonController
    {
        private readonly BusinessPartyDbContext _context;

        public SalesPersonController(BusinessPartyDbContext context)
        {
            _context = context;
        }

        public IActionResult Get()
        {
            var salespersons = _context.SalesPerson
                .Select(s => new SalesPersonSelectItemVm(s.Id, s.Employee.Person.Name));

            return new JsonResult(salespersons);
        }
    }
}