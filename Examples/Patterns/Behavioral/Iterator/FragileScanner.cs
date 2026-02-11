namespace Examples.Patterns.Behavioral.Iterator;

public class FragileScanner : IIterator<string>
{
    private FragileSection _fragileSection;
    private int _nextIndex = 0;

    public FragileScanner(FragileSection fragileSection)
    {
        _fragileSection = fragileSection;
    }

    public string GetNext()
    {
        return _fragileSection.items.ElementAt(_nextIndex++);
    }

    public bool HasMore()
    {
        return _nextIndex < _fragileSection.items.Count;
    }
}
