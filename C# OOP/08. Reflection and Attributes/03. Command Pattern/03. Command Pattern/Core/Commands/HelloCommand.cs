using _03._Command_Pattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _03._Command_Pattern.Core.Commands
{
    public class HelloCommand : ICommands
    {
        public string Execute(string[] args)
        {
            return $"Hello, {args[0]}";
        }
    }
}