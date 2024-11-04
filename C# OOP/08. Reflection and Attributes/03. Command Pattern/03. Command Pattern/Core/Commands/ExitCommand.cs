using _03._Command_Pattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Command_Pattern.Core.Commands
{
    public class ExitCommand : ICommands
    {
        private const int DefaultExitCode = 0;

        public string Execute(string[] args)
        {
            Environment.Exit(DefaultExitCode);

            return null;
        }
    }
}