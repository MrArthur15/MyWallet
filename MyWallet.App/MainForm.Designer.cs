namespace MyWallet.App
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            imageList1 = new ImageList(components);
            airTabPage1 = new ReaLTaiizor.Controls.AirTabPage();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnCriar1 = new ReaLTaiizor.Controls.HopeRoundButton();
            btnEditar1 = new ReaLTaiizor.Controls.HopeRoundButton();
            btnDeletar1 = new ReaLTaiizor.Controls.HopeRoundButton();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            airTabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "home.png");
            imageList1.Images.SetKeyName(1, "user.png");
            // 
            // airTabPage1
            // 
            airTabPage1.Alignment = TabAlignment.Left;
            airTabPage1.BaseColor = Color.FromArgb(150, 0, 255);
            airTabPage1.Controls.Add(tabPage1);
            airTabPage1.Controls.Add(tabPage2);
            airTabPage1.Controls.Add(tabPage3);
            airTabPage1.Controls.Add(tabPage4);
            airTabPage1.Controls.Add(tabPage5);
            airTabPage1.Controls.Add(tabPage6);
            airTabPage1.Controls.Add(tabPage7);
            airTabPage1.Dock = DockStyle.Fill;
            airTabPage1.ImageList = imageList1;
            airTabPage1.ItemSize = new Size(60, 80);
            airTabPage1.Location = new Point(2, 36);
            airTabPage1.Multiline = true;
            airTabPage1.Name = "airTabPage1";
            airTabPage1.NormalTextColor = SystemColors.Desktop;
            airTabPage1.SelectedIndex = 0;
            airTabPage1.SelectedTabBackColor = Color.FromArgb(10, 6, 52);
            airTabPage1.SelectedTextColor = Color.Black;
            airTabPage1.ShowOuterBorders = false;
            airTabPage1.Size = new Size(1276, 682);
            airTabPage1.SizeMode = TabSizeMode.Fixed;
            airTabPage1.SquareColor = Color.FromArgb(10, 6, 52);
            airTabPage1.TabCursor = Cursors.Hand;
            airTabPage1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(10, 6, 52);
            tabPage1.ImageIndex = 0;
            tabPage1.Location = new Point(84, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1188, 674);
            tabPage1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(10, 6, 52);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(panel1);
            tabPage2.ImageIndex = 1;
            tabPage2.Location = new Point(84, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1188, 674);
            tabPage2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(21, 16, 70);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1182, 588);
            dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCriar1);
            panel1.Controls.Add(btnEditar1);
            panel1.Controls.Add(btnDeletar1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 591);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 80);
            panel1.TabIndex = 0;
            // 
            // btnCriar1
            // 
            btnCriar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCriar1.BorderColor = Color.FromArgb(220, 223, 230);
            btnCriar1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCriar1.DangerColor = Color.FromArgb(245, 108, 108);
            btnCriar1.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCriar1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCriar1.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCriar1.InfoColor = Color.FromArgb(144, 147, 153);
            btnCriar1.Location = new Point(737, 18);
            btnCriar1.Name = "btnCriar1";
            btnCriar1.PrimaryColor = Color.FromArgb(150, 0, 255);
            btnCriar1.Size = new Size(125, 50);
            btnCriar1.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCriar1.TabIndex = 5;
            btnCriar1.Text = "Cirar";
            btnCriar1.TextColor = Color.White;
            btnCriar1.WarningColor = Color.FromArgb(230, 162, 60);
            btnCriar1.Click += btnCriar1_Click;
            // 
            // btnEditar1
            // 
            btnEditar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar1.BorderColor = Color.FromArgb(220, 223, 230);
            btnEditar1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnEditar1.DangerColor = Color.FromArgb(245, 108, 108);
            btnEditar1.DefaultColor = Color.FromArgb(255, 255, 255);
            btnEditar1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar1.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnEditar1.InfoColor = Color.FromArgb(144, 147, 153);
            btnEditar1.Location = new Point(892, 18);
            btnEditar1.Name = "btnEditar1";
            btnEditar1.PrimaryColor = Color.FromArgb(150, 0, 255);
            btnEditar1.Size = new Size(125, 50);
            btnEditar1.SuccessColor = Color.FromArgb(103, 194, 58);
            btnEditar1.TabIndex = 4;
            btnEditar1.Text = "Editar";
            btnEditar1.TextColor = Color.White;
            btnEditar1.WarningColor = Color.FromArgb(230, 162, 60);
            btnEditar1.Click += btnEditar1_Click;
            // 
            // btnDeletar1
            // 
            btnDeletar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeletar1.BorderColor = Color.FromArgb(220, 223, 230);
            btnDeletar1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnDeletar1.DangerColor = Color.FromArgb(245, 108, 108);
            btnDeletar1.DefaultColor = Color.FromArgb(255, 255, 255);
            btnDeletar1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeletar1.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnDeletar1.InfoColor = Color.FromArgb(144, 147, 153);
            btnDeletar1.Location = new Point(1038, 18);
            btnDeletar1.Name = "btnDeletar1";
            btnDeletar1.PrimaryColor = Color.FromArgb(150, 0, 255);
            btnDeletar1.Size = new Size(125, 50);
            btnDeletar1.SuccessColor = Color.FromArgb(103, 194, 58);
            btnDeletar1.TabIndex = 3;
            btnDeletar1.Text = "Deletar";
            btnDeletar1.TextColor = Color.White;
            btnDeletar1.WarningColor = Color.FromArgb(230, 162, 60);
            btnDeletar1.Click += btnDeletar1_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(10, 6, 52);
            tabPage3.Location = new Point(84, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1188, 674);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(10, 6, 52);
            tabPage4.Location = new Point(84, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1188, 674);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.FromArgb(10, 6, 52);
            tabPage5.Location = new Point(84, 4);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1188, 674);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.FromArgb(10, 6, 52);
            tabPage6.Location = new Point(84, 4);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1188, 674);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "tabPage6";
            // 
            // tabPage7
            // 
            tabPage7.BackColor = Color.FromArgb(10, 6, 52);
            tabPage7.Location = new Point(84, 4);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(1188, 674);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "tabPage7";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 6, 52);
            ClientSize = new Size(1280, 720);
            Controls.Add(airTabPage1);
            HeaderColor = Color.FromArgb(192, 102, 255);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Image = Properties.Resources.wallet;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "MyWallet";
            TitleColor = Color.Black;
            WindowState = FormWindowState.Maximized;
            airTabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private ReaLTaiizor.Controls.AirTabPage airTabPage1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private Panel panel1;
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.HopeRoundButton btnCriar1;
        private ReaLTaiizor.Controls.HopeRoundButton btnEditar;
        private ReaLTaiizor.Controls.HopeRoundButton btnDeletar1;
        private ReaLTaiizor.Controls.HopeRoundButton btnEditar1;
    }
}