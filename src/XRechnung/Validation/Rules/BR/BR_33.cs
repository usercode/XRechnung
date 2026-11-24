namespace XRechnung.Validation;

public class BR_33 : BR
{
    public override string ID => "BR_33";

    public override string Description => "Jeder Nachlass für die Rechnung als Ganzes \"DOCUMENT LEVEL ALLOWANCES\" (BG-20) muss einen Nachlassgrund \"Document level allowance reason\" (BT-97) oder einen entsprechenden Code\"Document level allowance reason code\" (BT-98) aufweisen.";

    public override string Context => RuleContext.DocumentLevelAllowances;

    public override string Element => "BT-97 / BT-98";

    public override bool Validate(Invoice invoice)
    {
        return invoice.DocumentLevelAllowances?.All(x => x.Reason?.Value.HasValue() is true || x.ReasonCode?.Value.HasValue() is true) is not false;
    }
}
