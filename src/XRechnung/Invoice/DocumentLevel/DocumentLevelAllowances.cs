namespace XRechnung;

/// <summary>
/// Eine Gruppe von Informationselementen, die Informationen über Nachlässe enthalten, die für die Rechnung als Ganzes gelten.
/// </summary>
public class DocumentLevelAllowances : IAllowanceCharge
{
    /// <summary>
    /// Der Nachlassbetrag ohne Umsatzsteuer.
    /// </summary>
    [Field("BT-92")]
    public required Amount Amount { get; set; }

    /// <summary>
    /// Der Grundbetrag, der in Verbindung mit der "Document level allowance percentage" (BT-94) zur Berechnung des "Document level allowance amount" (BT-92) verwendet werden kann.
    /// </summary>
    [Field("BT-93")]
    public Amount? BaseAmount { get; set; }

    /// <summary>
    /// Der Prozentsatz, der in Verbindung mit dem "Document level allowance base amount" (BT-93) zur Berechnung des "Document level allowance amount" (BT-92) verwendet werden kann.
    /// </summary>
    [Field("BT-94")]
    public Percentage? Percentage { get; set; }

    /// <summary>
    /// Ein Code für das Umsatzsteuermerkmal, das auf den "Document level allowance amount" (BT-92) anzuwenden ist.
    /// </summary>
    [Field("BT-95")]
    public required TaxCategoryCode VATCategoryCode { get; set; }

    /// <summary>
    /// Der für den "Document level allowance amount" (BT-92) geltende und in Prozent angegebene Umsatzsteuersatz.
    /// </summary>
    [Field("BT-96")]
    public required Percentage VATRate { get; set; }

    /// <summary>
    /// Der in Textform angegebene Grund für den "Document level allowance amount" (BT-92)
    /// </summary>
    [Field("BT-97")]
    public Text? Reason { get; set; }

    /// <summary>
    /// Der als Code angegebene Grund für den "Document level allowance amount" (BT-92).
    /// </summary>
    /// <remarks>
    /// Hier sind die Codes aus der Codeliste UNTDID 5189 zu verwenden. Dabei müssen Document level allowance reason code und "Document level allowance reason"(BT - 97) den gleichen Grund für den Nachlass angeben.
    /// </remarks>
    [Field("BT-98")]
    public Code? ReasonCode { get; set; }
}
