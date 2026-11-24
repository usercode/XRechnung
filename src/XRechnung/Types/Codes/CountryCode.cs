namespace XRechnung;

/// <summary>
/// ISO 3166 Alpha-2 country code. The source is the XRepository Country-Codes codelist (version 8).
/// </summary>
public record class CountryCode : Code
{
    /// <summary>
    /// das Fürstentum Andorra ISO numeric: 020
    /// </summary>
    public static readonly CountryCode Andorra = new CountryCode { Value = "AD" };

    /// <summary>
    /// die Vereinigten Arabischen Emirate (Abu Dhabi, Adschman, Dubai, Fudschaira, Ras al Chaima, Schardscha, Umm al Kaiwain) ISO numeric: 784
    /// </summary>
    public static readonly CountryCode VereinigteArabischeEmirate = new CountryCode { Value = "AE" };

    /// <summary>
    /// die Islamische Republik Afghanistan ISO numeric: 004
    /// </summary>
    public static readonly CountryCode Afghanistan = new CountryCode { Value = "AF" };

    /// <summary>
    /// Antigua und Barbuda ISO numeric: 028
    /// </summary>
    public static readonly CountryCode AntiguaUndBarbuda = new CountryCode { Value = "AG" };

    /// <summary>
    /// Anguilla ISO numeric: 660
    /// </summary>
    public static readonly CountryCode Anguilla = new CountryCode { Value = "AI" };

    /// <summary>
    /// die Republik Albanien ISO numeric: 008
    /// </summary>
    public static readonly CountryCode Albanien = new CountryCode { Value = "AL" };

    /// <summary>
    /// die Republik Armenien ISO numeric: 051
    /// </summary>
    public static readonly CountryCode Armenien = new CountryCode { Value = "AM" };

    /// <summary>
    /// die Republik Angola ISO numeric: 024
    /// </summary>
    public static readonly CountryCode Angola = new CountryCode { Value = "AO" };

    /// <summary>
    /// Antarktis ISO numeric: 010
    /// </summary>
    public static readonly CountryCode Antarktis = new CountryCode { Value = "AQ" };

    /// <summary>
    /// die Argentinische Republik ISO numeric: 032
    /// </summary>
    public static readonly CountryCode Argentinien = new CountryCode { Value = "AR" };

    /// <summary>
    /// Amerikanisch-Samoa ISO numeric: 016
    /// </summary>
    public static readonly CountryCode AmerikanischSamoa = new CountryCode { Value = "AS" };

    /// <summary>
    /// die Republik Österreich ISO numeric: 040
    /// </summary>
    public static readonly CountryCode Osterreich = new CountryCode { Value = "AT" };

    /// <summary>
    /// Australien ISO numeric: 036
    /// </summary>
    public static readonly CountryCode Australien = new CountryCode { Value = "AU" };

    /// <summary>
    /// Aruba ISO numeric: 533
    /// </summary>
    public static readonly CountryCode Aruba = new CountryCode { Value = "AW" };

    /// <summary>
    /// Ålandinseln ISO numeric: 248
    /// </summary>
    public static readonly CountryCode Alandinseln = new CountryCode { Value = "AX" };

    /// <summary>
    /// die Republik Aserbaidschan ISO numeric: 031
    /// </summary>
    public static readonly CountryCode Aserbaidschan = new CountryCode { Value = "AZ" };

    /// <summary>
    /// Bosnien und Herzegowina ISO numeric: 070
    /// </summary>
    public static readonly CountryCode BosnienUndHerzegowina = new CountryCode { Value = "BA" };

    /// <summary>
    /// Barbados ISO numeric: 052
    /// </summary>
    public static readonly CountryCode Barbados = new CountryCode { Value = "BB" };

    /// <summary>
    /// die Volksrepublik Bangladesch ISO numeric: 050
    /// </summary>
    public static readonly CountryCode Bangladesch = new CountryCode { Value = "BD" };

    /// <summary>
    /// das Königreich Belgien ISO numeric: 056
    /// </summary>
    public static readonly CountryCode Belgien = new CountryCode { Value = "BE" };

    /// <summary>
    /// Burkina Faso ISO numeric: 854
    /// </summary>
    public static readonly CountryCode BurkinaFaso = new CountryCode { Value = "BF" };

    /// <summary>
    /// die Republik Bulgarien ISO numeric: 100
    /// </summary>
    public static readonly CountryCode Bulgarien = new CountryCode { Value = "BG" };

    /// <summary>
    /// das Königreich Bahrain ISO numeric: 048
    /// </summary>
    public static readonly CountryCode Bahrain = new CountryCode { Value = "BH" };

    /// <summary>
    /// die Republik Burundi ISO numeric: 108
    /// </summary>
    public static readonly CountryCode Burundi = new CountryCode { Value = "BI" };

    /// <summary>
    /// die Republik Benin ISO numeric: 204
    /// </summary>
    public static readonly CountryCode Benin = new CountryCode { Value = "BJ" };

    /// <summary>
    /// St. Barthélemy ISO numeric: 652
    /// </summary>
    public static readonly CountryCode StBarthelemy = new CountryCode { Value = "BL" };

    /// <summary>
    /// Bermuda ISO numeric: 060
    /// </summary>
    public static readonly CountryCode Bermuda = new CountryCode { Value = "BM" };

    /// <summary>
    /// Brunei Darussalam ISO numeric: 096
    /// </summary>
    public static readonly CountryCode BruneiDarussalam = new CountryCode { Value = "BN" };

    /// <summary>
    /// der Plurinationale Staat Bolivien ISO numeric: 068
    /// </summary>
    public static readonly CountryCode PlurinationalerStaatBolivien = new CountryCode { Value = "BO" };

    /// <summary>
    /// Bonaire, St. Eustatius und Saba ISO numeric: 535
    /// </summary>
    public static readonly CountryCode BonaireStEustatiusUndSaba = new CountryCode { Value = "BQ" };

