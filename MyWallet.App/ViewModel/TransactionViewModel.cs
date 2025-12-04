using MyWallet.Domain.Entities;
using MyWallet.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWallet.App.ViewModel
{
    public class TransactionViewModel
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public bool IsPaid { get; set; }
        public TransactionType Type { get; set; }
        public PaymentMethod PaymentType { get; set; }
        public User User { get; set; }
        public Account Account { get; set; }
        public Category Category { get; set; }
    }
}
