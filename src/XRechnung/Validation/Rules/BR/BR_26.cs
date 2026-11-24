namespace XRechnung.Validation;

public class BR_26 : BR
{
    public override string ID => "BR_26";

    public override string Description => "Jede Rechnungsposition \"INVOICE LINE\" (BG-25) muss den Preis des Postens, ohne Umsatzsteuer, nach Abzug des für diese Rechnungsposition geltenden Rabatts \"Item net price\" (BT-146) beinhalten.";

    public override string Context => RuleContext.PriceDetails;

    public override string Element => "BT-146";

    public override bool Validate(Invoice invoice)
    {
        return invoice.InvoiceLines?.All(x => x.PriceDetails?.ItemNetPrice != null) is not false;
    }
}
