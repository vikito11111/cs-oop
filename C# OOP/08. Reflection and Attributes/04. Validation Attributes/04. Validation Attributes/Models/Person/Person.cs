﻿using _04._Validation_Attributes.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Validation_Attributes.Models.Person
{
    public class Person
    {
        private const int MinAge = 12;
        private const int MaxAge = 90;

        public Person(string fullName, int age)
        {
            FullName = fullName;

            Age = age;
        }

        [MyRequired]
        public string FullName { get; private set; }

        [MyRequired]
        [MyRange(MinAge, MaxAge)]
        public int Age { get; private set; }
    }
}