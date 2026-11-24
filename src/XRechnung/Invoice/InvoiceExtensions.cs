namespace XRechnung;

public static partial class InvoiceExtensions
{
    /// <summary>
    /// Calculates the VAT breakdown and total amounts for an invoice.
    /// </summary>
    /// <param name="invoice">The invoice whose totals and VAT breakdown are calculated.</param>
    /// <returns>The invoice with calculated VAT breakdown and document totals.</returns>
    /// <exception cref="Exception">Thrown when the invoice contains no invoice lines.</exception>
    public static Invoice CalculateTotalsAndVAT(this Invoice invoice)
    {
        CurrencyCode currencyCode = invoice.CurrencyCode;

        var vat = invoice.InvoiceLines
                                .GroupBy(x => new { Code = x.VATInformations.VATCategoryCode, Rate = x.VATInformations.VATRate })
                                .ToArray();

        invoice.VATBreakdowns = vat.Select(x => new VATBreakdown()
        {
            Code = x.Key.Code,
            Rate = x.Key.Rate,
            TaxableAmount = new Amount()
            {
                Value = invoice.InvoiceLines
                                .Where(line => line.VATInformations.VATCategoryCode == x.Key.Code && line.VATInformations.VATRate == x.Key.Rate)
                                .Sum(line => line.NetAmount.Value),
                CurrencyCode = currencyCode
            },
            TaxAmount = new Amount() { Value = 0, CurrencyCode = currencyCode }
        }).ToArray();

        foreach (VATBreakdown VATbreakdown in invoice.VATBreakdowns)
        {
            VATbreakdown.TaxAmount.Value = Math.Round(VATbreakdown.TaxableAmount.Value * VATbreakdown.Rate.Value, 2, MidpointRounding.AwayFromZero);
        }

        Amount netAmount = new Amount() { Value = invoice.InvoiceLines.Sum(x => x.NetAmount.Value), CurrencyCode = currencyCode };
        Amount netAmountWithoutVAT = netAmount;
        Amount netAmountWithVAT = new Amount() { Value = netAmountWithoutVAT.Value + invoice.VATBreakdowns.Sum(x => x.TaxAmount.Value), CurrencyCode = currencyCode };
        Amount amountForPayment = netAmountWithVAT;

        invoice.DocumentTotals = new DocumentTotals()
        {
            SumOfInvoiceLineNetAmount = netAmount,
            InvoiceTotalAmountWithoutVAT = netAmountWithoutVAT,
            InvoiceTotalAmountWithVAT = netAmountWithVAT,
            AmountDueForPayment = amountForPayment
        };

        return invoice;
    }
}
