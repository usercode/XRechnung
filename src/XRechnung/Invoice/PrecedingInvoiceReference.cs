namespace XRechnung;

/// <summary>
/// Eine Gruppe von Informationselementen, die Informationen über eine oder mehrere vorausgegangene Rechnung(en) enthalten.
/// </summary>
/// <remarks>
/// Das Informationselement ist zu verwenden, wenn eine vorangegangene Rechnung korrigiert wird, eine Abschlussrechnung auf vorangegangene Teilrechnungen Bezug nimmt oder eine Abschlussrechnung auf vorangegangene Vorauszahlungsrechnungen Bezug nimmt.
/// </remarks>
public record class PrecedingInvoiceReference
{
    /// <summary>
    /// Die Kennung der vorausgegangenen Rechnung, auf die Bezug genommen wird.
    /// </summary>
    public required string InvoiceReference { get; set; }
}
