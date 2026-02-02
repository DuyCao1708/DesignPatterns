namespace Examples.Patterns.Behavioral.Observer;

public class DisplayBoardObserver : IStockObserver
{
    public void Update(IStock stock)
    {
        Console.WriteLine($"Latest {stock.Name} price: {stock.Price}$");
    }
}
