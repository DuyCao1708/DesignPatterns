
using Examples.Enums;
using Examples.Interfaces;

namespace Examples.Patterns.Behavioral.State;

public class StateExample : IPatternExample
{
    public string Name => "State";

    public PatternGroup Group => PatternGroup.Behavioral;

    public void Run()
    {
        var vendingMachine = new VendingMachine();

        Console.WriteLine("Insert a coin into the vending machine");
        vendingMachine.InsertCoin();
        Console.WriteLine("\nPress the button");
        vendingMachine.PressButton();

        Console.WriteLine("\nInsert another coin into the vending machine");
        vendingMachine.InsertCoin();
        Console.WriteLine("\nPress the button");
        vendingMachine.PressButton();
    }
}
