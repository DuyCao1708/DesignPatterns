namespace Examples.Patterns.Behavioral.Strategy;

public class BusTransport : ITransport
{
    public double Price => 5;
    public string Name => "Bus";
    public double CalculateCost(double distance)
    {
        return Price;
    }
}
