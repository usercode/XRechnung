namespace XRechnung;

/// <summary>
/// Eine Gruppe von Informationselementen, die Informationen über den Erwerber enthalten.
/// </summary>
public record class Buyer
{
    /// <summary>
    /// Der vollständige Name des Erwerbers.
    /// </summary>
    [Field("BT-44")]
    public required Text Name { get; set; }

    /// <summary>
    /// Ein Name, unter dem der Erwerber bekannt ist, sofern abweichend vom Namen des Erwerbers.
    /// </summary>
    [Field("BT-45")]
    public Text? TradingName { get; set; }

    /// <summary>
    /// Eine (i. d. R. vom Verkäufer vergebene) Kennung des Erwerbers, wie z. B. die Debitorennummer für die Buchhaltung oder die Kundennnummer für die Auftragsverwaltung.
    /// </summary>
    /// <remarks>Für die Bildung des Buyer Identifier ist kein einheitliches Schema erforderlich.</remarks>
    [Field("BT-46")]
    public Text? Identifier { get; set; }

    /// <summary>
    /// Ein von einer offiziellen Registrierstelle ausgegebener Bezeichner, der den Erwerber als Rechtsträger oder juristische Person identifiziert. Z. B. Handelsregister-Eintrag, Vereinsregister etc.
    /// </summary>
    [Field("BT-47")]
    public Identifier? LegalRegistrationIdentifier { get; set; }

    /// <summary>
    /// Die Umsatzsteuer-Identifikationsnummer des Erwerbers.
    /// </summary>
    /// <remarks>
    /// Die Umsatzsteuer-Identifikationsnummer mit vorangestelltem Präfix gem. EN ISO 3166-1 "Codes for the representation of names of countries and their subdivisions"
    /// </remarks>
    [Field("BT-48")]
    public Identifier? VATIdentifier { get; set; }

    /// <summary>
    /// Gibt eine elektronische Adresse des Erwerbers an, an die eine Rechnung gesendet werden sollte.
    /// </summary>
    [Field("BT-49")]
    public required Identifier ElectronicAddress { get; set; }

    /// <summary>
    /// Eine Gruppe von Informationselementen, die Informationen über die Anschrift des Erwerbers enthalten.
    /// </summary>
    [Field("BG-8")]
    public required BuyerPostalAddress PostalAddress { get; set; }

    /// <summary>
    /// Eine Gruppe von Informationselementen, die Angaben zum Ansprechpartner oder der Kontaktstelle beim Erwerber enthalten.
    /// </summary>
    [Field("BG-9")]
    public BuyerContact? Contact { get; set; }

}
