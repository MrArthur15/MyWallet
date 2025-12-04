using FluentValidation;
using MyWallet.Domain.Entities;

namespace MyWallet.Service.Validators
{
    public class TransactionValidator : AbstractValidator<Transaction>
    {
        public TransactionValidator()
        {
            RuleFor(t => t.Description)
              .NotEmpty().WithMessage("Descrição da transação é obrigatorio!");
            RuleFor(t => t.Amount)
              .NotEmpty().WithMessage("Valor da transação é obrigatorio!");
            RuleFor(t => t.Type)
              .NotEmpty().WithMessage("Tipo da transação é obrigatorio!");
            RuleFor(t => t.PaymentType)
              .NotEmpty().WithMessage("Tipo de pagamento da transação é obrigatorio!");
            RuleFor(t => t.User)
              .NotEmpty().WithMessage("Descrição da transação é obrigatorio!");
            RuleFor(t => t.Account)
              .NotEmpty().WithMessage("Descrição da transação é obrigatorio!");
        }
    }
}
