using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Command_Pattern.Core.Contracts
{
    public interface ICommandInterpreter
    {
        string Read(string args);
    }
}