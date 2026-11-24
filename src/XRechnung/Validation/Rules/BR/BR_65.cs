namespace XRechnung.Validation;

public class BR_65 : BR
{
    public override string ID => "BR_65";

    public override string Description => "Im Element \"Item classification identifier\" (BT-158) muss die Komponente „Scheme Identifier“ vorhanden sein";

    public override string Context => RuleContext.ItemClassificationIdentifier;

    public override string Element => "BT-158";

    public override bool Validate(Invoice invoice)
    {
        return invoice.InvoiceLines?.All(x => x.Item?.ClassificationIdentifier?.SchemeIdentifier?.HasValue() is not false) is not false;
    }
}
