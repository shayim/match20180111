using Match.Domain.Common.PartyBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Match.Repository.EntityConfig.Common.PartyBase
{
    public class PartyAddressConfig : IEntityTypeConfiguration<PartyAddress>
    {
        public void Configure(EntityTypeBuilder<PartyAddress> builder)
        {
            builder.HasKey(a => new { a.PartyId, a.AddressId });
            builder.HasOne(p => p.Address).WithMany().HasForeignKey(p => p.AddressId);
        }
    }
}