namespace XRechnung;

/// <summary>
/// Codes for the representation of currencies and funds
/// <br /><br />
/// Die Codeliste basiert auf dem Standard "Currency codes" der International Organization for Standardization (ISO). Die vorliegende Version der Codeliste enthält alle Codelisteneinträge, die mit einem listenweit eindeutigen Eintrag in den Feldern "Currency" und "Alphabetic Code" geführt werden. Sie ist konform zur EN16931-1 und zu dem darauf basierenden Standard XRechnung sowie zum Standard XBestellung und der zugrundeliegenden Peppol BIS Order only.
/// <br /><br />
/// https://www.xrepository.de/details/urn:xoev-de:kosit:codeliste:currency-codes_3
/// </summary>
public record class CurrencyCode : Code
{
    /// <summary>
    /// UAE Dirham
    /// </summary>
    public static CurrencyCode AED => new() { Value = "AED" };

    /// <summary>
    /// Afghani
    /// </summary>
    public static CurrencyCode AFN => new() { Value = "AFN" };

    /// <summary>
    /// Lek
    /// </summary>
    public static CurrencyCode ALL => new() { Value = "ALL" };

    /// <summary>
    /// Armenian Dram
    /// </summary>
    public static CurrencyCode AMD => new() { Value = "AMD" };

    /// <summary>
    /// Netherlands Antillean Guilder
    /// </summary>
    public static CurrencyCode ANG => new() { Value = "ANG" };

    /// <summary>
    /// Kwanza
    /// </summary>
    public static CurrencyCode AOA => new() { Value = "AOA" };

    /// <summary>
    /// Argentine Peso
    /// </summary>
    public static CurrencyCode ARS => new() { Value = "ARS" };

    /// <summary>
    /// Australian Dollar
    /// </summary>
    public static CurrencyCode AUD => new() { Value = "AUD" };

    /// <summary>
    /// Aruban Florin
    /// </summary>
    public static CurrencyCode AWG => new() { Value = "AWG" };

    /// <summary>
    /// Azerbaijan Manat
    /// </summary>
    public static CurrencyCode AZN => new() { Value = "AZN" };

    /// <summary>
    /// Convertible Mark
    /// </summary>
    public static CurrencyCode BAM => new() { Value = "BAM" };

    /// <summary>
    /// Barbados Dollar
    /// </summary>
    public static CurrencyCode BBD => new() { Value = "BBD" };

    /// <summary>
    /// Taka
    /// </summary>
    public static CurrencyCode BDT => new() { Value = "BDT" };

    /// <summary>
    /// Bulgarian Lev
    /// </summary>
    public static CurrencyCode BGN => new() { Value = "BGN" };

    /// <summary>
    /// Bahraini Dinar
    /// </summary>
    public static CurrencyCode BHD => new() { Value = "BHD" };

    /// <summary>
    /// Burundi Franc
    /// </summary>
    public static CurrencyCode BIF => new() { Value = "BIF" };

    /// <summary>
    /// Bermudian Dollar
    /// </summary>
    public static CurrencyCode BMD => new() { Value = "BMD" };

    /// <summary>
    /// Brunei Dollar
    /// </summary>
    public static CurrencyCode BND => new() { Value = "BND" };

    /// <summary>
    /// Boliviano
    /// </summary>
    public static CurrencyCode BOB => new() { Value = "BOB" };

    /// <summary>
    /// Mvdol
    /// </summary>
    public static CurrencyCode BOV => new() { Value = "BOV" };

    /// <summary>
    /// Brazilian Real
    /// </summary>
    public static CurrencyCode BRL => new() { Value = "BRL" };

    /// <summary>
    /// Bahamian Dollar
    /// </summary>
    public static CurrencyCode BSD => new() { Value = "BSD" };

    /// <summary>
    /// Ngultrum
    /// </summary>
    public static CurrencyCode BTN => new() { Value = "BTN" };

    /// <summary>
    /// Pula
    /// </summary>
    public static CurrencyCode BWP => new() { Value = "BWP" };

    /// <summary>
    /// Belarusian Ruble
    /// </summary>
    public static CurrencyCode BYN => new() { Value = "BYN" };

    /// <summary>
    /// Belize Dollar
    /// </summary>
    public static CurrencyCode BZD => new() { Value = "BZD" };

