namespace XRechnung;

/// <summary>
/// Eine Gruppe von Informationselementen, die Informationen über den Preis für die in der betreffenden Rechnungsposition in Rechnung gestellten Waren und Dienstleistungen enthalten.
/// </summary>
public class PriceDetails
{
    /// <summary>
    /// Der Preis eines Postens, ohne Umsatzsteuer, nach Abzug des für diese Rechnungsposition geltenden Rabatts.
    /// </summary>
    /// <remarks>
    ///  "Item net price" (BT-146) muss gleich "Item gross price" (BT-148) abzüglich "Item price discount" (BT-147) sein.
    /// </remarks>
    [Field("BT-146 ")]
    public required UnitPriceAmount ItemNetPrice { get; set; }

    /// <summary>
    /// Der gesamte zur Berechnung des Netto-Postenpreises vom Brutto-Postenpreis subtrahierte Rabatt.
    /// </summary>
    /// <remarks>
    /// Nur anzugeben, wenn der Nachlass pro Verpackungseinheit gegeben wird und nicht in den "Item gross price" (BT-148) inkludiert ist.
    /// </remarks>
    [Field("BT-147")]
    public UnitPriceAmount? ItemPriceDdiscount { get; set; }

    /// <summary>
    /// Der Postenpreis ohne Umsatzsteuer vor Abzug des Postenpreisrabatts.
    /// </summary>
    [Field("BT-148")]
    public UnitPriceAmount? ItemGrossPrice { get; set; }

    /// <summary>
    /// Die Anzahl von Einheiten, für die der Postenpreis gilt.
    /// </summary>
    [Field("BT-149")]
    public Quantity? ItemPriceBaseQuantity { get; set; }
}
