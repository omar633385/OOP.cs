using session05.Question_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session05.Question_3.classes
{
    internal class EmailNotificationService : INotificationService
    {
        
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"{recipient} sent that e-mail and its body is\n{message}");
        }
    }
}
