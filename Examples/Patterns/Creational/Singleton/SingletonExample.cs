using Examples.Enums;
using Examples.Interfaces;

namespace Examples.Patterns.Creational.Singleton;

public class SingletonExample : IPatternExample
{
    public string Name => "Singleton";

    public PatternGroup Group => PatternGroup.Creational;

    public void Run()
    {
        Console.WriteLine(DbContext.Instance.executeQuery("SELECT * FROM Products"));
        Console.WriteLine(DbContext.Instance.executeQuery("SELECT * FROM Invoices"));
    }
}
