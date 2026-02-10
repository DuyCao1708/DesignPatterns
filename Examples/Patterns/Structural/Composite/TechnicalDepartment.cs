namespace Examples.Patterns.Structural.Composite;

public class TechnicalDepartment : IOrganizationComponent
{
    private List<IOrganizationComponent> _components;

    public TechnicalDepartment(List<IOrganizationComponent> components)
    {
        _components = components;
    }

    public void Add(IOrganizationComponent component)
    {
        _components.Add(component);
    }

    public void Remove(IOrganizationComponent component)
    {
        _components.Remove(component);
    }

    public int GetSalary()
    {
        return _components.Sum(component => component.GetSalary());
    }
}
