namespace Examples.Patterns.Structural.Facade;

public class TelevisionControl
{
    public void TurnOn()
    {
        Console.WriteLine("Turn on the television");
    }

    public void SetHDMIChannel(int channel)
    {
        Console.WriteLine($"Set television to HDMI {channel}");
    }
}
