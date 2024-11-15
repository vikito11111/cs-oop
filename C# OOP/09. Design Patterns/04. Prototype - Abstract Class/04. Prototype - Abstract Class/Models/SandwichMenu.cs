using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Prototype___Abstract_Class.Models
{
    public class SandwichMenu
    {
        private IDictionary<string, SandwichPrototype> sandwiches;

        public SandwichMenu()
        {
            sandwiches = new Dictionary<string, SandwichPrototype>();
        }

        public SandwichPrototype this[string name]
        {
            get => sandwiches[name];
            set => sandwiches[name] = value;
        }
    }
}