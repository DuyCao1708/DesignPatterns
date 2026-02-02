namespace Examples.Patterns.Creational.FactoryMethod;

public class SMSSender : INotificationSender
{
    public void NotifyUser(string userId, string message)
    {
        Console.WriteLine($"Message '{message}' has been sent to user '{userId}' by SMS");
    }
}
