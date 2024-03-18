using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SIREMA.konfigurasi
{
    abstract class KonfigurasiCls
    {
        // untuk menangani intruksi SELECT
        public abstract DataTable eksekusiQuery(string query);

        // untuk menangani instruksi INSERT, UPDATE, DELETE
        public abstract int eksekusiNonQuery(string query);
    }
}
