using System.Globalization;

namespace XRechnung;

/// <summary>
/// Mit diesem Datentyp wird die Mengenangabe zu einem Einzelposten abgebildet. Er basiert auf dem Typ „Quantity.Type“, wie in ISO 15000-5:2014 Anhang B definiert.
/// </summary>
public record class Quantity
{
    /// <summary>
    /// Eine Gleitkommazahl ohne Limitierung der Nachkommastellen.
    /// </summary>
    public required decimal Value { get; set; }

    /// <summary>
    /// UN/ECE Recommendation N°20 unit of measure codes used in international trade.
    /// </summary>
    public required QuantityCode UnitCode { get; set; }

    public override string ToString()
    {
        return Value.ToString(CultureInfo.InvariantCulture);
    }
}
