using Assignment_5_oop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_oop.Classes
{
    internal class EmailNotificationService:INotificationService
    {
        public void SendNotification(string recipient , string message)
        {
            Console.WriteLine($"This Message To You: {recipient}  , Message is {message} ");

        }

    }
}
