namespace XRechnung;

/// <summary>
/// Codes for the representation of names of countries and their subdivisions
/// <br /><br />
/// Die Codeliste basiert auf der Staats- und Gebietssystematik des Statistischen Bundesamtes (DESTATIS) und dem Standard "Country codes" der International Organization for Standardization (ISO). Die vorliegende Liste verwendet die "officially assigned codes" (Alpha-2 und Numerisch) der ISO-Liste sowie die "user assigned codes" für Kosovo ("XK") und Unbekannt ("QU"). Kurz- und Langnamen der aufgeführten Einträge wurden, sofern vorhanden, der DESTATIS-Liste entnommen. Zu den nicht in der DESTATIS-Liste geführten Codeeinträgen wurden die zugehörigen Namen der Deutschen Fassung der Norm entnommen. Die Codeliste ist konform zur EN16931-1 und dem darauf basierenden Standard XRechnung sowie zum Standard XBestellung und der zugrundeliegenden Peppol "BIS Order only" Spezifikation.
/// <br /><br />
/// https://www.xrepository.de/details/urn:xoev-de:kosit:codeliste:country-codes_8
/// </summary>
public record class CountryCode : Code
{
    /// <summary>
    /// das Fürstentum Andorra ISO numeric: 020
    /// </summary>
    public static CountryCode Andorra => new() { Value = "AD" };

    /// <summary>
    /// die Vereinigten Arabischen Emirate (Abu Dhabi, Adschman, Dubai, Fudschaira, Ras al Chaima, Schardscha, Umm al Kaiwain) ISO numeric: 784
    /// </summary>
    public static CountryCode VereinigteArabischeEmirate => new() { Value = "AE" };

    /// <summary>
    /// die Islamische Republik Afghanistan ISO numeric: 004
    /// </summary>
    public static CountryCode Afghanistan => new() { Value = "AF" };

    /// <summary>
    /// Antigua und Barbuda ISO numeric: 028
    /// </summary>
    public static CountryCode AntiguaUndBarbuda => new() { Value = "AG" };

    /// <summary>
    /// Anguilla ISO numeric: 660
    /// </summary>
    public static CountryCode Anguilla => new() { Value = "AI" };

    /// <summary>
    /// die Republik Albanien ISO numeric: 008
    /// </summary>
    public static CountryCode Albanien => new() { Value = "AL" };

    /// <summary>
    /// die Republik Armenien ISO numeric: 051
    /// </summary>
    public static CountryCode Armenien => new() { Value = "AM" };

    /// <summary>
    /// die Republik Angola ISO numeric: 024
    /// </summary>
    public static CountryCode Angola => new() { Value = "AO" };

    /// <summary>
    /// Antarktis ISO numeric: 010
    /// </summary>
    public static CountryCode Antarktis => new() { Value = "AQ" };

    /// <summary>
    /// die Argentinische Republik ISO numeric: 032
    /// </summary>
    public static CountryCode Argentinien => new() { Value = "AR" };

    /// <summary>
    /// Amerikanisch-Samoa ISO numeric: 016
    /// </summary>
    public static CountryCode AmerikanischSamoa => new() { Value = "AS" };

    /// <summary>
    /// die Republik Österreich ISO numeric: 040
    /// </summary>
    public static CountryCode Osterreich => new() { Value = "AT" };

    /// <summary>
    /// Australien ISO numeric: 036
    /// </summary>
    public static CountryCode Australien => new() { Value = "AU" };

    /// <summary>
    /// Aruba ISO numeric: 533
    /// </summary>
    public static CountryCode Aruba => new() { Value = "AW" };

    /// <summary>
    /// Ålandinseln ISO numeric: 248
    /// </summary>
    public static CountryCode Alandinseln => new() { Value = "AX" };

    /// <summary>
    /// die Republik Aserbaidschan ISO numeric: 031
    /// </summary>
    public static CountryCode Aserbaidschan => new() { Value = "AZ" };

    /// <summary>
    /// Bosnien und Herzegowina ISO numeric: 070
    /// </summary>
    public static CountryCode BosnienUndHerzegowina => new() { Value = "BA" };

    /// <summary>
    /// Barbados ISO numeric: 052
    /// </summary>
    public static CountryCode Barbados => new() { Value = "BB" };

    /// <summary>
    /// die Volksrepublik Bangladesch ISO numeric: 050
    /// </summary>
    public static CountryCode Bangladesch => new() { Value = "BD" };

    /// <summary>
    /// das Königreich Belgien ISO numeric: 056
    /// </summary>
    public static CountryCode Belgien => new() { Value = "BE" };

    /// <summary>
    /// Burkina Faso ISO numeric: 854
    /// </summary>
    public static CountryCode BurkinaFaso => new() { Value = "BF" };

    /// <summary>
    /// die Republik Bulgarien ISO numeric: 100
    /// </summary>
    public static CountryCode Bulgarien => new() { Value = "BG" };

    /// <summary>
    /// das Königreich Bahrain ISO numeric: 048
    /// </summary>
    public static CountryCode Bahrain => new() { Value = "BH" };

    /// <summary>
    /// die Republik Burundi ISO numeric: 108
    /// </summary>
    public static CountryCode Burundi => new() { Value = "BI" };

    /// <summary>
    /// die Republik Benin ISO numeric: 204
    /// </summary>
    public static CountryCode Benin => new() { Value = "BJ" };

