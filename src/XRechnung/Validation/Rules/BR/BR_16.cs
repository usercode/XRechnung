namespace XRechnung.Validation;

public class BR_16 : BR
{
    public override string ID => "BR_16";

    public override string Description => "Eine Rechnung (INVOICE) muss mindestens eine Rechnungsposition \"INVOICE LINE\" (BG-25) enthalten.";

    public override string Context => RuleContext.Invoice;

    public override string Element => "BG-25";

    public override bool Validate(Invoice invoice)
    {
        return invoice.InvoiceLines?.Length > 0;
    }
}
