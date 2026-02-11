namespace Examples.Patterns.Behavioral.Iterator;

public interface IWarehouseSection<T>
{
    IIterator<T> CreateScanner();
}
