namespace Examples.Patterns.Behavioral.State;

public class VendingMachine
{
    private IVendingState _state;

    public VendingMachine()
    {
        _state = new NoCoinState(this);
    }

    public void SetState(IVendingState state)
    {
        _state = state;
    }

    public void InsertCoin()
    {
        _state.InsertCoin();
    }

    public void PressButton()
    {
        _state.PressButton();
    }
}
