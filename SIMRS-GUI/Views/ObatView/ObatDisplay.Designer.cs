namespace SIMRS_GUI.Views.ObatView
{
    partial class ObatDisplay
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
            TabelObat = new DataGridView();
            pasienBindingSource = new BindingSource(components);
            ButtonTambah = new Button();
            LabelDataKosong = new Label();
            LabelTitle = new Label();
            Nomor = new DataGridViewTextBoxColumn();
            namaObat = new DataGridViewTextBoxColumn();
            hargaObat = new DataGridViewTextBoxColumn();
            jenisObat = new DataGridViewTextBoxColumn();
            EditObat = new DataGridViewButtonColumn();
            HapusObat = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)TabelObat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pasienBindingSource).BeginInit();
            SuspendLayout();
            // 
            // TabelObat
            // 
            TabelObat.AllowUserToAddRows = false;
            TabelObat.AllowUserToDeleteRows = false;
            TabelObat.AllowUserToResizeColumns = false;
            TabelObat.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 250, 255);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            TabelObat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            TabelObat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TabelObat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TabelObat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            TabelObat.BackgroundColor = SystemColors.Control;
            TabelObat.BorderStyle = BorderStyle.None;
            TabelObat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelObat.Columns.AddRange(new DataGridViewColumn[] { Nomor, namaObat, hargaObat, jenisObat, EditObat, HapusObat });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            TabelObat.DefaultCellStyle = dataGridViewCellStyle2;
            TabelObat.EditMode = DataGridViewEditMode.EditProgrammatically;
            TabelObat.GridColor = Color.White;
            TabelObat.Location = new Point(28, 112);
            TabelObat.MultiSelect = false;
            TabelObat.Name = "TabelObat";
            TabelObat.RowHeadersVisible = false;
            TabelObat.RowHeadersWidth = 51;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            TabelObat.RowsDefaultCellStyle = dataGridViewCellStyle3;
            TabelObat.RowTemplate.Height = 29;
            TabelObat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelObat.ShowCellErrors = false;
            TabelObat.ShowCellToolTips = false;
            TabelObat.ShowEditingIcon = false;
            TabelObat.ShowRowErrors = false;
            TabelObat.Size = new Size(1286, 600);
            TabelObat.TabIndex = 0;
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
            LabelDataKosong.Location = new Point(494, 136);
            LabelDataKosong.Name = "LabelDataKosong";
            LabelDataKosong.Padding = new Padding(10, 5, 10, 5);
            LabelDataKosong.Size = new Size(353, 60);
            LabelDataKosong.TabIndex = 3;
            LabelDataKosong.Text = "Data Obat kosong!";
            LabelDataKosong.Visible = false;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(28, 46);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(217, 41);
            LabelTitle.TabIndex = 4;
            LabelTitle.Text = "Halaman Obat";
            // 
            // Nomor
            // 
            Nomor.FillWeight = 25F;
            Nomor.HeaderText = "No";
            Nomor.MinimumWidth = 6;
            Nomor.Name = "Nomor";
            Nomor.ReadOnly = true;
            // 
            // namaObat
            // 
            namaObat.HeaderText = "Nama Obat";
            namaObat.MinimumWidth = 6;
            namaObat.Name = "namaObat";
            // 
            // hargaObat
            // 
            hargaObat.HeaderText = "Harga Obat";
            hargaObat.MinimumWidth = 6;
            hargaObat.Name = "hargaObat";
            // 
            // jenisObat
            // 
            jenisObat.HeaderText = "Jenis Obat";
            jenisObat.MinimumWidth = 6;
            jenisObat.Name = "jenisObat";
            // 
            // EditObat
            // 
            EditObat.FillWeight = 60F;
            EditObat.HeaderText = "";
            EditObat.MinimumWidth = 6;
            EditObat.Name = "EditObat";
            EditObat.Text = "Edit";
            EditObat.UseColumnTextForButtonValue = true;
            // 
            // HapusObat
            // 
            HapusObat.FillWeight = 60F;
            HapusObat.HeaderText = "";
            HapusObat.MinimumWidth = 6;
            HapusObat.Name = "HapusObat";
            HapusObat.Text = "Hapus";
            HapusObat.UseColumnTextForButtonValue = true;
            // 
            // ObatDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(LabelTitle);
            Controls.Add(LabelDataKosong);
            Controls.Add(ButtonTambah);
            Controls.Add(TabelObat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ObatDisplay";
            Text = "PasienDisplay";
            ((System.ComponentModel.ISupportInitialize)TabelObat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pasienBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TabelObat;
        private Button buttonHapusPasien;
        private Button buttonEditPasien;
        private Button ButtonTambah;
        private BindingSource pasienBindingSource;
        private Label LabelDataKosong;
        private Label LabelTitle;
        private DataGridViewTextBoxColumn Nomor;
        private DataGridViewTextBoxColumn namaObat;
        private DataGridViewTextBoxColumn hargaObat;
        private DataGridViewTextBoxColumn jenisObat;
        private DataGridViewButtonColumn EditObat;
        private DataGridViewButtonColumn HapusObat;
    }
}