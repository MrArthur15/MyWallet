

using MyWallet.App.Base;
using MyWallet.App.Others;
using MyWallet.Domain.Base;
using MyWallet.Domain.Entities;
using MyWallet.Domain.Enum;
using MyWallet.Service.Validators;
using System.Security.Cryptography;
using System.Security.Principal;

namespace MyWallet.App.Register
{
    public partial class CategoryForm : BaseForm
    {
        private IBaseService<Category> _categoryService;

        private int _id;

        public CategoryForm(IBaseService<Category> categoryService)
        {
            _categoryService = categoryService;
            InitializeComponent();
            CarregarComboTipo();
            CarregarComboPrioridade();
        }

        private void CarregarComboTipo()
        {

            cboType.DataSource = new[]
            {
                new { Value = TransactionType.Revenue, Text = "Receita"},
                new { Value = TransactionType.Expense, Text = "Despesa" },
                new { Value = TransactionType.Transfer, Text = "Transferência" }
            };
            cboType.DisplayMember = "Text";
            cboType.ValueMember = "Value";
            cboType.SelectedIndex = -1;


        }

        private void CarregarComboPrioridade()
        {

            cboPrioridade.DataSource = new[]
            {
                new { Value = PriorityLevel.Essential, Text = "Essencial"},
                new { Value = PriorityLevel.Superfluous, Text = "Supérfluo" },
                new { Value = PriorityLevel.None, Text = "Nada" }
            };
            cboPrioridade.DisplayMember = "Text";
            cboPrioridade.ValueMember = "Value";
            cboPrioridade.SelectedIndex = -1;
        }

        private void FormToObject(Category category)
        {
            
            category.Name = txtNome.Text;

            if (decimal.TryParse(txtLimit.Text, out decimal limite))
                category.BudgetLimit = limite;

            if (cboType.SelectedValue != null)
            {
                category.Type = (TransactionType)cboType.SelectedValue;
            }

            if (cboPrioridade.SelectedValue != null)
            {
                category.Priority = (PriorityLevel)cboPrioridade.SelectedValue;
            }



            if (category.User != null && category.User.Id == UserSession.UserId)
            {
            }
            else
            {
                
                var usuarioNaMemoria = _categoryService
                    .Get<Category>(new List<string> { "User" }) 
                    .FirstOrDefault(c => c.User != null && c.User.Id == UserSession.UserId)
                    ?.User;

                if (usuarioNaMemoria != null)
                {
                    
                    category.User = usuarioNaMemoria;
                }
                else
                {
                   
                    category.User = UserSession.CurrentUser;
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
            var category = _categoryService.GetById<Category>(_id);
            if (category != null)
            {
                txtNome.Text = category.Name;
                txtLimit.Text = category.BudgetLimit?.ToString("N2"); 
                cboType.SelectedValue = category.Type;
                cboPrioridade.SelectedValue = category.Priority;

            }
        }
        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    var categoty = _categoryService.GetById<Category>(_id);
                    if (categoty != null)
                    {
                        FormToObject(categoty);
                        _categoryService.Update<Category, Category, CategoryValidator>(categoty);
                    }
                }
                else
                {

                    var categoty = new Category();
                    FormToObject(categoty);
                    _categoryService.Add<Category, Category, CategoryValidator>(categoty);
                }

                MessageBox.Show("Categoria salva!", "MyWallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
