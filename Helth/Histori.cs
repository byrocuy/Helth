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
    public partial class Histori : Form
    {
        public Histori()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Histori_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jadwalDBDataSet.JadwalDB' table. You can move, or remove it, as needed.
            this.jadwalDBTableAdapter.Fill(this.jadwalDBDataSet.JadwalDB);

        }
    }
}