    /// <summary>
    /// die Föderative Republik Brasilien ISO numeric: 076
    /// </summary>
    public static readonly CountryCode Brasilien = new CountryCode { Value = "BR" };

    /// <summary>
    /// das Commonwealth der Bahamas ISO numeric: 044
    /// </summary>
    public static readonly CountryCode Bahamas = new CountryCode { Value = "BS" };

    /// <summary>
    /// das Königreich Bhutan ISO numeric: 064
    /// </summary>
    public static readonly CountryCode Bhutan = new CountryCode { Value = "BT" };

    /// <summary>
    /// Bouvetinsel ISO numeric: 074
    /// </summary>
    public static readonly CountryCode Bouvetinsel = new CountryCode { Value = "BV" };

    /// <summary>
    /// die Republik Botsuana ISO numeric: 072
    /// </summary>
    public static readonly CountryCode Botsuana = new CountryCode { Value = "BW" };

    /// <summary>
    /// die Republik Belarus ISO numeric: 112
    /// </summary>
    public static readonly CountryCode Belarus = new CountryCode { Value = "BY" };

    /// <summary>
    /// Belize ISO numeric: 084
    /// </summary>
    public static readonly CountryCode Belize = new CountryCode { Value = "BZ" };

    /// <summary>
    /// Kanada ISO numeric: 124
    /// </summary>
    public static readonly CountryCode Kanada = new CountryCode { Value = "CA" };

    /// <summary>
    /// Kokosinseln (Keeling) ISO numeric: 166
    /// </summary>
    public static readonly CountryCode KokosinselnKeeling = new CountryCode { Value = "CC" };

    /// <summary>
    /// die Demokratische Republik Kongo ISO numeric: 180
    /// </summary>
    public static readonly CountryCode DemokratischeRepublikKongo = new CountryCode { Value = "CD" };

    /// <summary>
    /// die Zentralafrikanische Republik ISO numeric: 140
    /// </summary>
    public static readonly CountryCode ZentralafrikanischeRepublik = new CountryCode { Value = "CF" };

    /// <summary>
    /// die Republik Kongo ISO numeric: 178
    /// </summary>
    public static readonly CountryCode Kongo = new CountryCode { Value = "CG" };

    /// <summary>
    /// die Schweizerische Eidgenossenschaft ISO numeric: 756
    /// </summary>
    public static readonly CountryCode Schweiz = new CountryCode { Value = "CH" };

    /// <summary>
    /// die Republik Côte d’Ivoire ISO numeric: 384
    /// </summary>
    public static readonly CountryCode CoteDIvoire = new CountryCode { Value = "CI" };

    /// <summary>
    /// die Cookinseln ISO numeric: 184
    /// </summary>
    public static readonly CountryCode Cookinseln = new CountryCode { Value = "CK" };

    /// <summary>
    /// die Republik Chile ISO numeric: 152
    /// </summary>
    public static readonly CountryCode Chile = new CountryCode { Value = "CL" };

    /// <summary>
    /// die Republik Kamerun ISO numeric: 120
    /// </summary>
    public static readonly CountryCode Kamerun = new CountryCode { Value = "CM" };

    /// <summary>
    /// die Volksrepublik China ISO numeric: 156
    /// </summary>
    public static readonly CountryCode China = new CountryCode { Value = "CN" };

    /// <summary>
    /// die Republik Kolumbien ISO numeric: 170
    /// </summary>
    public static readonly CountryCode Kolumbien = new CountryCode { Value = "CO" };

    /// <summary>
    /// die Republik Costa Rica ISO numeric: 188
    /// </summary>
    public static readonly CountryCode CostaRica = new CountryCode { Value = "CR" };

    /// <summary>
    /// die Republik Kuba ISO numeric: 192
    /// </summary>
    public static readonly CountryCode Kuba = new CountryCode { Value = "CU" };

    /// <summary>
    /// die Republik Cabo Verde ISO numeric: 132
    /// </summary>
    public static readonly CountryCode CaboVerde = new CountryCode { Value = "CV" };

    /// <summary>
    /// Curaçao ISO numeric: 531
    /// </summary>
    public static readonly CountryCode Curacao = new CountryCode { Value = "CW" };

    /// <summary>
    /// Territorium Weihnachtsinsel ISO numeric: 162
    /// </summary>
    public static readonly CountryCode Weihnachtsinsel = new CountryCode { Value = "CX" };

    /// <summary>
    /// die Republik Zypern ISO numeric: 196
    /// </summary>
    public static readonly CountryCode Zypern = new CountryCode { Value = "CY" };

    /// <summary>
    /// die Tschechische Republik ISO numeric: 203
    /// </summary>
    public static readonly CountryCode Tschechien = new CountryCode { Value = "CZ" };

    /// <summary>
    /// die Bundesrepublik Deutschland ISO numeric: 276
    /// </summary>
    public static readonly CountryCode Deutschland = new CountryCode { Value = "DE" };

    /// <summary>
    /// die Republik Dschibuti ISO numeric: 262
    /// </summary>
    public static readonly CountryCode Dschibuti = new CountryCode { Value = "DJ" };

    /// <summary>
    /// das Königreich Dänemark ISO numeric: 208
    /// </summary>
    public static readonly CountryCode Danemark = new CountryCode { Value = "DK" };

    /// <summary>
    /// das Commonwealth Dominica ISO numeric: 212
    /// </summary>
    public static readonly CountryCode Dominica = new CountryCode { Value = "DM" };

    /// <summary>
    /// die Dominikanische Republik ISO numeric: 214
    /// </summary>
    public static readonly CountryCode DominikanischeRepublik = new CountryCode { Value = "DO" };

    /// <summary>
    /// die Demokratische Volksrepublik Algerien ISO numeric: 012
    /// </summary>
    public static readonly CountryCode Algerien = new CountryCode { Value = "DZ" };

