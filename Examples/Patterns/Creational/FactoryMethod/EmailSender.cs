namespace Examples.Patterns.Creational.FactoryMethod;

public class EmailSender : INotificationSender
{
    public void NotifyUser(string userId, string message)
    {
        Console.WriteLine($"Message '{message}' has been sent to user '{userId}' by Email");
    }
}
