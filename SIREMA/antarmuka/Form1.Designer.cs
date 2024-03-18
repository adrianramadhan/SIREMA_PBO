namespace SIREMA
{
    partial class Form1
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
            this.kode_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.namaJurusan_txt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.jurusan_dgv = new System.Windows.Forms.DataGridView();
            this.cKode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batal_btn = new System.Windows.Forms.Button();
            this.keluar_btn = new System.Windows.Forms.Button();
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.getKode_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jurusan_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // kode_txt
            // 
            this.kode_txt.Enabled = false;
            this.kode_txt.Location = new System.Drawing.Point(220, 49);
            this.kode_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kode_txt.Name = "kode_txt";
            this.kode_txt.Size = new System.Drawing.Size(132, 22);
            this.kode_txt.TabIndex = 0;
            this.kode_txt.TextChanged += new System.EventHandler(this.kode_txt_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 47);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cek";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "KODE JURUSAN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "NAMA JURUSAN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // namaJurusan_txt
            // 
            this.namaJurusan_txt.Location = new System.Drawing.Point(220, 96);
            this.namaJurusan_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.namaJurusan_txt.Name = "namaJurusan_txt";
            this.namaJurusan_txt.Size = new System.Drawing.Size(260, 22);
            this.namaJurusan_txt.TabIndex = 0;
            this.namaJurusan_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 139);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "SIMPAN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hapus_btn
            // 
            this.hapus_btn.Location = new System.Drawing.Point(177, 139);
            this.hapus_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(100, 28);
            this.hapus_btn.TabIndex = 6;
            this.hapus_btn.Text = "HAPUS";
            this.hapus_btn.UseVisualStyleBackColor = true;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // jurusan_dgv
            // 
            this.jurusan_dgv.AllowUserToAddRows = false;
            this.jurusan_dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jurusan_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.jurusan_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jurusan_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cKode,
            this.cNama});
            this.jurusan_dgv.Location = new System.Drawing.Point(55, 255);
            this.jurusan_dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jurusan_dgv.Name = "jurusan_dgv";
            this.jurusan_dgv.ReadOnly = true;
            this.jurusan_dgv.RowHeadersWidth = 51;
            this.jurusan_dgv.Size = new System.Drawing.Size(668, 162);
            this.jurusan_dgv.TabIndex = 7;
            this.jurusan_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jurusan_dgv_CellClick);
            this.jurusan_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jurusan_dgv_CellContentClick);
            // 
            // cKode
            // 
            this.cKode.DataPropertyName = "kode_jurusan";
            this.cKode.HeaderText = "KODE JURUSAN";
            this.cKode.MinimumWidth = 6;
            this.cKode.Name = "cKode";
            this.cKode.ReadOnly = true;
            this.cKode.Width = 250;
            // 
            // cNama
            // 
            this.cNama.DataPropertyName = "nama_jurusan";
            this.cNama.HeaderText = "NAMA JURUSAN";
            this.cNama.MinimumWidth = 6;
            this.cNama.Name = "cNama";
            this.cNama.ReadOnly = true;
            this.cNama.Width = 250;
            // 
            // batal_btn
            // 
            this.batal_btn.Location = new System.Drawing.Point(312, 139);
            this.batal_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Size = new System.Drawing.Size(100, 28);
            this.batal_btn.TabIndex = 8;
            this.batal_btn.Text = "BATAL";
            this.batal_btn.UseVisualStyleBackColor = true;
            this.batal_btn.Click += new System.EventHandler(this.batal_btn_Click);
            // 
            // keluar_btn
            // 
            this.keluar_btn.Location = new System.Drawing.Point(433, 139);
            this.keluar_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.keluar_btn.Name = "keluar_btn";
            this.keluar_btn.Size = new System.Drawing.Size(100, 28);
            this.keluar_btn.TabIndex = 9;
            this.keluar_btn.Text = "KELUAR";
            this.keluar_btn.UseVisualStyleBackColor = true;
            this.keluar_btn.Click += new System.EventHandler(this.keluar_btn_Click);
            // 
            // cari_txt
            // 
            this.cari_txt.Location = new System.Drawing.Point(55, 219);
            this.cari_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(667, 22);
            this.cari_txt.TabIndex = 10;
            this.cari_txt.TextChanged += new System.EventHandler(this.cari_txt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "pencarian berdasarkan nama";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // getKode_btn
            // 
            this.getKode_btn.Location = new System.Drawing.Point(560, 139);
            this.getKode_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getKode_btn.Name = "getKode_btn";
            this.getKode_btn.Size = new System.Drawing.Size(100, 28);
            this.getKode_btn.TabIndex = 12;
            this.getKode_btn.Text = "Get Kode";
            this.getKode_btn.UseVisualStyleBackColor = true;
            this.getKode_btn.Click += new System.EventHandler(this.getKode_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 453);
            this.Controls.Add(this.getKode_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cari_txt);
            this.Controls.Add(this.keluar_btn);
            this.Controls.Add(this.batal_btn);
            this.Controls.Add(this.jurusan_dgv);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.namaJurusan_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kode_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.jurusan_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kode_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox namaJurusan_txt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.DataGridView jurusan_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNama;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.Button keluar_btn;
        private System.Windows.Forms.TextBox cari_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button getKode_btn;
    }
}

