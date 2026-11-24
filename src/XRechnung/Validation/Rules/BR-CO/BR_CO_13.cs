namespace XRechnung.Validation;

public class BR_CO_13 : BR_CO
{
    public override string ID => "BR-CO-13";

    public override string Description => "Der Inhalt des Elementes \"Invoice total amount without VAT\" (BT-109) muss der Summe aller Inhalte der Elemente \"Invoice line net amount\" (BT-131) abzüglich der Summe aller in der Rechnung enthaltenen Nachlässe der Dokumentenebene \"Sum of allowances on document level\" (BT-107) zuzüglich der Summe aller in der Rechnung enthaltenen Abgaben der Dokumentenebene \"Sum of charges on document level\" (BT-108) entsprechen.";

    public override string Context => RuleContext.DocumentTotals;

    public override string Element => "BT-109";

    public override bool Validate(Invoice invoice)
    {
        return invoice.DocumentTotals.InvoiceTotalAmountWithoutVAT.Value ==
                        (invoice.InvoiceLines.Sum(i => i.NetAmount.Value)
                        - (invoice.DocumentTotals.SumOfAllowancesOnDocumentLevel?.Value ?? 0m)
                        + (invoice.DocumentTotals.SumOfChargesOnDocumentLevel?.Value ?? 0m));
    }
}
