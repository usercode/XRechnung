namespace XRechnung.Validation;

public class BR_31 : BR
{
    public override string ID => "BR_31";

    public override string Description => "Jeder Nachlass für die Rechnung als Ganzes \"DOCUMENT LEVEL ALLOWANCES\" (BG-20) muss einen Betrag \"Document level allowance amount\" (BT-92) aufweisen.";

    public override string Context => RuleContext.DocumentLevelAllowances;

    public override string Element => "BT-92";

    public override bool Validate(Invoice invoice)
    {
        return invoice.DocumentLevelAllowances?.All(x => x.Amount != null) is not false;
    }
}
