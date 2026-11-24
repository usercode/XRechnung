namespace XRechnung;

public interface IRule
{
    string ID { get; }

    string Description { get; }

    bool Validate(Invoice invoice);
}
