using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_API
{
    class Constants
    {
        public void WelcomeMessage()
        {
            Console.WriteLine("----DESIGN PATTERNS ASSIGNMENT----");
            LogManager.Instance.WriteLog("---Inside Constants/WelcomeMessage---");
        }
        public void ShowDiscounts()
        {
            LogManager.Instance.WriteLog("---Show Discounts---");
            Console.WriteLine("---Air Product--- 30%");
            Console.WriteLine("---Hotel Product--- 50%");
            Console.WriteLine("---Activity Product--- 50%");
            Console.WriteLine("---Car Product--- 20%");
        }

        public void UserChoice()
        {
            LogManager.Instance.WriteLog("---Inside Constants/UserChoice---");
            Console.WriteLine("Enter type of product");
            Console.Write("Valid Entries:");
            Console.Write("CarProduct / Hotel / Activity / Airways");
            Console.Write("---PLEASE NOTE THAT ENTRIES ARE CASE SENSITIVE---");
            Console.WriteLine();
        }
        public void Error()
        {
            LogManager.Instance.WriteLog("---Inside Constants/Error---");
            Console.WriteLine("Wrong Entry! Please try again.");
            
        } 
        public void AskTypeOfDB()
        {
            LogManager.Instance.WriteLog("---Asking type of database---");
            Console.WriteLine("Enter the system you wish to access...");
            Console.Write("1 - Database");
            Console.Write("2 - FileSystem");
            Console.WriteLine();
        }

        public void BookOrSave()
        {
            LogManager.Instance.WriteLog("---Book Or Save---");
            Console.WriteLine("You can book OR save the selected product...");
            Console.WriteLine("___Select your choice___");
            Console.Write("1 - Save");
            Console.Write("2 - Book");
            Console.WriteLine();
        }
        public void EnterName()
        {
            Console.WriteLine("Name Of Product-----");
        }
        public void EnterPrice()
        {
            Console.WriteLine("Price Of Product-----");
        }
        public void DisplayDiscountMessage()
        {
            Console.WriteLine("Updating into database after providing discount");
        }
    }
}
