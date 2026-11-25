namespace XRechnung;

public static class QuantityExtensions
{
    extension(Quantity)
    {
        /// <summary>
        /// piece
        /// </summary>
        public static Quantity Piece(decimal value) => new() { Value = value, UnitCode = QuantityCode.Piece };

        /// <summary>
        /// hour
        /// </summary>
        public static Quantity Hour(decimal value) => new() { Value = value, UnitCode = QuantityCode.Hour };
    }
}
