using FluentValidation;
using MyWallet.Domain.Entities;

namespace MyWallet.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator() 
        { 
            RuleFor(u => u.Name)
               .NotEmpty().WithMessage("Nome do usuário é obrigatorio!");
            RuleFor(u => u.IdentificationDocument)
               .NotEmpty().WithMessage("Documento de identificação do usuário é obrigatorio!");
               //.NotEqual().WithMessage("Documento de indentificação já existe");
            RuleFor(u => u.Login)
               .NotEmpty().WithMessage("Login do usuário é obrigatorio!");
            RuleFor(u => u.Password)
                .NotEmpty().WithMessage("Sua senha não poder ser vazia")
                .MinimumLength(8).WithMessage("Sua senha deve ter no mínimo 8 caracteres.")
                .MaximumLength(16).WithMessage("Sua senha deve ter no máximo 16 caracteres.")
                .Matches(@"[A-Z]+").WithMessage("Sua senha deve conter pelo menos uma letra maiúscula.")
                .Matches(@"[a-z]+").WithMessage("Sua senha deve conter pelo menos uma letra minúscula.")
                .Matches(@"[0-9]+").WithMessage("Sua senha deve conter pelo menos um número.")
                .Matches(@"[\!\?\*\.\@]+").WithMessage("Sua senha deve conter pelo menos um caractere especial (! ? * .).");
            RuleFor(u => u.Email)
               .NotEmpty().WithMessage("Email do usuário é obrigatorio!")
               .EmailAddress().WithMessage("Email do usuário é inválido!");
            RuleFor(u => u.BirthDate)
               .NotEmpty().WithMessage("Data de nascimento do usuário é obrigatorio!");
            RuleFor(u => u.Type)
              .NotEmpty().WithMessage("Tipo do usuário é obrigatorio!");
              
        }
    }
}
