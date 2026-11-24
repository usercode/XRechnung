namespace XRechnung;

public static class IdentifierExtensions
{
    extension(Identifier)
    {
        public static Identifier Email(string email) => new Identifier { Value = email, SchemeIdentifier = "EM" };
        public static Identifier GermanLeitwegID(string id) => new Identifier { Value = id, SchemeIdentifier = "0204" };
        public static Identifier GermanVAT(string rate) => new Identifier { Value = rate, SchemeIdentifier = "9930" };
    }
}