    /// <summary>
    /// die Republik Ecuador ISO numeric: 218
    /// </summary>
    public static readonly CountryCode Ecuador = new CountryCode { Value = "EC" };

    /// <summary>
    /// die Republik Estland ISO numeric: 233
    /// </summary>
    public static readonly CountryCode Estland = new CountryCode { Value = "EE" };

    /// <summary>
    /// die Arabische Republik Ägypten ISO numeric: 818
    /// </summary>
    public static readonly CountryCode Agypten = new CountryCode { Value = "EG" };

    /// <summary>
    /// Westsahara ISO numeric: 732
    /// </summary>
    public static readonly CountryCode Westsahara = new CountryCode { Value = "EH" };

    /// <summary>
    /// der Staat Eritrea ISO numeric: 232
    /// </summary>
    public static readonly CountryCode Eritrea = new CountryCode { Value = "ER" };

    /// <summary>
    /// das Königreich Spanien ISO numeric: 724
    /// </summary>
    public static readonly CountryCode Spanien = new CountryCode { Value = "ES" };

    /// <summary>
    /// die Demokratische Bundesrepublik Äthiopien ISO numeric: 231
    /// </summary>
    public static readonly CountryCode Athiopien = new CountryCode { Value = "ET" };

    /// <summary>
    /// die Republik Finnland ISO numeric: 246
    /// </summary>
    public static readonly CountryCode Finnland = new CountryCode { Value = "FI" };

    /// <summary>
    /// die Republik Fidschi ISO numeric: 242
    /// </summary>
    public static readonly CountryCode Fidschi = new CountryCode { Value = "FJ" };

    /// <summary>
    /// Falklandinseln (Malwinen) ISO numeric: 238
    /// </summary>
    public static readonly CountryCode FalklandinselnMalwinen = new CountryCode { Value = "FK" };

    /// <summary>
    /// die Föderierten Staaten von Mikronesien ISO numeric: 583
    /// </summary>
    public static readonly CountryCode FoderierteStaatenVonMikronesien = new CountryCode { Value = "FM" };

    /// <summary>
    /// Färöer ISO numeric: 234
    /// </summary>
    public static readonly CountryCode Faroer = new CountryCode { Value = "FO" };

    /// <summary>
    /// die Französische Republik ISO numeric: 250
    /// </summary>
    public static readonly CountryCode Frankreich = new CountryCode { Value = "FR" };

    /// <summary>
    /// die Gabunische Republik ISO numeric: 266
    /// </summary>
    public static readonly CountryCode Gabun = new CountryCode { Value = "GA" };

    /// <summary>
    /// das Vereinigte Königreich Großbritannien und Nordirland ISO numeric: 826
    /// </summary>
    public static readonly CountryCode VereinigtesKonigreich = new CountryCode { Value = "GB" };

    /// <summary>
    /// Grenada ISO numeric: 308
    /// </summary>
    public static readonly CountryCode Grenada = new CountryCode { Value = "GD" };

    /// <summary>
    /// Georgien ISO numeric: 268
    /// </summary>
    public static readonly CountryCode Georgien = new CountryCode { Value = "GE" };

    /// <summary>
    /// Französisch-Guayana ISO numeric: 254
    /// </summary>
    public static readonly CountryCode FranzosischGuayana = new CountryCode { Value = "GF" };

    /// <summary>
    /// Guernsey ISO numeric: 831
    /// </summary>
    public static readonly CountryCode Guernsey = new CountryCode { Value = "GG" };

    /// <summary>
    /// die Republik Ghana ISO numeric: 288
    /// </summary>
    public static readonly CountryCode Ghana = new CountryCode { Value = "GH" };

    /// <summary>
    /// Gibraltar ISO numeric: 292
    /// </summary>
    public static readonly CountryCode Gibraltar = new CountryCode { Value = "GI" };

    /// <summary>
    /// Grönland ISO numeric: 304
    /// </summary>
    public static readonly CountryCode Gronland = new CountryCode { Value = "GL" };

    /// <summary>
    /// die Republik Gambia ISO numeric: 270
    /// </summary>
    public static readonly CountryCode Gambia = new CountryCode { Value = "GM" };

    /// <summary>
    /// die Republik Guinea ISO numeric: 324
    /// </summary>
    public static readonly CountryCode Guinea = new CountryCode { Value = "GN" };

    /// <summary>
    /// Guadeloupe ISO numeric: 312
    /// </summary>
    public static readonly CountryCode Guadeloupe = new CountryCode { Value = "GP" };

    /// <summary>
    /// die Republik Äquatorialguinea ISO numeric: 226
    /// </summary>
    public static readonly CountryCode Aquatorialguinea = new CountryCode { Value = "GQ" };

    /// <summary>
    /// die Hellenische Republik ISO numeric: 300
    /// </summary>
    public static readonly CountryCode Griechenland = new CountryCode { Value = "GR" };

    /// <summary>
    /// Südgeorgien und die Südlichen Sandwichinseln ISO numeric: 239
    /// </summary>
    public static readonly CountryCode SudgeorgienUndDieSudlichenSandwichinseln = new CountryCode { Value = "GS" };

    /// <summary>
    /// die Republik Guatemala ISO numeric: 320
    /// </summary>
    public static readonly CountryCode Guatemala = new CountryCode { Value = "GT" };

    /// <summary>
    /// Guam ISO numeric: 316
    /// </summary>
    public static readonly CountryCode Guam = new CountryCode { Value = "GU" };

    /// <summary>
    /// die Republik Guinea-Bissau ISO numeric: 624
    /// </summary>
    public static readonly CountryCode GuineaBissau = new CountryCode { Value = "GW" };

    /// <summary>
    /// die Kooperative Republik Guyana ISO numeric: 328
    /// </summary>
    public static readonly CountryCode Guyana = new CountryCode { Value = "GY" };

