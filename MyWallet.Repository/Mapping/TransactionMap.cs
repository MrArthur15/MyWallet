using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWallet.Domain.Entities;

namespace MyWallet.Repository.Mapping
{
    public class TransactionMap : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactio");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x => x.TransactionDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(x => x.IsPaid).IsRequired();
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.PaymentType).IsRequired();
            builder.HasOne(x => x.User);
            builder.HasOne(x => x.Account);
            builder.HasOne(x => x.Category);

        }
    }
}
