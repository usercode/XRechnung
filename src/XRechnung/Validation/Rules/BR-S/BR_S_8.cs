namespace XRechnung.Validation;

public class BR_S_8 : BR_S
{
    public override string ID => "BR-S-8";

    public override string Description => "Für jeden anderen Wert des kategoriespezifischen Umsatzsteuersatzes \"VAT category rate\" (BT-119), bei dem der Code der Umsatzsteuerkategorie \"VAT category code\" (BT-118) „Standard rated“ entspricht, muss der nach der Umsatzsteuerkategorie zu versteuernde Betrag \"VAT category taxable amount\" (BT-116) in einer Umsatzsteueraufschlüsselung \"VAT BREAKDOWN\" (BG-23) gleich der Summe der Rechnungszeilen-Nettobeträge \"Invoice line net amount\" (BT-131) zuzüglich der Summe der Beträge aller Abgaben auf der Dokumentenebene \"Document level charge amount\" (BT-99) abzüglich der Summe der Beträge aller Nachlässe auf der Dokumentenebene \"Document level allowance amount\" (BT-92) sein; wobei der Code der Umsatzsteuerkategorie (\"Invoiced item VAT category code\" (BT-151), \"Document level charge VAT category code\" (BT-102) und \"Document level allowance VAT category code\" (BT-95)) „Standard rated“ entspricht und der Umsatzsteuersatz (\"Invoiced item VAT rate\" (BT-152), \"Document level charge VAT rate\" (BT-103) und \"Document level allowance VAT rate\" (BT-96)) gleich dem kategoriespezifischen Umsatzsteuersatz ist. Anmerkung: D.h. dass für jeden USt-Satz eine gesonderte Gruppe zur Umsatzsteueraufschlüsselung \"VAT BREAKDOWN\" (BG-23) anzulegen ist.";

    public override bool Validate(Invoice invoice)
    {


        return true;
    }
}
