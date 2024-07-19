// NotificationService class with single responsibility of sending notifications
public class NotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Notification: {message}");
    }
}