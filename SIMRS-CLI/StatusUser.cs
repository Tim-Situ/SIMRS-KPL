using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIMRS_CLI.Content;

public enum Status
{
    HOME,
    MENU_PEMERIKSAAN,
    TAMBAH_PEMERIKSAAN,
    HAPUS_PEMERIKSAAN,
    MENU_PEMBAYARAN,
    TAMBAH_PEMBAYARAN,
    HAPUS_PEMBAYARAN,
    MENU_PASIEN,
    TAMBAH_DATA_PASIEN,
    EDIT_DATA_PASIEN,
    HAPUS_DATA_PASIEN,
    MENU_DOKTER,
    TAMBAH_DATA_DOKTER,
    EDIT_DATA_DOKTER,
    HAPUS_DATA_DOKTER,
    MENU_SPESIALIS,
    TAMBAH_DATA_SPESIALIS,
    EDIT_DATA_SPESIALIS,
    HAPUS_DATA_SPESIALIS,
    MENU_OBAT,
    TAMBAH_DATA_OBAT,
    EDIT_DATA_OBAT,
    HAPUS_DATA_OBAT,
    GANTI_BAHASA,
    LOG_OUT
};

public enum Trigger
{
    TAMBAH,
    EDIT,
    HAPUS,
    KEMBALI,
    AKSES_MENU_PEMERIKSAAN,
    AKSES_MENU_PEMBAYARAN,
    AKSES_MENU_PASIEN,
    AKSES_MENU_DOKTER,
    AKSES_MENU_SPESIALIS,
    AKSES_MENU_OBAT,
    KELUAR
};

public class StatusUser
{
    public class Transition
    {
        public Status stateAwal;
        public Status stateAkhir;
        public Trigger trigger;

        public Transition(Status stateAwal, Status stateAkhir, Trigger trigger)
        {
            this.stateAwal = stateAwal;
            this.stateAkhir = stateAkhir;
            this.trigger = trigger;
        }
    }

    Transition[] transitions = new Transition[]
    {
        new Transition(Status.HOME, Status.MENU_PEMERIKSAAN, Trigger.AKSES_MENU_PEMERIKSAAN),
        new Transition(Status.HOME, Status.MENU_PEMBAYARAN, Trigger.AKSES_MENU_PEMBAYARAN),
        new Transition(Status.HOME, Status.MENU_PASIEN, Trigger.AKSES_MENU_PASIEN),
        new Transition(Status.HOME, Status.MENU_DOKTER, Trigger.AKSES_MENU_DOKTER),
        new Transition(Status.HOME , Status.MENU_OBAT , Trigger.AKSES_MENU_OBAT),
        new Transition(Status.HOME , Status.LOG_OUT, Trigger.KELUAR),
        new Transition(Status.MENU_DOKTER , Status.HOME ,Trigger.KEMBALI),
        new Transition(Status.MENU_OBAT , Status.HOME ,Trigger.KEMBALI),
        new Transition(Status.MENU_PASIEN , Status.HOME ,Trigger.KEMBALI),
        new Transition(Status.MENU_PEMBAYARAN , Status.HOME ,Trigger.KEMBALI),
        new Transition(Status.MENU_PEMERIKSAAN , Status.HOME ,Trigger.KEMBALI),
        new Transition(Status.MENU_PEMERIKSAAN, Status.TAMBAH_PEMERIKSAAN, Trigger.TAMBAH),
        new Transition(Status.MENU_PEMERIKSAAN, Status.HAPUS_PEMERIKSAAN, Trigger.HAPUS),
        new Transition(Status.MENU_PEMBAYARAN, Status.TAMBAH_PEMBAYARAN, Trigger.TAMBAH),
        new Transition(Status.MENU_PEMBAYARAN, Status.HAPUS_PEMBAYARAN, Trigger.HAPUS),
        new Transition(Status.MENU_PASIEN , Status.TAMBAH_DATA_PASIEN ,Trigger.TAMBAH),
        new Transition(Status.MENU_DOKTER , Status.TAMBAH_DATA_DOKTER ,Trigger.TAMBAH),
        new Transition(Status.MENU_SPESIALIS , Status.TAMBAH_DATA_SPESIALIS ,Trigger.TAMBAH),
        new Transition(Status.MENU_OBAT , Status.TAMBAH_DATA_OBAT ,Trigger.TAMBAH),
        new Transition(Status.MENU_PASIEN , Status.EDIT_DATA_PASIEN ,Trigger.EDIT),
        new Transition(Status.MENU_DOKTER , Status.EDIT_DATA_DOKTER ,Trigger.EDIT),
        new Transition(Status.MENU_SPESIALIS , Status.EDIT_DATA_SPESIALIS ,Trigger.EDIT),
        new Transition(Status.MENU_OBAT , Status.EDIT_DATA_OBAT ,Trigger.EDIT),
        new Transition(Status.MENU_PASIEN , Status.HAPUS_DATA_PASIEN ,Trigger.HAPUS),
        new Transition(Status.MENU_DOKTER , Status.HAPUS_DATA_DOKTER ,Trigger.HAPUS),
        new Transition(Status.MENU_SPESIALIS , Status.HAPUS_DATA_SPESIALIS ,Trigger.HAPUS),
        new Transition(Status.MENU_OBAT , Status.HAPUS_DATA_OBAT ,Trigger.HAPUS)
    };

