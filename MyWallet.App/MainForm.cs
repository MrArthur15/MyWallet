


using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using MyWallet.App.Infra;
using MyWallet.App.Others;
using MyWallet.App.Register;
using MyWallet.App.ViewModel;
using MyWallet.Domain.Base;
using MyWallet.Domain.Entities;
using MyWallet.Domain.Enum;
using MyWallet.Service.Validators;
using ReaLTaiizor.Forms;
using ScottPlot;
using Color = System.Drawing.Color;

namespace MyWallet.App
{

    public partial class MainForm : LostForm
    {

        private IBaseService<Account> _accountService;
        private IBaseService<Bank> _bankService;
        private IBaseService<Category> _categoryService;
        private IBaseService<Subscription> _subscriptionService;
        private IBaseService<Transaction> _transactionService;

        public MainForm(IBaseService<Account> accountService, IBaseService<Bank> bankService, IBaseService<Category> categoryService, IBaseService<Subscription> subscriptionService, IBaseService<Transaction> transactionService)
        {
            _accountService = accountService;
            _bankService = bankService;
            _categoryService = categoryService;
            _subscriptionService = subscriptionService;
            _transactionService = transactionService;

            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;
            dataGridView2.MultiSelect = false;
            dataGridView3.MultiSelect = false;
            dataGridView4.MultiSelect = false;
            dataGridView5.MultiSelect = false;

            AtualizarDadosDoUsuarioLogado();
            ProcessarAssinaturasVencidas();
            CarregarDashboard();
            CarregarTransacoesRecentes();
            rdoMes.Checked = true;
            rdoTodas.Checked = false;
            CarregarGridTransacoes();
            CarregarGraficos();


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ProcessarAssinaturasVencidas();
            CarregarDashboard();
            CarregarTransacoesRecentes();

            // Configura o Filtro do Relatório
            cbFiltroPeriodo.Items.Add("Este Mês");
            cbFiltroPeriodo.Items.Add("Mês Passado");
            cbFiltroPeriodo.Items.Add("Este Ano");
            cbFiltroPeriodo.Items.Add("Personalizado");
            cbFiltroPeriodo.SelectedIndex = 0;
        }
        public void AtualizarDadosDoUsuarioLogado()
        {


            if (UserSession.CurrentUser != null)
            {
                var primeiroNome = UserSession.CurrentUser.Name.Split(' ')[0];
                lblUsuario.Text = $"Bem-vindo, {primeiroNome}!";


            }
            else
            {
                lblUsuario.Text = "Usuário Desconhecido";
            }
        }

        #region Dashboard 
        private void parrotButton1_Click(object sender, EventArgs e)
        {
            ProcessarAssinaturasVencidas();
            CarregarDashboard();
            CarregarTransacoesRecentes();
            CarregarGraficos();
        }

        private void rdoMes_Click(object sender, EventArgs e)
        {
            rdoMes.Checked = true;
            rdoTodas.Checked = false;

            CarregarGridTransacoes();
        }

