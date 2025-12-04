using MyWallet.Domain.Entities;
using MyWallet.Domain.Enum;

namespace MyWallet.App.ViewModel
{
    public class SubscripionViewModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public Frequency Frequency { get; set; }
        public DateTime NextDueDate { get; set; }
        public User User { get; set; }
        public Account Account { get; set; }
        public Category Category { get; set; }
    }
}
