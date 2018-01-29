using System;
using System.Collections.Generic;
using Match.Domain.Common.PartyBase;
using Match.Mia.Webapi.ViewModels.Common.Person;
using Match.Mia.Webapi.ViewModels.Common.SocialMedia;

namespace Match.Mia.Webapi.ViewModels.Contact
{
    public class ContactListItemVm : PersonDetailsVm
    {
        public ContactListItemVm(Guid liasionId, Guid id, string name, string otherName, Gender gender, string mobile,
            string tel, string email, DateTime? birthDate, IEnumerable<SocialMediaAccountVm> socialMediaAccounts = null)
            : base(id, name, otherName, gender, mobile, tel, email, birthDate, socialMediaAccounts)
        {
            PartyId = liasionId;
        }

        public Guid PartyId { get; set; }
    }
}