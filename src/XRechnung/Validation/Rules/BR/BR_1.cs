namespace XRechnung.Validation;

public class BR_1 : BR
{
    public override string ID => "BR_1";

    public override string Description => "Eine Rechnung (INVOICE) muss eine Spezifikationskennung \"Specification identifier\" (BT-24) enthalten.";

    public override string Context => RuleContext.ProcessControl;

    public override string Element => "BT-24";

    public override bool Validate(Invoice invoice)
    {
        return invoice.ProcessControl?.SpecificationIdentifier?.Value.HasValue() == true;
    }
}
