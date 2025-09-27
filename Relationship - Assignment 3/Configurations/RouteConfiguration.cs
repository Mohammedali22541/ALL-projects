using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Relationship___Assignment_3.Models;

namespace EF_Core_2.Configurations
{
    internal class RouteConfiguration : IEntityTypeConfiguration<Route>
    {
        public void Configure(EntityTypeBuilder<Route> builder)
        {

            builder.HasKey(e => e.RouteId);

            builder.Property(e => e.RouteId).HasColumnName("RouteId").UseIdentityColumn();

            //builder.Property(e => e.Distance).HasColumnType("decimal(10,2)");

            builder.Property(e => e.Distination).HasMaxLength(50).IsRequired();

            builder.Property(e => e.Orgin).HasMaxLength(50).IsRequired();

            builder.Property(e => e.Classification).HasMaxLength(30).IsRequired(false);
        }
    }
}
