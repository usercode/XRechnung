using System.Globalization;

namespace XRechnung;

/// <summary>
/// Mit diesem Datentyp wird ein kalendarisches Datum abgebildet. Der Datentyp basiert auf dem Typ „Date Time.Type“, wie in ISO 15000-5:2014 Anhang B definiert.Er wird abgebildet, wie es in der ISO 8601 Spezifikation „Calendar date complete representation“ beschrieben ist (siehe ISO 8601:2004, Abschnitt 5.2.1.1).
/// <br />
/// <br />
/// Das Datum beinhaltet keine Zeitangabe. Das konkret zu verwendende Format ist abhängig von der genutzten Syntax.
/// </summary>
public record class Date
{
    public required DateOnly Value { get; set; }

    public override string ToString()
    {
        return Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
    }

    public static implicit operator Date(DateOnly value)
    {
        return new Date { Value = value };
    }
}
