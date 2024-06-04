namespace SIMRS_GUI
{
    partial class PasienEditDisplay
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
            label1 = new Label();
            labelNama = new Label();
            labelTanggalLahir = new Label();
            labelNoHP = new Label();
            labelJenisKelamin = new Label();
            labelAlamat = new Label();
            buttonSubmit = new Button();
            inputNama = new TextBox();
            inputNoHp = new TextBox();
            inputTanggal = new DateTimePicker();
            rbLakiLaki = new RadioButton();
            rbPerempuan = new RadioButton();
            inputAlamat = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(557, 35);
            label1.Name = "label1";
            label1.Size = new Size(329, 54);
            label1.TabIndex = 0;
            label1.Text = "Edit Data Pasien";
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelNama.Location = new Point(353, 139);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(157, 31);
            labelNama.TabIndex = 1;
            labelNama.Text = "Nama Pasien :";
            // 
            // labelTanggalLahir
            // 
            labelTanggalLahir.AutoSize = true;
            labelTanggalLahir.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelTanggalLahir.Location = new Point(349, 206);
            labelTanggalLahir.Name = "labelTanggalLahir";
            labelTanggalLahir.Size = new Size(161, 31);
            labelTanggalLahir.TabIndex = 1;
            labelTanggalLahir.Text = "Tanggal Lahir :";
            // 
            // labelNoHP
            // 
            labelNoHP.AutoSize = true;
            labelNoHP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelNoHP.Location = new Point(420, 266);
            labelNoHP.Name = "labelNoHP";
            labelNoHP.Size = new Size(90, 31);
            labelNoHP.TabIndex = 1;
            labelNoHP.Text = "No HP :";
            // 
            // labelJenisKelamin
            // 
            labelJenisKelamin.AutoSize = true;
            labelJenisKelamin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelJenisKelamin.Location = new Point(348, 333);
            labelJenisKelamin.Name = "labelJenisKelamin";
            labelJenisKelamin.Size = new Size(162, 31);
            labelJenisKelamin.TabIndex = 1;
            labelJenisKelamin.Text = "Jenis Kelamin :";
            // 
            // labelAlamat
            // 
            labelAlamat.AutoSize = true;
            labelAlamat.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelAlamat.Location = new Point(412, 401);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(98, 31);
            labelAlamat.TabIndex = 1;
            labelAlamat.Text = "Alamat :";
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.Transparent;
            buttonSubmit.FlatAppearance.BorderColor = SystemColors.Highlight;
            buttonSubmit.FlatStyle = FlatStyle.Flat;
            buttonSubmit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSubmit.ForeColor = SystemColors.Highlight;
            buttonSubmit.Location = new Point(622, 652);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(184, 46);
            buttonSubmit.TabIndex = 2;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            // 
            // inputNama
            // 
            inputNama.Location = new Point(533, 145);
            inputNama.Name = "inputNama";
            inputNama.Size = new Size(371, 27);
            inputNama.TabIndex = 3;
            // 
            // inputNoHp
            // 
            inputNoHp.Location = new Point(533, 272);
            inputNoHp.Name = "inputNoHp";
            inputNoHp.Size = new Size(371, 27);
            inputNoHp.TabIndex = 3;
            // 
            // inputTanggal
            // 
            inputTanggal.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inputTanggal.Location = new Point(533, 210);
            inputTanggal.Name = "inputTanggal";
            inputTanggal.Size = new Size(371, 27);
            inputTanggal.TabIndex = 4;
            // 
            // rbLakiLaki
            // 
            rbLakiLaki.AutoSize = true;
            rbLakiLaki.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbLakiLaki.Location = new Point(533, 333);
            rbLakiLaki.Name = "rbLakiLaki";
            rbLakiLaki.Size = new Size(119, 32);
            rbLakiLaki.TabIndex = 5;
            rbLakiLaki.TabStop = true;
            rbLakiLaki.Text = "Laki - Laki";
            rbLakiLaki.UseVisualStyleBackColor = true;
            // 
            // rbPerempuan
            // 
            rbPerempuan.AutoSize = true;
            rbPerempuan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbPerempuan.Location = new Point(686, 333);
            rbPerempuan.Name = "rbPerempuan";
            rbPerempuan.Size = new Size(131, 32);
            rbPerempuan.TabIndex = 5;
            rbPerempuan.TabStop = true;
            rbPerempuan.Text = "Perempuan";
            rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // inputAlamat
            // 
            inputAlamat.Location = new Point(533, 407);
            inputAlamat.Multiline = true;
            inputAlamat.Name = "inputAlamat";
            inputAlamat.Size = new Size(371, 186);
            inputAlamat.TabIndex = 3;
            // 
            // PasienEditDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(rbPerempuan);
            Controls.Add(rbLakiLaki);
            Controls.Add(inputTanggal);
            Controls.Add(inputNama);
            Controls.Add(inputAlamat);
            Controls.Add(inputNoHp);
            Controls.Add(buttonSubmit);
            Controls.Add(labelAlamat);
            Controls.Add(labelJenisKelamin);
            Controls.Add(labelNoHP);
            Controls.Add(labelTanggalLahir);
            Controls.Add(labelNama);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PasienEditDisplay";
            Text = "PasienEditDisplay";
            TransparencyKey = Color.Fuchsia;
            Load += PasienEditDisplay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelNama;
        private Label labelTanggalLahir;
        private Label labelNoHP;
        private Label labelJenisKelamin;
        private Label labelAlamat;
        private Button buttonSubmit;
        private TextBox inputNama;
        private TextBox inputNoHp;
        private DateTimePicker inputTanggal;
        private RadioButton rbLakiLaki;
        private RadioButton rbPerempuan;
        private TextBox inputAlamat;
    }
}