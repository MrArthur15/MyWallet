namespace MyWallet.App.Register
{
    partial class AccountForm
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
            txtValor = new ReaLTaiizor.Controls.HopeTextBox();
            txtNome = new ReaLTaiizor.Controls.HopeTextBox();
            txtLimiteCredito = new ReaLTaiizor.Controls.HopeTextBox();
            btnAddBanco = new ReaLTaiizor.Controls.HopeRoundButton();
            cboBank = new ReaLTaiizor.Controls.DungeonComboBox();
            cboType = new ReaLTaiizor.Controls.DungeonComboBox();
            SuspendLayout();
            // 
            // txtValor
            // 
            txtValor.BackColor = Color.White;
            txtValor.BaseColor = Color.FromArgb(44, 55, 66);
            txtValor.BorderColorA = Color.FromArgb(64, 158, 255);
            txtValor.BorderColorB = Color.FromArgb(220, 223, 230);
            txtValor.Font = new Font("Microsoft Sans Serif", 16F);
            txtValor.ForeColor = Color.Black;
            txtValor.Hint = "valor na conta";
            txtValor.ImeMode = ImeMode.NoControl;
            txtValor.Location = new Point(153, 129);
            txtValor.MaxLength = 32767;
            txtValor.Multiline = false;
            txtValor.Name = "txtValor";
            txtValor.PasswordChar = '\0';
            txtValor.ScrollBars = ScrollBars.None;
            txtValor.SelectedText = "";
            txtValor.SelectionLength = 0;
            txtValor.SelectionStart = 0;
            txtValor.Size = new Size(200, 41);
            txtValor.TabIndex = 5;
            txtValor.TabStop = false;
            txtValor.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.BaseColor = Color.FromArgb(44, 55, 66);
            txtNome.BorderColorA = Color.FromArgb(64, 158, 255);
            txtNome.BorderColorB = Color.FromArgb(220, 223, 230);
            txtNome.Font = new Font("Microsoft Sans Serif", 16F);
            txtNome.ForeColor = Color.Black;
            txtNome.Hint = "nome da conta";
            txtNome.ImeMode = ImeMode.NoControl;
            txtNome.Location = new Point(233, 58);
            txtNome.MaxLength = 32767;
            txtNome.Multiline = false;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.ScrollBars = ScrollBars.None;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.Size = new Size(318, 41);
            txtNome.TabIndex = 4;
            txtNome.TabStop = false;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtLimiteCredito
            // 
            txtLimiteCredito.BackColor = Color.White;
            txtLimiteCredito.BaseColor = Color.FromArgb(44, 55, 66);
            txtLimiteCredito.BorderColorA = Color.FromArgb(64, 158, 255);
            txtLimiteCredito.BorderColorB = Color.FromArgb(220, 223, 230);
            txtLimiteCredito.Font = new Font("Microsoft Sans Serif", 16F);
            txtLimiteCredito.ForeColor = Color.Black;
            txtLimiteCredito.Hint = "limite de credito";
            txtLimiteCredito.ImeMode = ImeMode.NoControl;
            txtLimiteCredito.Location = new Point(431, 129);
            txtLimiteCredito.MaxLength = 32767;
            txtLimiteCredito.Multiline = false;
            txtLimiteCredito.Name = "txtLimiteCredito";
            txtLimiteCredito.PasswordChar = '\0';
            txtLimiteCredito.ScrollBars = ScrollBars.None;
            txtLimiteCredito.SelectedText = "";
            txtLimiteCredito.SelectionLength = 0;
            txtLimiteCredito.SelectionStart = 0;
            txtLimiteCredito.Size = new Size(200, 41);
            txtLimiteCredito.TabIndex = 6;
            txtLimiteCredito.TabStop = false;
            txtLimiteCredito.UseSystemPasswordChar = false;
            // 
            // btnAddBanco
            // 
            btnAddBanco.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddBanco.BorderColor = Color.FromArgb(220, 223, 230);
            btnAddBanco.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnAddBanco.DangerColor = Color.FromArgb(245, 108, 108);
            btnAddBanco.DefaultColor = Color.FromArgb(255, 255, 255);
            btnAddBanco.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBanco.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnAddBanco.InfoColor = Color.FromArgb(144, 147, 153);
            btnAddBanco.Location = new Point(433, 205);
            btnAddBanco.Name = "btnAddBanco";
            btnAddBanco.PrimaryColor = Color.FromArgb(150, 0, 255);
            btnAddBanco.Size = new Size(198, 41);
            btnAddBanco.SuccessColor = Color.FromArgb(103, 194, 58);
            btnAddBanco.TabIndex = 7;
            btnAddBanco.Text = "Adicionar Banco";
            btnAddBanco.TextColor = Color.White;
            btnAddBanco.WarningColor = Color.FromArgb(230, 162, 60);
            btnAddBanco.Click += btnAddBanco_Click;
            // 
            // cboBank
            // 
            cboBank.BackColor = Color.FromArgb(246, 246, 246);
            cboBank.ColorA = Color.FromArgb(246, 132, 85);
            cboBank.ColorB = Color.FromArgb(231, 108, 57);
            cboBank.ColorC = Color.FromArgb(242, 241, 240);
            cboBank.ColorD = Color.FromArgb(253, 252, 252);
            cboBank.ColorE = Color.FromArgb(239, 237, 236);
            cboBank.ColorF = Color.FromArgb(180, 180, 180);
            cboBank.ColorG = Color.FromArgb(119, 119, 118);
            cboBank.ColorH = Color.FromArgb(224, 222, 220);
            cboBank.ColorI = Color.FromArgb(250, 249, 249);
            cboBank.DrawMode = DrawMode.OwnerDrawFixed;
            cboBank.DropDownHeight = 100;
            cboBank.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBank.Font = new Font("Microsoft Sans Serif", 15F);
            cboBank.ForeColor = Color.Black;
            cboBank.FormattingEnabled = true;
            cboBank.HoverSelectionColor = Color.Empty;
            cboBank.IntegralHeight = false;
            cboBank.ItemHeight = 35;
            cboBank.Location = new Point(153, 205);
            cboBank.Name = "cboBank";
            cboBank.Size = new Size(200, 41);
            cboBank.StartIndex = 0;
            cboBank.TabIndex = 8;
            // 
            // cboType
            // 
            cboType.BackColor = Color.FromArgb(246, 246, 246);
            cboType.ColorA = Color.FromArgb(246, 132, 85);
            cboType.ColorB = Color.FromArgb(231, 108, 57);
            cboType.ColorC = Color.FromArgb(242, 241, 240);
            cboType.ColorD = Color.FromArgb(253, 252, 252);
            cboType.ColorE = Color.FromArgb(239, 237, 236);
            cboType.ColorF = Color.FromArgb(180, 180, 180);
            cboType.ColorG = Color.FromArgb(119, 119, 118);
            cboType.ColorH = Color.FromArgb(224, 222, 220);
            cboType.ColorI = Color.FromArgb(250, 249, 249);
            cboType.DrawMode = DrawMode.OwnerDrawFixed;
            cboType.DropDownHeight = 100;
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.Font = new Font("Microsoft Sans Serif", 15F);
            cboType.ForeColor = Color.Black;
            cboType.FormattingEnabled = true;
            cboType.HoverSelectionColor = Color.Empty;
            cboType.IntegralHeight = false;
            cboType.ItemHeight = 35;
            cboType.Location = new Point(299, 278);
            cboType.Name = "cboType";
            cboType.Size = new Size(200, 41);
            cboType.StartIndex = 0;
            cboType.TabIndex = 9;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 417);
            Controls.Add(cboType);
            Controls.Add(cboBank);
            Controls.Add(btnAddBanco);
            Controls.Add(txtLimiteCredito);
            Controls.Add(txtValor);
            Controls.Add(txtNome);
            Name = "AccountForm";
            Text = "Conta";
            Controls.SetChildIndex(txtNome, 0);
            Controls.SetChildIndex(txtValor, 0);
            Controls.SetChildIndex(txtLimiteCredito, 0);
            Controls.SetChildIndex(btnAddBanco, 0);
            Controls.SetChildIndex(cboBank, 0);
            Controls.SetChildIndex(cboType, 0);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox txtValor;
        private ReaLTaiizor.Controls.HopeTextBox txtNome;
        private ReaLTaiizor.Controls.HopeTextBox txtLimiteCredito;
        private ReaLTaiizor.Controls.HopeRoundButton btnAddBanco;
        private ReaLTaiizor.Controls.DungeonComboBox cboBank;
        private ReaLTaiizor.Controls.DungeonComboBox cboType;
    }
}