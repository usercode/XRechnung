namespace XRechnung;

/// <summary>
/// Eine Gruppe von Informationselementen, die Informationen über den für die Rechnungsposition maßgeblichen Abrechnungszeitraum enthalten.
/// </summary>
public class Period
{
    /// <summary>
    /// Das Datum, an dem der Abrechnungszeitraum der betreffenden Rechnungsposition beginnt.
    /// </summary>
    public Date? StartDate { get; set; }

    /// <summary>
    /// Das Datum, an dem der Abrechnungszeitraum der betreffenden Rechnungsposition endet.
    /// </summary>
    public Date? EndDate { get; set; }
}
