using Examples.Enums;
using Examples.Interfaces;

namespace Examples.Patterns.Behavioral.ChainOfResponsibility;

public class ChainOfResponsibilityExample : IPatternExample
{
    public string Name => "Chain of Responsibility";

    public PatternGroup Group => PatternGroup.Behavioral;

    public void Run()
    {
        var juniorHandler = new JuniorHandler();

        juniorHandler
        .SetNext(new SeniorHandler())
        .SetNext(new EngineerHandler());

        Console.WriteLine("Simple request");
        juniorHandler.Handle(new Request() { IsBug = true, IsComplex = false });

        Console.WriteLine("\nComplex request");
        juniorHandler.Handle(new Request() { IsBug = false, IsComplex = true });

        Console.WriteLine("\nBug request");
        juniorHandler.Handle(new Request() { IsBug = true, IsComplex = true });
    }
}
