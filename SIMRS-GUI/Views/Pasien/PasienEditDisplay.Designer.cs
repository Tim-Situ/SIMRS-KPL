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
            InputAlamat = new TextBox();
            RadioWanita = new RadioButton();
            RadioPria = new RadioButton();
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
            labelTanggalLahir.Location = new Point(349, 205);
            labelTanggalLahir.Name = "labelTanggalLahir";
            labelTanggalLahir.Size = new Size(161, 31);
            labelTanggalLahir.TabIndex = 1;
            labelTanggalLahir.Text = "Tanggal Lahir :";
            // 
            // labelNoHP
            // 
            labelNoHP.AutoSize = true;
            labelNoHP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelNoHP.Location = new Point(421, 267);
            labelNoHP.Name = "labelNoHP";
            labelNoHP.Size = new Size(90, 31);
            labelNoHP.TabIndex = 1;
            labelNoHP.Text = "No HP :";
            // 
            // labelJenisKelamin
            // 
            labelJenisKelamin.AutoSize = true;
            labelJenisKelamin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelJenisKelamin.Location = new Point(347, 333);
            labelJenisKelamin.Name = "labelJenisKelamin";
            labelJenisKelamin.Size = new Size(162, 31);
            labelJenisKelamin.TabIndex = 1;
            labelJenisKelamin.Text = "Jenis Kelamin :";
            // 
            // labelAlamat
            // 
            labelAlamat.AutoSize = true;
            labelAlamat.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelAlamat.Location = new Point(411, 401);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(98, 31);
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
            ButtonSubmit.Location = new Point(622, 652);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(184, 45);
            ButtonSubmit.TabIndex = 7;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = false;
            ButtonSubmit.Click += ButtonSubmit_Click;
            // 
            // InputNama
            // 
            InputNama.Location = new Point(533, 145);
            InputNama.Name = "InputNama";
            InputNama.Size = new Size(371, 27);
            InputNama.TabIndex = 1;
            // 
            // InputNoHp
            // 
            InputNoHp.Location = new Point(533, 272);
            InputNoHp.Name = "InputNoHp";
            InputNoHp.Size = new Size(371, 27);
            InputNoHp.TabIndex = 3;
            // 
            // InputTanggal
            // 
            InputTanggal.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            InputTanggal.Location = new Point(533, 211);
            InputTanggal.Name = "InputTanggal";
            InputTanggal.Size = new Size(371, 27);
            InputTanggal.TabIndex = 2;
            // 
            // InputAlamat
            // 
            InputAlamat.Location = new Point(533, 407);
            InputAlamat.Multiline = true;
            InputAlamat.Name = "InputAlamat";
            InputAlamat.Size = new Size(371, 185);
            InputAlamat.TabIndex = 6;
            // 
            // RadioWanita
            // 
            RadioWanita.AutoSize = true;
            RadioWanita.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RadioWanita.Location = new Point(687, 333);
            RadioWanita.Name = "RadioWanita";
            RadioWanita.Size = new Size(94, 32);
            RadioWanita.TabIndex = 5;
            RadioWanita.Text = "Wanita";
            RadioWanita.UseVisualStyleBackColor = true;
            // 
            // RadioPria
            // 
            RadioPria.AutoSize = true;
            RadioPria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RadioPria.Location = new Point(534, 333);
            RadioPria.Name = "RadioPria";
            RadioPria.Size = new Size(66, 32);
            RadioPria.TabIndex = 4;
            RadioPria.Text = "Pria";
            RadioPria.UseVisualStyleBackColor = true;
            // 
            // PasienEditDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(RadioWanita);
            Controls.Add(RadioPria);
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
        private TextBox InputAlamat;
        private RadioButton RadioWanita;
        private RadioButton RadioPria;
    }
}