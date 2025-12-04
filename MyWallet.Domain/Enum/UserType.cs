using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet.Domain.Enum
{
    public enum UserType
    {
        Individual = 1,  // Pessoa Física
        Corporate = 2,   // Pessoa Jurídica (Empresa)
        Admin = 3        // Administrador
    }
}
