namespace Examples.Patterns.Behavioral.Strategy;

public class TaxiTransport : ITransport
{
    public double Price => 30;
    public string Name => "Taxi";

    public double CalculateCost(double distance)
    {
        return Price * distance;
    }
}
