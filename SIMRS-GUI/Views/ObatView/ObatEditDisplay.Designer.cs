namespace SIMRS_GUI.Views.ObatView
{
    partial class ObatEditDisplay
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
            ButtonSubmit = new Button();
            LabelNama = new Label();
            InputObat = new TextBox();
            LabelHarga = new Label();
            InputHarga = new TextBox();
            LabelJenis = new Label();
            RadioPil = new RadioButton();
            RadioTablet = new RadioButton();
            RadioSirup = new RadioButton();
            RadioOles = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(557, 35);
            label1.Name = "label1";
            label1.Size = new Size(301, 54);
            label1.TabIndex = 0;
            label1.Text = "Edit Data Obat";
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.BackColor = Color.Transparent;
            ButtonSubmit.FlatAppearance.BorderColor = SystemColors.Highlight;
            ButtonSubmit.FlatStyle = FlatStyle.Flat;
            ButtonSubmit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSubmit.ForeColor = SystemColors.Highlight;
            ButtonSubmit.Location = new Point(622, 372);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(184, 45);
            ButtonSubmit.TabIndex = 7;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = false;
            // 
            // LabelNama
            // 
            LabelNama.AutoSize = true;
            LabelNama.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNama.Location = new Point(366, 141);
            LabelNama.Name = "LabelNama";
            LabelNama.Size = new Size(143, 31);
            LabelNama.TabIndex = 8;
            LabelNama.Text = "Nama Obat :";
            // 
            // InputObat
            // 
            InputObat.Location = new Point(534, 145);
            InputObat.Name = "InputObat";
            InputObat.Size = new Size(370, 27);
            InputObat.TabIndex = 9;
            // 
            // LabelHarga
            // 
            LabelHarga.AutoSize = true;
            LabelHarga.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelHarga.Location = new Point(422, 209);
            LabelHarga.Name = "LabelHarga";
            LabelHarga.Size = new Size(87, 31);
            LabelHarga.TabIndex = 10;
            LabelHarga.Text = "Harga :";
            // 
            // InputHarga
            // 
            InputHarga.Location = new Point(534, 213);
            InputHarga.Name = "InputHarga";
            InputHarga.Size = new Size(370, 27);
            InputHarga.TabIndex = 11;
            // 
            // LabelJenis
            // 
            LabelJenis.AutoSize = true;
            LabelJenis.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelJenis.Location = new Point(378, 268);
            LabelJenis.Name = "LabelJenis";
            LabelJenis.Size = new Size(131, 31);
            LabelJenis.TabIndex = 12;
            LabelJenis.Text = "Jenis Obat :";
            // 
            // RadioPil
            // 
            RadioPil.AutoSize = true;
            RadioPil.Location = new Point(534, 275);
            RadioPil.Name = "RadioPil";
            RadioPil.Size = new Size(46, 24);
            RadioPil.TabIndex = 13;
            RadioPil.TabStop = true;
            RadioPil.Text = "Pil";
            RadioPil.UseVisualStyleBackColor = true;
            // 
            // RadioTablet
            // 
            RadioTablet.AutoSize = true;
            RadioTablet.Location = new Point(534, 318);
            RadioTablet.Name = "RadioTablet";
            RadioTablet.Size = new Size(70, 24);
            RadioTablet.TabIndex = 13;
            RadioTablet.TabStop = true;
            RadioTablet.Text = "Tablet";
            RadioTablet.UseVisualStyleBackColor = true;
            // 
            // RadioSirup
            // 
            RadioSirup.AutoSize = true;
            RadioSirup.Location = new Point(622, 275);
            RadioSirup.Name = "RadioSirup";
            RadioSirup.Size = new Size(64, 24);
            RadioSirup.TabIndex = 13;
            RadioSirup.TabStop = true;
            RadioSirup.Text = "Sirup";
            RadioSirup.UseVisualStyleBackColor = true;
            // 
            // RadioOles
            // 
            RadioOles.AutoSize = true;
            RadioOles.Location = new Point(622, 318);
            RadioOles.Name = "RadioOles";
            RadioOles.Size = new Size(59, 24);
            RadioOles.TabIndex = 13;
            RadioOles.TabStop = true;
            RadioOles.Text = "Oles";
            RadioOles.UseVisualStyleBackColor = true;
            // 
            // ObatEditDisplay
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
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ObatEditDisplay";
            Text = "PasienEditDisplay";
            TransparencyKey = Color.Fuchsia;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelNama;
        private Button ButtonSubmit;
        private TextBox InputNama;
        private Label LabelNama;
        private TextBox InputObat;
        private Label LabelHarga;
        private TextBox InputHarga;
        private Label LabelJenis;
        private RadioButton RadioPil;
        private RadioButton RadioTablet;
        private RadioButton RadioSirup;
        private RadioButton RadioOles;
    }
}