namespace SIREMA.antarmuka
{
    partial class ProgramStudi_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.keluar_btn = new System.Windows.Forms.Button();
            this.batal_btn = new System.Windows.Forms.Button();
            this.prodi_dgv = new System.Windows.Forms.DataGridView();
            this.cKodeProdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNamaProdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNamaJurusan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.namaProdi_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kode_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.namaJurusan_cmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.prodi_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "pencarian berdasarkan nama prodi";
            // 
            // cari_txt
            // 
            this.cari_txt.Location = new System.Drawing.Point(59, 201);
            this.cari_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(785, 22);
            this.cari_txt.TabIndex = 23;
            this.cari_txt.TextChanged += new System.EventHandler(this.cari_txt_TextChanged);
            // 
            // keluar_btn
            // 
            this.keluar_btn.Location = new System.Drawing.Point(437, 142);
            this.keluar_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.keluar_btn.Name = "keluar_btn";
            this.keluar_btn.Size = new System.Drawing.Size(100, 28);
            this.keluar_btn.TabIndex = 22;
            this.keluar_btn.Text = "KELUAR";
            this.keluar_btn.UseVisualStyleBackColor = true;
            this.keluar_btn.Click += new System.EventHandler(this.keluar_btn_Click);
            // 
            // batal_btn
            // 
            this.batal_btn.Location = new System.Drawing.Point(316, 142);
            this.batal_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Size = new System.Drawing.Size(100, 28);
            this.batal_btn.TabIndex = 21;
            this.batal_btn.Text = "BATAL";
            this.batal_btn.UseVisualStyleBackColor = true;
            // 
            // prodi_dgv
            // 
            this.prodi_dgv.AllowUserToAddRows = false;
            this.prodi_dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodi_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.prodi_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodi_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cKodeProdi,
            this.cNamaProdi,
            this.cNamaJurusan});
            this.prodi_dgv.Location = new System.Drawing.Point(59, 236);
            this.prodi_dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prodi_dgv.Name = "prodi_dgv";
            this.prodi_dgv.ReadOnly = true;
            this.prodi_dgv.RowHeadersWidth = 51;
            this.prodi_dgv.Size = new System.Drawing.Size(787, 162);
            this.prodi_dgv.TabIndex = 20;
            this.prodi_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodi_dgv_CellClick);
            // 
            // cKodeProdi
            // 
            this.cKodeProdi.DataPropertyName = "kode_prodi";
            this.cKodeProdi.HeaderText = "KODE PRODI";
            this.cKodeProdi.MinimumWidth = 6;
            this.cKodeProdi.Name = "cKodeProdi";
            this.cKodeProdi.ReadOnly = true;
            this.cKodeProdi.Width = 125;
            // 
            // cNamaProdi
            // 
            this.cNamaProdi.DataPropertyName = "nama_prodi";
            this.cNamaProdi.HeaderText = "NAMA PRODI";
            this.cNamaProdi.MinimumWidth = 6;
            this.cNamaProdi.Name = "cNamaProdi";
            this.cNamaProdi.ReadOnly = true;
            this.cNamaProdi.Width = 200;
            // 
            // cNamaJurusan
            // 
            this.cNamaJurusan.DataPropertyName = "nama_jurusan";
            this.cNamaJurusan.HeaderText = "NAMA JURUSAN";
            this.cNamaJurusan.MinimumWidth = 6;
            this.cNamaJurusan.Name = "cNamaJurusan";
            this.cNamaJurusan.ReadOnly = true;
            this.cNamaJurusan.Width = 250;
            // 
            // hapus_btn
            // 
            this.hapus_btn.Location = new System.Drawing.Point(181, 142);
            this.hapus_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(100, 28);
            this.hapus_btn.TabIndex = 19;
            this.hapus_btn.Text = "HAPUS";
            this.hapus_btn.UseVisualStyleBackColor = true;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // simpan_btn
            // 
            this.simpan_btn.Location = new System.Drawing.Point(59, 142);
            this.simpan_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(100, 28);
            this.simpan_btn.TabIndex = 18;
            this.simpan_btn.Text = "SIMPAN";
            this.simpan_btn.UseVisualStyleBackColor = true;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // namaProdi_txt
            // 
            this.namaProdi_txt.Location = new System.Drawing.Point(224, 68);
            this.namaProdi_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.namaProdi_txt.Name = "namaProdi_txt";
            this.namaProdi_txt.Size = new System.Drawing.Size(312, 22);
            this.namaProdi_txt.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "NAMA PRODI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "KODE PRODI";
            // 
            // kode_txt
            // 
            this.kode_txt.Enabled = false;
            this.kode_txt.Location = new System.Drawing.Point(224, 31);
            this.kode_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kode_txt.Name = "kode_txt";
            this.kode_txt.Size = new System.Drawing.Size(132, 22);
            this.kode_txt.TabIndex = 14;
            this.kode_txt.TextChanged += new System.EventHandler(this.kode_txt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "NAMA JURUSAN";
            // 
            // namaJurusan_cmb
            // 
            this.namaJurusan_cmb.FormattingEnabled = true;
            this.namaJurusan_cmb.Location = new System.Drawing.Point(224, 107);
            this.namaJurusan_cmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.namaJurusan_cmb.Name = "namaJurusan_cmb";
            this.namaJurusan_cmb.Size = new System.Drawing.Size(312, 24);
            this.namaJurusan_cmb.TabIndex = 28;
            this.namaJurusan_cmb.SelectedIndexChanged += new System.EventHandler(this.namaJurusan_cmb_SelectedIndexChanged);
            // 
            // ProgramStudi_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 427);
            this.Controls.Add(this.namaJurusan_cmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cari_txt);
            this.Controls.Add(this.keluar_btn);
            this.Controls.Add(this.batal_btn);
            this.Controls.Add(this.prodi_dgv);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.namaProdi_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kode_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProgramStudi_Form";
            this.Text = "ProgramStudi_Form";
            this.Load += new System.EventHandler(this.ProgramStudi_Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProgramStudi_Form_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.prodi_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cari_txt;
        private System.Windows.Forms.Button keluar_btn;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.DataGridView prodi_dgv;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.TextBox namaProdi_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kode_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox namaJurusan_cmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKodeProdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNamaProdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNamaJurusan;
    }
}