        private void rdoTodas_Click(object sender, EventArgs e)
        {
            rdoTodas.Checked = true;
            rdoMes.Checked = false;

            CarregarGridTransacoes();
        }
        private void CarregarTransacoesRecentes()
        {
            try
            {

                var recentes = _transactionService.Get<Transaction>(new List<string> { "Category" })
                    .Where(t => t.User.Id == UserSession.UserId)
                    .OrderByDescending(t => t.TransactionDate)
                    .Take(10)
                    .Select(t => new
                    {
                        Id = t.Id,
                        Data = t.TransactionDate,
                        Descricao = t.Description,
                        

                        Valor = t.Amount
                    })
                    .ToList();

                if (dgvRecentes != null)
                {
                    dgvRecentes.DataSource = recentes;

                    if (dgvRecentes.Columns.Count > 0)
                    {
                        dgvRecentes.Columns["Id"].Visible = false;

                        dgvRecentes.Columns["Valor"].DefaultCellStyle.Format = "C2";
                        dgvRecentes.Columns["Data"].DefaultCellStyle.Format = "dd/MM";

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar recentes: " + ex.Message);
            }
        }
        private void CarregarDashboard()
        {
            try
            {
                var userId = UserSession.UserId;
                var dataAtual = DateTime.Now;


                var contas = _accountService.Get<Account>(new List<string> { "User" })
                    .Where(c => c.User.Id == userId)
                    .ToList();

                decimal valorBaseContas = contas.Sum(c => c.InitialBalance ?? 0);


                var transacoesDoMes = _transactionService.Get<Transaction>(new List<string> { "User" })
                    .Where(t => t.User.Id == userId &&
                                t.TransactionDate.Month == dataAtual.Month &&
                                t.TransactionDate.Year == dataAtual.Year)
                    .ToList();


                decimal receitasDoMes = transacoesDoMes
                    .Where(t => t.Type == TransactionType.Revenue)
                    .Sum(t => t.Amount);

                decimal gastosPagosDoMes = transacoesDoMes
                    .Where(t => t.Type == TransactionType.Expense && t.IsPaid)
                    .Sum(t => t.Amount);

                var assinaturas = _subscriptionService.Get<Subscription>(new List<string> { "User" })
                    .Where(s => s.User.Id == userId && s.IsActive)
                    .ToList();

                decimal assinaturasPendentes = assinaturas
                    .Where(s => s.NextDueDate.Month == dataAtual.Month &&
                                s.NextDueDate.Year == dataAtual.Year &&
                                s.NextDueDate > dataAtual)
                    .Sum(s => s.Price);



                decimal saldoAtual = valorBaseContas + receitasDoMes - gastosPagosDoMes;


                decimal gastosTotalMes = gastosPagosDoMes + assinaturasPendentes;


                decimal saldoPrevisto = saldoAtual - assinaturasPendentes;



                if (lblSaldoAtual != null)
                {
                    lblSaldoAtual.Text = saldoAtual.ToString("C2");
                    lblSaldoAtual.ForeColor = saldoAtual < 0 ? Color.Red : Color.White;
                }

                if (lblSaldoPrevisto != null)
                {
                    lblSaldoPrevisto.Text = saldoPrevisto.ToString("C2");
                    lblSaldoPrevisto.ForeColor = saldoPrevisto < 0 ? Color.Red : Color.White;
                }

                if (lblGastosTotal != null) lblGastosTotal.Text = gastosTotalMes.ToString("C2");

                if (lblGastosPagos != null) lblGastosPagos.Text = gastosPagosDoMes.ToString("C2");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dashboard: " + ex.Message);
            }
        }
        private void ProcessarAssinaturasVencidas()
        {
            try
            {
                var assinaturasVencidas = _subscriptionService.Get<Subscription>(new List<string> { "User", "Account", "Category" })
                    .Where(s => s.User.Id == UserSession.UserId && s.IsActive && s.NextDueDate <= DateTime.Now)
                    .ToList();

                if (assinaturasVencidas.Count == 0) return;

                bool houveAtualizacao = false;

                foreach (var sub in assinaturasVencidas)
                {

                    while (sub.NextDueDate <= DateTime.Now)
                    {
                        var novaTransacao = new Transaction
                        {
                            Description = $"Assinatura: {sub.Name}",
                            Amount = sub.Price,
                            TransactionDate = sub.NextDueDate,
                            IsPaid = true,
                            Type = TransactionType.Expense,


                            PaymentType = PaymentMethod.CreditCard,

                            Account = sub.Account,
                            Category = sub.Category,
                            User = sub.User
                        };

                        _transactionService.Add<Transaction, Transaction, TransactionValidator>(novaTransacao);

                        if (sub.Frequency == Frequency.Monthly)
                        {
                            sub.NextDueDate = sub.NextDueDate.AddMonths(1);
                        }
                        else if (sub.Frequency == Frequency.Yearly)
                        {
                            sub.NextDueDate = sub.NextDueDate.AddYears(1);
                        }

                        houveAtualizacao = true;
                    }

                    _subscriptionService.Update<Subscription, Subscription, SubscriptionValidator>(sub);
                }

                if (houveAtualizacao)
                {
                    MessageBox.Show("Assinaturas vencidas foram lançadas automaticamente!", "MyWallet", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CarregarGridTransacoes();
                    CarregarGridAssinaturas();
                    CarregarDashboard();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao processar assinaturas: {ex.Message}");
            }
        }
        private void CarregarGraficos()
        {
            try
            {
                var corFundo = new ScottPlot.Color(21, 16, 70);
                var corTexto = ScottPlot.Colors.White;

                var dataAtual = DateTime.Now;
                var userId = UserSession.UserId;

                var transacoesDoMes = _transactionService.Get<Transaction>(new List<string> { "Category" })
                    .Where(t => t.User.Id == userId &&
                                t.TransactionDate.Month == dataAtual.Month &&
                                t.TransactionDate.Year == dataAtual.Year)
                    .ToList();

                
                if (plotPizza != null)
                {
                    plotPizza.Plot.Clear();

                    plotPizza.Plot.FigureBackground.Color = corFundo;
                    plotPizza.Plot.DataBackground.Color = corFundo;
                    plotPizza.Plot.Axes.Color(corTexto);

                    var gastosPorCategoria = transacoesDoMes
                        .Where(t => t.Type == TransactionType.Expense)
                        .GroupBy(t => t.Category != null ? t.Category.Name : "Outros")
                        .Select(g => new { Categoria = g.Key, Total = (double)g.Sum(t => t.Amount) })
                        .Where(x => x.Total > 0)
                        .OrderByDescending(x => x.Total)
                        .ToList();

                    if (gastosPorCategoria.Count > 0)
                    {
                        var fatias = new List<ScottPlot.PieSlice>();
                        var paleta = ScottPlot.Colors.Category10;
                        int i = 0;

                        foreach (var item in gastosPorCategoria)
                        {
                            fatias.Add(new ScottPlot.PieSlice
                            {
                                Value = item.Total,
                                Label = $"{item.Categoria}\n{item.Total:C2}",
                                FillColor = paleta[i % paleta.Length],
                                LabelFontColor = corTexto,
                                LabelFontSize = 12, 
                                LabelBold = true
                            });
                            i++;
                        }

                        var pie = plotPizza.Plot.Add.Pie(fatias);
                        pie.DonutFraction = 0.5;

                        pie.SliceLabelDistance = 1.05;

                        plotPizza.Plot.HideGrid();
                        plotPizza.Plot.Axes.Frameless();

                        plotPizza.Plot.Axes.Margins(0, 0);

                        plotPizza.Plot.Axes.SetLimits(-1.25, 1.25, -1.25, 1.25);
                    }
                    else
                    {
                        plotPizza.Plot.Title("Sem despesas");
                        plotPizza.Plot.Axes.Title.Label.ForeColor = corTexto;
                    }

                    plotPizza.Plot.Title("Gastos por Categoria");
                    plotPizza.Plot.Axes.Title.Label.ForeColor = corTexto;

                    plotPizza.Refresh();
                }

                
                if (plotBarras != null)
                {
                    plotBarras.Plot.Clear();

                    plotBarras.Plot.FigureBackground.Color = corFundo;
                    plotBarras.Plot.DataBackground.Color = corFundo;
                    plotBarras.Plot.Axes.Color(corTexto);
                    plotBarras.Plot.Grid.MajorLineColor = ScottPlot.Colors.White.WithAlpha(0.1);

                    double totalReceita = (double)transacoesDoMes
                        .Where(t => t.Type == TransactionType.Revenue)
                        .Sum(t => t.Amount);

                    double totalDespesa = (double)transacoesDoMes
                        .Where(t => t.Type == TransactionType.Expense)
                        .Sum(t => t.Amount);

                    var barraReceita = new ScottPlot.Bar
                    {
                        Value = totalReceita,
                        Position = 1,
                        FillColor = ScottPlot.Colors.MediumSeaGreen,
                        Label = $"Receita\n{totalReceita:C2}"
                    };

                    var barraDespesa = new ScottPlot.Bar
                    {
                        Value = totalDespesa,
                        Position = 2,
                        FillColor = ScottPlot.Colors.IndianRed,
                        Label = $"Despesa\n{totalDespesa:C2}"
                    };

                    var bars = plotBarras.Plot.Add.Bars(new[] { barraReceita, barraDespesa });
                    bars.ValueLabelStyle.ForeColor = corTexto;

                    ScottPlot.TickGenerators.NumericManual ticks = new();
                    ticks.AddMajor(1, "");
                    ticks.AddMajor(2, "");
                    plotBarras.Plot.Axes.Bottom.TickGenerator = ticks;

                    plotBarras.Plot.Title("Balanço do Mês");
                    plotBarras.Plot.Axes.Title.Label.ForeColor = corTexto;

                    double maiorValor = Math.Max(totalReceita, totalDespesa);

                    if (maiorValor > 0)
                    {
                        plotBarras.Plot.Axes.SetLimitsY(0, maiorValor * 1.25);
                    }
                    else
                    {
                        plotBarras.Plot.Axes.AutoScale();
                    }
                    plotBarras.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar gráficos: " + ex.Message);
            }
        }
        private void tabPageHome_Enter(object sender, EventArgs e)
        {
            CarregarGraficos();

        }
        #endregion

        #region Account 
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
        private void btnCriar1_Click(object sender, EventArgs e)
        {
            var formConta = ConfigureDI.serviceProvider.GetService<AccountForm>();


            if (formConta.ShowDialog() == DialogResult.OK)
            {

                CarregarGridContas();
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
        private void tabPageAccount_Enter(object sender, EventArgs e)
        {
            CarregarGridContas();
        }
        #endregion

        #region Bank 
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
        private void btnCriar2_Click(object sender, EventArgs e)
        {
            var formBanco = ConfigureDI.serviceProvider.GetService<BankForm>();

            if (formBanco.ShowDialog() == DialogResult.OK)
            {
                CarregarGridBancos();
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
        private void tabPageBank_Enter(object sender, EventArgs e)
        {
            CarregarGridBancos();
        }
        #endregion

        #region Category 
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
        private void btnCriar3_Click(object sender, EventArgs e)
        {
            var formCategoria = ConfigureDI.serviceProvider.GetService<CategoryForm>();

            if (formCategoria.ShowDialog() == DialogResult.OK)
            {
                CarregarGridCategorias();
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
        private void tabPageCategory_Enter(object sender, EventArgs e)
        {
            CarregarGridCategorias();
        }
        #endregion

        #region Subscription
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

                    dataGridView4.Columns["ProximoVencimento"].HeaderText = "Vencimento";
                    dataGridView4.Columns["Frequencia"].HeaderText = "Frequência";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar assinaturas: " + ex.Message);
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
        private void tabPageSubs_Enter(object sender, EventArgs e)
        {
            CarregarGridAssinaturas();
        }
        #endregion

        #region Transaction 
        private void CarregarGridTransacoes()
        {
            try
            {
                var includes = new List<string> { "User", "Account", "Category" };
                var query = _transactionService.Get<Transaction>(includes)
                    .Where(t => t.User != null && t.User.Id == UserSession.UserId);

                if (rdoMes.Checked)
                {
                    var dataAtual = DateTime.Now;
                    query = query.Where(t => t.TransactionDate.Month == dataAtual.Month &&
                                             t.TransactionDate.Year == dataAtual.Year);
                }

                var transacoesFiltradas = query
                    .OrderByDescending(t => t.TransactionDate)
                    .Select(t => new
                    {
                        Id = t.Id,
                        Descricao = t.Description,
                        Valor = t.Amount,
                        Data = t.TransactionDate,
                        Tipo = t.Type switch { TransactionType.Revenue => "Receita", TransactionType.Expense => "Despesa", TransactionType.Transfer => "Transferência", _ => t.Type.ToString() },
                        Pagamento = t.PaymentType switch { PaymentMethod.Cash => "Dinheiro", PaymentMethod.DebitCard => "Débito", PaymentMethod.CreditCard => "Crédito", PaymentMethod.Pix => "Pix", PaymentMethod.BankSlip => "Boleto", PaymentMethod.Transfer => "Transferência", _ => t.PaymentType.ToString() },
                        Pago = t.IsPaid ? "Sim" : "Não",
                        Conta = t.Account != null ? t.Account.Name : "N/A",
                        Categoria = t.Category != null ? t.Category.Name : "N/A"
                    })
                    .ToList();

                dataGridView5.DataSource = transacoesFiltradas;

                if (dataGridView5.Columns.Count > 0)
                {
                    dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView5.Columns["Id"].Visible = false;
                    if (dataGridView5.Columns.Contains("Descricao"))
                        dataGridView5.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView5.Columns["Valor"].DefaultCellStyle.Format = "C2";
                    dataGridView5.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void btnCriar5_Click(object sender, EventArgs e)
        {
            var formTransacao = ConfigureDI.serviceProvider.GetRequiredService<TransactionFrom>();

            if (formTransacao.ShowDialog() == DialogResult.OK)
            {
                CarregarGridTransacoes();
                CarregarDashboard();
                CarregarTransacoesRecentes();
                CarregarGraficos();

            }
        }
        private void btnEditar5_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count > 0)
            {
                var id = (int)dataGridView5.SelectedRows[0].Cells["Id"].Value;

                var formTransacao = ConfigureDI.serviceProvider.GetRequiredService<TransactionFrom>();

                formTransacao.SetEditMode(id);

                if (formTransacao.ShowDialog() == DialogResult.OK)
                {
                    CarregarGridTransacoes();
                    CarregarDashboard();
                    CarregarTransacoesRecentes();
                    CarregarGraficos();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma transação para editar.");
            }
        }
        private void btnDeletar5_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count > 0)
            {
                var id = (int)dataGridView5.SelectedRows[0].Cells["Id"].Value;

                if (MessageBox.Show("Deseja realmente excluir esta transação?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        _transactionService.Delete(id);

                        CarregarGridTransacoes();
                        CarregarDashboard();
                        CarregarTransacoesRecentes();
                        CarregarGraficos();
                        MessageBox.Show("Transação excluída com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao excluir: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma transação para excluir.");
            }
        }
        private void tabPageTrans_Enter(object sender, EventArgs e)
        {
            CarregarGridTransacoes();

        }
        #endregion

        #region Reports
        private void AtualizarKPIs(List<Transaction> transacoes)
        {
            double totalReceita = (double)transacoes.Where(t => t.Type == TransactionType.Revenue).Sum(t => t.Amount);
            double totalDespesa = (double)transacoes.Where(t => t.Type == TransactionType.Expense).Sum(t => t.Amount);
            double saldo = totalReceita - totalDespesa;

            if (lblRelatorioSaldo != null)
            {
                lblRelatorioSaldo.Text = $"Saldo\n{saldo:C2}";
                lblRelatorioSaldo.ForeColor = saldo >= 0 ? System.Drawing.Color.LightGreen : System.Drawing.Color.LightCoral;
            }

            if (lblRelatorioEntrada != null)
                lblRelatorioEntrada.Text = $"Entradas\n{totalReceita:C2}";

            if (lblRelatorioSaida != null)
                lblRelatorioSaida.Text = $"Saídas\n{totalDespesa:C2}";
        }

        private void AtualizarGraficos(List<Transaction> transacoes, DateTime dataInicio, DateTime dataFim)
        {
            var corFundo = new ScottPlot.Color(21, 16, 70);
            var corTexto = ScottPlot.Colors.White;

        
            if (plotRelatorioPizza != null)
            {
                plotRelatorioPizza.Plot.Clear();
                plotRelatorioPizza.Plot.FigureBackground.Color = corFundo;
                plotRelatorioPizza.Plot.DataBackground.Color = corFundo;
                plotRelatorioPizza.Plot.Axes.Color(corTexto);

                var dadosPizza = transacoes
                    .Where(t => t.Type == TransactionType.Expense)
                    .GroupBy(t => t.Category != null ? t.Category.Name : "Outros")
                    .Select(g => new { Categoria = g.Key, Total = (double)g.Sum(t => t.Amount) })
                    .Where(x => x.Total > 0)
                    .OrderByDescending(x => x.Total)
                    .ToList();

                if (dadosPizza.Count > 0)
                {
                    var fatias = new List<ScottPlot.PieSlice>();
                    var paleta = ScottPlot.Colors.Category10;
                    int i = 0;

                    foreach (var item in dadosPizza)
                    {
                        fatias.Add(new ScottPlot.PieSlice
                        {
                            Value = item.Total,
                            Label = $"{item.Categoria}\n{item.Total:C2}",
                            FillColor = paleta[i % paleta.Length],
                            LabelFontColor = corTexto,
                            LabelFontSize = 12, 
                            LabelBold = true
                        });
                        i++;
                    }

                    var pie = plotRelatorioPizza.Plot.Add.Pie(fatias);
                    pie.DonutFraction = 0.5;

 
                    pie.SliceLabelDistance = 1.05; 

                    plotRelatorioPizza.Plot.HideGrid();
                    plotRelatorioPizza.Plot.Axes.Frameless();
                    plotRelatorioPizza.Plot.Axes.Margins(0, 0);

                    plotRelatorioPizza.Plot.Axes.SetLimits(-1.3, 1.3, -1.3, 1.3);
                }
                else
                {
                    plotRelatorioPizza.Plot.Title("Sem despesas no período");
                    plotRelatorioPizza.Plot.Axes.Title.Label.ForeColor = corTexto;
                }

                plotRelatorioPizza.Plot.Title("Despesas por Categoria");
                plotRelatorioPizza.Plot.Axes.Title.Label.ForeColor = corTexto;
                plotRelatorioPizza.Refresh();
            }


            if (plotRelatorioEvolucao != null)
            {
                plotRelatorioEvolucao.Plot.Clear();
                plotRelatorioEvolucao.Plot.FigureBackground.Color = corFundo;
                plotRelatorioEvolucao.Plot.DataBackground.Color = corFundo;
                plotRelatorioEvolucao.Plot.Axes.Color(corTexto);
                plotRelatorioEvolucao.Plot.Grid.MajorLineColor = ScottPlot.Colors.White.WithAlpha(0.05);

                bool agruparPorMes = (dataFim - dataInicio).TotalDays > 60;

                var grupos = transacoes
                    .GroupBy(t => agruparPorMes
                        ? new DateTime(t.TransactionDate.Year, t.TransactionDate.Month, 1)
                        : t.TransactionDate.Date)
                    .OrderBy(g => g.Key)
                    .ToList();

                List<ScottPlot.Bar> barras = new();
                ScottPlot.TickGenerators.NumericManual tickGen = new();
                int posicao = 0;
                double maiorValor = 0;

                foreach (var grupo in grupos)
                {
                    double ent = Math.Abs((double)grupo.Where(t => t.Type == TransactionType.Revenue).Sum(t => t.Amount));
                    double sai = Math.Abs((double)grupo.Where(t => t.Type == TransactionType.Expense).Sum(t => t.Amount));

                    if (ent > maiorValor) maiorValor = ent;
                    if (sai > maiorValor) maiorValor = sai;

                    barras.Add(new ScottPlot.Bar
                    {
                        Position = posicao,
                        Value = ent,
                        FillColor = ScottPlot.Colors.MediumSeaGreen,
                        Size = 0.4,
                        Label = ent > 0 ? ent.ToString("C0") : ""
                    });

                    barras.Add(new ScottPlot.Bar
                    {
                        Position = posicao + 0.4,
                        Value = sai,
                        FillColor = ScottPlot.Colors.IndianRed,
                        Size = 0.4,
                        Label = sai > 0 ? sai.ToString("C0") : ""
                    });

                    string textoData = agruparPorMes ? grupo.Key.ToString("MMM/yy") : grupo.Key.ToString("dd/MM");
                    tickGen.AddMajor(posicao + 0.2, textoData);

                    posicao++;
                }

                var plotBars = plotRelatorioEvolucao.Plot.Add.Bars(barras);

                plotBars.ValueLabelStyle.ForeColor = corTexto;
                plotBars.ValueLabelStyle.FontSize = 10;
                plotBars.ValueLabelStyle.Bold = true;

                plotRelatorioEvolucao.Plot.Axes.Bottom.TickGenerator = tickGen;
                plotRelatorioEvolucao.Plot.Axes.Bottom.TickLabelStyle.Rotation = -45;
                plotRelatorioEvolucao.Plot.Axes.Bottom.TickLabelStyle.Alignment = ScottPlot.Alignment.MiddleRight;

                plotRelatorioEvolucao.Plot.Axes.Margins(bottom: 0.2, top: 0.2);

                plotRelatorioEvolucao.Plot.Title("Evolução Financeira");
                plotRelatorioEvolucao.Plot.Axes.Title.Label.ForeColor = corTexto;

                if (maiorValor > 0)
                {
                    plotRelatorioEvolucao.Plot.Axes.SetLimitsY(0, maiorValor * 1.2);
                }
                else
                {
                    plotRelatorioEvolucao.Plot.Axes.SetLimitsY(0, 100);
                }

                if (grupos.Count > 0)
                {
                    plotRelatorioEvolucao.Plot.Axes.SetLimitsX(-0.5, grupos.Count + 0.5);
                }

                plotRelatorioEvolucao.Refresh();
            }
        }
        private void CarregarRelatorios()
        {
            try
            {
                DateTime dataInicio = dtpInicio.Value.Date;
                DateTime dataFim = dtpFim.Value.Date.AddDays(1).AddTicks(-1);

                var userId = UserSession.UserId;

                var transacoes = _transactionService.Get<Transaction>(new List<string> { "Category" })
                    .Where(t => t.User.Id == userId &&
                                t.TransactionDate >= dataInicio &&
                                t.TransactionDate <= dataFim)
                    .ToList();

                AtualizarKPIs(transacoes);

                AtualizarGraficos(transacoes, dataInicio, dataFim);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar relatório: " + ex.Message);
            }
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregarRelatorios();
        }
        private void cbFiltroPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hoje = DateTime.Now;

            dtpInicio.ValueChanged -= btnFiltrar_Click;

            switch (cbFiltroPeriodo.SelectedItem.ToString())
            {
                case "Este Mês":
                    dtpInicio.Value = new DateTime(hoje.Year, hoje.Month, 1);
                    dtpFim.Value = hoje;
                    break;

                case "Mês Passado":
                    var mesPassado = hoje.AddMonths(-1);
                    dtpInicio.Value = new DateTime(mesPassado.Year, mesPassado.Month, 1);
                    dtpFim.Value = new DateTime(mesPassado.Year, mesPassado.Month, DateTime.DaysInMonth(mesPassado.Year, mesPassado.Month));
                    break;

                case "Este Ano":
                    dtpInicio.Value = new DateTime(hoje.Year, 1, 1);
                    dtpFim.Value = new DateTime(hoje.Year, 12, 31);
                    break;

            }

            
            CarregarRelatorios();
        }
        #endregion

        #region Extra
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

        #endregion

        
    }
}
