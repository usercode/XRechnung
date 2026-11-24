namespace XRechnung.Validation;

public class BR_11 : BR
{
    public override string ID => "BR_11";

    public override string Description => "Die postalische Anschrift des Erwerbers \"BUYER POSTAL ADDRESS\" (BG-8) muss einen Erwerber-Ländercode \"Buyer country code\" (BT-55) enthalten.";

    public override string Context => RuleContext.BuyerPostalAddress;

    public override string Element => "BT-55";

    public override bool Validate(Invoice invoice)
    {
        return invoice.Buyer.PostalAddress?.CountryCode?.Value.HasValue() == true;
    }
}
