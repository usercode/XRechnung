namespace XRechnung.Validation;

public class BR_CO_15 : BR_CO
{
    public override string ID => "BR-CO-15";

    public override string Description => "Der Inhalt des Elementes \"Invoice total amount with VAT\" (BT-112) muss der Summe des Inhalts des Elementes \"Invoice total amount without VAT\" (BT-109) und des Elementes \"Invoice total VAT amount\" (BT-110) entsprechen.";

    public override string Context => RuleContext.DocumentTotals;

    public override string Element => "BT-112";

    public override bool Validate(Invoice invoice)
    {
        if (invoice.DocumentTotals.InvoiceTotalVATAmount == null)
        {
            return true;
        }

        return invoice.DocumentTotals.InvoiceTotalAmountWithVAT.Value ==
                                            invoice.DocumentTotals.InvoiceTotalAmountWithoutVAT.Value
                                            + invoice.DocumentTotals.InvoiceTotalVATAmount.Value;
    }
}
