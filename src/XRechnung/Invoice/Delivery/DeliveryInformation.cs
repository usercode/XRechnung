namespace XRechnung;

/// <summary>
/// Eine Gruppe von Informationselementen, die Informationen darüber enthalten, wo und wann die in Rechnung gestellten Waren und Dienstleistungen geliefert bzw.erbracht werden.
/// </summary>
public class DeliveryInformation
{
    /// <summary>
    /// Der Name des Empfängers, an den die Waren geliefert bzw. für den die Dienstleistungen erbracht werden.
    /// </summary>
    /// <remarks>
    /// Das Informationselement ist zu verwenden, wenn der Empfänger vom Erwerber abweicht.
    /// </remarks>
    [Field("BT-70")]
    public Text? DeliverToPartyName { get; set; }

    /// <summary>
    /// Ein Bezeichner für den Ort, an den die Waren geliefert oder an dem die Dienstleistungen erbracht werden.
    /// </summary>
    [Field("BT-71")]
    public Identifier? DeliverToLocationIdentifier { get; set; }

    /// <summary>
    /// Datum, an dem die Lieferung tatsächlich erfolgt bzw. die Dienstleistung tatsächlich erbracht wird.
    /// </summary>
    [Field("BT-72")]
    public Date? ActualDeliveryDate { get; set; }

    /// <summary>
    /// Eine Gruppe von Informationselementen, die Informationen über den Abrechnungszeitraum enthalten.
    /// </summary>
    [Field("BG-14")]
    public InvoicePeriod? Period { get; set; }

    /// <summary>
    /// Eine Gruppe von Informationselementen, die Informationen über die Anschrift enthalten, an die die Waren geliefert oder an der die Dienstleistungen erbracht werden. Die Gruppe ist nur zu verwenden, wenn die Lieferanschrift von der Erwerberanschrift abweicht.Wenn die Waren abgeholt werden, ist die Abholadresse die Lieferadresse. Eine vollständige gültige Anschrift ist anzugeben.
    /// </summary>
    [Field("BG-15")]
    public DeliveryAddress? DeliverToAddress { get; set; }
}
