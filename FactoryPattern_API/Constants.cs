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
        public void UserChoice()
        {
            LogManager.Instance.WriteLog("---Inside Constants/UserChoice---");
            Console.WriteLine("Enter type of product");
            Console.Write("Valid Entries:");
            Console.Write("CarProduct / Hotel / Activity / Airways");
            Console.Write("---PLEASE NOTE THAT ENTRIES ARE CASE SENSITIVE---");
        }
        public void Error()
        {
            LogManager.Instance.WriteLog("---Inside Constants/Error---");
            Console.WriteLine("Wrong Entry! Please try again.");
        }
    }
}
