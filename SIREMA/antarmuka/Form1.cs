using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIREMA.model; // koneksi ke model

namespace SIREMA
{
    public partial class Form1 : Form
    {
        JurusanCls jurusan = new JurusanCls();
        public Form1()
        {
            InitializeComponent();
        }

        void tampilGrid()
        {
            if (cari_txt.Text == "")
            {
                jurusan_dgv.DataSource = jurusan.tampilSemua();
            }
            else
            {
                jurusan_dgv.DataSource = jurusan.cariNama(cari_txt.Text);
            }
            belangBelang(jurusan_dgv);
        }

        void belangBelang(DataGridView dgv)
        {
            foreach(DataGridViewRow baris in dgv.Rows)
            {
                foreach(DataGridViewCell kolom in baris.Cells)
                {
                    if (baris.Index %2 == 1)
                    {
                        kolom.Style.BackColor = Color.WhiteSmoke;
                    }
                    else
                    {
                        kolom.Style.BackColor = Color.LightGray;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jurusan.apakahAda(kode_txt.Text))
            {
                MessageBox.Show("Data sudah ada");
            }
            else
            {
                MessageBox.Show("Data tidak ada");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void bersihkan()
        {
            kode_txt.Text=jurusan.buatKode();
            namaJurusan_txt.Clear();
            namaJurusan_txt.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!jurusan.apakahAda(kode_txt.Text))
            {
                jurusan.setKode_Jurusan = kode_txt.Text;
                jurusan.setNamaJurusan = namaJurusan_txt.Text;
                

                if(jurusan.simpanData()>0)
                {
                    MessageBox.Show("Data berhasil disimpan.",
                        "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    bersihkan();
                    kode_txt.Focus();
                    tampilGrid();
                }
                else
                {
                    MessageBox.Show("Data gagal disimpan.",
                        "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    bersihkan();
                    kode_txt.Focus();
                    tampilGrid();
                }
            }
            else
            {
                if (MessageBox.Show("Apakah data akan diubah?",
                    "KONFIRMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    jurusan.setNamaJurusan = namaJurusan_txt.Text;
                    if (jurusan.ubahData(kode_txt.Text) > 0)
                    {
                        MessageBox.Show("Data berhasil diubah.",
                            "INFORMASI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        bersihkan();
                        kode_txt.Focus();
                        tampilGrid();
                    }
                }
            }
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (jurusan.apakahAda(kode_txt.Text))
            {
                if (MessageBox.Show("Apakah yakin akan menghapus data?",
                    "KONFIRMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (jurusan.hapusData(kode_txt.Text) > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus.",
                            "INFORMASI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        bersihkan();
                        kode_txt.Focus();
                        tampilGrid();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tampilGrid();
            bersihkan();
        }

        private void jurusan_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.jurusan_dgv.Rows[e.RowIndex];
            kode_txt.Text = baris.Cells[0].Value.ToString();
            namaJurusan_txt.Text = baris.Cells[1].Value.ToString();
        }

        // menyimpan dan menghapus menggnakan keyboard
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.S && e.Control)
            {
                button2.PerformClick();
            }
            else if (e.KeyCode == Keys.H && e.Control)
            {
                hapus_btn.PerformClick();
            }
        }

        private void cari_txt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void getKode_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jurusan.ambilKodeDgnNama(namaJurusan_txt.Text));
        }

        private void kode_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void keluar_btn_Click(object sender, EventArgs e)
        {

        }

        private void batal_btn_Click(object sender, EventArgs e)
        {

        }

        private void jurusan_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
