using MyWallet.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWallet.App.ViewModel
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public string IdentificationDocument { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public UserType Type { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
