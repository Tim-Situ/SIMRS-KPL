namespace SIMRS_GUI
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
            rbPerempuan = new RadioButton();
            rbLakiLaki = new RadioButton();
            InputTanggal = new DateTimePicker();
            InputNama = new TextBox();
            InputAlamat = new TextBox();
            InputNoHp = new TextBox();
            ButtonSubmit = new Button();
            labelAlamat = new Label();
            labelJenisKelamin = new Label();
            labelNoHP = new Label();
            labelTanggalLahir = new Label();
            labelNama = new Label();
            label1 = new Label();
            label2 = new Label();
            InputNIK = new TextBox();
            SuspendLayout();
            // 
            // rbPerempuan
            // 
            rbPerempuan.AutoSize = true;
            rbPerempuan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbPerempuan.Location = new Point(682, 397);
            rbPerempuan.Name = "rbPerempuan";
            rbPerempuan.Size = new Size(131, 32);
            rbPerempuan.TabIndex = 17;
            rbPerempuan.Text = "Perempuan";
            rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // rbLakiLaki
            // 
            rbLakiLaki.AutoSize = true;
            rbLakiLaki.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbLakiLaki.Location = new Point(529, 397);
            rbLakiLaki.Name = "rbLakiLaki";
            rbLakiLaki.Size = new Size(119, 32);
            rbLakiLaki.TabIndex = 18;
            rbLakiLaki.Text = "Laki - Laki";
            rbLakiLaki.UseVisualStyleBackColor = true;
            // 
            // InputTanggal
            // 
            InputTanggal.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            InputTanggal.Location = new Point(529, 275);
            InputTanggal.Name = "InputTanggal";
            InputTanggal.Size = new Size(371, 27);
            InputTanggal.TabIndex = 16;
            InputTanggal.Value = new DateTime(2024, 6, 4, 22, 46, 48, 0);
            // 
            // InputNama
            // 
            InputNama.Location = new Point(529, 211);
            InputNama.Name = "InputNama";
            InputNama.Size = new Size(371, 27);
            InputNama.TabIndex = 13;
            // 
            // InputAlamat
            // 
            InputAlamat.Location = new Point(529, 472);
            InputAlamat.Multiline = true;
            InputAlamat.Name = "InputAlamat";
            InputAlamat.Size = new Size(371, 185);
            InputAlamat.TabIndex = 14;
            // 
            // InputNoHp
            // 
            InputNoHp.Location = new Point(529, 337);
            InputNoHp.Name = "InputNoHp";
            InputNoHp.Size = new Size(371, 27);
            InputNoHp.TabIndex = 15;
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
            ButtonSubmit.TabIndex = 12;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = false;
            ButtonSubmit.Click += ButtonSubmit_Click;
            // 
            // labelAlamat
            // 
            labelAlamat.AutoSize = true;
            labelAlamat.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelAlamat.Location = new Point(408, 467);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(98, 31);
            labelAlamat.TabIndex = 7;
            labelAlamat.Text = "Alamat :";
            // 
            // labelJenisKelamin
            // 
            labelJenisKelamin.AutoSize = true;
            labelJenisKelamin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelJenisKelamin.Location = new Point(344, 397);
            labelJenisKelamin.Name = "labelJenisKelamin";
            labelJenisKelamin.Size = new Size(162, 31);
            labelJenisKelamin.TabIndex = 8;
            labelJenisKelamin.Text = "Jenis Kelamin :";
            // 
            // labelNoHP
            // 
            labelNoHP.AutoSize = true;
            labelNoHP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelNoHP.Location = new Point(416, 331);
            labelNoHP.Name = "labelNoHP";
            labelNoHP.Size = new Size(90, 31);
            labelNoHP.TabIndex = 9;
            labelNoHP.Text = "No HP :";
            // 
            // labelTanggalLahir
            // 
            labelTanggalLahir.AutoSize = true;
            labelTanggalLahir.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelTanggalLahir.Location = new Point(345, 271);
            labelTanggalLahir.Name = "labelTanggalLahir";
            labelTanggalLahir.Size = new Size(161, 31);
            labelTanggalLahir.TabIndex = 10;
            labelTanggalLahir.Text = "Tanggal Lahir :";
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelNama.Location = new Point(349, 204);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(157, 31);
            labelNama.TabIndex = 11;
            labelNama.Text = "Nama Pasien :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(513, 55);
            label1.Name = "label1";
            label1.Size = new Size(406, 54);
            label1.TabIndex = 6;
            label1.Text = "Tambah Data Pasien";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(374, 143);
            label2.Name = "label2";
            label2.Size = new Size(132, 31);
            label2.TabIndex = 11;
            label2.Text = "NIK Pasien :";
            // 
            // InputNIK
            // 
            InputNIK.ImeMode = ImeMode.NoControl;
            InputNIK.Location = new Point(529, 149);
            InputNIK.Name = "InputNIK";
            InputNIK.Size = new Size(371, 27);
            InputNIK.TabIndex = 13;
            // 
            // PasienTambahDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(rbPerempuan);
            Controls.Add(rbLakiLaki);
            Controls.Add(InputTanggal);
            Controls.Add(InputNIK);
            Controls.Add(InputNama);
            Controls.Add(InputAlamat);
            Controls.Add(InputNoHp);
            Controls.Add(ButtonSubmit);
            Controls.Add(labelAlamat);
            Controls.Add(labelJenisKelamin);
            Controls.Add(labelNoHP);
            Controls.Add(labelTanggalLahir);
            Controls.Add(label2);
            Controls.Add(labelNama);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PasienTambahDisplay";
            Text = "PasienTambahDisplay";
            Load += PasienTambahDisplay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbPerempuan;
        private RadioButton rbLakiLaki;
        private DateTimePicker InputTanggal;
        private TextBox InputNama;
        private TextBox InputAlamat;
        private TextBox InputNoHp;
        private Button ButtonSubmit;
        private Label labelAlamat;
        private Label labelJenisKelamin;
        private Label labelNoHP;
        private Label labelTanggalLahir;
        private Label labelNama;
        private Label label1;
        private Label label2;
        private TextBox InputNIK;
    }
}