    /// <summary>
    /// St. Barthélemy ISO numeric: 652
    /// </summary>
    public static CountryCode StBarthelemy => new() { Value = "BL" };

    /// <summary>
    /// Bermuda ISO numeric: 060
    /// </summary>
    public static CountryCode Bermuda => new() { Value = "BM" };

    /// <summary>
    /// Brunei Darussalam ISO numeric: 096
    /// </summary>
    public static CountryCode BruneiDarussalam => new() { Value = "BN" };

    /// <summary>
    /// der Plurinationale Staat Bolivien ISO numeric: 068
    /// </summary>
    public static CountryCode PlurinationalerStaatBolivien => new() { Value = "BO" };

    /// <summary>
    /// Bonaire, St. Eustatius und Saba ISO numeric: 535
    /// </summary>
    public static CountryCode BonaireStEustatiusUndSaba => new() { Value = "BQ" };

    /// <summary>
    /// die Föderative Republik Brasilien ISO numeric: 076
    /// </summary>
    public static CountryCode Brasilien => new() { Value = "BR" };

    /// <summary>
    /// das Commonwealth der Bahamas ISO numeric: 044
    /// </summary>
    public static CountryCode Bahamas => new() { Value = "BS" };

    /// <summary>
    /// das Königreich Bhutan ISO numeric: 064
    /// </summary>
    public static CountryCode Bhutan => new() { Value = "BT" };

    /// <summary>
    /// Bouvetinsel ISO numeric: 074
    /// </summary>
    public static CountryCode Bouvetinsel => new() { Value = "BV" };

    /// <summary>
    /// die Republik Botsuana ISO numeric: 072
    /// </summary>
    public static CountryCode Botsuana => new() { Value = "BW" };

    /// <summary>
    /// die Republik Belarus ISO numeric: 112
    /// </summary>
    public static CountryCode Belarus => new() { Value = "BY" };

    /// <summary>
    /// Belize ISO numeric: 084
    /// </summary>
    public static CountryCode Belize => new() { Value = "BZ" };

    /// <summary>
    /// Kanada ISO numeric: 124
    /// </summary>
    public static CountryCode Kanada => new() { Value = "CA" };

    /// <summary>
    /// Kokosinseln (Keeling) ISO numeric: 166
    /// </summary>
    public static CountryCode KokosinselnKeeling => new() { Value = "CC" };

    /// <summary>
    /// die Demokratische Republik Kongo ISO numeric: 180
    /// </summary>
    public static CountryCode DemokratischeRepublikKongo => new() { Value = "CD" };

    /// <summary>
    /// die Zentralafrikanische Republik ISO numeric: 140
    /// </summary>
    public static CountryCode ZentralafrikanischeRepublik => new() { Value = "CF" };

    /// <summary>
    /// die Republik Kongo ISO numeric: 178
    /// </summary>
    public static CountryCode Kongo => new() { Value = "CG" };

    /// <summary>
    /// die Schweizerische Eidgenossenschaft ISO numeric: 756
    /// </summary>
    public static CountryCode Schweiz => new() { Value = "CH" };

    /// <summary>
    /// die Republik Côte d’Ivoire ISO numeric: 384
    /// </summary>
    public static CountryCode CoteDIvoire => new() { Value = "CI" };

    /// <summary>
    /// die Cookinseln ISO numeric: 184
    /// </summary>
    public static CountryCode Cookinseln => new() { Value = "CK" };

    /// <summary>
    /// die Republik Chile ISO numeric: 152
    /// </summary>
    public static CountryCode Chile => new() { Value = "CL" };

    /// <summary>
    /// die Republik Kamerun ISO numeric: 120
    /// </summary>
    public static CountryCode Kamerun => new() { Value = "CM" };

    /// <summary>
    /// die Volksrepublik China ISO numeric: 156
    /// </summary>
    public static CountryCode China => new() { Value = "CN" };

    /// <summary>
    /// die Republik Kolumbien ISO numeric: 170
    /// </summary>
    public static CountryCode Kolumbien => new() { Value = "CO" };

    /// <summary>
    /// die Republik Costa Rica ISO numeric: 188
    /// </summary>
    public static CountryCode CostaRica => new() { Value = "CR" };

    /// <summary>
    /// die Republik Kuba ISO numeric: 192
    /// </summary>
    public static CountryCode Kuba => new() { Value = "CU" };

    /// <summary>
    /// die Republik Cabo Verde ISO numeric: 132
    /// </summary>
    public static CountryCode CaboVerde => new() { Value = "CV" };

    /// <summary>
    /// Curaçao ISO numeric: 531
    /// </summary>
    public static CountryCode Curacao => new() { Value = "CW" };

    /// <summary>
    /// Territorium Weihnachtsinsel ISO numeric: 162
    /// </summary>
    public static CountryCode Weihnachtsinsel => new() { Value = "CX" };

    /// <summary>
    /// die Republik Zypern ISO numeric: 196
    /// </summary>
    public static CountryCode Zypern => new() { Value = "CY" };

    /// <summary>
    /// die Tschechische Republik ISO numeric: 203
    /// </summary>
    public static CountryCode Tschechien => new() { Value = "CZ" };

    /// <summary>
    /// die Bundesrepublik Deutschland ISO numeric: 276
    /// </summary>
    public static CountryCode Deutschland => new() { Value = "DE" };

    /// <summary>
    /// die Republik Dschibuti ISO numeric: 262
    /// </summary>
    public static CountryCode Dschibuti => new() { Value = "DJ" };

