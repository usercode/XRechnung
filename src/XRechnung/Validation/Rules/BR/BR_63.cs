namespace XRechnung.Validation;

public class BR_63 : BR
{
    public override string ID => "BR_63";

    public override string Description => "Im Element \"Buyer electronic address\" (BT-49) muss die Komponente „Scheme Identifier“ vorhanden sein.";

    public override string Context => RuleContext.BuyerElectronicAddress;

    public override string Element => "BT-49";

    public override bool Validate(Invoice invoice)
    {
        return invoice.Buyer?.ElectronicAddress?.SchemeIdentifier?.HasValue() is true;
    }
}
