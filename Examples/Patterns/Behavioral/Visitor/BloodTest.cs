namespace Examples.Patterns.Behavioral.Visitor;

public class BloodTest : IMedicalRecord
{
    public double Glucose { get; set; }

    public void Accept(IMedicalVisitor visitor)
    {
        visitor.VisitBloodTest(this);
    }
}
