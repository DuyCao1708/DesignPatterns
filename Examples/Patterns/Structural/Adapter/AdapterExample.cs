using Examples.Enums;
using Examples.Interfaces;

namespace Examples.Patterns.Structural.Adapter;

public class AdapterExample : IPatternExample
{
    public string Name => "Adapter";

    public PatternGroup Group => PatternGroup.Structural;

    public void Run()
    {
        var printAdapter = new PrintAdapter(new PrintService());

        Console.WriteLine("Print 'Hello World'");
        printAdapter.SendUsbRequest("Hello World");
    }
}