    /// <summary>
    /// das Königreich Dänemark ISO numeric: 208
    /// </summary>
    public static CountryCode Danemark => new() { Value = "DK" };

    /// <summary>
    /// das Commonwealth Dominica ISO numeric: 212
    /// </summary>
    public static CountryCode Dominica => new() { Value = "DM" };

    /// <summary>
    /// die Dominikanische Republik ISO numeric: 214
    /// </summary>
    public static CountryCode DominikanischeRepublik => new() { Value = "DO" };

    /// <summary>
    /// die Demokratische Volksrepublik Algerien ISO numeric: 012
    /// </summary>
    public static CountryCode Algerien => new() { Value = "DZ" };

    /// <summary>
    /// die Republik Ecuador ISO numeric: 218
    /// </summary>
    public static CountryCode Ecuador => new() { Value = "EC" };

    /// <summary>
    /// die Republik Estland ISO numeric: 233
    /// </summary>
    public static CountryCode Estland => new() { Value = "EE" };

    /// <summary>
    /// die Arabische Republik Ägypten ISO numeric: 818
    /// </summary>
    public static CountryCode Agypten => new() { Value = "EG" };

    /// <summary>
    /// Westsahara ISO numeric: 732
    /// </summary>
    public static CountryCode Westsahara => new() { Value = "EH" };

    /// <summary>
    /// der Staat Eritrea ISO numeric: 232
    /// </summary>
    public static CountryCode Eritrea => new() { Value = "ER" };

    /// <summary>
    /// das Königreich Spanien ISO numeric: 724
    /// </summary>
    public static CountryCode Spanien => new() { Value = "ES" };

    /// <summary>
    /// die Demokratische Bundesrepublik Äthiopien ISO numeric: 231
    /// </summary>
    public static CountryCode Athiopien => new() { Value = "ET" };

    /// <summary>
    /// die Republik Finnland ISO numeric: 246
    /// </summary>
    public static CountryCode Finnland => new() { Value = "FI" };

    /// <summary>
    /// die Republik Fidschi ISO numeric: 242
    /// </summary>
    public static CountryCode Fidschi => new() { Value = "FJ" };

    /// <summary>
    /// Falklandinseln (Malwinen) ISO numeric: 238
    /// </summary>
    public static CountryCode FalklandinselnMalwinen => new() { Value = "FK" };

    /// <summary>
    /// die Föderierten Staaten von Mikronesien ISO numeric: 583
    /// </summary>
    public static CountryCode FoderierteStaatenVonMikronesien => new() { Value = "FM" };

    /// <summary>
    /// Färöer ISO numeric: 234
    /// </summary>
    public static CountryCode Faroer => new() { Value = "FO" };

    /// <summary>
    /// die Französische Republik ISO numeric: 250
    /// </summary>
    public static CountryCode Frankreich => new() { Value = "FR" };

    /// <summary>
    /// die Gabunische Republik ISO numeric: 266
    /// </summary>
    public static CountryCode Gabun => new() { Value = "GA" };

    /// <summary>
    /// das Vereinigte Königreich Großbritannien und Nordirland ISO numeric: 826
    /// </summary>
    public static CountryCode VereinigtesKonigreich => new() { Value = "GB" };

    /// <summary>
    /// Grenada ISO numeric: 308
    /// </summary>
    public static CountryCode Grenada => new() { Value = "GD" };

    /// <summary>
    /// Georgien ISO numeric: 268
    /// </summary>
    public static CountryCode Georgien => new() { Value = "GE" };

    /// <summary>
    /// Französisch-Guayana ISO numeric: 254
    /// </summary>
    public static CountryCode FranzosischGuayana => new() { Value = "GF" };

    /// <summary>
    /// Guernsey ISO numeric: 831
    /// </summary>
    public static CountryCode Guernsey => new() { Value = "GG" };

    /// <summary>
    /// die Republik Ghana ISO numeric: 288
    /// </summary>
    public static CountryCode Ghana => new() { Value = "GH" };

    /// <summary>
    /// Gibraltar ISO numeric: 292
    /// </summary>
    public static CountryCode Gibraltar => new() { Value = "GI" };

    /// <summary>
    /// Grönland ISO numeric: 304
    /// </summary>
    public static CountryCode Gronland => new() { Value = "GL" };

    /// <summary>
    /// die Republik Gambia ISO numeric: 270
    /// </summary>
    public static CountryCode Gambia => new() { Value = "GM" };

    /// <summary>
    /// die Republik Guinea ISO numeric: 324
    /// </summary>
    public static CountryCode Guinea => new() { Value = "GN" };

    /// <summary>
    /// Guadeloupe ISO numeric: 312
    /// </summary>
    public static CountryCode Guadeloupe => new() { Value = "GP" };

    /// <summary>
    /// die Republik Äquatorialguinea ISO numeric: 226
    /// </summary>
    public static CountryCode Aquatorialguinea => new() { Value = "GQ" };

    /// <summary>
    /// die Hellenische Republik ISO numeric: 300
    /// </summary>
    public static CountryCode Griechenland => new() { Value = "GR" };

    /// <summary>
    /// Südgeorgien und die Südlichen Sandwichinseln ISO numeric: 239
    /// </summary>
    public static CountryCode SudgeorgienUndDieSudlichenSandwichinseln => new() { Value = "GS" };

