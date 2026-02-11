namespace Examples.Patterns.Structural.Bridge;

public class SimpleFileDownloader : FileDownloader
{
    public SimpleFileDownloader(IOperationSystemDownloader os) : base(os) { }

    public override void Download(string url)
    {
        Console.WriteLine($"Fetch data from {url}");
        _os.SaveToDisk("Simple_file.csv");
    }
}
