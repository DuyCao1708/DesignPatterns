namespace Examples.Patterns.Creational.AbstractFactory;

public class ArtDecoFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new ArtDecoChair();
    }

    public ISofa CreateSofa()
    {
        return new ArtDecoSofa();
    }
}
