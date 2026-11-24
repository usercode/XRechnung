using System.Runtime.ConstrainedExecution;

namespace XRechnung;

/// <summary>
/// Eine Gruppe von Informationselementen, die Informationen über die Umsatzsteuer enthalten, die für die in der betreffenden Zeile in Rechnung gestellten Waren und Dienstleistungen gilt.
/// </summary>
public class VATInformation
{
    /// <summary>
    /// Der Code der für den in Rechnung gestellten Posten geltenden Umsatzsteuerkategorie.
    /// </summary>
    [Field("BT-151 ")]
    public required TaxCategoryCode VATCategoryCode { get; set; }

    /// <summary>
    /// Der für den in Rechnung gestellten Posten geltende und als Prozentsatz angegebene Umsatzsteuersatz.
    /// </summary>
    /// <remarks>
    /// Ein Umsatzsteuersatz von 0 Prozent wird für Kalkulationszwecke auch dann angewandt, wenn der Posten außerhalb der Reichweite der Umsatzsteuer ist.
    /// </remarks>
    [Field("BT-152")]
    public required Percentage VATRate { get; set; }
}
