using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_API
{
    class CarStrategy : IStrategy
    {
        public int FareCalculation(int inputPrice)
        {
            LogManager.Instance.WriteLog("---Inside CarStrategy---");
            Constants message = new Constants();
            message.DisplayDiscountMessage();
            return Convert.ToInt32(inputPrice * 0.8);
        }
    }
}
