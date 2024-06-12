namespace SIMRS_GUI.Views.DokterView
{
    partial class DokterEditDisplay
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
            LabelHeaderEditDokter = new Label();
            LabelNama = new Label();
            LabelTanggalLahir = new Label();
            LabelNoHP = new Label();
            LabelJenisKelamin = new Label();
            LabelAlamat = new Label();
            ButtonSubmit = new Button();
            InputNama = new TextBox();
            InputNoHp = new TextBox();
            InputTanggal = new DateTimePicker();
            InputAlamat = new TextBox();
            RadioWanita = new RadioButton();
            RadioPria = new RadioButton();
            InputPoli = new ComboBox();
            LabelPoli = new Label();
            SuspendLayout();
            // 
            // LabelHeaderEditDokter
            // 
            LabelHeaderEditDokter.AutoSize = true;
            LabelHeaderEditDokter.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHeaderEditDokter.Location = new Point(547, 35);
            LabelHeaderEditDokter.Name = "LabelHeaderEditDokter";
            LabelHeaderEditDokter.Size = new Size(338, 54);
            LabelHeaderEditDokter.TabIndex = 0;
            LabelHeaderEditDokter.Text = "Edit Data Dokter";
            // 
            // LabelNama
            // 
            LabelNama.AutoSize = true;
            LabelNama.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNama.Location = new Point(353, 139);
            LabelNama.Name = "LabelNama";
            LabelNama.Size = new Size(160, 31);
            LabelNama.TabIndex = 1;
            LabelNama.Text = "Nama Dokter :";
            // 
            // LabelTanggalLahir
            // 
            LabelTanggalLahir.AutoSize = true;
            LabelTanggalLahir.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTanggalLahir.Location = new Point(349, 268);
            LabelTanggalLahir.Name = "LabelTanggalLahir";
            LabelTanggalLahir.Size = new Size(161, 31);
            LabelTanggalLahir.TabIndex = 1;
            LabelTanggalLahir.Text = "Tanggal Lahir :";
            // 
            // LabelNoHP
            // 
            LabelNoHP.AutoSize = true;
            LabelNoHP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNoHP.Location = new Point(421, 330);
            LabelNoHP.Name = "LabelNoHP";
            LabelNoHP.Size = new Size(90, 31);
            LabelNoHP.TabIndex = 1;
            LabelNoHP.Text = "No HP :";
            // 
            // LabelJenisKelamin
            // 
            LabelJenisKelamin.AutoSize = true;
            LabelJenisKelamin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelJenisKelamin.Location = new Point(347, 396);
            LabelJenisKelamin.Name = "LabelJenisKelamin";
            LabelJenisKelamin.Size = new Size(162, 31);
            LabelJenisKelamin.TabIndex = 1;
            LabelJenisKelamin.Text = "Jenis Kelamin :";
            // 
            // LabelAlamat
            // 
            LabelAlamat.AutoSize = true;
            LabelAlamat.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAlamat.Location = new Point(411, 464);
            LabelAlamat.Name = "LabelAlamat";
            LabelAlamat.Size = new Size(98, 31);
            LabelAlamat.TabIndex = 1;
            LabelAlamat.Text = "Alamat :";
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.BackColor = Color.Transparent;
            ButtonSubmit.FlatAppearance.BorderColor = SystemColors.Highlight;
            ButtonSubmit.FlatStyle = FlatStyle.Flat;
            ButtonSubmit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSubmit.ForeColor = SystemColors.Highlight;
            ButtonSubmit.Location = new Point(622, 715);
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
            InputNoHp.Location = new Point(533, 335);
            InputNoHp.Name = "InputNoHp";
            InputNoHp.Size = new Size(371, 27);
            InputNoHp.TabIndex = 3;
            // 
            // InputTanggal
            // 
            InputTanggal.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            InputTanggal.Location = new Point(533, 274);
            InputTanggal.Name = "InputTanggal";
            InputTanggal.Size = new Size(371, 27);
            InputTanggal.TabIndex = 2;
            // 
            // InputAlamat
            // 
            InputAlamat.Location = new Point(533, 470);
            InputAlamat.Multiline = true;
            InputAlamat.Name = "InputAlamat";
            InputAlamat.Size = new Size(371, 185);
            InputAlamat.TabIndex = 6;
            // 
            // RadioWanita
            // 
            RadioWanita.AutoSize = true;
            RadioWanita.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RadioWanita.Location = new Point(687, 396);
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
            RadioPria.Location = new Point(534, 396);
            RadioPria.Name = "RadioPria";
            RadioPria.Size = new Size(66, 32);
            RadioPria.TabIndex = 4;
            RadioPria.Text = "Pria";
            RadioPria.UseVisualStyleBackColor = true;
            // 
            // InputPoli
            // 
            InputPoli.FormattingEnabled = true;
            InputPoli.Location = new Point(533, 209);
            InputPoli.Name = "InputPoli";
            InputPoli.Size = new Size(371, 28);
            InputPoli.TabIndex = 15;
            // 
            // LabelPoli
            // 
            LabelPoli.AutoSize = true;
            LabelPoli.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPoli.Location = new Point(448, 203);
            LabelPoli.Name = "LabelPoli";
            LabelPoli.Size = new Size(62, 31);
            LabelPoli.TabIndex = 14;
            LabelPoli.Text = "Poli :";
            // 
            // DokterEditDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(InputPoli);
            Controls.Add(LabelPoli);
            Controls.Add(RadioWanita);
            Controls.Add(RadioPria);
            Controls.Add(InputTanggal);
            Controls.Add(InputNama);
            Controls.Add(InputAlamat);
            Controls.Add(InputNoHp);
            Controls.Add(ButtonSubmit);
            Controls.Add(LabelAlamat);
            Controls.Add(LabelJenisKelamin);
            Controls.Add(LabelNoHP);
            Controls.Add(LabelTanggalLahir);
            Controls.Add(LabelNama);
            Controls.Add(LabelHeaderEditDokter);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DokterEditDisplay";
            Text = "PasienEditDisplay";
            TransparencyKey = Color.Fuchsia;
            Load += DokterEditDisplay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelHeaderEditDokter;
        private Label LabelNama;
        private Label LabelTanggalLahir;
        private Label LabelNoHP;
        private Label LabelJenisKelamin;
        private Label LabelAlamat;
        private Button ButtonSubmit;
        private TextBox InputNama;
        private TextBox InputNoHp;
        private DateTimePicker InputTanggal;
        private TextBox InputAlamat;
        private RadioButton RadioWanita;
        private RadioButton RadioPria;
        private ComboBox InputPoli;
        private Label LabelPoli;
    }
}