using Match.Domain.Common.PartyBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Match.Repository.EntityConfig.Common.PartyBase
{
    public class PartyConfig : IEntityTypeConfiguration<Party>
    {
        public void Configure(EntityTypeBuilder<Party> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasMany(party => party.Contacts)
                .WithOne(partyContact => partyContact.Party)
                .HasForeignKey(partyContact => partyContact.PartyId);
            builder.HasMany(party => party.Addresses).WithOne().HasForeignKey(partyAddress => partyAddress.PartyId);
            builder.HasMany(party => party.BankAccounts).WithOne().HasForeignKey(bankAccount => bankAccount.PartyId);
            builder.HasMany(party => party.IdentityDocuments).WithOne().HasForeignKey(identityDocument => identityDocument.PartyId);
            builder.HasDiscriminator(party => party.PartyType).HasValue<Company>((int)PartyType.Company).HasValue<Person>((int)PartyType.Person);
        }
    }
}