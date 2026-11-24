namespace XRechnung.Validation;

public class BR_8 : BR
{
    public override string ID => "BR_8";

    public override string Description => "Eine Rechnung (INVOICE) muss die postalische Anschrift des Verkäufers \"SELLER POSTAL ADDRESS\" (BG-5) enthalten.";

    public override string Context => RuleContext.Seller;

    public override string Element => "BG-5";

    public override bool Validate(Invoice invoice)
    {
        return invoice.Seller.PostalAddress != null;
    }
}
