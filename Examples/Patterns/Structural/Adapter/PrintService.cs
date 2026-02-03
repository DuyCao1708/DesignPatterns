namespace Examples.Patterns.Structural.Adapter;

public class PrintService
{
    public void PrintViaSerialPort(string data)
    {
        if (data.StartsWith("STR") && data.EndsWith("SYN"))
        {
            Console.WriteLine($"Data '{data.Substring(3, data.Length - 6)}' has been printed via serial port");
        }
    }
}
