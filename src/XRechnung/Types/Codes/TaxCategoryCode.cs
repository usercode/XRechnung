namespace XRechnung;

public record class TaxCategoryCode : Code
{
    /// <summary>
    /// Code specifying that the rate is based on mixed tax.
    /// </summary>
    public static readonly TaxCategoryCode MixedTaxRate = new TaxCategoryCode() { Value = "A" };

    /// <summary>
    /// Tax rate is lower than standard rate.
    /// </summary>
    public static readonly TaxCategoryCode LowerRate = new TaxCategoryCode() { Value = "AA" };

    /// <summary>
    /// A tax category code indicating the item is tax exempt when the item is bought for future resale.
    /// </summary>
    public static readonly TaxCategoryCode ExemptForResale = new TaxCategoryCode() { Value = "AB" };

    /// <summary>
    /// A code to indicate that the Value Added Tax (VAT) amount which is due on the current invoice is to be paid on receipt of a separate VAT payment request.
    /// </summary>
    public static readonly TaxCategoryCode ValueAddedTaxVATNotNowDueForPayment = new TaxCategoryCode() { Value = "AC" };

    /// <summary>
    /// A code to indicate that the Value Added Tax (VAT) amount of a previous invoice is to be paid.
    /// </summary>
    public static readonly TaxCategoryCode ValueAddedTaxVATDueFromAPreviousInvoice = new TaxCategoryCode() { Value = "AD" };

    /// <summary>
    /// Code specifying that the standard VAT rate is levied from the invoicee.
    /// </summary>
    public static readonly TaxCategoryCode VATReverseCharge = new TaxCategoryCode() { Value = "AE" };

    /// <summary>
    /// VAT not to be paid to the issuer of the invoice but directly to relevant tax authority.
    /// </summary>
    public static readonly TaxCategoryCode TransferredVAT = new TaxCategoryCode() { Value = "B" };

    /// <summary>
    /// Duty associated with shipment of goods is paid by the supplier; customer receives goods with duty paid.
    /// </summary>
    public static readonly TaxCategoryCode DutyPaidBySupplier = new TaxCategoryCode() { Value = "C" };

    /// <summary>
    /// Indication that the VAT margin scheme for travel agents is applied.
    /// </summary>
    public static readonly TaxCategoryCode ValueAddedTaxVATMarginSchemeTravelAgents = new TaxCategoryCode() { Value = "D" };

    /// <summary>
    /// Code specifying that taxes are not applicable.
    /// </summary>
    public static readonly TaxCategoryCode ExemptFromTax = new TaxCategoryCode() { Value = "E" };

    /// <summary>
    /// Indication that the VAT margin scheme for second-hand goods is applied.
    /// </summary>
    public static readonly TaxCategoryCode ValueAddedTaxVATMarginSchemeSecondHandGoods = new TaxCategoryCode() { Value = "F" };

    /// <summary>
    /// Code specifying that the item is free export and taxes are not charged.
    /// </summary>
    public static readonly TaxCategoryCode FreeExportItem = new TaxCategoryCode() { Value = "G" };

    /// <summary>
    /// Code specifying a higher rate of duty or tax or fee.
    /// </summary>
    public static readonly TaxCategoryCode HigherRate = new TaxCategoryCode() { Value = "H" };

    /// <summary>
    /// Indication that the VAT margin scheme for works of art is applied.
    /// </summary>
    public static readonly TaxCategoryCode ValueAddedTaxVATMarginSchemeWorksOfArtMarginSchemeWorksOfArt = new TaxCategoryCode() { Value = "I" };

    /// <summary>
    /// Indication that the VAT margin scheme for collector’s items and antiques is applied.
    /// </summary>
    public static readonly TaxCategoryCode ValueAddedTaxVATMarginSchemeCollectorSItemsAndAntiques = new TaxCategoryCode() { Value = "J" };

    /// <summary>
    /// A tax category code indicating the item is VAT exempt due to an intra-community supply in the European Economic Area.
    /// </summary>
    public static readonly TaxCategoryCode VATExemptForEEAIntraCommunitySupplyOfGoodsAndServices = new TaxCategoryCode() { Value = "K" };

    /// <summary>
    /// Impuesto General Indirecto Canario (IGIC) is an indirect tax levied on goods and services supplied in the Canary Islands (Spain) by traders and professionals, as well as on import of goods.
    /// </summary>
    public static readonly TaxCategoryCode CanaryIslandsGeneralIndirectTax = new TaxCategoryCode() { Value = "L" };

    /// <summary>
    /// Impuesto sobre la Producción, los Servicios y la Importación (IPSI) is an indirect municipal tax, levied on the production, processing and import of all kinds of movable tangible property, the supply of services and the transfer of immovable property located in the cities of Ceuta and Melilla.
    /// </summary>
    public static readonly TaxCategoryCode TaxForProductionServicesAndImportationInCeutaAndMelilla = new TaxCategoryCode() { Value = "M" };

    /// <summary>
    /// Code specifying that taxes are not applicable to the services.
    /// </summary>
    public static readonly TaxCategoryCode ServicesOutsideScopeOfTax = new TaxCategoryCode() { Value = "O" };

    /// <summary>
    /// Code specifying the standard rate.
    /// </summary>
    public static readonly TaxCategoryCode StandardRate = new TaxCategoryCode() { Value = "S" };

    /// <summary>
    /// Code specifying that the goods are at a zero rate.
    /// </summary>
    public static readonly TaxCategoryCode ZeroRatedGoods = new TaxCategoryCode() { Value = "Z" };

}
