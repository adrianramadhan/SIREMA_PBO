using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // koneksi database
using System.IO;
using Akses_File;

namespace SIREMA.konfigurasi
{
    
    class LayananCls:KonfigurasiCls
    {
        MySqlConnection mCon;
        MySqlCommand mCom;
        MySqlDataAdapter mAdp;

        string link = "server=localhost;port=3306;database=sirema;uid=root;pwd=";

        //constructor
        public LayananCls()
        {
            mCon = new MySqlConnection(getLink()); //mengkoneksikan database
            mCom = new MySqlCommand();  // memberikan perintah
            mAdp = new MySqlDataAdapter(); //menampung data hasil select
        }

        string getLink()
        {
            string[] data=File.ReadAllLines(@"F:\Kuliah\Semester 4\PBO\pemrograman-c#\konfig.txt");
            return data[0]+ data[1]+ data[2]+ data[3]+ data[4];
        }

        void bukaKoneksi()
        {
            try
            {
                if (mCon.State == ConnectionState.Closed)
                {
                    mCon.Open();
                }
            } catch (Exception e) { }
        }

        void tutupKoneksi()
        {
            mCon.Close();
        }

        // mengeksekusi insert, update, delete
        public override int eksekusiNonQuery(string query)
        {
            int result = -1;

            try
            {
                bukaKoneksi();
                mCom.Connection = mCon;
                mCom.CommandText = query;
                result = mCom.ExecuteNonQuery(); 

            }
            catch (Exception e) { }

            finally
            {
                tutupKoneksi();
            }

            return result;
        }

        // untuk select
        public override DataTable eksekusiQuery(string query)
        {
            DataTable result = new DataTable();

            try
            {
                bukaKoneksi();
                mCom.Connection = mCon;
                mCom.CommandText = query;
                mAdp.SelectCommand = mCom;
                mAdp.Fill(result);

            } catch (Exception e) { }

            finally
            {
                tutupKoneksi();
            }

            return result;
        }
    }
}
