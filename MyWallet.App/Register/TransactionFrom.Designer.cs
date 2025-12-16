namespace MyWallet.App.Register
{
    partial class TransactionFrom
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
            chkPago = new ReaLTaiizor.Controls.CyberCheckBox();
            dtpDate = new DateTimePicker();
            cboConta = new ReaLTaiizor.Controls.DungeonComboBox();
            cboCategoria = new ReaLTaiizor.Controls.DungeonComboBox();
            cboMetodo = new ReaLTaiizor.Controls.DungeonComboBox();
            txtDescricao = new ReaLTaiizor.Controls.HopeTextBox();
            txtValor = new ReaLTaiizor.Controls.HopeTextBox();
            cboTipo = new ReaLTaiizor.Controls.DungeonComboBox();
            SuspendLayout();
            // 
            // chkPago
            // 
            chkPago.BackColor = Color.Transparent;
            chkPago.Background = true;
            chkPago.Background_WidthPen = 2F;
            chkPago.BackgroundPen = true;
            chkPago.Checked = false;
            chkPago.ColorBackground = Color.FromArgb(37, 52, 68);
            chkPago.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            chkPago.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            chkPago.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            chkPago.ColorChecked = Color.FromArgb(29, 200, 238);
            chkPago.ColorPen_1 = Color.FromArgb(37, 52, 68);
            chkPago.ColorPen_2 = Color.FromArgb(41, 63, 86);
            chkPago.CyberCheckBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            chkPago.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            chkPago.Effect_1_Transparency = 25;
            chkPago.Effect_2 = true;
            chkPago.Effect_2_ColorBackground = Color.White;
            chkPago.Effect_2_Transparency = 15;
            chkPago.Font = new Font("Microsoft Sans Serif", 15F);
            chkPago.ForeColor = Color.FromArgb(245, 245, 245);
            chkPago.LinearGradient_Background = false;
            chkPago.LinearGradientPen = false;
            chkPago.Location = new Point(431, 127);
            chkPago.Name = "chkPago";
            chkPago.RGB = false;
            chkPago.Rounding = true;
            chkPago.RoundingInt = 100;
            chkPago.Size = new Size(126, 45);
            chkPago.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            chkPago.TabIndex = 29;
            chkPago.Tag = "Cyber";
            chkPago.TextButton = "Pagado";
            chkPago.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            chkPago.Timer_Effect_1 = 1;
            chkPago.Timer_RGB = 300;
            // 
            // dtpDate
            // 
            dtpDate.DropDownAlign = LeftRightAlignment.Right;
            dtpDate.Font = new Font("Microsoft Sans Serif", 22F);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(171, 127);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(182, 41);
            dtpDate.TabIndex = 28;
            dtpDate.Value = new DateTime(2025, 12, 15, 0, 0, 0, 0);
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
            cboConta.Location = new Point(314, 248);
            cboConta.Name = "cboConta";
            cboConta.Size = new Size(157, 41);
            cboConta.StartIndex = 0;
            cboConta.TabIndex = 27;
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
            cboCategoria.Location = new Point(492, 248);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(168, 41);
            cboCategoria.StartIndex = 0;
            cboCategoria.TabIndex = 26;
            // 
            // cboMetodo
            // 
            cboMetodo.BackColor = Color.FromArgb(246, 246, 246);
            cboMetodo.ColorA = Color.FromArgb(246, 132, 85);
            cboMetodo.ColorB = Color.FromArgb(231, 108, 57);
            cboMetodo.ColorC = Color.FromArgb(242, 241, 240);
            cboMetodo.ColorD = Color.FromArgb(253, 252, 252);
            cboMetodo.ColorE = Color.FromArgb(239, 237, 236);
            cboMetodo.ColorF = Color.FromArgb(180, 180, 180);
            cboMetodo.ColorG = Color.FromArgb(119, 119, 118);
            cboMetodo.ColorH = Color.FromArgb(224, 222, 220);
            cboMetodo.ColorI = Color.FromArgb(250, 249, 249);
            cboMetodo.DrawMode = DrawMode.OwnerDrawFixed;
            cboMetodo.DropDownHeight = 335;
            cboMetodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMetodo.Font = new Font("Microsoft Sans Serif", 15F);
            cboMetodo.ForeColor = Color.Black;
            cboMetodo.FormattingEnabled = true;
            cboMetodo.HoverSelectionColor = Color.Empty;
            cboMetodo.IntegralHeight = false;
            cboMetodo.ItemHeight = 35;
            cboMetodo.Location = new Point(109, 248);
            cboMetodo.Name = "cboMetodo";
            cboMetodo.Size = new Size(178, 41);
            cboMetodo.StartIndex = 0;
            cboMetodo.TabIndex = 25;
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = Color.White;
            txtDescricao.BaseColor = Color.FromArgb(44, 55, 66);
            txtDescricao.BorderColorA = Color.FromArgb(64, 158, 255);
            txtDescricao.BorderColorB = Color.FromArgb(220, 223, 230);
            txtDescricao.Font = new Font("Microsoft Sans Serif", 16F);
            txtDescricao.ForeColor = Color.Black;
            txtDescricao.Hint = "descrição";
            txtDescricao.ImeMode = ImeMode.NoControl;
            txtDescricao.Location = new Point(109, 188);
            txtDescricao.MaxLength = 32767;
            txtDescricao.Multiline = false;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PasswordChar = '\0';
            txtDescricao.ScrollBars = ScrollBars.None;
            txtDescricao.SelectedText = "";
            txtDescricao.SelectionLength = 0;
            txtDescricao.SelectionStart = 0;
            txtDescricao.Size = new Size(551, 41);
            txtDescricao.TabIndex = 24;
            txtDescricao.TabStop = false;
            txtDescricao.UseSystemPasswordChar = false;
            // 
            // txtValor
            // 
            txtValor.BackColor = Color.White;
            txtValor.BaseColor = Color.FromArgb(44, 55, 66);
            txtValor.BorderColorA = Color.FromArgb(64, 158, 255);
            txtValor.BorderColorB = Color.FromArgb(220, 223, 230);
            txtValor.Font = new Font("Microsoft Sans Serif", 16F);
            txtValor.ForeColor = Color.Black;
            txtValor.Hint = "valor";
            txtValor.ImeMode = ImeMode.NoControl;
            txtValor.Location = new Point(109, 69);
            txtValor.MaxLength = 32767;
            txtValor.Multiline = false;
            txtValor.Name = "txtValor";
            txtValor.PasswordChar = '\0';
            txtValor.ScrollBars = ScrollBars.None;
            txtValor.SelectedText = "";
            txtValor.SelectionLength = 0;
            txtValor.SelectionStart = 0;
            txtValor.Size = new Size(362, 41);
            txtValor.TabIndex = 23;
            txtValor.TabStop = false;
            txtValor.UseSystemPasswordChar = false;
            // 
            // cboTipo
            // 
            cboTipo.BackColor = Color.FromArgb(246, 246, 246);
            cboTipo.ColorA = Color.FromArgb(246, 132, 85);
            cboTipo.ColorB = Color.FromArgb(231, 108, 57);
            cboTipo.ColorC = Color.FromArgb(242, 241, 240);
            cboTipo.ColorD = Color.FromArgb(253, 252, 252);
            cboTipo.ColorE = Color.FromArgb(239, 237, 236);
            cboTipo.ColorF = Color.FromArgb(180, 180, 180);
            cboTipo.ColorG = Color.FromArgb(119, 119, 118);
            cboTipo.ColorH = Color.FromArgb(224, 222, 220);
            cboTipo.ColorI = Color.FromArgb(250, 249, 249);
            cboTipo.DrawMode = DrawMode.OwnerDrawFixed;
            cboTipo.DropDownHeight = 100;
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.Font = new Font("Microsoft Sans Serif", 15F);
            cboTipo.ForeColor = Color.Black;
            cboTipo.FormattingEnabled = true;
            cboTipo.HoverSelectionColor = Color.Empty;
            cboTipo.IntegralHeight = false;
            cboTipo.ItemHeight = 35;
            cboTipo.Location = new Point(492, 69);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(168, 41);
            cboTipo.StartIndex = 0;
            cboTipo.TabIndex = 30;
            // 
            // TransactionFrom
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 409);
            Controls.Add(cboTipo);
            Controls.Add(chkPago);
            Controls.Add(dtpDate);
            Controls.Add(cboConta);
            Controls.Add(cboCategoria);
            Controls.Add(cboMetodo);
            Controls.Add(txtDescricao);
            Controls.Add(txtValor);
            Name = "TransactionFrom";
            Text = "TransactionFrom";
            Controls.SetChildIndex(txtValor, 0);
            Controls.SetChildIndex(txtDescricao, 0);
            Controls.SetChildIndex(cboMetodo, 0);
            Controls.SetChildIndex(cboCategoria, 0);
            Controls.SetChildIndex(cboConta, 0);
            Controls.SetChildIndex(dtpDate, 0);
            Controls.SetChildIndex(chkPago, 0);
            Controls.SetChildIndex(cboTipo, 0);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CyberCheckBox chkPago;
        private DateTimePicker dtpDate;
        private ReaLTaiizor.Controls.DungeonComboBox cboConta;
        private ReaLTaiizor.Controls.DungeonComboBox cboCategoria;
        private ReaLTaiizor.Controls.DungeonComboBox cboMetodo;
        private ReaLTaiizor.Controls.HopeTextBox txtDescricao;
        private ReaLTaiizor.Controls.HopeTextBox txtValor;
        private ReaLTaiizor.Controls.DungeonComboBox cboTipo;
    }
}