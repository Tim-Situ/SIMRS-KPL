namespace SIMRS_GUI.Views.PembayaranView
{
    partial class PembayaranTambahDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PembayaranTambahDisplay));
            LabelHeaderPasien = new Label();
            SearchKodePembayaran = new Button();
            InputKodePemeriksaan = new TextBox();
            InputUangPembayaran = new TextBox();
            ButtonSubmit = new Button();
            LabelUangKembalian = new Label();
            LabelUangPembayaran = new Label();
            LabelTotalTagihan = new Label();
            LabelNamaDokter = new Label();
            label2 = new Label();
            LabelNamaPasien = new Label();
            LabelKodePemeriksaan = new Label();
            SuspendLayout();
            // 
            // LabelHeaderPasien
            // 
            LabelHeaderPasien.AutoSize = true;
            LabelHeaderPasien.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHeaderPasien.Location = new Point(513, 55);
            LabelHeaderPasien.Name = "LabelHeaderPasien";
            LabelHeaderPasien.Size = new Size(521, 54);
            LabelHeaderPasien.TabIndex = 6;
            LabelHeaderPasien.Text = "Tambah Data Pembayaran";
            // 
            // SearchKodePembayaran
            // 
            SearchKodePembayaran.BackColor = SystemColors.Highlight;
            SearchKodePembayaran.FlatStyle = FlatStyle.Flat;
            SearchKodePembayaran.ForeColor = Color.White;
            SearchKodePembayaran.Image = (Image)resources.GetObject("SearchKodePembayaran.Image");
            SearchKodePembayaran.ImageAlign = ContentAlignment.MiddleLeft;
            SearchKodePembayaran.Location = new Point(780, 200);
            SearchKodePembayaran.Name = "SearchKodePembayaran";
            SearchKodePembayaran.Padding = new Padding(5, 0, 0, 0);
            SearchKodePembayaran.Size = new Size(121, 29);
            SearchKodePembayaran.TabIndex = 22;
            SearchKodePembayaran.Text = "Cari";
            SearchKodePembayaran.UseVisualStyleBackColor = false;
            SearchKodePembayaran.Click += SearchKodePembayaran_Click;
            // 
            // InputKodePemeriksaan
            // 
            InputKodePemeriksaan.Location = new Point(530, 201);
            InputKodePemeriksaan.Name = "InputKodePemeriksaan";
            InputKodePemeriksaan.Size = new Size(236, 27);
            InputKodePemeriksaan.TabIndex = 10;
            // 
            // InputUangPembayaran
            // 
            InputUangPembayaran.Location = new Point(530, 456);
            InputUangPembayaran.Name = "InputUangPembayaran";
            InputUangPembayaran.Size = new Size(371, 27);
            InputUangPembayaran.TabIndex = 11;
            InputUangPembayaran.KeyUp += InputUangPembayaran_KeyUp;
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.BackColor = Color.Transparent;
            ButtonSubmit.FlatAppearance.BorderColor = SystemColors.Highlight;
            ButtonSubmit.FlatStyle = FlatStyle.Flat;
            ButtonSubmit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSubmit.ForeColor = SystemColors.Highlight;
            ButtonSubmit.Location = new Point(619, 642);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(184, 45);
            ButtonSubmit.TabIndex = 21;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = false;
            ButtonSubmit.Click += ButtonSubmit_Click;
            // 
            // LabelUangKembalian
            // 
            LabelUangKembalian.AutoSize = true;
            LabelUangKembalian.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelUangKembalian.Location = new Point(314, 515);
            LabelUangKembalian.Name = "LabelUangKembalian";
            LabelUangKembalian.Size = new Size(194, 31);
            LabelUangKembalian.TabIndex = 13;
            LabelUangKembalian.Text = "Uang Kembalian :";
            // 
            // LabelUangPembayaran
            // 
            LabelUangPembayaran.AutoSize = true;
            LabelUangPembayaran.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelUangPembayaran.Location = new Point(296, 450);
            LabelUangPembayaran.Name = "LabelUangPembayaran";
            LabelUangPembayaran.Size = new Size(212, 31);
            LabelUangPembayaran.TabIndex = 14;
            LabelUangPembayaran.Text = "Uang Pembayaran :";
            // 
            // LabelTotalTagihan
            // 
            LabelTotalTagihan.AutoSize = true;
            LabelTotalTagihan.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTotalTagihan.Location = new Point(349, 388);
            LabelTotalTagihan.Name = "LabelTotalTagihan";
            LabelTotalTagihan.Size = new Size(159, 31);
            LabelTotalTagihan.TabIndex = 15;
            LabelTotalTagihan.Text = "Total Tagihan :";
            // 
            // LabelNamaDokter
            // 
            LabelNamaDokter.AutoSize = true;
            LabelNamaDokter.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNamaDokter.Location = new Point(348, 323);
            LabelNamaDokter.Name = "LabelNamaDokter";
            LabelNamaDokter.Size = new Size(160, 31);
            LabelNamaDokter.TabIndex = 16;
            LabelNamaDokter.Text = "Nama Dokter :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(351, 322);
            label2.Name = "label2";
            label2.Size = new Size(160, 31);
            label2.TabIndex = 17;
            label2.Text = "Nama Dokter :";
            // 
            // LabelNamaPasien
            // 
            LabelNamaPasien.AutoSize = true;
            LabelNamaPasien.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNamaPasien.Location = new Point(351, 258);
            LabelNamaPasien.Name = "LabelNamaPasien";
            LabelNamaPasien.Size = new Size(157, 31);
            LabelNamaPasien.TabIndex = 18;
            LabelNamaPasien.Text = "Nama Pasien :";
            // 
            // LabelKodePemeriksaan
            // 
            LabelKodePemeriksaan.AutoSize = true;
            LabelKodePemeriksaan.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelKodePemeriksaan.Location = new Point(298, 195);
            LabelKodePemeriksaan.Name = "LabelKodePemeriksaan";
            LabelKodePemeriksaan.Size = new Size(210, 31);
            LabelKodePemeriksaan.TabIndex = 19;
            LabelKodePemeriksaan.Text = "Kode Pemeriksaan :";
            // 
            // PembayaranTambahDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(SearchKodePembayaran);
            Controls.Add(InputKodePemeriksaan);
            Controls.Add(InputUangPembayaran);
            Controls.Add(ButtonSubmit);
            Controls.Add(LabelUangKembalian);
            Controls.Add(LabelUangPembayaran);
            Controls.Add(LabelTotalTagihan);
            Controls.Add(LabelNamaDokter);
            Controls.Add(label2);
            Controls.Add(LabelNamaPasien);
            Controls.Add(LabelKodePemeriksaan);
            Controls.Add(LabelHeaderPasien);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PembayaranTambahDisplay";
            Text = "PasienTambahDisplay";
            Load += PembayaranTambahDisplay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LabelHeaderPasien;
        private Button SearchKodePembayaran;
        private TextBox InputKodePemeriksaan;
        private TextBox InputUangPembayaran;
        private Button ButtonSubmit;
        private Label LabelUangKembalian;
        private Label LabelUangPembayaran;
        private Label LabelTotalTagihan;
        private Label LabelNamaDokter;
        private Label label2;
        private Label LabelNamaPasien;
        private Label LabelKodePemeriksaan;
    }
}