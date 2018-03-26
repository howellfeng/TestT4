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
            Console.WriteLine(Guid.NewGuid().ToString());
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
        public static List<Field> GetFields(string connectionString, string database, string table)
        {
            var result = new List<Field>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter($"select * from information_schema.COLUMNS where table_name={table}", conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        foreach (DataRow dr in dt.Rows)
                        {
                            Field field = new Field() { Name = dr["COLUMN_NAME"].ToString(), Comment = dr["COLUMN_COMMENT"].ToString() };
                            result.Add(field);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
            return result;
        }
        public class Field
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public string Comment { get; set; }
        }
    }
}
