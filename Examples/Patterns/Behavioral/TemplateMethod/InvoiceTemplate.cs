namespace Examples.Patterns.Behavioral.TemplateMethod;

public abstract class InvoiceTemplate
{
    public void ProcessInvoice()
    {
        CalculateSubtotal();
        ApplyTax();
        ApplyDiscount();
        GeneratePDF();
        SendNotification();
    }

    public void CalculateSubtotal() => Console.WriteLine("Calculate invoice subtotal");

    public abstract void ApplyTax();

    public abstract void ApplyDiscount();

    public void GeneratePDF() => Console.WriteLine("Generate invoice PDF");

    public void SendNotification() => Console.WriteLine("Send notification about invoice");
}
