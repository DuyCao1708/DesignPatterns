namespace Examples.Patterns.Structural.Bridge;

public class LinuxDownloader : IOperationSystemDownloader
{
    public void SaveToDisk(string fileName)
    {
        Console.WriteLine($"[Linux] writing {fileName} to /usr/download");
    }
}
