using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Match.Mia.Webapi.ViewModels.Client
{
    public class CompanyClientNewVm : ClientNewVm, IValidatableObject
    {
        public int? BusinessSectionId { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Contacts == null || Contacts.Count <= 0)
            {
                yield return new ValidationResult("company client need to have a contact");
            }
        }
    }
}