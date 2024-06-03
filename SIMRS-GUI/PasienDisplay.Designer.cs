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
            TabelPasien = new DataGridView();
            buttonHapusPasien = new Button();
            buttonEditPasien = new Button();
            buttonTambahPasien = new Button();
            ButtonRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)TabelPasien).BeginInit();
            SuspendLayout();
            // 
            // TabelPasien
            // 
            TabelPasien.AllowUserToAddRows = false;
            TabelPasien.AllowUserToDeleteRows = false;
            TabelPasien.AllowUserToResizeColumns = false;
            TabelPasien.AllowUserToResizeRows = false;
            TabelPasien.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TabelPasien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelPasien.EditMode = DataGridViewEditMode.EditProgrammatically;
            TabelPasien.Location = new Point(10, 62);
            TabelPasien.Margin = new Padding(3, 2, 3, 2);
            TabelPasien.Name = "TabelPasien";
            TabelPasien.RowHeadersWidth = 51;
            TabelPasien.RowTemplate.Height = 29;
            TabelPasien.Size = new Size(785, 292);
            TabelPasien.TabIndex = 0;
            // 
            // buttonHapusPasien
            // 
            buttonHapusPasien.Location = new Point(538, 23);
            buttonHapusPasien.Margin = new Padding(3, 2, 3, 2);
            buttonHapusPasien.Name = "buttonHapusPasien";
            buttonHapusPasien.Size = new Size(82, 22);
            buttonHapusPasien.TabIndex = 1;
            buttonHapusPasien.Text = "Hapus";
            buttonHapusPasien.UseVisualStyleBackColor = true;
            // 
            // buttonEditPasien
            // 
            buttonEditPasien.Location = new Point(626, 23);
            buttonEditPasien.Margin = new Padding(3, 2, 3, 2);
            buttonEditPasien.Name = "buttonEditPasien";
            buttonEditPasien.Size = new Size(82, 22);
            buttonEditPasien.TabIndex = 1;
            buttonEditPasien.Text = "Edit";
            buttonEditPasien.UseVisualStyleBackColor = true;
            // 
            // buttonTambahPasien
            // 
            buttonTambahPasien.Location = new Point(713, 23);
            buttonTambahPasien.Margin = new Padding(3, 2, 3, 2);
            buttonTambahPasien.Name = "buttonTambahPasien";
            buttonTambahPasien.Size = new Size(82, 22);
            buttonTambahPasien.TabIndex = 1;
            buttonTambahPasien.Text = "Tambah";
            buttonTambahPasien.UseVisualStyleBackColor = true;
            // 
            // ButtonRefresh
            // 
            ButtonRefresh.Location = new Point(450, 23);
            ButtonRefresh.Margin = new Padding(3, 2, 3, 2);
            ButtonRefresh.Name = "ButtonRefresh";
            ButtonRefresh.Size = new Size(82, 22);
            ButtonRefresh.TabIndex = 2;
            ButtonRefresh.Text = "Refresh";
            ButtonRefresh.UseVisualStyleBackColor = true;
            ButtonRefresh.Click += ButtonRefresh_Click;
            // 
            // PasienDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 363);
            Controls.Add(ButtonRefresh);
            Controls.Add(buttonTambahPasien);
            Controls.Add(buttonEditPasien);
            Controls.Add(buttonHapusPasien);
            Controls.Add(TabelPasien);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "PasienDisplay";
            Text = "PasienDisplay";
            ((System.ComponentModel.ISupportInitialize)TabelPasien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TabelPasien;
        private Button buttonHapusPasien;
        private Button buttonEditPasien;
        private Button buttonTambahPasien;
        private Button ButtonRefresh;
    }
}