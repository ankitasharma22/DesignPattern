using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_API
{
    class ActivityStrategy
    {
        public int FareCalculation(int inputPrice)
        {
            LogManager.Instance.WriteLog("---Inside Activity Strategy---");
            Constants message = new Constants();
            message.DisplayDiscountMessage();
            return Convert.ToInt32(inputPrice * 0.5);
        }
    }
}
