namespace Examples.Patterns.Behavioral.ChainOfResponsibility;

public abstract class Handler : IHandler
{
    protected IHandler? _nextHandler;

    public abstract void Handle(Request request);

    public IHandler SetNext(IHandler handler)
    {
        _nextHandler = handler;
        return _nextHandler;
    }
}
