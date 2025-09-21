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
    internal class AirLineConfiguration : IEntityTypeConfiguration<Airline>
    {
        public void Configure(EntityTypeBuilder<Airline> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("AirLine_Id");
            builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.Name).HasMaxLength(50).IsRequired(false);
            builder.Property(e => e.Address).IsRequired(false).HasMaxLength(100);
            builder.Property(e => e.Cont_Person).HasColumnName("CountOfPerson");
        }
    }
}
