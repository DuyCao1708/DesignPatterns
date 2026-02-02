namespace Examples.Patterns.Behavioral.Strategy;

public class BicycleTransport : ITransport
{
    public double Price => 10;
    public string Name => "Bicycle";

    public double CalculateCost(double distance)
    {
        return Price * distance;
    }
}
