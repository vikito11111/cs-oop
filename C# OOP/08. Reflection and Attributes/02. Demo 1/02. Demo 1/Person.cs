using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Demo_1
{
    public class Person
    {
        private string name;

        public Person(string name, int age)
        {
            this.name = name;
            Age = age;
        }

        public int Age { get; private set; }

        public string GetName()
        {
            return name;
        }
    }
}