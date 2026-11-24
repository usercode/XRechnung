namespace XRechnung.Validation;

public class BR_7 : BR
{
    public override string ID => "BR_7";

    public override string Description => "Eine Rechnung (INVOICE) muss den Erwerbernamen \"Buyer name\" (BT-44) enthalten.";

    public override string Context => RuleContext.Buyer;

    public override string Element => "BT-44";

    public override bool Validate(Invoice invoice)
    {
        return invoice.Buyer.Name?.Value.HasValue() == true;
    }
}
