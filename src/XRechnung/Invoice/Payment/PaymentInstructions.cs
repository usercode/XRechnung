namespace XRechnung;

/// <summary>
/// Eine Gruppe von Informationselementen, die Informationen darüber enthalten, wie die Zahlung erfolgen soll.
/// </summary>
public class PaymentInstructions
{
    /// <summary>
    /// Das als Code ausgedrückte erwartete oder genutzte Zahlungsmittel. Hierzu wird auf die Codeliste UNTDID 4461 verwiesen.
    /// </summary>
    [Field("BT-81")]
    public required PaymentMeansCode PaymentMeansTypeCode { get; set; }

    /// <summary>
    /// Das in Textform ausgedrückte erwartete oder genutzte Zahlungsmittel.
    /// </summary>
    [Field("BT-82")]
    public Text? PaymentMeansText { get; set; }

    /// <summary>
    /// Ein Textwert, der zur Verknüpfung der Zahlung mit der vom Verkäufer ausgestellten Rechnung verwendet wird.
    /// </summary>
    /// <remarks>
    /// Die Angabe eines Verwendungszwecks hilft dem Verkäufer bei der Zuweisung einer eingehenden Zahlung zum jeweiligen Zahlungsprozess.Wenn Remittance information in der Rechnung übermittelt wurde, sollte diese daher bei der Zahlung genutzt werden.
    /// </remarks>
    [Field("BT-83")]
    public Text? RemittanceInformation { get; set; }

    /// <summary>
    /// Eine Gruppe von Informationselementen, die Informationen über das Bankkonto geben, auf das die Überweisung zu leisten ist.
    /// </summary>
    [Field("BG-17")]
    public CreditTransfer[] CreditTransfer { get; set; } = [];
}
