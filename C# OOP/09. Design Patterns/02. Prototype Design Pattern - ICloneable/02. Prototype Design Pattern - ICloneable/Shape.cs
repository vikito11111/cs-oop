using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Prototype_Design_Pattern___ICloneable
{
    public abstract class Shape : ICloneable
    {
        public abstract object Clone();
    }
}