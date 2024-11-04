using _03._Command_Pattern.Core;
using _03._Command_Pattern.Core.Contracts;

ICommandInterpreter command = new CommandInterpreter();

IEngine engine = new Engine(command);

engine.Run();