namespace SIMRS_GUI.Views.ObatView
{
    partial class ObatTambahDisplay
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
            LabelHeaderObat = new Label();
            RadioOles = new RadioButton();
            RadioSirup = new RadioButton();
            RadioTablet = new RadioButton();
            RadioPil = new RadioButton();
            LabelJenis = new Label();
            InputHarga = new TextBox();
            LabelHarga = new Label();
            InputObat = new TextBox();
            LabelNama = new Label();
            ButtonSubmit = new Button();
            SuspendLayout();
            // 
            // LabelHeaderObat
            // 
            LabelHeaderObat.AutoSize = true;
            LabelHeaderObat.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHeaderObat.Location = new Point(513, 55);
            LabelHeaderObat.Name = "LabelHeaderObat";
            LabelHeaderObat.Size = new Size(378, 54);
            LabelHeaderObat.TabIndex = 6;
            LabelHeaderObat.Text = "Tambah Data Obat";
            // 
            // RadioOles
            // 
            RadioOles.AutoSize = true;
            RadioOles.Location = new Point(612, 319);
            RadioOles.Name = "RadioOles";
            RadioOles.Size = new Size(59, 24);
            RadioOles.TabIndex = 20;
            RadioOles.TabStop = true;
            RadioOles.Text = "Oles";
            RadioOles.UseVisualStyleBackColor = true;
            // 
            // RadioSirup
            // 
            RadioSirup.AutoSize = true;
            RadioSirup.Location = new Point(612, 276);
            RadioSirup.Name = "RadioSirup";
            RadioSirup.Size = new Size(64, 24);
            RadioSirup.TabIndex = 21;
            RadioSirup.TabStop = true;
            RadioSirup.Text = "Sirup";
            RadioSirup.UseVisualStyleBackColor = true;
            // 
            // RadioTablet
            // 
            RadioTablet.AutoSize = true;
            RadioTablet.Location = new Point(524, 319);
            RadioTablet.Name = "RadioTablet";
            RadioTablet.Size = new Size(70, 24);
            RadioTablet.TabIndex = 22;
            RadioTablet.TabStop = true;
            RadioTablet.Text = "Tablet";
            RadioTablet.UseVisualStyleBackColor = true;
            // 
            // RadioPil
            // 
            RadioPil.AutoSize = true;
            RadioPil.Location = new Point(524, 276);
            RadioPil.Name = "RadioPil";
            RadioPil.Size = new Size(46, 24);
            RadioPil.TabIndex = 23;
            RadioPil.TabStop = true;
            RadioPil.Text = "Pil";
            RadioPil.UseVisualStyleBackColor = true;
            // 
            // LabelJenis
            // 
            LabelJenis.AutoSize = true;
            LabelJenis.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelJenis.Location = new Point(368, 269);
            LabelJenis.Name = "LabelJenis";
            LabelJenis.Size = new Size(131, 31);
            LabelJenis.TabIndex = 19;
            LabelJenis.Text = "Jenis Obat :";
            // 
            // InputHarga
            // 
            InputHarga.Location = new Point(524, 214);
            InputHarga.Name = "InputHarga";
            InputHarga.Size = new Size(370, 27);
            InputHarga.TabIndex = 18;
            // 
            // LabelHarga
            // 
            LabelHarga.AutoSize = true;
            LabelHarga.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelHarga.Location = new Point(412, 210);
            LabelHarga.Name = "LabelHarga";
            LabelHarga.Size = new Size(87, 31);
            LabelHarga.TabIndex = 17;
            LabelHarga.Text = "Harga :";
            // 
            // InputObat
            // 
            InputObat.Location = new Point(524, 146);
            InputObat.Name = "InputObat";
            InputObat.Size = new Size(370, 27);
            InputObat.TabIndex = 16;
            // 
            // LabelNama
            // 
            LabelNama.AutoSize = true;
            LabelNama.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNama.Location = new Point(356, 142);
            LabelNama.Name = "LabelNama";
            LabelNama.Size = new Size(143, 31);
            LabelNama.TabIndex = 15;
            LabelNama.Text = "Nama Obat :";
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.BackColor = Color.Transparent;
            ButtonSubmit.FlatAppearance.BorderColor = SystemColors.Highlight;
            ButtonSubmit.FlatStyle = FlatStyle.Flat;
            ButtonSubmit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSubmit.ForeColor = SystemColors.Highlight;
            ButtonSubmit.Location = new Point(612, 373);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(184, 45);
            ButtonSubmit.TabIndex = 14;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = false;
            // 
            // ObatTambahDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(RadioOles);
            Controls.Add(RadioSirup);
            Controls.Add(RadioTablet);
            Controls.Add(RadioPil);
            Controls.Add(LabelJenis);
            Controls.Add(InputHarga);
            Controls.Add(LabelHarga);
            Controls.Add(InputObat);
            Controls.Add(LabelNama);
            Controls.Add(ButtonSubmit);
            Controls.Add(LabelHeaderObat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ObatTambahDisplay";
            Text = "PasienTambahDisplay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LabelHeaderObat;
        private RadioButton RadioOles;
        private RadioButton RadioSirup;
        private RadioButton RadioTablet;
        private RadioButton RadioPil;
        private Label LabelJenis;
        private TextBox InputHarga;
        private Label LabelHarga;
        private TextBox InputObat;
        private Label LabelNama;
        private Button ButtonSubmit;
    }
}