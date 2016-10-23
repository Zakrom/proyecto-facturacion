using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.SQL
{
    public class ConnectionSql
    {
        private static string cs = @"server=localhost;Uid=root;persistsecurityinfo=True;pwd=password123;database=cotimex";

        //TODO load from properties connection string
        public ConnectionSql()
        {

        }

        public static void Main()
        {

            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                Console.WriteLine("Connection initialized");
                Console.WriteLine("MySQL version : {0}", conn.ServerVersion);

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    Console.WriteLine("Connection closed");
                }
            }
        }
    }
}