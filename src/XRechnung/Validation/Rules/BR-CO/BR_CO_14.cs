namespace XRechnung.Validation;

public class BR_CO_14 : BR_CO
{
    public override string ID => "BR-CO-14";

    public override string Description => "Der Inhalt des Elementes \"Invoice total VAT amount\" (BT-110) muss der Summe aller Inhalte der Elemente \"VAT category tax amount\" (BT-117) entsprechen.";

    public override string Context => RuleContext.DocumentTotals;

    public override string Element => "BT-110";

    public override bool Validate(Invoice invoice)
    {
        if (invoice.DocumentTotals?.InvoiceTotalVATAmount == null)
        {
            return true;
        }

        return (invoice.DocumentTotals?.InvoiceTotalVATAmount?.Value).GetValueOrZero() == invoice.VATBreakdowns.Sum(i => i.TaxAmount.Value);
    }
}
