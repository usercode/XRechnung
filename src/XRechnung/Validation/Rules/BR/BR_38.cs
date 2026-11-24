namespace XRechnung.Validation;

public class BR_38 : BR
{
    public override string ID => "BR_38";

    public override string Description => "Jede Abgabe auf Dokumentenebene \"DOCUMENT LEVEL CHARGES\" (BG-21) muss einen Abgabegrund \"Document level charge reason\" (BT-104) oder einen entsprechenden Code \"Document level charge reason code\" (BT-105) aufweisen.";

    public override string Context => RuleContext.DocumentLevelCharges;

    public override string Element => "BT-104 / BT-05";

    public override bool Validate(Invoice invoice)
    {
        return invoice.DocumentLevelCharges?.All(x => x.Reason?.Value.HasValue() is true || x.ReasonCode?.Value.HasValue() is true) is not false;
    }
}
