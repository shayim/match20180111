using Match.Repository.EntityConfig.BusinessParty;
using Match.Repository.EntityConfig.Common.Business;
using Match.Repository.EntityConfig.Common.Geolocation;
using Match.Repository.EntityConfig.Common.PartyBase;
using Microsoft.EntityFrameworkCore;

namespace Match.Repository
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder AddBusinessPartyTypesConfiguration(this ModelBuilder modelBuilder)
        {
            // business party
            modelBuilder.ApplyConfiguration(new ClientConfig());
            modelBuilder.ApplyConfiguration(new SalesPersonConfig());
            modelBuilder.ApplyConfiguration(new ClientSalesPersonConfig());
            modelBuilder.ApplyConfiguration(new EmployeeConfig());

            // common business
            modelBuilder.ApplyConfiguration(new EmploymentContractConfig());

            // common party base
            modelBuilder.ApplyConfiguration(new PartyConfig());
            modelBuilder.ApplyConfiguration(new CompanyConfig());
            modelBuilder.ApplyConfiguration(new PersonConfig());
            modelBuilder.ApplyConfiguration(new IdentityDocumentConfig());

            modelBuilder.ApplyConfiguration(new BankAccountConfig());
            modelBuilder.ApplyConfiguration(new CurrencyConfig());
            modelBuilder.ApplyConfiguration(new PartyAddressConfig());
            modelBuilder.ApplyConfiguration(new SocialMediaAccountConfig());

            modelBuilder.ApplyConfiguration(new PartyContactConfig());
            modelBuilder.ApplyConfiguration(new BankConfig());

            // common geolocations
            modelBuilder.ApplyConfiguration(new ZipcodeConfig());

            return modelBuilder;
        }
    }
}