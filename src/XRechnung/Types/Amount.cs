namespace XRechnung;

/// <summary>
/// Mit diesem Datentyp wird der dem Preis eines Einzelpostens entsprechende Betrag abgebildet. Dieser Geldwert kann mit der jeweiligen Mengenangabe zum Einzelposten multipliziert werden.Der Datentyp basiert auf dem Typ „Unit Price_ Amount“, wie in ISO 15000-5:2014 Anhang B definiert.
/// </summary>
public record class Amount
{
    /// <summary>
    /// Der Betrag wird mit zwei Nachkommastellen angegeben.
    /// </summary>
    public required decimal Value { get; set; }

    public required CurrencyCode CurrencyCode { get; set; }

    public override string ToString()
    {
        return FormattableString.Invariant($"{Value} {CurrencyCode.Value}");
    }

}
