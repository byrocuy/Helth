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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AturJadwal));
            this.lblQuotes = new System.Windows.Forms.Label();
            this.lblJadwal = new System.Windows.Forms.Label();
            this.lblJam = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblLokasi = new System.Windows.Forms.Label();
            this.btrnSet = new System.Windows.Forms.Button();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.tbLoc = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.cbJadwal = new System.Windows.Forms.ComboBox();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            this.lblJadwal.Location = new System.Drawing.Point(48, 245);
            this.lblJadwal.Name = "lblJadwal";
            this.lblJadwal.Size = new System.Drawing.Size(98, 20);
            this.lblJadwal.TabIndex = 2;
            this.lblJadwal.Text = "Pilih Jadwal :";
            // 
            // lblJam
            // 
            this.lblJam.AutoSize = true;
            this.lblJam.Location = new System.Drawing.Point(38, 288);
            this.lblJam.Name = "lblJam";
            this.lblJam.Size = new System.Drawing.Size(108, 20);
            this.lblJam.TabIndex = 3;
            this.lblJam.Text = "Jam/Tanggal :";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(64, 330);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(82, 20);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Deskripsi :";
            // 
            // lblLokasi
            // 
            this.lblLokasi.AutoSize = true;
            this.lblLokasi.Location = new System.Drawing.Point(14, 427);
            this.lblLokasi.Name = "lblLokasi";
            this.lblLokasi.Size = new System.Drawing.Size(136, 20);
            this.lblLokasi.TabIndex = 6;
            this.lblLokasi.Text = "Lokasi (opsional) :";
            // 
            // btrnSet
            // 
            this.btrnSet.Location = new System.Drawing.Point(348, 502);
            this.btrnSet.Name = "btrnSet";
            this.btrnSet.Size = new System.Drawing.Size(150, 40);
            this.btrnSet.TabIndex = 7;
            this.btrnSet.Text = "Set Jadwal";
            this.btrnSet.UseVisualStyleBackColor = true;
            this.btrnSet.Click += new System.EventHandler(this.btrnSet_Click);
            // 
            // rtbDesc
            // 
            this.rtbDesc.Location = new System.Drawing.Point(164, 330);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(334, 80);
            this.rtbDesc.TabIndex = 14;
            this.rtbDesc.Text = "";
            // 
            // tbLoc
            // 
            this.tbLoc.Location = new System.Drawing.Point(164, 424);
            this.tbLoc.Name = "tbLoc";
            this.tbLoc.Size = new System.Drawing.Size(334, 26);
            this.tbLoc.TabIndex = 15;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(134, 501);
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
            "Makan",
            "Olahraga",
            "Tidur"});
            this.cbJadwal.Location = new System.Drawing.Point(164, 242);
            this.cbJadwal.MaxDropDownItems = 3;
            this.cbJadwal.Name = "cbJadwal";
            this.cbJadwal.Size = new System.Drawing.Size(200, 28);
            this.cbJadwal.TabIndex = 18;
            this.cbJadwal.SelectedIndexChanged += new System.EventHandler(this.cbJadwal_SelectedIndexChanged);
            // 
            // pbImg
            // 
            this.pbImg.ErrorImage = global::Helth.Properties.Resources._150x1501;
            this.pbImg.Image = ((System.Drawing.Image)(resources.GetObject("pbImg.Image")));
            this.pbImg.Location = new System.Drawing.Point(40, 41);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(150, 150);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg.TabIndex = 0;
            this.pbImg.TabStop = false;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(164, 288);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(106, 26);
            this.dateTimePicker.TabIndex = 21;
            this.dateTimePicker.Value = new System.DateTime(2020, 5, 19, 12, 0, 0, 0);
            // 
            // AturJadwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 564);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.cbJadwal);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbLoc);
            this.Controls.Add(this.rtbDesc);
            this.Controls.Add(this.btrnSet);
            this.Controls.Add(this.lblLokasi);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblJam);
            this.Controls.Add(this.lblJadwal);
            this.Controls.Add(this.lblQuotes);
            this.Controls.Add(this.pbImg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AturJadwal";
            this.Text = "AturJadwal";
            this.Load += new System.EventHandler(this.AturJadwal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Label lblQuotes;
        private System.Windows.Forms.Label lblJadwal;
        private System.Windows.Forms.Label lblJam;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblLokasi;
        private System.Windows.Forms.Button btrnSet;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.TextBox tbLoc;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.ComboBox cbJadwal;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}