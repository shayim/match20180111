using Match.Domain.BusinessParties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Match.Repository.EntityConfig.BusinessParty
{
    public class ClientSalesPersonConfig : IEntityTypeConfiguration<ClientSalesPerson>
    {
        public void Configure(EntityTypeBuilder<ClientSalesPerson> builder)
        {
            builder.HasKey(clientSalesPerson => new { clientSalesPerson.ClientId, clientSalesPerson.SalesPersonId });

            builder.HasOne(clientSalesPerson => clientSalesPerson.Client)
                .WithMany(client => client.CurrentSalesPersons)
                .HasForeignKey(clientSalesPerson => clientSalesPerson.ClientId).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(clientSalePerson => clientSalePerson.SalesPerson)
                .WithMany(salesPerson => salesPerson.Clients)
                .HasForeignKey(clientSalesPerson => clientSalesPerson.SalesPersonId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}