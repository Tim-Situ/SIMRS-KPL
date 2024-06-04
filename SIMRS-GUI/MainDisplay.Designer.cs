namespace SIMRS_GUI
{
    partial class MainDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDisplay));
            panelTop = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            hamburgerMenu = new PictureBox();
            panelDashboard = new Panel();
            buttonDashboard = new Button();
            panelPasien = new Panel();
            buttonPasien = new Button();
            panelDokter = new Panel();
            buttonDokter = new Button();
            panelObat = new Panel();
            buttonObat = new Button();
            panelPemeriksaan = new Panel();
            buttonPemeriksaan = new Button();
            panelPembayaran = new Panel();
            buttonPembayaran = new Button();
            sidebar = new ReaLTaiizor.Controls.ParrotGradientPanel();
            BodyPanel = new Panel();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hamburgerMenu).BeginInit();
            panelDashboard.SuspendLayout();
            panelPasien.SuspendLayout();
            panelDokter.SuspendLayout();
            panelObat.SuspendLayout();
            panelPemeriksaan.SuspendLayout();
            panelPembayaran.SuspendLayout();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.WhiteSmoke;
            panelTop.Controls.Add(nightControlBox1);
            panelTop.Controls.Add(hamburgerMenu);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1600, 49);
            panelTop.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1461, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // hamburgerMenu
            // 
            hamburgerMenu.Image = (Image)resources.GetObject("hamburgerMenu.Image");
            hamburgerMenu.Location = new Point(12, 6);
            hamburgerMenu.Name = "hamburgerMenu";
            hamburgerMenu.Size = new Size(37, 37);
            hamburgerMenu.SizeMode = PictureBoxSizeMode.CenterImage;
            hamburgerMenu.TabIndex = 1;
            hamburgerMenu.TabStop = false;
            hamburgerMenu.Click += HamburgerMenu_Click;
            // 
            // panelDashboard
            // 
            panelDashboard.BackColor = Color.Transparent;
            panelDashboard.Controls.Add(buttonDashboard);
            panelDashboard.ImeMode = ImeMode.NoControl;
            panelDashboard.Location = new Point(0, 20);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(250, 50);
            panelDashboard.TabIndex = 2;
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = Color.Transparent;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            buttonDashboard.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.Image = (Image)resources.GetObject("buttonDashboard.Image");
            buttonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.Location = new Point(-11, 0);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Padding = new Padding(25, 0, 0, 0);
            buttonDashboard.Size = new Size(261, 50);
            buttonDashboard.TabIndex = 3;
            buttonDashboard.Text = "        Dashboard";
            buttonDashboard.TextAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.UseVisualStyleBackColor = false;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // panelPasien
            // 
            panelPasien.BackColor = Color.Transparent;
            panelPasien.Controls.Add(buttonPasien);
            panelPasien.ImeMode = ImeMode.NoControl;
            panelPasien.Location = new Point(0, 76);
            panelPasien.Name = "panelPasien";
            panelPasien.Size = new Size(250, 50);
            panelPasien.TabIndex = 2;
            // 
            // buttonPasien
            // 
            buttonPasien.BackColor = Color.Transparent;
            buttonPasien.FlatAppearance.BorderSize = 0;
            buttonPasien.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            buttonPasien.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            buttonPasien.FlatStyle = FlatStyle.Flat;
            buttonPasien.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPasien.ForeColor = Color.White;
            buttonPasien.Image = (Image)resources.GetObject("buttonPasien.Image");
            buttonPasien.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPasien.Location = new Point(-11, 0);
            buttonPasien.Name = "buttonPasien";
            buttonPasien.Padding = new Padding(25, 0, 0, 0);
            buttonPasien.Size = new Size(261, 50);
            buttonPasien.TabIndex = 3;
            buttonPasien.Text = "        Pasien";
            buttonPasien.TextAlign = ContentAlignment.MiddleLeft;
            buttonPasien.UseVisualStyleBackColor = false;
            buttonPasien.Click += buttonPasien_Click;
            // 
            // panelDokter
            // 
            panelDokter.BackColor = Color.Transparent;
            panelDokter.Controls.Add(buttonDokter);
            panelDokter.ImeMode = ImeMode.NoControl;
            panelDokter.Location = new Point(0, 132);
            panelDokter.Name = "panelDokter";
            panelDokter.Size = new Size(250, 50);
            panelDokter.TabIndex = 2;
            // 
            // buttonDokter
            // 
            buttonDokter.BackColor = Color.Transparent;
            buttonDokter.FlatAppearance.BorderSize = 0;
            buttonDokter.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            buttonDokter.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            buttonDokter.FlatStyle = FlatStyle.Flat;
            buttonDokter.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDokter.ForeColor = Color.White;
            buttonDokter.Image = (Image)resources.GetObject("buttonDokter.Image");
            buttonDokter.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDokter.Location = new Point(-11, 0);
            buttonDokter.Name = "buttonDokter";
            buttonDokter.Padding = new Padding(25, 0, 0, 0);
            buttonDokter.Size = new Size(261, 50);
            buttonDokter.TabIndex = 3;
            buttonDokter.Text = "        Dokter";
            buttonDokter.TextAlign = ContentAlignment.MiddleLeft;
            buttonDokter.UseVisualStyleBackColor = false;
            // 
            // panelObat
            // 
            panelObat.BackColor = Color.Transparent;
            panelObat.Controls.Add(buttonObat);
            panelObat.ImeMode = ImeMode.NoControl;
            panelObat.Location = new Point(0, 188);
            panelObat.Name = "panelObat";
            panelObat.Size = new Size(250, 50);
            panelObat.TabIndex = 2;
            // 
            // buttonObat
            // 
            buttonObat.BackColor = Color.Transparent;
            buttonObat.FlatAppearance.BorderSize = 0;
            buttonObat.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            buttonObat.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            buttonObat.FlatStyle = FlatStyle.Flat;
            buttonObat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonObat.ForeColor = Color.White;
            buttonObat.Image = (Image)resources.GetObject("buttonObat.Image");
            buttonObat.ImageAlign = ContentAlignment.MiddleLeft;
            buttonObat.Location = new Point(-11, 0);
            buttonObat.Name = "buttonObat";
            buttonObat.Padding = new Padding(25, 0, 0, 0);
            buttonObat.Size = new Size(261, 50);
            buttonObat.TabIndex = 3;
            buttonObat.Text = "        Obat";
            buttonObat.TextAlign = ContentAlignment.MiddleLeft;
            buttonObat.UseVisualStyleBackColor = false;
            // 
            // panelPemeriksaan
            // 
            panelPemeriksaan.BackColor = Color.Transparent;
            panelPemeriksaan.Controls.Add(buttonPemeriksaan);
            panelPemeriksaan.ImeMode = ImeMode.NoControl;
            panelPemeriksaan.Location = new Point(0, 244);
            panelPemeriksaan.Name = "panelPemeriksaan";
            panelPemeriksaan.Size = new Size(250, 50);
            panelPemeriksaan.TabIndex = 2;
            // 
            // buttonPemeriksaan
            // 
            buttonPemeriksaan.BackColor = Color.Transparent;
            buttonPemeriksaan.FlatAppearance.BorderSize = 0;
            buttonPemeriksaan.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            buttonPemeriksaan.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            buttonPemeriksaan.FlatStyle = FlatStyle.Flat;
            buttonPemeriksaan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPemeriksaan.ForeColor = Color.White;
            buttonPemeriksaan.Image = (Image)resources.GetObject("buttonPemeriksaan.Image");
            buttonPemeriksaan.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPemeriksaan.Location = new Point(-11, 0);
            buttonPemeriksaan.Name = "buttonPemeriksaan";
            buttonPemeriksaan.Padding = new Padding(25, 0, 0, 0);
            buttonPemeriksaan.Size = new Size(261, 50);
            buttonPemeriksaan.TabIndex = 3;
            buttonPemeriksaan.Text = "        Pemeriksaan";
            buttonPemeriksaan.TextAlign = ContentAlignment.MiddleLeft;
            buttonPemeriksaan.UseVisualStyleBackColor = false;
            // 
            // panelPembayaran
            // 
            panelPembayaran.BackColor = Color.Transparent;
            panelPembayaran.Controls.Add(buttonPembayaran);
            panelPembayaran.ImeMode = ImeMode.NoControl;
            panelPembayaran.Location = new Point(0, 300);
            panelPembayaran.Name = "panelPembayaran";
            panelPembayaran.Size = new Size(250, 50);
            panelPembayaran.TabIndex = 2;
            // 
            // buttonPembayaran
            // 
            buttonPembayaran.BackColor = Color.Transparent;
            buttonPembayaran.FlatAppearance.BorderSize = 0;
            buttonPembayaran.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            buttonPembayaran.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            buttonPembayaran.FlatStyle = FlatStyle.Flat;
            buttonPembayaran.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPembayaran.ForeColor = Color.White;
            buttonPembayaran.Image = (Image)resources.GetObject("buttonPembayaran.Image");
            buttonPembayaran.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPembayaran.Location = new Point(-11, 0);
            buttonPembayaran.Name = "buttonPembayaran";
            buttonPembayaran.Padding = new Padding(25, 0, 0, 0);
            buttonPembayaran.Size = new Size(261, 50);
            buttonPembayaran.TabIndex = 3;
            buttonPembayaran.Text = "        Pembayaran";
            buttonPembayaran.TextAlign = ContentAlignment.MiddleLeft;
            buttonPembayaran.UseVisualStyleBackColor = false;
            // 
            // sidebar
            // 
            sidebar.BottomLeft = Color.FromArgb(0, 46, 69);
            sidebar.BottomRight = Color.FromArgb(0, 46, 69);
            sidebar.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            sidebar.Controls.Add(panelDashboard);
            sidebar.Controls.Add(panelPasien);
            sidebar.Controls.Add(panelPembayaran);
            sidebar.Controls.Add(panelPemeriksaan);
            sidebar.Controls.Add(panelDokter);
            sidebar.Controls.Add(panelObat);
            sidebar.Dock = DockStyle.Left;
            sidebar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            sidebar.Location = new Point(0, 49);
            sidebar.Name = "sidebar";
            sidebar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            sidebar.PrimerColor = Color.White;
            sidebar.Size = new Size(250, 851);
            sidebar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            sidebar.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            sidebar.TabIndex = 8;
            sidebar.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            sidebar.TopLeft = Color.FromArgb(65, 201, 226);
            sidebar.TopRight = Color.FromArgb(65, 201, 226);
            // 
            // BodyPanel
            // 
            BodyPanel.Dock = DockStyle.Fill;
            BodyPanel.Location = new Point(250, 49);
            BodyPanel.Name = "BodyPanel";
            BodyPanel.Size = new Size(1350, 851);
            BodyPanel.TabIndex = 9;
            // 
            // MainDisplay
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1600, 900);
            Controls.Add(BodyPanel);
            Controls.Add(sidebar);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "MainDisplay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainDisplay";
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hamburgerMenu).EndInit();
            panelDashboard.ResumeLayout(false);
            panelPasien.ResumeLayout(false);
            panelDokter.ResumeLayout(false);
            panelObat.ResumeLayout(false);
            panelPemeriksaan.ResumeLayout(false);
            panelPembayaran.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private PictureBox hamburgerMenu;
        private Panel panelDashboard;
        private Button buttonDashboard;
        private Panel panelPasien;
        private Button buttonPasien;
        private Panel panelDokter;
        private Button buttonDokter;
        private Panel panelObat;
        private Button buttonObat;
        private Panel panelPemeriksaan;
        private Button buttonPemeriksaan;
        private Panel panelPembayaran;
        private Button buttonPembayaran;
        private ReaLTaiizor.Controls.ParrotGradientPanel sidebar;
        private Panel BodyPanel;
    }
}