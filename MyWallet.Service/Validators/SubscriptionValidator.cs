using FluentValidation;
using MyWallet.Domain.Entities;

namespace MyWallet.Service.Validators
{
    public class SubscriptionValidator : AbstractValidator<Subscription>
    {
        public SubscriptionValidator()
        {
            RuleFor(s => s.Name)
               .NotEmpty().WithMessage("Nome da assinatura é obrigatorio!");
            RuleFor(s => s.Price)
                    .NotEmpty().WithMessage("Valor da assinatura é obrigatorio!");
            RuleFor(s => s.Frequency)
                    .NotEmpty().WithMessage("Frequncia da assinatura é obrigatorio!");
            RuleFor(s => s.User)
                    .NotEmpty().WithMessage("Usuario da assinatura é obrigatorio!");
            RuleFor(s => s.Account)
                    .NotEmpty().WithMessage("Conta da assinatura é obrigatorio!");
            RuleFor(s => s.Category)
                    .NotEmpty().WithMessage("Categoria da assinatura é obrigatorio!");
        }
    }
}
