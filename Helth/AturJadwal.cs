using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helth
{
    public partial class AturJadwal : Form
    {
        public AturJadwal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btrnSet_Click(object sender, EventArgs e)
        {
            string Aktivitas, Waktu, Date, Loc, Desc;
            Aktivitas = this.cbJadwal.GetItemText(this.cbJadwal.SelectedItem);
            string jam = this.cbJam.GetItemText(this.cbJam.SelectedItem);
            string menit = this.cbMenit.GetItemText(this.cbMenit.SelectedItem);
            Waktu = jam + ":" + menit;
            Date = dtpTanggal.Value.ToString("D");
            Loc = tbLoc.Text;
            Desc = rtbDesc.Text;

            Jadwal jadwal = new Jadwal(Aktivitas, Waktu, Date, Loc, Desc);

            Reset();
            MessageBox.Show("Kegiatan : "+jadwal.Kegiatan+"\nWaktu : "+jadwal.Waktu+"\nTanggal : "+jadwal.Tanggal+"\nlokasi: "+jadwal.Lokasi+"\ndeskripsi: "+jadwal.Lokasi);
        }

        public void Reset()
        {
            cbJadwal.SelectedIndex = -1;
            cbJam.SelectedIndex = -1;
            cbMenit.SelectedIndex = -1;
            dtpTanggal.Value = DateTime.Now;
            tbLoc.Clear();
            rtbDesc.Clear();
        }

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
