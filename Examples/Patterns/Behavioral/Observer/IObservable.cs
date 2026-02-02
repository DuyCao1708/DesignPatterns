namespace Examples.Patterns.Behavioral.Observer;

public interface IObservable<T>
{
    public void Subscribe(ISubcriber<T> subscriber);

    public void Unsubscribe(ISubcriber<T> subscriber);

    public void NotifyToSubscribers();
}
