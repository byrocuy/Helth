namespace Helth
{
    partial class Histori
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Histori));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKembali = new System.Windows.Forms.Button();
            this.jadwalDBDataSet = new Helth.JadwalDBDataSet();
            this.jadwalDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jadwalDBTableAdapter = new Helth.JadwalDBDataSetTableAdapters.JadwalDBTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jadwalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hariTanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(234, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jadwal Saya";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.jadwalDataGridViewTextBoxColumn,
            this.jamDataGridViewTextBoxColumn,
            this.hariTanggalDataGridViewTextBoxColumn,
            this.lokasiDataGridViewTextBoxColumn,
            this.deskripsiDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.jadwalDBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(650, 262);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(558, 356);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(118, 45);
            this.btnKembali.TabIndex = 2;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // jadwalDBDataSet
            // 
            this.jadwalDBDataSet.DataSetName = "JadwalDBDataSet";
            this.jadwalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jadwalDBBindingSource
            // 
            this.jadwalDBBindingSource.DataMember = "JadwalDB";
            this.jadwalDBBindingSource.DataSource = this.jadwalDBDataSet;
            // 
            // jadwalDBTableAdapter
            // 
            this.jadwalDBTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // jadwalDataGridViewTextBoxColumn
            // 
            this.jadwalDataGridViewTextBoxColumn.DataPropertyName = "Jadwal";
            this.jadwalDataGridViewTextBoxColumn.HeaderText = "Jadwal";
            this.jadwalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jadwalDataGridViewTextBoxColumn.Name = "jadwalDataGridViewTextBoxColumn";
            this.jadwalDataGridViewTextBoxColumn.Width = 150;
            // 
            // jamDataGridViewTextBoxColumn
            // 
            this.jamDataGridViewTextBoxColumn.DataPropertyName = "Jam";
            this.jamDataGridViewTextBoxColumn.FillWeight = 50F;
            this.jamDataGridViewTextBoxColumn.HeaderText = "Jam";
            this.jamDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jamDataGridViewTextBoxColumn.Name = "jamDataGridViewTextBoxColumn";
            this.jamDataGridViewTextBoxColumn.Width = 150;
            // 
            // hariTanggalDataGridViewTextBoxColumn
            // 
            this.hariTanggalDataGridViewTextBoxColumn.DataPropertyName = "Hari/Tanggal";
            this.hariTanggalDataGridViewTextBoxColumn.HeaderText = "Hari/Tanggal";
            this.hariTanggalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hariTanggalDataGridViewTextBoxColumn.Name = "hariTanggalDataGridViewTextBoxColumn";
            this.hariTanggalDataGridViewTextBoxColumn.Width = 150;
            // 
            // lokasiDataGridViewTextBoxColumn
            // 
            this.lokasiDataGridViewTextBoxColumn.DataPropertyName = "Lokasi";
            this.lokasiDataGridViewTextBoxColumn.HeaderText = "Lokasi";
            this.lokasiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lokasiDataGridViewTextBoxColumn.Name = "lokasiDataGridViewTextBoxColumn";
            this.lokasiDataGridViewTextBoxColumn.Width = 150;
            // 
            // deskripsiDataGridViewTextBoxColumn
            // 
            this.deskripsiDataGridViewTextBoxColumn.DataPropertyName = "Deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.HeaderText = "Deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deskripsiDataGridViewTextBoxColumn.Name = "deskripsiDataGridViewTextBoxColumn";
            this.deskripsiDataGridViewTextBoxColumn.Width = 150;
            // 
            // Histori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 416);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Histori";
            this.Text = "Histori";
            this.Load += new System.EventHandler(this.Histori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalDBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKembali;
        private JadwalDBDataSet jadwalDBDataSet;
        private System.Windows.Forms.BindingSource jadwalDBBindingSource;
        private JadwalDBDataSetTableAdapters.JadwalDBTableAdapter jadwalDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jadwalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hariTanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiDataGridViewTextBoxColumn;
    }
}