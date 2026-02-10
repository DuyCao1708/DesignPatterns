namespace Examples.Patterns.Behavioral.Visitor;

public interface IMedicalRecord
{
    public void Accept(IMedicalVisitor visitor);
}
