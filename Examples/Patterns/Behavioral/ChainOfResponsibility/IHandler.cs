namespace Examples.Patterns.Behavioral.ChainOfResponsibility;

public interface IHandler
{
    public IHandler SetNext(IHandler handler);
    public void Handle(Request request);
}
