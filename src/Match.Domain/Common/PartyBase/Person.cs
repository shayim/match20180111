using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Match.Domain.Common.Geolocations;

namespace Match.Domain.Common.PartyBase
{
    public class Person : Party
    {
        protected Person() : base(Guid.NewGuid())
        {
        }

        public Person(string name, string otherName = null, Gender gender = Gender.Female, string tel = null, string mobile = null,
            string email = null, DateTime? birthDate = null, Country nationality = null) : base(Guid.NewGuid())
        {
            Name = name;
            OtherName = otherName;
            Gender = gender;
            Tel = tel;
            Mobile = mobile;
            Email = email;
            BirthDate = birthDate;
            Nationality = nationality;
            PartyType = (int)PartyBase.PartyType.Person;
        }

        public Gender Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? NationalityId { get; set; }
        public Country Nationality { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Mobile { get; set; }

        public ICollection<SocialMediaAccount> SocialMediaAccounts { get; set; }

        public int? Age => (DateTime.Now.Month > BirthDate?.Month)
         ? (DateTime.Now.Year - BirthDate?.Year)
         : (DateTime.Now.Year - BirthDate?.Year - 1);

        public void AddSocialMediaAccount(SocialMediaType type, string account)
        {
            var account1 = new SocialMediaAccount(type, account);
            SocialMediaAccounts.Add(account1);
        }
    }
}