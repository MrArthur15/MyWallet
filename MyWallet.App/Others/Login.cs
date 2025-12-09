using MyWallet.Domain.Base;
using MyWallet.Domain.Entities;
using ReaLTaiizor.Forms;


namespace MyWallet.App.Others
{
    public partial class Login : LostForm
    {
        private readonly IBaseService<User> _userService;
        public Login(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var users = _userService.Get<User>();
            var userEncontrado = users.FirstOrDefault(u => u.Login == txtUsuaruio.Text && u.Password == txtSenha.Text);
            if (userEncontrado != null)
            {
                UserSession.CurrentUser = userEncontrado;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void btnVoltar1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); 
        }
    }
}
