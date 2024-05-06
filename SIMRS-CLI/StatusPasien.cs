//using System;
//using System.Collections.Generic;
//using System.ComponentModel.Design;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public enum Status { BELUM_RESERVASI, SUDAH_RESERVASI, SIAP_DIPERIKSA, SUDAH_DIPERIKSA, SUDAH_BAYAR, PENGAMBILAN_OBAT};
//public enum Trigger { RESERVASI,  PERIKSA_PASIEN, BAYAR_TAGIHAN, AMBIL_OBAT, BATAL_RESERVASI, SELESAI_PEMERIKSAAN, TRANSAKSI, SELESAI_TRANSAKSI};

//    public class StatusPasien
//    {
//        public class Transition
//        {
//            public Status stateAwal;
//            public Status stateAkhir;
//            public Trigger trigger;

//            public Transition(Status stateAwal, Status stateAkhir, Trigger trigger)
//            {
//                this.stateAwal = stateAwal;
//                this.stateAkhir = stateAkhir;
//                this.trigger = trigger;
//            }
//        }

//        Transition[] transitions = new Transition[]
//        {
//            new Transition(Status.BELUM_RESERVASI, Status.SUDAH_RESERVASI, Trigger.RESERVASI),
//            new Transition(Status.SUDAH_RESERVASI, Status.BELUM_RESERVASI, Trigger.BATAL_RESERVASI),
//            new Transition(Status.SUDAH_RESERVASI, Status.SIAP_DIPERIKSA, Trigger.PERIKSA_PASIEN),
//            new Transition(Status.SIAP_DIPERIKSA, Status.SUDAH_DIPERIKSA, Trigger.SELESAI_PEMERIKSAAN),
//            new Transition(Status.SUDAH_DIPERIKSA, Status.PENGAMBILAN_OBAT, Trigger.AMBIL_OBAT),
//            new Transition(Status.PENGAMBILAN_OBAT, Status.SUDAH_BAYAR, Trigger.BAYAR_TAGIHAN),
//            new Transition(Status.SUDAH_DIPERIKSA, Status.SUDAH_BAYAR, Trigger.BAYAR_TAGIHAN),
//            new Transition(Status.SUDAH_BAYAR, Status.BELUM_RESERVASI, Trigger.SELESAI_TRANSAKSI)
//        };

//        //state default(awal) pasien
//        public Status currentState = Status.BELUM_RESERVASI;

//        public Status GetNextState(Status stateAwal, Trigger trigger)
//        {
//            Status stateAkhir = stateAwal;
            
//            for (int i = 0; i < transitions.Length; i++)
//            {
//                Transition transisi = transitions[i];
//                if (stateAwal == transisi.stateAwal && trigger == transisi.trigger)
//                {
//                    stateAkhir = transisi.stateAkhir;
//                }
//            }
//            return stateAkhir;
//        }

//        public void ActivateTrigger(Trigger trigger)
//        {
//            currentState = GetNextState(currentState, trigger);
//            if (currentState == Status.BELUM_RESERVASI)
//            {
//                Console.WriteLine("Pasien belum melakukan reservasi");
//            }
//            else if (currentState == Status.SUDAH_RESERVASI)
//            {
//                Console.WriteLine("Pasien berhasil melakukan reservasi");
//            }
//            else if (currentState == Status.SIAP_DIPERIKSA)
//            {
//                Console.WriteLine("Giliran pasien untuk diperiksa");
//            }
//            else if (currentState == Status.SUDAH_DIPERIKSA)
//            {
//                Console.WriteLine("Pasien sudah diperiksa oleh dokter");
//            }
//            else if (currentState == Status.PENGAMBILAN_OBAT)
//            {
//                Console.WriteLine("Pasien sedang mengambil obat di apotek");
//            }
//            else if (currentState == Status.SUDAH_BAYAR)
//            {
//                Console.WriteLine("Pasien sudah membayar tagihan");
//            }
//        }
//    }
