

using MyWallet.Domain.Entities;

namespace MyWallet.App.Others
{
    public static class UserSession
    {
        private static User? _currentUser;

        public static User? CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }

        // Atalho útil para pegar o ID sem precisar verificar nulo toda hora
        // Se não tiver ninguém logado, retorna 0
        public static int UserId => _currentUser?.Id ?? 0;

        // Atalho para pegar o Nome
        public static string UserName => _currentUser?.Name ?? "Desconhecido";
        public static void Logout()
        {
            _currentUser = null;
        }

    }

}
