namespace SIMRS_GUI
{
    partial class DashboardDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardDisplay));
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            LabelJumlahDokter = new Label();
            label1 = new Label();
            LabelJumlahPoli = new Label();
            LabelJumlahPasien = new Label();
            label3 = new Label();
            panel3 = new Panel();
            LabelJumlahPembayaran = new Label();
            label14 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(391, 282);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(LabelJumlahDokter);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LabelJumlahPoli);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(43, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 282);
            panel1.TabIndex = 5;
            // 
            // LabelJumlahDokter
            // 
            LabelJumlahDokter.AutoSize = true;
            LabelJumlahDokter.BackColor = Color.FromArgb(140, 133, 245);
            LabelJumlahDokter.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            LabelJumlahDokter.ForeColor = Color.White;
            LabelJumlahDokter.Location = new Point(17, 51);
            LabelJumlahDokter.Name = "LabelJumlahDokter";
            LabelJumlahDokter.Size = new Size(155, 46);
            LabelJumlahDokter.TabIndex = 1;
            LabelJumlahDokter.Text = "X Dokter";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(140, 133, 245);
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 20);
            label1.Name = "label1";
            label1.Size = new Size(136, 31);
            label1.TabIndex = 1;
            label1.Text = "Data Dokter";
            // 
            // LabelJumlahPoli
            // 
            LabelJumlahPoli.AutoSize = true;
            LabelJumlahPoli.BackColor = Color.FromArgb(140, 133, 245);
            LabelJumlahPoli.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelJumlahPoli.ForeColor = Color.White;
            LabelJumlahPoli.Location = new Point(17, 97);
            LabelJumlahPoli.Name = "LabelJumlahPoli";
            LabelJumlahPoli.Size = new Size(120, 31);
            LabelJumlahPoli.TabIndex = 1;
            LabelJumlahPoli.Text = "5 Spesialis";
            // 
            // LabelJumlahPasien
            // 
            LabelJumlahPasien.AutoSize = true;
            LabelJumlahPasien.BackColor = Color.FromArgb(180, 106, 240);
            LabelJumlahPasien.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            LabelJumlahPasien.ForeColor = Color.White;
            LabelJumlahPasien.Location = new Point(17, 51);
            LabelJumlahPasien.Name = "LabelJumlahPasien";
            LabelJumlahPasien.Size = new Size(149, 46);
            LabelJumlahPasien.TabIndex = 1;
            LabelJumlahPasien.Text = "X Pasien";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(180, 106, 240);
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 20);
            label3.Name = "label3";
            label3.Size = new Size(133, 31);
            label3.TabIndex = 1;
            label3.Text = "Data Pasien";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.Controls.Add(LabelJumlahPembayaran);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(931, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(391, 282);
            panel3.TabIndex = 5;
            // 
            // LabelJumlahPembayaran
            // 
            LabelJumlahPembayaran.AutoSize = true;
            LabelJumlahPembayaran.BackColor = Color.FromArgb(234, 213, 67);
            LabelJumlahPembayaran.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            LabelJumlahPembayaran.ForeColor = Color.White;
            LabelJumlahPembayaran.Location = new Point(17, 51);
            LabelJumlahPembayaran.Name = "LabelJumlahPembayaran";
            LabelJumlahPembayaran.Size = new Size(192, 46);
            LabelJumlahPembayaran.TabIndex = 1;
            LabelJumlahPembayaran.Text = "X Transaksi";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(234, 213, 67);
            label14.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(17, 20);
            label14.Name = "label14";
            label14.Size = new Size(160, 31);
            label14.TabIndex = 1;
            label14.Text = "Data Transaksi";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(391, 282);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(43, 370);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1279, 422);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.Controls.Add(LabelJumlahPasien);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(pictureBox5);
            panel4.Location = new Point(494, 42);
            panel4.Name = "panel4";
            panel4.Size = new Size(391, 282);
            panel4.TabIndex = 5;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(391, 282);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // DashboardDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(pictureBox3);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardDisplay";
            Text = "DashboardDisplay";
            Load += DashboardDisplay_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label LabelJumlahDokter;
        private Label label1;
        private Label LabelJumlahPoli;
        private Label LabelJumlahPasien;
        private Label label3;
        private Label label10;
        private Panel panel3;
        private Label LabelJumlahPembayaran;
        private Label label14;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private Panel panel4;
    }
}