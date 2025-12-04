using MyWallet.Domain.Base;
using MyWallet.Domain.Enum;

namespace MyWallet.Domain.Entities
{
    public class Subscription : BaseEntity<int>
    {
        public Subscription() { }

        public Subscription(int id, string name, decimal price, bool isActive, Frequency frequency, 
                            DateTime nextDueDate, User user, Account account, Category category) : base(id)
        {
            Name = name;
            Price = price;
            IsActive = isActive;
            Frequency = frequency;
            NextDueDate = nextDueDate;
            User = user;
            Account = account;
            Category = category;

        }
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
