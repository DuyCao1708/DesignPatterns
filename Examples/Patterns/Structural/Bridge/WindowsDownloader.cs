namespace Examples.Patterns.Structural.Bridge;

public class WindowsDownloader : IOperationSystemDownloader
{
    public void SaveToDisk(string fileName)
    {
        Console.WriteLine($"[Windows] writing {fileName} to C:/User/Download");
    }
}