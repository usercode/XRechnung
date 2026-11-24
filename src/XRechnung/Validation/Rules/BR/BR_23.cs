namespace XRechnung.Validation;

public class BR_23 : BR
{
    public override string ID => "BR_23";

    public override string Description => "Jede Rechnungsposition \"INVOICE LINE\" (BG-25) muss eine Einheit zur Mengenangabe \"Invoiced quantity unit of measure code\" (BT-130) enthalten.";

    public override string Context => RuleContext.InvoiceLine;

    public override string Element => "BT-130";

    public override bool Validate(Invoice invoice)
    {
        return invoice.InvoiceLines?.All(x => x.Quantity?.UnitCode?.Value.HasValue() is not false) is not false;
    }
}
