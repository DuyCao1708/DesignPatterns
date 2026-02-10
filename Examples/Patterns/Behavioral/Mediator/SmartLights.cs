namespace Examples.Patterns.Behavioral.Mediator;

public class SmartLights : SmartDevice
{
    public SmartLights(IMediator mediator) : base(mediator) { }

    public void TurnOff()
    {
        Console.WriteLine("Turn off the lights");

        _mediator.Notify(this);
    }
}
