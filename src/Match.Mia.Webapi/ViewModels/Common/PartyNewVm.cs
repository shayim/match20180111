using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Match.Mia.Webapi.ViewModels.Client;
using Match.Mia.Webapi.ViewModels.Contact;

namespace Match.Mia.Webapi.ViewModels.Common
{
    public class PartyNewVm
    {
        [Required]
        public string Name { get; set; }

        public string OtherName { get; set; }

        public string Tel { get; set; }

        public IList<AddressNewVm> Addresses { get; set; }
        public IList<ContactVm> Contacts { get; set; }
        public IList<BankAccountNewVm> BankAccounts { get; set; }
        public IList<IdentityDocumentNewVm> IdentityDocuments { get; set; }
    }
}