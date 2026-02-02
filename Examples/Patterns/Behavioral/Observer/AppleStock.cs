namespace Examples.Patterns.Behavioral.Observer;

public class AppleStock : Stock
{
    public override string Name => "AAPL";
    public AppleStock(double price = 250) : base(price) { }
}
