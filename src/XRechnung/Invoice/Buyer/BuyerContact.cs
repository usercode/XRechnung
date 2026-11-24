namespace XRechnung;

/// <summary>
/// Eine Gruppe von Informationselementen, die Angaben zum Ansprechpartner oder der Kontaktstelle beim Erwerber enthalten.
/// </summary>
/// <remarks>
/// Kontaktinformationen sollen nicht zum Zweck der Weiterleitung der empfangenen Rechnung 
/// durch die rechnungsempfangende Stelle verwendet werden; für diesen Zweck soll die "Buyer reference" (BT-10) verwendet werden.
/// </remarks>
public record class BuyerContact
{
    /// <summary>
    /// Ansprechpartner oder Kontaktstelle beim Erwerber (wie z. B. Name einer Person, Abteilungs- oder Bürobezeichnung).
    /// </summary>
    [Field("BT-56")]
    public Text? Name { get; set; }

    /// <summary>
    /// Eine Telefonnummer der Kontaktstelle.
    /// </summary>
    [Field("BT-57")]
    public Text? TelephoneNumber { get; set; }

    /// <summary>
    /// Eine E-Mail-Adresse der Kontaktstelle.
    /// </summary>
    [Field("BT-58")]
    public Text? EmailAddress { get; set; }
}
