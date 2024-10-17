﻿using _07.Military_Elite.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Military_Elite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNumber) : base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }

        public int CodeNumber { get; }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Code Number: {CodeNumber}";
        }
    }
}