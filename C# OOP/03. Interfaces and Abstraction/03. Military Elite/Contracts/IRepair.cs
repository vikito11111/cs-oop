﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Military_Elite.Contracts
{
    public interface IRepair
    {
        string PartName { get; }

        int HoursWorked { get; }
    }
}