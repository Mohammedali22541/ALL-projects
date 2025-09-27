using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Relationship___Assignment_3.Models;

namespace EF_Core_2.Configurations
{
    internal class AirLinePhonesConfiguration : IEntityTypeConfiguration<AirLinePhones>
    {
        public void Configure(EntityTypeBuilder<AirLinePhones> builder)
        {
            builder.ToTable("AirLinePhones", tb =>
                tb.HasCheckConstraint(
                    "CK_AirLinePhones_Format",
                    "LEN([PhoneNumber]) <=11 AND [PhoneNumber] LIKE '01%'"
                )
            );
            builder.Property(e => e.PhoneNumber)
                   .HasMaxLength(11)
                   .IsRequired();


            builder.HasOne(a => a.Airline).WithMany(ap => ap.AirLinePhones)
                .HasForeignKey(a => a.AirlineID);

            builder.HasKey(e => new
            {
                e.AirlineID,
                e.PhoneNumber,
            });
        }
    }
}
