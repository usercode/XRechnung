namespace XRechnung;

/// <summary>
/// Invoice
/// </summary>
public partial class Invoice
{
    /// <summary>
    /// Eine eindeutige Kennung der Rechnung, die diese im System des Verkäufers identifiziert.
    /// </summary>
    /// <remarks>Anmerkung: Es ist kein „identification scheme“ zu verwenden.</remarks>
    [Field("BT-1")]
    public required Identifier InvoiceNumber { get; set; }

    /// <summary>
    /// Das Datum, an dem die Rechnung ausgestellt wurde.
    /// </summary>
    [Field("BT-2")]
    public required Date IssueDate { get; set; }

    /// <summary>
    /// Ein Code, der den Funktionstyp der Rechnung angibt.
    /// </summary>
    [Field("BT-3")]
    public required InvoiceTypeCode InvoiceTypeCode { get; set; }

    /// <summary>
    /// Die Währung, in der alle Rechnungsbeträge angegeben werden, ausgenommen ist der Umsatzsteuer-Gesamtbetrag, der in der Abrechnungswährung anzugeben ist.
    /// </summary>
    /// <remarks>
    /// Nur eine Währung ist in der Rechnung zu verwenden, der "Invoice total VAT amount in accounting currency" (BT-111) ist in der Abrechnungswährung auszuweisen. Die gültigen Währungen sind bei der ISO 4217 „Codes for the representation of currencies and funds“ registriert.Nur die Alpha - 3 - Darstellung darf verwendet werden.
    /// </remarks>
    [Field("BT-5")]
    public required CurrencyCode CurrencyCode { get; set; }

    /// <summary>
    /// Das Fälligkeitsdatum des Rechnungsbetrages.
    /// </summary>
    /// <remarks>
    /// Das Fälligkeitsdatum stellt das Fälligkeitsdatum der Nettozahlung dar. Für Teilzahlungen ist dies der Zeitpunkt der ersten Zahlung.Die zugehörige Beschreibung von komplexeren Zahlungsbedingungen kann im Element "Payment terms" (BT-20) übergeben werden.
    /// </remarks>
    [Field("BT-9")]
    public Date? PaymentDueDate { get; set; }

    /// <summary>
    /// Ein vom Erwerber zugewiesener und für interne Lenkungszwecke benutzter Bezeichner.
    /// </summary>
    /// <remarks>
    /// Im Rahmen des Steuerungsprojekts eRechnung ist mit der so genannten Leitweg-ID eine Zuordnungsmöglichkeit entwickelt worden, deren verbindliche Nutzung von Bund und mehreren Ländern vorgegebenwird.Die Leitweg-ID ist prinzipiell für Bund, Länder und Kommunen einsetzbar(B2G, G2G).Für die Darstellung der Leitweg-ID wird das in XRechnung verpflichtende Feld Buyer Reference benutzt.
    /// </remarks>
    [Field("BT-10")]
    public required Text BuyerReference { get; set; }

    /// <summary>
    /// Die Kennung eines Projektes, auf das sich die Rechnung bezieht.
    /// </summary>
    [Field("BT-11")]
    public DocumentReference? ProjectReference { get; set; }

    /// <summary>
    /// Eine eindeutige Bezeichnung des Vertrages (z. B. Vertragsnummer).
    /// </summary>
    [Field("BT-12")]
    public DocumentReference? ContractReference { get; set; }

    /// <summary>
    /// Eine vom Erwerber ausgegebene Kennung für eine referenzierte Bestellung
    /// </summary>
    [Field("BT-13")]
    public DocumentReference? PurchaseOrderReference { get; set; }

    /// <summary>
    /// Eine vom Verkäufer ausgegebene Kennung für einen referenzierten Auftrag.
    /// </summary>
    [Field("BT-14")]
    public DocumentReference? SalesOrderReference { get; set; }

    /// <summary>
    /// Eine Kennung für eine referenzierte Empfangsbestätigung.
    /// </summary>
    [Field("BT-15")]
    public DocumentReference? ReceivingAdviceReference { get; set; }

    /// <summary>
    /// Eine Kennung für eine referenzierte Versandanzeige.
    /// </summary>
    [Field("BT-16")]
    public DocumentReference? DespatchAdviceReference { get; set; }

