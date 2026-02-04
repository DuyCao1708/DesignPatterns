using Examples.Enums;
using Examples.Interfaces;

namespace Examples.Patterns.Creational.Builder;

public class BuilderExample : IPatternExample
{
    public string Name => "Builder";

    public PatternGroup Group => PatternGroup.Creational;

    public void Run()
    {
        var gammingPCBuilder = new GamingPCBuilder();
        var director = new Director(gammingPCBuilder);

        Console.WriteLine("Director uses GamingPCBuilder to build a PC:");
        director.Build();
        var pc = gammingPCBuilder.GetPC();
        pc.DisplaySpecs();

        Console.WriteLine("\nChange to StandardPCBuilder to build a PC:");
        var standardPCBuilder = new StandardPCBuilder();
        director.ChangeBuilder(standardPCBuilder);
        director.Build();
        pc = standardPCBuilder.GetPC();
        pc.DisplaySpecs();
    }
}
