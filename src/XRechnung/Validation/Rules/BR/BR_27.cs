namespace XRechnung.Validation;

public class BR_27 : BR
{
    public override string ID => "BR_27";

    public override string Description => "Der Artikel-Nettobetrag \"Item net price\" (BT-146) darf nicht negativ sein.";

    public override string Context => RuleContext.ItemNetPrice;

    public override string Element => "BT-146";

    public override bool Validate(Invoice invoice)
    {
        return invoice.InvoiceLines?
                            .All(x => x.PriceDetails?.ItemNetPrice?.Value.IsPositive() is not false) is not false;
    }
}
