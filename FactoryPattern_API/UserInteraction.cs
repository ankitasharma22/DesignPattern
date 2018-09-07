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
            messages.DisplayDiscountMessage();
            string descripion = Console.ReadLine();
             
            TypeOfProduct typeOfProduct = new TypeOfProduct();
            Products product = typeOfProduct.GetProduct(descripion);

          
        }
        
    }
}
