namespace Examples.Patterns.Behavioral.Observer;

public interface ISubcriber<T>
{
    public void Update(T value);
}