    /// <summary>
    /// die Sonderverwaltungsregion Hongkong ISO numeric: 344
    /// </summary>
    public static readonly CountryCode Hongkong = new CountryCode { Value = "HK" };

    /// <summary>
    /// Territorium Heard und die McDonaldinseln ISO numeric: 334
    /// </summary>
    public static readonly CountryCode HeardUndDieMcDonaldinseln = new CountryCode { Value = "HM" };

    /// <summary>
    /// die Republik Honduras ISO numeric: 340
    /// </summary>
    public static readonly CountryCode Honduras = new CountryCode { Value = "HN" };

    /// <summary>
    /// die Republik Kroatien ISO numeric: 191
    /// </summary>
    public static readonly CountryCode Kroatien = new CountryCode { Value = "HR" };

    /// <summary>
    /// die Republik Haiti ISO numeric: 332
    /// </summary>
    public static readonly CountryCode Haiti = new CountryCode { Value = "HT" };

    /// <summary>
    /// Ungarn ISO numeric: 348
    /// </summary>
    public static readonly CountryCode Ungarn = new CountryCode { Value = "HU" };

    /// <summary>
    /// die Republik Indonesien ISO numeric: 360
    /// </summary>
    public static readonly CountryCode Indonesien = new CountryCode { Value = "ID" };

    /// <summary>
    /// Irland ISO numeric: 372
    /// </summary>
    public static readonly CountryCode Irland = new CountryCode { Value = "IE" };

    /// <summary>
    /// der Staat Israel ISO numeric: 376
    /// </summary>
    public static readonly CountryCode Israel = new CountryCode { Value = "IL" };

    /// <summary>
    /// Insel Man ISO numeric: 833
    /// </summary>
    public static readonly CountryCode InselMan = new CountryCode { Value = "IM" };

    /// <summary>
    /// die Republik Indien ISO numeric: 356
    /// </summary>
    public static readonly CountryCode Indien = new CountryCode { Value = "IN" };

    /// <summary>
    /// Britisches Territorium im Indischen Ozean ISO numeric: 086
    /// </summary>
    public static readonly CountryCode BritischesTerritoriumImIndischenOzean = new CountryCode { Value = "IO" };

    /// <summary>
    /// die Republik Irak ISO numeric: 368
    /// </summary>
    public static readonly CountryCode Irak = new CountryCode { Value = "IQ" };

    /// <summary>
    /// die Islamische Republik Iran ISO numeric: 364
    /// </summary>
    public static readonly CountryCode IslamischeRepublikIran = new CountryCode { Value = "IR" };

    /// <summary>
    /// die Republik Island ISO numeric: 352
    /// </summary>
    public static readonly CountryCode Island = new CountryCode { Value = "IS" };

    /// <summary>
    /// die Italienische Republik ISO numeric: 380
    /// </summary>
    public static readonly CountryCode Italien = new CountryCode { Value = "IT" };

    /// <summary>
    /// Jersey ISO numeric: 832
    /// </summary>
    public static readonly CountryCode Jersey = new CountryCode { Value = "JE" };

    /// <summary>
    /// Jamaika ISO numeric: 388
    /// </summary>
    public static readonly CountryCode Jamaika = new CountryCode { Value = "JM" };

    /// <summary>
    /// das Haschemitische Königreich Jordanien ISO numeric: 400
    /// </summary>
    public static readonly CountryCode Jordanien = new CountryCode { Value = "JO" };

    /// <summary>
    /// Japan ISO numeric: 392
    /// </summary>
    public static readonly CountryCode Japan = new CountryCode { Value = "JP" };

    /// <summary>
    /// die Republik Kenia ISO numeric: 404
    /// </summary>
    public static readonly CountryCode Kenia = new CountryCode { Value = "KE" };

    /// <summary>
    /// die Kirgisische Republik ISO numeric: 417
    /// </summary>
    public static readonly CountryCode Kirgisistan = new CountryCode { Value = "KG" };

    /// <summary>
    /// das Königreich Kambodscha ISO numeric: 116
    /// </summary>
    public static readonly CountryCode Kambodscha = new CountryCode { Value = "KH" };

    /// <summary>
    /// die Republik Kiribati ISO numeric: 296
    /// </summary>
    public static readonly CountryCode Kiribati = new CountryCode { Value = "KI" };

    /// <summary>
    /// die Union der Komoren ISO numeric: 174
    /// </summary>
    public static readonly CountryCode Komoren = new CountryCode { Value = "KM" };

    /// <summary>
    /// die Föderation St. Kitts und Nevis ISO numeric: 659
    /// </summary>
    public static readonly CountryCode StKittsUndNevis = new CountryCode { Value = "KN" };

    /// <summary>
    /// die Demokratische Volksrepublik Korea ISO numeric: 408
    /// </summary>
    public static readonly CountryCode DemokratischeVolksrepublikKorea = new CountryCode { Value = "KP" };

    /// <summary>
    /// die Republik Korea ISO numeric: 410
    /// </summary>
    public static readonly CountryCode RepublikKorea = new CountryCode { Value = "KR" };

    /// <summary>
    /// der Staat Kuwait ISO numeric: 414
    /// </summary>
    public static readonly CountryCode Kuwait = new CountryCode { Value = "KW" };

    /// <summary>
    /// Kaimaninseln ISO numeric: 136
    /// </summary>
    public static readonly CountryCode Kaimaninseln = new CountryCode { Value = "KY" };

    /// <summary>
    /// die Republik Kasachstan ISO numeric: 398
    /// </summary>
    public static readonly CountryCode Kasachstan = new CountryCode { Value = "KZ" };

    /// <summary>
    /// die Demokratische Volksrepublik Laos ISO numeric: 418
    /// </summary>
    public static readonly CountryCode DemokratischeVolksrepublikLaos = new CountryCode { Value = "LA" };

