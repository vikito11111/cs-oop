using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Template_Pattern___Bakery.Models
{
    public class WholeWheat : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine("Gathering Ingredients for WholeWheat bread.");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking the WholeWheat bread. (15 minutes)");
        }
    }
}