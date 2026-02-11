namespace Examples.Patterns.Behavioral.ChainOfResponsibility;

public class SeniorHandler : Handler
{
    public override void Handle(Request request)
    {
        if (!request.IsBug)
        {
            Console.WriteLine("Handles software configuration");
            return;
        }

        if (_nextHandler != null)
        {
            _nextHandler.Handle(request);
        }
    }
}
