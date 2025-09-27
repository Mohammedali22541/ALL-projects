using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Relationship___Assignment_3.Models;

namespace EF_Core_2.Configurations
{
    internal class AircraftConfiguration : IEntityTypeConfiguration<Aircraft>
    {
        public void Configure(EntityTypeBuilder<Aircraft> builder)
        {
            builder.ToTable("Aircrafts", tb =>
            {
               
                tb.HasCheckConstraint(
                   "CK_Aircraft_Capacity",
                   "[Capacity] > 0 AND [Capacity] <= 250"
               );

            });
            builder.HasKey(a => a.Id);
            builder.Property(e => e.Id).UseIdentityColumn(10, 10);

            builder.Property(e => e.Model).HasMaxLength(25).IsRequired();

          
            builder.HasOne(a=>a.Airline).WithMany(a=>a.Aircraft).IsRequired()
                .HasForeignKey(a=>a.AirlineID);

            builder.OwnsOne(e => e.Crew, cc =>
            {
                cc.Property(x => x.MajorPilot)
                  .HasMaxLength(50)
                  .HasColumnName("MajorPilot").IsRequired(false);

                cc.Property(x => x.AssistantPilot)
                  .HasMaxLength(50)
                  .HasColumnName("AssistantPilot").IsRequired(false);

                cc.Property(x => x.Host1)
                  .HasMaxLength(50)
                  .HasColumnName("Host1").IsRequired(false);

                cc.Property(x => x.Host2)
                  .HasMaxLength(50)
                  .HasColumnName("Host2").IsRequired(false);
            });
        }
    }
}
