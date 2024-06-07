namespace SIMRS_GUI.Views.PemeriksaanView
{
    partial class PemeriksaanEditDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PemeriksaanEditDisplay));
            LabelHeaderEditPemeriksaan = new Label();
            LabelNama = new Label();
            LabelTanggalPemeriksaan = new Label();
            LabelDiagnosa = new Label();
            ButtonSubmit = new Button();
            InputNIK = new TextBox();
            InputTanggal = new DateTimePicker();
            InputDiagnosa = new TextBox();
            SearchNIK = new Button();
            LabelPasien = new Label();
            InputNIP = new TextBox();
            SearchNIP = new Button();
            LabelTinggiBadan = new Label();
            InputTinggiBadan = new TextBox();
            LabelBeratBadan = new Label();
            InputBeratBadan = new TextBox();
            LabelTekananDarah = new Label();
            InputTekananDarah = new TextBox();
            LabelKeluhan = new Label();
            LabelNamaObat = new Label();
            InputKodeObat = new TextBox();
            InputKeluhan = new TextBox();
            OutputNamaDokter = new Label();
            OutputNamaPasien = new Label();
            OutputNamaObat = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // LabelHeaderEditPemeriksaan
            // 
            LabelHeaderEditPemeriksaan.AutoSize = true;
            LabelHeaderEditPemeriksaan.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHeaderEditPemeriksaan.Location = new Point(494, 35);
            LabelHeaderEditPemeriksaan.Name = "LabelHeaderEditPemeriksaan";
            LabelHeaderEditPemeriksaan.Size = new Size(448, 54);
            LabelHeaderEditPemeriksaan.TabIndex = 0;
            LabelHeaderEditPemeriksaan.Text = "Edit Data Pemeriksaan";
            // 
            // LabelNama
            // 
            LabelNama.AutoSize = true;
            LabelNama.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LabelNama.Location = new Point(92, 137);
            LabelNama.Name = "LabelNama";
            LabelNama.Size = new Size(140, 31);
            LabelNama.TabIndex = 1;
            LabelNama.Text = "NIK Pasien :";
            // 
            // LabelTanggalPemeriksaan
            // 
            LabelTanggalPemeriksaan.AutoSize = true;
            LabelTanggalPemeriksaan.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTanggalPemeriksaan.Location = new Point(102, 349);
            LabelTanggalPemeriksaan.Name = "LabelTanggalPemeriksaan";
            LabelTanggalPemeriksaan.Size = new Size(239, 31);
            LabelTanggalPemeriksaan.TabIndex = 1;
            LabelTanggalPemeriksaan.Text = "Tanggal Pemeriksaan :";
            // 
            // LabelDiagnosa
            // 
            LabelDiagnosa.AutoSize = true;
            LabelDiagnosa.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelDiagnosa.Location = new Point(721, 349);
            LabelDiagnosa.Name = "LabelDiagnosa";
            LabelDiagnosa.Size = new Size(121, 31);
            LabelDiagnosa.TabIndex = 1;
            LabelDiagnosa.Text = "Diagnosa :";
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.BackColor = Color.Transparent;
            ButtonSubmit.FlatAppearance.BorderColor = SystemColors.Highlight;
            ButtonSubmit.FlatStyle = FlatStyle.Flat;
            ButtonSubmit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSubmit.ForeColor = SystemColors.Highlight;
            ButtonSubmit.Location = new Point(619, 688);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(184, 45);
            ButtonSubmit.TabIndex = 7;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = false;
            ButtonSubmit.Click += ButtonSubmit_Click;
            // 
            // InputNIK
            // 
            InputNIK.Location = new Point(239, 143);
            InputNIK.Name = "InputNIK";
            InputNIK.Size = new Size(284, 27);
            InputNIK.TabIndex = 1;
            // 
            // InputTanggal
            // 
            InputTanggal.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            InputTanggal.Location = new Point(347, 353);
            InputTanggal.Name = "InputTanggal";
            InputTanggal.Size = new Size(313, 27);
            InputTanggal.TabIndex = 2;
            // 
            // InputDiagnosa
            // 
            InputDiagnosa.Location = new Point(870, 349);
            InputDiagnosa.Multiline = true;
            InputDiagnosa.Name = "InputDiagnosa";
            InputDiagnosa.Size = new Size(434, 165);
            InputDiagnosa.TabIndex = 6;
            // 
            // SearchNIK
            // 
            SearchNIK.BackColor = SystemColors.Highlight;
            SearchNIK.FlatStyle = FlatStyle.Flat;
            SearchNIK.ForeColor = Color.White;
            SearchNIK.Image = (Image)resources.GetObject("SearchNIK.Image");
            SearchNIK.ImageAlign = ContentAlignment.MiddleLeft;
            SearchNIK.Location = new Point(529, 142);
            SearchNIK.Name = "SearchNIK";
            SearchNIK.Padding = new Padding(5, 0, 0, 0);
            SearchNIK.Size = new Size(121, 29);
            SearchNIK.TabIndex = 8;
            SearchNIK.Text = "Cari";
            SearchNIK.UseVisualStyleBackColor = false;
            SearchNIK.Click += SearchNIK_Click;
            // 
            // LabelPasien
            // 
            LabelPasien.AutoSize = true;
            LabelPasien.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPasien.Location = new Point(92, 236);
            LabelPasien.Name = "LabelPasien";
            LabelPasien.Size = new Size(139, 31);
            LabelPasien.TabIndex = 1;
            LabelPasien.Text = "NIP Pasien :";
            // 
            // InputNIP
            // 
            InputNIP.Location = new Point(239, 242);
            InputNIP.Name = "InputNIP";
            InputNIP.Size = new Size(284, 27);
            InputNIP.TabIndex = 1;
            // 
            // SearchNIP
            // 
            SearchNIP.BackColor = SystemColors.Highlight;
            SearchNIP.FlatStyle = FlatStyle.Flat;
            SearchNIP.ForeColor = Color.White;
            SearchNIP.Image = (Image)resources.GetObject("SearchNIP.Image");
            SearchNIP.ImageAlign = ContentAlignment.MiddleLeft;
            SearchNIP.Location = new Point(529, 241);
            SearchNIP.Name = "SearchNIP";
            SearchNIP.Padding = new Padding(5, 0, 0, 0);
            SearchNIP.Size = new Size(121, 29);
            SearchNIP.TabIndex = 8;
            SearchNIP.Text = "Cari";
            SearchNIP.UseVisualStyleBackColor = false;
            SearchNIP.Click += SearchNIP_Click;
            // 
            // LabelTinggiBadan
            // 
            LabelTinggiBadan.AutoSize = true;
            LabelTinggiBadan.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTinggiBadan.Location = new Point(102, 420);
            LabelTinggiBadan.Name = "LabelTinggiBadan";
            LabelTinggiBadan.Size = new Size(160, 31);
            LabelTinggiBadan.TabIndex = 1;
            LabelTinggiBadan.Text = "Tinggi Badan :";
            // 
            // InputTinggiBadan
            // 
            InputTinggiBadan.Location = new Point(268, 426);
            InputTinggiBadan.Name = "InputTinggiBadan";
            InputTinggiBadan.Size = new Size(392, 27);
            InputTinggiBadan.TabIndex = 1;
            // 
            // LabelBeratBadan
            // 
            LabelBeratBadan.AutoSize = true;
            LabelBeratBadan.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelBeratBadan.Location = new Point(102, 492);
            LabelBeratBadan.Name = "LabelBeratBadan";
            LabelBeratBadan.Size = new Size(148, 31);
            LabelBeratBadan.TabIndex = 1;
            LabelBeratBadan.Text = "Berat Badan :";
            // 
            // InputBeratBadan
            // 
            InputBeratBadan.Location = new Point(268, 498);
            InputBeratBadan.Name = "InputBeratBadan";
            InputBeratBadan.Size = new Size(392, 27);
            InputBeratBadan.TabIndex = 1;
            // 
            // LabelTekananDarah
            // 
            LabelTekananDarah.AutoSize = true;
            LabelTekananDarah.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTekananDarah.Location = new Point(102, 566);
            LabelTekananDarah.Name = "LabelTekananDarah";
            LabelTekananDarah.Size = new Size(175, 31);
            LabelTekananDarah.TabIndex = 1;
            LabelTekananDarah.Text = "Tekanan Darah :";
            // 
            // InputTekananDarah
            // 
            InputTekananDarah.Location = new Point(283, 572);
            InputTekananDarah.Name = "InputTekananDarah";
            InputTekananDarah.Size = new Size(377, 27);
            InputTekananDarah.TabIndex = 1;
            // 
            // LabelKeluhan
            // 
            LabelKeluhan.AutoSize = true;
            LabelKeluhan.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelKeluhan.Location = new Point(721, 137);
            LabelKeluhan.Name = "LabelKeluhan";
            LabelKeluhan.Size = new Size(107, 31);
            LabelKeluhan.TabIndex = 1;
            LabelKeluhan.Text = "Keluhan :";
            // 
            // LabelNamaObat
            // 
            LabelNamaObat.AutoSize = true;
            LabelNamaObat.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNamaObat.Location = new Point(721, 566);
            LabelNamaObat.Name = "LabelNamaObat";
            LabelNamaObat.Size = new Size(143, 31);
            LabelNamaObat.TabIndex = 1;
            LabelNamaObat.Text = "Nama Obat :";
            // 
            // InputKodeObat
            // 
            InputKodeObat.Location = new Point(870, 572);
            InputKodeObat.Name = "InputKodeObat";
            InputKodeObat.Size = new Size(307, 27);
            InputKodeObat.TabIndex = 1;
            // 
            // InputKeluhan
            // 
            InputKeluhan.Location = new Point(870, 137);
            InputKeluhan.Multiline = true;
            InputKeluhan.Name = "InputKeluhan";
            InputKeluhan.Size = new Size(434, 165);
            InputKeluhan.TabIndex = 6;
            // 
            // OutputNamaDokter
            // 
            OutputNamaDokter.AutoSize = true;
            OutputNamaDokter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OutputNamaDokter.Location = new Point(146, 276);
            OutputNamaDokter.Name = "OutputNamaDokter";
            OutputNamaDokter.Size = new Size(78, 28);
            OutputNamaDokter.TabIndex = 9;
            OutputNamaDokter.Text = "Nama : ";
            // 
            // OutputNamaPasien
            // 
            OutputNamaPasien.AutoSize = true;
            OutputNamaPasien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OutputNamaPasien.Location = new Point(146, 176);
            OutputNamaPasien.Name = "OutputNamaPasien";
            OutputNamaPasien.Size = new Size(78, 28);
            OutputNamaPasien.TabIndex = 9;
            OutputNamaPasien.Text = "Nama : ";
            // 
            // OutputNamaObat
            // 
            OutputNamaObat.AutoSize = true;
            OutputNamaObat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OutputNamaObat.Location = new Point(786, 607);
            OutputNamaObat.Name = "OutputNamaObat";
            OutputNamaObat.Size = new Size(78, 28);
            OutputNamaObat.TabIndex = 10;
            OutputNamaObat.Text = "Nama : ";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1183, 570);
            button1.Name = "button1";
            button1.Padding = new Padding(5, 0, 0, 0);
            button1.Size = new Size(121, 29);
            button1.TabIndex = 11;
            button1.Text = "Cari";
            button1.UseVisualStyleBackColor = false;
            button1.Click += searchObat_Click;
            // 
            // PemeriksaanEditDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(button1);
            Controls.Add(OutputNamaObat);
            Controls.Add(OutputNamaPasien);
            Controls.Add(OutputNamaDokter);
            Controls.Add(SearchNIP);
            Controls.Add(SearchNIK);
            Controls.Add(InputKodeObat);
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
            Controls.Add(LabelHeaderEditPemeriksaan);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PemeriksaanEditDisplay";
            Text = "PasienEditDisplay";
            TransparencyKey = Color.Fuchsia;
            Load += PemeriksaanEditDisplay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelHeaderEditPemeriksaan;
        private Label LabelNama;
        private Label LabelTanggalPemeriksaan;
        private Label LabelDiagnosa;
        private Button ButtonSubmit;
        private TextBox InputNIK;
        private DateTimePicker InputTanggal;
        private TextBox InputDiagnosa;
        private Button SearchNIK;
        private Label LabelPasien;
        private TextBox InputNIP;
        private Button SearchNIP;
        private Label LabelTinggiBadan;
        private TextBox InputTinggiBadan;
        private Label LabelBeratBadan;
        private TextBox InputBeratBadan;
        private Label LabelTekananDarah;
        private TextBox InputTekananDarah;
        private Label LabelKeluhan;
        private Label LabelNamaObat;
        private TextBox InputKodeObat;
        private TextBox InputKeluhan;
        private Label OutputNamaDokter;
        private Label OutputNamaPasien;
        private Label OutputNamaObat;
        private Button button1;
    }
}