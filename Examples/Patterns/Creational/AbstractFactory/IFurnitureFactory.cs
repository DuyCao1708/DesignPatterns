namespace Examples.Patterns.Creational.AbstractFactory;

public interface IFurnitureFactory
{
    public IChair CreateChair();
    public ISofa CreateSofa();
}
