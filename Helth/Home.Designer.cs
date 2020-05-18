namespace Helth
{
    partial class Home
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.RtbQuotes = new System.Windows.Forms.RichTextBox();
            this.BtnSet = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.PbMain = new System.Windows.Forms.PictureBox();
            this.btnJadwalSaya = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Gotham", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(387, 99);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(231, 81);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Helth";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Gotham", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(364, 182);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(280, 23);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Atur jadwal hidup sehatmu!";
            // 
            // RtbQuotes
            // 
            this.RtbQuotes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RtbQuotes.Location = new System.Drawing.Point(32, 361);
            this.RtbQuotes.Name = "RtbQuotes";
            this.RtbQuotes.ReadOnly = true;
            this.RtbQuotes.Size = new System.Drawing.Size(624, 60);
            this.RtbQuotes.TabIndex = 3;
            this.RtbQuotes.Text = "Quotes";
            // 
            // BtnSet
            // 
            this.BtnSet.Location = new System.Drawing.Point(401, 226);
            this.BtnSet.Name = "BtnSet";
            this.BtnSet.Size = new System.Drawing.Size(217, 45);
            this.BtnSet.TabIndex = 4;
            this.BtnSet.Text = "Set Alarm Sehat";
            this.BtnSet.UseVisualStyleBackColor = true;
            this.BtnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.Location = new System.Drawing.Point(520, 277);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(98, 40);
            this.BtnAbout.TabIndex = 5;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // PbMain
            // 
            this.PbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbMain.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.PbMain.Image = global::Helth.Properties.Resources.gif;
            this.PbMain.InitialImage = global::Helth.Properties.Resources.ooooof;
            this.PbMain.Location = new System.Drawing.Point(31, 44);
            this.PbMain.Name = "PbMain";
            this.PbMain.Size = new System.Drawing.Size(300, 300);
            this.PbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbMain.TabIndex = 0;
            this.PbMain.TabStop = false;
            this.PbMain.UseWaitCursor = true;
            // 
            // btnJadwalSaya
            // 
            this.btnJadwalSaya.Location = new System.Drawing.Point(401, 277);
            this.btnJadwalSaya.Name = "btnJadwalSaya";
            this.btnJadwalSaya.Size = new System.Drawing.Size(113, 40);
            this.btnJadwalSaya.TabIndex = 6;
            this.btnJadwalSaya.Text = "Jadwal Saya";
            this.btnJadwalSaya.UseVisualStyleBackColor = true;
            this.btnJadwalSaya.Click += new System.EventHandler(this.btnJadwalSaya_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 438);
            this.Controls.Add(this.btnJadwalSaya);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.BtnSet);
            this.Controls.Add(this.RtbQuotes);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.PbMain);
            this.Name = "Home";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbMain;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.RichTextBox RtbQuotes;
        private System.Windows.Forms.Button BtnSet;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Button btnJadwalSaya;
    }
}

