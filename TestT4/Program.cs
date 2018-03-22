using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestT4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MySqlConnection conn = new MySqlConnection("Server=192.168.14.124;Port=3306;Database=test1;Uid=root;Pwd=root;Character Set=utf8;"))
            {
                //using (MySqlDataAdapter adapter = new MySqlDataAdapter("select * from yz_ship_info", conn))
                //{
                //    DataTable dt = new DataTable();
                //    adapter.Fill(dt);
                //    Console.WriteLine(dt.Rows.Count);
                //}
                MySqlCommand cmd = new MySqlCommand("", conn);
                cmd.ExecuteReader();
            }
        }
    }
}
