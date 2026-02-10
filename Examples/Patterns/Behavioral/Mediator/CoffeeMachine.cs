namespace Examples.Patterns.Behavioral.Mediator;

public class CoffeeMachine : SmartDevice
{
    public CoffeeMachine(IMediator mediator) : base(mediator) { }

    public void Brew()
    {
        Console.WriteLine("Start brewing");

        _mediator.Notify(this);
    }
}
