using XRechnung;

/// <summary>
/// Payment means code
/// <br /><br />
/// Die Codeliste basiert auf der Codeliste 4461 (Payment means code) des United Trade Data Interchange Directory (UNTDID). Sie ist konform zur DIN EN16931-1:2017 und zu dem darauf basierenden Standard XRechnung. EN16931-3-2, 3-3, 3-4 Annex A definiert Verwendungsweisen dieser Liste.
/// <br /><br />
/// https://www.xrepository.de/details/urn:xoev-de:xrechnung:codeliste:untdid.4461_3
/// </summary>
public record class PaymentMeansCode : Code
{
    public static PaymentMeansCode Undefined => new() { Value = "1" };
    public static PaymentMeansCode Cash => new() { Value = "10" };
    public static PaymentMeansCode CreditTransfer => new() { Value = "30" };
    public static PaymentMeansCode CreditCard => new() { Value = "54" };
    public static PaymentMeansCode DebitCard => new() { Value = "55" };
    public static PaymentMeansCode SEPA_CreditTransfer => new() { Value = "58" };
    public static PaymentMeansCode SEPA_DirectDebit => new() { Value = "59" };
    public static PaymentMeansCode OnlinePayment => new() { Value = "68" };

}
