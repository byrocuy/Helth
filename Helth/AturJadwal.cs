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
            cbJadwal.SelectedIndex = -1;
            cbJam.SelectedIndex = -1;
            cbMenit.SelectedIndex = -1;
            dtpTanggal.CustomFormat = " ";
            dtpTanggal.Format = DateTimePickerFormat.Custom;
            tbLoc.Clear();
            rtbDesc.Clear();
        }
    }
}
