namespace Examples.Patterns.Behavioral.Visitor;

public interface IMedicalVisitor
{
    public void VisitBloodTest(BloodTest bloodTest);
    public void VisitXRay(XRay xray);
}
