namespace Examples.Patterns.Structural.Flyweight;

public class SoldierFactory : EntityFactory
{
    private List<Soldier> _soldiers = new List<Soldier>();

    public Soldier ProduceSoldier((int, int) coordinate, int health, string texture, string model)
    {
        var type = GetEntityType(texture, model);
        var soldier = new Soldier(type) { Coordinate = coordinate, Health = health };

        _soldiers.Add(soldier);
        return soldier;
    }

    public void Render()
    {
        foreach (var solider in _soldiers)
        {
            solider.Render();
        }
    }
}
