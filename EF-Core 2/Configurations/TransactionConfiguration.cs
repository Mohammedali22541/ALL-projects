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
    internal class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
             builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("TransactionId").UseIdentityColumn();

            builder.Property(e => e.Description).HasMaxLength(150).IsRequired(false);

            builder.Property(e => e.Amout).IsRequired();

            builder.Property(e => e.Date).HasDefaultValueSql("GetDate()");

            builder.Property(e => e.AL_Id).HasColumnName("AirLineId");   
        }
    }
}