    /// <summary>
    /// die Libanesische Republik ISO numeric: 422
    /// </summary>
    public static readonly CountryCode Libanon = new CountryCode { Value = "LB" };

    /// <summary>
    /// St. Lucia ISO numeric: 662
    /// </summary>
    public static readonly CountryCode StLucia = new CountryCode { Value = "LC" };

    /// <summary>
    /// das Fürstentum Liechtenstein ISO numeric: 438
    /// </summary>
    public static readonly CountryCode Liechtenstein = new CountryCode { Value = "LI" };

    /// <summary>
    /// die Demokratische Sozialistische Republik Sri Lanka ISO numeric: 144
    /// </summary>
    public static readonly CountryCode SriLanka = new CountryCode { Value = "LK" };

    /// <summary>
    /// die Republik Liberia ISO numeric: 430
    /// </summary>
    public static readonly CountryCode Liberia = new CountryCode { Value = "LR" };

    /// <summary>
    /// das Königreich Lesotho ISO numeric: 426
    /// </summary>
    public static readonly CountryCode Lesotho = new CountryCode { Value = "LS" };

    /// <summary>
    /// die Republik Litauen ISO numeric: 440
    /// </summary>
    public static readonly CountryCode Litauen = new CountryCode { Value = "LT" };

    /// <summary>
    /// das Großherzogtum Luxemburg ISO numeric: 442
    /// </summary>
    public static readonly CountryCode Luxemburg = new CountryCode { Value = "LU" };

    /// <summary>
    /// die Republik Lettland ISO numeric: 428
    /// </summary>
    public static readonly CountryCode Lettland = new CountryCode { Value = "LV" };

    /// <summary>
    /// der Staat Libyen ISO numeric: 434
    /// </summary>
    public static readonly CountryCode Libyen = new CountryCode { Value = "LY" };

    /// <summary>
    /// das Königreich Marokko ISO numeric: 504
    /// </summary>
    public static readonly CountryCode Marokko = new CountryCode { Value = "MA" };

    /// <summary>
    /// das Fürstentum Monaco ISO numeric: 492
    /// </summary>
    public static readonly CountryCode Monaco = new CountryCode { Value = "MC" };

    /// <summary>
    /// die Republik Moldau ISO numeric: 498
    /// </summary>
    public static readonly CountryCode RepublikMoldau = new CountryCode { Value = "MD" };

    /// <summary>
    /// Montenegro ISO numeric: 499
    /// </summary>
    public static readonly CountryCode Montenegro = new CountryCode { Value = "ME" };

    /// <summary>
    /// St. Martin (französischer Teil) ISO numeric: 663
    /// </summary>
    public static readonly CountryCode StMartinFranzosischerTeil = new CountryCode { Value = "MF" };

    /// <summary>
    /// die Republik Madagaskar ISO numeric: 450
    /// </summary>
    public static readonly CountryCode Madagaskar = new CountryCode { Value = "MG" };

    /// <summary>
    /// die Republik Marshallinseln ISO numeric: 584
    /// </summary>
    public static readonly CountryCode Marshallinseln = new CountryCode { Value = "MH" };

    /// <summary>
    /// die Republik Nordmazedonien ISO numeric: 807
    /// </summary>
    public static readonly CountryCode Nordmazedonien = new CountryCode { Value = "MK" };

    /// <summary>
    /// die Republik Mali ISO numeric: 466
    /// </summary>
    public static readonly CountryCode Mali = new CountryCode { Value = "ML" };

    /// <summary>
    /// die Republik der Union Myanmar ISO numeric: 104
    /// </summary>
    public static readonly CountryCode Myanmar = new CountryCode { Value = "MM" };

    /// <summary>
    /// die Mongolei ISO numeric: 496
    /// </summary>
    public static readonly CountryCode Mongolei = new CountryCode { Value = "MN" };

    /// <summary>
    /// die Sonderverwaltungsregion Macau ISO numeric: 446
    /// </summary>
    public static readonly CountryCode Macau = new CountryCode { Value = "MO" };

    /// <summary>
    /// Commonwealth der Nördlichen Marianen ISO numeric: 580
    /// </summary>
    public static readonly CountryCode MarianenNordliche = new CountryCode { Value = "MP" };

    /// <summary>
    /// Martinique ISO numeric: 474
    /// </summary>
    public static readonly CountryCode Martinique = new CountryCode { Value = "MQ" };

    /// <summary>
    /// die Islamische Republik Mauretanien ISO numeric: 478
    /// </summary>
    public static readonly CountryCode Mauretanien = new CountryCode { Value = "MR" };

    /// <summary>
    /// Montserrat ISO numeric: 500
    /// </summary>
    public static readonly CountryCode Montserrat = new CountryCode { Value = "MS" };

    /// <summary>
    /// die Republik Malta ISO numeric: 470
    /// </summary>
    public static readonly CountryCode Malta = new CountryCode { Value = "MT" };

    /// <summary>
    /// die Republik Mauritius ISO numeric: 480
    /// </summary>
    public static readonly CountryCode Mauritius = new CountryCode { Value = "MU" };

    /// <summary>
    /// die Republik Malediven ISO numeric: 462
    /// </summary>
    public static readonly CountryCode Malediven = new CountryCode { Value = "MV" };

    /// <summary>
    /// die Republik Malawi ISO numeric: 454
    /// </summary>
    public static readonly CountryCode Malawi = new CountryCode { Value = "MW" };

    /// <summary>
    /// die Vereinigten Mexikanischen Staaten ISO numeric: 484
    /// </summary>
    public static readonly CountryCode Mexiko = new CountryCode { Value = "MX" };

    /// <summary>
    /// Malaysia ISO numeric: 458
    /// </summary>
    public static readonly CountryCode Malaysia = new CountryCode { Value = "MY" };

