using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Relationship___Assignment_3.Models;

namespace EF_Core_2.Configurations
{
    internal class EmployeeQualificationsConfiguration : IEntityTypeConfiguration<EmployeeQualifications>
    {
        public void Configure(EntityTypeBuilder<EmployeeQualifications> builder)
        {
            builder.ToTable("EmployeeQualifications");
            builder.Property(e => e.Qualification).IsRequired();


            builder.HasOne(e=>e.Employee).WithMany(eq=>eq.EmployeeQualifications)
                .HasForeignKey(e=>e.EmpId).OnDelete(DeleteBehavior.Cascade);

            builder.HasKey(e => new
            {
                e.Qualification,
                e.EmpId
            });
        }
    }
}
