using _01.LoggerTask.Appenders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LoggerTask.Loggers
{
    public interface ILogger
    {
        IAppender Appender { get; }

        void Error(string dateTime, string message);

        void Info(string dateTime, string message);
    }
}