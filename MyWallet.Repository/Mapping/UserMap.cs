using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWallet.Domain.Entities;

namespace MyWallet.Repository.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.IdentificationDocument).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Login).IsRequired().HasMaxLength(45);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(45);
            builder.Property(x => x.RegistrationDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(x => x.LoginDate).IsRequired();
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.BirthDate).IsRequired();

            builder.HasIndex(x => x.IdentificationDocument).IsUnique();
            builder.HasIndex(x => x.Login).IsUnique();
        }
    }
}
