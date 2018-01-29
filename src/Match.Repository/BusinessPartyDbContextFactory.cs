using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Match.Repository
{
    public class BusinessPartyDbContextFactory : IDesignTimeDbContextFactory<BusinessPartyDbContext>
    {
        public BusinessPartyDbContext CreateDbContext(string[] args)
        {
            var contextOptionsBuilder = new DbContextOptionsBuilder<BusinessPartyDbContext>();
            contextOptionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MatchDb-20180111;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new BusinessPartyDbContext(contextOptionsBuilder.Options);
        }
    }
}