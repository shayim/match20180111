using Match.Domain.Common.PartyBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Match.Repository.EntityConfig.Common.PartyBase
{
    public class IdentityDocumentConfig : IEntityTypeConfiguration<IdentityDocument>
    {
        public void Configure(EntityTypeBuilder<IdentityDocument> builder)
        {
            builder.HasKey(id => new { id.PartyId, id.TypeId, id.Num });
            builder.Property(id => id.Num).HasMaxLength(50);
            builder.Property(id => id.FileUrl).HasMaxLength(50);
        }
    }
}