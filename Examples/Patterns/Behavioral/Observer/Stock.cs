namespace Examples.Patterns.Behavioral.Observer;

public abstract class Stock : IStock
{
    public abstract string Name { get; }

    private double _price { get; set; }

    public double Price => _price;

    public Stock(double price)
    {
        _price = price;
    }

    private readonly List<ISubcriber<IStock>> _subscribers = new List<ISubcriber<IStock>>();

    public void NotifyToSubscribers()
    {
        foreach (var observer in _subscribers)
        {
            observer.Update(this);
        }
    }

    public void Subscribe(ISubcriber<IStock> observer)
    {
        _subscribers.Add(observer);
    }

    public void Unsubscribe(ISubcriber<IStock> observer)
    {
        _subscribers.Remove(observer);
    }

    public void UpdateStockPrice(double price)
    {
        _price = price;
        NotifyToSubscribers();
    }
}

