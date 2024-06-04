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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasienDisplay));
            TabelPasien = new DataGridView();
            NomorPasien = new DataGridViewTextBoxColumn();
            NIKPasien = new DataGridViewTextBoxColumn();
            NamaPasien = new DataGridViewTextBoxColumn();
            TLPasien = new DataGridViewTextBoxColumn();
            NoHpPasien = new DataGridViewTextBoxColumn();
            JKPasien = new DataGridViewTextBoxColumn();
            AlamatPasien = new DataGridViewTextBoxColumn();
            HapusPasien = new DataGridViewButtonColumn();
            EditPasien = new DataGridViewButtonColumn();
            buttonRefresh = new Button();
            buttonTambah = new Button();
            ((System.ComponentModel.ISupportInitialize)TabelPasien).BeginInit();
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
            TabelPasien.BackgroundColor = SystemColors.Control;
            TabelPasien.BorderStyle = BorderStyle.None;
            TabelPasien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelPasien.Columns.AddRange(new DataGridViewColumn[] { NomorPasien, NIKPasien, NamaPasien, TLPasien, NoHpPasien, JKPasien, AlamatPasien, HapusPasien, EditPasien });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            TabelPasien.DefaultCellStyle = dataGridViewCellStyle2;
            TabelPasien.EditMode = DataGridViewEditMode.EditProgrammatically;
            TabelPasien.Location = new Point(28, 112);
            TabelPasien.MultiSelect = false;
            TabelPasien.Name = "TabelPasien";
            TabelPasien.RowHeadersWidth = 51;
            TabelPasien.RowTemplate.Height = 29;
            TabelPasien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelPasien.ShowCellErrors = false;
            TabelPasien.ShowCellToolTips = false;
            TabelPasien.ShowEditingIcon = false;
            TabelPasien.ShowRowErrors = false;
            TabelPasien.Size = new Size(1286, 600);
            TabelPasien.TabIndex = 0;
            // 
            // NomorPasien
            // 
            NomorPasien.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NomorPasien.HeaderText = "No";
            NomorPasien.MinimumWidth = 6;
            NomorPasien.Name = "NomorPasien";
            NomorPasien.ReadOnly = true;
            NomorPasien.Resizable = DataGridViewTriState.True;
            NomorPasien.Width = 200;
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
            // TLPasien
            // 
            TLPasien.HeaderText = "Tanggal Lahir";
            TLPasien.MinimumWidth = 6;
            TLPasien.Name = "TLPasien";
            TLPasien.Width = 125;
            // 
            // NoHpPasien
            // 
            NoHpPasien.HeaderText = "No Hp";
            NoHpPasien.MinimumWidth = 6;
            NoHpPasien.Name = "NoHpPasien";
            NoHpPasien.Width = 125;
            // 
            // JKPasien
            // 
            JKPasien.HeaderText = "Jenis Kelamin";
            JKPasien.MinimumWidth = 6;
            JKPasien.Name = "JKPasien";
            JKPasien.Width = 125;
            // 
            // AlamatPasien
            // 
            AlamatPasien.HeaderText = "Alamat";
            AlamatPasien.MinimumWidth = 6;
            AlamatPasien.Name = "AlamatPasien";
            AlamatPasien.Width = 125;
            // 
            // HapusPasien
            // 
            HapusPasien.HeaderText = "Hapus";
            HapusPasien.MinimumWidth = 6;
            HapusPasien.Name = "HapusPasien";
            HapusPasien.Text = "Hapus";
            HapusPasien.UseColumnTextForButtonValue = true;
            HapusPasien.Width = 125;
            // 
            // EditPasien
            // 
            EditPasien.HeaderText = "Edit";
            EditPasien.MinimumWidth = 6;
            EditPasien.Name = "EditPasien";
            EditPasien.Text = "Edit";
            EditPasien.UseColumnTextForButtonValue = true;
            EditPasien.Width = 125;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRefresh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRefresh.Image = (Image)resources.GetObject("buttonRefresh.Image");
            buttonRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRefresh.Location = new Point(940, 31);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Padding = new Padding(10, 0, 0, 0);
            buttonRefresh.Size = new Size(177, 48);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += ButtonRefresh_Click;
            // 
            // buttonTambah
            // 
            buttonTambah.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonTambah.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTambah.Image = (Image)resources.GetObject("buttonTambah.Image");
            buttonTambah.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTambah.Location = new Point(1137, 31);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Padding = new Padding(10, 0, 0, 0);
            buttonTambah.Size = new Size(177, 48);
            buttonTambah.TabIndex = 2;
            buttonTambah.Text = "Tambah";
            buttonTambah.UseVisualStyleBackColor = true;
            buttonTambah.Click += buttonTambah_Click;
            buttonTambah.MouseClick += button1_MouseClick;
            // 
            // PasienDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(buttonTambah);
            Controls.Add(buttonRefresh);
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
        private Button buttonRefresh;
        private Button buttonTambah;
        private DataGridViewTextBoxColumn NomorPasien;
        private DataGridViewTextBoxColumn NIKPasien;
        private DataGridViewTextBoxColumn NamaPasien;
        private DataGridViewTextBoxColumn TLPasien;
        private DataGridViewTextBoxColumn NoHpPasien;
        private DataGridViewTextBoxColumn JKPasien;
        private DataGridViewTextBoxColumn AlamatPasien;
        private DataGridViewButtonColumn HapusPasien;
        private DataGridViewButtonColumn EditPasien;
    }
}