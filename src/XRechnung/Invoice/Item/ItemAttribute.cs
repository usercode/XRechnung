namespace XRechnung;

/// <summary>
/// Eine Gruppe von Informationselementen, die Informationen über die Eigenschaften der in Rechnung gestellten Waren und Dienstleistungen enthalten.
/// </summary>
public class ItemAttribute
{
    /// <summary>
    /// Der Name der Eigenschaft des Postens, wie z. B. „Farbe“.
    /// </summary>
    [Field("BT-160")]
    public required Text Name { get; set; }

    /// <summary>
    /// Der Wert der Eigenschaft des Postens, wie z. B. „rot“
    /// </summary>
    [Field("BT-161")]
    public required Text Value { get; set; }
}
