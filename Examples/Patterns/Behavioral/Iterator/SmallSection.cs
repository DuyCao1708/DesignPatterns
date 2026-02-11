namespace Examples.Patterns.Behavioral.Iterator;

public class SmallSection : IWarehouseSection<string>
{
    public readonly List<string> items = new List<string>() { "Small Item 1", "Small Item 2", "Small Item 3" };

    public IIterator<string> CreateScanner()
    {
        return new SmallScanner(this);
    }
}
