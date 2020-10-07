﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.Example1
{
    class BuyThreeGetOneDiscount : IDiscount
    {
        public decimal CalculateDiscount(decimal singleItemPrice, int quantity)
        {
            return singleItemPrice * (quantity / 3);
        }
    }
}
