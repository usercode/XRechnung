namespace XRechnung;

public static class AmountExtensions
{
    extension(Amount)
    {
        /// <summary>
        /// UAE Dirham
        /// </summary>
        public static Amount AED(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.AED };

        /// <summary>
        /// Afghani
        /// </summary>
        public static Amount AFN(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.AFN };

        /// <summary>
        /// Lek
        /// </summary>
        public static Amount ALL(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.ALL };

        /// <summary>
        /// Armenian Dram
        /// </summary>
        public static Amount AMD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.AMD };

        /// <summary>
        /// Netherlands Antillean Guilder
        /// </summary>
        public static Amount ANG(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.ANG };

        /// <summary>
        /// Kwanza
        /// </summary>
        public static Amount AOA(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.AOA };

        /// <summary>
        /// Argentine Peso
        /// </summary>
        public static Amount ARS(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.ARS };

        /// <summary>
        /// Australian Dollar
        /// </summary>
        public static Amount AUD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.AUD };

        /// <summary>
        /// Aruban Florin
        /// </summary>
        public static Amount AWG(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.AWG };

        /// <summary>
        /// Azerbaijan Manat
        /// </summary>
        public static Amount AZN(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.AZN };

        /// <summary>
        /// Convertible Mark
        /// </summary>
        public static Amount BAM(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.BAM };

        /// <summary>
        /// Barbados Dollar
        /// </summary>
        public static Amount BBD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.BBD };

        /// <summary>
        /// Taka
        /// </summary>
        public static Amount BDT(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.BDT };

        /// <summary>
        /// Bulgarian Lev
        /// </summary>
        public static Amount BGN(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.BGN };

        /// <summary>
        /// Bahraini Dinar
        /// </summary>
        public static Amount BHD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.BHD };

        /// <summary>
        /// Burundi Franc
        /// </summary>
        public static Amount BIF(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.BIF };

        /// <summary>
        /// Bermudian Dollar
        /// </summary>
        public static Amount BMD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.BMD };

        /// <summary>
        /// Brunei Dollar
        /// </summary>
        public static Amount BND(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.BND };

        /// <summary>
        /// Boliviano
        /// </summary>
        public static Amount BOB(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.BOB };

        /// <summary>
        /// Mvdol
        /// </summary>
        public static Amount BOV(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.BOV };

        /// <summary>
        /// Brazilian Real
        /// </summary>
        public static Amount BRL(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.BRL };

        /// <summary>
        /// Bahamian Dollar
        /// </summary>
        public static Amount BSD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.BSD };

        /// <summary>
        /// Ngultrum
        /// </summary>
        public static Amount BTN(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.BTN };

        /// <summary>
        /// Pula
        /// </summary>
        public static Amount BWP(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.BWP };

        /// <summary>
        /// Belarusian Ruble
        /// </summary>
        public static Amount BYN(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.BYN };

        /// <summary>
        /// Belize Dollar
        /// </summary>
        public static Amount BZD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.BZD };

        /// <summary>
        /// Canadian Dollar
        /// </summary>
        public static Amount CAD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.CAD };

        /// <summary>
        /// Congolese Franc
        /// </summary>
        public static Amount CDF(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.CDF };

        /// <summary>
        /// WIR Euro
        /// </summary>
        public static Amount CHE(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.CHE };

        /// <summary>
        /// Swiss Franc
        /// </summary>
        public static Amount CHF(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.CHF };

        /// <summary>
        /// WIR Franc
        /// </summary>
        public static Amount CHW(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.CHW };

        /// <summary>
        /// Unidad de Fomento
        /// </summary>
        public static Amount CLF(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.CLF };

        /// <summary>
        /// Chilean Peso
        /// </summary>
        public static Amount CLP(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.CLP };

        /// <summary>
        /// Yuan Renminbi
        /// </summary>
        public static Amount CNY(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.CNY };

        /// <summary>
        /// Colombian Peso
        /// </summary>
        public static Amount COP(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.COP };

        /// <summary>
        /// Unidad de Valor Real
        /// </summary>
        public static Amount COU(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.COU };

        /// <summary>
        /// Costa Rican Colon
        /// </summary>
        public static Amount CRC(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.CRC };

        /// <summary>
        /// Peso Convertible
        /// </summary>
        public static Amount CUC(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.CUC };

        /// <summary>
        /// Cuban Peso
        /// </summary>
        public static Amount CUP(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.CUP };

        /// <summary>
        /// Cabo Verde Escudo
        /// </summary>
        public static Amount CVE(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.CVE };

        /// <summary>
        /// Czech Koruna
        /// </summary>
        public static Amount CZK(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.CZK };

        /// <summary>
        /// Djibouti Franc
        /// </summary>
        public static Amount DJF(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.DJF };

        /// <summary>
        /// Danish Krone
        /// </summary>
        public static Amount DKK(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.DKK };

        /// <summary>
        /// Dominican Peso
        /// </summary>
        public static Amount DOP(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.DOP };

        /// <summary>
        /// Algerian Dinar
        /// </summary>
        public static Amount DZD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.DZD };

        /// <summary>
        /// Egyptian Pound
        /// </summary>
        public static Amount EGP(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.EGP };

        /// <summary>
        /// Nakfa
        /// </summary>
        public static Amount ERN(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.ERN };

        /// <summary>
        /// Ethiopian Birr
        /// </summary>
        public static Amount ETB(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.ETB };

        /// <summary>
        /// Euro
        /// </summary>
        public static Amount EUR(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.EUR };

        /// <summary>
        /// Fiji Dollar
        /// </summary>
        public static Amount FJD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.FJD };

        /// <summary>
        /// Falkland Islands Pound
        /// </summary>
        public static Amount FKP(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.FKP };

        /// <summary>
        /// Pound Sterling
        /// </summary>
        public static Amount GBP(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.GBP };

        /// <summary>
        /// Lari
        /// </summary>
        public static Amount GEL(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.GEL };

        /// <summary>
        /// Ghana Cedi
        /// </summary>
        public static Amount GHS(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.GHS };

        /// <summary>
        /// Gibraltar Pound
        /// </summary>
        public static Amount GIP(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.GIP };

        /// <summary>
        /// Dalasi
        /// </summary>
        public static Amount GMD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.GMD };

        /// <summary>
        /// Guinean Franc
        /// </summary>
        public static Amount GNF(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.GNF };

        /// <summary>
        /// Quetzal
        /// </summary>
        public static Amount GTQ(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.GTQ };

        /// <summary>
        /// Guyana Dollar
        /// </summary>
        public static Amount GYD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.GYD };

        /// <summary>
        /// Hong Kong Dollar
        /// </summary>
        public static Amount HKD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.HKD };

        /// <summary>
        /// Lempira
        /// </summary>
        public static Amount HNL(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.HNL };

        /// <summary>
        /// Kuna
        /// </summary>
        public static Amount HRK(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.HRK };

        /// <summary>
        /// Gourde
        /// </summary>
        public static Amount HTG(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.HTG };

        /// <summary>
        /// Forint
        /// </summary>
        public static Amount HUF(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.HUF };

        /// <summary>
        /// Rupiah
        /// </summary>
        public static Amount IDR(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.IDR };

        /// <summary>
        /// New Israeli Sheqel
        /// </summary>
        public static Amount ILS(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.ILS };

        /// <summary>
        /// Indian Rupee
        /// </summary>
        public static Amount INR(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.INR };

        /// <summary>
        /// Iraqi Dinar
        /// </summary>
        public static Amount IQD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.IQD };

        /// <summary>
        /// Iranian Rial
        /// </summary>
        public static Amount IRR(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.IRR };

        /// <summary>
        /// Iceland Krona
        /// </summary>
        public static Amount ISK(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.ISK };

        /// <summary>
        /// Jamaican Dollar
        /// </summary>
        public static Amount JMD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.JMD };

        /// <summary>
        /// Jordanian Dinar
        /// </summary>
        public static Amount JOD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.JOD };

        /// <summary>
        /// Yen
        /// </summary>
        public static Amount JPY(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.JPY };

        /// <summary>
        /// Kenyan Shilling
        /// </summary>
        public static Amount KES(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.KES };

        /// <summary>
        /// Som
        /// </summary>
        public static Amount KGS(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.KGS };

        /// <summary>
        /// Riel
        /// </summary>
        public static Amount KHR(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.KHR };

        /// <summary>
        /// Comorian Franc
        /// </summary>
        public static Amount KMF(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.KMF };

        /// <summary>
        /// North Korean Won
        /// </summary>
        public static Amount KPW(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.KPW };

        /// <summary>
        /// Won
        /// </summary>
        public static Amount KRW(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.KRW };

        /// <summary>
        /// Kuwaiti Dinar
        /// </summary>
        public static Amount KWD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.KWD };

        /// <summary>
        /// Cayman Islands Dollar
        /// </summary>
        public static Amount KYD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.KYD };

        /// <summary>
        /// Tenge
        /// </summary>
        public static Amount KZT(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.KZT };

        /// <summary>
        /// Lao Kip
        /// </summary>
        public static Amount LAK(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.LAK };

        /// <summary>
        /// Lebanese Pound
        /// </summary>
        public static Amount LBP(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.LBP };

        /// <summary>
        /// Sri Lanka Rupee
        /// </summary>
        public static Amount LKR(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.LKR };

        /// <summary>
        /// Liberian Dollar
        /// </summary>
        public static Amount LRD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.LRD };

        /// <summary>
        /// Loti
        /// </summary>
        public static Amount LSL(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.LSL };

        /// <summary>
        /// Libyan Dinar
        /// </summary>
        public static Amount LYD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.LYD };

        /// <summary>
        /// Moroccan Dirham
        /// </summary>
        public static Amount MAD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.MAD };

        /// <summary>
        /// Moldovan Leu
        /// </summary>
        public static Amount MDL(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.MDL };

        /// <summary>
        /// Malagasy Ariary
        /// </summary>
        public static Amount MGA(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.MGA };

        /// <summary>
        /// Denar
        /// </summary>
        public static Amount MKD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.MKD };

        /// <summary>
        /// Kyat
        /// </summary>
        public static Amount MMK(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.MMK };

        /// <summary>
        /// Tugrik
        /// </summary>
        public static Amount MNT(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.MNT };

        /// <summary>
        /// Pataca
        /// </summary>
        public static Amount MOP(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.MOP };

        /// <summary>
        /// Ouguiya
        /// </summary>
        public static Amount MRU(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.MRU };

        /// <summary>
        /// Mauritius Rupee
        /// </summary>
        public static Amount MUR(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.MUR };

        /// <summary>
        /// Rufiyaa
        /// </summary>
        public static Amount MVR(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.MVR };

        /// <summary>
        /// Malawi Kwacha
        /// </summary>
        public static Amount MWK(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.MWK };

        /// <summary>
        /// Mexican Peso
        /// </summary>
        public static Amount MXN(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.MXN };

        /// <summary>
        /// Mexican Unidad de Inversion (UDI)
        /// </summary>
        public static Amount MXV(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.MXV };

        /// <summary>
        /// Malaysian Ringgit
        /// </summary>
        public static Amount MYR(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.MYR };

        /// <summary>
        /// Mozambique Metical
        /// </summary>
        public static Amount MZN(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.MZN };

        /// <summary>
        /// Namibia Dollar
        /// </summary>
        public static Amount NAD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.NAD };

        /// <summary>
        /// Naira
        /// </summary>
        public static Amount NGN(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.NGN };

        /// <summary>
        /// Cordoba Oro
        /// </summary>
        public static Amount NIO(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.NIO };

        /// <summary>
        /// Norwegian Krone
        /// </summary>
        public static Amount NOK(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.NOK };

        /// <summary>
        /// Nepalese Rupee
        /// </summary>
        public static Amount NPR(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.NPR };

        /// <summary>
        /// New Zealand Dollar
        /// </summary>
        public static Amount NZD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.NZD };

        /// <summary>
        /// Rial Omani
        /// </summary>
        public static Amount OMR(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.OMR };

        /// <summary>
        /// Balboa
        /// </summary>
        public static Amount PAB(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.PAB };

        /// <summary>
        /// Sol
        /// </summary>
        public static Amount PEN(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.PEN };

        /// <summary>
        /// Kina
        /// </summary>
        public static Amount PGK(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.PGK };

        /// <summary>
        /// Philippine Peso
        /// </summary>
        public static Amount PHP(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.PHP };

        /// <summary>
        /// Pakistan Rupee
        /// </summary>
        public static Amount PKR(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.PKR };

        /// <summary>
        /// Zloty
        /// </summary>
        public static Amount PLN(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.PLN };

        /// <summary>
        /// Guarani
        /// </summary>
        public static Amount PYG(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.PYG };

        /// <summary>
        /// Qatari Rial
        /// </summary>
        public static Amount QAR(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.QAR };

        /// <summary>
        /// Romanian Leu
        /// </summary>
        public static Amount RON(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.RON };

        /// <summary>
        /// Serbian Dinar
        /// </summary>
        public static Amount RSD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.RSD };

        /// <summary>
        /// Russian Ruble
        /// </summary>
        public static Amount RUB(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.RUB };

        /// <summary>
        /// Rwanda Franc
        /// </summary>
        public static Amount RWF(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.RWF };

        /// <summary>
        /// Saudi Riyal
        /// </summary>
        public static Amount SAR(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.SAR };

        /// <summary>
        /// Solomon Islands Dollar
        /// </summary>
        public static Amount SBD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.SBD };

        /// <summary>
        /// Seychelles Rupee
        /// </summary>
        public static Amount SCR(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.SCR };

        /// <summary>
        /// Sudanese Pound
        /// </summary>
        public static Amount SDG(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.SDG };

        /// <summary>
        /// Swedish Krona
        /// </summary>
        public static Amount SEK(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.SEK };

        /// <summary>
        /// Singapore Dollar
        /// </summary>
        public static Amount SGD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.SGD };

        /// <summary>
        /// Saint Helena Pound
        /// </summary>
        public static Amount SHP(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.SHP };

        /// <summary>
        /// Leone
        /// </summary>
        public static Amount SLL(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.SLL };

        /// <summary>
        /// Somali Shilling
        /// </summary>
        public static Amount SOS(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.SOS };

        /// <summary>
        /// Surinam Dollar
        /// </summary>
        public static Amount SRD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.SRD };

        /// <summary>
        /// South Sudanese Pound
        /// </summary>
        public static Amount SSP(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.SSP };

        /// <summary>
        /// Dobra
        /// </summary>
        public static Amount STN(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.STN };

        /// <summary>
        /// El Salvador Colon
        /// </summary>
        public static Amount SVC(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.SVC };

        /// <summary>
        /// Syrian Pound
        /// </summary>
        public static Amount SYP(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.SYP };

        /// <summary>
        /// Lilangeni
        /// </summary>
        public static Amount SZL(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.SZL };

        /// <summary>
        /// Baht
        /// </summary>
        public static Amount THB(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.THB };

        /// <summary>
        /// Somoni
        /// </summary>
        public static Amount TJS(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.TJS };

        /// <summary>
        /// Turkmenistan New Manat
        /// </summary>
        public static Amount TMT(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.TMT };

        /// <summary>
        /// Tunisian Dinar
        /// </summary>
        public static Amount TND(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.TND };

        /// <summary>
        /// Pa’anga
        /// </summary>
        public static Amount TOP(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.TOP };

        /// <summary>
        /// Turkish Lira
        /// </summary>
        public static Amount TRY(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.TRY };

        /// <summary>
        /// Trinidad and Tobago Dollar
        /// </summary>
        public static Amount TTD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.TTD };

        /// <summary>
        /// New Taiwan Dollar
        /// </summary>
        public static Amount TWD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.TWD };

        /// <summary>
        /// Tanzanian Shilling
        /// </summary>
        public static Amount TZS(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.TZS };

        /// <summary>
        /// Hryvnia
        /// </summary>
        public static Amount UAH(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.UAH };

        /// <summary>
        /// Uganda Shilling
        /// </summary>
        public static Amount UGX(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.UGX };

        /// <summary>
        /// US Dollar
        /// </summary>
        public static Amount USD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.USD };

        /// <summary>
        /// US Dollar (Next day)
        /// </summary>
        public static Amount USN(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.USN };

        /// <summary>
        /// Uruguay Peso en Unidades Indexadas (UI)
        /// </summary>
        public static Amount UYI(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.UYI };

        /// <summary>
        /// Peso Uruguayo
        /// </summary>
        public static Amount UYU(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.UYU };

        /// <summary>
        /// Unidad Previsional
        /// </summary>
        public static Amount UYW(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.UYW };

        /// <summary>
        /// Uzbekistan Sum
        /// </summary>
        public static Amount UZS(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.UZS };

        /// <summary>
        /// Bolívar Soberano
        /// </summary>
        public static Amount VES(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.VES };

        /// <summary>
        /// Dong
        /// </summary>
        public static Amount VND(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.VND };

        /// <summary>
        /// Vatu
        /// </summary>
        public static Amount VUV(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.VUV };

        /// <summary>
        /// Tala
        /// </summary>
        public static Amount WST(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.WST };

        /// <summary>
        /// CFA Franc BEAC
        /// </summary>
        public static Amount XAF(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.XAF };

        /// <summary>
        /// Silver
        /// </summary>
        public static Amount XAG(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.XAG };

        /// <summary>
        /// Gold
        /// </summary>
        public static Amount XAU(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.XAU };

        /// <summary>
        /// Bond Markets Unit European Composite Unit (EURCO)
        /// </summary>
        public static Amount XBA(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.XBA };

        /// <summary>
        /// Bond Markets Unit European Monetary Unit (E.M.U.-6)
        /// </summary>
        public static Amount XBB(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.XBB };

        /// <summary>
        /// Bond Markets Unit European Unit of Account 9 (E.U.A.-9)
        /// </summary>
        public static Amount XBC(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.XBC };

        /// <summary>
        /// Bond Markets Unit European Unit of Account 17 (E.U.A.-17)
        /// </summary>
        public static Amount XBD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.XBD };

        /// <summary>
        /// East Caribbean Dollar
        /// </summary>
        public static Amount XCD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.XCD };

        /// <summary>
        /// SDR (Special Drawing Right)
        /// </summary>
        public static Amount XDR(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.XDR };

        /// <summary>
        /// CFA Franc BCEAO
        /// </summary>
        public static Amount XOF(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.XOF };

        /// <summary>
        /// Palladium
        /// </summary>
        public static Amount XPD(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.XPD };

        /// <summary>
        /// CFP Franc
        /// </summary>
        public static Amount XPF(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.XPF };

        /// <summary>
        /// Platinum
        /// </summary>
        public static Amount XPT(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.XPT };

        /// <summary>
        /// Sucre
        /// </summary>
        public static Amount XSU(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.XSU };

        /// <summary>
        /// Codes specifically reserved for testing purposes
        /// </summary>
        public static Amount XTS(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.XTS };

        /// <summary>
        /// ADB Unit of Account
        /// </summary>
        public static Amount XUA(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.XUA };

        /// <summary>
        /// The codes assigned for transactions where no currency is involved
        /// </summary>
        public static Amount XXX(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.XXX };

        /// <summary>
        /// Yemeni Rial
        /// </summary>
        public static Amount YER(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.YER };

        /// <summary>
        /// Rand
        /// </summary>
        public static Amount ZAR(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.ZAR };

        /// <summary>
        /// Zambian Kwacha
        /// </summary>
        public static Amount ZMW(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.ZMW };

        /// <summary>
        /// Zimbabwe Dollar
        /// </summary>
        public static Amount ZWL(decimal value) => new Amount() { Value = value, CurrencyCode = CurrencyCode.ZWL };
    }
}
