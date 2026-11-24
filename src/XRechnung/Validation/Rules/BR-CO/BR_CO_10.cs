namespace XRechnung.Validation;

public class BR_CO_10 : BR_CO
{
    public override string ID => "BR-CO-10";

    public override string Description => "Der Inhalt des Elementes \"Sum of Invoice line net amount\" (BT-106) muss der Summe aller Inhalte der Elemente \"Invoice line net amount\" (BT-131) entsprechen.";

    public override string Context => RuleContext.DocumentTotals;

    public override string Element => "BT-106";

    public override bool Validate(Invoice invoice)
    {
        return invoice.DocumentTotals.SumOfInvoiceLineNetAmount.Value == invoice.InvoiceLines.Sum(i => i.NetAmount.Value);
    }
}
