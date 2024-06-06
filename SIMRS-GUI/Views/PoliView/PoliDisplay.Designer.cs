namespace SIMRS_GUI.Views.PoliView
{
    partial class PoliDisplay
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
            TabelPoli = new DataGridView();
            pasienBindingSource = new BindingSource(components);
            ButtonTambah = new Button();
            LabelDataKosong = new Label();
            LabelTitle = new Label();
            Nomor = new DataGridViewTextBoxColumn();
            nikDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            namaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            alamatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            EditPoli = new DataGridViewButtonColumn();
            HapusPoli = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)TabelPoli).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pasienBindingSource).BeginInit();
            SuspendLayout();
            // 
            // TabelPoli
            // 
            TabelPoli.AllowUserToAddRows = false;
            TabelPoli.AllowUserToDeleteRows = false;
            TabelPoli.AllowUserToResizeColumns = false;
            TabelPoli.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 250, 255);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            TabelPoli.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            TabelPoli.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TabelPoli.AutoGenerateColumns = false;
            TabelPoli.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TabelPoli.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            TabelPoli.BackgroundColor = SystemColors.Control;
            TabelPoli.BorderStyle = BorderStyle.None;
            TabelPoli.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelPoli.Columns.AddRange(new DataGridViewColumn[] { Nomor, nikDataGridViewTextBoxColumn, namaDataGridViewTextBoxColumn, alamatDataGridViewTextBoxColumn, EditPoli, HapusPoli });
            TabelPoli.DataSource = pasienBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            TabelPoli.DefaultCellStyle = dataGridViewCellStyle2;
            TabelPoli.EditMode = DataGridViewEditMode.EditProgrammatically;
            TabelPoli.GridColor = Color.White;
            TabelPoli.Location = new Point(28, 112);
            TabelPoli.MultiSelect = false;
            TabelPoli.Name = "TabelPoli";
            TabelPoli.RowHeadersVisible = false;
            TabelPoli.RowHeadersWidth = 51;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            TabelPoli.RowsDefaultCellStyle = dataGridViewCellStyle3;
            TabelPoli.RowTemplate.Height = 29;
            TabelPoli.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelPoli.ShowCellErrors = false;
            TabelPoli.ShowCellToolTips = false;
            TabelPoli.ShowEditingIcon = false;
            TabelPoli.ShowRowErrors = false;
            TabelPoli.Size = new Size(882, 600);
            TabelPoli.TabIndex = 0;
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
            ButtonTambah.Location = new Point(733, 39);
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
            LabelDataKosong.Location = new Point(302, 138);
            LabelDataKosong.Name = "LabelDataKosong";
            LabelDataKosong.Padding = new Padding(10, 5, 10, 5);
            LabelDataKosong.Size = new Size(331, 60);
            LabelDataKosong.TabIndex = 3;
            LabelDataKosong.Text = "Data Poli kosong!";
            LabelDataKosong.Visible = false;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(28, 46);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(200, 41);
            LabelTitle.TabIndex = 4;
            LabelTitle.Text = "Halaman Poli";
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
            nikDataGridViewTextBoxColumn.DataPropertyName = "namaPoli";
            nikDataGridViewTextBoxColumn.FillWeight = 90F;
            nikDataGridViewTextBoxColumn.HeaderText = "Nama Poli";
            nikDataGridViewTextBoxColumn.MinimumWidth = 6;
            nikDataGridViewTextBoxColumn.Name = "nikDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            namaDataGridViewTextBoxColumn.DataPropertyName = "ruangPoli";
            namaDataGridViewTextBoxColumn.FillWeight = 160F;
            namaDataGridViewTextBoxColumn.HeaderText = "Ruang Poli";
            namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            alamatDataGridViewTextBoxColumn.DataPropertyName = "biaya";
            alamatDataGridViewTextBoxColumn.FillWeight = 200F;
            alamatDataGridViewTextBoxColumn.HeaderText = "Biaya";
            alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // EditPoli
            // 
            EditPoli.FillWeight = 60F;
            EditPoli.HeaderText = "";
            EditPoli.MinimumWidth = 6;
            EditPoli.Name = "EditPoli";
            EditPoli.Text = "Edit";
            EditPoli.UseColumnTextForButtonValue = true;
            // 
            // HapusPoli
            // 
            HapusPoli.FillWeight = 60F;
            HapusPoli.HeaderText = "";
            HapusPoli.MinimumWidth = 6;
            HapusPoli.Name = "HapusPoli";
            HapusPoli.Text = "Hapus";
            HapusPoli.UseColumnTextForButtonValue = true;
            // 
            // PoliDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(LabelTitle);
            Controls.Add(LabelDataKosong);
            Controls.Add(ButtonTambah);
            Controls.Add(TabelPoli);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PoliDisplay";
            Text = "PasienDisplay";
            ((System.ComponentModel.ISupportInitialize)TabelPoli).EndInit();
            ((System.ComponentModel.ISupportInitialize)pasienBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TabelPoli;
        private Button buttonHapusPasien;
        private Button buttonEditPasien;
        private Button ButtonTambah;
        private BindingSource pasienBindingSource;
        private Label LabelDataKosong;
        private Label LabelTitle;
        private DataGridViewTextBoxColumn Nomor;
        private DataGridViewTextBoxColumn nikDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn EditPoli;
        private DataGridViewButtonColumn HapusPoli;
    }
}