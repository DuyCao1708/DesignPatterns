namespace Examples.Patterns.Creational.AbstractFactory;

public class FurnitureSimulator
{
    private readonly IChair _chair;
    private readonly ISofa _sofa;

    public FurnitureSimulator(IFurnitureFactory factory)
    {
        _chair = factory.CreateChair();
        _sofa = factory.CreateSofa();
    }

    public void ShowRoom()
    {
        Console.WriteLine($"There is a {_sofa.Style} sofa in the room");
        Console.WriteLine($"There are 4 {_chair.Style} chairs in the room");
    }
}
