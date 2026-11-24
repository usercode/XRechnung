namespace XRechnung.Validation;

public class BR_S_3 : BR_S
{
    public override string ID => "BR-S-3";

    public override string Description => "In einer Rechnung, die eine Gruppe \"DOCUMENT LEVEL ALLOWANCES\" (BG-20) enthält, in der \"Document level allowance VAT category code\" (BT-95) „Standard rated“ entspricht, muss entweder die Umsatzsteuer-Identifikationsnummer des Verkäufers \"Seller VAT identifier\" (BT-31), die Steueridentifikationsnummer des Verkäufers \"Seller tax registration identifier\" (BT-32) und / oder die Umsatzsteuer-Identifikationsnummer des Steuervertreters des Verkäufers \"Seller tax representative VAT identifier\" (BT-63) vorhanden sein.";

    public override bool Validate(Invoice invoice)
    {
        bool anyTax = invoice.DocumentLevelAllowances.Any(x => x.VATCategoryCode == TaxCategoryCode.StandardRate);

        if (anyTax == false)
        {
            return true;
        }

        return invoice.Seller.VATIdentifier != null || invoice.Seller.TaxRegistrationIdentifier != null;
    }
}
