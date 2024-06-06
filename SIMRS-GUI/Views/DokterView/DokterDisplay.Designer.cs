namespace SIMRS_GUI.Views.Dokter
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
            pasienBindingSource = new BindingSource(components);
            ButtonTambah = new Button();
            LabelDataKosong = new Label();
            LabelTitle = new Label();
            Nomor = new DataGridViewTextBoxColumn();
            nikDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            namaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Poli = new DataGridViewComboBoxColumn();
            tglLahirDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            noHpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            jnsKelaminDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            alamatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            EditDokter = new DataGridViewButtonColumn();
            HapusDokter = new DataGridViewButtonColumn();
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
            TabelDokter.AutoGenerateColumns = false;
            TabelDokter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TabelDokter.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            TabelDokter.BackgroundColor = SystemColors.Control;
            TabelDokter.BorderStyle = BorderStyle.None;
            TabelDokter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelDokter.Columns.AddRange(new DataGridViewColumn[] { Nomor, nikDataGridViewTextBoxColumn, namaDataGridViewTextBoxColumn, Poli, tglLahirDataGridViewTextBoxColumn, noHpDataGridViewTextBoxColumn, jnsKelaminDataGridViewTextBoxColumn, alamatDataGridViewTextBoxColumn, EditDokter, HapusDokter });
            TabelDokter.DataSource = pasienBindingSource;
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
            TabelDokter.RowHeadersVisible = false;
            TabelDokter.RowHeadersWidth = 51;
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
            // Nomor
            // 
            Nomor.FillWeight = 25F;
            Nomor.HeaderText = "No";
            Nomor.MinimumWidth = 6;
            Nomor.Name = "Nomor";
            Nomor.ReadOnly = true;
            // 
            // nikDataGridViewTextBoxColumn
            // 
            nikDataGridViewTextBoxColumn.DataPropertyName = "nip";
            nikDataGridViewTextBoxColumn.FillWeight = 90F;
            nikDataGridViewTextBoxColumn.HeaderText = "NIP";
            nikDataGridViewTextBoxColumn.MinimumWidth = 6;
            nikDataGridViewTextBoxColumn.Name = "nikDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            namaDataGridViewTextBoxColumn.DataPropertyName = "nama";
            namaDataGridViewTextBoxColumn.FillWeight = 160F;
            namaDataGridViewTextBoxColumn.HeaderText = "Nama Pasien";
            namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // Poli
            // 
            Poli.DataPropertyName = "poli";
            Poli.HeaderText = "Poli";
            Poli.MinimumWidth = 6;
            Poli.Name = "Poli";
            Poli.Resizable = DataGridViewTriState.True;
            Poli.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // tglLahirDataGridViewTextBoxColumn
            // 
            tglLahirDataGridViewTextBoxColumn.DataPropertyName = "tglLahir";
            tglLahirDataGridViewTextBoxColumn.FillWeight = 80F;
            tglLahirDataGridViewTextBoxColumn.HeaderText = "Tanggal Lahir";
            tglLahirDataGridViewTextBoxColumn.MinimumWidth = 6;
            tglLahirDataGridViewTextBoxColumn.Name = "tglLahirDataGridViewTextBoxColumn";
            // 
            // noHpDataGridViewTextBoxColumn
            // 
            noHpDataGridViewTextBoxColumn.DataPropertyName = "noHp";
            noHpDataGridViewTextBoxColumn.FillWeight = 75F;
            noHpDataGridViewTextBoxColumn.HeaderText = "No HP";
            noHpDataGridViewTextBoxColumn.MinimumWidth = 6;
            noHpDataGridViewTextBoxColumn.Name = "noHpDataGridViewTextBoxColumn";
            // 
            // jnsKelaminDataGridViewTextBoxColumn
            // 
            jnsKelaminDataGridViewTextBoxColumn.DataPropertyName = "jnsKelamin";
            jnsKelaminDataGridViewTextBoxColumn.FillWeight = 80F;
            jnsKelaminDataGridViewTextBoxColumn.HeaderText = "Jenis Kelamin";
            jnsKelaminDataGridViewTextBoxColumn.MinimumWidth = 6;
            jnsKelaminDataGridViewTextBoxColumn.Name = "jnsKelaminDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            alamatDataGridViewTextBoxColumn.FillWeight = 200F;
            alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // EditDokter
            // 
            EditDokter.FillWeight = 60F;
            EditDokter.HeaderText = "";
            EditDokter.MinimumWidth = 6;
            EditDokter.Name = "EditDokter";
            EditDokter.Text = "Edit";
            EditDokter.UseColumnTextForButtonValue = true;
            // 
            // HapusDokter
            // 
            HapusDokter.FillWeight = 60F;
            HapusDokter.HeaderText = "";
            HapusDokter.MinimumWidth = 6;
            HapusDokter.Name = "HapusDokter";
            HapusDokter.Text = "Hapus";
            HapusDokter.UseColumnTextForButtonValue = true;
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
        private DataGridViewTextBoxColumn Nomor;
        private DataGridViewTextBoxColumn nikDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn Poli;
        private DataGridViewTextBoxColumn tglLahirDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noHpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jnsKelaminDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn EditDokter;
        private DataGridViewButtonColumn HapusDokter;
    }
}