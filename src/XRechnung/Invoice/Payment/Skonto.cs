namespace XRechnung;

/// <summary>
/// Skonto
/// </summary>
public readonly record struct Skonto
{
    public Skonto(int days, decimal percentage, decimal? baseAmount = null)
    {
        Days = days;
        Percentage = percentage;
        BaseAmount = baseAmount;
    }

    /// <summary>
    /// 
    /// </summary>
    public int Days { get; }

    /// <summary>
    /// 
    /// </summary>
    public decimal Percentage { get; }

    /// <summary>
    /// Grundwert zur Berechnung des Skonto
    /// </summary>
    public decimal? BaseAmount { get; }

    public override string ToString()
    {
        string result = FormattableString.Invariant($"#SKONTO#TAGE={Days}#PROZENT={Percentage:0.00}#");

        if (BaseAmount != null)
        {
            result += FormattableString.Invariant($"BASISBETRAG={BaseAmount:0.00}#");
        }

        return result;
    }
}
