using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helth
{
    public partial class Alarm : Form
    {
        // buat nampilin detail kegiatan di popup alarm

        string Kegiatan, Lokasi, Deskripsi;
        public Alarm()
        {
            InitializeComponent();
            lblTitle.Text = Kegiatan;
            tbLoc.Text = Lokasi;
            rtbDesc.Text = Deskripsi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Alarm(string kegiatan, string loc, string desc)
        {
            Kegiatan = kegiatan;
            Lokasi = loc;
            Deskripsi = desc;
        }
    }
}
