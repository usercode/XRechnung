namespace XRechnung.Validation;

public class BR_2 : BR
{
    public override string ID => "BR_2";

    public override string Description => "Eine Rechnung (INVOICE) muss eine Rechnungsnummer \"Invoice number\" (BT-1) enthalten.";

    public override string Context => RuleContext.Invoice;

    public override string Element => "BT-1";

    public override bool Validate(Invoice invoice)
    {
        return invoice.InvoiceNumber?.Value.HasValue() == true;
    }
}
