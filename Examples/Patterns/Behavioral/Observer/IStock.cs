namespace Examples.Patterns.Behavioral.Observer;

public interface IStock : IStockObservable
{
    public string Name { get; }
    public double Price { get; }
    public void UpdateStockPrice(double price);
}
