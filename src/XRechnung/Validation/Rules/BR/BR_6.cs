namespace XRechnung.Validation;

public class BR_6 : BR
{
    public override string ID => "BR_6";

    public override string Description => "Eine Rechnung (INVOICE) muss den Verkäufernamen \"Seller name\" (BT-27) enthalten.";

    public override string Context => RuleContext.Seller;

    public override string Element => "BT-27";

    public override bool Validate(Invoice invoice)
    {
        return invoice.Seller.Name?.Value.HasValue() == true;
    }
}
