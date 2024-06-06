﻿namespace SIMRS_GUI.Views.PoliView
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
            pasienBindingSource = new BindingSource(components);
            ButtonTambah = new Button();
            LabelDataKosong = new Label();
            LabelTitle = new Label();
            TabelObat = new DataGridView();
            label1 = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            namaPoli = new DataGridViewTextBoxColumn();
            ruangPoli = new DataGridViewTextBoxColumn();
            biayaPoli = new DataGridViewTextBoxColumn();
            EditObat = new DataGridViewButtonColumn();
            HapusObat = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)pasienBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TabelObat).BeginInit();
            SuspendLayout();
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
            ButtonTambah.Location = new Point(1137, 39);
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
            TabelObat.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, namaPoli, ruangPoli, biayaPoli, EditObat, HapusObat });
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
            TabelObat.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(548, 138);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 5, 10, 5);
            label1.Size = new Size(331, 60);
            label1.TabIndex = 6;
            label1.Text = "Data Poli kosong!";
            label1.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 25F;
            dataGridViewTextBoxColumn1.HeaderText = "No";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // namaPoli
            // 
            namaPoli.HeaderText = "Nama Poli";
            namaPoli.MinimumWidth = 6;
            namaPoli.Name = "namaPoli";
            // 
            // ruangPoli
            // 
            ruangPoli.HeaderText = "Ruang Poli";
            ruangPoli.MinimumWidth = 6;
            ruangPoli.Name = "ruangPoli";
            // 
            // biayaPoli
            // 
            biayaPoli.HeaderText = "Biaya Poli";
            biayaPoli.MinimumWidth = 6;
            biayaPoli.Name = "biayaPoli";
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
            // PoliDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 851);
            Controls.Add(label1);
            Controls.Add(TabelObat);
            Controls.Add(LabelTitle);
            Controls.Add(LabelDataKosong);
            Controls.Add(ButtonTambah);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PoliDisplay";
            Text = "PasienDisplay";
            ((System.ComponentModel.ISupportInitialize)pasienBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)TabelObat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonHapusPasien;
        private Button buttonEditPasien;
        private Button ButtonTambah;
        private BindingSource pasienBindingSource;
        private Label LabelDataKosong;
        private Label LabelTitle;
        private DataGridView TabelObat;
        private Label label1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn namaPoli;
        private DataGridViewTextBoxColumn ruangPoli;
        private DataGridViewTextBoxColumn biayaPoli;
        private DataGridViewButtonColumn EditObat;
        private DataGridViewButtonColumn HapusObat;
    }
}