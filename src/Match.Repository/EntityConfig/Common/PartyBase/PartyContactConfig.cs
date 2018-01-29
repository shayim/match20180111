using Match.Domain.Common.PartyBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Match.Repository.EntityConfig.Common.PartyBase
{
    public class PartyContactConfig : IEntityTypeConfiguration<PartyContact>
    {
        public void Configure(EntityTypeBuilder<PartyContact> builder)
        {
            builder.HasKey(c => new { c.PartyId, c.ContactId });

            builder.HasOne(partyContact => partyContact.Party)
                .WithMany(party => party.Contacts)
                .HasForeignKey(partyContact => partyContact.PartyId).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(partyContact => partyContact.Contact)
              .WithMany()
              .HasForeignKey(partyContact => partyContact.ContactId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}