namespace XRechnung.Validation;

public class BR_CO_9 : BR_CO
{
    public override string ID => "BR-CO-9";

    public override string Description => "Der Umsatzsteuer-Identifikationsnummer des Verkäufers \"Seller VAT identifier\" (BT-31), der Umsatzsteuer-Identifikationsnummer des Steuervertreters des Verkäufers \"Seller tax representative VAT identifier\" (BT-63) und der Umsatzsteuer-Identifikationsnummer des Erwerbers \"Buyer VAT identifier\" (BT-48) muss zur Kennzeichnung des Mitgliedstaats, der sie erteilt hat, jeweils ein Präfix nach dem ISO-Code 3166 Alpha-2 vorangestellt werden. Griechenland wird jedoch ermächtigt, das Präfix „EL“ zu verwenden.";

    public override string Context => RuleContext.VATidentifiers;

    public override string Element => "BT-31 / BT-48 / BT-63";

    public override bool Validate(Invoice invoice)
    {
        return invoice.Seller?.VATIdentifier?.Value.IsValidVATIdentifier() is not false &&
                invoice.Buyer?.VATIdentifier?.Value.IsValidVATIdentifier() is not false;
    }
}
