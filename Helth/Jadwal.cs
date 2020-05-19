using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Helth
{
    class Jadwal
    {
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

        public Jadwal(string activity, string time, string date, string loc, string desc)
        {
            Kegiatan = activity;
            Waktu = time;
            Tanggal = date;
            Lokasi = loc;
            Deskripsi = desc;
        }
    }
}
