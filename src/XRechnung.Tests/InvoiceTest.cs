using System.Xml.Linq;
using XRechnung.UBL;
using Xunit;

namespace XRechnung.Tests;

public class InvoiceTest
{
    [Fact]
    public void Create()
    {
        Invoice invoice = CreateInvoice();

        invoice.Validate();

        Assert.Equal(100, invoice.DocumentTotals.SumOfInvoiceLineNetAmount.Value);
        Assert.Equal(30, invoice.DocumentTotals.SumOfAllowancesOnDocumentLevel.Value);
        Assert.Equal(60, invoice.DocumentTotals.SumOfChargesOnDocumentLevel.Value);
        Assert.Equal(130, invoice.DocumentTotals.InvoiceTotalAmountWithoutVAT.Value);
        Assert.Equal(154.7m, invoice.DocumentTotals.InvoiceTotalAmountWithVAT.Value);
        Assert.Equal(10, invoice.DocumentTotals.PaidAmount.Value);
        Assert.Equal(144.7m, invoice.DocumentTotals.AmountDueForPayment.Value);


    }
    
    [Fact]
    public void ReadAndWrite()
    {
        Invoice invoice = CreateInvoice();

        XDocument document = invoice.ToUblDocument();

        Invoice invoice2 = document.ToInvoice();

        Assert.Equivalent(invoice, invoice2);
    }

    private Invoice CreateInvoice()
    {
        return Invoice.Create(
            "123456",
            new DateOnly(2026, 01, 30),
            InvoiceTypeCode.CommercialInvoice,
            CurrencyCode.EUR,
            "Leitweg-ID 123",
            new Seller()
            {
                Name = "Musterfirma GmbH",
                TradingName = "Musterfirma",
                ElectronicAddress = Identifier.ElectronicMail("info@musterfirma.de"),
                VATIdentifier = "DE123456789",
                Contact = new SellerContact()
                {
                    EmailAddress = "info@musterfirma.de",
                    Name = "Mustermann",
                    TelephoneNumber = "030 / 1234567890"
                },
                PostalAddress = new SellerPostalAddress() { AddressLine1 = "Musterstraße 1", PostCode = "12345", City = "Musterstadt", CountryCode = CountryCode.Deutschland }
            },
            new Buyer()
            {
                Name = "Kundenfirma GmbH",
                TradingName = "Kundenfirma",
                ElectronicAddress = Identifier.ElectronicMail("info@kundenfirma.de"),
                VATIdentifier = "DE987654321",
                Contact = new BuyerContact()
                {
                    EmailAddress = "info@kundenfirma.de",
                    Name = "Kundenkontakt",
                    TelephoneNumber = "030 / 9876543210"
                },
                PostalAddress = new BuyerPostalAddress() { AddressLine1 = "Kundenstraße 1", PostCode = "12345", City = "Musterstadt", CountryCode = CountryCode.Deutschland }
            },
            new PaymentInstructions()
            {
                PaymentMeansTypeCode = PaymentMeansCode.SEPA_CreditTransfer,
                PaymentMeansText = "Überweisung",
                RemittanceInformation = "Rechnung RE-123456",
                CreditTransfer = [
                    new CreditTransfer()
                    {
                        AccountIdentifier = "DE89370400440532013000",
                        AccountName = "Musterfirma GmbH",
                        ServiceProviderIdentifier = "DEUTDEFFXXX"
                    }]
            },
            [
                new InvoiceLine()
                {
                    Identifier = "1",
                    Note = "Rechnungsposition 1",
                    InvoicedObjectIdentifier = "Objekt 1",
                    Quantity = Quantity.Piece(2),
                    NetAmount = Amount.EUR(100),
                    PriceDetails = new PriceDetails()
                    {
                        ItemNetPrice = UnitPriceAmount.EUR(50),
                        //ItemPriceDdiscount = new UnitPriceAmount() { Value = 0m, CurrencyID = CurrencyCode.EUR },
                        //ItemGrossPrice = new UnitPriceAmount() { Value = 50m, CurrencyID = CurrencyCode.EUR },
                        //ItemPriceBaseQuantity = new Quantity() { Value = 1, UnitCode = "EA" }
                    },
                    VATInformations = new VATInformation()
                    {
                        VATCategoryCode = TaxCategoryCode.StandardRate,
                        VATRate = 19,
                    },
                    Item = new ItemInformation()
                    {
                        Name = "Produkt A",
                        Description = "Beschreibung von Produkt A",
                        Attributes = [ new ItemAttribute() { Name = "Color", Value = "Black" } ]
                    }
                }],
            Amount.EUR(10),
            [
                new DocumentLevelAllowances() { Amount = Amount.EUR(20), VATCategoryCode = TaxCategoryCode.StandardRate, VATRate = 19, Reason = "Rabatt 1" },
                new DocumentLevelAllowances() { Amount = Amount.EUR(10), VATCategoryCode = TaxCategoryCode.StandardRate, VATRate = 19, Reason = "Rabatt 2" }
            ],
            [
                new DocumentLevelCharges() { Amount = Amount.EUR(20), VATCategoryCode = TaxCategoryCode.StandardRate, VATRate = 19, Reason = "Zuschlag 1" },
                new DocumentLevelCharges() { Amount = Amount.EUR(40), VATCategoryCode = TaxCategoryCode.StandardRate, VATRate = 19, Reason = "Zuschlag 2" }
            ]);
    }
}
