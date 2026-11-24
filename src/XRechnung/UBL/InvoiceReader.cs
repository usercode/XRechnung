using System.Globalization;
using System.Xml;
using System.Xml.Linq;

namespace XRechnung.UBL;

public static partial class InvoiceWriter
{
    private sealed record AllowanceChargeData(
        Amount Amount,
        Amount? BaseAmount,
        Percentage? Percentage,
        TaxCategoryCode VATCategoryCode,
        Percentage VATRate,
        Text? Reason,
        Code? ReasonCode);

    private static string OptionalAttribute(XElement element, XName name)
    {
        return (string?)element.Attribute(name) ?? string.Empty;
    }

    private static decimal ReadDecimal(string value)
    {
        if (decimal.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal result))
        {
            return result;
        }

        return 0;
    }

    private static Date? ReadDate(this XElement element)
    {
        if (DateOnly.TryParseExact(element.Value, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateOnly date))
        {
            return date;
        }

        return null;
    }

    private static InvoiceTypeCode ReadInvoiceTypeCode(this XElement element)
    {
        return new InvoiceTypeCode(element.Value);
    }

    private static CurrencyCode ReadCurrencyCode(this XElement element)
    {
        return new CurrencyCode { Value = element.Value };
    }

    private static Text ReadText(this XElement element)
    {
        return new Text { Value = element.Value };
    }

    private static Identifier ReadIdentifier(this XElement element)
    {
        return new Identifier
        {
            Value = element.Value,
            SchemeIdentifier = (string?)element.Attribute("schemeID")
        };
    }

    private static Amount ReadAmount(this XElement element)
    {
        return new Amount
        {
            Value = ReadDecimal(element.Value),
            CurrencyCode = new CurrencyCode { Value = ((string?)element.Attribute("currencyID"))! }
        };
    }

    private static Percentage ReadPercentage(this XElement element)
    {
        return new Percentage { Value = ReadDecimal(element.Value) };
    }

    private static TaxCategoryCode ReadTaxCategoryCode(this XElement element)
    {
        return new TaxCategoryCode { Value = element.Value };
    }

    private static Code ReadCode(this XElement element)
    {
        return new Code { Value = element.Value };
    }

    private static InvoicePeriod ReadInvoicePeriod(this XElement element)
    {
        return new InvoicePeriod
        {
            StartDate = element.CBC("StartDate")?.ReadDate(),
            EndDate = element.CBC("EndDate")?.ReadDate()
        };
    }

    private static SellerPostalAddress ReadSellerPostalAddress(this XElement element)
    {
        XElement? country = element.CAC("Country");
        return new SellerPostalAddress
        {
            AddressLine1 = element.CBC("StreetName")?.ReadText(),
            AddressLine2 = element.CBC("AdditionalStreetName")?.ReadText(),
            City = element.CBC("CityName")?.ReadText()!,
            PostCode = element.CBC("PostalZone")?.ReadText()!,
            CountryCode = country?.CBC("IdentificationCode")?.ReadCountryCode()!
        };
    }

    private static BuyerPostalAddress ReadBuyerPostalAddress(this XElement element)
    {
        XElement? country = element.CAC("Country");
        return new BuyerPostalAddress
        {
            AddressLine1 = element.CBC("StreetName")?.ReadText(),
            AddressLine2 = element.CBC("AdditionalStreetName")?.ReadText(),
            City = element.CBC("CityName")?.ReadText()!,
            PostCode = element.CBC("PostalZone")?.ReadText()!,
            CountryCode = country?.CBC("IdentificationCode")?.ReadCountryCode()!
        };
    }

    private static CountryCode ReadCountryCode(this XElement element)
    {
        return new CountryCode { Value = element.Value };
    }

    private static PaymentCode ReadPaymentCode(this XElement element)
    {
        return new PaymentCode { Value = element.Value };
    }

    private static DeliveryAddress ReadDeliveryAddress(this XElement element)
    {
        return new DeliveryAddress
        {
            AddressLine1 = element.CBC("StreetName")?.ReadText(),
            AddressLine2 = element.CBC("AdditionalStreetName")?.ReadText(),
            AddressLine3 = element.CAC("AddressLine")?.CBC("Line")?.ReadText(),
            City = element.CBC("CityName")?.ReadText()!,
            PostCode = element.CBC("PostalZone")?.ReadText()!,
            CountryCode = element.CAC("Country")?.CBC("IdentificationCode")?.ReadCountryCode()!
        };
    }

    private static SellerContact ReadSellerContact(this XElement element)
    {
        return new SellerContact
        {
            Name = element.CBC("Name")?.ReadText()!,
            TelephoneNumber = element.CBC("Telephone")?.ReadText()!,
            EmailAddress = element.CBC("ElectronicMail")?.ReadText()!
        };
    }

    private static Seller ReadSeller(this XElement supplierParty)
    {
        XElement? party = supplierParty.CAC("Party");
        IEnumerable<XElement> taxSchemes = party?.CACs("PartyTaxScheme").ToArray() ?? [];
        XElement? vatScheme = taxSchemes.FirstOrDefault(x => (string?)x.CAC("TaxScheme")?.CBC("ID") == "VAT");
        XElement? registrationScheme = taxSchemes.FirstOrDefault(x => (string?)x.CAC("TaxScheme")?.CBC("ID") == "FC");
        XElement? legalEntity = party?.CAC("PartyLegalEntity");

        return new Seller
        {
            Name = legalEntity?.CBC("RegistrationName")?.ReadText()!,
            TradingName = party?.CAC("PartyName")?.CBC("Name")?.ReadText(),
            LegalRegistrationIdentifier = legalEntity?.CBC("CompanyID")?.ReadIdentifier(),
            VATIdentifier = vatScheme?.CBC("CompanyID")?.ReadIdentifier(),
            TaxRegistrationIdentifier = registrationScheme?.CBC("CompanyID")?.ReadIdentifier(),
            ElectronicAddress = party?.CBC("EndpointID")?.ReadIdentifier()!,
            PostalAddress = party?.CAC("PostalAddress")?.ReadSellerPostalAddress()!,
            Contact = party?.CAC("Contact")?.ReadSellerContact()!
        };
    }

    private static Buyer ReadBuyer(this XElement customerParty)
    {
        XElement? party = customerParty.CAC("Party");
        XElement? taxScheme = party?.CACs("PartyTaxScheme").FirstOrDefault(x => (string?)x.CAC("TaxScheme")?.CBC("ID") == "VAT");
        XElement? legalEntity = party?.CAC("PartyLegalEntity");
        XElement? contact = party?.CAC("Contact");

        return new Buyer
        {
            Name = legalEntity?.CBC("RegistrationName")?.ReadText()!,
            TradingName = party?.CAC("PartyName")?.CBC("Name")?.ReadText(),
            LegalRegistrationIdentifier = legalEntity?.CBC("CompanyID")?.ReadIdentifier(),
            VATIdentifier = taxScheme?.CBC("CompanyID")?.ReadIdentifier(),
            ElectronicAddress = party?.CBC("EndpointID")?.ReadIdentifier()!,
            PostalAddress = party?.CAC("PostalAddress")?.ReadBuyerPostalAddress()!,
            Contact = contact?.ReadBuyerContact()
        };
    }

    private static BuyerContact ReadBuyerContact(this XElement element)
    {
        return new BuyerContact
        {
            Name = element.CBC("Name")?.ReadText(),
            TelephoneNumber = element.CBC("Telephone")?.ReadText(),
            EmailAddress = element.CBC("ElectronicMail")?.ReadText()
        };
    }

    private static DeliveryInformation? ReadDelivery(this XElement root)
    {
        XElement? element = root.CAC("Delivery");
        XElement? invoicePeriod = root.CAC("InvoicePeriod");

        if (element == null)
        {
            return invoicePeriod == null ? null : new DeliveryInformation { Period = ReadInvoicePeriod(invoicePeriod) };
        }

        XElement? location = element.CAC("DeliveryLocation");
        XElement? address = location?.CAC("Address");
        XElement? addressLine3 = address?.CAC("AddressLine")?.CBC("Line");
        XElement? partyName = element.CAC("DeliveryParty")?.CAC("PartyName");

        return new DeliveryInformation
        {
            ActualDeliveryDate = element.CBC("ActualDeliveryDate")?.ReadDate(),
            DeliverToLocationIdentifier = location?.CBC("ID")?.ReadIdentifier(),
            DeliverToPartyName = partyName?.CBC("Name")?.ReadText(),
            Period = invoicePeriod == null ? null : ReadInvoicePeriod(invoicePeriod),
            DeliverToAddress = address?.ReadDeliveryAddress()
        };
    }

    private static PaymentInstructions ReadPaymentInstructions(this XElement paymentMeans)
    {
        XElement? code = paymentMeans.CBC("PaymentMeansCode");
        IEnumerable<XElement> accounts = paymentMeans.CACs("PayeeFinancialAccount");

        return new PaymentInstructions
        {
            PaymentMeansTypeCode = code?.ReadPaymentCode()!,
            PaymentMeansText = (string?)code?.Attribute("name") is { } name ? new Text { Value = name } : null,
            RemittanceInformation = paymentMeans.CBC("PaymentID")?.ReadText(),
            CreditTransfer = accounts.Select(x => x.ReadCreditTransfer()).ToArray()
        };
    }

    private static CreditTransfer ReadCreditTransfer(this XElement account)
    {
        return new CreditTransfer
        {
            AccountIdentifier = account.CBC("ID")?.ReadIdentifier()!,
            AccountName = account.CBC("Name")?.ReadText(),
            ServiceProviderIdentifier = account.CAC("FinancialInstitutionBranch")?.CBC("ID")?.ReadIdentifier()
        };
    }

    private static InvoiceNote ReadInvoiceNote(this XElement element)
    {
        string value = element.Value;

        if (value.StartsWith('#'))
        {
            var separator = value.IndexOf('#', 1);
            if (separator > 1)
            {
                return new InvoiceNote
                {
                    SubjectCode = new InvoiceNoteCode { Value = value[1..separator] },
                    Note = new Text { Value = value[(separator + 1)..] }
                };
            }
        }

        return new InvoiceNote { Note = new Text { Value = value } };
    }

    private static VATBreakdown[] ReadVatBreakdowns(this XElement? taxTotal)
    {
        return taxTotal?.CACs("TaxSubtotal")
                        .Select(subtotal => subtotal.ReadVatBreakdown())
                        .ToArray() ?? [];
    }

    private static VATBreakdown ReadVatBreakdown(this XElement subtotal)
    {
        XElement? category = subtotal.CAC("TaxCategory");

        return new VATBreakdown
        {
            TaxableAmount = subtotal.CBC("TaxableAmount")?.ReadAmount()!,
            TaxAmount = subtotal.CBC("TaxAmount")?.ReadAmount()!,
            Code = category?.CBC("ID")?.ReadTaxCategoryCode()!,
            Rate = category?.CBC("Percent")?.ReadPercentage()!
        };
    }

    private static DocumentTotals ReadDocumentTotals(this XElement totals)
    {
        return new DocumentTotals
        {
            SumOfInvoiceLineNetAmount = totals.CBC("LineExtensionAmount")?.ReadAmount()!,
            SumOfAllowancesOnDocumentLevel = totals.CBC("AllowanceTotalAmount")?.ReadAmount(),
            SumOfChargesOnDocumentLevel = totals.CBC("ChargeTotalAmount")?.ReadAmount(),
            InvoiceTotalAmountWithoutVAT = totals.CBC("TaxExclusiveAmount")?.ReadAmount()!,
            InvoiceTotalVATAmount = totals.CBC("TaxTotal")?.ReadAmount(),
            InvoiceTotalAmountWithVAT = totals.CBC("TaxInclusiveAmount")?.ReadAmount()!,
            PaidAmount = totals.CBC("PrepaidAmount")?.ReadAmount(),
            AmountDueForPayment = totals.CBC("PayableAmount")?.ReadAmount()!
        };
    }

    private static bool ReadChargeIndicator(XElement element)
    {
        string? value = element.CBC("ChargeIndicator")?.Value;

        return !string.IsNullOrWhiteSpace(value) && XmlConvert.ToBoolean(value);
    }

    private static DocumentLevelAllowances ReadAllowance(this XElement element)
    {
        var data = ReadAllowanceCharge(element, false);
        return new DocumentLevelAllowances
        {
            Amount = data.Amount,
            BaseAmount = data.BaseAmount,
            Percentage = data.Percentage,
            VATCategoryCode = data.VATCategoryCode,
            VATRate = data.VATRate,
            Reason = data.Reason,
            ReasonCode = data.ReasonCode
        };
    }

    private static DocumentLevelCharges ReadCharge(this XElement element)
    {
        var data = ReadAllowanceCharge(element, true);

        return new DocumentLevelCharges
        {
            Amount = data.Amount,
            BaseAmount = data.BaseAmount,
            Percentage = data.Percentage,
            VATCategoryCode = data.VATCategoryCode,
            VATRate = data.VATRate,
            Reason = data.Reason,
            ReasonCode = data.ReasonCode
        };
    }

    private static AllowanceChargeData ReadAllowanceCharge(this XElement element, bool expectedCharge)
    {
        bool isCharge = ReadChargeIndicator(element);

        if (isCharge != expectedCharge)
        {
            throw new FormatException("The UBL AllowanceCharge has an inconsistent ChargeIndicator.");
        }

        XElement? category = element.CAC("TaxCategory");

        return new AllowanceChargeData(
            element.CBC("Amount")?.ReadAmount()!,
            element.CBC("BaseAmount")?.ReadAmount(),
            element.CBC("MultiplierFactorNumeric")?.ReadPercentage(),
            category?.CBC("ID")?.ReadTaxCategoryCode()!,
            category?.CBC("Percent")?.ReadPercentage()!,
            element.CBC("AllowanceChargeReason")?.ReadText(),
            element.CBC("AllowanceChargeReasonCode")?.ReadCode());
    }

    private static InvoiceLine ReadInvoiceLine(this XElement element)
    {
        XElement? item = element.CAC("Item");
        XElement? taxCategory = item?.CAC("ClassifiedTaxCategory");
        XElement? price = element.CAC("Price");

        return new InvoiceLine
        {
            Identifier = element.CBC("ID")?.ReadIdentifier()!,
            Note = element.CBC("Note")?.ReadText(),
            Quantity = element.CBC("InvoicedQuantity")?.ReadQuantity()!,
            NetAmount = element.CBC("LineExtensionAmount")?.ReadAmount()!,
            PriceDetails = new PriceDetails
            {
                ItemNetPrice = price?.CBC("PriceAmount")?.ReadUnitPriceAmount()!,
                ItemPriceBaseQuantity = price?.CBC("BaseQuantity")?.ReadQuantity()
            },
            VATInformations = new VATInformation
            {
                VATCategoryCode = taxCategory?.CBC("ID")?.ReadTaxCategoryCode()!,
                VATRate = taxCategory?.CBC("Percent")?.ReadPercentage()!
            },
            Item = item?.ReadItemInformation()!
        };
    }

    private static Quantity ReadQuantity(this XElement element)
    {
        return new Quantity
        {
            Value = ReadDecimal(element.Value),
            UnitCode = new QuantityCode { Value = OptionalAttribute(element, "unitCode") }
        };
    }

    private static ItemInformation ReadItemInformation(this XElement item)
    {
        return new ItemInformation
        {
            Name = item.CBC("Name")?.ReadText()!,
            Description = item.CBC("Description")?.ReadText(),
            SellersIdentifier = item.CAC("SellersItemIdentification")?.CBC("ID")?.ReadIdentifier(),
            BuyersIdentifier = item.CAC("BuyersItemIdentification")?.CBC("ID")?.ReadIdentifier(),
            StandardIdentifier = item.CAC("StandardItemIdentification")?.CBC("ID")?.ReadIdentifier(),
            CountryOfOrigin = item.CAC("OriginCountry")?.CBC("IdentificationCode")?.ReadCountryCode(),
            Attributes = item.CACs("AdditionalItemProperty")
                                .Select(attribute => attribute.ReadItemAttribute())
                                .ToArray()
        };
    }

    private static ItemAttribute ReadItemAttribute(this XElement element)
    {
        return new ItemAttribute
        {
            Name = element.CBC("Name")?.ReadText()!,
            Value = element.CBC("Value")?.ReadText()!
        };
    }

    private static UnitPriceAmount ReadUnitPriceAmount(this XElement element)
    {
        return new UnitPriceAmount
        {
            Value = ReadDecimal(element.Value),
            CurrencyID = new CurrencyCode { Value = OptionalAttribute(element, "currencyID") }
        };
    }

    private static DocumentReference ReadDocumentReference(this XElement element)
    {
        return new DocumentReference
        {
            Value = element.CBC("ID")?.Value ?? string.Empty
        };
    }

    private static DocumentReference? ReadPurchaseOrderReference(this XElement? orderReference)
    {
        string? value = orderReference?.CBC("ID")?.Value;
        return string.IsNullOrEmpty(value) || value == "NA" ? null : new DocumentReference { Value = value };
    }

    private static DocumentReference? ReadSalesOrderReference(this XElement? orderReference)
    {
        string? value = orderReference?.CBC("SalesOrderID")?.Value;
        return value == null ? null : new DocumentReference { Value = value };
    }

    private static ProcessControl ReadProcessControl(this XElement root)
    {
        return new ProcessControl
        {
            SpecificationIdentifier = root.CBC("CustomizationID")?.ReadIdentifier()!,
            BusinessProcessType = root.CBC("ProfileID")?.ReadText()!
        };
    }

    public static Invoice FromUblDocument(this XDocument document)
    {
        XElement? root = document.Root ?? throw new FormatException("The UBL document has no root element.");

        if (root.Name != UblNamespaces.Invoice + "Invoice")
        {
            throw new FormatException("The UBL document root must be an Invoice element in the UBL Invoice namespace.");
        }

        var invoice = new Invoice()
        {
            ProcessControl = root.ReadProcessControl(),
            InvoiceNumber = root.CBC("ID")?.ReadIdentifier()!,
            IssueDate = root.CBC("IssueDate")?.ReadDate()!,
            PaymentDueDate = root.CBC("DueDate")?.ReadDate(),
            InvoiceTypeCode = root.CBC("InvoiceTypeCode")?.ReadInvoiceTypeCode()!,
            CurrencyCode = root.CBC("DocumentCurrencyCode")?.ReadCurrencyCode()!,
            BuyerReference = root.CBC("BuyerReference")?.ReadText()!,
            Seller = root.CAC("AccountingSupplierParty")?.ReadSeller()!,
            Buyer = root.CAC("AccountingCustomerParty")?.ReadBuyer()!,
            PaymentInstructions = root.CAC("PaymentMeans")?.ReadPaymentInstructions()!,
            DocumentTotals = root.CAC("LegalMonetaryTotal")?.ReadDocumentTotals()!,
            VATBreakdowns = root.CAC("TaxTotal").ReadVatBreakdowns(),
            InvoiceLines = root.CACs("InvoiceLine").Select(line => line.ReadInvoiceLine()).ToArray(),
            InvoiceNotes = root.CACs("Note").Select(note => note.ReadInvoiceNote()).ToArray(),
            DocumentLevelAllowances = root.CACs("AllowanceCharge")
                                            .Where(x => !ReadChargeIndicator(x))
                                            .Select(allowance => allowance.ReadAllowance())
                                            .ToArray(),
            DocumentLevelCharges = root.CACs("AllowanceCharge")
                                            .Where(ReadChargeIndicator)
                                            .Select(charge => charge.ReadCharge())
                                            .ToArray(),           
            ContractReference = root.CAC("ContractDocumentReference")?.ReadDocumentReference(),
            ReceivingAdviceReference = root.CAC("ReceivingAdviceReference")?.ReadDocumentReference(),
            DespatchAdviceReference = root.CAC("DespatchAdviceReference")?.ReadDocumentReference(),
            InvoicedObjectIdentifier = root.CAC("AdditionalDocumentReference")?.CBC("ID")?.ReadIdentifier(),
            ProjectReference = root.CAC("ProjectReference")?.ReadDocumentReference(),
            BuyerAccountingReference = root.CAC("AccountingCost")?.ReadText(),
            PurchaseOrderReference = root.CAC("OrderReference")?.ReadPurchaseOrderReference(),
            SalesOrderReference = root.CAC("OrderReference")?.ReadSalesOrderReference(),
            PaymentTerms = root.CAC("PaymentTerms")?.CBC("Note")?.ReadText(),
            DeliveryInformation = root.ReadDelivery()
        };

        return invoice;
    }
}
