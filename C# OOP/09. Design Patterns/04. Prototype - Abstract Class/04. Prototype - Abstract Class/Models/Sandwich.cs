using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Prototype___Abstract_Class.Models
{
    public class Sandwich : SandwichPrototype
    {
        private string meat;
        private string bread;
        private string cheese;
        private string veggies;

        public Sandwich(string bread, string meat, string cheese, string veggies)
        {
            this.bread = bread;
            this.meat = meat;
            this.cheese = cheese;
            this.veggies = veggies;
        }

        public int MyProperty { get; set; }

        public override SandwichPrototype Clone()
        {
            string ingredientList = GetIngredientList();

            Console.WriteLine($"Cloning sandwich with ingredients: {GetIngredientList()}");

            return MemberwiseClone() as SandwichPrototype;
        }

        private string GetIngredientList()
        {
            return $"{this.bread}, {this.meat}, {this.cheese}, {this.veggies}";
        }
    }
}