using FluentValidation;
using MyWallet.Domain.Entities;

namespace MyWallet.Service.Validators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Name)
               .NotEmpty().WithMessage("Nome da categoria é obrigatorio!");
            RuleFor(c => c.Type)
                    .NotEmpty().WithMessage("Tipo da categoria é obrigatorio!");
            RuleFor(c => c.Priority)
                    .NotEmpty().WithMessage("Prioridade da categoria é obrigatorio!");
            RuleFor(c => c.User)
                    .NotEmpty().WithMessage("Usuario da categoria é obrigatorio!");
        }
    }
}
