using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Match.Domain.Common.PartyBase
{
    public class Bank
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string SwiftCode { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        public int? ParentBankId { get; set; }

        public Bank ParentBank { get; set; }

        public ICollection<Bank> SubBranches { get; set; } = new List<Bank>();
    }
}