namespace XRechnung;

/// <summary>
/// Mit diesem Datentyp wird ein Code abgebildet, der in einer Codeliste spezifiziert ist.
/// <br /><br />
/// Eine Codeliste ist eine Liste von Codes und der Beschreibung ihrer jeweiligen Bedeutung. Die Bedeutung von Codes kann dabei beispielsweise in Form von Namen(Augsburg, Bremen, München etc.), Begrifflichkeiten(ledig, verheiratet, geschieden etc.) oder Statusbeschreibungen(Antrag übermittelt, Antrag empfangen, Antrag unvollständig etc.) vorliegen. Codelisten werden eingesetzt, um die für einen bestimmten Kontext relevanten Sachverhalte eindeutig zu bezeichnen und in der erforderlichen Form zu beschreiben.
/// </summary>
public record class Code
{
    public required string Value { get; set; }

    public override string ToString()
    {
        return Value;
    }

    public static implicit operator Code(string value)
    {
        return new Code { Value = value };
    }
}
