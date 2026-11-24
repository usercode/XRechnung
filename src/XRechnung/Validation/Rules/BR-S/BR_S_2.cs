namespace XRechnung.Validation;

public class BR_S_2 : BR_S
{
    public override string ID => "BR-S-2";

    public override string Description => "Eine Rechnung (INVOICE), die eine Rechnungsposition \"INVOICE LINE\" (BG-25) enthält, in der als Code der Umsatzsteuerkategorie für den in Rechnung gestellten Posten \"Invoiced item VAT category code\" (BT-151) entsprechend „Standard rated“ angegeben ist, muss die Umsatzsteuer-Identifikationsnummer des Verkäufers \"Seller VAT identifier\" (BT-31), die Steueridentifikationsnummer des Verkäufers \"Seller tax registration identifier\" (BT-32) und / oder die Umsatzsteuer-Identifikationsnummer des Steuervertreters des Verkäufers \"Seller tax representative VAT identifier\" (BT-63) enthalten.";

    public override bool Validate(Invoice invoice)
    {
        bool anyTax = invoice.InvoiceLines.Any(x => x.VATInformations.VATCategoryCode == TaxCategoryCode.StandardRate);

        if (anyTax == false)
        {
            return true;
        }

        return invoice.Seller.VATIdentifier != null || invoice.Seller.TaxRegistrationIdentifier != null;
    }
}
