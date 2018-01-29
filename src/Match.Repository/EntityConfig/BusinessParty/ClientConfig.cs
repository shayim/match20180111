using Match.Domain.BusinessParties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Match.Repository.EntityConfig.BusinessParty
{
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasOne(client => client.Party).WithOne().HasForeignKey<Client>(client => client.Id);
        }
    }
}