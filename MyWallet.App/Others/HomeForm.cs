using MyWallet.Domain.Entities;
using ReaLTaiizor.Forms;
using Microsoft.Extensions.DependencyInjection;
using MyWallet.App.Infra;
using MyWallet.App.Register;


namespace MyWallet.App.Others
{
    public partial class HomeForm : LostForm
    {
        public HomeForm()
        {
            UserSession.Logout();
            InitializeComponent();
        }

        

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var form = ConfigureDI.serviceProvider.GetService<Login>();
            this.Hide();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                var mainForm = ConfigureDI.serviceProvider.GetRequiredService<MainForm>();
                mainForm.AtualizarDadosDoUsuarioLogado();
                mainForm.ShowDialog();

                this.Close();
            }
            else
            {
                this.Show();
            }

        }

       

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var form = ConfigureDI.serviceProvider.GetService<UserForm>();
            this.Hide();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Cadastro realizado com sucesso! Faça login para continuar.");
                var loginForm = ConfigureDI.serviceProvider.GetService<Login>();
                var loginResult = loginForm.ShowDialog();
                if (loginResult == DialogResult.OK)
                {
                    var mainForm = ConfigureDI.serviceProvider.GetRequiredService<MainForm>();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            }
            else
            {
                this.Show();
            }

        }
    }
}
