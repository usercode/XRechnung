namespace XRechnung.Validation;

public class BR_10 : BR
{
    public override string ID => "BR_10";

    public override string Description => "Eine Rechnung (INVOICE) muss die postalische Anschrift des Erwerbers \"BUYER POSTAL ADDRESS\" (BG-8) enthalten.";

    public override string Context => RuleContext.Buyer;

    public override string Element => "BG-8";

    public override bool Validate(Invoice invoice)
    {
        return invoice.Buyer.PostalAddress != null;
    }
}
