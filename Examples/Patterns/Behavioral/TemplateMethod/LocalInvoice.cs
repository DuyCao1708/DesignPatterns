namespace Examples.Patterns.Behavioral.TemplateMethod;

public class LocalInvoice : InvoiceTemplate
{
    public override void ApplyDiscount()
    {
        Console.WriteLine("Apply domestic discount (5%) on invoice");
    }

    public override void ApplyTax()
    {
        Console.WriteLine("Apply domestic tax (10%) on invoice");
    }
}
