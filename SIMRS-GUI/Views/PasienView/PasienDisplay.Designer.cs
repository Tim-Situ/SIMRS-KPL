namespace SIMRS_GUI.Views.PasienView
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasienDisplay));
            TabelPasien = new DataGridView();
            pasienBindingSource = new BindingSource(components);
            ButtonTambah = new Button();
            LabelDataKosong = new Label();
            LabelTitle = new Label();
            nik = new DataGridViewTextBoxColumn();
            nama = new DataGridViewTextBoxColumn();
            tanggalLahir = new DataGridViewTextBoxColumn();
            noHP = new DataGridViewTextBoxColumn();
            jenisKelamin = new DataGridViewTextBoxColumn();
            alamat = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Hapus = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)TabelPasien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pasienBindingSource).BeginInit();
            SuspendLayout();
            // 
            // TabelPasien
            // 
            TabelPasien.AllowUserToAddRows = false;
            TabelPasien.AllowUserToDeleteRows = false;
            TabelPasien.AllowUserToResizeColumns = false;
            TabelPasien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 250, 255);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            TabelPasien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            TabelPasien.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TabelPasien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TabelPasien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            TabelPasien.BackgroundColor = SystemColors.Control;
            TabelPasien.BorderStyle = BorderStyle.None;
            TabelPasien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelPasien.Columns.AddRange(new DataGridViewColumn[] { nik, nama, tanggalLahir, noHP, jenisKelamin, alamat, Edit, Hapus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            TabelPasien.DefaultCellStyle = dataGridViewCellStyle2;
            TabelPasien.EditMode = DataGridViewEditMode.EditProgrammatically;
            TabelPasien.GridColor = Color.White;
            TabelPasien.Location = new Point(28, 112);
            TabelPasien.MultiSelect = false;
            TabelPasien.Name = "TabelPasien";
            TabelPasien.RowHeadersWidth = 60;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            TabelPasien.RowsDefaultCellStyle = dataGridViewCellStyle3;
            TabelPasien.RowTemplate.Height = 29;
            TabelPasien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelPasien.ShowCellErrors = false;
            TabelPasien.ShowCellToolTips = false;
            TabelPasien.ShowEditingIcon = false;
            TabelPasien.ShowRowErrors = false;
            TabelPasien.Size = new Size(1286, 600);
            TabelPasien.TabIndex = 0;
            TabelPasien.CellContentClick += TabelPasien_CellContentClick;
            TabelPasien.DataBindingComplete += TabelPasien_DataBindingComplete;
            // 
            // pasienBindingSource
            // 
            pasienBindingSource.DataSource = typeof(SIMRS_API.Pasien);
            // 
            // ButtonTambah
            // 
            ButtonTambah.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonTambah.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonTambah.Image = (Image)resources.GetObject("ButtonTambah.Image");
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
            LabelDataKosong.Size = new Size(377, 60);
            LabelDataKosong.TabIndex = 3;
            LabelDataKosong.Text = "Data pasien kosong!";
            LabelDataKosong.Visible = false;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(28, 46);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(237, 41);
            LabelTitle.TabIndex = 4;
            LabelTitle.Text = "Halaman Pasien";
            // 
            // nik
            // 
            nik.DataPropertyName = "nik";
            nik.HeaderText = "NIK";
            nik.MinimumWidth = 6;
            nik.Name = "nik";
            // 
            // nama
            // 
            nama.DataPropertyName = "nama";
            nama.HeaderText = "Nama Pasien";
            nama.MinimumWidth = 6;
            nama.Name = "nama";
            // 
            // tanggalLahir
            // 
            tanggalLahir.DataPropertyName = "tanggalLahir";
            tanggalLahir.HeaderText = "Tanggal Lahir";
            tanggalLahir.MinimumWidth = 6;
            tanggalLahir.Name = "tanggalLahir";
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
            // PasienDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(LabelTitle);
            Controls.Add(LabelDataKosong);
            Controls.Add(ButtonTambah);
            Controls.Add(TabelPasien);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PasienDisplay";
            Text = "PasienDisplay";
            Load += PasienDisplay_Load;
            ((System.ComponentModel.ISupportInitialize)TabelPasien).EndInit();
            ((System.ComponentModel.ISupportInitialize)pasienBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TabelPasien;
        private Button buttonHapusPasien;
        private Button buttonEditPasien;
        private Button ButtonTambah;
        private BindingSource pasienBindingSource;
        private Label LabelDataKosong;
        private Label LabelTitle;
        private DataGridViewTextBoxColumn nik;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn tanggalLahir;
        private DataGridViewTextBoxColumn noHP;
        private DataGridViewTextBoxColumn jenisKelamin;
        private DataGridViewTextBoxColumn alamat;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Hapus;
    }
}