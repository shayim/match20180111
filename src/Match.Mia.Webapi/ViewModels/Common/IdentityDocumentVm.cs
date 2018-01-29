using System;

namespace Match.Mia.Webapi.ViewModels.Common
{
    public class IdentityDocumentVm
    {
        public string Type { get; set; }
        public Guid PartyId { get; set; }
        public int TypeId { get; set; }
        public string Num { get; set; }
        public string FileUrl { get; set; }
        public DateTime Effective { get; set; }
        public DateTime Due { get; set; }
    }
}