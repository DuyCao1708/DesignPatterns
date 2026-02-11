namespace Examples.Patterns.Behavioral.ChainOfResponsibility;

public class EngineerHandler : Handler
{
    public override void Handle(Request request)
    {
        Console.WriteLine("Handles deep code bugs or hardware replacement");
    }
}
