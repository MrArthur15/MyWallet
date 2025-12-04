using FluentValidation;
using MyWallet.Domain.Entities;

namespace MyWallet.Service.Validators
{
    public class AccountValidator : AbstractValidator<Account>
    {
        public AccountValidator()
        {
            RuleFor(a => a.Name)
               .NotEmpty().WithMessage("Nome da conta é obrigatorio!");
            RuleFor(a => a.InitialBalance)
                    .NotEmpty().WithMessage("Quanto tem na conta (agora) é obrigatorio!");
            RuleFor(a => a.Type)
                    .NotEmpty().WithMessage("Tipo da conta é obrigatorio!");
            RuleFor(a => a.User)
                    .NotEmpty().WithMessage("Usuario da conta é obrigatorio!");
            RuleFor(a => a.Bank)
                    .NotEmpty().WithMessage("Banco da conta é obrigatorio"!);
        }
    }
}
