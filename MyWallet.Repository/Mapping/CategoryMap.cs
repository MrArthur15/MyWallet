using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWallet.Domain.Entities;

namespace MyWallet.Repository.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Type).IsRequired().HasConversion<string>().HasMaxLength(12);
            builder.Property(x => x.Priority).IsRequired().HasConversion<string>().HasMaxLength(12);
            builder.Property(x => x.BudgetLimit);
            builder.HasOne(x => x.User);
            //builder.HasOne(x => x.User).WithOne().HasForeignKey<Category>(x => x.User.Id).IsRequired(false);
        }
    }
}
