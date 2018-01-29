using Match.Domain.Common.Geolocations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Match.Repository.EntityConfig.Common.Geolocation
{
    public class ZipcodeConfig : IEntityTypeConfiguration<ZipCode>
    {
        public void Configure(EntityTypeBuilder<ZipCode> builder)
        {
            builder.HasKey(c => new { c.CityId, c.Code });
            builder.Property(c => c.Code).HasMaxLength(10);
        }
    }
}