using MyWallet.Domain.Base;
using MyWallet.Domain.Entities;
using MyWallet.Domain.Enum;
using MyWallet.Service.Validators;
using Org.BouncyCastle.Asn1.Cmp;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyWallet.App.Register
{
    public partial class UserForm : LostForm
    {
        private IBaseService<User> _userService;
        public UserForm(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
            CarregandoComboTipo();
        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormToObject(User user)
        {
            user.Name = txtNome.Text;
            user.Login = txtUsuario.Text;
            user.Password = txtSenha.Text;
            user.Email = txtEmail.Text;
            user.IdentificationDocument = txtDocumento.Text;
            user.Type = (UserType)cboUserType.SelectedValue;
            user.BirthDate = dtpDataNacimento.Value;

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            try
            {
                var user = new User();
                FormToObject(user);
                _userService.Add<User, User, UserValidator>(user);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregandoComboTipo()
        {
            var tiposPermitidos = new[]
            {
                new { Value = UserType.Individual, Text = "Pessoa Física" },
                new { Value = UserType.Corporate,  Text = "Pessoa Jurídica" }
            };
            cboUserType.DataSource = tiposPermitidos;
            cboUserType.DisplayMember = "Text"; 
            cboUserType.ValueMember = "Value";  

            cboUserType.SelectedIndex = -1;
        }
    }
    
}