    /// <summary>
    /// die Republik Mosambik ISO numeric: 508
    /// </summary>
    public static readonly CountryCode Mosambik = new CountryCode { Value = "MZ" };

    /// <summary>
    /// die Republik Namibia ISO numeric: 516
    /// </summary>
    public static readonly CountryCode Namibia = new CountryCode { Value = "NA" };

    /// <summary>
    /// Neukaledonien ISO numeric: 540
    /// </summary>
    public static readonly CountryCode Neukaledonien = new CountryCode { Value = "NC" };

    /// <summary>
    /// die Republik Niger ISO numeric: 562
    /// </summary>
    public static readonly CountryCode Niger = new CountryCode { Value = "NE" };

    /// <summary>
    /// Norfolkinsel ISO numeric: 574
    /// </summary>
    public static readonly CountryCode Norfolkinsel = new CountryCode { Value = "NF" };

    /// <summary>
    /// die Bundesrepublik Nigeria ISO numeric: 566
    /// </summary>
    public static readonly CountryCode Nigeria = new CountryCode { Value = "NG" };

    /// <summary>
    /// die Republik Nicaragua ISO numeric: 558
    /// </summary>
    public static readonly CountryCode Nicaragua = new CountryCode { Value = "NI" };

    /// <summary>
    /// das Königreich der Niederlande ISO numeric: 528
    /// </summary>
    public static readonly CountryCode Niederlande = new CountryCode { Value = "NL" };

    /// <summary>
    /// das Königreich Norwegen ISO numeric: 578
    /// </summary>
    public static readonly CountryCode Norwegen = new CountryCode { Value = "NO" };

    /// <summary>
    /// die Demokratische Bundesrepublik Nepal ISO numeric: 524
    /// </summary>
    public static readonly CountryCode Nepal = new CountryCode { Value = "NP" };

    /// <summary>
    /// die Republik Nauru ISO numeric: 520
    /// </summary>
    public static readonly CountryCode Nauru = new CountryCode { Value = "NR" };

    /// <summary>
    /// Niue ISO numeric: 570
    /// </summary>
    public static readonly CountryCode Niue = new CountryCode { Value = "NU" };

    /// <summary>
    /// Neuseeland ISO numeric: 554
    /// </summary>
    public static readonly CountryCode Neuseeland = new CountryCode { Value = "NZ" };

    /// <summary>
    /// das Sultanat Oman ISO numeric: 512
    /// </summary>
    public static readonly CountryCode Oman = new CountryCode { Value = "OM" };

    /// <summary>
    /// die Republik Panama ISO numeric: 591
    /// </summary>
    public static readonly CountryCode Panama = new CountryCode { Value = "PA" };

    /// <summary>
    /// die Republik Peru ISO numeric: 604
    /// </summary>
    public static readonly CountryCode Peru = new CountryCode { Value = "PE" };

    /// <summary>
    /// Französisch-Polynesien ISO numeric: 258
    /// </summary>
    public static readonly CountryCode FranzosischPolynesien = new CountryCode { Value = "PF" };

    /// <summary>
    /// der Unabhängige Staat Papua-Neuguinea ISO numeric: 598
    /// </summary>
    public static readonly CountryCode PapuaNeuguinea = new CountryCode { Value = "PG" };

    /// <summary>
    /// die Republik der Philippinen ISO numeric: 608
    /// </summary>
    public static readonly CountryCode Philippinen = new CountryCode { Value = "PH" };

    /// <summary>
    /// die Islamische Republik Pakistan ISO numeric: 586
    /// </summary>
    public static readonly CountryCode Pakistan = new CountryCode { Value = "PK" };

    /// <summary>
    /// die Republik Polen ISO numeric: 616
    /// </summary>
    public static readonly CountryCode Polen = new CountryCode { Value = "PL" };

    /// <summary>
    /// St. Pierre und Miquelon ISO numeric: 666
    /// </summary>
    public static readonly CountryCode StPierreUndMiquelon = new CountryCode { Value = "PM" };

    /// <summary>
    /// Pitcairninseln ISO numeric: 612
    /// </summary>
    public static readonly CountryCode Pitcairninseln = new CountryCode { Value = "PN" };

    /// <summary>
    /// Freistaat Puerto Rico ISO numeric: 630
    /// </summary>
    public static readonly CountryCode PuertoRico = new CountryCode { Value = "PR" };

    /// <summary>
    /// Palästinensische Gebiete ISO numeric: 275 Status: In der internationalen Norm ISO 3166 wird den Länderzeichen PS und PSE der Ländername „State of Palestine“ bzw. „État de Palestine“ (auf Deutsch „Staat Palästina“) zugeordnet. Die Bundesrepublik Deutschland erkennt die Palästinensischen Gebiete nicht als Staat an.
    /// </summary>
    public static readonly CountryCode PalastinensischeGebiete = new CountryCode { Value = "PS" };

    /// <summary>
    /// die Portugiesische Republik ISO numeric: 620
    /// </summary>
    public static readonly CountryCode Portugal = new CountryCode { Value = "PT" };

    /// <summary>
    /// die Republik Palau ISO numeric: 585
    /// </summary>
    public static readonly CountryCode Palau = new CountryCode { Value = "PW" };

    /// <summary>
    /// die Republik Paraguay ISO numeric: 600
    /// </summary>
    public static readonly CountryCode Paraguay = new CountryCode { Value = "PY" };

    /// <summary>
    /// der Staat Katar ISO numeric: 634
    /// </summary>
    public static readonly CountryCode Katar = new CountryCode { Value = "QA" };

    /// <summary>
    /// Unbekannt Status: user assigned code
    /// </summary>
    public static readonly CountryCode Unbekannt = new CountryCode { Value = "QU" };

    /// <summary>
    /// Réunion ISO numeric: 638
    /// </summary>
    public static readonly CountryCode Reunion = new CountryCode { Value = "RE" };

