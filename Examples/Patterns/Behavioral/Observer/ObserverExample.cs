
using Examples.Enums;
using Examples.Interfaces;

namespace Examples.Patterns.Behavioral.Observer;

public class ObserverExample : IPatternExample
{
    public string Name => "Observer";

    public PatternGroup Group => PatternGroup.Behavioral;

    public void Run()
    {
        var stock = new AppleStock();
        var logger = new Logger();
        var displayBoard = new DisplayBoard();
        var alertSystem = new AlertSystem();

        stock.Subscribe(logger);
        stock.Subscribe(displayBoard);
        stock.Subscribe(alertSystem);

        Console.WriteLine("Notify current AAPL price:");
        stock.NotifyToSubscribers();
        Console.WriteLine("\nAAPL price decreased to 240:");
        stock.UpdateStockPrice(240);
        Console.WriteLine("\nAAPL price dramatically decreased to 140:");
        stock.UpdateStockPrice(140);
    }
}
