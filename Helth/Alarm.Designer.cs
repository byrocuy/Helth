namespace Helth
{
    partial class Alarm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbLoc = new System.Windows.Forms.TextBox();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anda punya jadwal :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lokasi :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Deskripsi :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbLoc
            // 
            this.tbLoc.Location = new System.Drawing.Point(159, 138);
            this.tbLoc.Name = "tbLoc";
            this.tbLoc.ReadOnly = true;
            this.tbLoc.Size = new System.Drawing.Size(188, 26);
            this.tbLoc.TabIndex = 11;
            // 
            // rtbDesc
            // 
            this.rtbDesc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rtbDesc.Location = new System.Drawing.Point(159, 177);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.ReadOnly = true;
            this.rtbDesc.Size = new System.Drawing.Size(297, 83);
            this.rtbDesc.TabIndex = 12;
            this.rtbDesc.Text = "";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitle.Location = new System.Drawing.Point(112, 60);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(264, 46);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "<kegiatan>";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 358);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rtbDesc);
            this.Controls.Add(this.tbLoc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Alarm";
            this.Text = "Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbLoc;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.Label lblTitle;
    }
}