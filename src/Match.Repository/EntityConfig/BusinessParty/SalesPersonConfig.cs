using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Match.Domain.BusinessParties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Match.Repository.EntityConfig.BusinessParty
{
    public class SalesPersonConfig : IEntityTypeConfiguration<SalesPerson>
    {
        public void Configure(EntityTypeBuilder<SalesPerson> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasOne(s => s.Employee).WithOne().HasForeignKey<SalesPerson>(s => s.Id);
        }
    }
}