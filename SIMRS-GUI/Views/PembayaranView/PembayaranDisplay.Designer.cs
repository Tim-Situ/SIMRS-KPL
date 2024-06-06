namespace SIMRS_GUI.Views.PembayaranView
{
    partial class PembayaranDisplay
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
            TabelPembayaran = new DataGridView();
            pasienBindingSource = new BindingSource(components);
            ButtonTambah = new Button();
            LabelDataKosong = new Label();
            LabelTitle = new Label();
            Nomor = new DataGridViewTextBoxColumn();
            kodePembayaran = new DataGridViewTextBoxColumn();
            tanggal = new DataGridViewTextBoxColumn();
            pasien = new DataGridViewTextBoxColumn();
            dokter = new DataGridViewTextBoxColumn();
            totalBiaya = new DataGridViewTextBoxColumn();
            EditPasien = new DataGridViewButtonColumn();
            HapusPasien = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)TabelPembayaran).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pasienBindingSource).BeginInit();
            SuspendLayout();
            // 
            // TabelPembayaran
            // 
            TabelPembayaran.AllowUserToAddRows = false;
            TabelPembayaran.AllowUserToDeleteRows = false;
            TabelPembayaran.AllowUserToResizeColumns = false;
            TabelPembayaran.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(242, 250, 255);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            TabelPembayaran.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            TabelPembayaran.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TabelPembayaran.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TabelPembayaran.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            TabelPembayaran.BackgroundColor = SystemColors.Control;
            TabelPembayaran.BorderStyle = BorderStyle.None;
            TabelPembayaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelPembayaran.Columns.AddRange(new DataGridViewColumn[] { Nomor, kodePembayaran, tanggal, pasien, dokter, totalBiaya, EditPasien, HapusPasien });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            TabelPembayaran.DefaultCellStyle = dataGridViewCellStyle5;
            TabelPembayaran.EditMode = DataGridViewEditMode.EditProgrammatically;
            TabelPembayaran.GridColor = Color.White;
            TabelPembayaran.Location = new Point(28, 112);
            TabelPembayaran.MultiSelect = false;
            TabelPembayaran.Name = "TabelPembayaran";
            TabelPembayaran.RowHeadersVisible = false;
            TabelPembayaran.RowHeadersWidth = 51;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            TabelPembayaran.RowsDefaultCellStyle = dataGridViewCellStyle6;
            TabelPembayaran.RowTemplate.Height = 29;
            TabelPembayaran.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelPembayaran.ShowCellErrors = false;
            TabelPembayaran.ShowCellToolTips = false;
            TabelPembayaran.ShowEditingIcon = false;
            TabelPembayaran.ShowRowErrors = false;
            TabelPembayaran.Size = new Size(1286, 600);
            TabelPembayaran.TabIndex = 0;
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
            LabelDataKosong.Location = new Point(459, 131);
            LabelDataKosong.Name = "LabelDataKosong";
            LabelDataKosong.Padding = new Padding(10, 5, 10, 5);
            LabelDataKosong.Size = new Size(473, 60);
            LabelDataKosong.TabIndex = 3;
            LabelDataKosong.Text = "Data Pembayaran kosong!";
            LabelDataKosong.Visible = false;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(28, 46);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(319, 41);
            LabelTitle.TabIndex = 4;
            LabelTitle.Text = "Halaman Pembayaran";
            // 
            // Nomor
            // 
            Nomor.FillWeight = 25F;
            Nomor.HeaderText = "No";
            Nomor.MinimumWidth = 6;
            Nomor.Name = "Nomor";
            Nomor.ReadOnly = true;
            // 
            // kodePembayaran
            // 
            kodePembayaran.HeaderText = "Kode Pembayaran";
            kodePembayaran.MinimumWidth = 6;
            kodePembayaran.Name = "kodePembayaran";
            // 
            // tanggal
            // 
            tanggal.HeaderText = "Tanggal";
            tanggal.MinimumWidth = 6;
            tanggal.Name = "tanggal";
            // 
            // pasien
            // 
            pasien.HeaderText = "Pasien";
            pasien.MinimumWidth = 6;
            pasien.Name = "pasien";
            // 
            // dokter
            // 
            dokter.HeaderText = "Dokter";
            dokter.MinimumWidth = 6;
            dokter.Name = "dokter";
            // 
            // totalBiaya
            // 
            totalBiaya.HeaderText = "Total Biaya";
            totalBiaya.MinimumWidth = 6;
            totalBiaya.Name = "totalBiaya";
            // 
            // EditPasien
            // 
            EditPasien.FillWeight = 60F;
            EditPasien.HeaderText = "";
            EditPasien.MinimumWidth = 6;
            EditPasien.Name = "EditPasien";
            EditPasien.Text = "Edit";
            EditPasien.UseColumnTextForButtonValue = true;
            // 
            // HapusPasien
            // 
            HapusPasien.FillWeight = 60F;
            HapusPasien.HeaderText = "";
            HapusPasien.MinimumWidth = 6;
            HapusPasien.Name = "HapusPasien";
            HapusPasien.Text = "Hapus";
            HapusPasien.UseColumnTextForButtonValue = true;
            // 
            // PembayaranDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(LabelTitle);
            Controls.Add(LabelDataKosong);
            Controls.Add(ButtonTambah);
            Controls.Add(TabelPembayaran);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PembayaranDisplay";
            Text = "PasienDisplay";
            ((System.ComponentModel.ISupportInitialize)TabelPembayaran).EndInit();
            ((System.ComponentModel.ISupportInitialize)pasienBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TabelPembayaran;
        private Button buttonHapusPasien;
        private Button buttonEditPasien;
        private Button ButtonTambah;
        private BindingSource pasienBindingSource;
        private Label LabelDataKosong;
        private Label LabelTitle;
        private DataGridViewTextBoxColumn Nomor;
        private DataGridViewTextBoxColumn kodePembayaran;
        private DataGridViewTextBoxColumn tanggal;
        private DataGridViewTextBoxColumn pasien;
        private DataGridViewTextBoxColumn dokter;
        private DataGridViewTextBoxColumn totalBiaya;
        private DataGridViewButtonColumn EditPasien;
        private DataGridViewButtonColumn HapusPasien;
    }
}