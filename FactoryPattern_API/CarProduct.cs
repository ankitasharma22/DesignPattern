using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_API
{
    class CarProduct :  IProduct
    {
        FileDatabase file = new FileDatabase();
        public string Name { get; set; } 
        public bool isBooked { get; set; }
        public void Book()
        {
            LogManager.Instance.WriteLog("---Inside CarProduct/Book---");
            file.EnterBookingDetails("Booking Done Successfully --- Car");

        }

        public string GetTypeOfProduct()
        {
            return "Car";
        }

        public void Save()
        {
            LogManager.Instance.WriteLog("---Inside CarProduct/Save---");
            file.EnterBookingDetails("Saaving Done Successfully --- Car");
        }

        public void GetInstance()
        {
            
        }
    }
}
