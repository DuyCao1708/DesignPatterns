using Examples.Enums;
using Examples.Interfaces;

namespace Examples.Patterns.Structural.Proxy;

public class ProxyExample : IPatternExample
{
    public string Name => "Proxy";

    public PatternGroup Group => PatternGroup.Structural;

    public void Run()
    {
        IInternet internet = new InternetProxy(new Internet());

        var url = "https://facebook.com/news";
        Console.WriteLine($"Try to access {url}");
        internet.AccessTo(url);

        url = "https://medium.com/how-to-implement-proxy-pattern";
        Console.WriteLine($"Try to access {url}");
        internet.AccessTo(url);
    }
}
