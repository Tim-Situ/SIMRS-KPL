namespace SIMRS_GUI
{
    partial class PasienDisplay
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
            TabelPasien = new DataGridView();
            NoPasien = new DataGridViewTextBoxColumn();
            NIKPasien = new DataGridViewTextBoxColumn();
            NamaPasien = new DataGridViewTextBoxColumn();
            TanggalLahirPasien = new DataGridViewTextBoxColumn();
            NoHpPasien = new DataGridViewTextBoxColumn();
            JenisKelaminPasien = new DataGridViewTextBoxColumn();
            AlamatPasien = new DataGridViewTextBoxColumn();
            buttonHapusPasien = new Button();
            buttonEditPasien = new Button();
            buttonTambahPasien = new Button();
            ((System.ComponentModel.ISupportInitialize)TabelPasien).BeginInit();
            SuspendLayout();
            // 
            // TabelPasien
            // 
            TabelPasien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelPasien.Columns.AddRange(new DataGridViewColumn[] { NoPasien, NIKPasien, NamaPasien, TanggalLahirPasien, NoHpPasien, JenisKelaminPasien, AlamatPasien });
            TabelPasien.Location = new Point(12, 83);
            TabelPasien.Name = "TabelPasien";
            TabelPasien.RowHeadersWidth = 51;
            TabelPasien.RowTemplate.Height = 29;
            TabelPasien.Size = new Size(897, 389);
            TabelPasien.TabIndex = 0;
            // 
            // NoPasien
            // 
            NoPasien.HeaderText = "No";
            NoPasien.MinimumWidth = 6;
            NoPasien.Name = "NoPasien";
            NoPasien.Width = 125;
            // 
            // NIKPasien
            // 
            NIKPasien.HeaderText = "NIK";
            NIKPasien.MinimumWidth = 6;
            NIKPasien.Name = "NIKPasien";
            NIKPasien.Width = 125;
            // 
            // NamaPasien
            // 
            NamaPasien.HeaderText = "Nama";
            NamaPasien.MinimumWidth = 6;
            NamaPasien.Name = "NamaPasien";
            NamaPasien.Width = 125;
            // 
            // TanggalLahirPasien
            // 
            TanggalLahirPasien.HeaderText = "Tanggal Lahir";
            TanggalLahirPasien.MinimumWidth = 6;
            TanggalLahirPasien.Name = "TanggalLahirPasien";
            TanggalLahirPasien.Width = 125;
            // 
            // NoHpPasien
            // 
            NoHpPasien.HeaderText = "No Hp";
            NoHpPasien.MinimumWidth = 6;
            NoHpPasien.Name = "NoHpPasien";
            NoHpPasien.Width = 125;
            // 
            // JenisKelaminPasien
            // 
            JenisKelaminPasien.HeaderText = "Jenis Kelamin";
            JenisKelaminPasien.MinimumWidth = 6;
            JenisKelaminPasien.Name = "JenisKelaminPasien";
            JenisKelaminPasien.Width = 125;
            // 
            // AlamatPasien
            // 
            AlamatPasien.HeaderText = "Alamat";
            AlamatPasien.MinimumWidth = 6;
            AlamatPasien.Name = "AlamatPasien";
            AlamatPasien.Width = 125;
            // 
            // buttonHapusPasien
            // 
            buttonHapusPasien.Location = new Point(615, 31);
            buttonHapusPasien.Name = "buttonHapusPasien";
            buttonHapusPasien.Size = new Size(94, 29);
            buttonHapusPasien.TabIndex = 1;
            buttonHapusPasien.Text = "Hapus";
            buttonHapusPasien.UseVisualStyleBackColor = true;
            // 
            // buttonEditPasien
            // 
            buttonEditPasien.Location = new Point(715, 31);
            buttonEditPasien.Name = "buttonEditPasien";
            buttonEditPasien.Size = new Size(94, 29);
            buttonEditPasien.TabIndex = 1;
            buttonEditPasien.Text = "Edit";
            buttonEditPasien.UseVisualStyleBackColor = true;
            // 
            // buttonTambahPasien
            // 
            buttonTambahPasien.Location = new Point(815, 31);
            buttonTambahPasien.Name = "buttonTambahPasien";
            buttonTambahPasien.Size = new Size(94, 29);
            buttonTambahPasien.TabIndex = 1;
            buttonTambahPasien.Text = "Tambah";
            buttonTambahPasien.UseVisualStyleBackColor = true;
            // 
            // PasienDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 484);
            Controls.Add(buttonTambahPasien);
            Controls.Add(buttonEditPasien);
            Controls.Add(buttonHapusPasien);
            Controls.Add(TabelPasien);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PasienDisplay";
            Text = "PasienDisplay";
            ((System.ComponentModel.ISupportInitialize)TabelPasien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TabelPasien;
        private Button buttonHapusPasien;
        private Button buttonEditPasien;
        private Button buttonTambahPasien;
        private DataGridViewTextBoxColumn NoPasien;
        private DataGridViewTextBoxColumn NIKPasien;
        private DataGridViewTextBoxColumn NamaPasien;
        private DataGridViewTextBoxColumn TanggalLahirPasien;
        private DataGridViewTextBoxColumn NoHpPasien;
        private DataGridViewTextBoxColumn JenisKelaminPasien;
        private DataGridViewTextBoxColumn AlamatPasien;
    }
}