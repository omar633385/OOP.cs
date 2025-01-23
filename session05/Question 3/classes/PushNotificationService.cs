using session05.Question_3.Interfaces;

namespace session05.Question_3.classes
{
    internal class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"{recipient} Pushed this notification and it contain \n{message}");
        }
    }
}
