using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace FactoryPattern_API
{
    class DatabaseAccess : IDatabase
    {

        public void EnterBookingDetails(string NameOfProduct, int PriceOfProduct, string TableName)
        {
            LogManager.Instance.WriteLog("---Inside Database Access/Save---");

            DatabaseConnection databaseConnection = new DatabaseConnection();
            SqlConnection connection = databaseConnection.SQLConnection();

            string query = "Insert into " + TableName + " (Name, Price, isBooked) values ('" + NameOfProduct + "', '" + PriceOfProduct + "', 0)";
            SqlCommand myCommand = new SqlCommand(query, connection);
            myCommand.ExecuteNonQuery();
        }

        public void UpdateBookingDetails(string NameOfProduct, int PriceOfProduct, string TableName)
        {
            LogManager.Instance.WriteLog("---Inside Database Access/Book---");
            DatabaseConnection databaseConnection = new DatabaseConnection();
            SqlConnection connection = databaseConnection.SQLConnection();

            string checkQuery = "Select * from " + TableName + " where Name= '" + NameOfProduct+ " '";
            SqlCommand myCommand1 = new SqlCommand(checkQuery, connection);
            if (myCommand1.ExecuteNonQuery() > 0)
            { 
                string query = "Update " + TableName + " set isBooked = " + 1 + " where Name ='" + NameOfProduct+ " '";
                SqlCommand myCommand = new SqlCommand(query, connection);
                myCommand.ExecuteNonQuery();
            }
            else
                Console.WriteLine("Sorry! The Data you entered does not exists!");
        }
    }
}
