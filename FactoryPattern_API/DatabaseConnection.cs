
using System;
using System.Text;
using System.Data.SqlClient;

namespace FactoryPattern_API
{
    public class DatabaseConnection 
    {
        public SqlConnection SQLConnection()
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                LogManager.Instance.WriteLog("---Inside DatabaseConnection---");
                // Build connection string
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";   // update me
                builder.UserID = "sa";              // update me
                builder.Password = "test123!@#";      // update me
                builder.InitialCatalog = "ProductDB"; 
                // Connect to SQL
                Console.Write("Connecting to SQL Server ... ");
                connection = new SqlConnection(builder.ConnectionString); 
                    connection.Open();
                    Console.WriteLine("Connection Established!!!");
                    return connection; 
            }
            catch (SqlException e)
            {
                LogManager.Instance.WriteLog("---Exception caught while establishing connection with DB---");
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("All done. Press any key to finish...");
            Console.ReadKey(false);
            return connection;
        }
    }
}