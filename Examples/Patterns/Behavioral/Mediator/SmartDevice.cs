namespace Examples.Patterns.Behavioral.Mediator;

public class SmartDevice
{
    protected IMediator _mediator;

    public SmartDevice(IMediator mediator)
    {
        _mediator = mediator;
    }
}
