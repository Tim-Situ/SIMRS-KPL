namespace SIMRS_GUI.Views.PoliView
{
    partial class PoliEditDisplay
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
            this.LabelHeaderEditPoli = new Label();
            this.LabelNama = new Label();
            this.LabelRuang = new Label();
            this.LabelBiaya = new Label();
            ButtonSubmit = new Button();
            InputNama = new TextBox();
            InputBiaya = new TextBox();
            InputRuang = new TextBox();
            SuspendLayout();
            // 
            // LabelHeaderEditPoli
            // 
            this.LabelHeaderEditPoli.AutoSize = true;
            this.LabelHeaderEditPoli.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            this.LabelHeaderEditPoli.Location = new Point(571, 35);
            this.LabelHeaderEditPoli.Name = "LabelHeaderEditPoli";
            this.LabelHeaderEditPoli.Size = new Size(278, 54);
            this.LabelHeaderEditPoli.TabIndex = 0;
            this.LabelHeaderEditPoli.Text = "Edit Data Poli";
            // 
            // LabelNama
            // 
            this.LabelNama.AutoSize = true;
            this.LabelNama.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            this.LabelNama.Location = new Point(380, 145);
            this.LabelNama.Name = "LabelNama";
            this.LabelNama.Size = new Size(129, 31);
            this.LabelNama.TabIndex = 1;
            this.LabelNama.Text = "Nama Poli :";
            // 
            // LabelRuang
            // 
            this.LabelRuang.AutoSize = true;
            this.LabelRuang.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            this.LabelRuang.Location = new Point(418, 205);
            this.LabelRuang.Name = "LabelRuang";
            this.LabelRuang.Size = new Size(91, 31);
            this.LabelRuang.TabIndex = 1;
            this.LabelRuang.Text = "Ruang :";
            // 
            // LabelBiaya
            // 
            this.LabelBiaya.AutoSize = true;
            this.LabelBiaya.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            this.LabelBiaya.Location = new Point(430, 266);
            this.LabelBiaya.Name = "LabelBiaya";
            this.LabelBiaya.Size = new Size(79, 31);
            this.LabelBiaya.TabIndex = 1;
            this.LabelBiaya.Text = "Biaya :";
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.BackColor = Color.Transparent;
            ButtonSubmit.FlatAppearance.BorderColor = SystemColors.Highlight;
            ButtonSubmit.FlatStyle = FlatStyle.Flat;
            ButtonSubmit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSubmit.ForeColor = SystemColors.Highlight;
            ButtonSubmit.Location = new Point(628, 331);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(184, 45);
            ButtonSubmit.TabIndex = 7;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = false;
            // 
            // InputNama
            // 
            InputNama.Location = new Point(533, 145);
            InputNama.Name = "InputNama";
            InputNama.Size = new Size(371, 27);
            InputNama.TabIndex = 1;
            InputNama.TextChanged += InputNama_TextChanged;
            // 
            // InputBiaya
            // 
            InputBiaya.Location = new Point(533, 272);
            InputBiaya.Name = "InputBiaya";
            InputBiaya.Size = new Size(371, 27);
            InputBiaya.TabIndex = 3;
            // 
            // InputRuang
            // 
            InputRuang.Location = new Point(533, 211);
            InputRuang.Name = "InputRuang";
            InputRuang.Size = new Size(371, 27);
            InputRuang.TabIndex = 1;
            InputRuang.TextChanged += InputNama_TextChanged;
            // 
            // PoliEditDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(InputRuang);
            Controls.Add(InputNama);
            Controls.Add(InputBiaya);
            Controls.Add(ButtonSubmit);
            Controls.Add(this.LabelBiaya);
            Controls.Add(this.LabelRuang);
            Controls.Add(this.LabelNama);
            Controls.Add(this.LabelHeaderEditPoli);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PoliEditDisplay";
            Text = "PasienEditDisplay";
            TransparencyKey = Color.Fuchsia;
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
        private TextBox InputBiaya;
        private TextBox InputRuang;
        private TextBox InputAlamat;
        private RadioButton RadioWanita;
        private RadioButton RadioPria;
    }
}