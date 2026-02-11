namespace Examples.Patterns.Creational.Prototype;

public interface IPrototype
{
    public string Data { get; set; }
    public string Styles { get; set; }

    public IPrototype Clone();
    public void Render();
}
