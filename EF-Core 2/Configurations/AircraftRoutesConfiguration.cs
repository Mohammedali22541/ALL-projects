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
    internal class AircraftRoutesConfiguration : IEntityTypeConfiguration<Aircraft_Routes>
    {
        public void Configure(EntityTypeBuilder<Aircraft_Routes> builder)
        {
            builder.HasKey(e => new { e.AC_Id, e.Route_Id });
            builder.Property(e => e.AC_Id).HasColumnName("AirCraft_Id");
            builder.Property(e => e.Departure).HasMaxLength(50);
            builder.Property(e => e.Num_Of_Pass).HasColumnName("NumberOfPassenger");
            builder.ToTable( e => e.HasCheckConstraint("AircraftRoutesNumsOfPassenger",
                "[NumberOfPassenger] between 0 And 250"));
            builder.Property(e => e.Price).HasPrecision(10, 3);
            builder.Property(e => e.Arrival).HasDefaultValueSql("GetDate()");

        }
    }
}
