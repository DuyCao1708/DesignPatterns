namespace Examples.Patterns.Behavioral.Visitor;

public class AlertVisitor : IMedicalVisitor
{
    public void VisitBloodTest(BloodTest bloodTest)
    {
        if (bloodTest.Glucose > 140) Console.WriteLine("ALERT: High Glucose!");
    }

    public void VisitXRay(XRay xray)
    {
        if (xray.Result != "Clear") Console.WriteLine("ALERT: XRay bad result");
    }
}
