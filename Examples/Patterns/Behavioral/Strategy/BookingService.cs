namespace Examples.Patterns.Behavioral.Strategy;

public class BookingService
{
    private ITransport _transport;

    public BookingService(ITransport transport)
    {
        _transport = transport;
    }

    public void SetTransport(ITransport transport)
    {
        _transport = transport;
    }

    public void CalculateCost(double distance)
    {
        double cost = _transport.CalculateCost(distance);
        Console.WriteLine($"Travel by {_transport.Name} cost {cost}$ for {distance}km");
    }
}
