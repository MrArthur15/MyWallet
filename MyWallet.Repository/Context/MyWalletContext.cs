using Microsoft.EntityFrameworkCore;
using MyWallet.Domain.Entities;
using MyWallet.Repository.Mapping;

namespace MyWallet.Repository.Context
{
    public class MyWalletContext : DbContext
    {
        public MyWalletContext(DbContextOptions<MyWalletContext>? options=null) :
            base(options)
        {
            Database.EnsureCreated(); // Cria o banco caso não exista
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySQL("server=localhost;database=MyWallet;user=root;password=");


        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Account>(new AccountMap().Configure);
            modelBuilder.Entity<Bank>(new BankMap().Configure);
            modelBuilder.Entity<Category>(new CategoryMap().Configure);
            modelBuilder.Entity<Subscription>(new SubscriptionMap().Configure);
            modelBuilder.Entity<Transaction>(new TransactionMap().Configure);
            modelBuilder.Entity<User>(new UserMap().Configure);
        }
    }
}
