namespace XRechnung.Validation;

public class BR_28 : BR
{
    public override string ID => "BR_28";

    public override string Description => "Der Einheitspreis ohne Umsatzsteuer vor Abzug des Postenpreisrabatts einer Rechnungsposition \"Item gross price\" (BT-148) darf nicht negativ sein.";

    public override string Context => RuleContext.PriceDetails;

    public override string Element => "BT-148";

    public override bool Validate(Invoice invoice)
    {
        return invoice.InvoiceLines?
                            .All(x => x.PriceDetails?.ItemGrossPrice?.Value.IsPositive() is not false) is not false;
    }
}
