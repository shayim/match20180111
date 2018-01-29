using System;
using System.ComponentModel.DataAnnotations;

namespace Match.Domain.Common.PartyBase
{
    public class BankAccount
    {
        protected BankAccount() { }
        public BankAccount(Party party, Bank bank, string accountNum, string currency)
        {
            PartyId = party.Id;
            Bank = bank;
            AccountNumber = accountNum;
            CurrencyCode = currency;
        }

        // key
        public Guid PartyId { get; set; }

        // key
        public int BankId { get; set; }

        // key
        public string AccountNumber { get; set; }

        public string AccountName { get; set; }

        [Required, StringLength(3)]
        public string CurrencyCode { get; set; }

        public Bank Bank { get; set; }
    }
}