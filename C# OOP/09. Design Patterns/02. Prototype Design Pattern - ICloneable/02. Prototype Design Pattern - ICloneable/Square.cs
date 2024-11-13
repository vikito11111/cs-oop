using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Prototype_Design_Pattern___ICloneable
{
    public class Square : ICloneable
    {
        public int Width { get; set; }

        public Page Page { get; set; }

        public object Clone()
        {
            // Shallow Copy
            //return this.MemberwiseClone();

            // Deep Copy
            return JsonConvert.DeserializeObject<Square>(JsonConvert.SerializeObject(this));
        }
    }
}
