namespace XRechnung;

/// <summary>
/// Eine Gruppe von Informationselementen, die Informationen über den Geschäftsprozess und für die Rechnung geltende Regeln enthalten.
/// </summary>
public class ProcessControl
{
    /// <summary>
    /// Identifiziert den Kontext des Geschäftsprozesses, in dem die Transaktion erfolgt. Er ermöglicht es dem Erwerber, die Rechnung in angemessener Weise zu verarbeiten.
    /// </summary>
    [Field("BT-23")]
    public Text BusinessProcessType { get; set; } = "urn:fdc:peppol.eu:2017:poacc:billing:01:1.0";

    /// <summary>
    /// Eine Kennung der Spezifikation, die das gesamte Regelwerk zum semantischen Inhalt, zu den Kardinalitäten und den Geschäftsregeln enthält, dem die in der Rechnung enthaltenen Daten entsprechen.
    /// </summary>
    [Field("BT-24")]
    public Identifier SpecificationIdentifier { get; set; } = "urn:cen.eu:en16931:2017#compliant#urn:xeinkauf.de:kosit:xrechnung_3.0";
}