    /// <summary>
    /// Rumänien ISO numeric: 642
    /// </summary>
    public static readonly CountryCode Rumanien = new CountryCode { Value = "RO" };

    /// <summary>
    /// die Republik Serbien ISO numeric: 688
    /// </summary>
    public static readonly CountryCode Serbien = new CountryCode { Value = "RS" };

    /// <summary>
    /// die Russische Föderation ISO numeric: 643
    /// </summary>
    public static readonly CountryCode RussischeFoderation = new CountryCode { Value = "RU" };

    /// <summary>
    /// die Republik Ruanda ISO numeric: 646
    /// </summary>
    public static readonly CountryCode Ruanda = new CountryCode { Value = "RW" };

    /// <summary>
    /// das Königreich Saudi-Arabien ISO numeric: 682
    /// </summary>
    public static readonly CountryCode SaudiArabien = new CountryCode { Value = "SA" };

    /// <summary>
    /// die Salomonen ISO numeric: 090
    /// </summary>
    public static readonly CountryCode Salomonen = new CountryCode { Value = "SB" };

    /// <summary>
    /// die Republik Seychellen ISO numeric: 690
    /// </summary>
    public static readonly CountryCode Seychellen = new CountryCode { Value = "SC" };

    /// <summary>
    /// die Republik Sudan ISO numeric: 729
    /// </summary>
    public static readonly CountryCode Sudan = new CountryCode { Value = "SD" };

    /// <summary>
    /// das Königreich Schweden ISO numeric: 752
    /// </summary>
    public static readonly CountryCode Schweden = new CountryCode { Value = "SE" };

    /// <summary>
    /// die Republik Singapur ISO numeric: 702
    /// </summary>
    public static readonly CountryCode Singapur = new CountryCode { Value = "SG" };

    /// <summary>
    /// St. Helena, Ascension und Tristan da Cunha ISO numeric: 654
    /// </summary>
    public static readonly CountryCode StHelenaAscensionUndTristanDaCunha = new CountryCode { Value = "SH" };

    /// <summary>
    /// die Republik Slowenien ISO numeric: 705
    /// </summary>
    public static readonly CountryCode Slowenien = new CountryCode { Value = "SI" };

    /// <summary>
    /// Svalbard und Jan Mayen ISO numeric: 744
    /// </summary>
    public static readonly CountryCode SvalbardUndJanMayen = new CountryCode { Value = "SJ" };

    /// <summary>
    /// die Slowakische Republik ISO numeric: 703
    /// </summary>
    public static readonly CountryCode Slowakei = new CountryCode { Value = "SK" };

    /// <summary>
    /// die Republik Sierra Leone ISO numeric: 694
    /// </summary>
    public static readonly CountryCode SierraLeone = new CountryCode { Value = "SL" };

    /// <summary>
    /// die Republik San Marino ISO numeric: 674
    /// </summary>
    public static readonly CountryCode SanMarino = new CountryCode { Value = "SM" };

    /// <summary>
    /// die Republik Senegal ISO numeric: 686
    /// </summary>
    public static readonly CountryCode Senegal = new CountryCode { Value = "SN" };

    /// <summary>
    /// die Bundesrepublik Somalia ISO numeric: 706
    /// </summary>
    public static readonly CountryCode Somalia = new CountryCode { Value = "SO" };

    /// <summary>
    /// die Republik Suriname ISO numeric: 740
    /// </summary>
    public static readonly CountryCode Suriname = new CountryCode { Value = "SR" };

    /// <summary>
    /// die Republik Südsudan ISO numeric: 728
    /// </summary>
    public static readonly CountryCode Sudsudan = new CountryCode { Value = "SS" };

    /// <summary>
    /// die Demokratische Republik São Tomé und Príncipe ISO numeric: 678
    /// </summary>
    public static readonly CountryCode SaoTomeUndPrincipe = new CountryCode { Value = "ST" };

    /// <summary>
    /// die Republik El Salvador ISO numeric: 222
    /// </summary>
    public static readonly CountryCode ElSalvador = new CountryCode { Value = "SV" };

    /// <summary>
    /// St. Martin (Niederländischer Teil) ISO numeric: 534
    /// </summary>
    public static readonly CountryCode StMartinNiederlandischerTeil = new CountryCode { Value = "SX" };

    /// <summary>
    /// die Arabische Republik Syrien ISO numeric: 760
    /// </summary>
    public static readonly CountryCode ArabischeRepublikSyrien = new CountryCode { Value = "SY" };

    /// <summary>
    /// das Königreich Eswatini ISO numeric: 748
    /// </summary>
    public static readonly CountryCode Eswatini = new CountryCode { Value = "SZ" };

    /// <summary>
    /// Turks- und Caicosinseln ISO numeric: 796
    /// </summary>
    public static readonly CountryCode TurksUndCaicosinseln = new CountryCode { Value = "TC" };

    /// <summary>
    /// die Republik Tschad ISO numeric: 148
    /// </summary>
    public static readonly CountryCode Tschad = new CountryCode { Value = "TD" };

    /// <summary>
    /// Französische Süd- und Antarktisgebiete ISO numeric: 260
    /// </summary>
    public static readonly CountryCode FranzosischeSudUndAntarktisgebiete = new CountryCode { Value = "TF" };

    /// <summary>
    /// die Republik Togo ISO numeric: 768
    /// </summary>
    public static readonly CountryCode Togo = new CountryCode { Value = "TG" };

    /// <summary>
    /// das Königreich Thailand ISO numeric: 764
    /// </summary>
    public static readonly CountryCode Thailand = new CountryCode { Value = "TH" };

    /// <summary>
    /// die Republik Tadschikistan ISO numeric: 762
    /// </summary>
    public static readonly CountryCode Tadschikistan = new CountryCode { Value = "TJ" };

