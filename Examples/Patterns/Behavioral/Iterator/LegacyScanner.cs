namespace Examples.Patterns.Behavioral.Iterator;

public class LegacyScanner : IIterator<string>
{
    private LegacySection _legacySection;
    private int _nextIndex = 0;

    public LegacyScanner(LegacySection legacySection)
    {
        _legacySection = legacySection;
    }

    public string GetNext()
    {
        return _legacySection.items.ElementAt(_nextIndex++);
    }

    public bool HasMore()
    {
        return _nextIndex < _legacySection.items.Length;
    }
}
