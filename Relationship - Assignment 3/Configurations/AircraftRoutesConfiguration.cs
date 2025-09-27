using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Relationship___Assignment_3.Models;

namespace EF_Core_2.Configurations
{
    internal class AircraftRoutesConfiguration : IEntityTypeConfiguration<AircraftRoute>
    {
        public void Configure(EntityTypeBuilder<AircraftRoute> builder)
        {
            builder.ToTable("AircraftRoute", tb =>
            {
                tb.HasCheckConstraint(
                    "CK_AircraftRoutes_Duration_Positive",
                    "[Duration] > 0"
                );
                tb.HasCheckConstraint(
                    "CK_AircraftRoutes_NumPassengers",
                    "[NumberOfPassenger] >= 0 AND [NumberOfPassenger] <= 250"
                );
            });

            builder.Property(e => e.Departure).HasMaxLength(50).IsRequired();
            //builder.Property(e => e.NumberOfPassenger).HasColumnName("NumberOfPassenger");
            builder.Property(e => e.Price).HasPrecision(18, 2);
            builder.Property(e => e.Arrival).HasDefaultValueSql("GetDate()");
            builder.Property(x => x.Duration).HasPrecision(9, 2).IsRequired();


            builder.HasOne(a => a.Aircraft).WithMany(a => a.AircraftRoutes)
                .HasForeignKey(a => a.Aircraft_Id);
            
            builder.HasOne(r=>r.Route).WithMany(a => a.AircraftRoutes)
                .HasForeignKey(r => r.RouteId);

            builder.HasKey(a => new
            {
                a.Aircraft_Id,
                a.RouteId,
            });



        }
    }
}
