using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger.Loggers
{
    public class LogFile : ILogFile
    {
        private const string LogFilePath = "../../../log.txt";

        public void Write(string message)
        {
            File.AppendAllText(LogFilePath, message);
        }

        public int Size => File.ReadAllText(LogFilePath).Where(char.IsLetter).Sum(x => x);
    }
}