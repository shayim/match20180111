using System;
using System.ComponentModel.DataAnnotations;

namespace Match.Mia.Webapi.ViewModels.Common
{
    public class BankAccountNewVm
    {
        public int? BankId { get; set; }

        [Required]
        public string BankName { get; set; }

        [Required]
        public string AccountNumber { get; set; }

        [Required]
        public string AccountName { get; set; }

        [Required, StringLength(3)]
        public string CurrencyCode { get; set; }
    }
}