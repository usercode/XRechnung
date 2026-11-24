namespace XRechnung.Validation;

public class BR_32 : BR
{
    public override string ID => "BR_32";

    public override string Description => "Jeder Nachlass für die Rechnung als Ganzes \"DOCUMENT LEVEL ALLOWANCES\" (BG-20) muss einen Umsatzsteuer-Code \"Document level allowance VAT category code\" (BT-95) aufweisen.";

    public override string Context => RuleContext.DocumentLevelAllowances;

    public override string Element => "BT-95";

    public override bool Validate(Invoice invoice)
    {
        return invoice.DocumentLevelAllowances?.All(x => x.VATCategoryCode?.Value.HasValue() is true) is not false;
    }
}
