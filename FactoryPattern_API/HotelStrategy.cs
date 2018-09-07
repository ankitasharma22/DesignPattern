using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_API
{
    class HotelStrategy
    {
        public int FareCalculation(int inputPrice)
        {
            Constants message = new Constants();
            message.DisplayDiscountMessage();
            return Convert.ToInt32(inputPrice * 0.5);
        }
    }
}
