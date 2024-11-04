using _03._Command_Pattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03._Command_Pattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] arguments = args.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string commandName = arguments[0];

            string[] commandArguments = arguments.Skip(1)
                .ToArray();

            Type commandType = Assembly.GetEntryAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == $"{commandName}Command");

            if (commandType is null)
            {
                throw new InvalidOperationException("Command not found");
            }
            
            ICommands commandInstance = Activator.CreateInstance(commandType) as ICommands;

            string result = commandInstance.Execute(commandArguments);

            return result;
        }
    }
}