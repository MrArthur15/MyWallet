


using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using MyWallet.App.Infra;
using MyWallet.App.Others;
using MyWallet.App.Register;
using MyWallet.App.ViewModel;
using MyWallet.Domain.Base;
using MyWallet.Domain.Entities;
using MyWallet.Domain.Enum;
using ReaLTaiizor.Forms;

namespace MyWallet.App
{

    public partial class MainForm : LostForm
    {

        private IBaseService<Account> _accountService;
        private IBaseService<Bank> _bankService;
        private IBaseService<Category> _categoryService;
        private IBaseService<Subscription> _subscriptionService;




        public MainForm(IBaseService<Account> accountService, IBaseService<Bank> bankService, IBaseService<Category> categoryService, IBaseService<Subscription> subscriptionService)
        {
            _accountService = accountService;
            _bankService = bankService;
            _categoryService = categoryService;
            _subscriptionService = subscriptionService;

            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;
            dataGridView2.MultiSelect = false;
            dataGridView3.MultiSelect = false;
            dataGridView4.MultiSelect = false;


        }


        #region Grid

        private void CarregarGridContas()
        {
            try
            {
                var includes = new List<string> { "User", "Bank" };
                var contas = _accountService.Get<AccountViewModel>(includes);
                var contasFiltradas = contas
                    .Where(c => c.User != null && c.User.Id == UserSession.UserId)
                    .Select(c => new
                    {
                        Id = c.Id,
                        Nome = c.Name,
                        Saldo = c.InitialBalance,
                        Limite = c.CreditLimit,
                        Banco = c.Bank?.Name ?? "N/A",

                        Tipo = c.Type switch
                        {
                            AccountType.Checking => "Conta Corrente",
                            AccountType.Savings => "Poupança",
                            AccountType.CreditCard => "Cartão de Crédito",
                            _ => c.Type.ToString() 
                        }
                    })
                    .ToList();

                dataGridView1.DataSource = contasFiltradas;

                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.Columns["Id"].Visible = false;

                    dataGridView1.Columns["Saldo"].DefaultCellStyle.Format = "C2";
                    dataGridView1.Columns["Limite"].DefaultCellStyle.Format = "C2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar contas: " + ex.Message);
            }
        }
        private void CarregarGridBancos()
        {
            try
            {
                var includes = new List<string> { "User" };
                var bancos = _bankService.Get<BankViewModel>(includes);

                var bancosFiltrados = bancos
                    .Where(b => b.User != null && b.User.Id == UserSession.UserId)
                    .Select(b => new
                    {
                        Id = b.Id,
                        Nome = b.Name,
                        Codigo = b.Code
                    })
                    .ToList();

                dataGridView2.DataSource = bancosFiltrados;

                if (dataGridView2.Columns.Count > 0)
                {
                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView2.Columns["Id"].Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar: " + ex.Message);
            }
        }
        private void CarregarGridCategorias()
        {
            try
            {
                var includes = new List<string> { "User" };
                var categorias = _categoryService.Get<CategoryViewModel>(includes);
                var categoriasFiltradas = categorias
                    .Where(c => c.User != null && c.User.Id == UserSession.UserId)
                    .Select(c => new
                    {
                        Id = c.Id,
                        Nome = c.Name,
                        Limite = c.BudgetLimit,

                        Prioridade = c.Priority switch
                        {
                            PriorityLevel.Essential => "Essencial",
                            PriorityLevel.Superfluous => "Supérfluo",
                            PriorityLevel.None => "Nenhuma",
                            _ => c.Priority.ToString()
                        },

                        Tipo = c.Type switch
                        {
                            TransactionType.Revenue => "Receita",
                            TransactionType.Expense => "Despesa",
                            TransactionType.Transfer => "Transferência",
                            _ => c.Type.ToString()
                        }
                    })
                    .ToList();

                dataGridView3.DataSource = categoriasFiltradas;

                if (dataGridView3.Columns.Count > 0)
                {
                    dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView3.Columns["Id"].Visible = false;
                    dataGridView3.Columns["Limite"].DefaultCellStyle.Format = "C2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar: " + ex.Message);
            }
        }
        private void CarregarGridAssinaturas()
        {
            try
            {
                var includes = new List<string> { "User", "Account", "Category" };
                var assinaturas = _subscriptionService.Get<Subscription>(includes);

                var assinaturasFiltradas = assinaturas
                    .Where(s => s.User != null && s.User.Id == UserSession.UserId)
                    .Select(s => new
                    {
                        Id = s.Id,
                        Nome = s.Name,
                        Valor = s.Price,

                        Frequencia = s.Frequency switch
                        {
                            Frequency.Monthly => "Mensal",
                            Frequency.Yearly => "Anual",
                            _ => s.Frequency.ToString()
                        },

                        Ativo = s.IsActive ? "Sim" : "Não",
                        ProximoVencimento = s.NextDueDate,
                        Conta = s.Account?.Name ?? "N/A",
                        Categoria = s.Category?.Name ?? "N/A"
                    })
                    .ToList();

                dataGridView4.DataSource = assinaturasFiltradas;

                if (dataGridView4.Columns.Count > 0)
                {
                    dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView4.Columns["Id"].Visible = false;
                    dataGridView4.Columns["Valor"].DefaultCellStyle.Format = "C2";
                    dataGridView4.Columns["ProximoVencimento"].DefaultCellStyle.Format = "dd/MM/yyyy";

                    // Ajuste dos títulos das colunas
                    dataGridView4.Columns["ProximoVencimento"].HeaderText = "Vencimento";
                    dataGridView4.Columns["Frequencia"].HeaderText = "Frequência";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar assinaturas: " + ex.Message);
            }
        }
        #endregion

        #region Deletar
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

        private void btnDeletar2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var id = (int)dataGridView2.SelectedRows[0].Cells["Id"].Value;

                if (MessageBox.Show("Deseja excluir esta conta?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        _bankService.Delete(id);
                        CarregarGridBancos();
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
        private void btnDeletar3_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                var id = (int)dataGridView3.SelectedRows[0].Cells["Id"].Value;



                if (MessageBox.Show("Deseja realmente excluir esta categoria?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        _categoryService.Delete(id);
                        CarregarGridCategorias();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha.");
            }
        }

        private void btnDeletar4_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
                var id = (int)dataGridView4.SelectedRows[0].Cells["Id"].Value;

                if (MessageBox.Show("Deseja realmente excluir esta assinatura?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        _subscriptionService.Delete(id);

                        CarregarGridAssinaturas();
                        MessageBox.Show("Assinatura excluída com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao excluir: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma assinatura para excluir.");
            }
        }
        #endregion

        #region Editar
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

        private void btnEditar2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var id = (int)dataGridView2.SelectedRows[0].Cells["Id"].Value;

                var formBanco = ConfigureDI.serviceProvider.GetRequiredService<BankForm>();

                formBanco.SetEditMode(id);

                if (formBanco.ShowDialog() == DialogResult.OK)
                {
                    CarregarGridBancos();
                }
            }
            else
            {
                MessageBox.Show("Selecione um banco para editar.");
            }
        }
        private void btnEditar3_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                var id = (int)dataGridView3.SelectedRows[0].Cells["Id"].Value;

                var formCategoria = ConfigureDI.serviceProvider.GetRequiredService<CategoryForm>();

                formCategoria.SetEditMode(id);

                if (formCategoria.ShowDialog() == DialogResult.OK)
                {
                    CarregarGridCategorias();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma categoria para editar.");
            }
        }
        private void btnEditar4_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
               
                var id = (int)dataGridView4.SelectedRows[0].Cells["Id"].Value;

                var formAssinatura = ConfigureDI.serviceProvider.GetRequiredService<SubscriptionForm>();

                
                formAssinatura.SetEditMode(id);

                if (formAssinatura.ShowDialog() == DialogResult.OK)
                {
                    CarregarGridAssinaturas();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma assinatura para editar.");
            }
        }
        #endregion

