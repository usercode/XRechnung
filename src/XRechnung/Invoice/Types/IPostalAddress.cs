namespace XRechnung;

public interface IPostalAddress
{
    Text? AddressLine1 { get; set; }

    Text? AddressLine2 { get; set; }

    Text? AddressLine3 { get; set; }

    Text City { get; set; }

    Text PostCode { get; set; }

    CountryCode CountryCode { get; set; }
}
