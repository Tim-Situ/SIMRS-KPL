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
            inputTanggal = new DateTimePicker();
            inputNama = new TextBox();
            inputAlamat = new TextBox();
            inputNoHp = new TextBox();
            buttonSubmit = new Button();
            labelAlamat = new Label();
            labelJenisKelamin = new Label();
            labelNoHP = new Label();
            labelTanggalLahir = new Label();
            labelNama = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // rbPerempuan
            // 
            rbPerempuan.AutoSize = true;
            rbPerempuan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbPerempuan.Location = new Point(682, 398);
            rbPerempuan.Name = "rbPerempuan";
            rbPerempuan.Size = new Size(131, 32);
            rbPerempuan.TabIndex = 17;
            rbPerempuan.TabStop = true;
            rbPerempuan.Text = "Perempuan";
            rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // rbLakiLaki
            // 
            rbLakiLaki.AutoSize = true;
            rbLakiLaki.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbLakiLaki.Location = new Point(529, 398);
            rbLakiLaki.Name = "rbLakiLaki";
            rbLakiLaki.Size = new Size(119, 32);
            rbLakiLaki.TabIndex = 18;
            rbLakiLaki.TabStop = true;
            rbLakiLaki.Text = "Laki - Laki";
            rbLakiLaki.UseVisualStyleBackColor = true;
            // 
            // inputTanggal
            // 
            inputTanggal.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inputTanggal.Location = new Point(529, 275);
            inputTanggal.Name = "inputTanggal";
            inputTanggal.Size = new Size(371, 27);
            inputTanggal.TabIndex = 16;
            // 
            // inputNama
            // 
            inputNama.Location = new Point(529, 210);
            inputNama.Name = "inputNama";
            inputNama.Size = new Size(371, 27);
            inputNama.TabIndex = 13;
            // 
            // inputAlamat
            // 
            inputAlamat.Location = new Point(529, 472);
            inputAlamat.Multiline = true;
            inputAlamat.Name = "inputAlamat";
            inputAlamat.Size = new Size(371, 186);
            inputAlamat.TabIndex = 14;
            // 
            // inputNoHp
            // 
            inputNoHp.Location = new Point(529, 337);
            inputNoHp.Name = "inputNoHp";
            inputNoHp.Size = new Size(371, 27);
            inputNoHp.TabIndex = 15;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.Transparent;
            buttonSubmit.FlatAppearance.BorderColor = SystemColors.Highlight;
            buttonSubmit.FlatStyle = FlatStyle.Flat;
            buttonSubmit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSubmit.ForeColor = SystemColors.Highlight;
            buttonSubmit.Location = new Point(618, 694);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(184, 46);
            buttonSubmit.TabIndex = 12;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            // 
            // labelAlamat
            // 
            labelAlamat.AutoSize = true;
            labelAlamat.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelAlamat.Location = new Point(408, 466);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(98, 31);
            labelAlamat.TabIndex = 7;
            labelAlamat.Text = "Alamat :";
            // 
            // labelJenisKelamin
            // 
            labelJenisKelamin.AutoSize = true;
            labelJenisKelamin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelJenisKelamin.Location = new Point(344, 398);
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
            // textBox1
            // 
            textBox1.ImeMode = ImeMode.NoControl;
            textBox1.Location = new Point(529, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(371, 27);
            textBox1.TabIndex = 13;
            // 
            // PasienTambahDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(rbPerempuan);
            Controls.Add(rbLakiLaki);
            Controls.Add(inputTanggal);
            Controls.Add(textBox1);
            Controls.Add(inputNama);
            Controls.Add(inputAlamat);
            Controls.Add(inputNoHp);
            Controls.Add(buttonSubmit);
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
        private DateTimePicker inputTanggal;
        private TextBox inputNama;
        private TextBox inputAlamat;
        private TextBox inputNoHp;
        private Button buttonSubmit;
        private Label labelAlamat;
        private Label labelJenisKelamin;
        private Label labelNoHP;
        private Label labelTanggalLahir;
        private Label labelNama;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
    }
}