    /// <summary>
    /// Tokelau ISO numeric: 772
    /// </summary>
    public static readonly CountryCode Tokelau = new CountryCode { Value = "TK" };

    /// <summary>
    /// die Demokratische Republik Timor-Leste ISO numeric: 626
    /// </summary>
    public static readonly CountryCode TimorLeste = new CountryCode { Value = "TL" };

    /// <summary>
    /// Turkmenistan ISO numeric: 795
    /// </summary>
    public static readonly CountryCode Turkmenistan = new CountryCode { Value = "TM" };

    /// <summary>
    /// die Tunesische Republik ISO numeric: 788
    /// </summary>
    public static readonly CountryCode Tunesien = new CountryCode { Value = "TN" };

    /// <summary>
    /// das Königreich Tonga ISO numeric: 776
    /// </summary>
    public static readonly CountryCode Tonga = new CountryCode { Value = "TO" };

    /// <summary>
    /// die Republik Türkei ISO numeric: 792
    /// </summary>
    public static readonly CountryCode Turkei = new CountryCode { Value = "TR" };

    /// <summary>
    /// die Republik Trinidad und Tobago ISO numeric: 780
    /// </summary>
    public static readonly CountryCode TrinidadUndTobago = new CountryCode { Value = "TT" };

    /// <summary>
    /// Tuvalu ISO numeric: 798
    /// </summary>
    public static readonly CountryCode Tuvalu = new CountryCode { Value = "TV" };

    /// <summary>
    /// Taiwan ISO numeric: 158
    /// </summary>
    public static readonly CountryCode Taiwan = new CountryCode { Value = "TW" };

    /// <summary>
    /// die Vereinigte Republik Tansania ISO numeric: 834
    /// </summary>
    public static readonly CountryCode VereinigteRepublikTansania = new CountryCode { Value = "TZ" };

    /// <summary>
    /// die Ukraine ISO numeric: 804
    /// </summary>
    public static readonly CountryCode Ukraine = new CountryCode { Value = "UA" };

    /// <summary>
    /// die Republik Uganda ISO numeric: 800
    /// </summary>
    public static readonly CountryCode Uganda = new CountryCode { Value = "UG" };

    /// <summary>
    /// Kleinere amerikanische Überseeinseln ISO numeric: 581
    /// </summary>
    public static readonly CountryCode AmerikanischeUberseeinselnKleinere = new CountryCode { Value = "UM" };

    /// <summary>
    /// die Vereinigten Staaten von Amerika ISO numeric: 840
    /// </summary>
    public static readonly CountryCode VereinigteStaaten = new CountryCode { Value = "US" };

    /// <summary>
    /// die Republik Östlich des Uruguay ISO numeric: 858
    /// </summary>
    public static readonly CountryCode Uruguay = new CountryCode { Value = "UY" };

    /// <summary>
    /// die Republik Usbekistan ISO numeric: 860
    /// </summary>
    public static readonly CountryCode Usbekistan = new CountryCode { Value = "UZ" };

    /// <summary>
    /// der Staat Vatikanstadt ISO numeric: 336
    /// </summary>
    public static readonly CountryCode Vatikanstadt = new CountryCode { Value = "VA" };

    /// <summary>
    /// St. Vincent und die Grenadinen ISO numeric: 670
    /// </summary>
    public static readonly CountryCode StVincentUndDieGrenadinen = new CountryCode { Value = "VC" };

    /// <summary>
    /// die Bolivarische Republik Venezuela ISO numeric: 862
    /// </summary>
    public static readonly CountryCode BolivarischeRepublikVenezuela = new CountryCode { Value = "VE" };

    /// <summary>
    /// Britische Jungferninseln ISO numeric: 092
    /// </summary>
    public static readonly CountryCode BritischeJungferninseln = new CountryCode { Value = "VG" };

    /// <summary>
    /// Amerikanische Jungferninseln ISO numeric: 850
    /// </summary>
    public static readonly CountryCode AmerikanischeJungferninseln = new CountryCode { Value = "VI" };

    /// <summary>
    /// die Sozialistische Republik Vietnam ISO numeric: 704
    /// </summary>
    public static readonly CountryCode Vietnam = new CountryCode { Value = "VN" };

    /// <summary>
    /// die Republik Vanuatu ISO numeric: 548
    /// </summary>
    public static readonly CountryCode Vanuatu = new CountryCode { Value = "VU" };

    /// <summary>
    /// Wallis und Futuna ISO numeric: 876
    /// </summary>
    public static readonly CountryCode WallisUndFutuna = new CountryCode { Value = "WF" };

    /// <summary>
    /// der Unabhängige Staat Samoa ISO numeric: 882
    /// </summary>
    public static readonly CountryCode Samoa = new CountryCode { Value = "WS" };

    /// <summary>
    /// die Republik Kosovo  Status: user assigned code
    /// </summary>
    public static readonly CountryCode Kosovo = new CountryCode { Value = "XK" };

    /// <summary>
    /// die Republik Jemen ISO numeric: 887
    /// </summary>
    public static readonly CountryCode Jemen = new CountryCode { Value = "YE" };

    /// <summary>
    /// Mayotte ISO numeric: 175
    /// </summary>
    public static readonly CountryCode Mayotte = new CountryCode { Value = "YT" };

    /// <summary>
    /// die Republik Südafrika ISO numeric: 710
    /// </summary>
    public static readonly CountryCode Sudafrika = new CountryCode { Value = "ZA" };

    /// <summary>
    /// die Republik Sambia ISO numeric: 894
    /// </summary>
    public static readonly CountryCode Sambia = new CountryCode { Value = "ZM" };

    /// <summary>
    /// die Republik Simbabwe ISO numeric: 716
    /// </summary>
    public static readonly CountryCode Simbabwe = new CountryCode { Value = "ZW" };
}
