using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_API
{
    class CarProduct : Products
    {
        FileDatabase file = new FileDatabase();
        TypeOfProduct product = new TypeOfProduct();
        
        public string Name { get; set; } 
        public bool isBooked { get; set; }
        public int Price { get; set; }
        string NameOfProduct { get; set; }
        int PriceOfProduct { get; set; }
        public void GetObjectOfCar(CarProduct product)
        {
            NameOfProduct =  product.Name;
            PriceOfProduct = product.Price;
        }
        public override void Book(int typeOfDB)
        { 
            LogManager.Instance.WriteLog("---Inside CarProduct/Book---");
            if (typeOfDB == 1)
            {
                //Database
                DatabaseAccess database = new DatabaseAccess();
                database.UpdateBookingDetails(NameOfProduct, PriceOfProduct, "CarProduct");
            }
            else
                file.EnterBookingDetails(NameOfProduct, PriceOfProduct, "CarProduct");

        }

        public string GetTypeOfProduct()
        {
            return "Car";
        }

        //save = enterbooking details
        public override void Save(int typeOfDB)
        {
            LogManager.Instance.WriteLog("---Inside CarProduct/Book---");
            if (typeOfDB == 1)
            {
                //Database
                DatabaseAccess database = new DatabaseAccess();
                database.EnterBookingDetails(NameOfProduct, PriceOfProduct, "CarProduct");
            }
            else
                file.EnterBookingDetails(NameOfProduct, PriceOfProduct, "CarProduct");
        }

       
    }
}
