namespace SIMRS_GUI.Views.DokterView
{
    partial class DokterTambahDisplay
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
            RadioWanita = new RadioButton();
            RadioPria = new RadioButton();
            InputTanggal = new DateTimePicker();
            InputNama = new TextBox();
            InputAlamat = new TextBox();
            InputNoHp = new TextBox();
            ButtonSubmit = new Button();
            LabelAlamat = new Label();
            LabelJenisKelamin = new Label();
            LabelNoHP = new Label();
            LabelTanggalLahir = new Label();
            LabelNama = new Label();
            LabelHeaderTambahDokter = new Label();
            LabelNIP = new Label();
            InputNIP = new TextBox();
            LabelPoli = new Label();
            InputPoli = new ComboBox();
            SuspendLayout();
            // 
            // RadioWanita
            // 
            RadioWanita.AutoSize = true;
            RadioWanita.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RadioWanita.Location = new Point(682, 459);
            RadioWanita.Name = "RadioWanita";
            RadioWanita.Size = new Size(94, 32);
            RadioWanita.TabIndex = 6;
            RadioWanita.Text = "Wanita";
            RadioWanita.UseVisualStyleBackColor = true;
            // 
            // RadioPria
            // 
            RadioPria.AutoSize = true;
            RadioPria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RadioPria.Location = new Point(529, 459);
            RadioPria.Name = "RadioPria";
            RadioPria.Size = new Size(66, 32);
            RadioPria.TabIndex = 5;
            RadioPria.Text = "Pria";
            RadioPria.UseVisualStyleBackColor = true;
            // 
            // InputTanggal
            // 
            InputTanggal.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            InputTanggal.Location = new Point(529, 337);
            InputTanggal.MinDate = new DateTime(1800, 1, 1, 0, 0, 0, 0);
            InputTanggal.Name = "InputTanggal";
            InputTanggal.Size = new Size(371, 27);
            InputTanggal.TabIndex = 3;
            InputTanggal.Value = new DateTime(2024, 6, 5, 0, 0, 0, 0);
            // 
            // InputNama
            // 
            InputNama.Location = new Point(529, 211);
            InputNama.Name = "InputNama";
            InputNama.Size = new Size(371, 27);
            InputNama.TabIndex = 2;
            // 
            // InputAlamat
            // 
            InputAlamat.Location = new Point(529, 534);
            InputAlamat.Multiline = true;
            InputAlamat.Name = "InputAlamat";
            InputAlamat.Size = new Size(371, 185);
            InputAlamat.TabIndex = 7;
            // 
            // InputNoHp
            // 
            InputNoHp.Location = new Point(529, 399);
            InputNoHp.Name = "InputNoHp";
            InputNoHp.Size = new Size(371, 27);
            InputNoHp.TabIndex = 4;
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.BackColor = Color.Transparent;
            ButtonSubmit.FlatAppearance.BorderColor = SystemColors.Highlight;
            ButtonSubmit.FlatStyle = FlatStyle.Flat;
            ButtonSubmit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSubmit.ForeColor = SystemColors.Highlight;
            ButtonSubmit.Location = new Point(618, 755);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(184, 45);
            ButtonSubmit.TabIndex = 8;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = false;
            ButtonSubmit.Click += ButtonSubmit_Click;
            // 
            // LabelAlamat
            // 
            LabelAlamat.AutoSize = true;
            LabelAlamat.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAlamat.Location = new Point(408, 529);
            LabelAlamat.Name = "LabelAlamat";
            LabelAlamat.Size = new Size(98, 31);
            LabelAlamat.TabIndex = 7;
            LabelAlamat.Text = "Alamat :";
            // 
            // LabelJenisKelamin
            // 
            LabelJenisKelamin.AutoSize = true;
            LabelJenisKelamin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelJenisKelamin.Location = new Point(344, 459);
            LabelJenisKelamin.Name = "LabelJenisKelamin";
            LabelJenisKelamin.Size = new Size(162, 31);
            LabelJenisKelamin.TabIndex = 8;
            LabelJenisKelamin.Text = "Jenis Kelamin :";
            // 
            // LabelNoHP
            // 
            LabelNoHP.AutoSize = true;
            LabelNoHP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNoHP.Location = new Point(416, 393);
            LabelNoHP.Name = "LabelNoHP";
            LabelNoHP.Size = new Size(90, 31);
            LabelNoHP.TabIndex = 9;
            LabelNoHP.Text = "No HP :";
            // 
            // LabelTanggalLahir
            // 
            LabelTanggalLahir.AutoSize = true;
            LabelTanggalLahir.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTanggalLahir.Location = new Point(345, 333);
            LabelTanggalLahir.Name = "LabelTanggalLahir";
            LabelTanggalLahir.Size = new Size(161, 31);
            LabelTanggalLahir.TabIndex = 10;
            LabelTanggalLahir.Text = "Tanggal Lahir :";
            // 
            // LabelNama
            // 
            LabelNama.AutoSize = true;
            LabelNama.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNama.Location = new Point(349, 204);
            LabelNama.Name = "LabelNama";
            LabelNama.Size = new Size(160, 31);
            LabelNama.TabIndex = 11;
            LabelNama.Text = "Nama Dokter :";
            // 
            // LabelHeaderTambahDokter
            // 
            LabelHeaderTambahDokter.AutoSize = true;
            LabelHeaderTambahDokter.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHeaderTambahDokter.Location = new Point(503, 55);
            LabelHeaderTambahDokter.Name = "LabelHeaderTambahDokter";
            LabelHeaderTambahDokter.Size = new Size(415, 54);
            LabelHeaderTambahDokter.TabIndex = 6;
            LabelHeaderTambahDokter.Text = "Tambah Data Dokter";
            // 
            // LabelNIP
            // 
            LabelNIP.AutoSize = true;
            LabelNIP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNIP.Location = new Point(374, 143);
            LabelNIP.Name = "LabelNIP";
            LabelNIP.Size = new Size(135, 31);
            LabelNIP.TabIndex = 11;
            LabelNIP.Text = "NIP Dokter :";
            // 
            // InputNIP
            // 
            InputNIP.ImeMode = ImeMode.NoControl;
            InputNIP.Location = new Point(529, 149);
            InputNIP.Name = "InputNIP";
            InputNIP.Size = new Size(371, 27);
            InputNIP.TabIndex = 1;
            // 
            // LabelPoli
            // 
            LabelPoli.AutoSize = true;
            LabelPoli.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPoli.Location = new Point(444, 266);
            LabelPoli.Name = "LabelPoli";
            LabelPoli.Size = new Size(62, 31);
            LabelPoli.TabIndex = 12;
            LabelPoli.Text = "Poli :";
            // 
            // InputPoli
            // 
            InputPoli.FormattingEnabled = true;
            InputPoli.Location = new Point(529, 272);
            InputPoli.Name = "InputPoli";
            InputPoli.Size = new Size(371, 28);
            InputPoli.TabIndex = 13;
            InputPoli.Text = "(Pilih poli)";
            // 
            // DokterTambahDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(InputPoli);
            Controls.Add(LabelPoli);
            Controls.Add(RadioWanita);
            Controls.Add(RadioPria);
            Controls.Add(InputTanggal);
            Controls.Add(InputNIP);
            Controls.Add(InputNama);
            Controls.Add(InputAlamat);
            Controls.Add(InputNoHp);
            Controls.Add(ButtonSubmit);
            Controls.Add(LabelAlamat);
            Controls.Add(LabelJenisKelamin);
            Controls.Add(LabelNoHP);
            Controls.Add(LabelTanggalLahir);
            Controls.Add(LabelNIP);
            Controls.Add(LabelNama);
            Controls.Add(LabelHeaderTambahDokter);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DokterTambahDisplay";
            Text = "PasienTambahDisplay";
            Load += DokterTambahDisplay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton RadioWanita;
        private RadioButton RadioPria;
        private DateTimePicker InputTanggal;
        private TextBox InputNama;
        private TextBox InputAlamat;
        private TextBox InputNoHp;
        private Button ButtonSubmit;
        private Label LabelAlamat;
        private Label LabelJenisKelamin;
        private Label LabelNoHP;
        private Label LabelTanggalLahir;
        private Label LabelNama;
        private Label LabelHeaderTambahDokter;
        private Label LabelNIP;
        private TextBox InputNIP;
        private Label LabelPoli;
        private ComboBox InputPoli;
    }
}