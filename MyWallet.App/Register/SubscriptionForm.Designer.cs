namespace MyWallet.App.Register
{
    partial class SubscriptionForm
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
            cboCategoria = new ReaLTaiizor.Controls.DungeonComboBox();
            cboConta = new ReaLTaiizor.Controls.DungeonComboBox();
            txtLimit = new ReaLTaiizor.Controls.HopeTextBox();
            cboFrequencia = new ReaLTaiizor.Controls.DungeonComboBox();
            parrotRadioButton1 = new ReaLTaiizor.Controls.ParrotRadioButton();
            txtNome = new ReaLTaiizor.Controls.HopeTextBox();
            hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
            SuspendLayout();
            // 
            // cboCategoria
            // 
            cboCategoria.BackColor = Color.FromArgb(246, 246, 246);
            cboCategoria.ColorA = Color.FromArgb(246, 132, 85);
            cboCategoria.ColorB = Color.FromArgb(231, 108, 57);
            cboCategoria.ColorC = Color.FromArgb(242, 241, 240);
            cboCategoria.ColorD = Color.FromArgb(253, 252, 252);
            cboCategoria.ColorE = Color.FromArgb(239, 237, 236);
            cboCategoria.ColorF = Color.FromArgb(180, 180, 180);
            cboCategoria.ColorG = Color.FromArgb(119, 119, 118);
            cboCategoria.ColorH = Color.FromArgb(224, 222, 220);
            cboCategoria.ColorI = Color.FromArgb(250, 249, 249);
            cboCategoria.DrawMode = DrawMode.OwnerDrawFixed;
            cboCategoria.DropDownHeight = 100;
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.Font = new Font("Microsoft Sans Serif", 15F);
            cboCategoria.ForeColor = Color.Black;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.HoverSelectionColor = Color.Empty;
            cboCategoria.IntegralHeight = false;
            cboCategoria.ItemHeight = 35;
            cboCategoria.Location = new Point(441, 230);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(168, 41);
            cboCategoria.StartIndex = 0;
            cboCategoria.TabIndex = 17;
            // 
            // cboConta
            // 
            cboConta.BackColor = Color.FromArgb(246, 246, 246);
            cboConta.ColorA = Color.FromArgb(246, 132, 85);
            cboConta.ColorB = Color.FromArgb(231, 108, 57);
            cboConta.ColorC = Color.FromArgb(242, 241, 240);
            cboConta.ColorD = Color.FromArgb(253, 252, 252);
            cboConta.ColorE = Color.FromArgb(239, 237, 236);
            cboConta.ColorF = Color.FromArgb(180, 180, 180);
            cboConta.ColorG = Color.FromArgb(119, 119, 118);
            cboConta.ColorH = Color.FromArgb(224, 222, 220);
            cboConta.ColorI = Color.FromArgb(250, 249, 249);
            cboConta.DrawMode = DrawMode.OwnerDrawFixed;
            cboConta.DropDownHeight = 100;
            cboConta.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConta.Font = new Font("Microsoft Sans Serif", 15F);
            cboConta.ForeColor = Color.Black;
            cboConta.FormattingEnabled = true;
            cboConta.HoverSelectionColor = Color.Empty;
            cboConta.IntegralHeight = false;
            cboConta.ItemHeight = 35;
            cboConta.Location = new Point(194, 230);
            cboConta.Name = "cboConta";
            cboConta.Size = new Size(169, 41);
            cboConta.StartIndex = 0;
            cboConta.TabIndex = 16;
            cboConta.SelectedIndexChanged += cboConta_SelectedIndexChanged;
            // 
            // txtLimit
            // 
            txtLimit.BackColor = Color.White;
            txtLimit.BaseColor = Color.FromArgb(44, 55, 66);
            txtLimit.BorderColorA = Color.FromArgb(64, 158, 255);
            txtLimit.BorderColorB = Color.FromArgb(220, 223, 230);
            txtLimit.Font = new Font("Microsoft Sans Serif", 16F);
            txtLimit.ForeColor = Color.Black;
            txtLimit.Hint = "preço";
            txtLimit.ImeMode = ImeMode.NoControl;
            txtLimit.Location = new Point(153, 108);
            txtLimit.MaxLength = 32767;
            txtLimit.Multiline = false;
            txtLimit.Name = "txtLimit";
            txtLimit.PasswordChar = '\0';
            txtLimit.ScrollBars = ScrollBars.None;
            txtLimit.SelectedText = "";
            txtLimit.SelectionLength = 0;
            txtLimit.SelectionStart = 0;
            txtLimit.Size = new Size(240, 41);
            txtLimit.TabIndex = 15;
            txtLimit.TabStop = false;
            txtLimit.UseSystemPasswordChar = false;
            // 
            // cboFrequencia
            // 
            cboFrequencia.BackColor = Color.FromArgb(246, 246, 246);
            cboFrequencia.ColorA = Color.FromArgb(246, 132, 85);
            cboFrequencia.ColorB = Color.FromArgb(231, 108, 57);
            cboFrequencia.ColorC = Color.FromArgb(242, 241, 240);
            cboFrequencia.ColorD = Color.FromArgb(253, 252, 252);
            cboFrequencia.ColorE = Color.FromArgb(239, 237, 236);
            cboFrequencia.ColorF = Color.FromArgb(180, 180, 180);
            cboFrequencia.ColorG = Color.FromArgb(119, 119, 118);
            cboFrequencia.ColorH = Color.FromArgb(224, 222, 220);
            cboFrequencia.ColorI = Color.FromArgb(250, 249, 249);
            cboFrequencia.DrawMode = DrawMode.OwnerDrawFixed;
            cboFrequencia.DropDownHeight = 100;
            cboFrequencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFrequencia.Font = new Font("Microsoft Sans Serif", 15F);
            cboFrequencia.ForeColor = Color.Black;
            cboFrequencia.FormattingEnabled = true;
            cboFrequencia.HoverSelectionColor = Color.Empty;
            cboFrequencia.IntegralHeight = false;
            cboFrequencia.ItemHeight = 35;
            cboFrequencia.Location = new Point(431, 108);
            cboFrequencia.Name = "cboFrequencia";
            cboFrequencia.Size = new Size(120, 41);
            cboFrequencia.StartIndex = 0;
            cboFrequencia.TabIndex = 18;
            // 
            // parrotRadioButton1
            // 
            parrotRadioButton1.Checked = false;
            parrotRadioButton1.Font = new Font("Microsoft Sans Serif", 16F);
            parrotRadioButton1.ForeColor = Color.White;
            parrotRadioButton1.Location = new Point(581, 108);
            parrotRadioButton1.Name = "parrotRadioButton1";
            parrotRadioButton1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotRadioButton1.RadioColor = Color.FromArgb(0, 162, 250);
            parrotRadioButton1.RadioHoverColor = Color.FromArgb(249, 55, 98);
            parrotRadioButton1.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material;
            parrotRadioButton1.Size = new Size(111, 41);
            parrotRadioButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotRadioButton1.TabIndex = 19;
            parrotRadioButton1.Text = "Aitvo";
            parrotRadioButton1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.BaseColor = Color.FromArgb(44, 55, 66);
            txtNome.BorderColorA = Color.FromArgb(64, 158, 255);
            txtNome.BorderColorB = Color.FromArgb(220, 223, 230);
            txtNome.Font = new Font("Microsoft Sans Serif", 16F);
            txtNome.ForeColor = Color.Black;
            txtNome.Hint = "nome da categoria";
            txtNome.ImeMode = ImeMode.NoControl;
            txtNome.Location = new Point(194, 51);
            txtNome.MaxLength = 32767;
            txtNome.Multiline = false;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.ScrollBars = ScrollBars.None;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.Size = new Size(415, 41);
            txtNome.TabIndex = 14;
            txtNome.TabStop = false;
            txtNome.UseSystemPasswordChar = false;
            // 
            // hopeTextBox1
            // 
            hopeTextBox1.BackColor = Color.White;
            hopeTextBox1.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox1.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox1.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBox1.Font = new Font("Microsoft Sans Serif", 16F);
            hopeTextBox1.ForeColor = Color.Black;
            hopeTextBox1.Hint = "nome da categoria";
            hopeTextBox1.ImeMode = ImeMode.NoControl;
            hopeTextBox1.Location = new Point(233, 168);
            hopeTextBox1.MaxLength = 32767;
            hopeTextBox1.Multiline = false;
            hopeTextBox1.Name = "hopeTextBox1";
            hopeTextBox1.PasswordChar = '\0';
            hopeTextBox1.ScrollBars = ScrollBars.None;
            hopeTextBox1.SelectedText = "";
            hopeTextBox1.SelectionLength = 0;
            hopeTextBox1.SelectionStart = 0;
            hopeTextBox1.Size = new Size(318, 41);
            hopeTextBox1.TabIndex = 20;
            hopeTextBox1.TabStop = false;
            hopeTextBox1.UseSystemPasswordChar = false;
            // 
            // SubscriptionForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 375);
            Controls.Add(hopeTextBox1);
            Controls.Add(parrotRadioButton1);
            Controls.Add(cboFrequencia);
            Controls.Add(cboCategoria);
            Controls.Add(cboConta);
            Controls.Add(txtLimit);
            Controls.Add(txtNome);
            Name = "SubscriptionForm";
            Text = "Assinatura";
            Controls.SetChildIndex(txtNome, 0);
            Controls.SetChildIndex(txtLimit, 0);
            Controls.SetChildIndex(cboConta, 0);
            Controls.SetChildIndex(cboCategoria, 0);
            Controls.SetChildIndex(cboFrequencia, 0);
            Controls.SetChildIndex(parrotRadioButton1, 0);
            Controls.SetChildIndex(hopeTextBox1, 0);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonComboBox cboCategoria;
        private ReaLTaiizor.Controls.DungeonComboBox cboConta;
        private ReaLTaiizor.Controls.HopeTextBox txtLimit;
        private ReaLTaiizor.Controls.DungeonComboBox cboFrequencia;
        private ReaLTaiizor.Controls.ParrotRadioButton parrotRadioButton1;
        private ReaLTaiizor.Controls.HopeTextBox txtNome;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
    }
}