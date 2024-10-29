using _01.Logger.Enums;
using _01.LoggerTask.Appenders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LoggerTask.Loggers
{
    public class Logger : ILogger
    {
        public Logger(IAppender appender)
        {
            Appender = appender;
        }

        public IAppender Appender { get; }

        public void Error(string dateTime, string message)
        {
            Appender.Append(dateTime, LogLevel.Error, message);
        }

        public void Info(string dateTime, string message)
        {
            Appender.Append(dateTime, LogLevel.Info, message);
        }
    }
}