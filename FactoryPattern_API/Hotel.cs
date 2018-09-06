using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_API
{
    class Hotel :  IProduct
    {
        FileDatabase file = new FileDatabase();
        public string Name { get; set; } 
        public bool isBooked { get; set; }

        public void Book()
        {
            LogManager.Instance.WriteLog("---Inside Hotel/Book---");
            file.EnterBookingDetails("Booking Done Successfully --- Hotel");
        }

        public string GetTypeOfProduct()
        {
            return "Hotel";
        }

        public void Save()
        {
            LogManager.Instance.WriteLog("---Inside Hotel/Book---");
            file.EnterBookingDetails("Booking Done Successfully --- Hotel");
        }
    }
}
