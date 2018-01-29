using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;

namespace Match.Mia.Webapi.ViewModels.Common
{
    public class IdentityDocumentNewVm : IValidatableObject
    {
        public Guid PartyId { get; set; }

        [Required]
        public int TypeId { get; set; }

        [Required]
        public string Num { get; set; }

        public IFormFile File { get; set; }

        public DateTime? Effective { get; set; }

        public DateTime? Due { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var fileExt = File.FileName.Substring(File.FileName.LastIndexOf('.') + 1);

            Regex regex = new Regex("[pdf|png|jpg|gif]");

            if (!regex.IsMatch(fileExt))
            {
                yield return new ValidationResult("only upload pdf|png|jpg|gif allowed.");
            }
        }
    }
}