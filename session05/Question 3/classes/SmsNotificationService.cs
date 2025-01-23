using session05.Question_3.Interfaces;

namespace session05.Question_3.classes
{
    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"{recipient} sent this sms and its body is\n{message}");
        }
    }
}