    /// <summary>
    /// die Republik Guatemala ISO numeric: 320
    /// </summary>
    public static CountryCode Guatemala => new() { Value = "GT" };

    /// <summary>
    /// Guam ISO numeric: 316
    /// </summary>
    public static CountryCode Guam => new() { Value = "GU" };

    /// <summary>
    /// die Republik Guinea-Bissau ISO numeric: 624
    /// </summary>
    public static CountryCode GuineaBissau => new() { Value = "GW" };

    /// <summary>
    /// die Kooperative Republik Guyana ISO numeric: 328
    /// </summary>
    public static CountryCode Guyana => new() { Value = "GY" };

    /// <summary>
    /// die Sonderverwaltungsregion Hongkong ISO numeric: 344
    /// </summary>
    public static CountryCode Hongkong => new() { Value = "HK" };

    /// <summary>
    /// Territorium Heard und die McDonaldinseln ISO numeric: 334
    /// </summary>
    public static CountryCode HeardUndDieMcDonaldinseln => new() { Value = "HM" };

    /// <summary>
    /// die Republik Honduras ISO numeric: 340
    /// </summary>
    public static CountryCode Honduras => new() { Value = "HN" };

    /// <summary>
    /// die Republik Kroatien ISO numeric: 191
    /// </summary>
    public static CountryCode Kroatien => new() { Value = "HR" };

    /// <summary>
    /// die Republik Haiti ISO numeric: 332
    /// </summary>
    public static CountryCode Haiti => new() { Value = "HT" };

    /// <summary>
    /// Ungarn ISO numeric: 348
    /// </summary>
    public static CountryCode Ungarn => new() { Value = "HU" };

    /// <summary>
    /// die Republik Indonesien ISO numeric: 360
    /// </summary>
    public static CountryCode Indonesien => new() { Value = "ID" };

    /// <summary>
    /// Irland ISO numeric: 372
    /// </summary>
    public static CountryCode Irland => new() { Value = "IE" };

    /// <summary>
    /// der Staat Israel ISO numeric: 376
    /// </summary>
    public static CountryCode Israel => new() { Value = "IL" };

    /// <summary>
    /// Insel Man ISO numeric: 833
    /// </summary>
    public static CountryCode InselMan => new() { Value = "IM" };

    /// <summary>
    /// die Republik Indien ISO numeric: 356
    /// </summary>
    public static CountryCode Indien => new() { Value = "IN" };

    /// <summary>
    /// Britisches Territorium im Indischen Ozean ISO numeric: 086
    /// </summary>
    public static CountryCode BritischesTerritoriumImIndischenOzean => new() { Value = "IO" };

    /// <summary>
    /// die Republik Irak ISO numeric: 368
    /// </summary>
    public static CountryCode Irak => new() { Value = "IQ" };

    /// <summary>
    /// die Islamische Republik Iran ISO numeric: 364
    /// </summary>
    public static CountryCode IslamischeRepublikIran => new() { Value = "IR" };

    /// <summary>
    /// die Republik Island ISO numeric: 352
    /// </summary>
    public static CountryCode Island => new() { Value = "IS" };

    /// <summary>
    /// die Italienische Republik ISO numeric: 380
    /// </summary>
    public static CountryCode Italien => new() { Value = "IT" };

    /// <summary>
    /// Jersey ISO numeric: 832
    /// </summary>
    public static CountryCode Jersey => new() { Value = "JE" };

    /// <summary>
    /// Jamaika ISO numeric: 388
    /// </summary>
    public static CountryCode Jamaika => new() { Value = "JM" };

    /// <summary>
    /// das Haschemitische Königreich Jordanien ISO numeric: 400
    /// </summary>
    public static CountryCode Jordanien => new() { Value = "JO" };

    /// <summary>
    /// Japan ISO numeric: 392
    /// </summary>
    public static CountryCode Japan => new() { Value = "JP" };

    /// <summary>
    /// die Republik Kenia ISO numeric: 404
    /// </summary>
    public static CountryCode Kenia => new() { Value = "KE" };

    /// <summary>
    /// die Kirgisische Republik ISO numeric: 417
    /// </summary>
    public static CountryCode Kirgisistan => new() { Value = "KG" };

    /// <summary>
    /// das Königreich Kambodscha ISO numeric: 116
    /// </summary>
    public static CountryCode Kambodscha => new() { Value = "KH" };

    /// <summary>
    /// die Republik Kiribati ISO numeric: 296
    /// </summary>
    public static CountryCode Kiribati => new() { Value = "KI" };

    /// <summary>
    /// die Union der Komoren ISO numeric: 174
    /// </summary>
    public static CountryCode Komoren => new() { Value = "KM" };

    /// <summary>
    /// die Föderation St. Kitts und Nevis ISO numeric: 659
    /// </summary>
    public static CountryCode StKittsUndNevis => new() { Value = "KN" };

    /// <summary>
    /// die Demokratische Volksrepublik Korea ISO numeric: 408
    /// </summary>
    public static CountryCode DemokratischeVolksrepublikKorea => new() { Value = "KP" };

    /// <summary>
    /// die Republik Korea ISO numeric: 410
    /// </summary>
    public static CountryCode RepublikKorea => new() { Value = "KR" };

    /// <summary>
    /// der Staat Kuwait ISO numeric: 414
    /// </summary>
    public static CountryCode Kuwait => new() { Value = "KW" };

