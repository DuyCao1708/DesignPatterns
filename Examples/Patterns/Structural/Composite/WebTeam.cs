namespace Examples.Patterns.Structural.Composite;

public class WebTeam : IOrganizationComponent
{

    private List<IOrganizationComponent> _components;

    public WebTeam(List<IOrganizationComponent> components)
    {
        _components = components;
    }

    public int GetSalary()
    {
        return _components.Sum(component => component.GetSalary());
    }
}
