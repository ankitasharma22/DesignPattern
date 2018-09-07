using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_API
{
    interface IDatabase
    {
        void EnterBookingDetails(string name, int price, string tableName);

    }
}
