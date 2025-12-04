using MyWallet.Domain.Base;
using MyWallet.Domain.Enum;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace MyWallet.Domain.Entities
{
    public class User : BaseEntity<int>
    {
        public User() { }
        public User(int id, string identificationDocument, string name, string login, string password, string email, DateTime birthDate, DateTime registrationDate, DateTime loginDate, UserType type)
        {
            Name = name;
            IdentificationDocument = identificationDocument;
            Login = login;
            Password = password;
            Email = email;
            BirthDate = birthDate;
            Type = type;
            RegistrationDate = registrationDate;
            LoginDate = loginDate;
        }
        public string Name { get; set; }
        public string IdentificationDocument { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LoginDate { get; set; }
        public UserType Type { get; set; }
        public DateTime BirthDate { get; set; }



    }
}