        #region Criar
        private void btnCriar1_Click(object sender, EventArgs e)
        {
            var formConta = ConfigureDI.serviceProvider.GetService<AccountForm>();


            if (formConta.ShowDialog() == DialogResult.OK)
            {

                CarregarGridContas();
            }
        }
        private void btnCriar2_Click(object sender, EventArgs e)
        {
            var formBanco = ConfigureDI.serviceProvider.GetService<BankForm>();

            if (formBanco.ShowDialog() == DialogResult.OK)
            {
                CarregarGridBancos();
            }
        }

        private void btnCriar3_Click(object sender, EventArgs e)
        {
            var formCategoria = ConfigureDI.serviceProvider.GetService<CategoryForm>();

            if (formCategoria.ShowDialog() == DialogResult.OK)
            {
                CarregarGridCategorias();
            }
        }

        private void btnCriar4_Click(object sender, EventArgs e)
        {
            var formAssinatura = ConfigureDI.serviceProvider.GetService<SubscriptionForm>();

            if (formAssinatura.ShowDialog() == DialogResult.OK)
            {
                CarregarGridAssinaturas();
            }
        }
        #endregion

        #region Load
        private void tabPageAccount_Enter(object sender, EventArgs e)
        {
            CarregarGridContas();

        }

        private void tabPageBank_Enter(object sender, EventArgs e)
        {
            CarregarGridBancos();
        }

        private void tabPageCategory_Enter(object sender, EventArgs e)
        {
            CarregarGridCategorias();
        }
        private void tabPageSubs_Enter(object sender, EventArgs e)
        {
            CarregarGridAssinaturas();
        }
        #endregion

        private void airTabPage1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var tabControl = sender as ReaLTaiizor.Controls.AirTabPage;


            if (tabControl == null) return;


            if (tabControl.SelectedTab == tabPageLogout)
            {
                var resultado = MessageBox.Show("Deseja realmente sair do sistema?", "Logout",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Limpa sessão
                    UserSession.Logout();


                    var homeForm = new HomeForm();

                    this.Hide();
                    homeForm.ShowDialog();
                    this.Close();
                }
                else
                {

                    tabControl.SelectedTab = tabPageHome;
                }
            }
        }

        public void AtualizarDadosDoUsuarioLogado()
        {


            if (UserSession.CurrentUser != null)
            {

                lblUsuario.Text = $"Bem-vindo, {UserSession.CurrentUser.Name}!";


            }
            else
            {
                lblUsuario.Text = "Usuário Desconhecido";
            }
        }

    }
}
