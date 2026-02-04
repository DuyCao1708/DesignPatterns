using Examples.Enums;
using Examples.Interfaces;

namespace Examples.Patterns.Creational.AbstractFactory;

public class AbstractFactoryExample : IPatternExample
{
    public string Name => "Abstract Factory";

    public PatternGroup Group => PatternGroup.Creational;

    public void Run()
    {
        Console.WriteLine("Simulate an art deco style room");
        var artDecoSimulator = new FurnitureSimulator(new ArtDecoFurnitureFactory());
        artDecoSimulator.ShowRoom();

        Console.WriteLine("\nSimulate a modern style room");
        var modernSimulator = new FurnitureSimulator(new ModernFurnitureFactory());
        modernSimulator.ShowRoom();

        Console.WriteLine("\nSimulate a victorian style room");
        var victorianSimulator = new FurnitureSimulator(new VictorianFurnitureFactory());
        victorianSimulator.ShowRoom();
    }

}
