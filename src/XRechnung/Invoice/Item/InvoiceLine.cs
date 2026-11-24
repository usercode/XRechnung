namespace XRechnung;

/// <summary>
/// Eine Gruppe von Informationselementen, die Informationen über einzelne Rechnungspositionen enthalten.
/// </summary>
public class InvoiceLine
{
    /// <summary>
    /// Eindeutige Bezeichnung für die betreffende Rechnungsposition.
    /// </summary>
    [Field("BT-126")]
    public required Identifier Identifier { get; set; }

    /// <summary>
    /// Ein Textvermerk, der unstrukturierte Informationen enthält, die für die Rechnungsposition maßgeblich sind.
    /// </summary>
    [Field("BT-127")]
    public Text? Note { get; set; }

    /// <summary>
    /// Eine vom Verkäufer angegebene Kennung für ein Objekt, auf das sich die Rechnungsposition bezieht (z. B. Zählernummer, Telefonnummer, Kfz-Kennzeichen, versicherte Person, Abonnement-Nummer, Rufnummer).
    /// </summary>
    [Field("BT-128")]
    public Identifier? InvoicedObjectIdentifier { get; set; }

    /// <summary>
    /// Die Menge zu dem in der betreffenden Zeile in Rechnung gestellten Einzelposten (Waren oder Dienstleistungen)
    /// </summary>
    [Field("BT-129")]
    public required Quantity Quantity { get; set; }

    ///// <summary>
    ///// Die für die "Invoiced quantity" (BT-129) geltende Maßeinheit. Die Maßeinheit muss unter Anwendung der in UN/ECE Rec No 20 Intro 2.a) beschriebenen Methode aus den Listen UN/ECE Recommendation No. 20 „Codes for Units of Measure Used in International Trade“ und UN/ECE Recommendation No 21 „Codes for Passengers, Types of Cargo, Packages and Packaging Materials(with Complementary Codes for Package Names)“ ausgewählt werden.
    ///// </summary>
    //[Field("BT-130")]
    //public required string UnitOfMeasure { get; set; }

    /// <summary>
    /// Der Gesamtbetrag der Rechnungsposition. Dies ist der Betrag ohne Umsatzsteuer, aber einschließlich aller für die Rechnungsposition geltenden Nachlässe und Abgaben sowie sonstiger anfallender Steuern.
    /// </summary>
    [Field("BT-131")]
    public required Amount NetAmount { get; set; }

    /// <summary>
    /// Eine Gruppe von Informationselementen, die Informationen über den Preis für die in der betreffenden Rechnungsposition in Rechnung gestellten Waren und Dienstleistungen enthalten.
    /// </summary>
    [Field("BG-29")]
    public required PriceDetails PriceDetails { get; set; }

    /// <summary>
    /// Eine Gruppe von Informationselementen, die Informationen über den für die Rechnungsposition maßgeblichen Abrechnungszeitraum enthalten.
    /// </summary>
    [Field("BG-14")]
    public Period? Period { get; set; }

    /// <summary>
    /// Eine Gruppe von Informationselementen, die Informationen über die Umsatzsteuer enthalten, die für die in der betreffenden Zeile in Rechnung gestellten Waren und Dienstleistungen gilt.    
    /// </summary>
    [Field("BG-30")]
    public required VATInformation VATInformations { get; set; }

    /// <summary>
    /// Eine Gruppe von Informationselementen, die Informationen über die in Rechnung gestellten Waren und Dienstleistungen enthalten.
    /// </summary>
    [Field("BG-31")]
    public required ItemInformation Item { get; set; }

}
