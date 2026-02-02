namespace Examples.Patterns.Behavioral.Observer;

public class Stock : IStock
{
    public string Name { get; }

    private double _price { get; set; }

    public double Price => _price;

    public Stock(string name, double price)
    {
        Name = name;
        _price = price;
    }

    private readonly List<IStockObserver> _observers = new List<IStockObserver>();

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }

    public void Subscribe(IStockObserver observer)
    {
        _observers.Add(observer);
    }

    public void Unsubscribe(IStockObserver observer)
    {
        _observers.Remove(observer);
    }

    public void UpdateStockPrice(double price)
    {
        _price = price;
        NotifyObservers();
    }
}