    /// <summary>
    /// Kaimaninseln ISO numeric: 136
    /// </summary>
    public static CountryCode Kaimaninseln => new() { Value = "KY" };

    /// <summary>
    /// die Republik Kasachstan ISO numeric: 398
    /// </summary>
    public static CountryCode Kasachstan => new() { Value = "KZ" };

    /// <summary>
    /// die Demokratische Volksrepublik Laos ISO numeric: 418
    /// </summary>
    public static CountryCode DemokratischeVolksrepublikLaos => new() { Value = "LA" };

    /// <summary>
    /// die Libanesische Republik ISO numeric: 422
    /// </summary>
    public static CountryCode Libanon => new() { Value = "LB" };

    /// <summary>
    /// St. Lucia ISO numeric: 662
    /// </summary>
    public static CountryCode StLucia => new() { Value = "LC" };

    /// <summary>
    /// das Fürstentum Liechtenstein ISO numeric: 438
    /// </summary>
    public static CountryCode Liechtenstein => new() { Value = "LI" };

    /// <summary>
    /// die Demokratische Sozialistische Republik Sri Lanka ISO numeric: 144
    /// </summary>
    public static CountryCode SriLanka => new() { Value = "LK" };

    /// <summary>
    /// die Republik Liberia ISO numeric: 430
    /// </summary>
    public static CountryCode Liberia => new() { Value = "LR" };

    /// <summary>
    /// das Königreich Lesotho ISO numeric: 426
    /// </summary>
    public static CountryCode Lesotho => new() { Value = "LS" };

    /// <summary>
    /// die Republik Litauen ISO numeric: 440
    /// </summary>
    public static CountryCode Litauen => new() { Value = "LT" };

    /// <summary>
    /// das Großherzogtum Luxemburg ISO numeric: 442
    /// </summary>
    public static CountryCode Luxemburg => new() { Value = "LU" };

    /// <summary>
    /// die Republik Lettland ISO numeric: 428
    /// </summary>
    public static CountryCode Lettland => new() { Value = "LV" };

    /// <summary>
    /// der Staat Libyen ISO numeric: 434
    /// </summary>
    public static CountryCode Libyen => new() { Value = "LY" };

    /// <summary>
    /// das Königreich Marokko ISO numeric: 504
    /// </summary>
    public static CountryCode Marokko => new() { Value = "MA" };

    /// <summary>
    /// das Fürstentum Monaco ISO numeric: 492
    /// </summary>
    public static CountryCode Monaco => new() { Value = "MC" };

    /// <summary>
    /// die Republik Moldau ISO numeric: 498
    /// </summary>
    public static CountryCode RepublikMoldau => new() { Value = "MD" };

    /// <summary>
    /// Montenegro ISO numeric: 499
    /// </summary>
    public static CountryCode Montenegro => new() { Value = "ME" };

    /// <summary>
    /// St. Martin (französischer Teil) ISO numeric: 663
    /// </summary>
    public static CountryCode StMartinFranzosischerTeil => new() { Value = "MF" };

    /// <summary>
    /// die Republik Madagaskar ISO numeric: 450
    /// </summary>
    public static CountryCode Madagaskar => new() { Value = "MG" };

    /// <summary>
    /// die Republik Marshallinseln ISO numeric: 584
    /// </summary>
    public static CountryCode Marshallinseln => new() { Value = "MH" };

    /// <summary>
    /// die Republik Nordmazedonien ISO numeric: 807
    /// </summary>
    public static CountryCode Nordmazedonien => new() { Value = "MK" };

    /// <summary>
    /// die Republik Mali ISO numeric: 466
    /// </summary>
    public static CountryCode Mali => new() { Value = "ML" };

    /// <summary>
    /// die Republik der Union Myanmar ISO numeric: 104
    /// </summary>
    public static CountryCode Myanmar => new() { Value = "MM" };

    /// <summary>
    /// die Mongolei ISO numeric: 496
    /// </summary>
    public static CountryCode Mongolei => new() { Value = "MN" };

    /// <summary>
    /// die Sonderverwaltungsregion Macau ISO numeric: 446
    /// </summary>
    public static CountryCode Macau => new() { Value = "MO" };

    /// <summary>
    /// Commonwealth der Nördlichen Marianen ISO numeric: 580
    /// </summary>
    public static CountryCode MarianenNordliche => new() { Value = "MP" };

    /// <summary>
    /// Martinique ISO numeric: 474
    /// </summary>
    public static CountryCode Martinique => new() { Value = "MQ" };

    /// <summary>
    /// die Islamische Republik Mauretanien ISO numeric: 478
    /// </summary>
    public static CountryCode Mauretanien => new() { Value = "MR" };

    /// <summary>
    /// Montserrat ISO numeric: 500
    /// </summary>
    public static CountryCode Montserrat => new() { Value = "MS" };

    /// <summary>
    /// die Republik Malta ISO numeric: 470
    /// </summary>
    public static CountryCode Malta => new() { Value = "MT" };

    /// <summary>
    /// die Republik Mauritius ISO numeric: 480
    /// </summary>
    public static CountryCode Mauritius => new() { Value = "MU" };

    /// <summary>
    /// die Republik Malediven ISO numeric: 462
    /// </summary>
    public static CountryCode Malediven => new() { Value = "MV" };

    /// <summary>
    /// die Republik Malawi ISO numeric: 454
    /// </summary>
    public static CountryCode Malawi => new() { Value = "MW" };

