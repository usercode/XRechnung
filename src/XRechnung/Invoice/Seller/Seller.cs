namespace XRechnung;

/// <summary>
/// Eine Gruppe von Informationselementen, die Informationen über den Verkäufer enthalten.
/// </summary>
public class Seller
{
    /// <summary>
    /// Der vollständige Name, unter dem der Verkäufer im nationalen Register für juristische Personen oder als steuerpflichtige Person eingetragen ist oder anderweitig als Person(en) handelt (Firma).
    /// </summary>
    [Field("BT-27")]
    public required Text Name { get; set; }

    /// <summary>
    /// Ein Name, unter dem der Verkäufer bekannt ist, sofern abweichend vom Namen des Verkäufers.
    /// </summary>
    [Field("BT-28")]
    public Text? TradingName { get; set; }

    /// <summary>
    /// Eine (i. d. R. vom Erwerber vergebene) Kennung des Verkäufers, wie z. B. die Kreditorennummer für das Mittelbewirtschaftungsverfahren oder die Lieferantennummer für das Bestellsystem.
    /// </summary>
    [Field("BT-29")]
    public List<Identifier> Identifiers { get; set; } = [];

    /// <summary>
    /// Eine von einer offiziellen Registrierstelle ausgegebene Kennung, die den Verkäufer als Rechtsträger oder juristische Person identifiziert.
    /// </summary>
    /// <remarks>Wenn ein Schema verwendet wird, ist es aus der Liste der ISO/IEC 6523 Maintenance Agency zu wählen.</remarks>
    [Field("BT-30")]
    public Identifier? LegalRegistrationIdentifier { get; set; }

    /// <summary>
    /// Die Umsatzsteuer-Identifikationsnummer des Verkäufers. Verfügt der Verkäufer über eine solche, ist sie hier anzugeben, sofern nicht Angaben zum "SELLER TAX REPRESENTATIVE PARTY" (BG-11) gemacht werden.
    /// </summary>
    /// <remarks>
    /// Die Umsatzsteuer-Identifikationsnummer mit vorangestelltem Präfix gem. EN ISO 3166-1 "Codes for the representation of names of countries and their subdivisions"
    /// </remarks>
    [Field("BT-31")]
    public Identifier? VATIdentifier { get; set; }

    /// <summary>
    /// Eine örtliche steuerrechtliche Kennung des Verkäufers (bestimmt durch dessen Adresse) oder ein Verweis auf seinen eingetragenen Steuerstatus. (Hier ist ggf.die Angabe „Steuerschuldnerschaft des Leistungsempfängers“ oder die USt-Befreiung des Rechnungsstellers einzutragen.)
    /// </summary>
    [Field("BT-32")]
    public Identifier? TaxRegistrationIdentifier { get; set; }

    /// <summary>
    /// Gibt die elektronische Adresse des Verkäufers an, an die die Antwort der Anwendungsebene auf eine Rechnung gesendet werden kann.
    /// </summary>
    [Field("BT-34")]
    public required Identifier ElectronicAddress { get; set; }

    /// <summary>
    /// Eine Gruppe von Informationselementen, die Informationen über die Verkäuferanschrift enthalten.
    /// </summary>
    [Field("BG-5")]
    public required SellerPostalAddress PostalAddress { get; set; }

    /// <summary>
    /// Eine Gruppe von Informationselementen, die Kontaktinformationen des Verkäufers enthalten.
    /// </summary>
    [Field("BG-6")]
    public required SellerContact Contact { get; set; }

}
