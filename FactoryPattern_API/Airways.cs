using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_API
{
    class Airways :  Products
    {
        FileDatabase file = new FileDatabase();
        public string Name { get; set; } 
        public bool isBooked { get; set; }
        public int Price { get; set; }
        string NameOfProduct { get; set; }
        int PriceOfProduct { get; set; }

        public void GetObjectOfAir(Airways product)
        {
            NameOfProduct = product.Name;
            PriceOfProduct = product.Price;
        }

        public override void Book(int typeOfDB)
        {
            LogManager.Instance.WriteLog("---Inside Airways/Book---");
            if (typeOfDB == 1)
            {
                //Database
                DatabaseAccess database = new DatabaseAccess();
                database.UpdateBookingDetails(NameOfProduct, PriceOfProduct, "AirProduct");
            }
            else
                file.EnterBookingDetails(NameOfProduct, PriceOfProduct, "AirProduct");
        }

        public string GetTypeOfProduct()
        {
            return "Air product";
        }

        public override void Save(int typeOfDB)
        {
            LogManager.Instance.WriteLog("---Inside Airways/Book---");
            if (typeOfDB == 1)
            {
                //Database
                DatabaseAccess database = new DatabaseAccess();
                database.EnterBookingDetails(NameOfProduct, PriceOfProduct, "AirProduct");
            }
            else
                file.EnterBookingDetails(NameOfProduct, PriceOfProduct, "AirProduct");
        }
        public void GetObject(CarProduct product)
        {
            NameOfProduct = product.Name;
            PriceOfProduct = product.Price;
        }
    }
}
