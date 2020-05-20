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
    public partial class Home : Form
    {
        quotes quotes = new quotes();
        public Home()
        {
            InitializeComponent();
            RtbQuotes.Text = quotes.getQuotes();
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            AturJadwal newJadwal = new AturJadwal();
            newJadwal.Show();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            About newAbout = new About();
            newAbout.Show();
        }

        private void btnJadwalSaya_Click(object sender, EventArgs e)
        {
            Histori newHistori = new Histori();
            newHistori.Show();
        }
    }
}
