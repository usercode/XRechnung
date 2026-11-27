namespace XRechnung;

/// <summary>
/// Eine Gruppe von Informationselementen, die Kontaktinformationen des Verkäufers enthalten.
/// </summary>
public class SellerContact
{
    /// <summary>
    /// Angaben zu Ansprechpartner oder Kontaktstelle (wie z. B. Name einer Person, Abteilungs- oder Bürobezeichnung).
    /// </summary>
    [Field("BT-41")]
    public required Text Name { get; set; }

    /// <summary>
    /// Telefonnummer des Ansprechpartners oder der Kontaktstelle
    /// </summary>
    [Field("BT-42")]
    public required Text TelephoneNumber { get; set; }

    /// <summary>
    /// Eine E-Mail-Adresse des Ansprechpartners oder der Kontaktstelle.
    /// </summary>
    [Field("BT-43")]
    public required Text EmailAddress { get; set; }
}
