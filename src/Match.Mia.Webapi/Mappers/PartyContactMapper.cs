using System.Collections.Generic;
using Match.Domain.Common.PartyBase;
using Match.Mia.Webapi.ViewModels.Common.SocialMedia;
using Match.Mia.Webapi.ViewModels.Contact;

namespace Match.Mia.Webapi.Mappers
{
    public static class PartyContactMapper
    {
        public static ContactListItemVm ToContactListItem(this PartyContact contact)
        {
            var contactListItemVm = new ContactListItemVm(contact.PartyId, contact.ContactId, contact.Contact.Name,
                contact.Contact.OtherName, contact.Contact.Gender, contact.Contact.Mobile, contact.Contact.Tel,
                contact.Contact.Email, contact.Contact.BirthDate);

            if (contact.Contact.SocialMediaAccounts != null && contact.Contact.SocialMediaAccounts.Count > 0)
            {
                var socialMediaAccounts = new HashSet<SocialMediaAccountVm>();
                foreach (var account in contact.Contact.SocialMediaAccounts)
                {
                    var socialMediaAccountVm = new SocialMediaAccountVm(account.PersonId, account.TypeId, account.Type.Name, account.Account);
                    socialMediaAccounts.Add(socialMediaAccountVm);
                }
                contactListItemVm.SocialMediaAccounts = socialMediaAccounts;
            }

            return contactListItemVm;
        }

        public static IEnumerable<ContactListItemVm> ToContactList(this IEnumerable<PartyContact> contacts)
        {
            var contactList = new HashSet<ContactListItemVm>();
            foreach (var contact in contacts)
            {
                if (contact.IsActive)
                {
                    contactList.Add(contact.ToContactListItem());
                }
            }
            return contactList;
        }
    }
}