using MyWallet.Domain.Base;
using MyWallet.Domain.Enum;

namespace MyWallet.Domain.Entities
{
    public class Category : BaseEntity<int>
    {
        public Category() { }
        
        public Category(int id, string name, TransactionType type, PriorityLevel priority, decimal budgetLimit, User user) : base(id)
        {
            Name = name;
            Type = type;
            Priority = priority;
            BudgetLimit = budgetLimit;
            User = user;
        }

        public string Name { get; set; }
        public TransactionType Type { get; set; }
        public PriorityLevel Priority { get; set; }
        public decimal? BudgetLimit { get; set; }
        public User User { get; set; }
    }
}
