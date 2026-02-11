using Examples.Enums;
using Examples.Interfaces;

namespace Examples.Patterns.Structural.Bridge;

public class BridgeExample : IPatternExample
{
    public string Name => "Bridge";

    public PatternGroup Group => PatternGroup.Structural;

    public void Run()
    {
        IOperationSystemDownloader os = new WindowsDownloader();

        FileDownloader downloader = new SimpleFileDownloader(os);
        Console.WriteLine("Use Windows simple downloader");
        downloader.Download("https://file-csv/123abc");

        downloader = new SecureFileDownloader(os);
        Console.WriteLine("Use Windows secure downloader");
        downloader.Download("https://file-dat/123abc");

        os = new LinuxDownloader();

        downloader = new SimpleFileDownloader(os);
        Console.WriteLine("Use Linux simple downloader");
        downloader.Download("https://file-csv/123abc");

        downloader = new SecureFileDownloader(os);
        Console.WriteLine("Use Linux secure downloader");
        downloader.Download("https://file-dat/123abc");
    }
}
