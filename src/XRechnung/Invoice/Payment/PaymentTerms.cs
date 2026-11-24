namespace XRechnung;

public class PaymentTerms
{
    /// <summary>
    /// Creates a text representation of a list of skonto entries.
    /// </summary>
    /// <remarks>Each entry is appended to the resulting text, followed by a newline character.</remarks>
    /// <param name="data">The skonto entries to include in the list.</param>
    /// <returns>A text value containing the skonto entries separated by newline characters.</returns>
    public static Text CreateSkontoList(params Skonto[] data)
    {
        return new Text() { Value = data.Aggregate(string.Empty, (a,b) => a+= $"{b}\n") };
    }
}
