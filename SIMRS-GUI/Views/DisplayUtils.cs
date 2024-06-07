using SIMRS_API;

namespace SIMRS_GUI.Views
{
    internal class DisplayUtils
    {
        public static void NomorUrut(DataGridView grid)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                grid.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                row.Height = 25;
            }
        }

        public static string GenerateKode<T>(List<T> listData) where T : class
        {
            string prefix = "";
            int digit = 0;


            if (listData is List<Poli>)
            {
                List<Poli> list = listData as List<Poli>;
                prefix = "POL";
                if (list.Count > 0)
                {
                    digit = int.Parse(list.Last().kode.Substring(3)) + 1;
                }
                else
                {
                    digit = 1;
                }
            }
            else if (listData is List<Obat>)
            {
                List<Obat> list = listData as List<Obat>;
                prefix = "OBT";
                if (list.Count > 0)
                {
                    digit = int.Parse(list.Last().kode.Substring(3)) + 1;
                }
                else
                {
                    digit = 1;
                }
            }
            else if (listData is List<Pemeriksaan>)
            {
                List<Pemeriksaan> list = listData as List<Pemeriksaan>;
                prefix = "PMR";
                if (list.Count > 0)
                {
                    digit = int.Parse(list.Last().kode.Substring(3)) + 1;
                }
                else
                {
                    digit = 1;
                }
            }
            else if (listData is List<Pembayaran>)
            {
                List<Pembayaran> list = listData as List<Pembayaran>;
                prefix = "PBY";
                if (list.Count > 0)
                {
                    digit = int.Parse(list.Last().kode.Substring(3)) + 1;
                }
                else
                {
                    digit = 1;
                }
            }


            return $"{prefix}{digit:D3}";
        }
    }
}
