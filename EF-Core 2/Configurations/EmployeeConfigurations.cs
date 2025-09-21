using EF_Core_2.AirLine_Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_2.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("EmployeeId");
            builder.Property(e => e.Name).HasColumnName("EmployeeName").HasMaxLength(40).IsRequired();
            builder.Property(e=>e.Address).IsRequired(false).HasMaxLength(60);

            builder.Property(e => e.Gender).HasMaxLength(10).IsRequired(false);

            builder.Property(e => e.Position).HasMaxLength(30).IsRequired(false);

            builder.Property(e => e.BD_Year).HasColumnName("BirthYear");

            builder.Property(e => e.BD_Month).HasColumnName("BirthMonth");

            builder.Property(e => e.BD_Day).HasColumnName("BirthDay");

            builder.Property(e => e.AL_Id).HasColumnName("AirLineId");
        }
    }
}
