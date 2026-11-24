namespace XRechnung.Validation;

public class BR_CO_11 : BR_CO
{
    public override string ID => "BR-CO-11";

    public override string Description => "Der Inhalt des Elementes \"Sum of allowances on document level\" (BT-107) muss der Summe aller Inhalte der Elemente \"Document level allowance amount\" (BT-92) entsprechen.";

    public override string Context => RuleContext.DocumentTotals;

    public override string Element => "BT-107";

    public override bool Validate(Invoice invoice)
    {
        return invoice.DocumentTotals.SumOfAllowancesOnDocumentLevel?.Value == invoice.DocumentLevelAllowances.Sum(x => x.Amount.Value);
    }
}
