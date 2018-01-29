using System;

namespace Match.Mia.Webapi.ViewModels.Common
{
    public class BankAccountVm
    {
        // key
        public Guid ParyId { get; set; }

        // key
        public int BankId { get; set; }

        // key
        public string AccountNumber { get; set; }

        public string BankName { get; set; }
        public string AccountName { get; set; }
        public string CurrencyCode { get; set; }
    }
}