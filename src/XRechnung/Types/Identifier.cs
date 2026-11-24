namespace XRechnung;

/// <summary>
/// Mit diesem Datentyp werden eindeutige Kennungen abgebildet (engl. Identifier, kurz ID). Für jede Kennung, die innerhalb des semantischen Datenmodells auftritt, ist festgelegt, ob ein bestimmtes Bildungsmuster verwendet werden kann bzw.muss.Im letzteren Fall wird eine Liste der nutzbaren Bildungsmuster spezifiziert.
/// </summary>
public record class Identifier
{
    public required string Value { get; set; }

    /// <summary>
    /// Mit dieser Eigenschaft wird die Kennung des verwendeten Bildungsmusters angegeben. In Verbindung mit der Eigenschaft „Scheme version identifier“ wird das jeweilige Bildungsmuster eindeutig bestimmt.Die Kardinalität der Eigenschaft ist im Kontext eines Informationselements, das auf dem Datentyp „Identifier“ basiert, spezifiziert.
    /// </summary>
    public string? SchemeIdentifier { get; set; }

    /// <summary>
    /// Mit dieser Eigenschaft wird die Version des verwendeten Bildungsmusters angegeben. In Verbindung mit der Eigenschaft „Scheme identifier“ wird das jeweilige Bildungsmuster eindeutig bestimmt.Die Kardinalität der Eigenschaft ist im Kontext eines Informationselements, das auf dem Datentyp „Identifier“ basiert, spezifiziert.
    /// </summary>
    public string? SchemeVersionIdentifier { get; set; }

    public override string ToString()
    {
        if (SchemeIdentifier == null)
        {
            return Value;
        }

        if (SchemeVersionIdentifier == null)
        {
            return $"{SchemeIdentifier}:{Value}";
        }

        return $"{SchemeIdentifier}:{SchemeVersionIdentifier}:{Value}";
    }

    public static implicit operator Identifier(string value)
    {
        return new Identifier { Value = value };
    }
}
