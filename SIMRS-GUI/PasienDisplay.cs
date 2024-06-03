﻿using System;
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
        PasienService controller = new();
        public List<Pasien> listPasien { get; set; }
        public PasienDisplay()
        {
            InitializeComponent();
            LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                var response = await controller.GetPasien();
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
    }
}