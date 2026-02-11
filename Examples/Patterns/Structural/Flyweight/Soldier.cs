namespace Examples.Patterns.Structural.Flyweight;

public class Soldier
{
    public (int, int) Coordinate { get; set; } = (0, 0);
    public int Health { get; set; } = 100;

    public EntityType _type;

    public Soldier(EntityType type)
    {
        _type = type;
    }

    public void Render()
    {
        _type.Render(Coordinate, Health);

    }

}
