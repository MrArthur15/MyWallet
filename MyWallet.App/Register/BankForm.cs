using MyWallet.App.Base;
using MyWallet.App.Others;
using MyWallet.App.ViewModel;
using MyWallet.Domain.Base;
using MyWallet.Domain.Entities;
using MyWallet.Service.Validators;
using Org.BouncyCastle.Asn1.Cmp;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;


namespace MyWallet.App.Register
{
    public partial class BankForm : BaseForm
    {

        private IBaseService<Bank> _bankService;

        private int _id;


        public BankForm(IBaseService<Bank> bankService)
        {
            _bankService = bankService;
            InitializeComponent();
        }

        private void FormToObject(Bank bank)
        {
            bank.Name = txtNome.Text;
            bank.Code = txtCodigo.Text;
            if (bank.User != null && bank.User.Id == UserSession.UserId) ;

            else
            { 
                var bancoNaMemoria = _bankService
                    .Get<Bank>(new List<string> { "User" })
                    .FirstOrDefault(b => b.User != null && b.User.Id == UserSession.UserId);

                if (bancoNaMemoria != null)
                {
                    bank.User = bancoNaMemoria.User;
                }
                else
                {
                    bank.User = UserSession.CurrentUser;
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
            var bank = _bankService.GetById<Bank>(_id);
            if (bank != null)
            {
                txtNome.Text = bank.Name;
                txtCodigo.Text = bank.Code;
            }
        }
        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {

                    var bank = _bankService.GetById<Bank>(_id);

                    if (bank != null)
                    {
                        FormToObject(bank);
                        _bankService.Update<Bank, Bank, BankValidators>(bank);
                        
                    }
                }
                else
                {
                    var bank = new Bank();
                    FormToObject(bank);
                    _bankService.Add<Bank, Bank, BankValidators>(bank);
                    

                }
                MessageBox.Show("Banco salvo!", "MyWallet", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"MyWallet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
