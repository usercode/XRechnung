namespace XRechnung;

public static class IdentifierExtensions
{
    extension(Identifier)
    {
        /// <summary>
        /// Electronic mail
        /// </summary>
        /// <remarks>
        /// SMTP email
        /// </remarks>
        public static Identifier ElectronicMail(string value) => new() { Value = value, SchemeIdentifier = "EM" };
        
        /// <summary>
        /// EAN Location Code
        /// </summary>
        public static Identifier EanLocationCode(string value) => new() { Value = value, SchemeIdentifier = "0088" };
        
        /// <summary>
        /// Leitweg-ID
        /// </summary>
        /// <remarks>
        /// Replaces 9958
        /// </remarks>
        public static Identifier LeitwegId(string value) => new() { Value = value, SchemeIdentifier = "0204" };

        /// <summary>
        /// Germany VAT number
        /// </summary>
        public static Identifier GermanyVatNumber(string value) => new() { Value = value, SchemeIdentifier = "9930" };               

    }
}
