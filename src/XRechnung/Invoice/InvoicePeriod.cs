namespace XRechnung;

/// <summary>
/// Eine Gruppe von Informationselementen, die Informationen über den Abrechnungszeitraum enthalten.
/// </summary>
public class InvoicePeriod
{
    /// <summary>
    /// Das Datum, an dem der Abrechnungszeitraum beginnt.
    /// </summary>
    [Field("BT-73")]
    public Date? StartDate { get; set; }

    /// <summary>
    /// Das Datum, an dem der Abrechnungszeitraum endet.
    /// </summary>
    [Field("BT-74")]
    public Date? EndDate { get; set; }
}
