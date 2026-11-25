namespace XRechnung;

/// <summary>
/// Der Rechnungstyp muss gemäß UNTDID 1001, spezifiziert werden.
/// </summary>
public record class InvoiceTypeCode : Code
{
    public static InvoiceTypeCode PartialInvoice => new() { Value = "326" };
    public static InvoiceTypeCode CommercialInvoice => new() { Value = "380" };
    public static InvoiceTypeCode CorrectedInvoice => new() { Value = "384" };
    public static InvoiceTypeCode SelfBilledInvoice => new() { Value = "389" };
    public static InvoiceTypeCode CreditNote => new() { Value = "381" };

}
