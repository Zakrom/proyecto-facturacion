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
        //Connection string which has password user and other specifications
        private static string DB_CONN_STR = @"server=localhost;Uid=root;persistsecurityinfo=True;pwd=password123;database=cotimex";
         


        public static DataSet selectQuery(string query)
        { 

            MySqlConnection cn = new MySqlConnection(DB_CONN_STR);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            try
            {

                string sqlCmd = query;

                cn.Open(); // have to explicitly open connection (fetches from pool)

                //query with connection to run
                MySqlCommand cmd = new MySqlCommand(sqlCmd, cn);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader rdr = cmd.ExecuteReader();
                ds.Tables.Add(dt);
                ds.EnforceConstraints = false;
                dt.Load(rdr);
            }
            catch (Exception ex)
            {
                cn.Close();
                throw new Exception(ex.Message);
            }
           
                //Close connection whatever happens
                cn.Close();
            return ds;
        }


        // Executes querys wich won't return a  ResultSet
        public static int updateQuery(string query)
        {
            MySqlConnection conn = new MySqlConnection(DB_CONN_STR);
            int rowsAffected = 0;
            try
            { 
                conn.Open();

                string sql = query;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                 rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            Console.WriteLine("Done.");
            return rowsAffected;
        } 

    }
}