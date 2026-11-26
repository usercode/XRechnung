namespace XRechnung;

public abstract record class AmountBase<TAmount> where TAmount : AmountBase<TAmount>, new()
{
    public required decimal Value { get; set; }

    public required CurrencyCode CurrencyCode { get; set; }

    public override string ToString()
    {
        return FormattableString.Invariant($"{Value} {CurrencyCode.Value}");
    }

    public static TAmount operator +(AmountBase<TAmount> left, AmountBase<TAmount> right)
    {
        if (left.CurrencyCode != right.CurrencyCode)
        {
            throw new Exception();
        }

        return new TAmount() { Value = left.Value + right.Value, CurrencyCode = left.CurrencyCode };
    }

    public static TAmount operator -(AmountBase<TAmount> left, AmountBase<TAmount> right)
    {
        if (left.CurrencyCode != right.CurrencyCode)
        {
            throw new Exception();
        }

        return new TAmount() { Value = left.Value - right.Value, CurrencyCode = left.CurrencyCode };
    }
}
