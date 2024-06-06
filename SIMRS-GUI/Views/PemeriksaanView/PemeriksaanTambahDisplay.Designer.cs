namespace SIMRS_GUI.Views.PemeriksaanView
{
    partial class PemeriksaanTambahDisplay  
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PemeriksaanTambahDisplay));
            LabelHeaderPasien = new Label();
            OutputNamaPasien = new Label();
            OutputNamaDokter = new Label();
            SearchNIP = new Button();
            SearchNIK = new Button();
            InputNamaObat = new TextBox();
            InputTekananDarah = new TextBox();
            InputBeratBadan = new TextBox();
            InputTinggiBadan = new TextBox();
            InputNIP = new TextBox();
            InputTanggal = new DateTimePicker();
            InputNIK = new TextBox();
            InputKeluhan = new TextBox();
            InputDiagnosa = new TextBox();
            ButtonSubmit = new Button();
            LabelNamaObat = new Label();
            LabelKeluhan = new Label();
            LabelTekananDarah = new Label();
            LabelDiagnosa = new Label();
            LabelBeratBadan = new Label();
            LabelTinggiBadan = new Label();
            LabelPasien = new Label();
            LabelTanggalPemeriksaan = new Label();
            LabelNama = new Label();
            SuspendLayout();
            // 
            // LabelHeaderPasien
            // 
            LabelHeaderPasien.AutoSize = true;
            LabelHeaderPasien.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHeaderPasien.Location = new Point(452, 47);
            LabelHeaderPasien.Name = "LabelHeaderPasien";
            LabelHeaderPasien.Size = new Size(525, 54);
            LabelHeaderPasien.TabIndex = 6;
            LabelHeaderPasien.Text = "Tambah Data Pemeriksaan";
            // 
            // OutputNamaPasien
            // 
            OutputNamaPasien.AutoSize = true;
            OutputNamaPasien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OutputNamaPasien.Location = new Point(120, 184);
            OutputNamaPasien.Name = "OutputNamaPasien";
            OutputNamaPasien.Size = new Size(78, 28);
            OutputNamaPasien.TabIndex = 32;
            OutputNamaPasien.Text = "Nama : ";
            // 
            // OutputNamaDokter
            // 
            OutputNamaDokter.AutoSize = true;
            OutputNamaDokter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OutputNamaDokter.Location = new Point(120, 284);
            OutputNamaDokter.Name = "OutputNamaDokter";
            OutputNamaDokter.Size = new Size(78, 28);
            OutputNamaDokter.TabIndex = 31;
            OutputNamaDokter.Text = "Nama : ";
            // 
            // SearchNIP
            // 
            SearchNIP.BackColor = SystemColors.Highlight;
            SearchNIP.FlatStyle = FlatStyle.Flat;
            SearchNIP.ForeColor = Color.White;
            SearchNIP.Image = (Image)resources.GetObject("SearchNIP.Image");
            SearchNIP.ImageAlign = ContentAlignment.MiddleLeft;
            SearchNIP.Location = new Point(503, 249);
            SearchNIP.Name = "SearchNIP";
            SearchNIP.Padding = new Padding(5, 0, 0, 0);
            SearchNIP.Size = new Size(121, 29);
            SearchNIP.TabIndex = 30;
            SearchNIP.Text = "Cari";
            SearchNIP.UseVisualStyleBackColor = false;
            // 
            // SearchNIK
            // 
            SearchNIK.BackColor = SystemColors.Highlight;
            SearchNIK.FlatStyle = FlatStyle.Flat;
            SearchNIK.ForeColor = Color.White;
            SearchNIK.Image = (Image)resources.GetObject("SearchNIK.Image");
            SearchNIK.ImageAlign = ContentAlignment.MiddleLeft;
            SearchNIK.Location = new Point(503, 150);
            SearchNIK.Name = "SearchNIK";
            SearchNIK.Padding = new Padding(5, 0, 0, 0);
            SearchNIK.Size = new Size(121, 29);
            SearchNIK.TabIndex = 29;
            SearchNIK.Text = "Cari";
            SearchNIK.UseVisualStyleBackColor = false;
            // 
            // InputNamaObat
            // 
            InputNamaObat.Location = new Point(844, 580);
            InputNamaObat.Name = "InputNamaObat";
            InputNamaObat.Size = new Size(371, 27);
            InputNamaObat.TabIndex = 14;
            // 
            // InputTekananDarah
            // 
            InputTekananDarah.Location = new Point(257, 580);
            InputTekananDarah.Name = "InputTekananDarah";
            InputTekananDarah.Size = new Size(377, 27);
            InputTekananDarah.TabIndex = 15;
            // 
            // InputBeratBadan
            // 
            InputBeratBadan.Location = new Point(242, 506);
            InputBeratBadan.Name = "InputBeratBadan";
            InputBeratBadan.Size = new Size(392, 27);
            InputBeratBadan.TabIndex = 16;
            // 
            // InputTinggiBadan
            // 
            InputTinggiBadan.Location = new Point(242, 434);
            InputTinggiBadan.Name = "InputTinggiBadan";
            InputTinggiBadan.Size = new Size(392, 27);
            InputTinggiBadan.TabIndex = 17;
            // 
            // InputNIP
            // 
            InputNIP.Location = new Point(213, 250);
            InputNIP.Name = "InputNIP";
            InputNIP.Size = new Size(284, 27);
            InputNIP.TabIndex = 18;
            // 
            // InputTanggal
            // 
            InputTanggal.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            InputTanggal.Location = new Point(321, 361);
            InputTanggal.Name = "InputTanggal";
            InputTanggal.Size = new Size(313, 27);
            InputTanggal.TabIndex = 25;
            // 
            // InputNIK
            // 
            InputNIK.Location = new Point(213, 151);
            InputNIK.Name = "InputNIK";
            InputNIK.Size = new Size(284, 27);
            InputNIK.TabIndex = 19;
            // 
            // InputKeluhan
            // 
            InputKeluhan.Location = new Point(844, 368);
            InputKeluhan.Multiline = true;
            InputKeluhan.Name = "InputKeluhan";
            InputKeluhan.Size = new Size(434, 165);
            InputKeluhan.TabIndex = 26;
            // 
            // InputDiagnosa
            // 
            InputDiagnosa.Location = new Point(844, 145);
            InputDiagnosa.Multiline = true;
            InputDiagnosa.Name = "InputDiagnosa";
            InputDiagnosa.Size = new Size(434, 165);
            InputDiagnosa.TabIndex = 27;
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.BackColor = Color.Transparent;
            ButtonSubmit.FlatAppearance.BorderColor = SystemColors.Highlight;
            ButtonSubmit.FlatStyle = FlatStyle.Flat;
            ButtonSubmit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSubmit.ForeColor = SystemColors.Highlight;
            ButtonSubmit.Location = new Point(596, 660);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(184, 45);
            ButtonSubmit.TabIndex = 28;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = false;
            // 
            // LabelNamaObat
            // 
            LabelNamaObat.AutoSize = true;
            LabelNamaObat.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNamaObat.Location = new Point(695, 574);
            LabelNamaObat.Name = "LabelNamaObat";
            LabelNamaObat.Size = new Size(143, 31);
            LabelNamaObat.TabIndex = 23;
            LabelNamaObat.Text = "Nama Obat :";
            // 
            // LabelKeluhan
            // 
            LabelKeluhan.AutoSize = true;
            LabelKeluhan.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelKeluhan.Location = new Point(695, 368);
            LabelKeluhan.Name = "LabelKeluhan";
            LabelKeluhan.Size = new Size(107, 31);
            LabelKeluhan.TabIndex = 24;
            LabelKeluhan.Text = "Keluhan :";
            // 
            // LabelTekananDarah
            // 
            LabelTekananDarah.AutoSize = true;
            LabelTekananDarah.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTekananDarah.Location = new Point(76, 574);
            LabelTekananDarah.Name = "LabelTekananDarah";
            LabelTekananDarah.Size = new Size(175, 31);
            LabelTekananDarah.TabIndex = 22;
            LabelTekananDarah.Text = "Tekanan Darah :";
            // 
            // LabelDiagnosa
            // 
            LabelDiagnosa.AutoSize = true;
            LabelDiagnosa.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelDiagnosa.Location = new Point(695, 145);
            LabelDiagnosa.Name = "LabelDiagnosa";
            LabelDiagnosa.Size = new Size(121, 31);
            LabelDiagnosa.TabIndex = 21;
            LabelDiagnosa.Text = "Diagnosa :";
            // 
            // LabelBeratBadan
            // 
            LabelBeratBadan.AutoSize = true;
            LabelBeratBadan.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelBeratBadan.Location = new Point(76, 500);
            LabelBeratBadan.Name = "LabelBeratBadan";
            LabelBeratBadan.Size = new Size(148, 31);
            LabelBeratBadan.TabIndex = 13;
            LabelBeratBadan.Text = "Berat Badan :";
            // 
            // LabelTinggiBadan
            // 
            LabelTinggiBadan.AutoSize = true;
            LabelTinggiBadan.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTinggiBadan.Location = new Point(76, 428);
            LabelTinggiBadan.Name = "LabelTinggiBadan";
            LabelTinggiBadan.Size = new Size(160, 31);
            LabelTinggiBadan.TabIndex = 12;
            LabelTinggiBadan.Text = "Tinggi Badan :";
            // 
            // LabelPasien
            // 
            LabelPasien.AutoSize = true;
            LabelPasien.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPasien.Location = new Point(66, 244);
            LabelPasien.Name = "LabelPasien";
            LabelPasien.Size = new Size(139, 31);
            LabelPasien.TabIndex = 11;
            LabelPasien.Text = "NIP Pasien :";
            // 
            // LabelTanggalPemeriksaan
            // 
            LabelTanggalPemeriksaan.AutoSize = true;
            LabelTanggalPemeriksaan.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTanggalPemeriksaan.Location = new Point(76, 357);
            LabelTanggalPemeriksaan.Name = "LabelTanggalPemeriksaan";
            LabelTanggalPemeriksaan.Size = new Size(239, 31);
            LabelTanggalPemeriksaan.TabIndex = 20;
            LabelTanggalPemeriksaan.Text = "Tanggal Pemeriksaan :";
            // 
            // LabelNama
            // 
            LabelNama.AutoSize = true;
            LabelNama.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LabelNama.Location = new Point(66, 145);
            LabelNama.Name = "LabelNama";
            LabelNama.Size = new Size(140, 31);
            LabelNama.TabIndex = 10;
            LabelNama.Text = "NIK Pasien :";
            // 
            // PemeriksaanTambahDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(OutputNamaPasien);
            Controls.Add(OutputNamaDokter);
            Controls.Add(SearchNIP);
            Controls.Add(SearchNIK);
            Controls.Add(InputNamaObat);
            Controls.Add(InputTekananDarah);
            Controls.Add(InputBeratBadan);
            Controls.Add(InputTinggiBadan);
            Controls.Add(InputNIP);
            Controls.Add(InputTanggal);
            Controls.Add(InputNIK);
            Controls.Add(InputKeluhan);
            Controls.Add(InputDiagnosa);
            Controls.Add(ButtonSubmit);
            Controls.Add(LabelNamaObat);
            Controls.Add(LabelKeluhan);
            Controls.Add(LabelTekananDarah);
            Controls.Add(LabelDiagnosa);
            Controls.Add(LabelBeratBadan);
            Controls.Add(LabelTinggiBadan);
            Controls.Add(LabelPasien);
            Controls.Add(LabelTanggalPemeriksaan);
            Controls.Add(LabelNama);
            Controls.Add(LabelHeaderPasien);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PemeriksaanTambahDisplay";
            Text = "PasienTambahDisplay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LabelHeaderPasien;
        private Label OutputNamaPasien;
        private Label OutputNamaDokter;
        private Button SearchNIP;
        private Button SearchNIK;
        private TextBox InputNamaObat;
        private TextBox InputTekananDarah;
        private TextBox InputBeratBadan;
        private TextBox InputTinggiBadan;
        private TextBox InputNIP;
        private DateTimePicker InputTanggal;
        private TextBox InputNIK;
        private TextBox InputKeluhan;
        private TextBox InputDiagnosa;
        private Button ButtonSubmit;
        private Label LabelNamaObat;
        private Label LabelKeluhan;
        private Label LabelTekananDarah;
        private Label LabelDiagnosa;
        private Label LabelBeratBadan;
        private Label LabelTinggiBadan;
        private Label LabelPasien;
        private Label LabelTanggalPemeriksaan;
        private Label LabelNama;
    }
}