namespace XRechnung;

/// <summary>
/// Eine Gruppe von Informationselementen, die Informationen über die Umsatzsteueraufschlüsselung nach verschiedenen Kategorien, Steuersätzen und Ausnahmegründen enthalten.
/// </summary>
public class VATBreakdown
{
    /// <summary>
    /// Summe aller zu versteuernden Beträge, für die ein bestimmter Code der Umsatzsteuerkategorie und ein bestimmter Umsatzsteuersatz gelten(falls ein kategoriespezifischer Umsatzsteuersatz gilt).
    /// </summary>
    [Field("BT-116")]
    public required Amount TaxableAmount { get; set; }

    /// <summary>
    /// Der für die betreffende Umsatzsteuerkategorie zu entrichtende Gesamtbetrag.
    /// </summary>
    /// <remarks>
    /// Die Berechnung erfolgt durch Multiplikation des "VAT category taxable amount" (BT-116) mit der "VAT category rate" (BT-119) der jeweiligen VAT category.
    /// </remarks>
    [Field("BT-117")]
    public required Amount TaxAmount { get; set; }

    /// <summary>
    /// Codierte Bezeichnung einer Umsatzsteuerkategorie.
    /// </summary>
    [Field("BT-118")]
    public required TaxCategoryCode Code { get; set; }

    /// <summary>
    /// Der Umsatzsteuersatz, angegeben als für die betreffende Umsatzsteuerkategorie geltender Prozentsatz.
    /// <br/><br/>
    /// Sofern die Rechnung von der Umsatzsteuer ausgenommen ist, ist der Wert „0“ zu übermitteln.
    /// </summary>
    /// <remarks>
    /// "VAT category code" (BT-118) und "VAT category rate" (BT-119) müssen konsistent sein.
    /// </remarks>
    [Field("BT-119")]
    public required Percentage Rate { get; set; }
}
