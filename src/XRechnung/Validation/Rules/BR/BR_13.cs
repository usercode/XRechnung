namespace XRechnung.Validation;

public class BR_13 : BR
{
    public override string ID => "BR_13";

    public override string Description => "Eine Rechnung (INVOICE) muss den Gesamtbetrag der Rechnung ohne Umsatzsteuer \"Invoice total amount without VAT\" (BT-109) enthalten.";

    public override string Context => RuleContext.DocumentTotals;

    public override string Element => "BT-109";

    public override bool Validate(Invoice invoice)
    {
        return invoice.DocumentTotals?.InvoiceTotalAmountWithoutVAT != null;
    }
}
