﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Sort_People_By_Name_and_Age
{
    public class Person
    {
		private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName
		{
			get 
			{ 
				return firstName; 
			}
			private set 
			{
                firstName = value; 
			}
		}

		public string LastName
		{
			get 
			{ 
				return lastName;
			}
            private set
            { 
				lastName = value; 
			}
		}

		public int Age
		{
			get 
			{ 
				return age; 
			}
			private set 
			{ 
				age = value; 
			}
		}

        public override string ToString()
        {
			return $"{FirstName} {LastName} is {Age} years old";
        }
    }
}