    /// <summary>
    /// Canadian Dollar
    /// </summary>
    public static CurrencyCode CAD => new() { Value = "CAD" };

    /// <summary>
    /// Congolese Franc
    /// </summary>
    public static CurrencyCode CDF => new() { Value = "CDF" };

    /// <summary>
    /// WIR Euro
    /// </summary>
    public static CurrencyCode CHE => new() { Value = "CHE" };

    /// <summary>
    /// Swiss Franc
    /// </summary>
    public static CurrencyCode CHF => new() { Value = "CHF" };

    /// <summary>
    /// WIR Franc
    /// </summary>
    public static CurrencyCode CHW => new() { Value = "CHW" };

    /// <summary>
    /// Unidad de Fomento
    /// </summary>
    public static CurrencyCode CLF => new() { Value = "CLF" };

    /// <summary>
    /// Chilean Peso
    /// </summary>
    public static CurrencyCode CLP => new() { Value = "CLP" };

    /// <summary>
    /// Yuan Renminbi
    /// </summary>
    public static CurrencyCode CNY => new() { Value = "CNY" };

    /// <summary>
    /// Colombian Peso
    /// </summary>
    public static CurrencyCode COP => new() { Value = "COP" };

    /// <summary>
    /// Unidad de Valor Real
    /// </summary>
    public static CurrencyCode COU => new() { Value = "COU" };

    /// <summary>
    /// Costa Rican Colon
    /// </summary>
    public static CurrencyCode CRC => new() { Value = "CRC" };

    /// <summary>
    /// Peso Convertible
    /// </summary>
    public static CurrencyCode CUC => new() { Value = "CUC" };

    /// <summary>
    /// Cuban Peso
    /// </summary>
    public static CurrencyCode CUP => new() { Value = "CUP" };

    /// <summary>
    /// Cabo Verde Escudo
    /// </summary>
    public static CurrencyCode CVE => new() { Value = "CVE" };

    /// <summary>
    /// Czech Koruna
    /// </summary>
    public static CurrencyCode CZK => new() { Value = "CZK" };

    /// <summary>
    /// Djibouti Franc
    /// </summary>
    public static CurrencyCode DJF => new() { Value = "DJF" };

    /// <summary>
    /// Danish Krone
    /// </summary>
    public static CurrencyCode DKK => new() { Value = "DKK" };

    /// <summary>
    /// Dominican Peso
    /// </summary>
    public static CurrencyCode DOP => new() { Value = "DOP" };

    /// <summary>
    /// Algerian Dinar
    /// </summary>
    public static CurrencyCode DZD => new() { Value = "DZD" };

    /// <summary>
    /// Egyptian Pound
    /// </summary>
    public static CurrencyCode EGP => new() { Value = "EGP" };

    /// <summary>
    /// Nakfa
    /// </summary>
    public static CurrencyCode ERN => new() { Value = "ERN" };

    /// <summary>
    /// Ethiopian Birr
    /// </summary>
    public static CurrencyCode ETB => new() { Value = "ETB" };

    /// <summary>
    /// Euro
    /// </summary>
    public static CurrencyCode EUR => new() { Value = "EUR" };

    /// <summary>
    /// Fiji Dollar
    /// </summary>
    public static CurrencyCode FJD => new() { Value = "FJD" };

    /// <summary>
    /// Falkland Islands Pound
    /// </summary>
    public static CurrencyCode FKP => new() { Value = "FKP" };

    /// <summary>
    /// Pound Sterling
    /// </summary>
    public static CurrencyCode GBP => new() { Value = "GBP" };

    /// <summary>
    /// Lari
    /// </summary>
    public static CurrencyCode GEL => new() { Value = "GEL" };

    /// <summary>
    /// Ghana Cedi
    /// </summary>
    public static CurrencyCode GHS => new() { Value = "GHS" };

    /// <summary>
    /// Gibraltar Pound
    /// </summary>
    public static CurrencyCode GIP => new() { Value = "GIP" };

    /// <summary>
    /// Dalasi
    /// </summary>
    public static CurrencyCode GMD => new() { Value = "GMD" };

