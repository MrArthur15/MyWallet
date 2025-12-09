namespace MyWallet.App.Register
{
    partial class CategoryForm
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
            cboType = new ReaLTaiizor.Controls.DungeonComboBox();
            cboPrioridade = new ReaLTaiizor.Controls.DungeonComboBox();
            txtLimit = new ReaLTaiizor.Controls.HopeTextBox();
            txtNome = new ReaLTaiizor.Controls.HopeTextBox();
            SuspendLayout();
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
            cboType.Location = new Point(351, 184);
            cboType.Name = "cboType";
            cboType.Size = new Size(162, 41);
            cboType.StartIndex = 0;
            cboType.TabIndex = 13;
            // 
            // cboPrioridade
            // 
            cboPrioridade.BackColor = Color.FromArgb(246, 246, 246);
            cboPrioridade.ColorA = Color.FromArgb(246, 132, 85);
            cboPrioridade.ColorB = Color.FromArgb(231, 108, 57);
            cboPrioridade.ColorC = Color.FromArgb(242, 241, 240);
            cboPrioridade.ColorD = Color.FromArgb(253, 252, 252);
            cboPrioridade.ColorE = Color.FromArgb(239, 237, 236);
            cboPrioridade.ColorF = Color.FromArgb(180, 180, 180);
            cboPrioridade.ColorG = Color.FromArgb(119, 119, 118);
            cboPrioridade.ColorH = Color.FromArgb(224, 222, 220);
            cboPrioridade.ColorI = Color.FromArgb(250, 249, 249);
            cboPrioridade.DrawMode = DrawMode.OwnerDrawFixed;
            cboPrioridade.DropDownHeight = 100;
            cboPrioridade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPrioridade.Font = new Font("Microsoft Sans Serif", 15F);
            cboPrioridade.ForeColor = Color.Black;
            cboPrioridade.FormattingEnabled = true;
            cboPrioridade.HoverSelectionColor = Color.Empty;
            cboPrioridade.IntegralHeight = false;
            cboPrioridade.ItemHeight = 35;
            cboPrioridade.Location = new Point(195, 184);
            cboPrioridade.Name = "cboPrioridade";
            cboPrioridade.Size = new Size(131, 41);
            cboPrioridade.StartIndex = 0;
            cboPrioridade.TabIndex = 12;
            // 
            // txtLimit
            // 
            txtLimit.BackColor = Color.White;
            txtLimit.BaseColor = Color.FromArgb(44, 55, 66);
            txtLimit.BorderColorA = Color.FromArgb(64, 158, 255);
            txtLimit.BorderColorB = Color.FromArgb(220, 223, 230);
            txtLimit.Font = new Font("Microsoft Sans Serif", 16F);
            txtLimit.ForeColor = Color.Black;
            txtLimit.Hint = "limite de gasto";
            txtLimit.ImeMode = ImeMode.NoControl;
            txtLimit.Location = new Point(244, 124);
            txtLimit.MaxLength = 32767;
            txtLimit.Multiline = false;
            txtLimit.Name = "txtLimit";
            txtLimit.PasswordChar = '\0';
            txtLimit.ScrollBars = ScrollBars.None;
            txtLimit.SelectedText = "";
            txtLimit.SelectionLength = 0;
            txtLimit.SelectionStart = 0;
            txtLimit.Size = new Size(200, 41);
            txtLimit.TabIndex = 11;
            txtLimit.TabStop = false;
            txtLimit.UseSystemPasswordChar = false;
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
            txtNome.Location = new Point(195, 62);
            txtNome.MaxLength = 32767;
            txtNome.Multiline = false;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.ScrollBars = ScrollBars.None;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.Size = new Size(318, 41);
            txtNome.TabIndex = 10;
            txtNome.TabStop = false;
            txtNome.UseSystemPasswordChar = false;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 335);
            Controls.Add(cboType);
            Controls.Add(cboPrioridade);
            Controls.Add(txtLimit);
            Controls.Add(txtNome);
            Name = "CategoryForm";
            Text = "Categoria";
            Controls.SetChildIndex(txtNome, 0);
            Controls.SetChildIndex(txtLimit, 0);
            Controls.SetChildIndex(cboPrioridade, 0);
            Controls.SetChildIndex(cboType, 0);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonComboBox cboType;
        private ReaLTaiizor.Controls.DungeonComboBox cboPrioridade;
        private ReaLTaiizor.Controls.HopeTextBox txtLimit;
        private ReaLTaiizor.Controls.HopeTextBox txtNome;
    }
}