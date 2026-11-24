namespace XRechnung.Validation;

public class BR_4 : BR
{
    public override string ID => "BR_4";

    public override string Description => "Eine Rechnung (INVOICE) muss einen Rechnungstyp-Code\"Invoice type code\" (BT-3) enthalten.";

    public override string Context => RuleContext.Invoice;

    public override string Element => "BT-3";

    public override bool Validate(Invoice invoice)
    {
        return invoice.InvoiceTypeCode?.Value.HasValue() == true;
    }
}
