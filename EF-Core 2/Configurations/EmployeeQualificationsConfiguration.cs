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
    internal class EmployeeQualificationsConfiguration : IEntityTypeConfiguration<Emp_Qualifications>
    {
        public void Configure(EntityTypeBuilder<Emp_Qualifications> builder)
        {
            builder.ToTable(" EmployeeQualifications");
            builder.HasKey(e => e.Emp_Id);
            builder.Property(e => e.Qualifications).IsRequired();
        }
    }
}
