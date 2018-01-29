using System;
using System.Collections.Generic;
using Match.Domain.Common.PartyBase;
using Match.Mia.Webapi.ViewModels.Common.SocialMedia;

namespace Match.Mia.Webapi.ViewModels.Common.Person
{
    public class PersonDetailsVm
    {
        public PersonDetailsVm(Guid id, string name, string otherName, Gender gender, string mobile, string tel,
            string email, DateTime? birthDate, IEnumerable<SocialMediaAccountVm> socialMediaAccounts = null)
        {
            Id = id;
            Name = name;
            OtherName = otherName;
            Gender = gender;
            Mobile = mobile;
            Tel = tel;
            Email = email;
            BirthDate = birthDate;
            SocialMediaAccounts = socialMediaAccounts;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string OtherName { get; set; }
        public Gender Gender { get; set; }
        public string Mobile { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public DateTime? BirthDate { get; set; }
        public IEnumerable<SocialMediaAccountVm> SocialMediaAccounts { get; set; }
    }
}