namespace Examples.Patterns.Behavioral.State;

public class NoCoinState : IVendingState
{
    private VendingMachine _vendingMachine;

    public NoCoinState(VendingMachine vendingMachine)
    {
        _vendingMachine = vendingMachine;
    }

    public void InsertCoin()
    {
        Console.WriteLine("A coin has been inserted into the machine");

        var nextState = new HasCoinState(_vendingMachine);
        _vendingMachine.SetState(nextState);
    }

    public void PressButton()
    {
        Console.WriteLine("Please insert 1 coin to the machine");
    }
}
