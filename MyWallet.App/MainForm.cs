


using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using MyWallet.App.Infra;
using MyWallet.App.Others;
using MyWallet.App.Register;
using MyWallet.Domain.Base;
using MyWallet.Domain.Entities;
using ReaLTaiizor.Forms;

namespace MyWallet.App
{

    public partial class MainForm : LostForm
    {
        private IBaseService<Account> _accountService;
        public MainForm(IBaseService<Account> accountService)
        {
            _accountService = accountService;
            InitializeComponent();

        }
        private void CarregarGridContas()
        {
            
                
            var contas = _accountService.Get<Account>()
                .Where(c => c.User.Id == UserSession.UserId)
                .Select(c => new
                {
                    Id = c.Id,
                    Nome = c.Name,
                    Saldo = c.InitialBalance,
                    Banco = c.Bank?.Name ?? "N/A", 
                    Tipo = c.Type
                })
                .ToList();

            dataGridView1.DataSource = contas;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["Id"].Visible = false; 
            
            
        }

        private void btnDeletar1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;

                if (MessageBox.Show("Deseja excluir esta conta?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        _accountService.Delete(id);
                        CarregarGridContas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao excluir: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma conta para excluir.");
            }
        }
        }

        private void btnEditar1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;

                var formConta = ConfigureDI.serviceProvider.GetRequiredService<AccountForm>();

                formConta.SetEditMode(id);

                if (formConta.ShowDialog() == DialogResult.OK)
                {
                    CarregarGridContas();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma conta para editar.");
            }
        }

        private void btnCriar1_Click(object sender, EventArgs e)
        {
            var formConta = ConfigureDI.serviceProvider.GetRequiredService<AccountForm>();

            
            if (formConta.ShowDialog() == DialogResult.OK)
            {
                
                CarregarGridContas();
            }
        }
    }
}
