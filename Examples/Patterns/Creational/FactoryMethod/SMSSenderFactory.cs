namespace Examples.Patterns.Creational.FactoryMethod;

public class SMSSenderFactory : NotificationSenderFactory
{
    public override INotificationSender CreateSender()
    {
        return new SMSSender();
    }
}
