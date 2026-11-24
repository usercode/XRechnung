namespace XRechnung;

public static class QuantityExtensions
{
    extension(Quantity)
    {
        public static Quantity Piece(decimal value) => new Quantity() { Value = value, UnitCode = QuantityCode.Piece };
        public static Quantity Hour(decimal value) => new Quantity() { Value = value, UnitCode = QuantityCode.Hour };
    }
}
