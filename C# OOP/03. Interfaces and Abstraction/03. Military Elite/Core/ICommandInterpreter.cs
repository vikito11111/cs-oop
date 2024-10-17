using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Military_Elite.Core
{
    public interface ICommandInterpreter
    {
        string Read(string[] args);


    }
}