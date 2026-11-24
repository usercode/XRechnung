namespace XRechnung.Validation;

public class BR_64 : BR
{
    public override string ID => "BR_64";

    public override string Description => "Im Element \"Item standard identifier\" (BT-157) muss die Komponente „Scheme Identifier“ vorhanden sein.";

    public override string Context => RuleContext.ItemStandardIdentifier;

    public override string Element => "BT-157";

    public override bool Validate(Invoice invoice)
    {
        return invoice.InvoiceLines?.All(x => x.Item?.StandardIdentifier?.SchemeIdentifier?.HasValue() is not false) is not false;
    }
}
