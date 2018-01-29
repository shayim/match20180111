using System;
using System.IO;
using System.Threading.Tasks;
using Match.Mia.Webapi.ViewModels;
using Match.Mia.Webapi.ViewModels.Common;
using Match.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Match.Mia.Webapi.Controllers
{
    [Route("api/[controller]")]
    public class IdentityDocumentController : Controller
    {
        private readonly BusinessPartyDbContext _context;
        private readonly string _uploadPath;

        public IdentityDocumentController(BusinessPartyDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _uploadPath = Path.Combine(env.ContentRootPath, "upload", "ids");
        }

        [HttpPost]
        public async Task<IActionResult> Post(IdentityDocumentNewVm newId)
        {
            if (ModelState.IsValid && newId.File.Length > 0)
            {
                var party = _context.Party.Find(newId.PartyId);
                var idType = _context.IdentityDocumentType.Find(newId.TypeId);
                if (party != null && idType != null)
                {
                    var fileName = "id." + Guid.NewGuid() + "." +
                                   newId.File.FileName.Substring(newId.File.FileName.LastIndexOf('.') + 1);

                    var filePath = Path.Combine(_uploadPath, fileName);

                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        await newId.File.CopyToAsync(fs);
                    }

                    party.AddIdentityDocument(idType, newId.Num, newId.Effective, newId.Due, fileName);

                    await _context.SaveChangesAsync();

                    return Ok(new { fileName });
                }
            }
            return BadRequest();
        }
    }
}