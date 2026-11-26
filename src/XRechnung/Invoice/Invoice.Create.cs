namespace XRechnung;

/// <summary>
/// Represents an electronic invoice with document data, parties, line items, VAT details, totals, and payment
/// instructions.
/// </summary>
public partial class Invoice
{    
    public static Invoice Create(
                                Identifier invoiceNumber, 
                                Date issueDate, 
                                InvoiceTypeCode invoiceTypeCode,
                                CurrencyCode currencyCode,
                                Text buyerReference, 
                                Seller seller, 
                                Buyer buyer,
                                PaymentInstructions paymentInstructions,
                                InvoiceLine[] lines,
                                Amount? paidAmount = null,
                                DocumentLevelAllowances[]? allowances = null,
                                DocumentLevelCharges[]? charges = null)
    {
        var vat = lines
                        .GroupBy(x => new { Code = x.VATInformations.VATCategoryCode, Rate = x.VATInformations.VATRate })
                        .ToArray();

        VATBreakdown[] VATBreakdowns = vat.Select(x => new VATBreakdown()
        {
            Code = x.Key.Code,
            Rate = x.Key.Rate,
            TaxableAmount = new Amount()
            {
                Value = x.Sum(line => line.NetAmount.Value) 
                            - (allowances != null ? allowances
                                            .Where(a => a.VATCategoryCode == x.Key.Code && a.VATRate == x.Key.Rate)
                                            .Sum(a => a.Amount.Value) : 0)
                            + (charges != null ? charges
                                            .Where(a => a.VATCategoryCode == x.Key.Code && a.VATRate == x.Key.Rate)
                                            .Sum(a => a.Amount.Value) : 0),
                CurrencyCode = currencyCode
            },
            TaxAmount = new Amount() { Value = 0, CurrencyCode = currencyCode }
        }).ToArray();

        foreach (VATBreakdown VATbreakdown in VATBreakdowns)
        {
            VATbreakdown.TaxAmount.Value = Math.Round(VATbreakdown.TaxableAmount.Value * VATbreakdown.Rate.Value / 100, 2, MidpointRounding.AwayFromZero);
        }

        Amount? sumOfAllowances = allowances != null ? new Amount { Value = allowances.Sum(x => x.Amount.Value), CurrencyCode = currencyCode } : null;
        Amount? sumOfCharges = charges != null ? new Amount { Value = charges.Sum(x => x.Amount.Value), CurrencyCode = currencyCode } : null;

        Amount sumOfNetAmount = new Amount() { Value = lines.Sum(x => x.NetAmount.Value), CurrencyCode = currencyCode };
        Amount totalAmountWithoutVAT = new Amount { Value = sumOfNetAmount.Value - (sumOfAllowances?.Value ?? 0) + (sumOfCharges?.Value ?? 0), CurrencyCode = currencyCode };
        Amount totalAmountWithVAT = new Amount() { Value = totalAmountWithoutVAT.Value + VATBreakdowns.Sum(x => x.TaxAmount.Value), CurrencyCode = currencyCode };
        Amount amountForPayment = totalAmountWithVAT;

        if (paidAmount != null)
        {
            amountForPayment = totalAmountWithVAT - paidAmount;
        }

        DocumentTotals documentTotals = new DocumentTotals()
        {
            SumOfInvoiceLineNetAmount = sumOfNetAmount,
            SumOfAllowancesOnDocumentLevel = sumOfAllowances,
            SumOfChargesOnDocumentLevel = sumOfCharges,
            InvoiceTotalAmountWithoutVAT = totalAmountWithoutVAT,
            InvoiceTotalAmountWithVAT = totalAmountWithVAT,
            PaidAmount = paidAmount,
            AmountDueForPayment = amountForPayment
        };

        Invoice invoice = new Invoice()
        {
            BuyerReference = buyerReference,
            CurrencyCode = currencyCode,
            Buyer = buyer,
            Seller = seller,
            InvoiceNumber = invoiceNumber,           
            InvoiceLines = lines,            
            IssueDate = issueDate,
            InvoiceTypeCode = invoiceTypeCode,
            VATBreakdowns = VATBreakdowns,
            DocumentTotals = documentTotals,
            PaymentInstructions = paymentInstructions,
        };

        if (allowances != null)
        {
            invoice.DocumentLevelAllowances = allowances;
        }

        if (charges != null)
        {
            invoice.DocumentLevelCharges = charges;
        }

        return invoice;
    }
    
}
