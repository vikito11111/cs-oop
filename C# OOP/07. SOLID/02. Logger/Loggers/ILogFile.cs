using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger.Loggers
{
    public interface ILogFile
    {
        void Write(string message);

        int Size { get; }
    }
}