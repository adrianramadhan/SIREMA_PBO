using SIREMA.model;
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

namespace SIREMA.antarmuka
{
    public partial class ProgramStudi_Form : Form
    {
        ProdiCls prodi = new ProdiCls();
        public ProgramStudi_Form()
        {
            InitializeComponent();
        }

        void tampilGrid()
        {
            if (cari_txt.Text == "")
            {
                prodi_dgv.DataSource = prodi.tampilSemua();
            }
            else
            {
                prodi_dgv.DataSource = prodi.cariNama(cari_txt.Text);
            }
            belangBelang(prodi_dgv);
        }

        void belangBelang(DataGridView dgv)
        {
            foreach (DataGridViewRow baris in dgv.Rows)
            {
                foreach (DataGridViewCell kolom in baris.Cells)
                {
                    if (baris.Index % 2 == 1)
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


        private void kode_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProgramStudi_Form_Load(object sender, EventArgs e)
        {
            tampilDataJurusan();
            tampilGrid();
            bersihkan();
        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            if (!prodi.apakahAda(kode_txt.Text))
            {
                prodi.setKodeProdi = kode_txt.Text;
                prodi.setNamaProdi = namaProdi_txt.Text;
                prodi.setNamaJurusan = namaJurusan_cmb.Text;

                if (prodi.simpanData() > 0)
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
                    prodi.setKodeProdi = kode_txt.Text;
                    prodi.setNamaProdi = namaProdi_txt.Text;
                    prodi.setNamaJurusan = namaJurusan_cmb.Text;

                    if (prodi.ubahData(kode_txt.Text) > 0)
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
            if (prodi.apakahAda(kode_txt.Text))
            {
                if (MessageBox.Show("Apakah yakin akan menghapus data?",
                    "KONFIRMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (prodi.hapusData(kode_txt.Text) > 0)
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

        private void prodi_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.prodi_dgv.Rows[e.RowIndex];
            kode_txt.Text = baris.Cells[0].Value.ToString();
            namaProdi_txt.Text = baris.Cells[1].Value.ToString();
            string jurusanValue = baris.Cells[2].Value.ToString();
            int index = namaJurusan_cmb.FindStringExact(jurusanValue);
            if (index != -1)
            {
                namaJurusan_cmb.SelectedIndex = index;
            }
        }

        private void ProgramStudi_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                simpan_btn.PerformClick();
            }
            else if (e.KeyCode == Keys.H && e.Control)
            {
                hapus_btn.PerformClick();
            }
        }

        private void namaJurusan_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        // menampilkan data jurusan dropdown
        private void tampilDataJurusan()
        {
            {
                DataTable tampilJurusan = prodi.dataJurusan();
                namaJurusan_cmb.DataSource = tampilJurusan;
                namaJurusan_cmb.DisplayMember = "nama_jurusan";
                namaJurusan_cmb.ValueMember = "nama_jurusan";
            }
        }

        private void keluar_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cari_txt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        void bersihkan()
        {
            kode_txt.Text = prodi.buatKode();
            namaProdi_txt.Clear();
            namaProdi_txt.Focus();
        }
    }
}