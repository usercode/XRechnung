namespace XRechnung.Validation;

public class BR_15 : BR
{
    public override string ID => "BR_15";

    public override string Description => "Eine Rechnung (INVOICE) muss den ausstehenden Betrag \"Amount due for payment\" (BT-115) enthalten.";

    public override string Context => RuleContext.DocumentTotals;

    public override string Element => "BT-115";

    public override bool Validate(Invoice invoice)
    {
        return invoice.DocumentTotals?.AmountDueForPayment != null;
    }
}
