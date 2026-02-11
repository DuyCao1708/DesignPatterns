using Examples.Enums;
using Examples.Interfaces;

namespace Examples.Patterns.Structural.Flyweight;

public class FlyweightExample : IPatternExample
{
    public string Name => "Flyweight";

    public PatternGroup Group => PatternGroup.Structural;

    public void Run()
    {
        var factory = new SoldierFactory();

        Console.WriteLine("Create 2 soldiers with the same type");
        factory.ProduceSoldier((0, 0), 100, "RedSkin", "HumanModel");
        factory.ProduceSoldier((10, 5), 80, "RedSkin", "HumanModel");

        factory.Render();
    }
}
