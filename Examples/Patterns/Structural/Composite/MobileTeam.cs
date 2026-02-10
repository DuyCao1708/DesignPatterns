namespace Examples.Patterns.Structural.Composite;

public class MobileTeam : IOrganizationComponent
{
    private List<IOrganizationComponent> _components;

    public MobileTeam(List<IOrganizationComponent> components)
    {
        _components = components;
    }

    public int GetSalary()
    {
        return _components.Sum(component => component.GetSalary());
    }
}