    /// <summary>
    /// Guinean Franc
    /// </summary>
    public static CurrencyCode GNF => new() { Value = "GNF" };

    /// <summary>
    /// Quetzal
    /// </summary>
    public static CurrencyCode GTQ => new() { Value = "GTQ" };

    /// <summary>
    /// Guyana Dollar
    /// </summary>
    public static CurrencyCode GYD => new() { Value = "GYD" };

    /// <summary>
    /// Hong Kong Dollar
    /// </summary>
    public static CurrencyCode HKD => new() { Value = "HKD" };

    /// <summary>
    /// Lempira
    /// </summary>
    public static CurrencyCode HNL => new() { Value = "HNL" };

    /// <summary>
    /// Kuna
    /// </summary>
    public static CurrencyCode HRK => new() { Value = "HRK" };

    /// <summary>
    /// Gourde
    /// </summary>
    public static CurrencyCode HTG => new() { Value = "HTG" };

    /// <summary>
    /// Forint
    /// </summary>
    public static CurrencyCode HUF => new() { Value = "HUF" };

    /// <summary>
    /// Rupiah
    /// </summary>
    public static CurrencyCode IDR => new() { Value = "IDR" };

    /// <summary>
    /// New Israeli Sheqel
    /// </summary>
    public static CurrencyCode ILS => new() { Value = "ILS" };

    /// <summary>
    /// Indian Rupee
    /// </summary>
    public static CurrencyCode INR => new() { Value = "INR" };

    /// <summary>
    /// Iraqi Dinar
    /// </summary>
    public static CurrencyCode IQD => new() { Value = "IQD" };

    /// <summary>
    /// Iranian Rial
    /// </summary>
    public static CurrencyCode IRR => new() { Value = "IRR" };

    /// <summary>
    /// Iceland Krona
    /// </summary>
    public static CurrencyCode ISK => new() { Value = "ISK" };

    /// <summary>
    /// Jamaican Dollar
    /// </summary>
    public static CurrencyCode JMD => new() { Value = "JMD" };

    /// <summary>
    /// Jordanian Dinar
    /// </summary>
    public static CurrencyCode JOD => new() { Value = "JOD" };

    /// <summary>
    /// Yen
    /// </summary>
    public static CurrencyCode JPY => new() { Value = "JPY" };

    /// <summary>
    /// Kenyan Shilling
    /// </summary>
    public static CurrencyCode KES => new() { Value = "KES" };

    /// <summary>
    /// Som
    /// </summary>
    public static CurrencyCode KGS => new() { Value = "KGS" };

    /// <summary>
    /// Riel
    /// </summary>
    public static CurrencyCode KHR => new() { Value = "KHR" };

    /// <summary>
    /// Comorian Franc
    /// </summary>
    public static CurrencyCode KMF => new() { Value = "KMF" };

    /// <summary>
    /// North Korean Won
    /// </summary>
    public static CurrencyCode KPW => new() { Value = "KPW" };

    /// <summary>
    /// Won
    /// </summary>
    public static CurrencyCode KRW => new() { Value = "KRW" };

    /// <summary>
    /// Kuwaiti Dinar
    /// </summary>
    public static CurrencyCode KWD => new() { Value = "KWD" };

    /// <summary>
    /// Cayman Islands Dollar
    /// </summary>
    public static CurrencyCode KYD => new() { Value = "KYD" };

    /// <summary>
    /// Tenge
    /// </summary>
    public static CurrencyCode KZT => new() { Value = "KZT" };

    /// <summary>
    /// Lao Kip
    /// </summary>
    public static CurrencyCode LAK => new() { Value = "LAK" };

    /// <summary>
    /// Lebanese Pound
    /// </summary>
    public static CurrencyCode LBP => new() { Value = "LBP" };

    /// <summary>
    /// Sri Lanka Rupee
    /// </summary>
    public static CurrencyCode LKR => new() { Value = "LKR" };

    /// <summary>
    /// Liberian Dollar
    /// </summary>
    public static CurrencyCode LRD => new() { Value = "LRD" };

    /// <summary>
    /// Loti
    /// </summary>
    public static CurrencyCode LSL => new() { Value = "LSL" };

    /// <summary>
    /// Libyan Dinar
    /// </summary>
    public static CurrencyCode LYD => new() { Value = "LYD" };

