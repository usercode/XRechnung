namespace XRechnung.Validation;

public class BR_CO_4 : BR_CO
{
    public override string ID => "BR-CO-4";

    public override string Description => "Jede Rechnungsposition \"INVOICE LINE\" (BG-25) muss anhand der Umsatzsteuerkategorie des in Rechnung gestellten Postens \"Invoiced item VAT category code\" (BT-151) kategorisiert werden.";

    public override string Context => RuleContext.InvoiceLine;

    public override string Element => "BT-151";

    public override bool Validate(Invoice invoice)
    {
        return invoice.InvoiceLines?.All(x => x.VATInformations?.VATCategoryCode?.Value.HasValue() is true) is not false;
    }
}
