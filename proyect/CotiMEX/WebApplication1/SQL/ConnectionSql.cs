using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace WebApplication1.SQL
{
    //TODO return dataset
    public class ConnectionSql
    {
        private static string DB_CONN_STR = @"server=localhost;Uid=root;persistsecurityinfo=True;pwd=password123;database=cotimex";

        //TODO load from properties connection string
        public DataSet connectionSql(string query)
        { 

            MySqlConnection cn = new MySqlConnection(DB_CONN_STR);
            try
            {

                string sqlCmd = query;

                cn.Open(); // have to explicitly open connection (fetches from pool)

                MySqlCommand cmd = new MySqlCommand(sqlCmd, cn);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(string.Format("user_id = {0}", rdr["user_id"].ToString()));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("{oops - {0}", ex.Message);
            }
            finally
            {
                cn.Dispose(); // return connection to the pool
            }
            Console.WriteLine("press any key...");
            Console.ReadKey();
            return null;
        }
    }
}