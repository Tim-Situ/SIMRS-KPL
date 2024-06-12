﻿using SIMRS_API;
using SIMRS_GUI.Services;

namespace SIMRS_GUI.Views.PasienView
{
    public partial class PasienTambahDisplay : Form
    {
        private PasienManager _pasienManager;
        private MainDisplay _mainDisplay;

        public PasienTambahDisplay(MainDisplay mainDisplay)
        {
            InitializeComponent();
            TopLevel = false;
            _mainDisplay = mainDisplay;
            _pasienManager = new();

        }

        private async void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string NIK = InputNIK.Text;
            string nama = InputNama.Text;
            string noHP = InputNoHp.Text;
            User.EnumJenisKelamin jenisKelamin = default;
            string alamat = InputAlamat.Text;
            string tanggalLahir = InputTanggal.Value.ToShortDateString();

            if (!InputValidator.ValidasiNIK(NIK))
            {
                MessageBox.Show("NIK harus terdiri dari 16 digit angka");
                return;
            }

            if (!InputValidator.ValidasiHurufSaja(nama))
            {
                MessageBox.Show("Nama hanya boleh terdiri dari huruf");
                return;
            }

            if (!InputValidator.ValidasiNoTelp(noHP))
            {
                MessageBox.Show("Nomor HP hanya boleh terdiri dari 10-13 digit angka");
                return;
            }

            if (!RadioPria.Checked && !RadioWanita.Checked)
            {
                MessageBox.Show("Jenis kelamin harus dipilih");
                return;
            }

            if (alamat.Length == 0)
            {
                MessageBox.Show("Alamat harus ada isinya");
                return;
            }

            jenisKelamin = (RadioPria.Checked) 
                ? User.EnumJenisKelamin.PRIA 
                : User.EnumJenisKelamin.WANITA;
            Pasien pasien = new Pasien(NIK, nama, tanggalLahir, noHP, jenisKelamin, alamat);
            await _pasienManager.AddPasien(pasien);

            _mainDisplay.ShowDisplay(new PasienDisplay(_mainDisplay));
        }

    }
}
