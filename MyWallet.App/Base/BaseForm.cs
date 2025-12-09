using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Windows.Forms; 
using System;


namespace MyWallet.App.Base
{
    public partial class BaseForm : LostForm
    {
        #region Variables
        protected bool IsEditMode = false;
        #endregion

        #region Method
        public BaseForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Tem certeza que deseja cancelar?", @"MyWallet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearFields();
                this.DialogResult = DialogResult.Cancel;

                this.Close();
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            Save();
        }


        #endregion

        #region Methods
        protected void ClearFields()
        {
            IsEditMode = false;
            LimparControles(this.Controls);
        }

        private void LimparControles(Control.ControlCollection controles)
        {
            foreach (Control control in controles)
            {
                if (control is HopeTextBox txt)
                {
                    txt.Text = string.Empty;
                }

                else if (control is DungeonComboBox cbo)
                {
                    cbo.SelectedIndex = -1;
                }

                /*else if (control is CheckBox chk)
                {
                    chk.Checked = false;
                }*/

                else if (control is DateTimePicker dtp)
                {
                    dtp.Value = DateTime.Now;
                }

          
                if (control.HasChildren)
                {
                    LimparControles(control.Controls);
                }
            }
        
        }
        protected virtual void Save()
        {

        }
        #endregion
    }

}