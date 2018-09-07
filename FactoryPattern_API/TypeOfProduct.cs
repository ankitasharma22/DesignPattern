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
       
        public Products GetProduct(string productType)
        {
            LogManager._instance.WriteLog("---Inside GetProduct---");
            MemberInfo carType = typeof(CarProduct);
            MemberInfo airType = typeof(Airways);
            MemberInfo hotelType = typeof(Hotel);
            MemberInfo activityType = typeof(Activity);
            Constants messages = new Constants();
            ProductDetails product = new ProductDetails();
            object[] attributes = carType.GetCustomAttributes(true);

            messages.EnterName();
            string nameOfProduct = product.NameOfProduct();

            messages.EnterPrice();
            int priceOfProduct = product.PriceOfProduct();

            messages.AskTypeOfDB();
            int typeOfDb = Convert.ToInt32(Console.ReadLine());

            if (productType.Equals(carType.Name))
            {
                LogManager._instance.WriteLog("---Product type = car---");
                CarProduct carProduct = new CarProduct();
                CarStrategy discount = new CarStrategy();
                carProduct.Price = discount.FareCalculation(priceOfProduct);
                carProduct.isBooked = false;

                
                carProduct.Name = nameOfProduct;
                

                carProduct.GetObjectOfCar(carProduct);

                int userChoice = product.BookOrSaveSelectedProduct(); 
                if (userChoice == 1)
                    carProduct.Save(typeOfDb);
                else if (userChoice == 2) 
                    carProduct.Book(typeOfDb); 
                else
                    messages.Error();
              
                return carProduct;
            }

            if (productType.Equals(airType.Name))
            {
                LogManager._instance.WriteLog("---Product type = airways---");
                Airways airways = new Airways();
                airways.isBooked = false; 

                airways.Name = nameOfProduct;

                AirStrategy discount = new AirStrategy();
                airways.Price = discount.FareCalculation(priceOfProduct);

                airways.GetObjectOfAir(airways);
                 

                int userChoice = product.BookOrSaveSelectedProduct();
                if (userChoice == 1)
                    airways.Save(typeOfDb);
                else if (userChoice == 2)
                    airways.Book(typeOfDb);
                else
                    messages.Error();

                return airways;
            }

            if (productType.Equals(hotelType.Name))
            {
                LogManager._instance.WriteLog("---Product type = hotel---");
                Hotel hotel = new Hotel();
                hotel.isBooked = false;

                hotel.Name = nameOfProduct;
                HotelStrategy discount = new HotelStrategy();
                hotel.Price = discount.FareCalculation(priceOfProduct);

                hotel.GetObjectOfHotel(hotel);

                int userChoice = product.BookOrSaveSelectedProduct();
                if (userChoice == 1)
                    hotel.Save(typeOfDb);
                else if (userChoice == 2)
                    hotel.Book(typeOfDb);
                else
                    messages.Error();
                return hotel;
            }

            if (productType.Equals(activityType.Name))
            {
                LogManager._instance.WriteLog("---Product type = activity---");
                Activity activity = new Activity();
                activity.isBooked = false;

                activity.Name = nameOfProduct;
                ActivityStrategy discount = new ActivityStrategy();
                activity.Price = discount.FareCalculation(priceOfProduct);
                activity.GetObjectOfActivity(activity);

                int userChoice = product.BookOrSaveSelectedProduct();
                if (userChoice == 1)
                    activity.Save(typeOfDb);
                else if (userChoice == 2)
                    activity.Book(typeOfDb);
                else
                    messages.Error();
                return activity;
            }
            return new Activity();
        }


    }
}
