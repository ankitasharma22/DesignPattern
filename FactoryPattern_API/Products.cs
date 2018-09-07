using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_API
{
    abstract class Products
    {
        int Id;
        string Name;
        int Price;
        bool isBooked = false;
        public virtual void Book(int dbType) { }
        public virtual void Save(int dbType) { }
        
    }
}
