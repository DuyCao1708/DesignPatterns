using Examples.Enums;
using Examples.Interfaces;

namespace Examples.Patterns.Behavioral.TemplateMethod;

public class TemplateMethodExample : IPatternExample
{
    public string Name => "Template Method";

    public PatternGroup Group => PatternGroup.Behavioral;

    public void Run()
    {
        Console.WriteLine("Process on local invoice");
        new LocalInvoice().ProcessInvoice();

        Console.WriteLine("\nProcess on export invoice");
        new ExportInvoice().ProcessInvoice();
    }
}
