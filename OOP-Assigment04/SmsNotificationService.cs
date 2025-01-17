using OOP_Assigment04.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assigment04
{
    internal class SmsNotificationService:INotificationService
    {
      public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending SMS To {recipient} : {message}");
        }
    }
}
