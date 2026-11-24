namespace XRechnung.Validation;

public class BR_CO_12 : BR_CO
{
    public override string ID => "BR-CO-12";

    public override string Description => "Der Inhalt des Elementes \"Sum of charges on document level\" (BT-108) muss der Summe aller Inhalte der Elemente \"Document level charge amount\" (BT-99) entsprechen.";

    public override string Context => RuleContext.DocumentTotals;

    public override string Element => "BT-108";

    public override bool Validate(Invoice invoice)
    {
        return invoice.DocumentTotals.SumOfChargesOnDocumentLevel?.Value == invoice.DocumentLevelCharges.Sum(x => x.Amount.Value);
    }
}
