using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Prototype___Abstract_Class.Models
{
    public abstract class SandwichPrototype
    {
        public abstract SandwichPrototype Clone();
    }
}