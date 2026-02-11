namespace Examples.Patterns.Structural.Bridge;

public abstract class FileDownloader
{
    protected IOperationSystemDownloader _os;

    public FileDownloader(IOperationSystemDownloader os)
    {
        _os = os;
    }

    public abstract void Download(string url);

    public void SaveToDisk(string fileName)
    {
        _os.SaveToDisk(fileName);
    }
}
