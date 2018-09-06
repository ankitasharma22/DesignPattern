using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace FactoryPattern_API
{
    class TypeOfProduct
    {
        public IProduct GetProduct(string productType)
        {
            LogManager._instance.WriteLog("---Inside GetProduct---");

            MemberInfo carType = typeof(CarProduct);
            MemberInfo airType = typeof(Airways);
            MemberInfo hotelType = typeof(Hotel);
            MemberInfo activityType = typeof(Activity);
            Constants messages = new Constants();
            object[] attributes = carType.GetCustomAttributes(true);

            if (productType.Equals(carType.Name))
            {
                LogManager._instance.WriteLog("---Product type = car---");
                CarProduct carProduct = new CarProduct();
                carProduct.isBooked = false;
                Console.WriteLine("Getting Car Name---");
                carProduct.Name = Console.ReadLine(); 

                Console.WriteLine("---- Enter your choice: 1. Save Entry 2. Book Entry ----");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice == 1)
                    carProduct.Save();
                else if (userChoice == 2)
                {
                    carProduct.Book();
                    carProduct.isBooked = true;
                } 
                else
                    messages.Error();
                return carProduct;
            }

            if (productType.Equals(airType.Name))
            {
                LogManager._instance.WriteLog("---Product type = airways---");
                Airways airways = new Airways();
                airways.isBooked = false;
                Console.WriteLine("Getting Car Name---");
                airways.Name = Console.ReadLine();
                Console.WriteLine("---- Enter your choice: 1. Save Entry 2. Book Entry ----");

                int userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice == 1)
                    airways.Save();
                else if (userChoice == 2)
                {
                    airways.Book();
                    airways.isBooked = true;
                }
                else
                    messages.Error();

                return airways;
            }

            if (productType.Equals(hotelType.Name))
            {
                LogManager._instance.WriteLog("---Product type = hotel---");
                Hotel hotel = new Hotel();
                hotel.isBooked = false;
                Console.WriteLine("Getting Car Name---");
                hotel.Name = Console.ReadLine();

                Console.WriteLine("---- Enter your choice: 1. Save Entry 2. Book Entry ----");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice == 1)
                    hotel.Save();
                else if (userChoice == 2)
                {
                    hotel.Book();
                    hotel.isBooked = true;
                }
                else
                    messages.Error();
                return hotel;
            }

            if (productType.Equals(activityType.Name))
            {
                LogManager._instance.WriteLog("---Product type = activity---");
                Activity activity = new Activity();
                activity.isBooked = false;
                Console.WriteLine("Getting Car Name---");
                activity.Name = Console.ReadLine();
                Console.WriteLine("---- Enter your choice: 1. Save Entry 2. Book Entry ----");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice == 1)
                    activity.Save();
                else if (userChoice == 2)
                {
                    activity.Book();
                    activity.isBooked = true;
                }
                else
                    messages.Error();
                return activity;
            }
            return new Activity();
        }

       
    }
}
