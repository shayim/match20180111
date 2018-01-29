using Match.Domain.Common.PartyBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Match.Repository.EntityConfig.Common.PartyBase
{
    public class SocialMediaAccountConfig : IEntityTypeConfiguration<SocialMediaAccount>
    {
        public void Configure(EntityTypeBuilder<SocialMediaAccount> builder)
        {
            builder.HasKey(s => new { s.PersonId, s.TypeId, s.Account });
            builder.Property(s => s.Account).HasMaxLength(50);
        }
    }
}