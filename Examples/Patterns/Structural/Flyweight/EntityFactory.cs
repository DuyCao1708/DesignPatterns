namespace Examples.Patterns.Structural.Flyweight;

public class EntityFactory
{
    private List<EntityType> _types = new List<EntityType>();

    public EntityType GetEntityType(string texture, string model)
    {
        var type = _types.FirstOrDefault(type => type.Texture == texture && type.Model == model);

        if (type != null) return type;

        var newType = new EntityType(texture, model); ;
        _types.Add(newType);

        return newType;

    }
}
