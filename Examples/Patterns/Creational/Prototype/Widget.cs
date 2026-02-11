namespace Examples.Patterns.Creational.Prototype;

public class Widget : IPrototype
{
    public string Data { get; set; } = "";
    public string Styles { get; set; } = "";

    public Widget(IPrototype? prototype = null)
    {
        if (prototype != null)
        {
            Data = prototype.Data;
            Styles = prototype.Styles;
        }
    }

    public void Render()
    {
        Console.WriteLine($"Render widget: Data - {Data}; Styles: {Styles}");
    }

    public IPrototype Clone()
    {
        return new Widget(this);
    }
}
