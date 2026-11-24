namespace XRechnung.Validation;

public class BR_14 : BR
{
    public override string ID => "BR_14";

    public override string Description => "Eine Rechnung (INVOICE) muss den Gesamtbetrag der Rechnung mit Umsatzsteuer \"Invoice total amount with VAT\" (BT-112) enthalten.";

    public override string Context => RuleContext.DocumentTotals;

    public override string Element => "BT-112";

    public override bool Validate(Invoice invoice)
    {
        return invoice.DocumentTotals?.InvoiceTotalAmountWithVAT != null;
    }
}
