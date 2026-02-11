
using Examples.Enums;
using Examples.Interfaces;

namespace Examples.Patterns.Behavioral.Iterator;

public class IteratorExample : IPatternExample
{
    public string Name => "Iterator";

    public PatternGroup Group => PatternGroup.Behavioral;

    public void Run()
    {
        IWarehouseSection<string> section = new SmallSection();
        IIterator<string> scanner = section.CreateScanner();
        Console.WriteLine("Items in small section");
        while (scanner.HasMore())
        {
            Console.WriteLine(scanner.GetNext());
        }

        section = new LegacySection();
        scanner = section.CreateScanner();
        Console.WriteLine("\nItems in legacy section");
        while (scanner.HasMore())
        {
            Console.WriteLine(scanner.GetNext());
        }

        section = new FragileSection();
        scanner = section.CreateScanner();
        Console.WriteLine("\nItems in fragile section");
        while (scanner.HasMore())
        {
            Console.WriteLine(scanner.GetNext());
        }
    }
}
