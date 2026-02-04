namespace Examples.Patterns.Behavioral.TemplateMethod;

public class ExportInvoice : InvoiceTemplate
{
    public override void ApplyDiscount()
    {
        Console.WriteLine("No discount available for this invoice");
    }

    public override void ApplyTax()
    {
        Console.WriteLine("Apply export tax (20%) on invoice");
    }
}
