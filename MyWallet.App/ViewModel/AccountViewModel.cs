using MyWallet.Domain.Entities;
using MyWallet.Domain.Enum;


namespace MyWallet.App.ViewModel
{
    public class AccountViewModel
    {
        public string Name { get; set; }
        public decimal InitialBalance { get; set; }
        public decimal CreditLimit { get; set; }
        public AccountType Type { get; set; }
        public Bank Bank { get; set; }
    }
}
