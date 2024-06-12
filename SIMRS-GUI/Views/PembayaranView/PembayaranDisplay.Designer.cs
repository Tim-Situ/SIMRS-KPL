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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            TabelPembayaran = new DataGridView();
            pasienBindingSource = new BindingSource(components);
            ButtonTambah = new Button();
            LabelDataKosong = new Label();
            LabelTitle = new Label();
            kodePembayaran = new DataGridViewTextBoxColumn();
            tanggal = new DataGridViewTextBoxColumn();
            pasien = new DataGridViewTextBoxColumn();
            dokter = new DataGridViewTextBoxColumn();
            uangBayar = new DataGridViewTextBoxColumn();
            Hapus = new DataGridViewButtonColumn();
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 250, 255);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            TabelPembayaran.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            TabelPembayaran.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TabelPembayaran.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TabelPembayaran.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            TabelPembayaran.BackgroundColor = SystemColors.Control;
            TabelPembayaran.BorderStyle = BorderStyle.None;
            TabelPembayaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelPembayaran.Columns.AddRange(new DataGridViewColumn[] { kodePembayaran, tanggal, pasien, dokter, uangBayar, Hapus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            TabelPembayaran.DefaultCellStyle = dataGridViewCellStyle2;
            TabelPembayaran.EditMode = DataGridViewEditMode.EditProgrammatically;
            TabelPembayaran.GridColor = Color.White;
            TabelPembayaran.Location = new Point(28, 112);
            TabelPembayaran.MultiSelect = false;
            TabelPembayaran.Name = "TabelPembayaran";
            TabelPembayaran.RowHeadersWidth = 51;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            TabelPembayaran.RowsDefaultCellStyle = dataGridViewCellStyle3;
            TabelPembayaran.RowTemplate.Height = 29;
            TabelPembayaran.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelPembayaran.ShowCellErrors = false;
            TabelPembayaran.ShowCellToolTips = false;
            TabelPembayaran.ShowEditingIcon = false;
            TabelPembayaran.ShowRowErrors = false;
            TabelPembayaran.Size = new Size(1286, 600);
            TabelPembayaran.TabIndex = 0;
            TabelPembayaran.CellContentClick += TabelPembayaran_CellContentClick;
            TabelPembayaran.DataBindingComplete += TabelPembayaran_DataBindingComplete;
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
            // kodePembayaran
            // 
            kodePembayaran.DataPropertyName = "kode";
            kodePembayaran.HeaderText = "Kode Pembayaran";
            kodePembayaran.MinimumWidth = 6;
            kodePembayaran.Name = "kodePembayaran";
            // 
            // tanggal
            // 
            tanggal.DataPropertyName = "tanggal";
            tanggal.HeaderText = "Tanggal";
            tanggal.MinimumWidth = 6;
            tanggal.Name = "tanggal";
            // 
            // pasien
            // 
            pasien.DataPropertyName = "namaPasien";
            pasien.HeaderText = "Pasien";
            pasien.MinimumWidth = 6;
            pasien.Name = "pasien";
            // 
            // dokter
            // 
            dokter.DataPropertyName = "namaDokter";
            dokter.HeaderText = "Dokter";
            dokter.MinimumWidth = 6;
            dokter.Name = "dokter";
            // 
            // uangBayar
            // 
            uangBayar.DataPropertyName = "uangBayar";
            uangBayar.HeaderText = "Uang Bayar";
            uangBayar.MinimumWidth = 6;
            uangBayar.Name = "uangBayar";
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
            Load += PembayaranDisplay_Load;
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
        private DataGridViewTextBoxColumn kodePembayaran;
        private DataGridViewTextBoxColumn tanggal;
        private DataGridViewTextBoxColumn pasien;
        private DataGridViewTextBoxColumn dokter;
        private DataGridViewTextBoxColumn uangBayar;
        private DataGridViewButtonColumn Hapus;
    }
}