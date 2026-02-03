namespace Examples.Patterns.Structural.Facade;

public class SoundControl
{
    public void TurnOn()
    {
        Console.WriteLine("Turn on the Sound System");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine($"Set sound volume to {volume}");
    }
}
