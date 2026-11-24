namespace XRechnung.Validation;

public abstract class BR_S : IRule
{
    public abstract string ID { get; }

    public abstract string Description { get; }

    public abstract bool Validate(Invoice invoice);
}
