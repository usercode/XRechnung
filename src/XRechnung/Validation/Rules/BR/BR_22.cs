namespace XRechnung.Validation;

public class BR_22 : BR
{
    public override string ID => "BR_22";

    public override string Description => "Jede Rechnungsposition \"INVOICE LINE\" (BG-25) muss die Menge der in der betreffenden Position in Rechnung gestellten Waren oder Dienstleistungen als Einzelposten \"Invoiced quantity\" (BT-129) enthalten.";

    public override string Context => RuleContext.InvoiceLine;

    public override string Element => "BT-129";

    public override bool Validate(Invoice invoice)
    {
        return invoice.InvoiceLines?.All(x => x.Quantity != null) is not false;
    }
}
