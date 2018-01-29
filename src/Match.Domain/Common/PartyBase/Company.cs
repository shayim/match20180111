using System;

namespace Match.Domain.Common.PartyBase
{
    public class Company : Party
    {
        protected Company() : base(Guid.NewGuid())
        {
        }

        public Company(string companyName, string otherName = null, string tel = null, BusinessSection businessSection = null) : base(Guid.NewGuid())
        {
            Name = companyName;
            OtherName = otherName;
            Tel = tel;
            BusinessSection = businessSection;
            PartyType = (int)PartyBase.PartyType.Company;
        }

        public int? BusinessSectionId { get; set; }

        public BusinessSection BusinessSection { get; set; }
    }
}