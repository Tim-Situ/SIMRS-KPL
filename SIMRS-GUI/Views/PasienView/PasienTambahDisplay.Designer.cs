namespace SIMRS_GUI.Views.PasienView
{
    partial class PasienTambahDisplay
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
            LabelHeaderPasien = new Label();
            LabeNIK = new Label();
            InputNIK = new TextBox();
            SuspendLayout();
            // 
            // RadioWanita
            // 
            RadioWanita.AutoSize = true;
            RadioWanita.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RadioWanita.Location = new Point(682, 397);
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
            RadioPria.Location = new Point(529, 397);
            RadioPria.Name = "RadioPria";
            RadioPria.Size = new Size(66, 32);
            RadioPria.TabIndex = 5;
            RadioPria.Text = "Pria";
            RadioPria.UseVisualStyleBackColor = true;
            // 
            // InputTanggal
            // 
            InputTanggal.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            InputTanggal.Location = new Point(529, 275);
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
            InputAlamat.Location = new Point(529, 472);
            InputAlamat.Multiline = true;
            InputAlamat.Name = "InputAlamat";
            InputAlamat.Size = new Size(371, 185);
            InputAlamat.TabIndex = 7;
            // 
            // InputNoHp
            // 
            InputNoHp.Location = new Point(529, 337);
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
            ButtonSubmit.Location = new Point(618, 693);
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
            LabelAlamat.Location = new Point(408, 467);
            LabelAlamat.Name = "LabelAlamat";
            LabelAlamat.Size = new Size(98, 31);
            LabelAlamat.TabIndex = 7;
            LabelAlamat.Text = "Alamat :";
            // 
            // LabelJenisKelamin
            // 
            LabelJenisKelamin.AutoSize = true;
            LabelJenisKelamin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelJenisKelamin.Location = new Point(344, 397);
            LabelJenisKelamin.Name = "LabelJenisKelamin";
            LabelJenisKelamin.Size = new Size(162, 31);
            LabelJenisKelamin.TabIndex = 8;
            LabelJenisKelamin.Text = "Jenis Kelamin :";
            // 
            // LabelNoHP
            // 
            LabelNoHP.AutoSize = true;
            LabelNoHP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNoHP.Location = new Point(416, 331);
            LabelNoHP.Name = "LabelNoHP";
            LabelNoHP.Size = new Size(90, 31);
            LabelNoHP.TabIndex = 9;
            LabelNoHP.Text = "No HP :";
            // 
            // LabelTanggalLahir
            // 
            LabelTanggalLahir.AutoSize = true;
            LabelTanggalLahir.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTanggalLahir.Location = new Point(345, 271);
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
            LabelNama.Size = new Size(157, 31);
            LabelNama.TabIndex = 11;
            LabelNama.Text = "Nama Pasien :";
            // 
            // LabelHeaderPasien
            // 
            LabelHeaderPasien.AutoSize = true;
            LabelHeaderPasien.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHeaderPasien.Location = new Point(513, 55);
            LabelHeaderPasien.Name = "LabelHeaderPasien";
            LabelHeaderPasien.Size = new Size(406, 54);
            LabelHeaderPasien.TabIndex = 6;
            LabelHeaderPasien.Text = "Tambah Data Pasien";
            // 
            // LabeNIK
            // 
            LabeNIK.AutoSize = true;
            LabeNIK.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabeNIK.Location = new Point(374, 143);
            LabeNIK.Name = "LabeNIK";
            LabeNIK.Size = new Size(132, 31);
            LabeNIK.TabIndex = 11;
            LabeNIK.Text = "NIK Pasien :";
            // 
            // InputNIK
            // 
            InputNIK.ImeMode = ImeMode.NoControl;
            InputNIK.Location = new Point(529, 149);
            InputNIK.Name = "InputNIK";
            InputNIK.Size = new Size(371, 27);
            InputNIK.TabIndex = 1;
            // 
            // PasienTambahDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(RadioWanita);
            Controls.Add(RadioPria);
            Controls.Add(InputTanggal);
            Controls.Add(InputNIK);
            Controls.Add(InputNama);
            Controls.Add(InputAlamat);
            Controls.Add(InputNoHp);
            Controls.Add(ButtonSubmit);
            Controls.Add(LabelAlamat);
            Controls.Add(LabelJenisKelamin);
            Controls.Add(LabelNoHP);
            Controls.Add(LabelTanggalLahir);
            Controls.Add(LabeNIK);
            Controls.Add(LabelNama);
            Controls.Add(LabelHeaderPasien);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PasienTambahDisplay";
            Text = "PasienTambahDisplay";
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
        private Label LabelHeaderPasien;
        private Label LabeNIK;
        private TextBox InputNIK;
    }
}