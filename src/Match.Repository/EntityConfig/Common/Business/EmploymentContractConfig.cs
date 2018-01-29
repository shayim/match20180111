using Match.Domain.Common.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Match.Repository.EntityConfig.Common.Business
{
    public class EmploymentContractConfig : IEntityTypeConfiguration<EmploymentContract>
    {
        public void Configure(EntityTypeBuilder<EmploymentContract> builder)
        {
            builder.HasKey(e => new { e.EmployeeId, e.Num });
            builder.HasOne<Employee>().WithMany(e => e.EmploymentContracts).HasForeignKey(ec => ec.EmployeeId);
        }
    }
}