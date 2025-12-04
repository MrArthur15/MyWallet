using MyWallet.Domain.Entities;
using MyWallet.Domain.Enum;

namespace MyWallet.App.ViewModel
{
    public class BankViewModel
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public User User { get; set; }
    }
}
