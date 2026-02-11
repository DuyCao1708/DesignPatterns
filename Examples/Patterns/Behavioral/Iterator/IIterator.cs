namespace Examples.Patterns.Behavioral.Iterator;

public interface IIterator<T>
{
    public T GetNext();
    public bool HasMore();
}
