namespace Examples.Patterns.Behavioral.Mediator;

public class Curtains : SmartDevice
{
    public Curtains(IMediator mediator) : base(mediator) { }

    public void Open()
    {
        Console.WriteLine("Open the curtains");

        _mediator.Notify(this);
    }
}
