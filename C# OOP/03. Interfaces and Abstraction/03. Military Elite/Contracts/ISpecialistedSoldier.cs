using _07.Military_Elite.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Military_Elite.Contracts
{
    public interface ISpecialistedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}