    /// <summary>
    /// Moroccan Dirham
    /// </summary>
    public static CurrencyCode MAD => new() { Value = "MAD" };

    /// <summary>
    /// Moldovan Leu
    /// </summary>
    public static CurrencyCode MDL => new() { Value = "MDL" };

    /// <summary>
    /// Malagasy Ariary
    /// </summary>
    public static CurrencyCode MGA => new() { Value = "MGA" };

    /// <summary>
    /// Denar
    /// </summary>
    public static CurrencyCode MKD => new() { Value = "MKD" };

    /// <summary>
    /// Kyat
    /// </summary>
    public static CurrencyCode MMK => new() { Value = "MMK" };

    /// <summary>
    /// Tugrik
    /// </summary>
    public static CurrencyCode MNT => new() { Value = "MNT" };

    /// <summary>
    /// Pataca
    /// </summary>
    public static CurrencyCode MOP => new() { Value = "MOP" };

    /// <summary>
    /// Ouguiya
    /// </summary>
    public static CurrencyCode MRU => new() { Value = "MRU" };

    /// <summary>
    /// Mauritius Rupee
    /// </summary>
    public static CurrencyCode MUR => new() { Value = "MUR" };

    /// <summary>
    /// Rufiyaa
    /// </summary>
    public static CurrencyCode MVR => new() { Value = "MVR" };

    /// <summary>
    /// Malawi Kwacha
    /// </summary>
    public static CurrencyCode MWK => new() { Value = "MWK" };

    /// <summary>
    /// Mexican Peso
    /// </summary>
    public static CurrencyCode MXN => new() { Value = "MXN" };

    /// <summary>
    /// Mexican Unidad de Inversion (UDI)
    /// </summary>
    public static CurrencyCode MXV => new() { Value = "MXV" };

    /// <summary>
    /// Malaysian Ringgit
    /// </summary>
    public static CurrencyCode MYR => new() { Value = "MYR" };

    /// <summary>
    /// Mozambique Metical
    /// </summary>
    public static CurrencyCode MZN => new() { Value = "MZN" };

    /// <summary>
    /// Namibia Dollar
    /// </summary>
    public static CurrencyCode NAD => new() { Value = "NAD" };

    /// <summary>
    /// Naira
    /// </summary>
    public static CurrencyCode NGN => new() { Value = "NGN" };

    /// <summary>
    /// Cordoba Oro
    /// </summary>
    public static CurrencyCode NIO => new() { Value = "NIO" };

    /// <summary>
    /// Norwegian Krone
    /// </summary>
    public static CurrencyCode NOK => new() { Value = "NOK" };

    /// <summary>
    /// Nepalese Rupee
    /// </summary>
    public static CurrencyCode NPR => new() { Value = "NPR" };

    /// <summary>
    /// New Zealand Dollar
    /// </summary>
    public static CurrencyCode NZD => new() { Value = "NZD" };

    /// <summary>
    /// Rial Omani
    /// </summary>
    public static CurrencyCode OMR => new() { Value = "OMR" };

    /// <summary>
    /// Balboa
    /// </summary>
    public static CurrencyCode PAB => new() { Value = "PAB" };

    /// <summary>
    /// Sol
    /// </summary>
    public static CurrencyCode PEN => new() { Value = "PEN" };

    /// <summary>
    /// Kina
    /// </summary>
    public static CurrencyCode PGK => new() { Value = "PGK" };

    /// <summary>
    /// Philippine Peso
    /// </summary>
    public static CurrencyCode PHP => new() { Value = "PHP" };

    /// <summary>
    /// Pakistan Rupee
    /// </summary>
    public static CurrencyCode PKR => new() { Value = "PKR" };

    /// <summary>
    /// Zloty
    /// </summary>
    public static CurrencyCode PLN => new() { Value = "PLN" };

    /// <summary>
    /// Guarani
    /// </summary>
    public static CurrencyCode PYG => new() { Value = "PYG" };

    /// <summary>
    /// Qatari Rial
    /// </summary>
    public static CurrencyCode QAR => new() { Value = "QAR" };

    /// <summary>
    /// Romanian Leu
    /// </summary>
    public static CurrencyCode RON => new() { Value = "RON" };

