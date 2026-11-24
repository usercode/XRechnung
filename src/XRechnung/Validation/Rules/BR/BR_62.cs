namespace XRechnung.Validation;

public class BR_62 : BR
{
    public override string ID => "BR_62";

    public override string Description => "Im Element \"Seller electronic address\" (BT-34) muss die Komponente „Scheme Identifier“ vorhanden sein.";

    public override string Context => RuleContext.SellerElectronicAddress;

    public override string Element => "BT-34";

    public override bool Validate(Invoice invoice)
    {
        return invoice.Seller?.ElectronicAddress?.SchemeIdentifier?.HasValue() is true;
    }
}
