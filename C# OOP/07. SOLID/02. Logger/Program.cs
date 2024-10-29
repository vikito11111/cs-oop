using _01.Logger.Loggers;
using _01.LoggerTask.Appenders;
using _01.LoggerTask.Layouts;
using _01.LoggerTask.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LoggerTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var simpleLayout = new SimpleLayout();

            var consoleAppender = new ConsoleAppender(simpleLayout);

            var file = new LogFile();

            var fileAppender = new FileAppender(simpleLayout, file);

            var logger = new Logger(consoleAppender, fileAppender);

            logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");

            logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");

            Console.ReadLine();
        }
    }
}