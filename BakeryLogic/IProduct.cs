﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLogic
{
    public interface IProduct
    {
        decimal Price { get; set; }
        decimal ReadPrice();
        void OrderProduct();
    }
}
