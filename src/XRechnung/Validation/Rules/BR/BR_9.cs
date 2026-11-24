namespace XRechnung.Validation;

public class BR_9 : BR
{
    public override string ID => "BR_9";

    public override string Description => "Die postalische Anschrift des Verkäufers \"SELLER POSTAL ADDRESS\" (BG-5) muss einen Verkäufer-Ländercode \"Seller country code\" (BT-40) enthalten.";

    public override string Context => RuleContext.SellerPostalAddress;

    public override string Element => "BT-40";

    public override bool Validate(Invoice invoice)
    {
        return invoice.Seller.PostalAddress?.CountryCode?.Value.HasValue() == true;
    }
}
