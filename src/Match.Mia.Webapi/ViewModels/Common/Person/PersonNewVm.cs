using System;
using System.ComponentModel.DataAnnotations;
using Match.Domain.Common.PartyBase;

namespace Match.Mia.Webapi.ViewModels.Common.Person
{
    public class PersonNewVm
    {
        [Required]
        public string Name { get; set; }

        public string OtherName { get; set; }

        public Gender Gender { get; set; } = Gender.Female;

        public string Tel { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public DateTime? BirthDate { get; set; }

        public int CountryId { get; set; }
    }
}