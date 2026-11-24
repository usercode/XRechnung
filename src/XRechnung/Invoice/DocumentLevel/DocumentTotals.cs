namespace XRechnung;

/// <summary>
/// Eine Gruppe von Informationselementen, die die monetären Gesamtbeträge der Rechnung enthalten.
/// </summary>
public class DocumentTotals
{
    /// <summary>
    /// Summe aller "Invoice line net amount" (BT-131) der Rechnung.
    /// </summary>
    [Field("BT-106")]
    public required Amount SumOfInvoiceLineNetAmount { get; set; }

    /// <summary>
    /// Summe aller in der Rechnung enthaltenen "Document level allowance amount" (BT-92).
    /// </summary>
    [Field("BT-107")]
    public Amount? SumOfAllowancesOnDocumentLevel { get; set; }

    /// <summary>
    /// Summe aller in der Rechnung enthaltenen "Document level charge amount" (BT-99).
    /// </summary>
    [Field("BT-108")]
    public Amount? SumOfChargesOnDocumentLevel { get; set; }

    /// <summary>
    /// Der Gesamtbetrag der Rechnung ohne Umsatzsteuer.
    /// </summary>
    [Field("BT-109")]
    public required Amount InvoiceTotalAmountWithoutVAT { get; set; }

    /// <summary>
    /// Der Gesamtbetrag der Umsatzsteuer für die Rechnung.
    /// </summary>
    [Field("BT-110")]
    public Amount? InvoiceTotalVATAmount { get; set; }

    /// <summary>
    /// Der Gesamtbetrag der Rechnung mit Umsatzsteuer.
    /// </summary>
    [Field("BT-112")]
    public required Amount InvoiceTotalAmountWithVAT { get; set; }

    /// <summary>
    /// Summe bereits gezahlter Beträge.
    /// </summary>
    [Field("BT-114")]
    public Amount? PaidAmount { get; set; }

    /// <summary>
    /// Der ausstehende Betrag, der zu zahlen ist.
    /// </summary>
    /// <remarks>
    /// Dieser Betrag ist der "Invoice total amount with VAT" (BT-112) abzüglich des "Paid amount" (BT-113). Im Falle einer vollständig beglichenen Rechnung ist dieser Betrag gleich null. Der Betrag ist negativ, falls der "Paid amount" (BT-113) größer als der "Invoice total amount with VAT" (BT-112) ist.
    /// </remarks>
    [Field("BT-115")]
    public required Amount AmountDueForPayment { get; set; }
}
