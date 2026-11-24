namespace XRechnung;

/// <summary>
/// Eine Gruppe von Informationselementen für rechnungsrelevante Erläuterungen mit Hinweisen auf den Rechnungsbetreff.
/// </summary>
public class InvoiceNote
{
    /// <summary>
    /// Der Betreff für den nachfolgenden Textvermerk zur Rechnung.
    /// </summary>
    /// <remarks>
    /// Die Auswahl erfolgt aus UNTDID 4451.
    /// </remarks>
    [Field("BT-21")]
    public InvoiceNoteCode? SubjectCode { get; set; }

    /// <summary>
    /// Ein Textvermerk, der unstrukturierte Informationen enthält, die für die Rechnung als Ganzes maßgeblich sind. Erforderlichenfalls können Angaben zur Aufbewahrungspflicht gem. § 14 Abs. 4 Nr. 9 UStG hier aufgenommen werden.
    /// </summary>
    /// <remarks>
    ///  Im Falle einer bereits fakturierten Rechnung kann hier z. B. der Grund der Korrektur angegeben werden.
    /// </remarks>
    [Field("BT-22")]
    public required Text Note { get; set; }
}
