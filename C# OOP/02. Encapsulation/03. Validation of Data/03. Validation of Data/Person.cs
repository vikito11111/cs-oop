using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Validation_of_Data
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            private set
            {
                if (value != null && value.Length < 3)
                {
                    throw new Exception("Invalid length for first name!");
                }

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
                if (value != null && value.Length < 3)
                {
                    throw new Exception("Invalid length for last name!");
                }

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
                if (value < 0)
                {
                    throw new Exception("Invalid age!");
                }

                age = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value < 650)
                {
                    throw new Exception("Invalid minimum salary! Minimum should be at least 650!");
                }

                salary = value;
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age >= 30)
            {
                this.Salary += Salary * percentage / 100;
            }
            else
            {
                this.Salary += Salary * percentage / 200;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
        }
    }
}