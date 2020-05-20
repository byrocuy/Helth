using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helth
{
    public class JadwalMakan : Jadwal
    {
        public JadwalMakan(string jadwal, string time, string date, string loc, string desc) : base(jadwal, time, date, desc)
        {
            Ikegiatan = jadwal;
            Waktu = time;
            Tanggal = date;
            Ilokasi = loc;
            Ideskripsi = desc;
        }

        public override void showMsg()
        {
            string msg = "Kegiatan : " + Ikegiatan + "\nWaktu: " + Waktu + "\nTanggal: " + Tanggal + "\nLokasi: " + Ilokasi + "\ndeskripsi: " + Ideskripsi;
            MessageBox.Show(msg, "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
