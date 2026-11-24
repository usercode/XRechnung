namespace XRechnung.Validation;

public class BR_S_6 : BR_S
{
    public override string ID => "BR-S-6";

    public override string Description => "In einer Gruppe \"DOCUMENT LEVEL ALLOWANCES\" (BG-20), in der \"Document level allowance VAT category code\" (BT-95) „Standard rated“ entspricht, muss \"Document level allowance VAT rate\" (BT-96) größer als „0“ sein.";

    public override bool Validate(Invoice invoice)
    {
        return invoice.DocumentLevelAllowances?
                        .Where(x => x.VATCategoryCode == TaxCategoryCode.StandardRate)
                        .All(x => x.VATRate.Value > 0) 
                        is not false;
    }
}
