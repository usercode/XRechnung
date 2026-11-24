namespace XRechnung.Validation;

public class BR_5 : BR
{
    public override string ID => "BR_5";

    public override string Description => "Eine Rechnung (INVOICE) muss einen Währungs-Code \"Invoice currency code\" (BT-5) enthalten.";

    public override string Context => RuleContext.Invoice;

    public override string Element => "BT-5";

    public override bool Validate(Invoice invoice)
    {
        return invoice.CurrencyCode?.Value.HasValue() == true;
    }
}
