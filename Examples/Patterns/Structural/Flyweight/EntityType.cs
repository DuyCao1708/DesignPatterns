namespace Examples.Patterns.Structural.Flyweight;

public class EntityType
{
    public string Texture { get; private set; }
    public string Model { get; private set; }

    public EntityType(string texture, string model)
    {
        Texture = texture;
        Model = model;

        Console.WriteLine("New type has been created");
    }

    public void Render((int, int) coordinate, int health)
    {
        Console.WriteLine($"Render {Texture}{Model} with {health}HP at [{coordinate.Item1}; {coordinate.Item2}]");
    }
}
