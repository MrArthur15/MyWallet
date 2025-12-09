namespace MyWallet.App.Base
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            panel1 = new Panel();
            btnVoltar = new ReaLTaiizor.Controls.HopeRoundButton();
            btnCriar = new ReaLTaiizor.Controls.HopeRoundButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(btnCriar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(2, 618);
            panel1.Name = "panel1";
            panel1.Size = new Size(996, 80);
            panel1.TabIndex = 0;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnVoltar.BorderColor = Color.FromArgb(220, 223, 230);
            btnVoltar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnVoltar.DangerColor = Color.FromArgb(245, 108, 108);
            btnVoltar.DefaultColor = Color.FromArgb(255, 255, 255);
            btnVoltar.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnVoltar.InfoColor = Color.FromArgb(144, 147, 153);
            btnVoltar.Location = new Point(331, 16);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.PrimaryColor = Color.FromArgb(150, 0, 255);
            btnVoltar.Size = new Size(120, 50);
            btnVoltar.SuccessColor = Color.FromArgb(103, 194, 58);
            btnVoltar.TabIndex = 21;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.White;
            btnVoltar.WarningColor = Color.FromArgb(230, 162, 60);
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnCriar
            // 
            btnCriar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnCriar.BorderColor = Color.FromArgb(220, 223, 230);
            btnCriar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCriar.DangerColor = Color.FromArgb(245, 108, 108);
            btnCriar.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCriar.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCriar.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCriar.InfoColor = Color.FromArgb(144, 147, 153);
            btnCriar.Location = new Point(529, 16);
            btnCriar.Name = "btnCriar";
            btnCriar.PrimaryColor = Color.FromArgb(150, 0, 255);
            btnCriar.Size = new Size(120, 50);
            btnCriar.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCriar.TabIndex = 20;
            btnCriar.Text = "Criar";
            btnCriar.TextColor = Color.White;
            btnCriar.WarningColor = Color.FromArgb(230, 162, 60);
            btnCriar.Click += btnCriar_Click;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 6, 52);
            ClientSize = new Size(1000, 700);
            Controls.Add(panel1);
            HeaderColor = Color.FromArgb(192, 102, 255);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Image = null;
            MaximizeBox = false;
            Name = "BaseForm";
            StartPosition = FormStartPosition.CenterParent;
            TitleColor = Color.Black;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.HopeRoundButton btnVoltar;
        private ReaLTaiizor.Controls.HopeRoundButton btnCriar;
    }
}