using SIMRS_API;
using SIMRS_LIB;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CobaUnitTes;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TesTotalBiaya()
    {
        Poli poli = new Poli("PLI01", "THT", "POLI0102", 45000);
        Dokter dokter = new Dokter("1234222", "Dr. Anwar", poli, "01-01-2002", "08574868", User.EnumJenisKelamin.PRIA, "Jakarta");
        Pasien pasien = new Pasien("1242323", "Fauzein Mulya Warman", "02-12-2003", "08674557654", User.EnumJenisKelamin.PRIA, "Padang");
        Obat obat = new Obat("OBT01", "Paracetamol", 5000, Obat.EnumObat.PIL);
        Pemeriksaan pemeriksaan = new Pemeriksaan("PRS01", pasien, dokter, "07-05-2024", 160, 60, 90, "Pusing", "Sakit Kepala", obat);
        Pembayaran pembayaran = new Pembayaran("BYR01", pemeriksaan);

        int expectTotalBiaya = 50000; // biaya Poli (45000) + biaya obat (5000)

        int hasilTotalBiaya = pembayaran.getTotalBiaya();

        Assert.AreEqual(expectTotalBiaya, hasilTotalBiaya);
    }

    [TestMethod]
    public void TesUangKembalian()
    {
        Poli poli = new Poli("PLI02", "Gigi", "POLI0102", 100000);
        Dokter dokter = new Dokter("1234222", "Dr. Ayu", poli, "01-01-2002", "08574868", User.EnumJenisKelamin.WANITA, "Jakarta");
        Pasien pasien = new Pasien("1242323", "Rafatar", "02-12-2003", "08674557654", User.EnumJenisKelamin.PRIA, "Jakarta");
        Obat obat = new Obat("OBT01", "Obat Sakit Gigi", 30000, Obat.EnumObat.PIL);
        Pemeriksaan pemeriksaan = new Pemeriksaan("PRS01", pasien, dokter, "07-05-2024", 160, 60, 90, "Pusing", "Sakit Kepala", obat);
        Pembayaran pembayaran = new Pembayaran("BYR01", pemeriksaan);

        pembayaran.uangBayar = 150000;

        //Contoh Expect salah
        int expectUangKembalian = 2000; // uang (150000) - total biaya (130000)

        int hasilUangKembalian = pembayaran.getUangKembalian(pembayaran.uangBayar);

        Assert.AreEqual(expectUangKembalian, hasilUangKembalian);
    }
}
