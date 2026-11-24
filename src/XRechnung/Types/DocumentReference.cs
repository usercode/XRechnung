namespace XRechnung;

/// <summary>
/// Mit diesem Datentyp werden eindeutige Referenzen abgebildet, die ein Dokument oder eine Dokumentenzeile eindeutig identifizieren.Er basiert auf dem Typ „Identifier.Type“, wie in ISO 15000-5:2014 Anhang B definiert.
/// </summary>
public record class DocumentReference
{
    public required string Value { get; set; }

    public override string ToString()
    {
        return Value;
    }

    public static implicit operator DocumentReference(string value)
    {
        return new DocumentReference { Value = value };
    }
}
