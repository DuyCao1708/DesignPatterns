namespace Examples.Patterns.Behavioral.State;

public class OutOfStockState : IVendingState
{
    private VendingMachine _vendingMachine;

    public OutOfStockState(VendingMachine vendingMachine)
    {
        _vendingMachine = vendingMachine;
    }

    public void InsertCoin()
    {
        Console.WriteLine("Return the inserted coin since the machine is out of stock");
    }

    public void PressButton()
    {
        Console.WriteLine("This machine is out of stock. Please come back later");
    }
}
