namespace XRechnung.Validation;

public class BR_S_7 : BR_S
{
    public override string ID => "BR-S-7";

    public override string Description => "In einer Gruppe \"DOCUMENT LEVEL CHARGES\" (BG-21), in der \"Document level charge VAT category code\" (BT-102) „Standard rated“ entspricht, muss \"Document level charge VAT rate\" (BT-103) größer als „0“ sein.";

    public override bool Validate(Invoice invoice)
    {
        return invoice.DocumentLevelCharges?
                        .Where(x => x.VATCategoryCode == TaxCategoryCode.StandardRate)
                        .All(x => x.VATRate.Value > 0) 
                        is not false;
    }
}
