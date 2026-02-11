using Examples.Enums;
using Examples.Interfaces;

namespace Examples.Patterns.Creational.Prototype;

public class PrototypeExample : IPatternExample
{
    public string Name => "Prototype";

    public PatternGroup Group => PatternGroup.Creational;

    public void Run()
    {
        var widget = new Widget() { Data = "123abc", Styles = "display: block;" };
        var clone = widget.Clone();

        Console.WriteLine("Render base widget");
        widget.Render();

        Console.WriteLine("\nRender clone widget");
        clone.Render();
    }
}
