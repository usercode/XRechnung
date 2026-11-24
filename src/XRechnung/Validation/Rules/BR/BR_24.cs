namespace XRechnung.Validation;

public class BR_24 : BR
{
    public override string ID => "BR_24";

    public override string Description => "Jede Rechnungsposition \"INVOICE LINE\" (BG-25) muss den Nettobetrag der Rechnungsposition \"Invoice line net amount\" (BT-131) enthalten.";

    public override string Context => RuleContext.InvoiceLine;

    public override string Element => "BT-131";

    public override bool Validate(Invoice invoice)
    {
        return invoice.InvoiceLines?.All(x => x.NetAmount != null) is not false;
    }
}
