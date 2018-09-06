using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern_API;
namespace FactoryPattern_API
{
    class UserInteraction
    {
        static void Main(string[] args)
        {
            LogManager.Instance.WriteLog("---Inside Main---");

            Constants messages = new Constants();
            messages.WelcomeMessage();
            messages.UserChoice();

            string descripion = Console.ReadLine();

          

            TypeOfProduct typeOfProduct = new TypeOfProduct();
            IProduct product = typeOfProduct.GetProduct(descripion);
            

            
        }
    }
}
