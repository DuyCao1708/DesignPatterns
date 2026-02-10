namespace Examples.Patterns.Behavioral.Visitor;

public class XRay : IMedicalRecord
{
    public string Result { get; set; } = "Clear";

    public void Accept(IMedicalVisitor visitor)
    {
        visitor.VisitXRay(this);
    }
}
