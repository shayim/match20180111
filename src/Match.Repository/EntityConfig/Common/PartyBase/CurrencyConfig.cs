using Match.Domain.Common.PartyBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Match.Repository.EntityConfig.Common.PartyBase
{
    public class CurrencyConfig : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.HasKey(o => o.Code);
            builder.Property(o => o.Code).HasMaxLength(3);
        }
    }
}