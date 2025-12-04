using MyWallet.Domain.Base;
using MyWallet.Domain.Enum;


namespace MyWallet.Domain.Entities
{
    public class Account : BaseEntity<int>
    {
        public Account() { }

        public Account(int id, string name, decimal initialBalance, decimal creditLimit, AccountType type, User user, Bank bank) : base(id)
        {
            Name = name;
            InitialBalance = initialBalance;
            CreditLimit = creditLimit;
            Type = type;
            User = user;
            Bank = bank;

        }
        public string Name { get; set; }
        public decimal InitialBalance { get; set; }
        public decimal? CreditLimit { get; set; }
        public AccountType Type { get; set; }
        public User User { get; set; }
        public Bank Bank { get; set; }

    }
}
