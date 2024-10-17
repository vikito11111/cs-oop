using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cars.Cars
{
    public interface IElectricCar : ICar
    {
        string Battery { get; set; }
    }
}