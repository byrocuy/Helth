using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helth
{
    public class Jadwal : IDetail
    {
        public string Ikegiatan { get; set; }
        public string Ilokasi { get; set; }
        public string Ideskripsi { get; set; }

        // Waktu disetel bertipe string terlebih dahulu
        // konversi menjadi integer saat kalkulasi saja
        private string _activity, _loc, _desc, _date, _time;

        public string Kegiatan
        {
            get { return _activity; }
            set { _activity = value; }
        }

        public string Lokasi
        {
            get { return _loc; }
            set { _loc = value; }
        }

        public string Deskripsi
        {
            get { return _desc; }
            set { _desc = value; }
        }

        public string Tanggal
        {
            get { return _date; }
            set { _date = value; }
        }
        
        public string Waktu
        {
            get { return _time; }
            set { _time = value; }
        }

        public Jadwal(string activity, string time, string date, string desc)
        {
            Ikegiatan = activity;
            Waktu = time;
            Tanggal = date;
            Ideskripsi = desc;
        }

        public Jadwal(string activity, string time, string date, string loc, string desc)
        {
            Ikegiatan = activity;
            Waktu = time;
            Tanggal = date;
            Ilokasi = loc;
            Ideskripsi = desc;
        }

        public virtual void showMsg()
        {
            string msg = "Kegiatan : " + Ikegiatan + "\nWaktu: " + Waktu + "\nTanggal: " + Tanggal + "\ndeskripsi: " + Ideskripsi;
            MessageBox.Show(msg, "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
