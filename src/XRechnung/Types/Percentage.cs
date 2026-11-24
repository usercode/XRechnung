using System.Globalization;

namespace XRechnung;

/// <summary>
/// Mit diesem Datentyp wird eine Prozentangabe abgebildet. Er basiert auf dem Typ „Numeric. Type“, wie in ISO 15000-5:2014 Anhang B definiert.
/// </summary>
public record class Percentage
{
    /// <summary>
    /// Die Prozentangabe erfolgt als Teil von Hundert. Der Wert „34,78“ entspricht somit beispielsweise 34,78%.
    /// </summary>
    public required decimal Value { get; set; }

    public override string ToString()
    {
        return Value.ToString(CultureInfo.InvariantCulture);
    }

    public static implicit operator Percentage(decimal value)
    {
        return new Percentage { Value = value };
    }
}
