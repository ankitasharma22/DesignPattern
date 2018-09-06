using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_API
{
    class Activity : IProduct
    {
        FileDatabase file = new FileDatabase();
        public string Name { get; set; } 
        public bool isBooked { get; set; }
        public void Book()
        {
            LogManager.Instance.WriteLog("---Inside Activity/Book---");
            file.EnterBookingDetails("Booking Done Successfully --- Activity");
        }

        public string GetTypeOfProduct()
        {
            return "Activity";
        }

        public void Save()
        {
            LogManager.Instance.WriteLog("---Inside Activity/Book---");
            file.EnterBookingDetails("Booking Done Successfully --- Activity");
        }
    }
}
