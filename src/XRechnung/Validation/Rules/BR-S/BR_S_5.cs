namespace XRechnung.Validation;

public class BR_S_5 : BR_S
{
    public override string ID => "BR-S-5";

    public override string Description => "In einer Gruppe \"INVOICE LINE\" (BG-25), in der \"Invoiced item VAT category code\" (BT-151) „Standard rated“ entspricht, muss \"Invoiced item VAT rate\" (BT-152) größer als „0“ sein.";

    public override bool Validate(Invoice invoice)
    {
        return invoice.InvoiceLines?
                        .Where(x => x.VATInformations.VATCategoryCode == TaxCategoryCode.StandardRate)
                        .All(x => x.VATInformations.VATRate.Value > 0) 
                        is not false;
    }
}
