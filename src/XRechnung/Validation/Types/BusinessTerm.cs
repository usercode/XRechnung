namespace XRechnung.Validation;

/// <summary>
/// 
/// </summary>
public readonly record struct BusinessTerm
{
    public BusinessTerm(int number)
    {
        Number = number;
    }

    public int Number { get; }

    public override string ToString()
    {
        return $"BT-{Number}";
    }

    public static implicit operator BusinessTerm(int value)
    {
        return new BusinessTerm(value);
    }
}
