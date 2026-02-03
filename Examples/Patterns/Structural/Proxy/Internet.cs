namespace Examples.Patterns.Structural.Proxy;

public class Internet : IInternet
{
    public void AccessTo(string url)
    {
        Console.WriteLine($"Redirect to {url}");
    }
}