    /// <summary>
    /// Serbian Dinar
    /// </summary>
    public static CurrencyCode RSD => new() { Value = "RSD" };

    /// <summary>
    /// Russian Ruble
    /// </summary>
    public static CurrencyCode RUB => new() { Value = "RUB" };

    /// <summary>
    /// Rwanda Franc
    /// </summary>
    public static CurrencyCode RWF => new() { Value = "RWF" };

    /// <summary>
    /// Saudi Riyal
    /// </summary>
    public static CurrencyCode SAR => new() { Value = "SAR" };

    /// <summary>
    /// Solomon Islands Dollar
    /// </summary>
    public static CurrencyCode SBD => new() { Value = "SBD" };

    /// <summary>
    /// Seychelles Rupee
    /// </summary>
    public static CurrencyCode SCR => new() { Value = "SCR" };

    /// <summary>
    /// Sudanese Pound
    /// </summary>
    public static CurrencyCode SDG => new() { Value = "SDG" };

    /// <summary>
    /// Swedish Krona
    /// </summary>
    public static CurrencyCode SEK => new() { Value = "SEK" };

    /// <summary>
    /// Singapore Dollar
    /// </summary>
    public static CurrencyCode SGD => new() { Value = "SGD" };

    /// <summary>
    /// Saint Helena Pound
    /// </summary>
    public static CurrencyCode SHP => new() { Value = "SHP" };

    /// <summary>
    /// Leone
    /// </summary>
    public static CurrencyCode SLL => new() { Value = "SLL" };

    /// <summary>
    /// Somali Shilling
    /// </summary>
    public static CurrencyCode SOS => new() { Value = "SOS" };

    /// <summary>
    /// Surinam Dollar
    /// </summary>
    public static CurrencyCode SRD => new() { Value = "SRD" };

    /// <summary>
    /// South Sudanese Pound
    /// </summary>
    public static CurrencyCode SSP => new() { Value = "SSP" };

    /// <summary>
    /// Dobra
    /// </summary>
    public static CurrencyCode STN => new() { Value = "STN" };

    /// <summary>
    /// El Salvador Colon
    /// </summary>
    public static CurrencyCode SVC => new() { Value = "SVC" };

    /// <summary>
    /// Syrian Pound
    /// </summary>
    public static CurrencyCode SYP => new() { Value = "SYP" };

    /// <summary>
    /// Lilangeni
    /// </summary>
    public static CurrencyCode SZL => new() { Value = "SZL" };

    /// <summary>
    /// Baht
    /// </summary>
    public static CurrencyCode THB => new() { Value = "THB" };

    /// <summary>
    /// Somoni
    /// </summary>
    public static CurrencyCode TJS => new() { Value = "TJS" };

    /// <summary>
    /// Turkmenistan New Manat
    /// </summary>
    public static CurrencyCode TMT => new() { Value = "TMT" };

    /// <summary>
    /// Tunisian Dinar
    /// </summary>
    public static CurrencyCode TND => new() { Value = "TND" };

    /// <summary>
    /// Pa’anga
    /// </summary>
    public static CurrencyCode TOP => new() { Value = "TOP" };

    /// <summary>
    /// Turkish Lira
    /// </summary>
    public static CurrencyCode TRY => new() { Value = "TRY" };

    /// <summary>
    /// Trinidad and Tobago Dollar
    /// </summary>
    public static CurrencyCode TTD => new() { Value = "TTD" };

    /// <summary>
    /// New Taiwan Dollar
    /// </summary>
    public static CurrencyCode TWD => new() { Value = "TWD" };

    /// <summary>
    /// Tanzanian Shilling
    /// </summary>
    public static CurrencyCode TZS => new() { Value = "TZS" };

    /// <summary>
    /// Hryvnia
    /// </summary>
    public static CurrencyCode UAH => new() { Value = "UAH" };

    /// <summary>
    /// Uganda Shilling
    /// </summary>
    public static CurrencyCode UGX => new() { Value = "UGX" };

    /// <summary>
    /// US Dollar
    /// </summary>
    public static CurrencyCode USD => new() { Value = "USD" };

    /// <summary>
    /// US Dollar (Next day)
    /// </summary>
    public static CurrencyCode USN => new() { Value = "USN" };

