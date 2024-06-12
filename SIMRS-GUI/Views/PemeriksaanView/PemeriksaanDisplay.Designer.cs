namespace SIMRS_GUI.Views.PemeriksaanView
{
    partial class PemeriksaanDisplay
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            TabelPemeriksaan = new DataGridView();
            kodePemeriksaan = new DataGridViewTextBoxColumn();
            namaPasien = new DataGridViewTextBoxColumn();
            namaDokter = new DataGridViewTextBoxColumn();
            tanggal = new DataGridViewTextBoxColumn();
            tinggiBadan = new DataGridViewTextBoxColumn();
            beratBadan = new DataGridViewTextBoxColumn();
            tekananDarah = new DataGridViewTextBoxColumn();
            keluhan = new DataGridViewTextBoxColumn();
            diagnosa = new DataGridViewTextBoxColumn();
            namaObat = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Hapus = new DataGridViewButtonColumn();
            pasienBindingSource = new BindingSource(components);
            ButtonTambah = new Button();
            LabelDataKosong = new Label();
            LabelTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)TabelPemeriksaan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pasienBindingSource).BeginInit();
            SuspendLayout();
            // 
            // TabelPemeriksaan
            // 
            TabelPemeriksaan.AllowUserToAddRows = false;
            TabelPemeriksaan.AllowUserToDeleteRows = false;
            TabelPemeriksaan.AllowUserToResizeColumns = false;
            TabelPemeriksaan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 250, 255);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            TabelPemeriksaan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            TabelPemeriksaan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TabelPemeriksaan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TabelPemeriksaan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            TabelPemeriksaan.BackgroundColor = SystemColors.Control;
            TabelPemeriksaan.BorderStyle = BorderStyle.None;
            TabelPemeriksaan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelPemeriksaan.Columns.AddRange(new DataGridViewColumn[] { kodePemeriksaan, namaPasien, namaDokter, tanggal, tinggiBadan, beratBadan, tekananDarah, keluhan, diagnosa, namaObat, Edit, Hapus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            TabelPemeriksaan.DefaultCellStyle = dataGridViewCellStyle2;
            TabelPemeriksaan.EditMode = DataGridViewEditMode.EditProgrammatically;
            TabelPemeriksaan.GridColor = Color.White;
            TabelPemeriksaan.Location = new Point(28, 112);
            TabelPemeriksaan.MultiSelect = false;
            TabelPemeriksaan.Name = "TabelPemeriksaan";
            TabelPemeriksaan.RowHeadersWidth = 60;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            TabelPemeriksaan.RowsDefaultCellStyle = dataGridViewCellStyle3;
            TabelPemeriksaan.RowTemplate.Height = 29;
            TabelPemeriksaan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelPemeriksaan.ShowCellErrors = false;
            TabelPemeriksaan.ShowCellToolTips = false;
            TabelPemeriksaan.ShowEditingIcon = false;
            TabelPemeriksaan.ShowRowErrors = false;
            TabelPemeriksaan.Size = new Size(1286, 600);
            TabelPemeriksaan.TabIndex = 0;
            TabelPemeriksaan.CellContentClick += TabelPemeriksaan_CellContentClick;
            // 
            // kodePemeriksaan
            // 
            kodePemeriksaan.DataPropertyName = "kode";
            kodePemeriksaan.HeaderText = "Kode Pemeriksaan";
            kodePemeriksaan.MinimumWidth = 6;
            kodePemeriksaan.Name = "kodePemeriksaan";
            // 
            // namaPasien
            // 
            namaPasien.DataPropertyName = "namaPasien";
            namaPasien.HeaderText = "Nama Pasien";
            namaPasien.MinimumWidth = 6;
            namaPasien.Name = "namaPasien";
            // 
            // namaDokter
            // 
            namaDokter.DataPropertyName = "namaDokter";
            namaDokter.HeaderText = "Nama Dokter";
            namaDokter.MinimumWidth = 6;
            namaDokter.Name = "namaDokter";
            // 
            // tanggal
            // 
            tanggal.DataPropertyName = "tanggal";
            tanggal.HeaderText = "Tanggal";
            tanggal.MinimumWidth = 6;
            tanggal.Name = "tanggal";
            // 
            // tinggiBadan
            // 
            tinggiBadan.DataPropertyName = "tinggiBadan";
            tinggiBadan.HeaderText = "Tinggi Badan";
            tinggiBadan.MinimumWidth = 6;
            tinggiBadan.Name = "tinggiBadan";
            // 
            // beratBadan
            // 
            beratBadan.DataPropertyName = "beratBadan";
            beratBadan.HeaderText = "Berat Badan";
            beratBadan.MinimumWidth = 6;
            beratBadan.Name = "beratBadan";
            // 
            // tekananDarah
            // 
            tekananDarah.DataPropertyName = "tekananDarah";
            tekananDarah.HeaderText = "Tekanan Darah";
            tekananDarah.MinimumWidth = 6;
            tekananDarah.Name = "tekananDarah";
            // 
            // keluhan
            // 
            keluhan.DataPropertyName = "keluhan";
            keluhan.HeaderText = "Keluhan";
            keluhan.MinimumWidth = 6;
            keluhan.Name = "keluhan";
            // 
            // diagnosa
            // 
            diagnosa.DataPropertyName = "diagnosa";
            diagnosa.HeaderText = "Diagnosa";
            diagnosa.MinimumWidth = 6;
            diagnosa.Name = "diagnosa";
            // 
            // namaObat
            // 
            namaObat.DataPropertyName = "namaObat";
            namaObat.HeaderText = "Nama Obat";
            namaObat.MinimumWidth = 6;
            namaObat.Name = "namaObat";
            // 
            // Edit
            // 
            Edit.FillWeight = 60F;
            Edit.HeaderText = "";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Hapus
            // 
            Hapus.FillWeight = 60F;
            Hapus.HeaderText = "";
            Hapus.MinimumWidth = 6;
            Hapus.Name = "Hapus";
            Hapus.Text = "Hapus";
            Hapus.UseColumnTextForButtonValue = true;
            // 
            // pasienBindingSource
            // 
            pasienBindingSource.DataSource = typeof(SIMRS_API.Pasien);
            // 
            // ButtonTambah
            // 
            ButtonTambah.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonTambah.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonTambah.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonTambah.Location = new Point(1137, 31);
            ButtonTambah.Name = "ButtonTambah";
            ButtonTambah.Padding = new Padding(10, 0, 0, 0);
            ButtonTambah.Size = new Size(177, 48);
            ButtonTambah.TabIndex = 2;
            ButtonTambah.Text = "Tambah";
            ButtonTambah.UseVisualStyleBackColor = true;
            ButtonTambah.Click += ButtonTambah_Click;
            // 
            // LabelDataKosong
            // 
            LabelDataKosong.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LabelDataKosong.AutoSize = true;
            LabelDataKosong.BackColor = SystemColors.GradientInactiveCaption;
            LabelDataKosong.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            LabelDataKosong.Location = new Point(481, 150);
            LabelDataKosong.Name = "LabelDataKosong";
            LabelDataKosong.Padding = new Padding(10, 5, 10, 5);
            LabelDataKosong.Size = new Size(476, 60);
            LabelDataKosong.TabIndex = 3;
            LabelDataKosong.Text = "Data Pemeriksaan kosong!";
            LabelDataKosong.Visible = false;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(28, 46);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(323, 41);
            LabelTitle.TabIndex = 4;
            LabelTitle.Text = "Halaman Pemeriksaan";
            // 
            // PemeriksaanDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(LabelTitle);
            Controls.Add(LabelDataKosong);
            Controls.Add(ButtonTambah);
            Controls.Add(TabelPemeriksaan);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PemeriksaanDisplay";
            Text = "PasienDisplay";
            Load += PemeriksaanDisplay_Load;
            ((System.ComponentModel.ISupportInitialize)TabelPemeriksaan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pasienBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TabelPemeriksaan;
        private Button buttonHapusPasien;
        private Button buttonEditPasien;
        private Button ButtonTambah;
        private BindingSource pasienBindingSource;
        private Label LabelDataKosong;
        private Label LabelTitle;
        private DataGridViewTextBoxColumn kodePemeriksaan;
        private DataGridViewTextBoxColumn namaPasien;
        private DataGridViewTextBoxColumn namaDokter;
        private DataGridViewTextBoxColumn tanggal;
        private DataGridViewTextBoxColumn tinggiBadan;
        private DataGridViewTextBoxColumn beratBadan;
        private DataGridViewTextBoxColumn tekananDarah;
        private DataGridViewTextBoxColumn keluhan;
        private DataGridViewTextBoxColumn diagnosa;
        private DataGridViewTextBoxColumn namaObat;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Hapus;
    }
}