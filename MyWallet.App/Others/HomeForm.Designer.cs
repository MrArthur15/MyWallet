namespace MyWallet.App.Others
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            btnCadastrar = new ReaLTaiizor.Controls.HopeRoundButton();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            btnEntrar = new ReaLTaiizor.Controls.HopeRoundButton();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCadastrar.BorderColor = Color.FromArgb(220, 223, 230);
            btnCadastrar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCadastrar.DangerColor = Color.FromArgb(245, 108, 108);
            btnCadastrar.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCadastrar.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCadastrar.InfoColor = Color.FromArgb(144, 147, 153);
            btnCadastrar.Location = new Point(45, 536);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.PrimaryColor = Color.FromArgb(150, 0, 255);
            btnCadastrar.Size = new Size(150, 50);
            btnCadastrar.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextColor = Color.White;
            btnCadastrar.WarningColor = Color.FromArgb(230, 162, 60);
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Microsoft Sans Serif", 50F);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(77, 65);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(306, 76);
            bigLabel1.TabIndex = 1;
            bigLabel1.Text = "MyWallet";
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
            btnEntrar.Location = new Point(311, 536);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.PrimaryColor = Color.FromArgb(150, 0, 255);
            btnEntrar.Size = new Size(118, 50);
            btnEntrar.SuccessColor = Color.FromArgb(103, 194, 58);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.TextColor = Color.White;
            btnEntrar.WarningColor = Color.FromArgb(230, 162, 60);
            btnEntrar.Click += btnEntrar_Click;
            // 
            // bigLabel2
            // 
            bigLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Microsoft Sans Serif", 15F);
            bigLabel2.ForeColor = Color.White;
            bigLabel2.Location = new Point(45, 248);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(384, 217);
            bigLabel2.TabIndex = 3;
            bigLabel2.Text = resources.GetString("bigLabel2.Text");
            bigLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(495, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 6, 52);
            ClientSize = new Size(1000, 686);
            Controls.Add(pictureBox1);
            Controls.Add(bigLabel2);
            Controls.Add(btnEntrar);
            Controls.Add(bigLabel1);
            Controls.Add(btnCadastrar);
            HeaderColor = Color.FromArgb(192, 102, 255);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Image = Properties.Resources.wallet;
            MaximizeBox = false;
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyWallet";
            TitleColor = Color.Black;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.HopeRoundButton btnCadastrar;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.HopeRoundButton btnEntrar;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private PictureBox pictureBox1;
    }
}