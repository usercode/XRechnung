namespace XRechnung.Validation;

public class BR_54 : BR
{
    public override string ID => "BR_54";

    public override string Description => "Jede Eigenschaft eines in Rechnung gestellten Postens \"ITEM ATTRIBUTES\" (BG-32) muss eine Bezeichnung \"Item attribute name\" (BT-160) und einen Wert \"Item attribute value\" (BT-161) haben.";

    public override string Context => RuleContext.ItemAttribute;

    public override string Element => "BT-160 / BT-161";

    public override bool Validate(Invoice invoice)
    {
        return invoice.InvoiceLines?
                            .All(x => x.Item?.Attributes?
                                        .All(a => a?.Name?.Value.HasValue() is not false 
                                                && a?.Value?.Value.HasValue() is not false) is not false) is not false;
    }
}
