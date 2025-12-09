using Microsoft.Extensions.DependencyInjection;
using MyWallet.App.Base;
using MyWallet.App.Infra;
using MyWallet.App.Others;
using MyWallet.Domain.Base;
using MyWallet.Domain.Entities;
using MyWallet.Domain.Enum;
using MyWallet.Service.Validators;
using System.Xml.Linq;


namespace MyWallet.App.Register
{
    public partial class AccountForm : BaseForm
    {
        private IBaseService<Account> _accountService;
        private IBaseService<Bank> _bankService;

        private int _id;


        public AccountForm(IBaseService<Account> accountService, IBaseService<Bank> bankService)
        {
            _accountService = accountService;
            _bankService = bankService;
            InitializeComponent();

            CarregarComboTipo();
            CarregarComboBancos();

        }

        private void CarregarComboTipo()
        {
            
            cboType.DataSource = new[]
            {
                
                new { Value = AccountType.Checking,   Text = "Conta Corrente" },
                new { Value = AccountType.Savings,    Text = "Poupança" },
                new { Value = AccountType.CreditCard, Text = "Cartão de Crédito" }
            };
            cboType.DisplayMember = "Text";
            cboType.ValueMember = "Value";
            cboType.SelectedIndex = -1;

            
        }

        private void CarregarComboBancos()
        {
            
            var bancos = _bankService.Get<Bank>(new List<string> { "User" })
                .Where(c => c.User != null && c.User.Id == UserSession.UserId)
                .ToList();

            cboBank.DataSource = bancos;
            cboBank.DisplayMember = "Name"; 
            cboBank.ValueMember = "Id";     
            cboBank.SelectedIndex = -1;
        }

        private void btnAddBanco_Click(object sender, EventArgs e)
        {
            var formBanco = ConfigureDI.serviceProvider.GetService<BankForm>();

            
            if (formBanco.ShowDialog() == DialogResult.OK)
            {
                
                CarregarComboBancos();

                
                if (cboBank.Items.Count > 0)
                    cboBank.SelectedIndex = cboBank.Items.Count - 1;
            }
        }
        

        private void FormToObject(Account account)
        {
            account.Name = txtNome.Text;
            if (decimal.TryParse(txtValor.Text, out decimal saldo))
                account.InitialBalance = saldo;

            if (decimal.TryParse(txtLimiteCredito.Text, out decimal limite))
                account.CreditLimit = limite;
            else
                account.CreditLimit = null;

            if (cboType.SelectedValue != null)
                account.Type = (AccountType)cboType.SelectedValue;

            if (cboBank.SelectedValue != null && int.TryParse(cboBank.SelectedValue.ToString(), out int bankId))
            {
             
                var listaBancos = cboBank.DataSource as List<Bank>;

                var bancoDaMemoria = listaBancos?.FirstOrDefault(b => b.Id == bankId);

                if (bancoDaMemoria != null)
                {
                    account.Bank = bancoDaMemoria;

                   
                    if (account.Bank.User != null)
                    {
                        account.User = account.Bank.User;
                    }
                    else
                    {
                        account.User = UserSession.CurrentUser;
                    }
                }
                else
                {
                    
                    account.Bank = _bankService.GetById<Bank>(bankId);
                    account.User = UserSession.CurrentUser;
                }
            }
            else
            {
                account.Bank = null;
                account.User = UserSession.CurrentUser;
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
            var account = _accountService.GetById<Account>(_id);
            if (account != null)
            {
                txtNome.Text = account.Name;
                txtValor.Text = account.InitialBalance?.ToString("N2"); 
                txtLimiteCredito.Text = account.CreditLimit?.ToString("N2");
                cboType.SelectedValue = account.Type;

                if (account.Bank != null)
                    cboBank.SelectedValue = account.Bank.Id;
            }
        }
        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    var account = _accountService.GetById<Account>(_id);
                    if (account != null)
                    {
                        FormToObject(account);
                        _accountService.Update<Account, Account, AccountValidator>(account);
                    }
                }
                else
                {
                    
                    var account = new Account();
                    FormToObject(account);
                    _accountService.Add<Account, Account, AccountValidator>(account);
                }

                MessageBox.Show("Conta salva!", "MyWallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
