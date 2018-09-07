﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FactoryPattern_API.TypeOfProduct;

namespace FactoryPattern_API
{
    interface IProduct
    {
        TypeOfProducts GetTypeOfProduct();
        void Save();
        void Book();
    }
}
