using Microsoft.VisualBasic.ApplicationServices;
using MyWallet.App.Base;
using MyWallet.App.Others;
using MyWallet.Domain.Base;
using MyWallet.Domain.Entities;
using MyWallet.Domain.Enum;
using MyWallet.Service.Validators;
using ReaLTaiizor.Controls;
using System.Security.Principal;


namespace MyWallet.App.Register
{
    public partial class SubscriptionForm : BaseForm
    {
        private IBaseService<Category> _categoryService;
        private IBaseService<Account> _accountService;
        private IBaseService<Subscription> _subscriptionService;


        private int _id;

        public SubscriptionForm(IBaseService<Account> accountService, IBaseService<Category> categoryService, IBaseService<Subscription> subscriptionService)
        {
            _accountService = accountService;
            _categoryService = categoryService;
            _subscriptionService = subscriptionService;

            InitializeComponent();
            CarregarComboFrequencia();
            CarregarComboContas();
            CarregarComboCategorias();

        }

        private void CarregarComboFrequencia()
        {

            cboFrequencia.DataSource = new[]
            {
                new { Value = Frequency.Monthly, Text = "Mensal"},
                new { Value = Frequency.Yearly, Text = "Anual" }
                
            };
            cboFrequencia.DisplayMember = "Text";
            cboFrequencia.ValueMember = "Value";
            cboFrequencia.SelectedIndex = -1;


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

        private void FormToObject(Subscription subscription)
        {
            subscription.Name = txtNome.Text;
            subscription.NextDueDate = dtpNextDate.Value;
            subscription.IsActive = chkAtivo.Checked;
            if (decimal.TryParse(txtPrice.Text, out decimal price))
                subscription.Price = price;
            if (cboFrequencia.SelectedValue != null)
            {
                subscription.Frequency = (Frequency)cboFrequencia.SelectedValue;
            }
            if (cboConta.SelectedItem is Account account)
            {
                subscription.Account = account;
            }
            if (cboCategoria.SelectedItem is Category category)
            {
                subscription.Category = category;
            }
            if (subscription.User != null && subscription.User.Id == UserSession.UserId)
            {
                
            }
            else
            {
                
                var usuarioNaMemoria = _subscriptionService
                    .Get<Subscription>(new List<string> { "User" })
                    .FirstOrDefault(s => s.User != null && s.User.Id == UserSession.UserId)
                    ?.User;

                if (usuarioNaMemoria != null)
                {
                    subscription.User = usuarioNaMemoria;
                }
                else
                {
                    
                    subscription.User = UserSession.CurrentUser;
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
            var subscription = _subscriptionService.GetById<Subscription>(_id);
            if (subscription != null)
            {
                txtNome.Text = subscription.Name;
                txtPrice.Text = subscription.Price.ToString("N2");

                cboFrequencia.SelectedValue = subscription.Frequency;
                chkAtivo.Checked = subscription.IsActive;

                if (subscription.Account != null)
                    cboConta.SelectedValue = subscription.Account.Id;

                if (subscription.Category != null)
                    cboCategoria.SelectedValue = subscription.Category.Id;
            }
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    var subscription = _subscriptionService.GetById<Subscription>(_id);
                    if (subscription != null)
                    {
                        FormToObject(subscription);
                        _subscriptionService.Update<Subscription, Subscription, SubscriptionValidator>(subscription);
                    }
                }
                else
                {
                    var subscription = new Subscription();
                    FormToObject(subscription);
                    _subscriptionService.Add<Subscription, Subscription, SubscriptionValidator>(subscription);
                }

                MessageBox.Show("Assinatura salva com sucesso!", "MyWallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
