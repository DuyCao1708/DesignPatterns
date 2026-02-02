namespace Examples.Patterns.Creational.FactoryMethod;

public abstract class NotificationSenderFactory
{
    public abstract INotificationSender CreateSender();

    // Also note that, despite its name, the Creator's primary
    // responsibility is not creating products. Usually, it contains some
    // core business logic that relies on Product objects, returned by the
    // factory method. Subclasses can indirectly change that business logic
    // by overriding the factory method and returning a different type of
    // product from it.
    public void SendNotification(string userId, string message)
    {
        INotificationSender sender = CreateSender();
        sender.NotifyUser(userId, message);
    }
}
