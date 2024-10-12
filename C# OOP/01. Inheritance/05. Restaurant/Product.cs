using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Restaurant
{
    public abstract class Product
    {
        public Product(string name, decimal price)
        {
            Name = name;

            Price = price;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}