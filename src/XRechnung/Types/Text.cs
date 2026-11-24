namespace XRechnung;

/// <summary>
/// Mit diesem Datentyp wird ein geschriebener Text, inklusive möglicher Zeilenumbrüche, abgebildet. Er basiert auf dem Typ „Text. Type“, wie in ISO 15000-5:2014 Anhang B definiert. Beim Typ Text werden keine Feldlängenbegrenzungen definiert.
/// </summary>
public record class Text
{
    public required string Value { get; set; }

    public override string ToString()
    {
        return Value;
    }

    public static implicit operator Text(string value)
    {
        return new Text { Value = value };
    }
}
