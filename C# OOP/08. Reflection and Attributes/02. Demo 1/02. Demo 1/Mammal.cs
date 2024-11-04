using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02._Demo_1
{
    public class Mammal
    {
        string executing = Assembly.GetExecutingAssembly().FullName;
        string calling = Assembly.GetCallingAssembly().FullName;
        string entry = Assembly.GetEntryAssembly().FullName;
    }
}