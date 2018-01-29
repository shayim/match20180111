using System;

namespace Match.Domain.Common.PartyBase
{
    public class SocialMediaAccount
    {
        protected SocialMediaAccount() { }
        public SocialMediaAccount(SocialMediaType type, string account)
        {
            Type = type;
            Account = account;
        }

        // key
        public Guid PersonId { get; set; }

        // key
        public int TypeId { get; set; }

        // key
        public string Account { get; set; }

        public SocialMediaType Type { get; set; }
    }
}