namespace XRechnung;

/// <summary>
/// Eine Gruppe von Informationselementen, die Informationen über Kosten, Zuschläge, und Steuern – ausgenommen die Umsatzsteuer – enthalten, die für die Rechnung als Ganzes gelten.
/// </summary>
public class DocumentLevelCharges : IAllowanceCharge
{
    /// <summary>
    /// Der Betrag einer Abgabe ohne die Umsatzsteuer.
    /// </summary>
    [Field("BT-99")]
    public required Amount Amount { get; set; }

    /// <summary>
    /// Der Grundbetrag, der in Verbindung mit dem "Document level charge percentage" (BT-101) zur Berechnung des "Document level charge amount" (BT-99) verwendet werden kann(Bemessungsgrundlage).
    /// </summary>
    [Field("BT-100")]
    public Amount? BaseAmount { get; set; }

    /// <summary>
    /// Der Prozentsatz, der in Verbindung mit dem "Document level charge base amount" (BT-100) zur Berechnung des "Document level charge amount" (BT-99) verwendet werden kann.
    /// </summary>
    [Field("BT-101")]
    public Percentage? Percentage { get; set; }

    /// <summary>
    /// Ein Code für das Umsatzsteuermerkmal dieser Elementgruppe.
    /// </summary>
    [Field("BT-102")]
    public required TaxCategoryCode VATCategoryCode { get; set; }

    /// <summary>
    /// Der Umsatzsteuersatz, dargestellt als Prozentsatz, der für die Abgaben auf der Dokumentenebene "Document level charge amount" (BT-99) gilt.
    /// </summary>
    [Field("BT-103")]
    public required Percentage VATRate { get; set; }

    /// <summary>
    /// Der in Textform angegebene Grund für die Abgaben auf der Dokumentenebene.
    /// </summary>
    [Field("BT-104")]
    public Text? Reason { get; set; }

    /// <summary>
    /// Der als Code angegebene Grund für die Abgaben auf der Dokumentenebene.
    /// </summary>
    /// <remarks>
    /// Hier sind die Codes aus der Codeliste UNTDID 7161 zu verwenden. "Document level charge reason code" (BT-105) und "Document level charge reason" (BT-104) müssen auf den gleichen Grund für die Abgaben auf Dokumentenebene verweisen.
    /// </remarks>
    [Field("BT-105")]
    public Code? ReasonCode { get; set; }
}
