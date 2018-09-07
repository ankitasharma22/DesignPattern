using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_API
{
    class Activity : Products
    {
        FileDatabase file = new FileDatabase();
        public string Name { get; set; }
        public bool isBooked { get; set; }
        public int Price { get; set; }
        string NameOfProduct { get; set; }
        int PriceOfProduct { get; set; }

        public void GetObjectOfActivity(Activity product)
        {
            NameOfProduct = product.Name;
            PriceOfProduct = product.Price;
        }

        public override void Book(int typeOfDB)
        {
            LogManager.Instance.WriteLog("---Inside Activity/Book---");
            if (typeOfDB == 1)
            {
                //Database
                DatabaseAccess database = new DatabaseAccess();
                database.UpdateBookingDetails(NameOfProduct, PriceOfProduct, "ActivityProduct");
            }
            else
                file.EnterBookingDetails(NameOfProduct, PriceOfProduct, "ActivityProduct");
        }

        public string GetTypeOfProduct()
        {
            LogManager.Instance.WriteLog("---Inside Activity/GetTypeOfProduct---");
            return "Activity";
        }

        public override void Save(int typeOfDB)
        {
            LogManager.Instance.WriteLog("---Inside Activity/Book---");
            if (typeOfDB == 1)
            {
                //Database
                DatabaseAccess database = new DatabaseAccess();
                database.EnterBookingDetails(NameOfProduct, PriceOfProduct, "ActivityProduct");
            }
            else
                file.EnterBookingDetails(NameOfProduct, PriceOfProduct, "ActivityProduct");
        }
    }
}
