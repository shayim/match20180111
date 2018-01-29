using System;
using System.Collections.Generic;
using Match.Mia.Webapi.ViewModels.Common;
using Match.Mia.Webapi.ViewModels.Contact;
using Match.Mia.Webapi.ViewModels.SalesPerson;

namespace Match.Mia.Webapi.ViewModels.Client
{
    public class ClientDetailsVm
    {
        protected ClientDetailsVm()
        {
        }

        public ClientDetailsVm(Guid id, string name, string otherName = null,
            IEnumerable<ContactListItemVm> contact = null, IEnumerable<SalesPersonListItemVm> sales = null,
            IEnumerable<AddressSingleLineVm> addresses = null, IEnumerable<IdentityDocumentVm> identityDocuments = null)
        {
            Id = id;
            Name = name;
            OtherName = otherName;
            Contacts = contact;
            Sales = sales;
            Addresses = addresses;
            IdentityDocuments = identityDocuments;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string OtherName { get; set; }
        public IEnumerable<ContactListItemVm> Contacts { get; set; }
        public IEnumerable<SalesPersonListItemVm> Sales { get; set; }
        public IEnumerable<AddressSingleLineVm> Addresses { get; set; }
        public IEnumerable<BankAccountVm> BankAccounts { get; set; }
        public IEnumerable<IdentityDocumentVm> IdentityDocuments { get; set; }
    }
}