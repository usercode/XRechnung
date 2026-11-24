using XRechnung;

public record class PaymentCode : Code
{
    public static PaymentCode Undefined { get; } = new PaymentCode() { Value = "1" };
    public static PaymentCode Cash { get; } = new PaymentCode() { Value = "10" };
    public static PaymentCode CreditTransfer { get; } = new PaymentCode() { Value = "30" };
    public static PaymentCode CreditCard { get; } = new PaymentCode() { Value = "54" };
    public static PaymentCode DebitCard { get; } = new PaymentCode() { Value = "55" };
    public static PaymentCode SEPA_CreditTransfer { get; } = new PaymentCode() { Value = "58" };
    public static PaymentCode SEPA_DirectDebit { get; } = new PaymentCode() { Value = "59" };
    public static PaymentCode OnlinePayment { get; } = new PaymentCode() { Value = "68" };

}
