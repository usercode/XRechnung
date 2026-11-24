using System.Net;

namespace XRechnung;

/// <summary>
/// Eine Gruppe von Informationselementen, die Informationen über die Anschrift des Erwerbers enthalten.
/// </summary>
/// <remarks>
/// Es ist eine gültige vollständige Anschrift anzugeben.
/// </remarks>
public record class BuyerPostalAddress
{
    /// <summary>
    /// Die Hauptzeile einer Anschrift. Üblicherweise ist dies entweder Strasse und Hausnummer oder der Text „Postfach“ gefolgt von der Postfachnummer.
    /// </summary>
    [Field("BT-50")]
    public Text? AddressLine1{ get; set; }

    /// <summary>
    /// Eine zusätzliche Adresszeile in einer Anschrift, die verwendet werden kann, um weitere Einzelheiten in Ergänzung zur Hauptzeile anzugeben.
    /// </summary>
    [Field("BT-51")]
    public Text? AddressLine2 { get; set; }

    /// <summary>
    /// Eine zusätzliche Adresszeile in einer Anschrift, die verwendet werden kann, um weitere Einzelheiten in Ergänzung zur Hauptzeile anzugeben.
    /// </summary>
    [Field("BT-163")]
    public Text? AddressLine3 { get; set; }

    /// <summary>
    /// Die Bezeichnung der Stadt oder Gemeinde, in der sich die Erwerberanschrift befindet.
    /// </summary>
    [Field("BT-52")]
    public required Text City { get; set; }

    /// <summary>
    /// Die Postleitzahl.
    /// </summary>
    [Field("BT-53")]
    public required Text PostCode { get; set; }

    /// <summary>
    /// Die Unterteilung eines Landes (wie Region, Bundesland, Provinz etc.).
    /// </summary>
    [Field("BT-54")]
    public Text? CountrySubdivision { get; set; }

    /// <summary>
    /// Ein Code, mit dem das Land bezeichnet wird.
    /// </summary>
    /// <remarks>
    /// Die Liste der zulässigen Länder ist bei der ISO 3166-1 „Codes for the representation of names of countries and their subdivisions“ erhältlich.Nur die Alpha - 2 - Darstellung darf verwendet werden.
    /// </remarks>
    [Field("BT-55")]
    public required CountryCode CountryCode { get; set; }

}
