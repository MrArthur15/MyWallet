namespace MyWallet.App.Others
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new ReaLTaiizor.Controls.Panel();
            btnVoltar1 = new ReaLTaiizor.Controls.HopeRoundButton();
            txtSenha = new ReaLTaiizor.Controls.HopeTextBox();
            txtUsuaruio = new ReaLTaiizor.Controls.HopeTextBox();
            crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            btnEntrar = new ReaLTaiizor.Controls.HopeRoundButton();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(192, 102, 255);
            panel1.Controls.Add(btnVoltar1);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtUsuaruio);
            panel1.Controls.Add(crownLabel1);
            panel1.Controls.Add(btnEntrar);
            panel1.EdgeColor = Color.FromArgb(32, 41, 50);
            panel1.Location = new Point(80, 200);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(350, 315);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 0;
            panel1.Text = "panel1";
            // 
            // btnVoltar1
            // 
            btnVoltar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVoltar1.BorderColor = Color.FromArgb(220, 223, 230);
            btnVoltar1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnVoltar1.DangerColor = Color.FromArgb(245, 108, 108);
            btnVoltar1.DefaultColor = Color.FromArgb(255, 255, 255);
            btnVoltar1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar1.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnVoltar1.InfoColor = Color.FromArgb(144, 147, 153);
            btnVoltar1.Location = new Point(24, 246);
            btnVoltar1.Name = "btnVoltar1";
            btnVoltar1.PrimaryColor = Color.FromArgb(150, 0, 255);
            btnVoltar1.Size = new Size(120, 50);
            btnVoltar1.SuccessColor = Color.FromArgb(103, 194, 58);
            btnVoltar1.TabIndex = 5;
            btnVoltar1.Text = "Voltar";
            btnVoltar1.TextColor = Color.White;
            btnVoltar1.WarningColor = Color.FromArgb(230, 162, 60);
            btnVoltar1.Click += btnVoltar1_Click;
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
            txtSenha.Location = new Point(24, 168);
            txtSenha.MaxLength = 32767;
            txtSenha.Multiline = false;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '\0';
            txtSenha.ScrollBars = ScrollBars.None;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.Size = new Size(300, 41);
            txtSenha.TabIndex = 7;
            txtSenha.TabStop = false;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsuaruio
            // 
            txtUsuaruio.BackColor = Color.White;
            txtUsuaruio.BaseColor = Color.FromArgb(44, 55, 66);
            txtUsuaruio.BorderColorA = Color.FromArgb(64, 158, 255);
            txtUsuaruio.BorderColorB = Color.FromArgb(220, 223, 230);
            txtUsuaruio.Font = new Font("Microsoft Sans Serif", 16F);
            txtUsuaruio.ForeColor = Color.Black;
            txtUsuaruio.Hint = "usuario";
            txtUsuaruio.ImeMode = ImeMode.NoControl;
            txtUsuaruio.Location = new Point(24, 83);
            txtUsuaruio.MaxLength = 32767;
            txtUsuaruio.Multiline = false;
            txtUsuaruio.Name = "txtUsuaruio";
            txtUsuaruio.PasswordChar = '\0';
            txtUsuaruio.ScrollBars = ScrollBars.None;
            txtUsuaruio.SelectedText = "";
            txtUsuaruio.SelectionLength = 0;
            txtUsuaruio.SelectionStart = 0;
            txtUsuaruio.Size = new Size(300, 41);
            txtUsuaruio.TabIndex = 1;
            txtUsuaruio.TabStop = false;
            txtUsuaruio.UseSystemPasswordChar = false;
            // 
            // crownLabel1
            // 
            crownLabel1.Font = new Font("Microsoft Sans Serif", 25F);
            crownLabel1.ForeColor = Color.Black;
            crownLabel1.Location = new Point(0, 14);
            crownLabel1.Name = "crownLabel1";
            crownLabel1.Size = new Size(350, 39);
            crownLabel1.TabIndex = 6;
            crownLabel1.Text = "Acesse sua conta";
            crownLabel1.TextAlign = ContentAlignment.MiddleCenter;
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
            btnEntrar.Location = new Point(204, 246);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.PrimaryColor = Color.FromArgb(150, 0, 255);
            btnEntrar.Size = new Size(120, 50);
            btnEntrar.SuccessColor = Color.FromArgb(103, 194, 58);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.TextColor = Color.White;
            btnEntrar.WarningColor = Color.FromArgb(230, 162, 60);
            btnEntrar.Click += btnEntrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(500, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 6, 52);
            ClientSize = new Size(1000, 700);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            HeaderColor = Color.FromArgb(192, 102, 255);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Image = Properties.Resources.wallet;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyWallet";
            TitleColor = Color.Black;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.HopeRoundButton btnEntrar;
        private ReaLTaiizor.Controls.HopeRoundButton btnVoltar1;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private ReaLTaiizor.Controls.HopeTextBox txtUsuaruio;
        private ReaLTaiizor.Controls.HopeTextBox txtSenha;
        private PictureBox pictureBox1;
    }
}