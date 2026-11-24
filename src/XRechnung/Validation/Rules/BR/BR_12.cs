namespace XRechnung.Validation;

public class BR_12 : BR
{
    public override string ID => "BR_12";

    public override string Description => "Eine Rechnung (INVOICE) muss die Summe der Nettobeträge der Rechnungspositionen \"Sum of Invoice line net amount\" (BT-106) enthalten.";

    public override string Context => RuleContext.DocumentTotals;

    public override string Element => "BT-106";

    public override bool Validate(Invoice invoice)
    {
        return invoice.DocumentTotals?.SumOfInvoiceLineNetAmount != null;
    }
}
