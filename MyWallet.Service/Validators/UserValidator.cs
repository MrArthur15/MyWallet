using FluentValidation;
using MyWallet.Domain.Entities;
using MyWallet.Domain.Enum;

namespace MyWallet.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator() 
        { 
            RuleFor(u => u.Name)
               .NotEmpty().WithMessage("Nome do usuário é obrigatorio!");
            RuleFor(u => u.IdentificationDocument)
               .Must(BeAValidCNPJ).When(d => d.Type  == UserType.Corporate).WithMessage("Please put a valid CNPJ!");
            RuleFor(d => d.IdentificationDocument)
                .Must(BeAValidCPF).When(d => d.Type == UserType.Individual).WithMessage("Please put a valid CPF!");
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
        private bool BeAValidCNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

        private bool BeAValidCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
    }
}