    /// <summary>
    /// Eine vom Verkäufer angegebene Kennung für ein Objekt, auf das sich die Rechnung bezieht (z. B. Zählernummer, Telefonnummer, Kfz-Kennzeichen, versicherte Person, Abonnement-Nummer, Rufnummer).
    /// </summary>
    [Field("BT-18")]
    public Identifier? InvoicedObjectIdentifier { get; set; }

    /// <summary>
    /// Ein Textwert, der angibt, an welcher Stelle die betreffenden Daten in den Finanzkonten des Erwerbers zu buchen sind.
    /// </summary>
    [Field("BT-19")]
    public Text? BuyerAccountingReference { get; set; }

    /// <summary>
    /// BT-20<br/>
    /// Eine Textbeschreibung der Zahlungsbedingungen, die für den fälligen Zahlungsbetrag gelten (einschließlich Beschreibung möglicher Skontobedingungen). Dieses Informationselement kann mehrere Zeilen und mehrere Angaben zu Zahlungsbedingungen beinhalten und sowohl unstrukturierten als strukturierten Text enthalten.Der unstrukturierte Text darf dabei keine # enthalten.
    /// </summary>
    /// <example>#SKONTO#TAGE=14#PROZENT=2.25#BASISBETRAG=357.93#</example>
    [Field("BT-20")]
    public Text? PaymentTerms { get; set; }

    /// <summary>
    /// Eine Gruppe von Informationselementen für rechnungsrelevante Erläuterungen mit Hinweisen auf den Rechnungsbetreff.
    /// </summary>
    [Field("BG-1")]
    public InvoiceNote[] InvoiceNotes { get; set; } = [];

    /// <summary>
    /// Eine Gruppe von Informationselementen, die Informationen über den Geschäftsprozess und für die Rechnung geltende Regeln enthalten.
    /// </summary>
    [Field("BG-2")]
    public ProcessControl ProcessControl { get; set; } = new ProcessControl();

    /// <summary>
    /// Eine Gruppe von Informationselementen, die Informationen über den Verkäufer enthalten.
    /// </summary>
    [Field("BG-4")]
    public required Seller Seller { get; set; }

    /// <summary>
    /// Eine Gruppe von Informationselementen, die Informationen über den Erwerber enthalten
    /// </summary>
    [Field("BG-7")]
    public required Buyer Buyer { get; set; }

    /// <summary>
    /// Eine Gruppe von Informationselementen, die Informationen darüber enthalten, wo und wann die in Rechnung gestellten Waren und Dienstleistungen geliefert bzw.erbracht werden.
    /// </summary>
    [Field("BG-13")]
    public DeliveryInformation? DeliveryInformation { get; set; }

    /// <summary>
    /// Eine Gruppe von Informationselementen, die Informationen darüber enthalten, wie die Zahlung erfolgen soll.
    /// </summary>
    [Field("BG-16")]
    public required PaymentInstructions PaymentInstructions { get; set; }

    /// <summary>
    /// Eine Gruppe von Informationselementen, die Informationen über Nachlässe enthalten, die für die Rechnung als Ganzes gelten.
    /// </summary>
    [Field("BG-20")]
    public DocumentLevelAllowances[] DocumentLevelAllowances { get; set; } = [];

    /// <summary>
    /// Eine Gruppe von Informationselementen, die Informationen über Kosten, Zuschläge, und Steuern – ausgenommen die Umsatzsteuer – enthalten, die für die Rechnung als Ganzes gelten.
    /// </summary>
    [Field("BG-21")]
    public DocumentLevelCharges[] DocumentLevelCharges { get; set; } = [];

    /// <summary>
    /// Eine Gruppe von Informationselementen, die die monetären Gesamtbeträge der Rechnung enthalten.
    /// </summary>
    [Field("BG-22")]
    public required DocumentTotals DocumentTotals { get; set; }

    /// <summary>
    /// Eine Gruppe von Informationselementen, die Informationen über die Umsatzsteueraufschlüsselung nach verschiedenen Kategorien, Steuersätzen und Ausnahmegründen enthalten.
    /// </summary>
    [Field("BG-23")]
    public required VATBreakdown[] VATBreakdowns { get; set; }

    /// <summary>
    /// Eine Gruppe von Informationselementen, die Informationen über einzelne Rechnungspositionen enthalten.
    /// </summary>
    [Field("BG-25")]
    public required InvoiceLine[] InvoiceLines { get; set; }

    
}
