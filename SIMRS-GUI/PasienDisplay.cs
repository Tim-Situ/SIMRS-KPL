using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIMRS_API;
using SIMRS_GUI.Services;

namespace SIMRS_GUI
{
    public partial class PasienDisplay : Form
    {
        private PasienService controller = new();
        private List<Pasien> listPasien { get; set; }
        private MainDisplay _mainDisplay;
        public PasienDisplay(MainDisplay mainDisplay)
        {
            InitializeComponent();
            LoadDataAsync();
            TopLevel = false;
            _mainDisplay = mainDisplay;
            //TabelPasien.Column
        }

        private async Task LoadDataAsync()
        {
            try
            {
                ApiResponse<List<Pasien>> response = await controller.GetPasien();
                listPasien = response.data;


                if (TabelPasien.InvokeRequired)
                {
                    TabelPasien.Invoke(new Action(() => TabelPasien.DataSource = listPasien));
                }
                else
                {
                    TabelPasien.DataSource = listPasien;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ambil data: " + ex.Message);
            }
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadDataAsync();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            //_mainDisplay.ButtonTambahPasien();
        }
    }
}
