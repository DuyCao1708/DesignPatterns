namespace Examples.Patterns.Structural.Proxy;

public class InternetProxy : IInternet
{
    private IInternet _internet;
    private List<string> _blockedUrls = new List<string> { "https://facebook.com", "https://youtube.com" };

    public InternetProxy(IInternet internet)
    {
        _internet = internet;
    }

    public void AccessTo(string url)
    {
        if (_blockedUrls.Any(url.StartsWith))
        {
            Console.WriteLine($"Access to {url} has been prohibited as the company policy");
            return;
        }

        _internet.AccessTo(url);
    }
}
