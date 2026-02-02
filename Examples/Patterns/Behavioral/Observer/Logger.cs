namespace Examples.Patterns.Behavioral.Observer;

public class Logger : ISubcriber<IStock>
{
    public void Update(IStock stock)
    {
        Console.WriteLine($"Logged {stock.Name} price at {DateTime.Now}: {stock.Price}$");
    }
}
