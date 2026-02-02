namespace Examples.Patterns.Creational.FactoryMethod;

public class EmailSenderFactory : NotificationSenderFactory
{
    public override INotificationSender CreateSender()
    {
        return new EmailSender();
    }
}
