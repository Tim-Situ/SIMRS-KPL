using System.ComponentModel;
using System.Linq;
using Microsoft.Build.Framework;
using SIMRS_API;
using SIMRS_GUI.Services;
using static SIMRS_API.User;

namespace SIMRS_GUI.Views.DokterView
{
    public partial class DokterDisplay : Form
    {
        private List<Dokter> _listDokter { get; set; }
        private DokterManager _dokterManager;
        private MainDisplay _mainDisplay;

        public DokterDisplay(MainDisplay mainDisplay)
        {
            InitializeComponent();
            TopLevel = false;
            _mainDisplay = mainDisplay;
            _dokterManager = new();
        }
        private void DokterDisplay_Load(object sender, EventArgs e)
        {
            LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                // Get dari API.
                ApiResponse<List<Dokter>> response = await _dokterManager.GetDokter();
                _listDokter = response.data;

                // Ambil hanya nilai yang ingin ditampilkan
                // pada tabel.
                List<GridViewDokter> gridViewDokter = _listDokter.Select(dokter =>
                {
                    return new GridViewDokter(
                        dokter.nip,
                        dokter.nama,
                        dokter.poli.namaPoli,
                        dokter.tglLahir,
                        dokter.noHp,
                        dokter.jnsKelamin.ToString(),
                        dokter.alamat
                        );

                }).ToList();

                // Cek apakah kosong atau tidak.
                if (gridViewDokter.Count == 0)
                {
                    TabelDokter.Hide();
                    LabelDataKosong.Text = "Data dokter kosong";
                    LabelDataKosong.Show();
                }
                else
                {
                    // Jika tidak kosong, invoke agar tabel dapat
                    // menampilkan data terbaru dari async call.
                    if (TabelDokter.InvokeRequired)
                    {
                        TabelDokter.Invoke(new Action(() => TabelDokter.DataSource = gridViewDokter));
                    }
                    else
                    {
                        TabelDokter.DataSource = gridViewDokter;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ambil data: " + ex.Message);
            }
        }

        private class GridViewDokter
        {
            public string nip { get; set; }
            public string nama { get; set; }
            public string namaPoli { get; set; }
            public string tglLahir { get; set; }
            public string noHP { get; set; }
            public string jenisKelamin { get; set; }
            public string alamat { get; set; }

            public GridViewDokter(string nip, string nama, string namaPoli, string tglLahir, string noHP, string jenisKelamin, string alamat)
            {
                this.nip = nip;
                this.nama = nama;
                this.namaPoli = namaPoli;
                this.tglLahir = tglLahir;
                this.noHP = noHP;
                this.jenisKelamin = jenisKelamin;
                this.alamat = alamat;
            }
        }

        private void TabelDokter_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            NomorUrut(TabelDokter);
        }

        private void NomorUrut(DataGridView grid)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                grid.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                row.Height = 25;
            }
        }
    }
}
