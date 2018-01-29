using Match.Domain.BusinessParties;
using Match.Domain.Common.Business;
using Match.Domain.Common.Geolocations;
using Match.Domain.Common.PartyBase;
using Microsoft.EntityFrameworkCore;

namespace Match.Repository
{
    public class BusinessPartyDbContext : DbContext
    {
        public BusinessPartyDbContext(DbContextOptions<BusinessPartyDbContext> options) : base(options)
        { }

        // business entities
        public DbSet<Client> Client { get; set; }

        public DbSet<SalesPerson> SalesPerson { get; set; }

        // common
        public DbSet<BusinessSection> BusinessSection { get; set; }

        public DbSet<Party> Party { get; set; }

        public DbSet<Department> Department { get; set; }

        public DbSet<IdentityDocumentType> IdentityDocumentType { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<AddressType> AddressType { get; set; }
        public DbSet<District> District { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddBusinessPartyTypesConfiguration();

            base.OnModelCreating(modelBuilder);
        }
    }
}