using System;
using System.ComponentModel.DataAnnotations;
using Match.Domain.Common.PartyBase;

namespace Match.Domain.Common.Business
{
    public class EmploymentContract : IEffectiveDocument
    {
        public EmploymentContract(string num, Person person, DateTime effective, DateTime? due, string fileUrl = null)
        {
            EmployeeId = person.Id;
            EffectiveFrom = effective;
            EffectiveTo = due;
            Num = num;
            FileUrl = fileUrl;
        }

        public Guid EmployeeId { get; set; }

        [Required, StringLength(20)]
        public string Num { get; set; }

        [Required]
        public DateTime? EffectiveFrom { get; set; }

        public DateTime? EffectiveTo { get; set; }

        public DateTime? IssueDate { get; set; }

        [StringLength(50)]
        public string FileUrl { get; set; }

        public bool IsEffective => IsActive && DateTime.Now >= EffectiveFrom && DateTime.Now <= EffectiveTo;

        public bool IsActive { get; set; }
    }
}