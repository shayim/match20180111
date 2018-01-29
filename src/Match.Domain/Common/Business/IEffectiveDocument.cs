using System;

namespace Match.Domain.Common.Business
{
    public interface IEffectiveDocument
    {
        string Num { get; set; }

        DateTime? EffectiveFrom { get; set; }

        DateTime? EffectiveTo { get; set; }

        DateTime? IssueDate { get; set; }

        string FileUrl { get; set; }

        bool IsActive { get; set; }

        bool IsEffective { get; }
    }
}