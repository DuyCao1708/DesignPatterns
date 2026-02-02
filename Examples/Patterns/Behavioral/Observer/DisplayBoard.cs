namespace Examples.Patterns.Behavioral.Observer;

public class DisplayBoard : ISubcriber<IStock>
{
    public void Update(IStock stock)
    {
        Console.WriteLine($"Latest {stock.Name} price: {stock.Price}$");
    }
}
