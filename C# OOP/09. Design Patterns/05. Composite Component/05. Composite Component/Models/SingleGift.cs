﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Composite_Component.Models
{
    public class SingleGift : GiftBase
    {
        public SingleGift(string name, decimal price) 
            : base(name, price)
        {

        }

        public override decimal CalculateTotalPrice()
        {
            Console.WriteLine($"{Name} with the price {Price}");

            return Price;
        }
    }
}