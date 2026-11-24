using XRechnung.Validation;

namespace XRechnung;

public static partial class InvoiceExtensions
{
    private readonly static IRule[] Rules =
                    [
                    new BR_1(), new BR_2(), new BR_3(), new BR_4(), new BR_5(), new BR_6(), new BR_7() , new BR_8(), new BR_9(),
                    new BR_10(), new BR_11(), new BR_12(), new BR_13(), new BR_14(), new BR_15(), new BR_16(),
                    new BR_21(), new BR_22(), new BR_23(), new BR_24(), new BR_25(), new BR_26(), new BR_27(), new BR_28(),
                    new BR_54(),
                    new BR_62(), new BR_63(), new BR_64(), new BR_65(),
                    new BR_CO_4(), new BR_CO_9(), new BR_CO_10(), new BR_CO_11(), new BR_CO_12(), new BR_CO_13(), new BR_CO_14(), new BR_CO_15(),
                    new BR_33(), new BR_38(),
                    new BR_S_2(), new BR_S_3(), new BR_S_4(), new BR_S_5(), new BR_S_6(), new BR_S_7(), new BR_S_8()
                    ];

    extension(Invoice invoice)
    {
        public void Validate()
        {
            List<(bool, IRule)> ruleState = new List<(bool, IRule)>();

            List<IRule> failedRules = new List<IRule>();

            foreach(IRule rule in Rules)
            {
                bool result = rule.Validate(invoice);

                ruleState.Add((result, rule));

                if (result == false)
                {
                    failedRules.Add(rule);
                }
            }

            if (failedRules.Any())
            {
                throw new Exception();
            }
        }
    }
}
