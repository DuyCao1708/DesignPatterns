namespace Examples.Patterns.Behavioral.Iterator;

public class SmallScanner : IIterator<string>
{
    private SmallSection _smallSection;
    private int _nextIndex = 0;

    public SmallScanner(SmallSection smallSection)
    {
        _smallSection = smallSection;
    }

    public string GetNext()
    {
        return _smallSection.items.ElementAt(_nextIndex++);
    }

    public bool HasMore()
    {
        return _nextIndex < _smallSection.items.Count;
    }
}
