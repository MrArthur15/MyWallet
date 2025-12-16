using MyWallet.App.Base;
using MyWallet.App.Others;
using MyWallet.Domain.Base;
using MyWallet.Domain.Entities;
using MyWallet.Domain.Enum;
using MyWallet.Service.Validators;
using ReaLTaiizor.Controls;


namespace MyWallet.App.Register
{
    public partial class TransactionFrom : BaseForm
    {
        private IBaseService<Transaction> _transactionService;
        private IBaseService<Account> _accountService;
        private IBaseService<Category> _categoryService;

        private int _id;

        public TransactionFrom(IBaseService<Transaction> transactionService, IBaseService<Account> accountService, IBaseService<Category> categoryService)
        {
            _transactionService = transactionService;
            _accountService = accountService;
            _categoryService = categoryService;

            InitializeComponent();

            CarregarComboTipo();
            CarregarComboMetodo();
            CarregarComboContas();
            CarregarComboCategorias();
        }

        private void CarregarComboTipo()
        {
            cboTipo.DataSource = new[]
            {
                new { Value = TransactionType.Revenue, Text = "Receita" },
                new { Value = TransactionType.Expense, Text = "Despesa" },
                new { Value = TransactionType.Transfer, Text = "Transferência" }
            };

            cboTipo.DisplayMember = "Text";
            cboTipo.ValueMember = "Value";
            cboTipo.SelectedIndex = -1;
        }

        private void CarregarComboMetodo()
        {
            cboMetodo.DataSource = new[]
            {
                new { Value = PaymentMethod.Cash, Text = "Dinheiro" },
                new { Value = PaymentMethod.DebitCard, Text = "Débito" },
                new { Value = PaymentMethod.CreditCard, Text = "Crédito" },
                new { Value = PaymentMethod.Pix, Text = "Pix" },
                new { Value = PaymentMethod.BankSlip, Text = "Boleto" },
                new { Value = PaymentMethod.Transfer, Text = "Transferência Bancária" }
            };

            cboMetodo.DisplayMember = "Text";
            cboMetodo.ValueMember = "Value";
            cboMetodo.SelectedIndex = -1;
        }

        private void CarregarComboContas()
        {
            var accounts = _accountService.Get<Account>().ToList();

            cboConta.DataSource = accounts;
            cboConta.DisplayMember = "Name";
            cboConta.ValueMember = "Id";
            cboConta.SelectedIndex = -1;
        }

        private void CarregarComboCategorias()
        {
            var categories = _categoryService.Get<Category>().ToList();

            cboCategoria.DataSource = categories;
            cboCategoria.DisplayMember = "Name";
            cboCategoria.ValueMember = "Id";
            cboCategoria.SelectedIndex = -1;
        }

        private void FormToObject(Transaction transaction)
        {
            if (decimal.TryParse(txtValor.Text, out decimal amount))
            {
                transaction.Amount = amount;
            }

            transaction.Description = txtDescricao.Text;
            transaction.TransactionDate = dtpNextDate.Value;
            transaction.IsPaid = chkPago.Checked;

            if (cboTipo.SelectedValue != null)
                transaction.Type = (TransactionType)cboTipo.SelectedValue;

            if (cboMetodo.SelectedValue != null)
                transaction.PaymentType = (PaymentMethod)cboMetodo.SelectedValue;

            if (cboConta.SelectedItem is Account account)
                transaction.Account = account;

            if (cboCategoria.SelectedItem is Category category)
                transaction.Category = category;

            if (transaction.User != null && transaction.User.Id == UserSession.UserId)
            {
            }
            else
            {
                var usuarioNaMemoria = _transactionService
                    .Get<Transaction>(new List<string> { "User" })
                    .FirstOrDefault(t => t.User != null && t.User.Id == UserSession.UserId)
                    ?.User;

                if (usuarioNaMemoria != null)
                {
                    transaction.User = usuarioNaMemoria;
                }
                else
                {
                    transaction.User = UserSession.CurrentUser;
                }
            }
        }
        public void SetEditMode(int id)
        {
            _id = id;
            IsEditMode = true;
            CarregarDadosEdicao();
        }

        private void CarregarDadosEdicao()
        {
            var transaction = _transactionService.GetById<Transaction>(_id);

            if (transaction != null)
            {
                txtValor.Text = transaction.Amount.ToString("N2");
                txtDescricao.Text = transaction.Description;
                dtpNextDate.Value = transaction.TransactionDate;
                chkPago.Checked = transaction.IsPaid;

                cboTipo.SelectedValue = transaction.Type;
                cboMetodo.SelectedValue = transaction.PaymentType;

                if (transaction.Account != null)
                    cboConta.SelectedValue = transaction.Account.Id;

                if (transaction.Category != null)
                    cboCategoria.SelectedValue = transaction.Category.Id;
            }
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    var transaction = _transactionService.GetById<Transaction>(_id);
                    if (transaction != null)
                    {
                        FormToObject(transaction);
                        _transactionService.Update<Transaction, Transaction, TransactionValidator>(transaction);
                    }
                }
                else
                {
                    var transaction = new Transaction();
                    FormToObject(transaction);
                    _transactionService.Add<Transaction, Transaction, TransactionValidator>(transaction);
                }

                MessageBox.Show("Transação salva com sucesso!", "MyWallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

