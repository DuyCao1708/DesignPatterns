using Examples.Enums;
using Examples.Interfaces;

namespace Examples.Patterns.Behavioral.Visitor;

public class VisitorExample : IPatternExample
{
    public string Name => "Visitor";

    public PatternGroup Group => PatternGroup.Behavioral;

    public void Run()
    {
        var bloodTest = new BloodTest() { Glucose = 120 };
        var xray = new XRay() { Result = "Broken leg" };

        var alertVisitor = new AlertVisitor();
        var billingVisitor = new BillingVisitor();

        Console.WriteLine("Here are patient's blood test and xray results");

        bloodTest.Accept(alertVisitor);
        xray.Accept(alertVisitor);

        bloodTest.Accept(billingVisitor);
        xray.Accept(billingVisitor);

        Console.WriteLine($"Total billing: {billingVisitor.TotalCost}$");
    }
}
