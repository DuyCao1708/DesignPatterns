using Examples.Enums;
using Examples.Interfaces;

namespace Examples.Patterns.Creational.FactoryMethod;

public class FactoryMethodExample : IPatternExample
{
    public string Name => "Factory Method";

    public PatternGroup Group => PatternGroup.Creational;

    public void Run()
    {
        SendExampleNotification(new EmailSenderFactory());
        SendExampleNotification(new SMSSenderFactory());
    }

    public void SendExampleNotification(NotificationSenderFactory senderFactory)
    {
        // The code works without knowing the exact concrete factory
        senderFactory.SendNotification("user123", "Hello there");
    }
}
