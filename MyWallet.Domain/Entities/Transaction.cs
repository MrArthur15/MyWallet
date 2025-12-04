
using MyWallet.Domain.Base;
using MyWallet.Domain.Enum;

namespace MyWallet.Domain.Entities
{
    public class Transaction : BaseEntity<int>
    {
        public Transaction() { }
        
        public Transaction(int id, string description, decimal amount, DateTime transactionDate, bool isPaid,
                          TransactionType type, PaymentMethod paymentType, User user, Account account, Category category) : base(id)
        {
            Description = description;
            Amount = amount;
            TransactionDate = transactionDate;
            IsPaid = isPaid;
            Type = type;
            PaymentType = paymentType;
            User = user;
            Account = account;
            Category = category;
        }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public bool IsPaid { get; set; }
        public TransactionType Type { get; set; }
        public PaymentMethod PaymentType { get; set; }
        public User User { get; set; }
        public Account Account { get; set; }
        public Category? Category { get; set; }

    }
}
