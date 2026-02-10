namespace Examples.Patterns.Behavioral.Visitor;

public class BillingVisitor : IMedicalVisitor
{
    public decimal TotalCost { get; private set; }

    public void VisitBloodTest(BloodTest bloodTest)
    {
        TotalCost += 50;
    }

    public void VisitXRay(XRay xray)
    {
        TotalCost += 200;
    }
}
