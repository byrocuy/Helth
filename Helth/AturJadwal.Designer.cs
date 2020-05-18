namespace Helth
{
    partial class AturJadwal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuotes = new System.Windows.Forms.Label();
            this.lblJadwal = new System.Windows.Forms.Label();
            this.lblJam = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblLokasi = new System.Windows.Forms.Label();
            this.btrnSet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.tbLoc = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.cbJadwal = new System.Windows.Forms.ComboBox();
            this.cbJam = new System.Windows.Forms.ComboBox();
            this.cbMenit = new System.Windows.Forms.ComboBox();
            this.pbImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuotes
            // 
            this.lblQuotes.Font = new System.Drawing.Font("Gotham", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuotes.Location = new System.Drawing.Point(186, 41);
            this.lblQuotes.Name = "lblQuotes";
            this.lblQuotes.Size = new System.Drawing.Size(269, 150);
            this.lblQuotes.TabIndex = 1;
            this.lblQuotes.Text = "\"Orang awam hanya berpikir bagaimana cara menghabiskan waktu. Orang-orang besar b" +
    "erpikir bagaimana cara menggunakannya.\"";
            this.lblQuotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJadwal
            // 
            this.lblJadwal.AutoSize = true;
            this.lblJadwal.Location = new System.Drawing.Point(47, 244);
            this.lblJadwal.Name = "lblJadwal";
            this.lblJadwal.Size = new System.Drawing.Size(98, 20);
            this.lblJadwal.TabIndex = 2;
            this.lblJadwal.Text = "Pilih Jadwal :";
            // 
            // lblJam
            // 
            this.lblJam.AutoSize = true;
            this.lblJam.Location = new System.Drawing.Point(98, 282);
            this.lblJam.Name = "lblJam";
            this.lblJam.Size = new System.Drawing.Size(47, 20);
            this.lblJam.TabIndex = 3;
            this.lblJam.Text = "Jam :";
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(71, 325);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(74, 20);
            this.lblTanggal.TabIndex = 4;
            this.lblTanggal.Text = "Tanggal :";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(63, 406);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(82, 20);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Deskripsi :";
            // 
            // lblLokasi
            // 
            this.lblLokasi.AutoSize = true;
            this.lblLokasi.Location = new System.Drawing.Point(82, 367);
            this.lblLokasi.Name = "lblLokasi";
            this.lblLokasi.Size = new System.Drawing.Size(63, 20);
            this.lblLokasi.TabIndex = 6;
            this.lblLokasi.Text = "Lokasi :";
            // 
            // btrnSet
            // 
            this.btrnSet.Location = new System.Drawing.Point(348, 501);
            this.btrnSet.Name = "btrnSet";
            this.btrnSet.Size = new System.Drawing.Size(150, 40);
            this.btrnSet.TabIndex = 7;
            this.btrnSet.Text = "Set Jadwal";
            this.btrnSet.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = ":";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Location = new System.Drawing.Point(165, 319);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(200, 26);
            this.dtpTanggal.TabIndex = 13;
            // 
            // rtbDesc
            // 
            this.rtbDesc.Location = new System.Drawing.Point(165, 406);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(334, 80);
            this.rtbDesc.TabIndex = 14;
            this.rtbDesc.Text = "";
            // 
            // tbLoc
            // 
            this.tbLoc.Location = new System.Drawing.Point(165, 361);
            this.tbLoc.Name = "tbLoc";
            this.tbLoc.Size = new System.Drawing.Size(334, 26);
            this.tbLoc.TabIndex = 15;
            this.tbLoc.Text = "(opsional)";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(261, 501);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 40);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(26, 501);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(92, 41);
            this.btnKembali.TabIndex = 17;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbJadwal
            // 
            this.cbJadwal.AccessibleDescription = "";
            this.cbJadwal.CausesValidation = false;
            this.cbJadwal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJadwal.FormattingEnabled = true;
            this.cbJadwal.Items.AddRange(new object[] {
            "Jadwal Makan",
            "Jadwal Tidur",
            "Jadwal Olahraga"});
            this.cbJadwal.Location = new System.Drawing.Point(165, 241);
            this.cbJadwal.MaxDropDownItems = 3;
            this.cbJadwal.Name = "cbJadwal";
            this.cbJadwal.Size = new System.Drawing.Size(200, 28);
            this.cbJadwal.TabIndex = 18;
            // 
            // cbJam
            // 
            this.cbJam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJam.FormatString = "N0";
            this.cbJam.FormattingEnabled = true;
            this.cbJam.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbJam.Location = new System.Drawing.Point(163, 279);
            this.cbJam.Name = "cbJam";
            this.cbJam.Size = new System.Drawing.Size(55, 28);
            this.cbJam.TabIndex = 19;
            // 
            // cbMenit
            // 
            this.cbMenit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMenit.FormattingEnabled = true;
            this.cbMenit.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbMenit.Location = new System.Drawing.Point(237, 280);
            this.cbMenit.Name = "cbMenit";
            this.cbMenit.Size = new System.Drawing.Size(55, 28);
            this.cbMenit.TabIndex = 20;
            // 
            // pbImg
            // 
            this.pbImg.ErrorImage = global::Helth.Properties.Resources._150x150;
            this.pbImg.Image = global::Helth.Properties.Resources._150x1501;
            this.pbImg.Location = new System.Drawing.Point(40, 41);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(150, 150);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg.TabIndex = 0;
            this.pbImg.TabStop = false;
            // 
            // AturJadwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 564);
            this.Controls.Add(this.cbMenit);
            this.Controls.Add(this.cbJam);
            this.Controls.Add(this.cbJadwal);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbLoc);
            this.Controls.Add(this.rtbDesc);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btrnSet);
            this.Controls.Add(this.lblLokasi);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.lblJam);
            this.Controls.Add(this.lblJadwal);
            this.Controls.Add(this.lblQuotes);
            this.Controls.Add(this.pbImg);
            this.Name = "AturJadwal";
            this.Text = "AturJadwal";
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Label lblQuotes;
        private System.Windows.Forms.Label lblJadwal;
        private System.Windows.Forms.Label lblJam;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblLokasi;
        private System.Windows.Forms.Button btrnSet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.TextBox tbLoc;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.ComboBox cbJadwal;
        private System.Windows.Forms.ComboBox cbJam;
        private System.Windows.Forms.ComboBox cbMenit;
    }
}