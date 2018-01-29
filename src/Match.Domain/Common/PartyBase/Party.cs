using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Match.Domain.Common.Geolocations;

namespace Match.Domain.Common.PartyBase
{
    public abstract class Party : Entity<Guid>
    {
        protected Party() : base(Guid.NewGuid())
        { }

        protected Party(Guid id) : base(id)
        { }

        public int PartyType { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string OtherName { get; set; }

        [StringLength(20)]
        public string Tel { get; set; }

        public ICollection<PartyAddress> Addresses { get; set; } = new List<PartyAddress>();

        public ICollection<PartyContact> Contacts { get; set; } = new List<PartyContact>();

        public ICollection<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();

        public ICollection<IdentityDocument> IdentityDocuments { get; set; } = new List<IdentityDocument>();

        public bool IsActive { get; set; } = true;

        public void AddAddress(AddressType type, Address address)
        {
            Addresses.Add(new PartyAddress(this, address, type));
        }

        public void AddContact(Person contact)
        {
            Contacts.Add(new PartyContact(this, contact));
        }

        public void AddBankAccount(Bank bank, string accountNum, string currency)
        {
            BankAccounts.Add(new BankAccount(this, bank, accountNum, currency));
        }

        public void AddIdentityDocument(IdentityDocumentType type, string num, DateTime? effective = null, DateTime? due = null, string fileUrl = null)
        {
            IdentityDocuments.Add(new IdentityDocument(this, type, num, effective, due, fileUrl));
        }
    }
}