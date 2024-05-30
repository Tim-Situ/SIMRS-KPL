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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDisplay));
            panelTop = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            hamburgerMenu = new PictureBox();
            panelDashboard = new Panel();
            buttonDashboard = new Button();
            sidebar = new FlowLayoutPanel();
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
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hamburgerMenu).BeginInit();
            panelDashboard.SuspendLayout();
            sidebar.SuspendLayout();
            panelPasien.SuspendLayout();
            panelDokter.SuspendLayout();
            panelObat.SuspendLayout();
            panelPemeriksaan.SuspendLayout();
            panelPembayaran.SuspendLayout();
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
            panelTop.Size = new Size(1161, 49);
            panelTop.TabIndex = 0;
            panelTop.Paint += PanelTop_Paint;
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
            nightControlBox1.Location = new Point(1022, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            nightControlBox1.Click += nightControlBox1_Click;
            // 
            // hamburgerMenu
            // 
            hamburgerMenu.Image = (Image)resources.GetObject("hamburgerMenu.Image");
            hamburgerMenu.Location = new Point(18, 6);
            hamburgerMenu.Name = "hamburgerMenu";
            hamburgerMenu.Size = new Size(37, 37);
            hamburgerMenu.SizeMode = PictureBoxSizeMode.CenterImage;
            hamburgerMenu.TabIndex = 1;
            hamburgerMenu.TabStop = false;
            hamburgerMenu.Click += hamburgerMenu_Click;
            // 
            // panelDashboard
            // 
            panelDashboard.Controls.Add(buttonDashboard);
            panelDashboard.ImeMode = ImeMode.NoControl;
            panelDashboard.Location = new Point(8, 28);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(197, 50);
            panelDashboard.TabIndex = 2;
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = Color.FromArgb(0, 141, 218);
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.Image = (Image)resources.GetObject("buttonDashboard.Image");
            buttonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.Location = new Point(0, 0);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Padding = new Padding(25, 0, 0, 0);
            buttonDashboard.Size = new Size(197, 50);
            buttonDashboard.TabIndex = 3;
            buttonDashboard.Text = "       Dashboard";
            buttonDashboard.TextAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.UseVisualStyleBackColor = false;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(0, 141, 218);
            sidebar.Controls.Add(panelDashboard);
            sidebar.Controls.Add(panelPasien);
            sidebar.Controls.Add(panelDokter);
            sidebar.Controls.Add(panelObat);
            sidebar.Controls.Add(panelPemeriksaan);
            sidebar.Controls.Add(panelPembayaran);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 49);
            sidebar.Name = "sidebar";
            sidebar.Padding = new Padding(5, 25, 0, 0);
            sidebar.Size = new Size(222, 513);
            sidebar.TabIndex = 4;
            sidebar.Paint += sidebar_Paint;
            // 
            // panelPasien
            // 
            panelPasien.Controls.Add(buttonPasien);
            panelPasien.ImeMode = ImeMode.NoControl;
            panelPasien.Location = new Point(8, 84);
            panelPasien.Name = "panelPasien";
            panelPasien.Size = new Size(197, 50);
            panelPasien.TabIndex = 2;
            // 
            // buttonPasien
            // 
            buttonPasien.BackColor = Color.FromArgb(0, 141, 218);
            buttonPasien.FlatAppearance.BorderSize = 0;
            buttonPasien.FlatStyle = FlatStyle.Flat;
            buttonPasien.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPasien.ForeColor = Color.White;
            buttonPasien.Image = (Image)resources.GetObject("buttonPasien.Image");
            buttonPasien.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPasien.Location = new Point(0, 0);
            buttonPasien.Name = "buttonPasien";
            buttonPasien.Padding = new Padding(25, 0, 0, 0);
            buttonPasien.Size = new Size(197, 50);
            buttonPasien.TabIndex = 3;
            buttonPasien.Text = "       Pasien";
            buttonPasien.TextAlign = ContentAlignment.MiddleLeft;
            buttonPasien.UseVisualStyleBackColor = false;
            // 
            // panelDokter
            // 
            panelDokter.Controls.Add(buttonDokter);
            panelDokter.ImeMode = ImeMode.NoControl;
            panelDokter.Location = new Point(8, 140);
            panelDokter.Name = "panelDokter";
            panelDokter.Size = new Size(197, 50);
            panelDokter.TabIndex = 2;
            // 
            // buttonDokter
            // 
            buttonDokter.BackColor = Color.FromArgb(0, 141, 218);
            buttonDokter.FlatAppearance.BorderSize = 0;
            buttonDokter.FlatStyle = FlatStyle.Flat;
            buttonDokter.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDokter.ForeColor = Color.White;
            buttonDokter.Image = (Image)resources.GetObject("buttonDokter.Image");
            buttonDokter.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDokter.Location = new Point(0, 0);
            buttonDokter.Name = "buttonDokter";
            buttonDokter.Padding = new Padding(25, 0, 0, 0);
            buttonDokter.Size = new Size(197, 50);
            buttonDokter.TabIndex = 3;
            buttonDokter.Text = "       Dokter";
            buttonDokter.TextAlign = ContentAlignment.MiddleLeft;
            buttonDokter.UseVisualStyleBackColor = false;
            // 
            // panelObat
            // 
            panelObat.Controls.Add(buttonObat);
            panelObat.ImeMode = ImeMode.NoControl;
            panelObat.Location = new Point(8, 196);
            panelObat.Name = "panelObat";
            panelObat.Size = new Size(197, 50);
            panelObat.TabIndex = 2;
            // 
            // buttonObat
            // 
            buttonObat.BackColor = Color.FromArgb(0, 141, 218);
            buttonObat.FlatAppearance.BorderSize = 0;
            buttonObat.FlatStyle = FlatStyle.Flat;
            buttonObat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonObat.ForeColor = Color.White;
            buttonObat.Image = (Image)resources.GetObject("buttonObat.Image");
            buttonObat.ImageAlign = ContentAlignment.MiddleLeft;
            buttonObat.Location = new Point(0, 0);
            buttonObat.Name = "buttonObat";
            buttonObat.Padding = new Padding(25, 0, 0, 0);
            buttonObat.Size = new Size(197, 50);
            buttonObat.TabIndex = 3;
            buttonObat.Text = "       Obat";
            buttonObat.TextAlign = ContentAlignment.MiddleLeft;
            buttonObat.UseVisualStyleBackColor = false;
            // 
            // panelPemeriksaan
            // 
            panelPemeriksaan.Controls.Add(buttonPemeriksaan);
            panelPemeriksaan.ImeMode = ImeMode.NoControl;
            panelPemeriksaan.Location = new Point(8, 252);
            panelPemeriksaan.Name = "panelPemeriksaan";
            panelPemeriksaan.Size = new Size(197, 50);
            panelPemeriksaan.TabIndex = 2;
            // 
            // buttonPemeriksaan
            // 
            buttonPemeriksaan.BackColor = Color.FromArgb(0, 141, 218);
            buttonPemeriksaan.FlatAppearance.BorderSize = 0;
            buttonPemeriksaan.FlatStyle = FlatStyle.Flat;
            buttonPemeriksaan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPemeriksaan.ForeColor = Color.White;
            buttonPemeriksaan.Image = (Image)resources.GetObject("buttonPemeriksaan.Image");
            buttonPemeriksaan.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPemeriksaan.Location = new Point(0, 0);
            buttonPemeriksaan.Name = "buttonPemeriksaan";
            buttonPemeriksaan.Padding = new Padding(25, 0, 0, 0);
            buttonPemeriksaan.Size = new Size(197, 50);
            buttonPemeriksaan.TabIndex = 3;
            buttonPemeriksaan.Text = "       Pemeriksaan";
            buttonPemeriksaan.TextAlign = ContentAlignment.MiddleLeft;
            buttonPemeriksaan.UseVisualStyleBackColor = false;
            // 
            // panelPembayaran
            // 
            panelPembayaran.Controls.Add(buttonPembayaran);
            panelPembayaran.ImeMode = ImeMode.NoControl;
            panelPembayaran.Location = new Point(8, 308);
            panelPembayaran.Name = "panelPembayaran";
            panelPembayaran.Size = new Size(197, 50);
            panelPembayaran.TabIndex = 2;
            // 
            // buttonPembayaran
            // 
            buttonPembayaran.BackColor = Color.FromArgb(0, 141, 218);
            buttonPembayaran.FlatAppearance.BorderSize = 0;
            buttonPembayaran.FlatStyle = FlatStyle.Flat;
            buttonPembayaran.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPembayaran.ForeColor = Color.White;
            buttonPembayaran.Image = (Image)resources.GetObject("buttonPembayaran.Image");
            buttonPembayaran.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPembayaran.Location = new Point(0, 0);
            buttonPembayaran.Name = "buttonPembayaran";
            buttonPembayaran.Padding = new Padding(25, 0, 0, 0);
            buttonPembayaran.Size = new Size(197, 50);
            buttonPembayaran.TabIndex = 3;
            buttonPembayaran.Text = "       Pembayaran";
            buttonPembayaran.TextAlign = ContentAlignment.MiddleLeft;
            buttonPembayaran.UseVisualStyleBackColor = false;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // MainDisplay
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1161, 562);
            Controls.Add(sidebar);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "MainDisplay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainDisplay";
            Load += MainDisplayDraft_Load;
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hamburgerMenu).EndInit();
            panelDashboard.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            panelPasien.ResumeLayout(false);
            panelDokter.ResumeLayout(false);
            panelObat.ResumeLayout(false);
            panelPemeriksaan.ResumeLayout(false);
            panelPembayaran.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private PictureBox hamburgerMenu;
        private Panel panelDashboard;
        private Button buttonDashboard;
        private FlowLayoutPanel sidebar;
        private Panel panelPasien;
        private Button buttonPasien;
        private Panel panelDokter;
        private Button buttonDokter;
        private Panel panelObat;
        private Button buttonObat;
        private Panel panelPemeriksaan;
        private Button buttonPemeriksaan;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel panelPembayaran;
        private Button buttonPembayaran;
    }
}