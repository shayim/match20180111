using System;

namespace Match.Mia.Webapi.ViewModels.Common.SocialMedia
{
    public class SocialMediaAccountVm
    {
        public SocialMediaAccountVm(Guid personId, int typeId, string type, string account)
        {
            PersonId = personId;
            TypeId = typeId;
            Type = type;
            Account = account;
        }

        public Guid PersonId { get; set; }
        public int TypeId { get; set; }
        public string Type { get; set; }
        public string Account { get; set; }
    }
}