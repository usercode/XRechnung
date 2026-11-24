namespace XRechnung.Validation;

public class BR_25 : BR
{
    public override string ID => "BR_25";

    public override string Description => "Jede Rechnungsposition \"INVOICE LINE\" (BG-25) muss den Namen des Postens \"Item name\" (BT-153) enthalten.";

    public override string Context => RuleContext.ItemInformation;

    public override string Element => "BT-153";

    public override bool Validate(Invoice invoice)
    {
        return invoice.InvoiceLines?.All(x => x.Item?.Name?.Value.HasValue() is true) is not false;
    }
}
