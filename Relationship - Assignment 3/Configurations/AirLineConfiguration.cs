using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Relationship___Assignment_3.Models;

namespace EF_Core_2.Configurations
{
    internal class AirLineConfiguration : IEntityTypeConfiguration<Airline>
    {
        public void Configure(EntityTypeBuilder<Airline> builder)
        {
            builder.HasKey(e => e.AirlineID);
            builder.Property(e => e.AirlineID).HasColumnName("AirLine_Id");
            builder.Property(e => e.AirlineID).UseIdentityColumn();
            builder.Property(e => e.AirlineName).HasMaxLength(50).IsRequired(false);
            builder.Property(e => e.Address).IsRequired(false).HasMaxLength(100);
            builder.Property(e => e.ContactPerson).HasColumnName("Contact_person");


        }
    }
}
