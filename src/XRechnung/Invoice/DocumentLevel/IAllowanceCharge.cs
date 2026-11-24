namespace XRechnung;

public interface IAllowanceCharge
{
    Amount Amount { get; }

    Amount? BaseAmount { get; }

    Percentage? Percentage { get; }

    TaxCategoryCode VATCategoryCode { get; }

    Percentage VATRate { get; }

    Text? Reason { get; }

    Code? ReasonCode { get; }
}
