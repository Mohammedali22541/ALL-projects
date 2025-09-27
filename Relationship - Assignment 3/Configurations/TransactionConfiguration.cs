using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Relationship___Assignment_3.Models;

namespace EF_Core_2.Configurations
{
    internal class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
             builder.HasKey(e => e.TransactionId);

            builder.Property(e => e.TransactionId).HasColumnName("Transaction_Id").UseIdentityColumn();

            builder.Property(e => e.TransactionDescription).HasMaxLength(150).IsRequired(false);

            builder.Property(e => e.TransactionAmount).IsRequired();

            builder.Property(e => e.TransactionDate).HasDefaultValueSql("GetDate()");


            builder.HasOne(t=>t.Airline).WithMany(a=>a.Transactions)
                .HasForeignKey(t=>t.AirlineID);
        }
    }
}
