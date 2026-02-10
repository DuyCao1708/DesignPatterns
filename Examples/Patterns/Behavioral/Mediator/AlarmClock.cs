namespace Examples.Patterns.Behavioral.Mediator;

public class AlarmClock : SmartDevice
{
    public AlarmClock(IMediator mediator) : base(mediator) { }

    public void Ring()
    {
        Console.WriteLine("It's time to wake up!");

        _mediator.Notify(this);
    }
}
