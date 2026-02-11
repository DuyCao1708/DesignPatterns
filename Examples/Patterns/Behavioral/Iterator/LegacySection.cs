namespace Examples.Patterns.Behavioral.Iterator;

public class LegacySection : IWarehouseSection<string>
{
    public readonly string[] items = ["Legacy Item 1", "Legacy Item 2", "Legacy Item 3"];

    public IIterator<string> CreateScanner()
    {
        return new LegacyScanner(this);
    }
}