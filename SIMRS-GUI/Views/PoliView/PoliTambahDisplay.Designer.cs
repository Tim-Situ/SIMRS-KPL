namespace SIMRS_GUI.Views.PoliView
{
    partial class PoliTambahDisplay
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
            LabelHeaderTambahPoli = new Label();
            InputRuang = new TextBox();
            InputNama = new TextBox();
            InputBiaya = new TextBox();
            ButtonSubmit = new Button();
            LabelBiaya = new Label();
            LabelRuang = new Label();
            LabelNama = new Label();
            SuspendLayout();
            // 
            // LabelHeaderTambahPoli
            // 
            LabelHeaderTambahPoli.AutoSize = true;
            LabelHeaderTambahPoli.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHeaderTambahPoli.Location = new Point(513, 55);
            LabelHeaderTambahPoli.Name = "LabelHeaderTambahPoli";
            LabelHeaderTambahPoli.Size = new Size(355, 54);
            LabelHeaderTambahPoli.TabIndex = 6;
            LabelHeaderTambahPoli.Text = "Tambah Data Poli";
            // 
            // InputRuang
            // 
            InputRuang.Location = new Point(511, 199);
            InputRuang.Name = "InputRuang";
            InputRuang.Size = new Size(371, 27);
            InputRuang.TabIndex = 8;
            // 
            // InputNama
            // 
            InputNama.Location = new Point(511, 133);
            InputNama.Name = "InputNama";
            InputNama.Size = new Size(371, 27);
            InputNama.TabIndex = 9;
            // 
            // InputBiaya
            // 
            InputBiaya.Location = new Point(511, 260);
            InputBiaya.Name = "InputBiaya";
            InputBiaya.Size = new Size(371, 27);
            InputBiaya.TabIndex = 13;
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.BackColor = Color.Transparent;
            ButtonSubmit.FlatAppearance.BorderColor = SystemColors.Highlight;
            ButtonSubmit.FlatStyle = FlatStyle.Flat;
            ButtonSubmit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSubmit.ForeColor = SystemColors.Highlight;
            ButtonSubmit.Location = new Point(606, 319);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(184, 45);
            ButtonSubmit.TabIndex = 14;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = false;
            // 
            // LabelBiaya
            // 
            LabelBiaya.AutoSize = true;
            LabelBiaya.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelBiaya.Location = new Point(408, 254);
            LabelBiaya.Name = "LabelBiaya";
            LabelBiaya.Size = new Size(79, 31);
            LabelBiaya.TabIndex = 10;
            LabelBiaya.Text = "Biaya :";
            // 
            // LabelRuang
            // 
            LabelRuang.AutoSize = true;
            LabelRuang.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelRuang.Location = new Point(396, 193);
            LabelRuang.Name = "LabelRuang";
            LabelRuang.Size = new Size(91, 31);
            LabelRuang.TabIndex = 11;
            LabelRuang.Text = "Ruang :";
            // 
            // LabelNama
            // 
            LabelNama.AutoSize = true;
            LabelNama.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNama.Location = new Point(358, 133);
            LabelNama.Name = "LabelNama";
            LabelNama.Size = new Size(129, 31);
            LabelNama.TabIndex = 12;
            LabelNama.Text = "Nama Poli :";
            // 
            // PoliTambahDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(InputRuang);
            Controls.Add(InputNama);
            Controls.Add(InputBiaya);
            Controls.Add(ButtonSubmit);
            Controls.Add(LabelBiaya);
            Controls.Add(LabelRuang);
            Controls.Add(LabelNama);
            Controls.Add(LabelHeaderTambahPoli);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PoliTambahDisplay";
            Text = "PasienTambahDisplay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LabelHeaderTambahPoli;
        private TextBox InputRuang;
        private TextBox InputNama;
        private TextBox InputBiaya;
        private Button ButtonSubmit;
        private Label LabelBiaya;
        private Label LabelRuang;
        private Label LabelNama;
    }
}