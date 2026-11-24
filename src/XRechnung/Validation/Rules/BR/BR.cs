namespace XRechnung.Validation;

public abstract class BR : IRule
{
    public abstract string ID { get; }

    public abstract string Description { get; }

    public abstract string Context { get; }

    public abstract string Element { get; }

    public abstract bool Validate(Invoice invoice);
}
