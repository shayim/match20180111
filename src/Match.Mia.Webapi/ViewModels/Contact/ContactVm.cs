using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Match.Mia.Webapi.ViewModels.Common.Person;

namespace Match.Mia.Webapi.ViewModels.Contact
{
    public class ContactVm : PersonNewVm, IValidatableObject
    {
        public Guid? PersonId { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(Mobile) && string.IsNullOrWhiteSpace(Tel))
            {
                yield return new ValidationResult("contact need tel or mobile");
            }
        }
    }
}