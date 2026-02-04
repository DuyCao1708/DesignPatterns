namespace Examples.Patterns.Creational.Builder;

public class PC
{
    public string? CPU { get; set; }
    public string? GPU { get; set; }
    public int RAM { get; set; }

    public void DisplaySpecs() => Console.WriteLine($"PC: {CPU}, {GPU}, {RAM}GB RAM");
}
