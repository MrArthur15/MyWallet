using MyWallet.Domain.Entities;
using MyWallet.Domain.Enum;

namespace MyWallet.App.ViewModel
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public TransactionType Type { get; set; }
        public PriorityLevel Priority { get; set; }
        public decimal BudgetLimit { get; set; }
        public User User { get; set; }
    }
}