    /// <summary>
    /// Uruguay Peso en Unidades Indexadas (UI)
    /// </summary>
    public static CurrencyCode UYI => new() { Value = "UYI" };

    /// <summary>
    /// Peso Uruguayo
    /// </summary>
    public static CurrencyCode UYU => new() { Value = "UYU" };

    /// <summary>
    /// Unidad Previsional
    /// </summary>
    public static CurrencyCode UYW => new() { Value = "UYW" };

    /// <summary>
    /// Uzbekistan Sum
    /// </summary>
    public static CurrencyCode UZS => new() { Value = "UZS" };

    /// <summary>
    /// Bolívar Soberano
    /// </summary>
    public static CurrencyCode VES => new() { Value = "VES" };

    /// <summary>
    /// Dong
    /// </summary>
    public static CurrencyCode VND => new() { Value = "VND" };

    /// <summary>
    /// Vatu
    /// </summary>
    public static CurrencyCode VUV => new() { Value = "VUV" };

    /// <summary>
    /// Tala
    /// </summary>
    public static CurrencyCode WST => new() { Value = "WST" };

    /// <summary>
    /// CFA Franc BEAC
    /// </summary>
    public static CurrencyCode XAF => new() { Value = "XAF" };

    /// <summary>
    /// Silver
    /// </summary>
    public static CurrencyCode XAG => new() { Value = "XAG" };

    /// <summary>
    /// Gold
    /// </summary>
    public static CurrencyCode XAU => new() { Value = "XAU" };

    /// <summary>
    /// Bond Markets Unit European Composite Unit (EURCO)
    /// </summary>
    public static CurrencyCode XBA => new() { Value = "XBA" };

    /// <summary>
    /// Bond Markets Unit European Monetary Unit (E.M.U.-6)
    /// </summary>
    public static CurrencyCode XBB => new() { Value = "XBB" };

    /// <summary>
    /// Bond Markets Unit European Unit of Account 9 (E.U.A.-9)
    /// </summary>
    public static CurrencyCode XBC => new() { Value = "XBC" };

    /// <summary>
    /// Bond Markets Unit European Unit of Account 17 (E.U.A.-17)
    /// </summary>
    public static CurrencyCode XBD => new() { Value = "XBD" };

    /// <summary>
    /// East Caribbean Dollar
    /// </summary>
    public static CurrencyCode XCD => new() { Value = "XCD" };

    /// <summary>
    /// SDR (Special Drawing Right)
    /// </summary>
    public static CurrencyCode XDR => new() { Value = "XDR" };

    /// <summary>
    /// CFA Franc BCEAO
    /// </summary>
    public static CurrencyCode XOF => new() { Value = "XOF" };

    /// <summary>
    /// Palladium
    /// </summary>
    public static CurrencyCode XPD => new() { Value = "XPD" };

    /// <summary>
    /// CFP Franc
    /// </summary>
    public static CurrencyCode XPF => new() { Value = "XPF" };

    /// <summary>
    /// Platinum
    /// </summary>
    public static CurrencyCode XPT => new() { Value = "XPT" };

    /// <summary>
    /// Sucre
    /// </summary>
    public static CurrencyCode XSU => new() { Value = "XSU" };

    /// <summary>
    /// Codes specifically reserved for testing purposes
    /// </summary>
    public static CurrencyCode XTS => new() { Value = "XTS" };

    /// <summary>
    /// ADB Unit of Account
    /// </summary>
    public static CurrencyCode XUA => new() { Value = "XUA" };

    /// <summary>
    /// The codes assigned for transactions where no currency is involved
    /// </summary>
    public static CurrencyCode XXX => new() { Value = "XXX" };

    /// <summary>
    /// Yemeni Rial
    /// </summary>
    public static CurrencyCode YER => new() { Value = "YER" };

    /// <summary>
    /// Rand
    /// </summary>
    public static CurrencyCode ZAR => new() { Value = "ZAR" };

    /// <summary>
    /// Zambian Kwacha
    /// </summary>
    public static CurrencyCode ZMW => new() { Value = "ZMW" };

    /// <summary>
    /// Zimbabwe Dollar
    /// </summary>
    public static CurrencyCode ZWL => new() { Value = "ZWL" };
}
