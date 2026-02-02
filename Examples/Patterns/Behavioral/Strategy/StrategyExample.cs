using Examples.Enums;
using Examples.Interfaces;

namespace Examples.Patterns.Behavioral.Strategy;

public class StrategyExample : IPatternExample
{
    public string Name => "Strategy";

    public PatternGroup Group => PatternGroup.Behavioral;

    public void Run()
    {
        var service = new BookingService(new BusTransport());
        service.CalculateCost(20);
        service.CalculateCost(30);

        service.SetTransport(new TaxiTransport());
        service.CalculateCost(20);

        service.SetTransport(new BicycleTransport());
        service.CalculateCost(20);
    }
}
