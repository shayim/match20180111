using System.Linq;
using Match.Domain.BusinessParties;
using Match.Domain.Common.Business;
using Match.Domain.Common.PartyBase;

namespace Match.Repository
{
    public class DbInitializer
    {
        public static void Seed(BusinessPartyDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.SalesPerson.Any())
            {
                var department = context.Department.Find(1);
                var howard = new SalesPerson(new Employee(new Person("王海", "howard", Gender.Male), department, "1001"));

                context.Add(howard);
                context.SaveChanges();
            }
        }
    }
}