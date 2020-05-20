using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helth
{
    public class JadwalTidur : Jadwal
    {
        public JadwalTidur(string activity, string time, string date, string desc) : base(activity, time, date, desc)
        {

        }

        public override void showMsg()
        {
            string msg = "Kegiatan : " + Ikegiatan + "\nWaktu: " + Waktu + "\nTanggal: " + Tanggal + "\ndeskripsi: " + Ideskripsi;
            MessageBox.Show(msg, "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
