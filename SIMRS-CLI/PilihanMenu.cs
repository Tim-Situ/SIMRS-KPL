using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum MainMenu
{
    Pemeriksaan,
    Pembayaran,
    Pasien,
    Dokter,
    Spesialis,
    Obat,
    Ganti_bahasa,
    Keluar
}

public enum MenuA
{
    Tambah_data, Edit_data, Hapus_data, Kembali
}

public enum MenuB
{
    Tambah_data, Hapus_data, Kembali
}

public class PilihanMenu
{
   public int getPilihan(MainMenu menu)
    {
        return 0;
    }
}
