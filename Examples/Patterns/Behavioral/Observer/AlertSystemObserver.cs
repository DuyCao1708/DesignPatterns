namespace Examples.Patterns.Behavioral.Observer;

public class AlertSystemObserver : IStockObserver
{
    public void Update(IStock stock)
    {
        if (stock.Price > 150) return;

        Console.WriteLine($"WARNING: {stock.Name} price has dropped to {stock.Price}$");
    }
}
