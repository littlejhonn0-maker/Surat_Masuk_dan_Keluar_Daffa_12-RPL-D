using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace Surat_Masuk_dan_Keluar_Daffa_12_RPL_D
{
    class DB
    {
        
           public static MySqlConnection koneksi = new MySqlConnection
            ("Server = 127.0.0.1; username = root; password = ; database =db_km");

            public static DataSet ds = new DataSet();
            public static MySqlDataAdapter da;
            public static MySqlCommand perintah;

            public static void crud(string querynya)
            {
                Console.WriteLine(querynya);
                ds.Tables.Clear();
                perintah = new MySqlCommand(querynya, koneksi);
                da = new MySqlDataAdapter(perintah);
                da.Fill(ds);
            }
        
    }
}
