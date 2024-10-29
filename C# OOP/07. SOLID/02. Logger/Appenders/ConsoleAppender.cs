using _01.Logger.Enums;
using _01.LoggerTask.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LoggerTask.Appenders
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout)
        {
            Layout = layout;
        }

        public ILayout Layout { get; }

        public void Append(string dateTime, LogLevel logLevel, string message)
        {
            Console.WriteLine(Layout.Format, dateTime, logLevel, message);
        }
    }
}