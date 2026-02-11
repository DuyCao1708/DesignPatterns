namespace Examples.Patterns.Behavioral.ChainOfResponsibility;

public class JuniorHandler : Handler
{
    public override void Handle(Request request)
    {
        if (!request.IsComplex)
        {
            Console.WriteLine("Handle basic password resets");
            return;
        }

        if (_nextHandler != null)
        {
            _nextHandler.Handle(request);
        }
    }
}
