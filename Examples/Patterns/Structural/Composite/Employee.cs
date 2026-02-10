namespace Examples.Patterns.Structural.Composite;

public class Employee : IOrganizationComponent
{
    private int _basePay;

    public Employee(int basePay)
    {
        _basePay = basePay;
    }

    public int GetSalary()
    {
        return _basePay;
    }
}
