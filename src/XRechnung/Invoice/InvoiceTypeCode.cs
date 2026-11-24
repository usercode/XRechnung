namespace XRechnung;

public record class InvoiceTypeCode
{
    public static readonly InvoiceTypeCode PartialInvoice = new InvoiceTypeCode("326");
    public static readonly InvoiceTypeCode CommercialInvoice = new InvoiceTypeCode("380");
    public static readonly InvoiceTypeCode CorrectedInvoice = new InvoiceTypeCode("384");
    public static readonly InvoiceTypeCode SelfBilledInvoice = new InvoiceTypeCode("389");
    public static readonly InvoiceTypeCode CreditNote = new InvoiceTypeCode("381");

    public InvoiceTypeCode(string value)
    {
        Value = value;
    }

    /// <summary>
    /// Value
    /// </summary>
    public string Value { get; set; }
}
