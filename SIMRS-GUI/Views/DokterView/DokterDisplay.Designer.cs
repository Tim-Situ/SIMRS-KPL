namespace SIMRS_GUI.Views.DokterView
{
    partial class DokterDisplay
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            TabelDokter = new DataGridView();
            nip = new DataGridViewTextBoxColumn();
            nama = new DataGridViewTextBoxColumn();
            namaPoli = new DataGridViewTextBoxColumn();
            tglLahir = new DataGridViewTextBoxColumn();
            noHP = new DataGridViewTextBoxColumn();
            jenisKelamin = new DataGridViewTextBoxColumn();
            alamat = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Hapus = new DataGridViewButtonColumn();
            pasienBindingSource = new BindingSource(components);
            ButtonTambah = new Button();
            LabelDataKosong = new Label();
            LabelTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)TabelDokter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pasienBindingSource).BeginInit();
            SuspendLayout();
            // 
            // TabelDokter
            // 
            TabelDokter.AllowUserToAddRows = false;
            TabelDokter.AllowUserToDeleteRows = false;
            TabelDokter.AllowUserToResizeColumns = false;
            TabelDokter.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(242, 250, 255);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            TabelDokter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            TabelDokter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TabelDokter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TabelDokter.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            TabelDokter.BackgroundColor = SystemColors.Control;
            TabelDokter.BorderStyle = BorderStyle.None;
            TabelDokter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelDokter.Columns.AddRange(new DataGridViewColumn[] { nip, nama, namaPoli, tglLahir, noHP, jenisKelamin, alamat, Edit, Hapus });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            TabelDokter.DefaultCellStyle = dataGridViewCellStyle5;
            TabelDokter.EditMode = DataGridViewEditMode.EditProgrammatically;
            TabelDokter.GridColor = Color.White;
            TabelDokter.Location = new Point(28, 112);
            TabelDokter.MultiSelect = false;
            TabelDokter.Name = "TabelDokter";
            TabelDokter.RowHeadersWidth = 60;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            TabelDokter.RowsDefaultCellStyle = dataGridViewCellStyle6;
            TabelDokter.RowTemplate.Height = 29;
            TabelDokter.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelDokter.ShowCellErrors = false;
            TabelDokter.ShowCellToolTips = false;
            TabelDokter.ShowEditingIcon = false;
            TabelDokter.ShowRowErrors = false;
            TabelDokter.Size = new Size(1286, 600);
            TabelDokter.TabIndex = 0;
            TabelDokter.CellContentClick += TabelDokter_CellContentClick;
            TabelDokter.DataBindingComplete += TabelDokter_DataBindingComplete;
            // 
            // nip
            // 
            nip.DataPropertyName = "nip";
            nip.HeaderText = "NIP";
            nip.MinimumWidth = 6;
            nip.Name = "nip";
            // 
            // nama
            // 
            nama.DataPropertyName = "nama";
            nama.HeaderText = "Nama Dokter";
            nama.MinimumWidth = 6;
            nama.Name = "nama";
            // 
            // namaPoli
            // 
            namaPoli.DataPropertyName = "namaPoli";
            namaPoli.HeaderText = "Nama Poli";
            namaPoli.MinimumWidth = 6;
            namaPoli.Name = "namaPoli";
            // 
            // tglLahir
            // 
            tglLahir.DataPropertyName = "tglLahir";
            tglLahir.HeaderText = "Tanggal Lahir";
            tglLahir.MinimumWidth = 6;
            tglLahir.Name = "tglLahir";
            // 
            // noHP
            // 
            noHP.DataPropertyName = "noHP";
            noHP.HeaderText = "No HP";
            noHP.MinimumWidth = 6;
            noHP.Name = "noHP";
            // 
            // jenisKelamin
            // 
            jenisKelamin.DataPropertyName = "jenisKelamin";
            jenisKelamin.HeaderText = "Jenis Kelamin";
            jenisKelamin.MinimumWidth = 6;
            jenisKelamin.Name = "jenisKelamin";
            // 
            // alamat
            // 
            alamat.DataPropertyName = "alamat";
            alamat.HeaderText = "Alamat";
            alamat.MinimumWidth = 6;
            alamat.Name = "alamat";
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
            LabelDataKosong.Location = new Point(478, 136);
            LabelDataKosong.Name = "LabelDataKosong";
            LabelDataKosong.Padding = new Padding(10, 5, 10, 5);
            LabelDataKosong.Size = new Size(382, 60);
            LabelDataKosong.TabIndex = 3;
            LabelDataKosong.Text = "Data Dokter kosong!";
            LabelDataKosong.Visible = false;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(28, 46);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(243, 41);
            LabelTitle.TabIndex = 4;
            LabelTitle.Text = "Halaman Dokter";
            // 
            // DokterDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(LabelTitle);
            Controls.Add(LabelDataKosong);
            Controls.Add(ButtonTambah);
            Controls.Add(TabelDokter);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DokterDisplay";
            Text = "PasienDisplay";
            Load += DokterDisplay_Load;
            ((System.ComponentModel.ISupportInitialize)TabelDokter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pasienBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TabelDokter;
        private Button buttonHapusPasien;
        private Button buttonEditPasien;
        private Button ButtonTambah;
        private BindingSource pasienBindingSource;
        private Label LabelDataKosong;
        private Label LabelTitle;
        private DataGridViewTextBoxColumn nikDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn Poli;
        private DataGridViewTextBoxColumn nip;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn namaPoli;
        private DataGridViewTextBoxColumn tglLahir;
        private DataGridViewTextBoxColumn noHP;
        private DataGridViewTextBoxColumn jenisKelamin;
        private DataGridViewTextBoxColumn alamat;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Hapus;
    }
}