    /// <summary>
    /// die Vereinigten Mexikanischen Staaten ISO numeric: 484
    /// </summary>
    public static CountryCode Mexiko => new() { Value = "MX" };

    /// <summary>
    /// Malaysia ISO numeric: 458
    /// </summary>
    public static CountryCode Malaysia => new() { Value = "MY" };

    /// <summary>
    /// die Republik Mosambik ISO numeric: 508
    /// </summary>
    public static CountryCode Mosambik => new() { Value = "MZ" };

    /// <summary>
    /// die Republik Namibia ISO numeric: 516
    /// </summary>
    public static CountryCode Namibia => new() { Value = "NA" };

    /// <summary>
    /// Neukaledonien ISO numeric: 540
    /// </summary>
    public static CountryCode Neukaledonien => new() { Value = "NC" };

    /// <summary>
    /// die Republik Niger ISO numeric: 562
    /// </summary>
    public static CountryCode Niger => new() { Value = "NE" };

    /// <summary>
    /// Norfolkinsel ISO numeric: 574
    /// </summary>
    public static CountryCode Norfolkinsel => new() { Value = "NF" };

    /// <summary>
    /// die Bundesrepublik Nigeria ISO numeric: 566
    /// </summary>
    public static CountryCode Nigeria => new() { Value = "NG" };

    /// <summary>
    /// die Republik Nicaragua ISO numeric: 558
    /// </summary>
    public static CountryCode Nicaragua => new() { Value = "NI" };

    /// <summary>
    /// das Königreich der Niederlande ISO numeric: 528
    /// </summary>
    public static CountryCode Niederlande => new() { Value = "NL" };

    /// <summary>
    /// das Königreich Norwegen ISO numeric: 578
    /// </summary>
    public static CountryCode Norwegen => new() { Value = "NO" };

    /// <summary>
    /// die Demokratische Bundesrepublik Nepal ISO numeric: 524
    /// </summary>
    public static CountryCode Nepal => new() { Value = "NP" };

    /// <summary>
    /// die Republik Nauru ISO numeric: 520
    /// </summary>
    public static CountryCode Nauru => new() { Value = "NR" };

    /// <summary>
    /// Niue ISO numeric: 570
    /// </summary>
    public static CountryCode Niue => new() { Value = "NU" };

    /// <summary>
    /// Neuseeland ISO numeric: 554
    /// </summary>
    public static CountryCode Neuseeland => new() { Value = "NZ" };

    /// <summary>
    /// das Sultanat Oman ISO numeric: 512
    /// </summary>
    public static CountryCode Oman => new() { Value = "OM" };

    /// <summary>
    /// die Republik Panama ISO numeric: 591
    /// </summary>
    public static CountryCode Panama => new() { Value = "PA" };

    /// <summary>
    /// die Republik Peru ISO numeric: 604
    /// </summary>
    public static CountryCode Peru => new() { Value = "PE" };

    /// <summary>
    /// Französisch-Polynesien ISO numeric: 258
    /// </summary>
    public static CountryCode FranzosischPolynesien => new() { Value = "PF" };

    /// <summary>
    /// der Unabhängige Staat Papua-Neuguinea ISO numeric: 598
    /// </summary>
    public static CountryCode PapuaNeuguinea => new() { Value = "PG" };

    /// <summary>
    /// die Republik der Philippinen ISO numeric: 608
    /// </summary>
    public static CountryCode Philippinen => new() { Value = "PH" };

    /// <summary>
    /// die Islamische Republik Pakistan ISO numeric: 586
    /// </summary>
    public static CountryCode Pakistan => new() { Value = "PK" };

    /// <summary>
    /// die Republik Polen ISO numeric: 616
    /// </summary>
    public static CountryCode Polen => new() { Value = "PL" };

    /// <summary>
    /// St. Pierre und Miquelon ISO numeric: 666
    /// </summary>
    public static CountryCode StPierreUndMiquelon => new() { Value = "PM" };

    /// <summary>
    /// Pitcairninseln ISO numeric: 612
    /// </summary>
    public static CountryCode Pitcairninseln => new() { Value = "PN" };

    /// <summary>
    /// Freistaat Puerto Rico ISO numeric: 630
    /// </summary>
    public static CountryCode PuertoRico => new() { Value = "PR" };

    /// <summary>
    /// Palästinensische Gebiete ISO numeric: 275 Status: In der internationalen Norm ISO 3166 wird den Länderzeichen PS und PSE der Ländername „State of Palestine“ bzw. „État de Palestine“ (auf Deutsch „Staat Palästina“) zugeordnet. Die Bundesrepublik Deutschland erkennt die Palästinensischen Gebiete nicht als Staat an.
    /// </summary>
    public static CountryCode PalastinensischeGebiete => new() { Value = "PS" };

    /// <summary>
    /// die Portugiesische Republik ISO numeric: 620
    /// </summary>
    public static CountryCode Portugal => new() { Value = "PT" };

    /// <summary>
    /// die Republik Palau ISO numeric: 585
    /// </summary>
    public static CountryCode Palau => new() { Value = "PW" };

    /// <summary>
    /// die Republik Paraguay ISO numeric: 600
    /// </summary>
    public static CountryCode Paraguay => new() { Value = "PY" };

    /// <summary>
    /// der Staat Katar ISO numeric: 634
    /// </summary>
    public static CountryCode Katar => new() { Value = "QA" };

