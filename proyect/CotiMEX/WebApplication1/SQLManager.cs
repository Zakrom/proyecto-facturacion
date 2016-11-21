using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Descripción breve de SQLManager
/// </summary>
public class SQLManager
{

    public static DataSet RunStoredProcedure(
        string spName, params SqlParameter[] parameters)
    {

        DataSet dataSet = null;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;

        string connectionString = @"server=localhost;Uid=root;persistsecurityinfo=True;pwd=brenda407;database=cotimex";
        SqlConnection conn = new SqlConnection(connectionString);

        try
        {
            conn.Open();
            sqlCommand = new SqlCommand(spName, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter sqlParam in parameters)
            {
                sqlCommand.Parameters.Add(sqlParam);
            }
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            conn.Close();

        }
        catch
        {
            Console.WriteLine();
            dataSet = null;
        }
        return dataSet;

    }

}