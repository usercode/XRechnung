namespace XRechnung.Validation;

/// <summary>
/// 
/// </summary>
public readonly record struct BusinessGroup
{
    public BusinessGroup(int number)
    {
        Number = number;
    }

    public int Number { get; }

    public override string ToString()
    {
        return $"BG-{Number}";
    }

    public static implicit operator BusinessGroup(int value)
    {
        return new BusinessGroup(value);
    }
}
