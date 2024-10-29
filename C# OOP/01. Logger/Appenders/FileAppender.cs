using _01.Logger.Enums;
using _01.Logger.Loggers;
using _01.LoggerTask.Appenders;
using _01.LoggerTask.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger.Appenders
{
    public class FileAppender : IAppender
    {
        private ILogFile logFile;

        public FileAppender(ILayout layout, ILogFile logFile)
        {
            Layout = layout;
        }

        public ILayout Layout { get; }

        public void Append(string dateTime, LogLevel logLevel, string message)
        {
            this.logFile.Write(string.Format(Layout.Format, dateTime, logLevel, message));
        }
    }
}