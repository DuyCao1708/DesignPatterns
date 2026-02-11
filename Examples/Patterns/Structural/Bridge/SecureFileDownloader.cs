namespace Examples.Patterns.Structural.Bridge;

public class SecureFileDownloader : FileDownloader
{
    public SecureFileDownloader(IOperationSystemDownloader os) : base(os) { }

    public override void Download(string url)
    {
        Console.WriteLine($"Decrypting connection for {url}...");
        _os.SaveToDisk("secret_file.dat");
    }
}
