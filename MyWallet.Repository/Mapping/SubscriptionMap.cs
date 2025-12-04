using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWallet.Domain.Entities;

namespace MyWallet.Repository.Mapping
{
    public class SubscriptionMap : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.ToTable("Subscription");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.IsActive);
            builder.Property(x => x.Frequency).IsRequired().HasConversion<string>().HasMaxLength(12);
            builder.Property(x => x.NextDueDate).IsRequired(); 
            builder.HasOne(x => x.User);
            builder.HasOne(x => x.Account);
            builder.HasOne(x => x.Category);
        }
    }
}
