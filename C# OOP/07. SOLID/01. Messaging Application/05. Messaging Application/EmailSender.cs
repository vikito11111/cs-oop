﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Messaging_Application
{
    public class EmailSender : IMessageSender
    {
        public string SendMessage(string message)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Sending email...");
            sb.AppendLine(message);

            return sb.ToString();
        }
    }
}