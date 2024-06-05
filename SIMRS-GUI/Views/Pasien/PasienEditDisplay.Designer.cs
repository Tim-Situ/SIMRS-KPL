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
            ButtonSubmit = new Button();
            InputNama = new TextBox();
            InputNoHp = new TextBox();
            InputTanggal = new DateTimePicker();
            rbLakiLaki = new RadioButton();
            rbPerempuan = new RadioButton();
            InputAlamat = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(487, 26);
            label1.Name = "label1";
            label1.Size = new Size(261, 45);
            label1.TabIndex = 0;
            label1.Text = "Edit Data Pasien";
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelNama.Location = new Point(309, 104);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(130, 25);
            labelNama.TabIndex = 1;
            labelNama.Text = "Nama Pasien :";
            // 
            // labelTanggalLahir
            // 
            labelTanggalLahir.AutoSize = true;
            labelTanggalLahir.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelTanggalLahir.Location = new Point(305, 154);
            labelTanggalLahir.Name = "labelTanggalLahir";
            labelTanggalLahir.Size = new Size(134, 25);
            labelTanggalLahir.TabIndex = 1;
            labelTanggalLahir.Text = "Tanggal Lahir :";
            // 
            // labelNoHP
            // 
            labelNoHP.AutoSize = true;
            labelNoHP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelNoHP.Location = new Point(368, 200);
            labelNoHP.Name = "labelNoHP";
            labelNoHP.Size = new Size(75, 25);
            labelNoHP.TabIndex = 1;
            labelNoHP.Text = "No HP :";
            // 
            // labelJenisKelamin
            // 
            labelJenisKelamin.AutoSize = true;
            labelJenisKelamin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelJenisKelamin.Location = new Point(304, 250);
            labelJenisKelamin.Name = "labelJenisKelamin";
            labelJenisKelamin.Size = new Size(135, 25);
            labelJenisKelamin.TabIndex = 1;
            labelJenisKelamin.Text = "Jenis Kelamin :";
            // 
            // labelAlamat
            // 
            labelAlamat.AutoSize = true;
            labelAlamat.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelAlamat.Location = new Point(360, 301);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(80, 25);
            labelAlamat.TabIndex = 1;
            labelAlamat.Text = "Alamat :";
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.BackColor = Color.Transparent;
            ButtonSubmit.FlatAppearance.BorderColor = SystemColors.Highlight;
            ButtonSubmit.FlatStyle = FlatStyle.Flat;
            ButtonSubmit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSubmit.ForeColor = SystemColors.Highlight;
            ButtonSubmit.Location = new Point(544, 489);
            ButtonSubmit.Margin = new Padding(3, 2, 3, 2);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(161, 34);
            ButtonSubmit.TabIndex = 2;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = false;
            // 
            // InputNama
            // 
            InputNama.Location = new Point(466, 109);
            InputNama.Margin = new Padding(3, 2, 3, 2);
            InputNama.Name = "InputNama";
            InputNama.Size = new Size(325, 23);
            InputNama.TabIndex = 3;
            // 
            // InputNoHp
            // 
            InputNoHp.Location = new Point(466, 204);
            InputNoHp.Margin = new Padding(3, 2, 3, 2);
            InputNoHp.Name = "InputNoHp";
            InputNoHp.Size = new Size(325, 23);
            InputNoHp.TabIndex = 3;
            // 
            // InputTanggal
            // 
            InputTanggal.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            InputTanggal.Location = new Point(466, 158);
            InputTanggal.Margin = new Padding(3, 2, 3, 2);
            InputTanggal.Name = "InputTanggal";
            InputTanggal.Size = new Size(325, 23);
            InputTanggal.TabIndex = 4;
            // 
            // rbLakiLaki
            // 
            rbLakiLaki.AutoSize = true;
            rbLakiLaki.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbLakiLaki.Location = new Point(466, 250);
            rbLakiLaki.Margin = new Padding(3, 2, 3, 2);
            rbLakiLaki.Name = "rbLakiLaki";
            rbLakiLaki.Size = new Size(98, 25);
            rbLakiLaki.TabIndex = 5;
            rbLakiLaki.TabStop = true;
            rbLakiLaki.Text = "Laki - Laki";
            rbLakiLaki.UseVisualStyleBackColor = true;
            // 
            // rbPerempuan
            // 
            rbPerempuan.AutoSize = true;
            rbPerempuan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbPerempuan.Location = new Point(600, 250);
            rbPerempuan.Margin = new Padding(3, 2, 3, 2);
            rbPerempuan.Name = "rbPerempuan";
            rbPerempuan.Size = new Size(107, 25);
            rbPerempuan.TabIndex = 5;
            rbPerempuan.TabStop = true;
            rbPerempuan.Text = "Perempuan";
            rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // InputAlamat
            // 
            InputAlamat.Location = new Point(466, 305);
            InputAlamat.Margin = new Padding(3, 2, 3, 2);
            InputAlamat.Multiline = true;
            InputAlamat.Name = "InputAlamat";
            InputAlamat.Size = new Size(325, 140);
            InputAlamat.TabIndex = 3;
            // 
            // PasienEditDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 638);
            Controls.Add(rbPerempuan);
            Controls.Add(rbLakiLaki);
            Controls.Add(InputTanggal);
            Controls.Add(InputNama);
            Controls.Add(InputAlamat);
            Controls.Add(InputNoHp);
            Controls.Add(ButtonSubmit);
            Controls.Add(labelAlamat);
            Controls.Add(labelJenisKelamin);
            Controls.Add(labelNoHP);
            Controls.Add(labelTanggalLahir);
            Controls.Add(labelNama);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private Button ButtonSubmit;
        private TextBox InputNama;
        private TextBox InputNoHp;
        private DateTimePicker InputTanggal;
        private RadioButton rbLakiLaki;
        private RadioButton rbPerempuan;
        private TextBox InputAlamat;
    }
}