using Examples.Enums;
using Examples.Interfaces;

namespace Examples.Patterns.Behavioral.Mediator;

public class MediatorExample : IPatternExample
{
    public string Name => "Mediator";

    public PatternGroup Group => PatternGroup.Behavioral;

    public void Run()
    {
        var system = new AutomationSystem();

        Console.WriteLine("Simulate Good Morning routine");
        system.SimulateGoodMorningRoutine();
    }
}
