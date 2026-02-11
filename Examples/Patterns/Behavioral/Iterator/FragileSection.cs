namespace Examples.Patterns.Behavioral.Iterator;

public class FragileSection : IWarehouseSection<string>
{
    public readonly Stack<string> items = new Stack<string>(["Fragile Item 1", "Fragile Item 2", "Fragile Item 3"]);

    public IIterator<string> CreateScanner()
    {
        return new FragileScanner(this);
    }
}