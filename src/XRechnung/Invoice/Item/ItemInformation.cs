namespace XRechnung;

/// <summary>
/// Eine Gruppe von Informationselementen, die Informationen über die in Rechnung gestellten Waren und Dienstleistungen enthalten.
/// </summary>
public class ItemInformation
{
    /// <summary>
    /// Ein Name des Postens.
    /// </summary>
    [Field("BT-153")]
    public required Text Name { get; set; }

    /// <summary>
    /// Eine Beschreibung des Postens.
    /// </summary>
    /// <remarks>
    /// Hier kann der Posten detaillierter beschrieben werden als im Namen.
    /// </remarks>
    [Field("BT-154")]
    public Text? Description { get; set; }

    /// <summary>
    /// Eine dem Posten vom Verkäufer zugewiesene Kennung.
    /// </summary>
    [Field("BT-155")]
    public Identifier? SellersIdentifier { get; set; }

    /// <summary>
    /// Eine dem Posten vom Erwerber zugewiesene Kennung.
    /// </summary>
    [Field("BT-156")]
    public Identifier? BuyersIdentifier { get; set; }

    /// <summary>
    /// Eine auf einem registrierten Schema basierende Postenkennung.
    /// </summary>
    [Field("BT-157")]
    public Identifier? StandardIdentifier { get; set; }

    /// <summary>
    /// Ein Code für die Klassifizierung des Postens nach Typ bzw. Art oder Wesen bzw. Beschaffenheit.
    /// </summary>
    [Field("BT-158")]
    public Identifier? ClassificationIdentifier { get; set; }

    /// <summary>
    /// Der Ländercode, der das Land angibt, aus dem die Ware stammt oder in dem die Dienstleistung erbracht wird.
    /// </summary>
    [Field("BT-159")]
    public CountryCode? CountryOfOrigin { get; set; }

    /// <summary>
    /// Eine Gruppe von Informationselementen, die Informationen über die Eigenschaften der in Rechnung gestellten Waren und Dienstleistungen enthalten.
    /// </summary>
    public ItemAttribute[] Attributes { get; set; } = [];

}
