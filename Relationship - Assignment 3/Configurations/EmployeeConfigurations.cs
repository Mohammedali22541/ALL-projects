using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Relationship___Assignment_3.Models;

namespace EF_Core_2.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.EmpId);
            builder.Property(e => e.EmpId).HasColumnName("EmployeeId");
            builder.Property(e => e.EmpName).HasColumnName("EmployeeName").HasMaxLength(40).IsRequired();
            builder.Property(e=>e.EmpAddress).IsRequired(false).HasMaxLength(60);

            builder.Property(e => e.Gender).HasMaxLength(10).IsRequired(false);

            builder.Property(e => e.Position).HasMaxLength(30).IsRequired();

            builder.Property(e => e.Year).HasColumnName("BirthYear");

            builder.Property(e => e.Month).HasColumnName("BirthMonth");

            builder.Property(e => e.Day).HasColumnName("BirthDay");

            builder.HasOne(e => e.Airline).WithMany(a => a.Employees)
                .HasForeignKey(e => e.AirlineID).IsRequired();

        }
    }
}
