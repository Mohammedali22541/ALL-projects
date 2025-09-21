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
    internal class AirLinePhonesConfiguration : IEntityTypeConfiguration<Airline_phones>
    {
        public void Configure(EntityTypeBuilder<Airline_phones> builder)
        {
            builder.HasKey(e=>e.Al_Id);
            builder.Property(e=>e.Al_Id).UseIdentityColumn();
            builder.ToTable(e => e.HasCheckConstraint("PhoneNumber", "([Phones] IS NULL OR [Phones] LIKE '01%')"));

        }
    }
}