    /// <summary>
    /// Unbekannt Status: user assigned code
    /// </summary>
    public static CountryCode Unbekannt => new() { Value = "QU" };

    /// <summary>
    /// Réunion ISO numeric: 638
    /// </summary>
    public static CountryCode Reunion => new() { Value = "RE" };

    /// <summary>
    /// Rumänien ISO numeric: 642
    /// </summary>
    public static CountryCode Rumanien => new() { Value = "RO" };

    /// <summary>
    /// die Republik Serbien ISO numeric: 688
    /// </summary>
    public static CountryCode Serbien => new() { Value = "RS" };

    /// <summary>
    /// die Russische Föderation ISO numeric: 643
    /// </summary>
    public static CountryCode RussischeFoderation => new() { Value = "RU" };

    /// <summary>
    /// die Republik Ruanda ISO numeric: 646
    /// </summary>
    public static CountryCode Ruanda => new() { Value = "RW" };

    /// <summary>
    /// das Königreich Saudi-Arabien ISO numeric: 682
    /// </summary>
    public static CountryCode SaudiArabien => new() { Value = "SA" };

    /// <summary>
    /// die Salomonen ISO numeric: 090
    /// </summary>
    public static CountryCode Salomonen => new() { Value = "SB" };

    /// <summary>
    /// die Republik Seychellen ISO numeric: 690
    /// </summary>
    public static CountryCode Seychellen => new() { Value = "SC" };

    /// <summary>
    /// die Republik Sudan ISO numeric: 729
    /// </summary>
    public static CountryCode Sudan => new() { Value = "SD" };

    /// <summary>
    /// das Königreich Schweden ISO numeric: 752
    /// </summary>
    public static CountryCode Schweden => new() { Value = "SE" };

    /// <summary>
    /// die Republik Singapur ISO numeric: 702
    /// </summary>
    public static CountryCode Singapur => new() { Value = "SG" };

    /// <summary>
    /// St. Helena, Ascension und Tristan da Cunha ISO numeric: 654
    /// </summary>
    public static CountryCode StHelenaAscensionUndTristanDaCunha => new() { Value = "SH" };

    /// <summary>
    /// die Republik Slowenien ISO numeric: 705
    /// </summary>
    public static CountryCode Slowenien => new() { Value = "SI" };

    /// <summary>
    /// Svalbard und Jan Mayen ISO numeric: 744
    /// </summary>
    public static CountryCode SvalbardUndJanMayen => new() { Value = "SJ" };

    /// <summary>
    /// die Slowakische Republik ISO numeric: 703
    /// </summary>
    public static CountryCode Slowakei => new() { Value = "SK" };

    /// <summary>
    /// die Republik Sierra Leone ISO numeric: 694
    /// </summary>
    public static CountryCode SierraLeone => new() { Value = "SL" };

    /// <summary>
    /// die Republik San Marino ISO numeric: 674
    /// </summary>
    public static CountryCode SanMarino => new() { Value = "SM" };

    /// <summary>
    /// die Republik Senegal ISO numeric: 686
    /// </summary>
    public static CountryCode Senegal => new() { Value = "SN" };

    /// <summary>
    /// die Bundesrepublik Somalia ISO numeric: 706
    /// </summary>
    public static CountryCode Somalia => new() { Value = "SO" };

    /// <summary>
    /// die Republik Suriname ISO numeric: 740
    /// </summary>
    public static CountryCode Suriname => new() { Value = "SR" };

    /// <summary>
    /// die Republik Südsudan ISO numeric: 728
    /// </summary>
    public static CountryCode Sudsudan => new() { Value = "SS" };

    /// <summary>
    /// die Demokratische Republik São Tomé und Príncipe ISO numeric: 678
    /// </summary>
    public static CountryCode SaoTomeUndPrincipe => new() { Value = "ST" };

    /// <summary>
    /// die Republik El Salvador ISO numeric: 222
    /// </summary>
    public static CountryCode ElSalvador => new() { Value = "SV" };

    /// <summary>
    /// St. Martin (Niederländischer Teil) ISO numeric: 534
    /// </summary>
    public static CountryCode StMartinNiederlandischerTeil => new() { Value = "SX" };

    /// <summary>
    /// die Arabische Republik Syrien ISO numeric: 760
    /// </summary>
    public static CountryCode ArabischeRepublikSyrien => new() { Value = "SY" };

    /// <summary>
    /// das Königreich Eswatini ISO numeric: 748
    /// </summary>
    public static CountryCode Eswatini => new() { Value = "SZ" };

    /// <summary>
    /// Turks- und Caicosinseln ISO numeric: 796
    /// </summary>
    public static CountryCode TurksUndCaicosinseln => new() { Value = "TC" };

    /// <summary>
    /// die Republik Tschad ISO numeric: 148
    /// </summary>
    public static CountryCode Tschad => new() { Value = "TD" };

    /// <summary>
    /// Französische Süd- und Antarktisgebiete ISO numeric: 260
    /// </summary>
    public static CountryCode FranzosischeSudUndAntarktisgebiete => new() { Value = "TF" };

    /// <summary>
    /// die Republik Togo ISO numeric: 768
    /// </summary>
    public static CountryCode Togo => new() { Value = "TG" };

    /// <summary>
    /// das Königreich Thailand ISO numeric: 764
    /// </summary>
    public static CountryCode Thailand => new() { Value = "TH" };

