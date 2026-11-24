namespace XRechnung.Validation;

public class BR_21 : BR
{
    public override string ID => "BR_21";

    public override string Description => "Jede Rechnungsposition \"INVOICE LINE\" (BG-25) muss eine Bezeichnung \"Invoice line identifier\" (BT-126) haben.";

    public override string Context => RuleContext.InvoiceLine;

    public override string Element => "BT-126";

    public override bool Validate(Invoice invoice)
    {
        return invoice.InvoiceLines?.All(x => x.Identifier?.Value.HasValue() is not false) is not false;
    }
}