    //State awal user adalah mengakses home
    public Status currentStatus = Status.HOME;

    public Status GetNextState(Status stateAwal, Trigger trigger)
    {
        Status stateAkhir = stateAwal;

        for (int i = 0; i < transitions.Length; i++)
        {
            Transition transisi = transitions[i];
            if (stateAwal == transisi.stateAwal && trigger == transisi.trigger)
            {
                stateAkhir = transisi.stateAkhir;
            }
        }
        return stateAkhir;
    }

    public void ActivateTrigger(Trigger trigger)
    {
        currentStatus = GetNextState(currentStatus, trigger);
    }

    public void ShowAvailableMenu()
    {

        if (currentStatus == Status.MENU_PEMERIKSAAN)
        {
            Console.WriteLine(
                    "[1] Tambah Data Pemeriksaan" +
                    "\n[2] Hapus Data Pemeriksaan" +
                    "\n[0] Kembali" +
                    "\n\nInputkan Pilihan Menu: "
                    );
        } else if (currentStatus == Status.MENU_PEMBAYARAN)
        {
            Console.WriteLine(
                    "[1] Tambah Data Pembayaran" +
                    "\n[2] Hapus Data Pembayaran" +
                    "\n[0] Kembali" +
                    "\n\nInputkan Pilihan Menu: "
                    );
        } else if (currentStatus == Status.MENU_PASIEN)
        {
            Console.WriteLine(
                    "[1] Tambah Data Pasien" +
                    "\n[2] Edit Data Pasien" +
                    "\n[3] Hapus Data Pasien" +
                    "\n[0] Kembali" +
                    "\n\nInputkan Pilihan Menu: "
                    );
        } else if (currentStatus == Status.MENU_DOKTER)
        {
            Console.WriteLine(
                    "[1] Tambah Data Dokter" +
                    "\n[2] Edit Data Dokter" +
                    "\n[3] Hapus Data Dokter" +
                    "\n[0] Kembali" +
                    "\n\nInputkan Pilihan Menu: "
                    );
        } else if (currentStatus == Status.MENU_OBAT)
        {
            Console.WriteLine(
                    "[1] Tambah Data Obat" +
                    "\n[2] Edit Data Obat" +
                    "\n[3] Hapus Data Obat" +
                    "\n[0] Kembali" +
                    "\n\nInputkan Pilihan Menu: "
                    );
        } else if (currentStatus == Status.MENU_SPESIALIS)
        {
            Console.WriteLine(
                    "[1] Tambah Data Spesialis" +
                    "\n[2] Edit Data Spesialis" +
                    "\n[3] Hapus Data Spesialis" +
                    "\n[0] Kembali" +
                    "\n\nInputkan Pilihan Menu: "
           );
        } else if (currentStatus == Status.HOME)
        {

        } else if (currentStatus == Status.LOG_OUT)
        {
            Console.WriteLine("Anda Telah Keluar Dari SIMRS");
        }
    }


}