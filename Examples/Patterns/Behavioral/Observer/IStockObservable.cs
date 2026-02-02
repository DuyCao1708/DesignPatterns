namespace Examples.Patterns.Behavioral.Observer;

public interface IStockObservable
{
    public void Subscribe(IStockObserver observer);

    public void Unsubscribe(IStockObserver observer);

    public void NotifyObservers();
}
