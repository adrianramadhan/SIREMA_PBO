using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIREMA.konfigurasi; // harus menyebutkan projek 'SIREMA'

namespace SIREMA.model
{
    using System.Data;
    using System.Windows.Forms;

    internal class ProdiCls
    {
        private string kode_prodi;
        private string nama_prodi;
        private string nama_jurusan;

        LayananCls server;
        DataTable temp;
        string Query;
        
        public ProdiCls()
        {
            kode_prodi = "";
            nama_prodi = "";
            nama_jurusan = "";

            server = new LayananCls();
            temp = new DataTable();
            Query = "";

        }

        //property
        public string setKodeProdi
        {
            set { kode_prodi = value; } // untuk setting data
            // get { return kode_jurusan; } // mengambil data
        }
        public string setNamaProdi
        {
            set { nama_prodi = value; }
        }
        public string setNamaJurusan
        {
            set { nama_jurusan = value; }
        }


        // menampilkan semua data yang ada di database
        public DataTable tampilSemua()
        {
            Query = "select a.kode_prodi, a.nama_prodi, b.nama_jurusan " +
                "from prodi a, jurusan b where a.kode_jurusan = b.kode_jurusan";

            return server.eksekusiQuery(Query);
        }  

        public DataTable dataJurusan ()
        {
            Query = "SELECT nama_jurusan from jurusan";
            return server.eksekusiQuery( Query );
        }

        //  fungsi validasi data
        public bool apakahAda(string kode) // kode parameter
        {
            bool cek = false;
            Query = "select * from prodi where kode_prodi='" + kode + "'";
            temp = server.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }
        // Hapus data
        public int hapusData(string kode)
        {
            int result = -1;
            Query = "delete from prodi where kode_prodi='" + kode + "'";

            try
            {
                result = server.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal menghapus data");
                }
            }
            catch (Exception e) { }

            return result;
        }
        // KODE PRODI SECARA OTOMATIS
        public string buatKode()
        {
            string kode = "";
            int nilai = 0;

            Query = "SELECT IFNULL (MAX(kode_prodi),0)+1 AS kode FROM prodi";
            temp = server.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    nilai = Convert.ToInt32(data[0]);
                }
                if (nilai > 0 && nilai < 10)
                {
                    kode = "0" + nilai.ToString();
                }
                else if (nilai >= 10 && nilai < 100)
                {
                    kode = nilai.ToString();
                }
            }
            return kode;
        }

        // fitur search
        public DataTable cariNama(string nama)
        {
            Query = "select a.kode_prodi, a.nama_prodi, b.nama_jurusan " +
                "FROM prodi a " + 
                "INNER JOIN jurusan b ON a.kode_jurusan = b.kode_jurusan " +
                "WHERE a.nama_prodi LIKE '%" + nama + "%'";
            return server.eksekusiQuery(Query);
        }

        // 
        public string ambilKodeDgnNama(string nama)
        {
            string kode = "";

            Query = "select kode_prodi from prodi where" +
                " nama_prodi='" + nama + "'";
            temp = server.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    kode = data[0].ToString();
                }
            }
            return kode;
        }

        //SIMPAN DATA
        private string getKode(string nama)
        {
            string kode = string.Empty;
            Query = "SELECT kode_jurusan FROM jurusan WHERE nama_jurusan = '" + nama + "'";
            DataTable result = server.eksekusiQuery(Query);

            if (result.Rows.Count > 0)
            {

                kode = result.Rows[0]["kode_jurusan"].ToString();
            }

            return kode;
        }

        public int simpanData()
        {
            int result = -1;

            // Retrieve kode_jurusan based on selected nama_jurusan
            string kode = getKode(nama_jurusan);

            // Ensure kode_jurusan is not null or empty
            if (string.IsNullOrEmpty(kode))
            {
                // Handle the case where kode_jurusan is not found
                throw new Exception("Kode Jurusan not found for selected nama_jurusan.");
            }

            Query = "INSERT INTO prodi (kode_prodi, nama_prodi, kode_jurusan) VALUES ('" + kode_prodi + "', '" + nama_prodi + "', '" + kode + "')";

            try
            {
                result = server.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal Menyimpan.");
                }
            }
            catch (Exception e)
            {

            }
            return result;
        }

        // Update data ---> Mengubah data yang ada
        public int ubahData(string kode)
        {
            int result = -1;
            string kodeJur = getKode(nama_jurusan);
            Query = "UPDATE prodi set nama_prodi='" + nama_prodi + "', kode_jurusan='" + kodeJur + "' where kode_prodi='" + kode + "'";

            try
            {
                result = server.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal mengubah data");
                }
            }
            catch (Exception e) { }

            return result;
        }
        
    }
}