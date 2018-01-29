using System;
using Match.Domain.Common.Business;

namespace Match.Domain.Common.PartyBase
{
    public class IdentityDocument : IEffectiveDocument
    {
        protected IdentityDocument() { }
        public IdentityDocument(Party party, IdentityDocumentType type, string num, DateTime? effective = null, DateTime? due = null, string fileUrl = null)
        {
            PartyId = party.Id;
            Type = type;
            Num = num;
            EffectiveFrom = effective;
            EffectiveTo = due;
            FileUrl = fileUrl;
        }

        // key
        public Guid PartyId { get; set; }

        // key
        public int TypeId { get; set; }

        // key
        public string Num { get; set; }

        public IdentityDocumentType Type { get; set; }

        public string FileUrl { get; set; }

        public DateTime? EffectiveFrom { get; set; }

        public DateTime? EffectiveTo { get; set; }

        public DateTime? IssueDate { get; set; }

        public bool IsEffective => IsActive && (DateTime.Now >= EffectiveFrom && DateTime.Now <= EffectiveTo);

        public bool IsActive { get; set; } = true;
    }
}