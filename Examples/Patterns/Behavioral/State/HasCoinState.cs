namespace Examples.Patterns.Behavioral.State;

public class HasCoinState : IVendingState
{
    private VendingMachine _vendingMachine;

    public HasCoinState(VendingMachine vendingMachine)
    {
        _vendingMachine = vendingMachine;
    }

    public void InsertCoin()
    {
        Console.WriteLine("There is already a coin in the machine");
    }

    public void PressButton()
    {
        Console.WriteLine("Dispense an item");

        var nextState = new OutOfStockState(_vendingMachine);
        _vendingMachine?.SetState(nextState);
    }
}
