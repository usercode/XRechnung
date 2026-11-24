namespace XRechnung.Validation;

/// <summary>
/// Geschäftsregel
/// </summary>
public readonly record struct BusinessRule
{
    public BusinessRule(int number)
    {
        Number = number;
    }

    public int Number { get; }

    public override string ToString()
    {
        return $"BR-{Number}";
    }

    public static implicit operator BusinessRule(int value)
    {
        return new BusinessRule(value);
    }
}
