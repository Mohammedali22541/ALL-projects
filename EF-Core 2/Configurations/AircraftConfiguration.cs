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
    internal class AircraftConfiguration : IEntityTypeConfiguration<Aircraft>
    {
        public void Configure(EntityTypeBuilder<Aircraft> builder)
        {
            builder.ToTable("Aircrafts");
            builder.HasKey(a => a.Id);
            builder.Property(e => e.Id).UseIdentityColumn(10, 10);

            builder.ToTable(e => e.HasCheckConstraint("Aircrat_Capacity", "[Capacity] <= 250"));
            builder.Property(e => e.Model).HasMaxLength(25);

            builder.Property(e => e.Maj_Pilot).HasColumnName("MajorPilot");
            builder.Property(e => e.Assistant).HasMaxLength(50);
            builder.Property(e => e.Host1).HasMaxLength(50);
            builder.Property(e => e.Host2).HasMaxLength(50);
            builder.HasAlternateKey(e => e.AL_Id);
            builder.Property(propertyExpression: e => e.AL_Id).HasColumnName("AirLineId");
        }
    }
}
