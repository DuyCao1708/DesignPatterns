namespace Examples.Patterns.Structural.Adapter;

public class PrintAdapter : IUsbDevice
{
    private PrintService _printService;

    public PrintAdapter(PrintService printService)
    {
        _printService = printService;
    }

    public void SendUsbRequest(string data)
    {
        var convertedData = ConvertToSerialPortData(data);
        _printService.PrintViaSerialPort(convertedData);
    }

    private string ConvertToSerialPortData(string data)
    {
        return $"STR{data}SYN";
    }
}
