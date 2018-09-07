using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_API
{
    class Hotel : Products
    {
        FileDatabase file = new FileDatabase();
        public string Name { get; set; } 
        public bool isBooked { get; set; }
        public int Price { get; set; }
        string NameOfProduct { get; set; }
        int PriceOfProduct { get; set; }

        public void GetObjectOfHotel(Hotel product)
        {
            NameOfProduct = product.Name;
            PriceOfProduct = product.Price;
        }
        public override void Book(int typeOfDB)
        {
            LogManager.Instance.WriteLog("---Inside CarProduct/Book---");
            if (typeOfDB == 1)
            {
                //Database
                DatabaseAccess database = new DatabaseAccess();
                database.UpdateBookingDetails(NameOfProduct, PriceOfProduct, "HotelProduct");
            }
            else
                file.EnterBookingDetails(NameOfProduct, PriceOfProduct, "HotelProduct");
        }

        public string GetTypeOfProduct()
        {
            return "Hotel";
        }

        public override void Save(int typeOfDB)
        {
            LogManager.Instance.WriteLog("---Inside CarProduct/Book---");
            if (typeOfDB == 1)
            {
                //Database
                DatabaseAccess database = new DatabaseAccess();
                database.EnterBookingDetails(NameOfProduct, PriceOfProduct, "HotelProduct");
            }
            else
                file.EnterBookingDetails(NameOfProduct, PriceOfProduct, "HotelProduct");
        }
    }
}
