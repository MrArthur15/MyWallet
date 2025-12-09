

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

       
        public static int UserId => _currentUser?.Id ?? 0;

        public static string UserName => _currentUser?.Name ?? "Desconhecido";
        public static void Logout()
        {
            _currentUser = null;

        }
    }

}
