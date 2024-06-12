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
            label1 = new Label();
            labelNama = new Label();
            ButtonSubmit = new Button();
            InputNama = new TextBox();
            InputRuang = new TextBox();
            label2 = new Label();
            InputBiaya = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(557, 35);
            label1.Name = "label1";
            label1.Size = new Size(278, 54);
            label1.TabIndex = 0;
            label1.Text = "Edit Data Poli";
            // 
            // labelNama
            // 
            labelNama.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNama.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelNama.Location = new Point(353, 139);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(157, 31);
            labelNama.TabIndex = 1;
            labelNama.Text = "Nama Poli :";
            labelNama.TextAlign = ContentAlignment.TopRight;
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
            // InputRuang
            // 
            InputRuang.Location = new Point(533, 210);
            InputRuang.Name = "InputRuang";
            InputRuang.Size = new Size(371, 27);
            InputRuang.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(353, 204);
            label2.Name = "label2";
            label2.Size = new Size(157, 31);
            label2.TabIndex = 9;
            label2.Text = "Ruang :";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // InputBiaya
            // 
            InputBiaya.Location = new Point(533, 273);
            InputBiaya.Name = "InputBiaya";
            InputBiaya.Size = new Size(371, 27);
            InputBiaya.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(353, 267);
            label3.Name = "label3";
            label3.Size = new Size(157, 31);
            label3.TabIndex = 11;
            label3.Text = "Biaya :";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // PoliEditDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(InputBiaya);
            Controls.Add(label3);
            Controls.Add(InputRuang);
            Controls.Add(label2);
            Controls.Add(InputNama);
            Controls.Add(ButtonSubmit);
            Controls.Add(labelNama);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PoliEditDisplay";
            Text = "PasienEditDisplay";
            TransparencyKey = Color.Fuchsia;
            Load += PoliditDisplay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelNama;
        private Button ButtonSubmit;
        private TextBox InputNama;
        private TextBox InputRuang;
        private Label label2;
        private TextBox InputBiaya;
        private Label label3;
    }
}