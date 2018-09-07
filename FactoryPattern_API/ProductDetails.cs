using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_API
{
    class ProductDetails
    {
        public int BookOrSaveSelectedProduct()
        {
            Constants constants = new Constants();
            constants.BookOrSave();
            int bookOrSave = Convert.ToInt32(Console.ReadLine());
            return bookOrSave;
        }

        public int TypeOfDatabase()
        {
            Constants constants = new Constants();
            constants.BookOrSave();
            int bookOrSave = Convert.ToInt32(Console.ReadLine());
            return bookOrSave;
        }

        public string NameOfProduct()
        {
            return Console.ReadLine();
        }

        public int PriceOfProduct()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
