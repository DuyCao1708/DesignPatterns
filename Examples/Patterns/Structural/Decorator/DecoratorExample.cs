using Examples.Enums;
using Examples.Interfaces;

namespace Examples.Patterns.Structural.Decorator;

public class DecoratorExample : IPatternExample
{
    public string Name => "Decorator";

    public PatternGroup Group => PatternGroup.Structural;

    public void Run()
    {
        ICharacter warrior = new Warrior();
        Console.WriteLine("Basic warrior status:");
        LogCharacterStatus(warrior);

        warrior = new ShieldDecorator(warrior);
        Console.WriteLine("Warrior with shield status:");
        LogCharacterStatus(warrior);

        warrior = new SwordDecorator(warrior);
        Console.WriteLine("Warrior with shield and sword status:");
        LogCharacterStatus(warrior);

        warrior = new StaffDecorator(warrior);
        Console.WriteLine("Warrior with shield, sword and staff status:");
        LogCharacterStatus(warrior);
    }

    private void LogCharacterStatus(ICharacter character)
    {
        var status = character.GetStatus();
        Console.WriteLine($"ATK: {status.Attack}");
        Console.WriteLine($"MP: {status.Magic}");
        Console.WriteLine($"DEF: {status.Defense}");
    }
}
