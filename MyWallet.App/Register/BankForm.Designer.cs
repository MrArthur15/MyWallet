namespace MyWallet.App.Register
{
    partial class BankForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new ReaLTaiizor.Controls.HopeTextBox();
            txtCodigo = new ReaLTaiizor.Controls.HopeTextBox();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.BaseColor = Color.FromArgb(44, 55, 66);
            txtNome.BorderColorA = Color.FromArgb(64, 158, 255);
            txtNome.BorderColorB = Color.FromArgb(220, 223, 230);
            txtNome.Font = new Font("Microsoft Sans Serif", 16F);
            txtNome.ForeColor = Color.Black;
            txtNome.Hint = "nome do banco";
            txtNome.ImeMode = ImeMode.NoControl;
            txtNome.Location = new Point(183, 71);
            txtNome.MaxLength = 32767;
            txtNome.Multiline = false;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.ScrollBars = ScrollBars.None;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.Size = new Size(318, 41);
            txtNome.TabIndex = 2;
            txtNome.TabStop = false;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.White;
            txtCodigo.BaseColor = Color.FromArgb(44, 55, 66);
            txtCodigo.BorderColorA = Color.FromArgb(64, 158, 255);
            txtCodigo.BorderColorB = Color.FromArgb(220, 223, 230);
            txtCodigo.Font = new Font("Microsoft Sans Serif", 16F);
            txtCodigo.ForeColor = Color.Black;
            txtCodigo.Hint = "codigo do banco";
            txtCodigo.ImeMode = ImeMode.NoControl;
            txtCodigo.Location = new Point(245, 137);
            txtCodigo.MaxLength = 32767;
            txtCodigo.Multiline = false;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PasswordChar = '\0';
            txtCodigo.ScrollBars = ScrollBars.None;
            txtCodigo.SelectedText = "";
            txtCodigo.SelectionLength = 0;
            txtCodigo.SelectionStart = 0;
            txtCodigo.Size = new Size(200, 41);
            txtCodigo.TabIndex = 3;
            txtCodigo.TabStop = false;
            txtCodigo.UseSystemPasswordChar = false;
            // 
            // BankForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 310);
            Controls.Add(txtCodigo);
            Controls.Add(txtNome);
            Name = "BankForm";
            Text = "Banco";
            Controls.SetChildIndex(txtNome, 0);
            Controls.SetChildIndex(txtCodigo, 0);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox txtNome;
        private ReaLTaiizor.Controls.HopeTextBox txtCodigo;
    }
}