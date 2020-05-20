using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helth
{
    public partial class AturJadwal : Form
    {
        System.Timers.Timer timer;

        public AturJadwal()
        {
            InitializeComponent();
        }
        private void AturJadwal_Load(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Now;

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += TimerElapsed;
        }

        private void TimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker.Value;
            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            {
                timer.Stop();

                // 3 lines code dibawah awalnya buat dapetin properti biar nanti pas messageBox muncul, 
                // bisa nampilin detail kayak jadwal, loc, sama desc.
                // tapi stuck di parameter ke 3 di Invoke(gj, rtbDesc, rtbDesc.Text). error terus, jadi ngga jadi
                //GetJadwal gj = getDataJadwal;
                //if (rtbDesc.InvokeRequired)
                //    Invoke(gj, rtbDesc, rtbDesc.Text);
                const string msg = "Ring ring ring... (3x)\nAlarm berbunyi :))";
                MessageBox.Show(msg, "alarm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // invoke, menghandle biar safe-connection
        //delegate void GetJadwal(RichTextBox rtb, string text);
        //void getDataJadwal(RichTextBox rtb, string text)
        //{
        //    rtb.Text = text;
        //}
        //void setJadwal(string text)
        //{
        //    getDataJadwal(rtbDesc.Text);
        //}

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
            DateTime userTime = dateTimePicker.Value;

            // mendapatkan masukan dari combobox dan textbox
            string Aktivitas, Waktu, Date, Loc, Desc;
            Aktivitas = cbJadwal.GetItemText(cbJadwal.SelectedItem);
            Waktu = userTime.Hour +":"+ userTime.Minute;
            Date = dateTimePicker.Value.ToString("D");
            Loc = tbLoc.Text;
            Desc = rtbDesc.Text;

            if (cbJadwal.SelectedItem == null && string.IsNullOrWhiteSpace(rtbDesc.Text))
            {
                // kalau jadwal sama deskripsi ngga diisi
                MessageBox.Show("Harap isi semua form!", "Peringatan");
            }
            else
            {
                timer.Start();

                if (cbJadwal.SelectedIndex == 0)
                {
                    Jadwal jadwal = new JadwalMakan(Aktivitas, Waktu, Date, Loc, Desc);
                    jadwal.showMsg();
                }
                if (cbJadwal.SelectedIndex == 1)
                {
                    Jadwal jadwal = new JadwalOlahraga(Aktivitas, Waktu, Date, Loc, Desc);
                    jadwal.showMsg();
                }
                if (cbJadwal.SelectedIndex == 2)
                {
                    Jadwal jadwal = new JadwalTidur(Aktivitas, Waktu, Date, Desc);
                    jadwal.showMsg();
                }
            }
        }

        // method reset form dan combobox
        public void Reset()
        {
            cbJadwal.SelectedIndex = -1;
            dateTimePicker.Value = DateTime.Now;
            tbLoc.Clear();
            rtbDesc.Clear();
        }

        // menyembunyikan form loc untuk pilihan jadwal tidur
        private void cbJadwal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbJadwal.SelectedIndex == 2)
            {
                lblLokasi.Hide();
                tbLoc.Hide();
            }
            else
            {
                lblLokasi.Show();
                tbLoc.Show();
            }
        }
    }
}
