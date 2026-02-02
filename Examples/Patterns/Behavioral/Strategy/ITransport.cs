namespace Examples.Patterns.Behavioral.Strategy;

public interface ITransport
{
    public double Price { get; }
    public string Name { get; }
    public double CalculateCost(double distance);
}
