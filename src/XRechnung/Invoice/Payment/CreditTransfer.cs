namespace XRechnung;

/// <summary>
/// Eine Gruppe von Informationselementen, die Informationen über das Bankkonto geben, auf das die Überweisung zu leisten ist.
/// </summary>
public class CreditTransfer
{
    /// <summary>
    /// Die Kennung des Kontos, auf das die Zahlung erfolgen soll: IBAN für Zahlungen im SEPA-Raum, Kontonummer oder IBAN im Falle von Auslandszahlungen.
    /// </summary>
    [Field("BT-84")]
    public required Identifier AccountIdentifier { get; set; }

    /// <summary>
    /// Name des Kontos bei einem Zahlungsdienstleister, auf das die Zahlung erfolgen soll. (z. B. Kontoinhaber)
    /// </summary>
    [Field("BT-85")]
    public Text? AccountName { get; set; }

    /// <summary>
    /// Die Kennung des Konto führenden Zahlungsdienstleisters. Diese Kennung ergibt sich bei Zahlungen im SEPA-Raum im Regelfall aus der IBAN.
    /// </summary>
    /// <remarks>
    /// Für alle Auslandszahlungen:
    /// <br /><br />
    /// - außerhalb des SEPA-Raumes wird der Bank Identifier Code (BIC) benötigt. Dies wird durch Code 30 (Credit transfer(non-SEPA) in "Payment means type code" (BT-81) gekennzeichnet.
    /// <br /><br />
    /// - innerhalb des SEPA-Raumes wird der Bank Identifier Code (BIC) nicht benötigt. Es reicht die Angabe der IBAN.Dies wird durch Code 58 „SCT“ in "Payment means type code" (BT-81) gekennzeichnet. Ausgenommen sind Zahlungen an Bankverbindungen z.B. in San Marino, Monaco, Schweiz, Saint Pierre und Miquelon: Hier ist die Angabe des BIC zwingend erforderlich.
    /// </remarks>
    [Field("BT-86")]
    public Identifier? ServiceProviderIdentifier { get; set; }
}
