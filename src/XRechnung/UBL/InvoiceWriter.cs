using System.Globalization;
using System.Xml.Linq;

namespace XRechnung.UBL;

public static partial class InvoiceWriter
{
    private static XElement? SurroundWithCAC(this XElement? element, string name)
    {
        if (element == null)
        {
            return null;
        }

        return XElement.CAC(name, element);
    }

    private static XElement WhenNullThen(this XElement? element, XElement alternativeElement)
    {
        if (element == null)
        {
            return alternativeElement;
        }

        return element;
    }

    private static XAttribute ToAttribute(this string value, string name)
    {
        return new XAttribute(name, value);
    }

    private static XElement ToCBC(this Date date, string name)
    {
        return XElement.CBC(name, date.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
    }

    private static XElement ToCBC(this CurrencyCode currencyCode, string name)
    {
        return XElement.CBC(name, currencyCode.Value);
    }

    private static XElement ToCBC(this InvoiceTypeCode invoiceTypeCode, string name)
    {
        return XElement.CBC(name, invoiceTypeCode.Value);
    }

    private static XElement ToCBC(this Text text, string name)
    {
        return XElement.CBC(name, text.Value);
    }

    private static XElement ToCBC(this Amount amount, string name)
    {
        return XElement.CBC(name, 
            amount.CurrencyCode.Value.ToAttribute("currencyID"),
            amount.Value.ToString("F2", CultureInfo.InvariantCulture));
    }

    private static XElement ToCBC(this UnitPriceAmount amount, string name)
    {
        return XElement.CBC(name,
           amount.CurrencyID.Value.ToAttribute("currencyID"),
            amount.Value.ToString(CultureInfo.InvariantCulture));
    }

    private static XElement ToCBC(this Quantity quantity, string name)
    {
        return XElement.CBC(name,
            quantity.UnitCode.Value.ToAttribute("unitCode"),
            quantity.Value.ToString(CultureInfo.InvariantCulture));
    }

    private static XElement ToCBC(this Code code, string name)
    {
        return XElement.CBC(name, code.Value);
    }

    private static XElement ToCBC(this Percentage percentage, string name)
    {
        return XElement.CBC(name, percentage.Value.ToString(CultureInfo.InvariantCulture));
    }

    private static XElement ToCBC(this DocumentReference documentReference, string name)
    {
        return XElement.CBC(name, documentReference.Value);
    }

    private static XElement ToCBC(this Identifier identifier, string name)
    {
        return XElement.CBC(name,
                            identifier.SchemeIdentifier?.ToAttribute("schemeID"),
                            identifier.Value);
    }

    private static XElement ToCAC(this Seller seller)
    {
        List<XElement?> elements =
        [
            seller.ElectronicAddress.ToCBC("EndpointID"),
            seller.TradingName?.ToCBC("Name").SurroundWithCAC("PartyName"),
            seller.PostalAddress.ToCAC(),
        ];

        if (seller.VATIdentifier != null)
        {
            elements.Add(XElement.CAC("PartyTaxScheme",
                                    seller.VATIdentifier.ToCBC("CompanyID"),
                                    XElement.CAC("TaxScheme", XElement.CBC("ID", "VAT"))
            ));
        }

        if (seller.TaxRegistrationIdentifier != null)
        {
            elements.Add(XElement.CAC("PartyTaxScheme",
                                    seller.TaxRegistrationIdentifier.ToCBC("CompanyID"),
                                    XElement.CAC("TaxScheme", XElement.CBC("ID", "FC"))
            ));
        }

        elements.Add(XElement.CAC("PartyLegalEntity", 
                                    seller.Name.ToCBC("RegistrationName"),
                                    seller.LegalRegistrationIdentifier?.ToCBC("CompanyID")
                                    ));

        elements.Add(seller.Contact.ToCAC());

        return XElement.CAC("AccountingSupplierParty", XElement.CAC("Party", elements));
    }

    private static XElement ToCAC(this SellerPostalAddress postalAddress)
    {
        return XElement.CAC("PostalAddress",
                        postalAddress.AddressLine1?.ToCBC("StreetName"),
                        postalAddress.AddressLine2?.ToCBC("AdditionalStreetName"),
                        postalAddress.City.ToCBC("CityName"),
                        postalAddress.PostCode.ToCBC("PostalZone"),
                        postalAddress.CountryCode.ToCBC("IdentificationCode").SurroundWithCAC("Country")
                        );
    }

    private static XElement ToCAC(this SellerContact contact)
    {
        return XElement.CAC("Contact",
                            contact.Name.ToCBC("Name"),
                            contact.TelephoneNumber.ToCBC("Telephone"),
                            contact.EmailAddress.ToCBC("ElectronicMail")
        );
    }

    private static XElement ToCAC(this Buyer buyer)
    {
        List<XElement?> elements =
        [
            buyer.ElectronicAddress.ToCBC("EndpointID"),
            buyer.TradingName?.ToCBC("Name").SurroundWithCAC("PartyName"),
            buyer.PostalAddress.ToCAC(),
        ];

        if (buyer.VATIdentifier != null)
        {
            elements.Add(XElement.CAC("PartyTaxScheme",
                            buyer.VATIdentifier.ToCBC("CompanyID"),
                            XElement.CAC("TaxScheme", XElement.CBC("ID", "VAT"))
                            ));
        }

        elements.Add(XElement.CAC("PartyLegalEntity",
                                   buyer.Name.ToCBC("RegistrationName"),
                                   buyer.LegalRegistrationIdentifier?.ToCBC("CompanyID")
                                   ));

        elements.Add(buyer.Contact?.ToCAC());
        
        return XElement.CAC("AccountingCustomerParty", XElement.CAC("Party", elements));
    }

    private static XElement ToCAC(this BuyerPostalAddress postalAddress)
    {
        return XElement.CAC("PostalAddress",
                        postalAddress.AddressLine1?.ToCBC("StreetName"),
                        postalAddress.AddressLine2?.ToCBC("AdditionalStreetName"),
                        postalAddress.City.ToCBC("CityName"),
                        postalAddress.PostCode.ToCBC("PostalZone"),
                        postalAddress.CountryCode.ToCBC("IdentificationCode").SurroundWithCAC("Country")
                        );
    }

    private static XElement ToCAC(this BuyerContact contact)
    {
        return XElement.CAC("Contact",
                            contact.Name?.ToCBC("Name"),
                            contact.TelephoneNumber?.ToCBC("Telephone"),
                            contact.EmailAddress?.ToCBC("ElectronicMail")
                            );
    }

    private static XElement ToCAC(this DeliveryInformation deliveryInformation)
    {
        var elements = new List<XElement?>
        {
            deliveryInformation.ActualDeliveryDate?.ToCBC("ActualDeliveryDate")
        };

        if (deliveryInformation.DeliverToLocationIdentifier != null || deliveryInformation.DeliverToAddress != null)
        {
            var el = new List<XElement?>();

            if (deliveryInformation.DeliverToLocationIdentifier != null)
            {
                el.Add(deliveryInformation.DeliverToLocationIdentifier?.ToCBC("ID"));
            }

            if (deliveryInformation.DeliverToAddress != null)
            {
                el.Add(XElement.CAC("Address",
                                deliveryInformation.DeliverToAddress.AddressLine1?.ToCBC("StreetName"),
                                deliveryInformation.DeliverToAddress.AddressLine2?.ToCBC("AdditionalStreetName"),
                                deliveryInformation.DeliverToAddress.City.ToCBC("CityName"),
                                deliveryInformation.DeliverToAddress.PostCode.ToCBC("PostalZone"),
                                deliveryInformation.DeliverToAddress.AddressLine3?.ToCBC("Line").SurroundWithCAC("AddressLine"),
                                deliveryInformation.DeliverToAddress.CountryCode.ToCBC("IdentificationCode").SurroundWithCAC("Country")
                                ));
            }

            elements.Add(XElement.CAC("DeliveryLocation", el));
        }

        elements.Add(deliveryInformation.DeliverToPartyName?.ToCBC("Name")
                                                            .SurroundWithCAC("PartyName")
                                                            .SurroundWithCAC("DeliveryParty"));

        return XElement.CAC("Delivery", elements);
    }

    private static XElement ToCAC(this PaymentInstructions paymentInstructions)
    {
        List<XElement?> elements =
        [
            XElement.CBC("PaymentMeansCode", 
                                        paymentInstructions.PaymentMeansText?.Value.ToAttribute("name"),
                                        paymentInstructions.PaymentMeansTypeCode.Value),
            paymentInstructions.RemittanceInformation?.ToCBC("PaymentID"),
        ];

        foreach (CreditTransfer creditTransfer in paymentInstructions.CreditTransfer)
        {
            elements.Add(XElement.CAC("PayeeFinancialAccount",
                            creditTransfer.AccountIdentifier.ToCBC("ID"),
                            creditTransfer.AccountName?.ToCBC("Name"),
                            creditTransfer.ServiceProviderIdentifier?.ToCBC("ID").SurroundWithCAC("FinancialInstitutionBranch")
                            ));
        }

        return XElement.CAC("PaymentMeans", elements);
    }

    private static XElement ToCAC(this InvoiceLine line)
    {
        return XElement.CAC("InvoiceLine", 
                            line.Identifier.ToCBC("ID"),
                            line.Note?.ToCBC("Note"),
                            line.Quantity.ToCBC("InvoicedQuantity"),
                            line.NetAmount.ToCBC("LineExtensionAmount"),
                            XElement.CAC("Item",
                                line.Item.Description?.ToCBC("Description"),
                                line.Item.Name.ToCBC("Name"),
                                line.Item.BuyersIdentifier?.ToCBC("ID").SurroundWithCAC("BuyersItemIdentification"),
                                line.Item.SellersIdentifier?.ToCBC("ID").SurroundWithCAC("SellersItemIdentification"),
                                line.Item.StandardIdentifier?.ToCBC("ID").SurroundWithCAC("StandardItemIdentification"),
                                line.Item.CountryOfOrigin?.ToCBC("IdentificationCode").SurroundWithCAC("OriginCountry"),
                                XElement.CAC("ClassifiedTaxCategory",
                                    line.VATInformations.VATCategoryCode.ToCBC("ID"),
                                    line.VATInformations.VATRate.ToCBC("Percent"),
                                    XElement.CAC("TaxScheme", XElement.CBC("ID", "VAT"))),
                                line.Item.Attributes.Select(x => XElement.CAC("AdditionalItemProperty", 
                                                                                    x.Name.ToCBC("Name"), 
                                                                                    x.Value.ToCBC("Value")))
                                ),
                            XElement.CAC("Price",
                                line.PriceDetails.ItemNetPrice.ToCBC("PriceAmount"),
                                line.PriceDetails.ItemPriceBaseQuantity?.ToCBC("BaseQuantity")
                            ));
    }

    private static XElement ToCAC(this DocumentTotals documentTotals)
    {
        return XElement.CAC("LegalMonetaryTotal", 
            [
                documentTotals.SumOfInvoiceLineNetAmount.ToCBC("LineExtensionAmount"),
                documentTotals.SumOfAllowancesOnDocumentLevel?.ToCBC("AllowanceTotalAmount"),
                documentTotals.SumOfChargesOnDocumentLevel?.ToCBC("ChargeTotalAmount"),
                documentTotals.InvoiceTotalAmountWithoutVAT.ToCBC("TaxExclusiveAmount"),
                documentTotals.InvoiceTotalVATAmount?.ToCBC("TaxTotal"),
                documentTotals.InvoiceTotalAmountWithVAT.ToCBC("TaxInclusiveAmount"),
                documentTotals.PaidAmount?.ToCBC("PrepaidAmount"),
                documentTotals.AmountDueForPayment.ToCBC("PayableAmount")
            ]);
    }

    private static XElement ToCAC(this InvoiceNote invoiceNote)
    {
        if(invoiceNote.SubjectCode != null)
        {
            return XElement.CBC("Note", $"#{invoiceNote.SubjectCode.Value}#{invoiceNote.Note.Value}");
        }
        else
        {
            return invoiceNote.Note.ToCBC("Note");
        }
    }

    private static XElement ToCAC(this IEnumerable<VATBreakdown> vatBreakdowns)
    {
        return XElement.CAC("TaxTotal",
                            Amount.EUR(vatBreakdowns.Sum(vatBreakdown => vatBreakdown.TaxAmount.Value)).ToCBC("TaxAmount"),
                            vatBreakdowns.Select(vatBreakdown => 
                                XElement.CAC("TaxSubtotal",
                                    vatBreakdown.TaxableAmount.ToCBC("TaxableAmount"),
                                    vatBreakdown.TaxAmount.ToCBC("TaxAmount"),           
                                    XElement.CAC("TaxCategory",
                                        vatBreakdown.Code.ToCBC("ID"),
                                        vatBreakdown.Rate.ToCBC("Percent"),
                                        XElement.CAC("TaxScheme", XElement.CBC("ID", "VAT"))
                                    )
                                )
                            )
        );
    }

    private static XElement ToCAC(this IAllowanceCharge allowanceCharge, bool chargeIndicator)
    {
        return XElement.CAC("AllowanceCharge",
                            XElement.CBC("ChargeIndicator", chargeIndicator),
                            allowanceCharge.ReasonCode?.ToCBC("AllowanceChargeReasonCode"),
                            allowanceCharge.Reason?.ToCBC("AllowanceChargeReason"),
                            allowanceCharge.Percentage?.ToCBC("MultiplierFactorNumeric"),
                            allowanceCharge.Amount.ToCBC("Amount"),
                            allowanceCharge.BaseAmount?.ToCBC("BaseAmount"),
                            XElement.CAC("TaxCategory",
                                    allowanceCharge.VATCategoryCode.ToCBC("ID"),
                                    allowanceCharge.VATRate.ToCBC("Percent"),
                                    XElement.CAC("TaxScheme", XElement.CBC("ID", "VAT"))
                                    )
                            );
    }

    public static XDocument ToUblDocument(this Invoice invoice)
    {
        List<XElement?> elements =
        [
            invoice.ProcessControl.SpecificationIdentifier.ToCBC("CustomizationID"),
            invoice.ProcessControl.BusinessProcessType.ToCBC("ProfileID"),
            invoice.InvoiceNumber.ToCBC("ID"),
            invoice.IssueDate.ToCBC("IssueDate"),
            invoice.PaymentDueDate?.ToCBC("DueDate"),
            invoice.InvoiceTypeCode.ToCBC("InvoiceTypeCode")
        ];

        elements.AddRange(invoice.InvoiceNotes.Select(x => x.ToCAC()));

        elements.Add(invoice.CurrencyCode.ToCBC("DocumentCurrencyCode"));
        elements.Add(invoice.BuyerReference.ToCBC("BuyerReference"));

        if (invoice.DeliveryInformation?.Period != null)
        {
            elements.Add(XElement.CAC("InvoicePeriod", 
                                        invoice.DeliveryInformation.Period.StartDate?.ToCBC("StartDate"),
                                        invoice.DeliveryInformation.Period.EndDate?.ToCBC("EndDate")
                                        ));
        }
        
        if (invoice.SalesOrderReference != null || invoice.PurchaseOrderReference != null)
        {            
            elements.Add(XElement.CAC("OrderReference", 
                                    invoice.PurchaseOrderReference?.ToCBC("ID").WhenNullThen(XElement.CBC("ID", "NA")),
                                    invoice.SalesOrderReference?.ToCBC("SalesOrderID")));
        }
        
        elements.Add(invoice.ContractReference?.ToCBC("ID").SurroundWithCAC("ContractDocumentReference"));
        elements.Add(invoice.ReceivingAdviceReference?.ToCBC("ID").SurroundWithCAC("ReceivingAdviceReference"));
        elements.Add(invoice.DespatchAdviceReference?.ToCBC("ID").SurroundWithCAC("DespatchAdviceReference"));
        elements.Add(invoice.InvoicedObjectIdentifier?.ToCBC("ID").SurroundWithCAC("AdditionalDocumentReference"));
        elements.Add(invoice.ProjectReference?.ToCBC("ID").SurroundWithCAC("ProjectReference"));
        elements.Add(invoice.BuyerAccountingReference?.ToCBC("ID").SurroundWithCAC("AccountingCost"));

        elements.Add(invoice.Seller.ToCAC());
        elements.Add(invoice.Buyer.ToCAC());
        elements.Add(invoice.DeliveryInformation?.ToCAC());
        elements.Add(invoice.PaymentInstructions.ToCAC());
        
        elements.Add(invoice.PaymentTerms?.ToCBC("Note").SurroundWithCAC("PaymentTerms"));
        
        elements.AddRange(invoice.DocumentLevelAllowances.Select(x => x.ToCAC(false)));
        elements.AddRange(invoice.DocumentLevelCharges.Select(x => x.ToCAC(true)));

        elements.Add(invoice.VATBreakdowns.ToCAC());
        elements.Add(invoice.DocumentTotals.ToCAC());

        elements.AddRange(invoice.InvoiceLines.Select(line => line.ToCAC()));

        var document = new XDocument(new XElement(UblNamespaces.Invoice + "Invoice",
            [
                new XAttribute(XNamespace.Xmlns + "ubl", UblNamespaces.Invoice),
                new XAttribute(XNamespace.Xmlns + "cbc", UblNamespaces.CommonBasicComponents),
                new XAttribute(XNamespace.Xmlns + "cac", UblNamespaces.CommonAggregateComponents),
                .. elements
            ]));

        return document;
    }
}
