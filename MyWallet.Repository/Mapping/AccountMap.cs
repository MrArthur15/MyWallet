using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWallet.Domain.Entities;
using MyWallet.Domain.Enum;
using System.Configuration;

namespace MyWallet.Repository.Mapping
{
    public class AccountMap : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Account");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Type).IsRequired().HasConversion<string>().HasMaxLength(12);
            builder.Property(x => x.InitialBalance).IsRequired();
            builder.Property(x => x.CreditLimit);
            builder.HasOne(x => x.User);
            builder.HasOne(x => x.Bank);
        }
    }
}
