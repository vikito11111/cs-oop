using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Messaging_Application
{
    public interface IMessageSender
    {
        string SendMessage(string message);

        //void MessageManager();
    }
}