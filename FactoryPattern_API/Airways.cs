using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_API
{
    class Airways :  IProduct
    {
        FileDatabase file = new FileDatabase();
        public string Name { get; set; } 
        public bool isBooked { get; set; }
        public void Book()
        {
            LogManager.Instance.WriteLog("---Inside Airways/Book---");
            file.EnterBookingDetails("Booking Done Successfully --- Airways");
        }

        public string GetTypeOfProduct()
        {
            return "Air product";
        }

        public void Save()
        {
            LogManager.Instance.WriteLog("---Inside Airways/Book---");
            file.EnterBookingDetails("Booking Done Successfully --- Airways");
        }
    }
}
