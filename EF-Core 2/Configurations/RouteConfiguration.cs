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
    internal class RouteConfiguration : IEntityTypeConfiguration<Route>
    {
        public void Configure(EntityTypeBuilder<Route> builder)
        {

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("RouteId").UseIdentityColumn();

            builder.Property(e => e.Distance).HasColumnType("decimal(10,2)");

            builder.Property(e => e.Destination).HasMaxLength(50).IsRequired();

            builder.Property(e => e.Origin).HasMaxLength(50).IsRequired();

            builder.Property(e => e.Classification).HasMaxLength(30).IsRequired(false);
        }
    }
}
