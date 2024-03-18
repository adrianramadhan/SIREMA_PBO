using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using SIREMA.konfigurasi; // harus menyebutkan projek 'SIREMA'


namespace SIREMA.model
{
    // using konfigurasi; // tidak menyebutkan 'SIREMA'
    using System.Data;

    //package
    internal class JurusanCls
    {
        private string kode_jurusan;
        private string nama_jurusan;

        LayananCls server;
        DataTable temp;
        string Query;

        public JurusanCls()
        {
            kode_jurusan = "";
            nama_jurusan = "";
            server = new LayananCls();
            temp = new DataTable();
            Query = "";
        }

        //property
        public string setKode_Jurusan
        {
            set { kode_jurusan = value; } // untuk setting data
            // get { return kode_jurusan; } // mengambil data
        }
        public string setNamaJurusan
        {
            set {  nama_jurusan = value; }
        }

        //  fungsi validasi data
        public bool apakahAda(string kode) // kode parameter
        {
            bool cek = false;
            Query = "select * from jurusan where kode_jurusan='" + kode + "'";
            temp = server.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        // menyimpan data ke database
        public int simpanData()
        {
            int result = -1;
            Query = "insert into jurusan values ('" + kode_jurusan + "','" + nama_jurusan +"')";

            try
            {
                result = server.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal menyimpan");
                }
            } 
            catch (Exception e) { }

            return result;
        }

        // Update data ---> Mengubah data yang ada
        public int ubahData(string kode)
        {
            int result = -1;
            Query = "update jurusan set nama_jurusan='" +
                nama_jurusan + "'where kode_jurusan='" +
                kode + "'";

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

        // Hapus data
        public int hapusData(string kode)
        {
            int result = -1;
            Query = "delete from jurusan where kode_jurusan='" + kode + "'";

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

        // MENAMPILKAN SEMUA DATA
        public DataTable tampilSemua ()
        {
            Query = "select * from jurusan";

            return server.eksekusiQuery(Query);
        }

        // KODE JURUSAN SECARA OTOMATIS
        public string buatKode()
        {
            string kode = "";
            int nilai = 0;

            Query = "SELECT IFNULL (MAX(kode_jurusan),0)+1 AS kode FROM jurusan";
            temp = server.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    nilai = Convert.ToInt32(data[0]);
                }
                if (nilai>0 && nilai < 10)
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
            Query = "select *from jurusan where nama_jurusan like '%" + nama + "%'";
            return server.eksekusiQuery(Query) ;
        }

        // 
        public string ambilKodeDgnNama(string nama)
        {
            string kode = "";

            Query = "select kode_jurusan from jurusan where" +
                " nama_jurusan='" + nama + "'";
            temp = server.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach(DataRow data in temp.Rows)
                {
                    kode = data[0].ToString();
                }
            }
            return kode;
        }
        
    }
}