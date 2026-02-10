using Examples.Enums;
using Examples.Interfaces;

namespace Examples.Patterns.Structural.Composite;

public class CompositeExample : IPatternExample
{
    public string Name => "Composite";

    public PatternGroup Group => PatternGroup.Structural;

    public void Run()
    {
        var devA = new Employee(1000);
        var devB = new Employee(1200);
        var techLead = new Employee(2000);

        var mobileTeam = new MobileTeam([devA]);
        var webTeam = new WebTeam([devB]);
        var technicalDepartment = new TechnicalDepartment([mobileTeam, webTeam, techLead]);

        Console.WriteLine($"Mobile team total salary: {mobileTeam.GetSalary()}$");
        Console.WriteLine($"Web team total salary: {webTeam.GetSalary()}$");
        Console.WriteLine($"Technical department total salary: {technicalDepartment.GetSalary()}$");
    }
}