    /// <summary>
    /// die Republik Tadschikistan ISO numeric: 762
    /// </summary>
    public static CountryCode Tadschikistan => new() { Value = "TJ" };

    /// <summary>
    /// Tokelau ISO numeric: 772
    /// </summary>
    public static CountryCode Tokelau => new() { Value = "TK" };

    /// <summary>
    /// die Demokratische Republik Timor-Leste ISO numeric: 626
    /// </summary>
    public static CountryCode TimorLeste => new() { Value = "TL" };

    /// <summary>
    /// Turkmenistan ISO numeric: 795
    /// </summary>
    public static CountryCode Turkmenistan => new() { Value = "TM" };

    /// <summary>
    /// die Tunesische Republik ISO numeric: 788
    /// </summary>
    public static CountryCode Tunesien => new() { Value = "TN" };

    /// <summary>
    /// das Königreich Tonga ISO numeric: 776
    /// </summary>
    public static CountryCode Tonga => new() { Value = "TO" };

    /// <summary>
    /// die Republik Türkei ISO numeric: 792
    /// </summary>
    public static CountryCode Turkei => new() { Value = "TR" };

    /// <summary>
    /// die Republik Trinidad und Tobago ISO numeric: 780
    /// </summary>
    public static CountryCode TrinidadUndTobago => new() { Value = "TT" };

    /// <summary>
    /// Tuvalu ISO numeric: 798
    /// </summary>
    public static CountryCode Tuvalu => new() { Value = "TV" };

    /// <summary>
    /// Taiwan ISO numeric: 158
    /// </summary>
    public static CountryCode Taiwan => new() { Value = "TW" };

    /// <summary>
    /// die Vereinigte Republik Tansania ISO numeric: 834
    /// </summary>
    public static CountryCode VereinigteRepublikTansania => new() { Value = "TZ" };

    /// <summary>
    /// die Ukraine ISO numeric: 804
    /// </summary>
    public static CountryCode Ukraine => new() { Value = "UA" };

    /// <summary>
    /// die Republik Uganda ISO numeric: 800
    /// </summary>
    public static CountryCode Uganda => new() { Value = "UG" };

    /// <summary>
    /// Kleinere amerikanische Überseeinseln ISO numeric: 581
    /// </summary>
    public static CountryCode AmerikanischeUberseeinselnKleinere => new() { Value = "UM" };

    /// <summary>
    /// die Vereinigten Staaten von Amerika ISO numeric: 840
    /// </summary>
    public static CountryCode VereinigteStaaten => new() { Value = "US" };

    /// <summary>
    /// die Republik Östlich des Uruguay ISO numeric: 858
    /// </summary>
    public static CountryCode Uruguay => new() { Value = "UY" };

    /// <summary>
    /// die Republik Usbekistan ISO numeric: 860
    /// </summary>
    public static CountryCode Usbekistan => new() { Value = "UZ" };

    /// <summary>
    /// der Staat Vatikanstadt ISO numeric: 336
    /// </summary>
    public static CountryCode Vatikanstadt => new() { Value = "VA" };

    /// <summary>
    /// St. Vincent und die Grenadinen ISO numeric: 670
    /// </summary>
    public static CountryCode StVincentUndDieGrenadinen => new() { Value = "VC" };

    /// <summary>
    /// die Bolivarische Republik Venezuela ISO numeric: 862
    /// </summary>
    public static CountryCode BolivarischeRepublikVenezuela => new() { Value = "VE" };

    /// <summary>
    /// Britische Jungferninseln ISO numeric: 092
    /// </summary>
    public static CountryCode BritischeJungferninseln => new() { Value = "VG" };

    /// <summary>
    /// Amerikanische Jungferninseln ISO numeric: 850
    /// </summary>
    public static CountryCode AmerikanischeJungferninseln => new() { Value = "VI" };

    /// <summary>
    /// die Sozialistische Republik Vietnam ISO numeric: 704
    /// </summary>
    public static CountryCode Vietnam => new() { Value = "VN" };

    /// <summary>
    /// die Republik Vanuatu ISO numeric: 548
    /// </summary>
    public static CountryCode Vanuatu => new() { Value = "VU" };

    /// <summary>
    /// Wallis und Futuna ISO numeric: 876
    /// </summary>
    public static CountryCode WallisUndFutuna => new() { Value = "WF" };

    /// <summary>
    /// der Unabhängige Staat Samoa ISO numeric: 882
    /// </summary>
    public static CountryCode Samoa => new() { Value = "WS" };

    /// <summary>
    /// die Republik Kosovo  Status: user assigned code
    /// </summary>
    public static CountryCode Kosovo => new() { Value = "XK" };

    /// <summary>
    /// die Republik Jemen ISO numeric: 887
    /// </summary>
    public static CountryCode Jemen => new() { Value = "YE" };

    /// <summary>
    /// Mayotte ISO numeric: 175
    /// </summary>
    public static CountryCode Mayotte => new() { Value = "YT" };

    /// <summary>
    /// die Republik Südafrika ISO numeric: 710
    /// </summary>
    public static CountryCode Sudafrika => new() { Value = "ZA" };

    /// <summary>
    /// die Republik Sambia ISO numeric: 894
    /// </summary>
    public static CountryCode Sambia => new() { Value = "ZM" };

    /// <summary>
    /// die Republik Simbabwe ISO numeric: 716
    /// </summary>
    public static CountryCode Simbabwe => new() { Value = "ZW" };
}
