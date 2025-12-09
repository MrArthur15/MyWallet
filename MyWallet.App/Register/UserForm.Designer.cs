namespace MyWallet.App.Register
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            panel1 = new ReaLTaiizor.Controls.Panel();
            dtpDataNacimento = new DateTimePicker();
            cboUserType = new ReaLTaiizor.Controls.DungeonComboBox();
            txtEmail = new ReaLTaiizor.Controls.HopeTextBox();
            txtSenha = new ReaLTaiizor.Controls.HopeTextBox();
            btnVoltar2 = new ReaLTaiizor.Controls.HopeRoundButton();
            btnCriar = new ReaLTaiizor.Controls.HopeRoundButton();
            txtUsuario = new ReaLTaiizor.Controls.HopeTextBox();
            txtDocumento = new ReaLTaiizor.Controls.HopeTextBox();
            txtNome = new ReaLTaiizor.Controls.HopeTextBox();
            btnVoltar = new ReaLTaiizor.Controls.HopeRoundButton();
            btnEntrar = new ReaLTaiizor.Controls.HopeRoundButton();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // crownLabel1
            // 
            crownLabel1.Font = new Font("Microsoft Sans Serif", 25F);
            crownLabel1.ForeColor = Color.Black;
            crownLabel1.Location = new Point(0, 19);
            crownLabel1.Name = "crownLabel1";
            crownLabel1.Size = new Size(350, 39);
            crownLabel1.TabIndex = 6;
            crownLabel1.Text = "Nova Carteira";
            crownLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(192, 102, 255);
            panel1.Controls.Add(dtpDataNacimento);
            panel1.Controls.Add(cboUserType);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(btnVoltar2);
            panel1.Controls.Add(btnCriar);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(txtDocumento);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(crownLabel1);
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(btnEntrar);
            panel1.EdgeColor = Color.FromArgb(32, 41, 50);
            panel1.Location = new Point(42, 73);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(350, 581);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 1;
            panel1.Text = "panel1";
            // 
            // dtpDataNacimento
            // 
            dtpDataNacimento.DropDownAlign = LeftRightAlignment.Right;
            dtpDataNacimento.Font = new Font("Microsoft Sans Serif", 22F);
            dtpDataNacimento.Format = DateTimePickerFormat.Short;
            dtpDataNacimento.Location = new Point(24, 387);
            dtpDataNacimento.Name = "dtpDataNacimento";
            dtpDataNacimento.Size = new Size(300, 41);
            dtpDataNacimento.TabIndex = 3;
            dtpDataNacimento.Value = new DateTime(2025, 12, 8, 17, 7, 5, 0);
            // 
            // cboUserType
            // 
            cboUserType.BackColor = Color.FromArgb(246, 246, 246);
            cboUserType.ColorA = Color.FromArgb(246, 132, 85);
            cboUserType.ColorB = Color.FromArgb(231, 108, 57);
            cboUserType.ColorC = Color.FromArgb(242, 241, 240);
            cboUserType.ColorD = Color.FromArgb(253, 252, 252);
            cboUserType.ColorE = Color.FromArgb(239, 237, 236);
            cboUserType.ColorF = Color.FromArgb(180, 180, 180);
            cboUserType.ColorG = Color.FromArgb(119, 119, 118);
            cboUserType.ColorH = Color.FromArgb(224, 222, 220);
            cboUserType.ColorI = Color.FromArgb(250, 249, 249);
            cboUserType.DrawMode = DrawMode.OwnerDrawFixed;
            cboUserType.DropDownHeight = 100;
            cboUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUserType.Font = new Font("Microsoft Sans Serif", 15F);
            cboUserType.ForeColor = Color.Black;
            cboUserType.FormattingEnabled = true;
            cboUserType.HoverSelectionColor = Color.Empty;
            cboUserType.IntegralHeight = false;
            cboUserType.ItemHeight = 35;
            cboUserType.Location = new Point(87, 450);
            cboUserType.Name = "cboUserType";
            cboUserType.Size = new Size(180, 41);
            cboUserType.StartIndex = 0;
            cboUserType.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BaseColor = Color.FromArgb(44, 55, 66);
            txtEmail.BorderColorA = Color.FromArgb(64, 158, 255);
            txtEmail.BorderColorB = Color.FromArgb(220, 223, 230);
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Hint = "email";
            txtEmail.ImeMode = ImeMode.NoControl;
            txtEmail.Location = new Point(24, 262);
            txtEmail.MaxLength = 32767;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.ScrollBars = ScrollBars.None;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.Size = new Size(300, 41);
            txtEmail.TabIndex = 22;
            txtEmail.TabStop = false;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.White;
            txtSenha.BaseColor = Color.FromArgb(44, 55, 66);
            txtSenha.BorderColorA = Color.FromArgb(64, 158, 255);
            txtSenha.BorderColorB = Color.FromArgb(220, 223, 230);
            txtSenha.Font = new Font("Microsoft Sans Serif", 16F);
            txtSenha.ForeColor = Color.Black;
            txtSenha.Hint = "senha";
            txtSenha.ImeMode = ImeMode.NoControl;
            txtSenha.Location = new Point(24, 325);
            txtSenha.MaxLength = 32767;
            txtSenha.Multiline = false;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '\0';
            txtSenha.ScrollBars = ScrollBars.None;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.Size = new Size(300, 41);
            txtSenha.TabIndex = 21;
            txtSenha.TabStop = false;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnVoltar2
            // 
            btnVoltar2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVoltar2.BorderColor = Color.FromArgb(220, 223, 230);
            btnVoltar2.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnVoltar2.DangerColor = Color.FromArgb(245, 108, 108);
            btnVoltar2.DefaultColor = Color.FromArgb(255, 255, 255);
            btnVoltar2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar2.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnVoltar2.InfoColor = Color.FromArgb(144, 147, 153);
            btnVoltar2.Location = new Point(24, 514);
            btnVoltar2.Name = "btnVoltar2";
            btnVoltar2.PrimaryColor = Color.FromArgb(150, 0, 255);
            btnVoltar2.Size = new Size(120, 50);
            btnVoltar2.SuccessColor = Color.FromArgb(103, 194, 58);
            btnVoltar2.TabIndex = 19;
            btnVoltar2.Text = "Voltar";
            btnVoltar2.TextColor = Color.White;
            btnVoltar2.WarningColor = Color.FromArgb(230, 162, 60);
            btnVoltar2.Click += btnVoltar2_Click;
            // 
            // btnCriar
            // 
            btnCriar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCriar.BorderColor = Color.FromArgb(220, 223, 230);
            btnCriar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCriar.DangerColor = Color.FromArgb(245, 108, 108);
            btnCriar.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCriar.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCriar.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCriar.InfoColor = Color.FromArgb(144, 147, 153);
            btnCriar.Location = new Point(222, 514);
            btnCriar.Name = "btnCriar";
            btnCriar.PrimaryColor = Color.FromArgb(150, 0, 255);
            btnCriar.Size = new Size(120, 50);
            btnCriar.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCriar.TabIndex = 18;
            btnCriar.Text = "Criar";
            btnCriar.TextColor = Color.White;
            btnCriar.WarningColor = Color.FromArgb(230, 162, 60);
            btnCriar.Click += btnCriar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BaseColor = Color.FromArgb(44, 55, 66);
            txtUsuario.BorderColorA = Color.FromArgb(64, 158, 255);
            txtUsuario.BorderColorB = Color.FromArgb(220, 223, 230);
            txtUsuario.Font = new Font("Microsoft Sans Serif", 16F);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Hint = "usuario";
            txtUsuario.ImeMode = ImeMode.NoControl;
            txtUsuario.Location = new Point(24, 202);
            txtUsuario.MaxLength = 32767;
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PasswordChar = '\0';
            txtUsuario.ScrollBars = ScrollBars.None;
            txtUsuario.SelectedText = "";
            txtUsuario.SelectionLength = 0;
            txtUsuario.SelectionStart = 0;
            txtUsuario.Size = new Size(300, 41);
            txtUsuario.TabIndex = 13;
            txtUsuario.TabStop = false;
            txtUsuario.UseSystemPasswordChar = false;
            // 
            // txtDocumento
            // 
            txtDocumento.BackColor = Color.White;
            txtDocumento.BaseColor = Color.FromArgb(44, 55, 66);
            txtDocumento.BorderColorA = Color.FromArgb(64, 158, 255);
            txtDocumento.BorderColorB = Color.FromArgb(220, 223, 230);
            txtDocumento.Font = new Font("Microsoft Sans Serif", 16F);
            txtDocumento.ForeColor = Color.Black;
            txtDocumento.Hint = "cpf/cnpj";
            txtDocumento.ImeMode = ImeMode.NoControl;
            txtDocumento.Location = new Point(24, 141);
            txtDocumento.MaxLength = 32767;
            txtDocumento.Multiline = false;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.PasswordChar = '\0';
            txtDocumento.ScrollBars = ScrollBars.None;
            txtDocumento.SelectedText = "";
            txtDocumento.SelectionLength = 0;
            txtDocumento.SelectionStart = 0;
            txtDocumento.Size = new Size(300, 41);
            txtDocumento.TabIndex = 7;
            txtDocumento.TabStop = false;
            txtDocumento.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.BaseColor = Color.FromArgb(44, 55, 66);
            txtNome.BorderColorA = Color.FromArgb(64, 158, 255);
            txtNome.BorderColorB = Color.FromArgb(220, 223, 230);
            txtNome.Font = new Font("Microsoft Sans Serif", 16F);
            txtNome.ForeColor = Color.Black;
            txtNome.Hint = "nome";
            txtNome.ImeMode = ImeMode.NoControl;
            txtNome.Location = new Point(24, 79);
            txtNome.MaxLength = 32767;
            txtNome.Multiline = false;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.ScrollBars = ScrollBars.None;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.Size = new Size(300, 41);
            txtNome.TabIndex = 1;
            txtNome.TabStop = false;
            txtNome.UseSystemPasswordChar = false;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVoltar.BorderColor = Color.FromArgb(220, 223, 230);
            btnVoltar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnVoltar.DangerColor = Color.FromArgb(245, 108, 108);
            btnVoltar.DefaultColor = Color.FromArgb(255, 255, 255);
            btnVoltar.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnVoltar.InfoColor = Color.FromArgb(144, 147, 153);
            btnVoltar.Location = new Point(8, 660);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.PrimaryColor = Color.FromArgb(150, 0, 255);
            btnVoltar.Size = new Size(100, 35);
            btnVoltar.SuccessColor = Color.FromArgb(103, 194, 58);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.White;
            btnVoltar.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEntrar.BorderColor = Color.FromArgb(220, 223, 230);
            btnEntrar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnEntrar.DangerColor = Color.FromArgb(245, 108, 108);
            btnEntrar.DefaultColor = Color.FromArgb(255, 255, 255);
            btnEntrar.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnEntrar.InfoColor = Color.FromArgb(144, 147, 153);
            btnEntrar.Location = new Point(192, 660);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.PrimaryColor = Color.FromArgb(150, 0, 255);
            btnEntrar.Size = new Size(100, 35);
            btnEntrar.SuccessColor = Color.FromArgb(103, 194, 58);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.TextColor = Color.White;
            btnEntrar.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(500, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 6, 52);
            ClientSize = new Size(1000, 700);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            HeaderColor = Color.FromArgb(192, 102, 255);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Image = (Image)resources.GetObject("$this.Image");
            MaximizeBox = false;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MyWallet";
            TitleColor = Color.Black;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.HopeTextBox txtDocumento;
        private ReaLTaiizor.Controls.HopeTextBox txtNome;
        private ReaLTaiizor.Controls.HopeRoundButton btnVoltar;
        private ReaLTaiizor.Controls.HopeRoundButton btnEntrar;

        private ReaLTaiizor.Controls.HopeTextBox txtUsuario;
        private ReaLTaiizor.Controls.HopeRoundButton btnVoltar2;
        private ReaLTaiizor.Controls.HopeRoundButton btnCriar;
        private ReaLTaiizor.Controls.HopeTextBox txtSenha;
        private ReaLTaiizor.Controls.HopeTextBox txtEmail;
        private ReaLTaiizor.Controls.DungeonComboBox cboUserType;
        private PictureBox pictureBox1;
        private DateTimePicker dtpDataNacimento;
        
    }
}