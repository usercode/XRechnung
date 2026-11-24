namespace XRechnung.Validation;

public class BR_3 : BR
{
    public override string ID => "BR_3";

    public override string Description => "Eine Rechnung (INVOICE) muss ein Rechnungsdatum \"Invoice issue date\" (BT-2) enthalten.";

    public override string Context => RuleContext.Invoice;

    public override string Element => "BT-2";

    public override bool Validate(Invoice invoice)
    {
        return invoice.IssueDate != null;
    }
}
