using FluentValidation;
using MyWallet.Domain.Entities;

namespace MyWallet.Service.Validators
{
    public class BankValidators : AbstractValidator<Bank>
    {
        public BankValidators()
        {
            RuleFor(b => b.Name)
               .NotEmpty().WithMessage("Nome do banco é obrigatorio!");
            RuleFor(b => b.User)
                .NotEmpty().WithMessage("Usuario do banco é obrigatorio!");
        }
    }
}
