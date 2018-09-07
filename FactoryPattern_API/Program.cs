using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static FactoryPattern_API.TypeOfProduct;
using FactoryPattern_API;
namespace FactoryPattern_API
{
    class Program
    {

        public DeviceController()
        {
            CarProduct cp = new CarProduct();
            cp.GetTypeOfProduct();
            _userSelection.Add(TypeOfProducts.Car, new Action(GetTypeOfProduct));

            //TODO
            //Create mapping for all the states
        }

        static void Main(string args[])
        {
            string userInput = Console.ReadLine();
            private Dictionary<TypeOfProducts, Action> _userSelection = new Dictionary<TypeOfProducts, Action>(); }
        }
    
} 
