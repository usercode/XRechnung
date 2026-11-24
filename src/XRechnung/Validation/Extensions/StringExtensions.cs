namespace XRechnung.Validation;

internal static class StringExtensions
{
    public static bool HasValue(this string value)
    {
        return string.IsNullOrWhiteSpace(value) == false;
    }

    public static bool IsPositive(this decimal value)
    {
        return value >= 0;
    }

    public static bool IsValidVATIdentifier(this string value)
    {
        if (value.Length < 2)
        {
            return false;
        }

        return char.IsLetter(value[0]) && char.IsLetter(value[1]);
    }

    public static decimal GetValueOrZero(this decimal? value)
    {
        return value ?? 0m;
    }
}
