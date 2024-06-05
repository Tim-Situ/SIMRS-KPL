namespace SIMRS_GUI
{
    partial class LoginUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUser));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            TextBoxPassword = new TextBox();
            TextBoxUsername = new TextBox();
            LabelUsername = new Label();
            LabelPassword = new Label();
            TombolLogin = new Button();
            Logo = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nightControlBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 48);
            panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(224, 224, 224);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(224, 224, 224);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = false;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(611, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = SystemColors.Highlight;
            nightControlBox1.MinimizeHoverForeColor = SystemColors.Control;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Location = new Point(272, 290);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(241, 27);
            TextBoxPassword.TabIndex = 2;
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.Location = new Point(272, 239);
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.Size = new Size(241, 27);
            TextBoxUsername.TabIndex = 2;
            // 
            // LabelUsername
            // 
            LabelUsername.AutoSize = true;
            LabelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelUsername.Location = new Point(156, 237);
            LabelUsername.Name = "LabelUsername";
            LabelUsername.Size = new Size(113, 28);
            LabelUsername.TabIndex = 1;
            LabelUsername.Text = "Username : ";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPassword.Location = new Point(162, 287);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(107, 28);
            LabelPassword.TabIndex = 1;
            LabelPassword.Text = "Password : ";
            // 
            // TombolLogin
            // 
            TombolLogin.BackColor = SystemColors.Highlight;
            TombolLogin.FlatAppearance.BorderColor = SystemColors.Highlight;
            TombolLogin.FlatStyle = FlatStyle.Flat;
            TombolLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TombolLogin.ForeColor = SystemColors.ButtonHighlight;
            TombolLogin.Location = new Point(272, 357);
            TombolLogin.Name = "TombolLogin";
            TombolLogin.Size = new Size(241, 44);
            TombolLogin.TabIndex = 3;
            TombolLogin.Text = "Login";
            TombolLogin.UseVisualStyleBackColor = false;
            TombolLogin.Click += TombolLogin_Click;
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(244, 68);
            Logo.Name = "Logo";
            Logo.Size = new Size(287, 130);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 4;
            Logo.TabStop = false;
            // 
            // LoginUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 500);
            Controls.Add(Logo);
            Controls.Add(TombolLogin);
            Controls.Add(TextBoxUsername);
            Controls.Add(TextBoxPassword);
            Controls.Add(LabelPassword);
            Controls.Add(LabelUsername);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginUser";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private TextBox TextBoxPassword;
        private TextBox TextBoxUsername;
        private Label LabelUsername;
        private Label LabelPassword;
        private Button TombolLogin;
        private PictureBox Logo;
    }
}