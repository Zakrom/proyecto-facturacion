using System; 
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.SQL;
using MySql.Data.MySqlClient;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        private static string cs = @"Uid=root; persistsecurityinfo=True;Password=password123;database=cotimex";

        [TestMethod]
        public void TestMethod1()
        {
            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(@"server=localhost;Uid=root;persistsecurityinfo=True;pwd=password123;database=cotimex");
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
