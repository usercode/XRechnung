namespace XRechnung;

/// <summary>
/// UN/ECE Recommendation N°20 unit of measure codes used in international trade.
/// </summary>
public record class QuantityCode : Code
{
    /// <summary>
    /// group
    /// </summary>
    public static readonly QuantityCode Group = new QuantityCode { Value = "10" };

    /// <summary>
    /// outfit
    /// </summary>
    public static readonly QuantityCode Outfit = new QuantityCode { Value = "11" };

    /// <summary>
    /// ration
    /// </summary>
    public static readonly QuantityCode Ration = new QuantityCode { Value = "13" };

    /// <summary>
    /// shot
    /// </summary>
    public static readonly QuantityCode Shot = new QuantityCode { Value = "14" };

    /// <summary>
    /// stick, military
    /// </summary>
    public static readonly QuantityCode StickMilitary = new QuantityCode { Value = "15" };

    /// <summary>
    /// twenty foot container
    /// </summary>
    public static readonly QuantityCode TwentyFootContainer = new QuantityCode { Value = "20" };

    /// <summary>
    /// forty foot container
    /// </summary>
    public static readonly QuantityCode FortyFootContainer = new QuantityCode { Value = "21" };

    /// <summary>
    /// decilitre per gram
    /// </summary>
    public static readonly QuantityCode DecilitrePerGram = new QuantityCode { Value = "22" };

    /// <summary>
    /// gram per cubic centimetre
    /// </summary>
    public static readonly QuantityCode GramPerCubicCentimetre = new QuantityCode { Value = "23" };

    /// <summary>
    /// theoretical pound
    /// </summary>
    public static readonly QuantityCode TheoreticalPound = new QuantityCode { Value = "24" };

    /// <summary>
    /// gram per square centimetre
    /// </summary>
    public static readonly QuantityCode GramPerSquareCentimetre = new QuantityCode { Value = "25" };

    /// <summary>
    /// theoretical ton
    /// </summary>
    public static readonly QuantityCode TheoreticalTon = new QuantityCode { Value = "27" };

    /// <summary>
    /// kilogram per square metre
    /// </summary>
    public static readonly QuantityCode KilogramPerSquareMetre = new QuantityCode { Value = "28" };

    /// <summary>
    /// kilopascal square metre per gram
    /// </summary>
    public static readonly QuantityCode KilopascalSquareMetrePerGram = new QuantityCode { Value = "33" };

    /// <summary>
    /// kilopascal per millimetre
    /// </summary>
    public static readonly QuantityCode KilopascalPerMillimetre = new QuantityCode { Value = "34" };

    /// <summary>
    /// millilitre per square centimetre second
    /// </summary>
    public static readonly QuantityCode MillilitrePerSquareCentimetreSecond = new QuantityCode { Value = "35" };

    /// <summary>
    /// ounce per square foot
    /// </summary>
    public static readonly QuantityCode OuncePerSquareFoot = new QuantityCode { Value = "37" };

    /// <summary>
    /// ounce per square foot per 0,01inch
    /// </summary>
    public static readonly QuantityCode OuncePerSquareFootPer001inch = new QuantityCode { Value = "38" };

    /// <summary>
    /// millilitre per second
    /// </summary>
    public static readonly QuantityCode MillilitrePerSecond = new QuantityCode { Value = "40" };

    /// <summary>
    /// millilitre per minute
    /// </summary>
    public static readonly QuantityCode MillilitrePerMinute = new QuantityCode { Value = "41" };

    /// <summary>
    /// sitas
    /// </summary>
    public static readonly QuantityCode Sitas = new QuantityCode { Value = "56" };

    /// <summary>
    /// mesh
    /// </summary>
    public static readonly QuantityCode Mesh = new QuantityCode { Value = "57" };

    /// <summary>
    /// net kilogram
    /// </summary>
    public static readonly QuantityCode NetKilogram = new QuantityCode { Value = "58" };

    /// <summary>
    /// part per million
    /// </summary>
    public static readonly QuantityCode PartPerMillion = new QuantityCode { Value = "59" };

    /// <summary>
    /// percent weight
    /// </summary>
    public static readonly QuantityCode PercentWeight = new QuantityCode { Value = "60" };

    /// <summary>
    /// part per billion (US)
    /// </summary>
    public static readonly QuantityCode PartPerBillionUS = new QuantityCode { Value = "61" };

    /// <summary>
    /// millipascal
    /// </summary>
    public static readonly QuantityCode Millipascal = new QuantityCode { Value = "74" };

    /// <summary>
    /// milli-inch
    /// </summary>
    public static readonly QuantityCode MilliInch = new QuantityCode { Value = "77" };

    /// <summary>
    /// pound per square inch absolute
    /// </summary>
    public static readonly QuantityCode PoundPerSquareInchAbsolute = new QuantityCode { Value = "80" };

    /// <summary>
    /// henry
    /// </summary>
    public static readonly QuantityCode Henry = new QuantityCode { Value = "81" };

    /// <summary>
    /// foot pound-force
    /// </summary>
    public static readonly QuantityCode FootPoundForce = new QuantityCode { Value = "85" };

    /// <summary>
    /// pound per cubic foot
    /// </summary>
    public static readonly QuantityCode PoundPerCubicFoot = new QuantityCode { Value = "87" };

    /// <summary>
    /// poise
    /// </summary>
    public static readonly QuantityCode Poise = new QuantityCode { Value = "89" };

    /// <summary>
    /// stokes
    /// </summary>
    public static readonly QuantityCode Stokes = new QuantityCode { Value = "91" };

    /// <summary>
    /// fixed rate
    /// </summary>
    public static readonly QuantityCode FixedRate = new QuantityCode { Value = "1I" };

    /// <summary>
    /// radian per second
    /// </summary>
    public static readonly QuantityCode RadianPerSecond = new QuantityCode { Value = "2A" };

    /// <summary>
    /// radian per second squared
    /// </summary>
    public static readonly QuantityCode RadianPerSecondSquared = new QuantityCode { Value = "2B" };

    /// <summary>
    /// roentgen
    /// </summary>
    public static readonly QuantityCode Roentgen = new QuantityCode { Value = "2C" };

    /// <summary>
    /// volt AC
    /// </summary>
    public static readonly QuantityCode VoltAC = new QuantityCode { Value = "2G" };

    /// <summary>
    /// volt DC
    /// </summary>
    public static readonly QuantityCode VoltDC = new QuantityCode { Value = "2H" };

    /// <summary>
    /// British thermal unit (international table) per hour
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitInternationalTablePerHour = new QuantityCode { Value = "2I" };

    /// <summary>
    /// cubic centimetre per second
    /// </summary>
    public static readonly QuantityCode CubicCentimetrePerSecond = new QuantityCode { Value = "2J" };

    /// <summary>
    /// cubic foot per hour
    /// </summary>
    public static readonly QuantityCode CubicFootPerHour = new QuantityCode { Value = "2K" };

    /// <summary>
    /// cubic foot per minute
    /// </summary>
    public static readonly QuantityCode CubicFootPerMinute = new QuantityCode { Value = "2L" };

    /// <summary>
    /// centimetre per second
    /// </summary>
    public static readonly QuantityCode CentimetrePerSecond = new QuantityCode { Value = "2M" };

    /// <summary>
    /// decibel
    /// </summary>
    public static readonly QuantityCode Decibel = new QuantityCode { Value = "2N" };

    /// <summary>
    /// kilobyte
    /// </summary>
    public static readonly QuantityCode Kilobyte = new QuantityCode { Value = "2P" };

    /// <summary>
    /// kilobecquerel
    /// </summary>
    public static readonly QuantityCode Kilobecquerel = new QuantityCode { Value = "2Q" };

    /// <summary>
    /// kilocurie
    /// </summary>
    public static readonly QuantityCode Kilocurie = new QuantityCode { Value = "2R" };

    /// <summary>
    /// megagram
    /// </summary>
    public static readonly QuantityCode Megagram = new QuantityCode { Value = "2U" };

    /// <summary>
    /// metre per minute
    /// </summary>
    public static readonly QuantityCode MetrePerMinute = new QuantityCode { Value = "2X" };

    /// <summary>
    /// milliroentgen
    /// </summary>
    public static readonly QuantityCode Milliroentgen = new QuantityCode { Value = "2Y" };

    /// <summary>
    /// millivolt
    /// </summary>
    public static readonly QuantityCode Millivolt = new QuantityCode { Value = "2Z" };

    /// <summary>
    /// megajoule
    /// </summary>
    public static readonly QuantityCode Megajoule = new QuantityCode { Value = "3B" };

    /// <summary>
    /// manmonth
    /// </summary>
    public static readonly QuantityCode Manmonth = new QuantityCode { Value = "3C" };

    /// <summary>
    /// centistokes
    /// </summary>
    public static readonly QuantityCode Centistokes = new QuantityCode { Value = "4C" };

    /// <summary>
    /// microlitre
    /// </summary>
    public static readonly QuantityCode Microlitre = new QuantityCode { Value = "4G" };

    /// <summary>
    /// micrometre (micron)
    /// </summary>
    public static readonly QuantityCode MicrometreMicron = new QuantityCode { Value = "4H" };

    /// <summary>
    /// milliampere
    /// </summary>
    public static readonly QuantityCode Milliampere = new QuantityCode { Value = "4K" };

    /// <summary>
    /// megabyte
    /// </summary>
    public static readonly QuantityCode Megabyte = new QuantityCode { Value = "4L" };

    /// <summary>
    /// milligram per hour
    /// </summary>
    public static readonly QuantityCode MilligramPerHour = new QuantityCode { Value = "4M" };

    /// <summary>
    /// megabecquerel
    /// </summary>
    public static readonly QuantityCode Megabecquerel = new QuantityCode { Value = "4N" };

    /// <summary>
    /// microfarad
    /// </summary>
    public static readonly QuantityCode Microfarad = new QuantityCode { Value = "4O" };

    /// <summary>
    /// newton per metre
    /// </summary>
    public static readonly QuantityCode NewtonPerMetre = new QuantityCode { Value = "4P" };

    /// <summary>
    /// ounce inch
    /// </summary>
    public static readonly QuantityCode OunceInch = new QuantityCode { Value = "4Q" };

    /// <summary>
    /// ounce foot
    /// </summary>
    public static readonly QuantityCode OunceFoot = new QuantityCode { Value = "4R" };

    /// <summary>
    /// picofarad
    /// </summary>
    public static readonly QuantityCode Picofarad = new QuantityCode { Value = "4T" };

    /// <summary>
    /// pound per hour
    /// </summary>
    public static readonly QuantityCode PoundPerHour = new QuantityCode { Value = "4U" };

    /// <summary>
    /// ton (US) per hour
    /// </summary>
    public static readonly QuantityCode TonUSPerHour = new QuantityCode { Value = "4W" };

    /// <summary>
    /// kilolitre per hour
    /// </summary>
    public static readonly QuantityCode KilolitrePerHour = new QuantityCode { Value = "4X" };

    /// <summary>
    /// barrel (US) per minute
    /// </summary>
    public static readonly QuantityCode BarrelUSPerMinute = new QuantityCode { Value = "5A" };

    /// <summary>
    /// batch
    /// </summary>
    public static readonly QuantityCode Batch = new QuantityCode { Value = "5B" };

    /// <summary>
    /// MMSCF/day
    /// </summary>
    public static readonly QuantityCode MMSCFDay = new QuantityCode { Value = "5E" };

    /// <summary>
    /// hydraulic horse power
    /// </summary>
    public static readonly QuantityCode HydraulicHorsePower = new QuantityCode { Value = "5J" };

    /// <summary>
    /// ampere square metre per joule second
    /// </summary>
    public static readonly QuantityCode AmpereSquareMetrePerJouleSecond = new QuantityCode { Value = "A10" };

    /// <summary>
    /// angstrom
    /// </summary>
    public static readonly QuantityCode Angstrom = new QuantityCode { Value = "A11" };

    /// <summary>
    /// astronomical unit
    /// </summary>
    public static readonly QuantityCode AstronomicalUnit = new QuantityCode { Value = "A12" };

    /// <summary>
    /// attojoule
    /// </summary>
    public static readonly QuantityCode Attojoule = new QuantityCode { Value = "A13" };

    /// <summary>
    /// barn
    /// </summary>
    public static readonly QuantityCode Barn = new QuantityCode { Value = "A14" };

    /// <summary>
    /// barn per electronvolt
    /// </summary>
    public static readonly QuantityCode BarnPerElectronvolt = new QuantityCode { Value = "A15" };

    /// <summary>
    /// barn per steradian electronvolt
    /// </summary>
    public static readonly QuantityCode BarnPerSteradianElectronvolt = new QuantityCode { Value = "A16" };

    /// <summary>
    /// barn per steradian
    /// </summary>
    public static readonly QuantityCode BarnPerSteradian = new QuantityCode { Value = "A17" };

    /// <summary>
    /// becquerel per kilogram
    /// </summary>
    public static readonly QuantityCode BecquerelPerKilogram = new QuantityCode { Value = "A18" };

    /// <summary>
    /// becquerel per cubic metre
    /// </summary>
    public static readonly QuantityCode BecquerelPerCubicMetre = new QuantityCode { Value = "A19" };

    /// <summary>
    /// ampere per centimetre
    /// </summary>
    public static readonly QuantityCode AmperePerCentimetre = new QuantityCode { Value = "A2" };

    /// <summary>
    /// British thermal unit (international table) per second square foot degree Rankine
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitInternationalTablePerSecondSquareFootDegreeRankine = new QuantityCode { Value = "A20" };

    /// <summary>
    /// British thermal unit (international table) per pound degree Rankine
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitInternationalTablePerPoundDegreeRankine = new QuantityCode { Value = "A21" };

    /// <summary>
    /// British thermal unit (international table) per second foot degree Rankine
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitInternationalTablePerSecondFootDegreeRankine = new QuantityCode { Value = "A22" };

    /// <summary>
    /// British thermal unit (international table) per hour square foot degree Rankine
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitInternationalTablePerHourSquareFootDegreeRankine = new QuantityCode { Value = "A23" };

    /// <summary>
    /// candela per square metre
    /// </summary>
    public static readonly QuantityCode CandelaPerSquareMetre = new QuantityCode { Value = "A24" };

    /// <summary>
    /// coulomb metre
    /// </summary>
    public static readonly QuantityCode CoulombMetre = new QuantityCode { Value = "A26" };

    /// <summary>
    /// coulomb metre squared per volt
    /// </summary>
    public static readonly QuantityCode CoulombMetreSquaredPerVolt = new QuantityCode { Value = "A27" };

    /// <summary>
    /// coulomb per cubic centimetre
    /// </summary>
    public static readonly QuantityCode CoulombPerCubicCentimetre = new QuantityCode { Value = "A28" };

    /// <summary>
    /// coulomb per cubic metre
    /// </summary>
    public static readonly QuantityCode CoulombPerCubicMetre = new QuantityCode { Value = "A29" };

    /// <summary>
    /// ampere per millimetre
    /// </summary>
    public static readonly QuantityCode AmperePerMillimetre = new QuantityCode { Value = "A3" };

    /// <summary>
    /// coulomb per cubic millimetre
    /// </summary>
    public static readonly QuantityCode CoulombPerCubicMillimetre = new QuantityCode { Value = "A30" };

    /// <summary>
    /// coulomb per kilogram second
    /// </summary>
    public static readonly QuantityCode CoulombPerKilogramSecond = new QuantityCode { Value = "A31" };

    /// <summary>
    /// coulomb per mole
    /// </summary>
    public static readonly QuantityCode CoulombPerMole = new QuantityCode { Value = "A32" };

    /// <summary>
    /// coulomb per square centimetre
    /// </summary>
    public static readonly QuantityCode CoulombPerSquareCentimetre = new QuantityCode { Value = "A33" };

    /// <summary>
    /// coulomb per square metre
    /// </summary>
    public static readonly QuantityCode CoulombPerSquareMetre = new QuantityCode { Value = "A34" };

    /// <summary>
    /// coulomb per square millimetre
    /// </summary>
    public static readonly QuantityCode CoulombPerSquareMillimetre = new QuantityCode { Value = "A35" };

    /// <summary>
    /// cubic centimetre per mole
    /// </summary>
    public static readonly QuantityCode CubicCentimetrePerMole = new QuantityCode { Value = "A36" };

    /// <summary>
    /// cubic decimetre per mole
    /// </summary>
    public static readonly QuantityCode CubicDecimetrePerMole = new QuantityCode { Value = "A37" };

    /// <summary>
    /// cubic metre per coulomb
    /// </summary>
    public static readonly QuantityCode CubicMetrePerCoulomb = new QuantityCode { Value = "A38" };

    /// <summary>
    /// cubic metre per kilogram
    /// </summary>
    public static readonly QuantityCode CubicMetrePerKilogram = new QuantityCode { Value = "A39" };

    /// <summary>
    /// ampere per square centimetre
    /// </summary>
    public static readonly QuantityCode AmperePerSquareCentimetre = new QuantityCode { Value = "A4" };

    /// <summary>
    /// cubic metre per mole
    /// </summary>
    public static readonly QuantityCode CubicMetrePerMole = new QuantityCode { Value = "A40" };

    /// <summary>
    /// ampere per square metre
    /// </summary>
    public static readonly QuantityCode AmperePerSquareMetre = new QuantityCode { Value = "A41" };

    /// <summary>
    /// curie per kilogram
    /// </summary>
    public static readonly QuantityCode CuriePerKilogram = new QuantityCode { Value = "A42" };

    /// <summary>
    /// deadweight tonnage
    /// </summary>
    public static readonly QuantityCode DeadweightTonnage = new QuantityCode { Value = "A43" };

    /// <summary>
    /// decalitre
    /// </summary>
    public static readonly QuantityCode Decalitre = new QuantityCode { Value = "A44" };

    /// <summary>
    /// decametre
    /// </summary>
    public static readonly QuantityCode Decametre = new QuantityCode { Value = "A45" };

    /// <summary>
    /// decitex
    /// </summary>
    public static readonly QuantityCode Decitex = new QuantityCode { Value = "A47" };

    /// <summary>
    /// degree Rankine
    /// </summary>
    public static readonly QuantityCode DegreeRankine = new QuantityCode { Value = "A48" };

    /// <summary>
    /// denier
    /// </summary>
    public static readonly QuantityCode Denier = new QuantityCode { Value = "A49" };

    /// <summary>
    /// ampere square metre
    /// </summary>
    public static readonly QuantityCode AmpereSquareMetre = new QuantityCode { Value = "A5" };

    /// <summary>
    /// electronvolt
    /// </summary>
    public static readonly QuantityCode Electronvolt = new QuantityCode { Value = "A53" };

    /// <summary>
    /// electronvolt per metre
    /// </summary>
    public static readonly QuantityCode ElectronvoltPerMetre = new QuantityCode { Value = "A54" };

    /// <summary>
    /// electronvolt square metre
    /// </summary>
    public static readonly QuantityCode ElectronvoltSquareMetre = new QuantityCode { Value = "A55" };

    /// <summary>
    /// electronvolt square metre per kilogram
    /// </summary>
    public static readonly QuantityCode ElectronvoltSquareMetrePerKilogram = new QuantityCode { Value = "A56" };

    /// <summary>
    /// 8-part cloud cover
    /// </summary>
    public static readonly QuantityCode Code8PartCloudCover = new QuantityCode { Value = "A59" };

    /// <summary>
    /// ampere per square metre kelvin squared
    /// </summary>
    public static readonly QuantityCode AmperePerSquareMetreKelvinSquared = new QuantityCode { Value = "A6" };

    /// <summary>
    /// exajoule
    /// </summary>
    public static readonly QuantityCode Exajoule = new QuantityCode { Value = "A68" };

    /// <summary>
    /// farad per metre
    /// </summary>
    public static readonly QuantityCode FaradPerMetre = new QuantityCode { Value = "A69" };

    /// <summary>
    /// ampere per square millimetre
    /// </summary>
    public static readonly QuantityCode AmperePerSquareMillimetre = new QuantityCode { Value = "A7" };

    /// <summary>
    /// femtojoule
    /// </summary>
    public static readonly QuantityCode Femtojoule = new QuantityCode { Value = "A70" };

    /// <summary>
    /// femtometre
    /// </summary>
    public static readonly QuantityCode Femtometre = new QuantityCode { Value = "A71" };

    /// <summary>
    /// foot per second squared
    /// </summary>
    public static readonly QuantityCode FootPerSecondSquared = new QuantityCode { Value = "A73" };

    /// <summary>
    /// foot pound-force per second
    /// </summary>
    public static readonly QuantityCode FootPoundForcePerSecond = new QuantityCode { Value = "A74" };

    /// <summary>
    /// freight ton
    /// </summary>
    public static readonly QuantityCode FreightTon = new QuantityCode { Value = "A75" };

    /// <summary>
    /// gal
    /// </summary>
    public static readonly QuantityCode Gal = new QuantityCode { Value = "A76" };

    /// <summary>
    /// ampere second
    /// </summary>
    public static readonly QuantityCode AmpereSecond = new QuantityCode { Value = "A8" };

    /// <summary>
    /// gigacoulomb per cubic metre
    /// </summary>
    public static readonly QuantityCode GigacoulombPerCubicMetre = new QuantityCode { Value = "A84" };

    /// <summary>
    /// gigaelectronvolt
    /// </summary>
    public static readonly QuantityCode Gigaelectronvolt = new QuantityCode { Value = "A85" };

    /// <summary>
    /// gigahertz
    /// </summary>
    public static readonly QuantityCode Gigahertz = new QuantityCode { Value = "A86" };

    /// <summary>
    /// gigaohm
    /// </summary>
    public static readonly QuantityCode Gigaohm = new QuantityCode { Value = "A87" };

    /// <summary>
    /// gigaohm metre
    /// </summary>
    public static readonly QuantityCode GigaohmMetre = new QuantityCode { Value = "A88" };

    /// <summary>
    /// gigapascal
    /// </summary>
    public static readonly QuantityCode Gigapascal = new QuantityCode { Value = "A89" };

    /// <summary>
    /// rate
    /// </summary>
    public static readonly QuantityCode Rate = new QuantityCode { Value = "A9" };

    /// <summary>
    /// gigawatt
    /// </summary>
    public static readonly QuantityCode Gigawatt = new QuantityCode { Value = "A90" };

    /// <summary>
    /// gon
    /// </summary>
    public static readonly QuantityCode Gon = new QuantityCode { Value = "A91" };

    /// <summary>
    /// gram per cubic metre
    /// </summary>
    public static readonly QuantityCode GramPerCubicMetre = new QuantityCode { Value = "A93" };

    /// <summary>
    /// gram per mole
    /// </summary>
    public static readonly QuantityCode GramPerMole = new QuantityCode { Value = "A94" };

    /// <summary>
    /// gray
    /// </summary>
    public static readonly QuantityCode Gray = new QuantityCode { Value = "A95" };

    /// <summary>
    /// gray per second
    /// </summary>
    public static readonly QuantityCode GrayPerSecond = new QuantityCode { Value = "A96" };

    /// <summary>
    /// hectopascal
    /// </summary>
    public static readonly QuantityCode Hectopascal = new QuantityCode { Value = "A97" };

    /// <summary>
    /// henry per metre
    /// </summary>
    public static readonly QuantityCode HenryPerMetre = new QuantityCode { Value = "A98" };

    /// <summary>
    /// bit
    /// </summary>
    public static readonly QuantityCode Bit = new QuantityCode { Value = "A99" };

    /// <summary>
    /// ball
    /// </summary>
    public static readonly QuantityCode Ball = new QuantityCode { Value = "AA" };

    /// <summary>
    /// bulk pack
    /// </summary>
    public static readonly QuantityCode BulkPack = new QuantityCode { Value = "AB" };

    /// <summary>
    /// acre
    /// </summary>
    public static readonly QuantityCode Acre = new QuantityCode { Value = "ACR" };

    /// <summary>
    /// activity
    /// </summary>
    public static readonly QuantityCode Activity = new QuantityCode { Value = "ACT" };

    /// <summary>
    /// byte
    /// </summary>
    public static readonly QuantityCode Byte = new QuantityCode { Value = "AD" };

    /// <summary>
    /// ampere per metre
    /// </summary>
    public static readonly QuantityCode AmperePerMetre = new QuantityCode { Value = "AE" };

    /// <summary>
    /// additional minute
    /// </summary>
    public static readonly QuantityCode AdditionalMinute = new QuantityCode { Value = "AH" };

    /// <summary>
    /// average minute per call
    /// </summary>
    public static readonly QuantityCode AverageMinutePerCall = new QuantityCode { Value = "AI" };

    /// <summary>
    /// fathom
    /// </summary>
    public static readonly QuantityCode Fathom = new QuantityCode { Value = "AK" };

    /// <summary>
    /// access line
    /// </summary>
    public static readonly QuantityCode AccessLine = new QuantityCode { Value = "AL" };

    /// <summary>
    /// ampere hour
    /// </summary>
    public static readonly QuantityCode AmpereHour = new QuantityCode { Value = "AMH" };

    /// <summary>
    /// ampere
    /// </summary>
    public static readonly QuantityCode Ampere = new QuantityCode { Value = "AMP" };

    /// <summary>
    /// year
    /// </summary>
    public static readonly QuantityCode Year = new QuantityCode { Value = "ANN" };

    /// <summary>
    /// troy ounce or apothecary ounce
    /// </summary>
    public static readonly QuantityCode TroyOunceOrApothecaryOunce = new QuantityCode { Value = "APZ" };

    /// <summary>
    /// anti-hemophilic factor (AHF) unit
    /// </summary>
    public static readonly QuantityCode AntiHemophilicFactorAHFUnit = new QuantityCode { Value = "AQ" };

    /// <summary>
    /// assortment
    /// </summary>
    public static readonly QuantityCode Assortment = new QuantityCode { Value = "AS" };

    /// <summary>
    /// alcoholic strength by mass
    /// </summary>
    public static readonly QuantityCode AlcoholicStrengthByMass = new QuantityCode { Value = "ASM" };

    /// <summary>
    /// alcoholic strength by volume
    /// </summary>
    public static readonly QuantityCode AlcoholicStrengthByVolume = new QuantityCode { Value = "ASU" };

    /// <summary>
    /// standard atmosphere
    /// </summary>
    public static readonly QuantityCode StandardAtmosphere = new QuantityCode { Value = "ATM" };

    /// <summary>
    /// american wire gauge
    /// </summary>
    public static readonly QuantityCode AmericanWireGauge = new QuantityCode { Value = "AWG" };

    /// <summary>
    /// assembly
    /// </summary>
    public static readonly QuantityCode Assembly = new QuantityCode { Value = "AY" };

    /// <summary>
    /// British thermal unit (international table) per pound
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitInternationalTablePerPound = new QuantityCode { Value = "AZ" };

    /// <summary>
    /// barrel (US) per day
    /// </summary>
    public static readonly QuantityCode BarrelUSPerDay = new QuantityCode { Value = "B1" };

    /// <summary>
    /// bit per second
    /// </summary>
    public static readonly QuantityCode BitPerSecond = new QuantityCode { Value = "B10" };

    /// <summary>
    /// joule per kilogram kelvin
    /// </summary>
    public static readonly QuantityCode JoulePerKilogramKelvin = new QuantityCode { Value = "B11" };

    /// <summary>
    /// joule per metre
    /// </summary>
    public static readonly QuantityCode JoulePerMetre = new QuantityCode { Value = "B12" };

    /// <summary>
    /// joule per square metre
    /// </summary>
    public static readonly QuantityCode JoulePerSquareMetre = new QuantityCode { Value = "B13" };

    /// <summary>
    /// joule per metre to the fourth power
    /// </summary>
    public static readonly QuantityCode JoulePerMetreToTheFourthPower = new QuantityCode { Value = "B14" };

    /// <summary>
    /// joule per mole
    /// </summary>
    public static readonly QuantityCode JoulePerMole = new QuantityCode { Value = "B15" };

    /// <summary>
    /// joule per mole kelvin
    /// </summary>
    public static readonly QuantityCode JoulePerMoleKelvin = new QuantityCode { Value = "B16" };

    /// <summary>
    /// credit
    /// </summary>
    public static readonly QuantityCode Credit = new QuantityCode { Value = "B17" };

    /// <summary>
    /// joule second
    /// </summary>
    public static readonly QuantityCode JouleSecond = new QuantityCode { Value = "B18" };

    /// <summary>
    /// digit
    /// </summary>
    public static readonly QuantityCode Digit = new QuantityCode { Value = "B19" };

    /// <summary>
    /// joule square metre per kilogram
    /// </summary>
    public static readonly QuantityCode JouleSquareMetrePerKilogram = new QuantityCode { Value = "B20" };

    /// <summary>
    /// kelvin per watt
    /// </summary>
    public static readonly QuantityCode KelvinPerWatt = new QuantityCode { Value = "B21" };

    /// <summary>
    /// kiloampere
    /// </summary>
    public static readonly QuantityCode Kiloampere = new QuantityCode { Value = "B22" };

    /// <summary>
    /// kiloampere per square metre
    /// </summary>
    public static readonly QuantityCode KiloamperePerSquareMetre = new QuantityCode { Value = "B23" };

    /// <summary>
    /// kiloampere per metre
    /// </summary>
    public static readonly QuantityCode KiloamperePerMetre = new QuantityCode { Value = "B24" };

    /// <summary>
    /// kilobecquerel per kilogram
    /// </summary>
    public static readonly QuantityCode KilobecquerelPerKilogram = new QuantityCode { Value = "B25" };

    /// <summary>
    /// kilocoulomb
    /// </summary>
    public static readonly QuantityCode Kilocoulomb = new QuantityCode { Value = "B26" };

    /// <summary>
    /// kilocoulomb per cubic metre
    /// </summary>
    public static readonly QuantityCode KilocoulombPerCubicMetre = new QuantityCode { Value = "B27" };

    /// <summary>
    /// kilocoulomb per square metre
    /// </summary>
    public static readonly QuantityCode KilocoulombPerSquareMetre = new QuantityCode { Value = "B28" };

    /// <summary>
    /// kiloelectronvolt
    /// </summary>
    public static readonly QuantityCode Kiloelectronvolt = new QuantityCode { Value = "B29" };

    /// <summary>
    /// batting pound
    /// </summary>
    public static readonly QuantityCode BattingPound = new QuantityCode { Value = "B3" };

    /// <summary>
    /// gibibit
    /// </summary>
    public static readonly QuantityCode Gibibit = new QuantityCode { Value = "B30" };

    /// <summary>
    /// kilogram metre per second
    /// </summary>
    public static readonly QuantityCode KilogramMetrePerSecond = new QuantityCode { Value = "B31" };

    /// <summary>
    /// kilogram metre squared
    /// </summary>
    public static readonly QuantityCode KilogramMetreSquared = new QuantityCode { Value = "B32" };

    /// <summary>
    /// kilogram metre squared per second
    /// </summary>
    public static readonly QuantityCode KilogramMetreSquaredPerSecond = new QuantityCode { Value = "B33" };

    /// <summary>
    /// kilogram per cubic decimetre
    /// </summary>
    public static readonly QuantityCode KilogramPerCubicDecimetre = new QuantityCode { Value = "B34" };

    /// <summary>
    /// kilogram per litre
    /// </summary>
    public static readonly QuantityCode KilogramPerLitre = new QuantityCode { Value = "B35" };

    /// <summary>
    /// barrel, imperial
    /// </summary>
    public static readonly QuantityCode BarrelImperial = new QuantityCode { Value = "B4" };

    /// <summary>
    /// kilojoule per kelvin
    /// </summary>
    public static readonly QuantityCode KilojoulePerKelvin = new QuantityCode { Value = "B41" };

    /// <summary>
    /// kilojoule per kilogram
    /// </summary>
    public static readonly QuantityCode KilojoulePerKilogram = new QuantityCode { Value = "B42" };

    /// <summary>
    /// kilojoule per kilogram kelvin
    /// </summary>
    public static readonly QuantityCode KilojoulePerKilogramKelvin = new QuantityCode { Value = "B43" };

    /// <summary>
    /// kilojoule per mole
    /// </summary>
    public static readonly QuantityCode KilojoulePerMole = new QuantityCode { Value = "B44" };

    /// <summary>
    /// kilomole
    /// </summary>
    public static readonly QuantityCode Kilomole = new QuantityCode { Value = "B45" };

    /// <summary>
    /// kilomole per cubic metre
    /// </summary>
    public static readonly QuantityCode KilomolePerCubicMetre = new QuantityCode { Value = "B46" };

    /// <summary>
    /// kilonewton
    /// </summary>
    public static readonly QuantityCode Kilonewton = new QuantityCode { Value = "B47" };

    /// <summary>
    /// kilonewton metre
    /// </summary>
    public static readonly QuantityCode KilonewtonMetre = new QuantityCode { Value = "B48" };

    /// <summary>
    /// kiloohm
    /// </summary>
    public static readonly QuantityCode Kiloohm = new QuantityCode { Value = "B49" };

    /// <summary>
    /// kiloohm metre
    /// </summary>
    public static readonly QuantityCode KiloohmMetre = new QuantityCode { Value = "B50" };

    /// <summary>
    /// kilosecond
    /// </summary>
    public static readonly QuantityCode Kilosecond = new QuantityCode { Value = "B52" };

    /// <summary>
    /// kilosiemens
    /// </summary>
    public static readonly QuantityCode Kilosiemens = new QuantityCode { Value = "B53" };

    /// <summary>
    /// kilosiemens per metre
    /// </summary>
    public static readonly QuantityCode KilosiemensPerMetre = new QuantityCode { Value = "B54" };

    /// <summary>
    /// kilovolt per metre
    /// </summary>
    public static readonly QuantityCode KilovoltPerMetre = new QuantityCode { Value = "B55" };

    /// <summary>
    /// kiloweber per metre
    /// </summary>
    public static readonly QuantityCode KiloweberPerMetre = new QuantityCode { Value = "B56" };

    /// <summary>
    /// light year
    /// </summary>
    public static readonly QuantityCode LightYear = new QuantityCode { Value = "B57" };

    /// <summary>
    /// litre per mole
    /// </summary>
    public static readonly QuantityCode LitrePerMole = new QuantityCode { Value = "B58" };

    /// <summary>
    /// lumen hour
    /// </summary>
    public static readonly QuantityCode LumenHour = new QuantityCode { Value = "B59" };

    /// <summary>
    /// lumen per square metre
    /// </summary>
    public static readonly QuantityCode LumenPerSquareMetre = new QuantityCode { Value = "B60" };

    /// <summary>
    /// lumen per watt
    /// </summary>
    public static readonly QuantityCode LumenPerWatt = new QuantityCode { Value = "B61" };

    /// <summary>
    /// lumen second
    /// </summary>
    public static readonly QuantityCode LumenSecond = new QuantityCode { Value = "B62" };

    /// <summary>
    /// lux hour
    /// </summary>
    public static readonly QuantityCode LuxHour = new QuantityCode { Value = "B63" };

    /// <summary>
    /// lux second
    /// </summary>
    public static readonly QuantityCode LuxSecond = new QuantityCode { Value = "B64" };

    /// <summary>
    /// megaampere per square metre
    /// </summary>
    public static readonly QuantityCode MegaamperePerSquareMetre = new QuantityCode { Value = "B66" };

    /// <summary>
    /// megabecquerel per kilogram
    /// </summary>
    public static readonly QuantityCode MegabecquerelPerKilogram = new QuantityCode { Value = "B67" };

    /// <summary>
    /// gigabit
    /// </summary>
    public static readonly QuantityCode Gigabit = new QuantityCode { Value = "B68" };

    /// <summary>
    /// megacoulomb per cubic metre
    /// </summary>
    public static readonly QuantityCode MegacoulombPerCubicMetre = new QuantityCode { Value = "B69" };

    /// <summary>
    /// cycle
    /// </summary>
    public static readonly QuantityCode Cycle = new QuantityCode { Value = "B7" };

    /// <summary>
    /// megacoulomb per square metre
    /// </summary>
    public static readonly QuantityCode MegacoulombPerSquareMetre = new QuantityCode { Value = "B70" };

    /// <summary>
    /// megaelectronvolt
    /// </summary>
    public static readonly QuantityCode Megaelectronvolt = new QuantityCode { Value = "B71" };

    /// <summary>
    /// megagram per cubic metre
    /// </summary>
    public static readonly QuantityCode MegagramPerCubicMetre = new QuantityCode { Value = "B72" };

    /// <summary>
    /// meganewton
    /// </summary>
    public static readonly QuantityCode Meganewton = new QuantityCode { Value = "B73" };

    /// <summary>
    /// meganewton metre
    /// </summary>
    public static readonly QuantityCode MeganewtonMetre = new QuantityCode { Value = "B74" };

    /// <summary>
    /// megaohm
    /// </summary>
    public static readonly QuantityCode Megaohm = new QuantityCode { Value = "B75" };

    /// <summary>
    /// megaohm metre
    /// </summary>
    public static readonly QuantityCode MegaohmMetre = new QuantityCode { Value = "B76" };

    /// <summary>
    /// megasiemens per metre
    /// </summary>
    public static readonly QuantityCode MegasiemensPerMetre = new QuantityCode { Value = "B77" };

    /// <summary>
    /// megavolt
    /// </summary>
    public static readonly QuantityCode Megavolt = new QuantityCode { Value = "B78" };

    /// <summary>
    /// megavolt per metre
    /// </summary>
    public static readonly QuantityCode MegavoltPerMetre = new QuantityCode { Value = "B79" };

    /// <summary>
    /// joule per cubic metre
    /// </summary>
    public static readonly QuantityCode JoulePerCubicMetre = new QuantityCode { Value = "B8" };

    /// <summary>
    /// gigabit per second
    /// </summary>
    public static readonly QuantityCode GigabitPerSecond = new QuantityCode { Value = "B80" };

    /// <summary>
    /// reciprocal metre squared reciprocal second
    /// </summary>
    public static readonly QuantityCode ReciprocalMetreSquaredReciprocalSecond = new QuantityCode { Value = "B81" };

    /// <summary>
    /// inch per linear foot
    /// </summary>
    public static readonly QuantityCode InchPerLinearFoot = new QuantityCode { Value = "B82" };

    /// <summary>
    /// metre to the fourth power
    /// </summary>
    public static readonly QuantityCode MetreToTheFourthPower = new QuantityCode { Value = "B83" };

    /// <summary>
    /// microampere
    /// </summary>
    public static readonly QuantityCode Microampere = new QuantityCode { Value = "B84" };

    /// <summary>
    /// microbar
    /// </summary>
    public static readonly QuantityCode Microbar = new QuantityCode { Value = "B85" };

    /// <summary>
    /// microcoulomb
    /// </summary>
    public static readonly QuantityCode Microcoulomb = new QuantityCode { Value = "B86" };

    /// <summary>
    /// microcoulomb per cubic metre
    /// </summary>
    public static readonly QuantityCode MicrocoulombPerCubicMetre = new QuantityCode { Value = "B87" };

    /// <summary>
    /// microcoulomb per square metre
    /// </summary>
    public static readonly QuantityCode MicrocoulombPerSquareMetre = new QuantityCode { Value = "B88" };

    /// <summary>
    /// microfarad per metre
    /// </summary>
    public static readonly QuantityCode MicrofaradPerMetre = new QuantityCode { Value = "B89" };

    /// <summary>
    /// microhenry
    /// </summary>
    public static readonly QuantityCode Microhenry = new QuantityCode { Value = "B90" };

    /// <summary>
    /// microhenry per metre
    /// </summary>
    public static readonly QuantityCode MicrohenryPerMetre = new QuantityCode { Value = "B91" };

    /// <summary>
    /// micronewton
    /// </summary>
    public static readonly QuantityCode Micronewton = new QuantityCode { Value = "B92" };

    /// <summary>
    /// micronewton metre
    /// </summary>
    public static readonly QuantityCode MicronewtonMetre = new QuantityCode { Value = "B93" };

    /// <summary>
    /// microohm
    /// </summary>
    public static readonly QuantityCode Microohm = new QuantityCode { Value = "B94" };

    /// <summary>
    /// microohm metre
    /// </summary>
    public static readonly QuantityCode MicroohmMetre = new QuantityCode { Value = "B95" };

    /// <summary>
    /// micropascal
    /// </summary>
    public static readonly QuantityCode Micropascal = new QuantityCode { Value = "B96" };

    /// <summary>
    /// microradian
    /// </summary>
    public static readonly QuantityCode Microradian = new QuantityCode { Value = "B97" };

    /// <summary>
    /// microsecond
    /// </summary>
    public static readonly QuantityCode Microsecond = new QuantityCode { Value = "B98" };

    /// <summary>
    /// microsiemens
    /// </summary>
    public static readonly QuantityCode Microsiemens = new QuantityCode { Value = "B99" };

    /// <summary>
    /// bar [unit of pressure]
    /// </summary>
    public static readonly QuantityCode BarUnitOfPressure = new QuantityCode { Value = "BAR" };

    /// <summary>
    /// base box
    /// </summary>
    public static readonly QuantityCode BaseBox = new QuantityCode { Value = "BB" };

    /// <summary>
    /// board foot
    /// </summary>
    public static readonly QuantityCode BoardFoot = new QuantityCode { Value = "BFT" };

    /// <summary>
    /// brake horse power
    /// </summary>
    public static readonly QuantityCode BrakeHorsePower = new QuantityCode { Value = "BHP" };

    /// <summary>
    /// billion (EUR)
    /// </summary>
    public static readonly QuantityCode BillionEUR = new QuantityCode { Value = "BIL" };

    /// <summary>
    /// dry barrel (US)
    /// </summary>
    public static readonly QuantityCode DryBarrelUS = new QuantityCode { Value = "BLD" };

    /// <summary>
    /// barrel (US)
    /// </summary>
    public static readonly QuantityCode BarrelUS = new QuantityCode { Value = "BLL" };

    /// <summary>
    /// hundred board foot
    /// </summary>
    public static readonly QuantityCode HundredBoardFoot = new QuantityCode { Value = "BP" };

    /// <summary>
    /// beats per minute
    /// </summary>
    public static readonly QuantityCode BeatsPerMinute = new QuantityCode { Value = "BPM" };

    /// <summary>
    /// becquerel
    /// </summary>
    public static readonly QuantityCode Becquerel = new QuantityCode { Value = "BQL" };

    /// <summary>
    /// British thermal unit (international table)
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitInternationalTable = new QuantityCode { Value = "BTU" };

    /// <summary>
    /// bushel (US)
    /// </summary>
    public static readonly QuantityCode BushelUS = new QuantityCode { Value = "BUA" };

    /// <summary>
    /// bushel (UK)
    /// </summary>
    public static readonly QuantityCode BushelUK = new QuantityCode { Value = "BUI" };

    /// <summary>
    /// call
    /// </summary>
    public static readonly QuantityCode Call = new QuantityCode { Value = "C0" };

    /// <summary>
    /// millifarad
    /// </summary>
    public static readonly QuantityCode Millifarad = new QuantityCode { Value = "C10" };

    /// <summary>
    /// milligal
    /// </summary>
    public static readonly QuantityCode Milligal = new QuantityCode { Value = "C11" };

    /// <summary>
    /// milligram per metre
    /// </summary>
    public static readonly QuantityCode MilligramPerMetre = new QuantityCode { Value = "C12" };

    /// <summary>
    /// milligray
    /// </summary>
    public static readonly QuantityCode Milligray = new QuantityCode { Value = "C13" };

    /// <summary>
    /// millihenry
    /// </summary>
    public static readonly QuantityCode Millihenry = new QuantityCode { Value = "C14" };

    /// <summary>
    /// millijoule
    /// </summary>
    public static readonly QuantityCode Millijoule = new QuantityCode { Value = "C15" };

    /// <summary>
    /// millimetre per second
    /// </summary>
    public static readonly QuantityCode MillimetrePerSecond = new QuantityCode { Value = "C16" };

    /// <summary>
    /// millimetre squared per second
    /// </summary>
    public static readonly QuantityCode MillimetreSquaredPerSecond = new QuantityCode { Value = "C17" };

    /// <summary>
    /// millimole
    /// </summary>
    public static readonly QuantityCode Millimole = new QuantityCode { Value = "C18" };

    /// <summary>
    /// mole per kilogram
    /// </summary>
    public static readonly QuantityCode MolePerKilogram = new QuantityCode { Value = "C19" };

    /// <summary>
    /// millinewton
    /// </summary>
    public static readonly QuantityCode Millinewton = new QuantityCode { Value = "C20" };

    /// <summary>
    /// kibibit
    /// </summary>
    public static readonly QuantityCode Kibibit = new QuantityCode { Value = "C21" };

    /// <summary>
    /// millinewton per metre
    /// </summary>
    public static readonly QuantityCode MillinewtonPerMetre = new QuantityCode { Value = "C22" };

    /// <summary>
    /// milliohm metre
    /// </summary>
    public static readonly QuantityCode MilliohmMetre = new QuantityCode { Value = "C23" };

    /// <summary>
    /// millipascal second
    /// </summary>
    public static readonly QuantityCode MillipascalSecond = new QuantityCode { Value = "C24" };

    /// <summary>
    /// milliradian
    /// </summary>
    public static readonly QuantityCode Milliradian = new QuantityCode { Value = "C25" };

    /// <summary>
    /// millisecond
    /// </summary>
    public static readonly QuantityCode Millisecond = new QuantityCode { Value = "C26" };

    /// <summary>
    /// millisiemens
    /// </summary>
    public static readonly QuantityCode Millisiemens = new QuantityCode { Value = "C27" };

    /// <summary>
    /// millisievert
    /// </summary>
    public static readonly QuantityCode Millisievert = new QuantityCode { Value = "C28" };

    /// <summary>
    /// millitesla
    /// </summary>
    public static readonly QuantityCode Millitesla = new QuantityCode { Value = "C29" };

    /// <summary>
    /// microvolt per metre
    /// </summary>
    public static readonly QuantityCode MicrovoltPerMetre = new QuantityCode { Value = "C3" };

    /// <summary>
    /// millivolt per metre
    /// </summary>
    public static readonly QuantityCode MillivoltPerMetre = new QuantityCode { Value = "C30" };

    /// <summary>
    /// milliwatt
    /// </summary>
    public static readonly QuantityCode Milliwatt = new QuantityCode { Value = "C31" };

    /// <summary>
    /// milliwatt per square metre
    /// </summary>
    public static readonly QuantityCode MilliwattPerSquareMetre = new QuantityCode { Value = "C32" };

    /// <summary>
    /// milliweber
    /// </summary>
    public static readonly QuantityCode Milliweber = new QuantityCode { Value = "C33" };

    /// <summary>
    /// mole
    /// </summary>
    public static readonly QuantityCode Mole = new QuantityCode { Value = "C34" };

    /// <summary>
    /// mole per cubic decimetre
    /// </summary>
    public static readonly QuantityCode MolePerCubicDecimetre = new QuantityCode { Value = "C35" };

    /// <summary>
    /// mole per cubic metre
    /// </summary>
    public static readonly QuantityCode MolePerCubicMetre = new QuantityCode { Value = "C36" };

    /// <summary>
    /// kilobit
    /// </summary>
    public static readonly QuantityCode Kilobit = new QuantityCode { Value = "C37" };

    /// <summary>
    /// mole per litre
    /// </summary>
    public static readonly QuantityCode MolePerLitre = new QuantityCode { Value = "C38" };

    /// <summary>
    /// nanoampere
    /// </summary>
    public static readonly QuantityCode Nanoampere = new QuantityCode { Value = "C39" };

    /// <summary>
    /// nanocoulomb
    /// </summary>
    public static readonly QuantityCode Nanocoulomb = new QuantityCode { Value = "C40" };

    /// <summary>
    /// nanofarad
    /// </summary>
    public static readonly QuantityCode Nanofarad = new QuantityCode { Value = "C41" };

    /// <summary>
    /// nanofarad per metre
    /// </summary>
    public static readonly QuantityCode NanofaradPerMetre = new QuantityCode { Value = "C42" };

    /// <summary>
    /// nanohenry
    /// </summary>
    public static readonly QuantityCode Nanohenry = new QuantityCode { Value = "C43" };

    /// <summary>
    /// nanohenry per metre
    /// </summary>
    public static readonly QuantityCode NanohenryPerMetre = new QuantityCode { Value = "C44" };

    /// <summary>
    /// nanometre
    /// </summary>
    public static readonly QuantityCode Nanometre = new QuantityCode { Value = "C45" };

    /// <summary>
    /// nanoohm metre
    /// </summary>
    public static readonly QuantityCode NanoohmMetre = new QuantityCode { Value = "C46" };

    /// <summary>
    /// nanosecond
    /// </summary>
    public static readonly QuantityCode Nanosecond = new QuantityCode { Value = "C47" };

    /// <summary>
    /// nanotesla
    /// </summary>
    public static readonly QuantityCode Nanotesla = new QuantityCode { Value = "C48" };

    /// <summary>
    /// nanowatt
    /// </summary>
    public static readonly QuantityCode Nanowatt = new QuantityCode { Value = "C49" };

    /// <summary>
    /// neper
    /// </summary>
    public static readonly QuantityCode Neper = new QuantityCode { Value = "C50" };

    /// <summary>
    /// neper per second
    /// </summary>
    public static readonly QuantityCode NeperPerSecond = new QuantityCode { Value = "C51" };

    /// <summary>
    /// picometre
    /// </summary>
    public static readonly QuantityCode Picometre = new QuantityCode { Value = "C52" };

    /// <summary>
    /// newton metre second
    /// </summary>
    public static readonly QuantityCode NewtonMetreSecond = new QuantityCode { Value = "C53" };

    /// <summary>
    /// newton metre squared per kilogram squared
    /// </summary>
    public static readonly QuantityCode NewtonMetreSquaredPerKilogramSquared = new QuantityCode { Value = "C54" };

    /// <summary>
    /// newton per square metre
    /// </summary>
    public static readonly QuantityCode NewtonPerSquareMetre = new QuantityCode { Value = "C55" };

    /// <summary>
    /// newton per square millimetre
    /// </summary>
    public static readonly QuantityCode NewtonPerSquareMillimetre = new QuantityCode { Value = "C56" };

    /// <summary>
    /// newton second
    /// </summary>
    public static readonly QuantityCode NewtonSecond = new QuantityCode { Value = "C57" };

    /// <summary>
    /// newton second per metre
    /// </summary>
    public static readonly QuantityCode NewtonSecondPerMetre = new QuantityCode { Value = "C58" };

    /// <summary>
    /// octave
    /// </summary>
    public static readonly QuantityCode Octave = new QuantityCode { Value = "C59" };

    /// <summary>
    /// ohm centimetre
    /// </summary>
    public static readonly QuantityCode OhmCentimetre = new QuantityCode { Value = "C60" };

    /// <summary>
    /// ohm metre
    /// </summary>
    public static readonly QuantityCode OhmMetre = new QuantityCode { Value = "C61" };

    /// <summary>
    /// one
    /// </summary>
    public static readonly QuantityCode One = new QuantityCode { Value = "C62" };

    /// <summary>
    /// parsec
    /// </summary>
    public static readonly QuantityCode Parsec = new QuantityCode { Value = "C63" };

    /// <summary>
    /// pascal per kelvin
    /// </summary>
    public static readonly QuantityCode PascalPerKelvin = new QuantityCode { Value = "C64" };

    /// <summary>
    /// pascal second
    /// </summary>
    public static readonly QuantityCode PascalSecond = new QuantityCode { Value = "C65" };

    /// <summary>
    /// pascal second per cubic metre
    /// </summary>
    public static readonly QuantityCode PascalSecondPerCubicMetre = new QuantityCode { Value = "C66" };

    /// <summary>
    /// pascal second per metre
    /// </summary>
    public static readonly QuantityCode PascalSecondPerMetre = new QuantityCode { Value = "C67" };

    /// <summary>
    /// petajoule
    /// </summary>
    public static readonly QuantityCode Petajoule = new QuantityCode { Value = "C68" };

    /// <summary>
    /// phon
    /// </summary>
    public static readonly QuantityCode Phon = new QuantityCode { Value = "C69" };

    /// <summary>
    /// centipoise
    /// </summary>
    public static readonly QuantityCode Centipoise = new QuantityCode { Value = "C7" };

    /// <summary>
    /// picoampere
    /// </summary>
    public static readonly QuantityCode Picoampere = new QuantityCode { Value = "C70" };

    /// <summary>
    /// picocoulomb
    /// </summary>
    public static readonly QuantityCode Picocoulomb = new QuantityCode { Value = "C71" };

    /// <summary>
    /// picofarad per metre
    /// </summary>
    public static readonly QuantityCode PicofaradPerMetre = new QuantityCode { Value = "C72" };

    /// <summary>
    /// picohenry
    /// </summary>
    public static readonly QuantityCode Picohenry = new QuantityCode { Value = "C73" };

    /// <summary>
    /// kilobit per second
    /// </summary>
    public static readonly QuantityCode KilobitPerSecond = new QuantityCode { Value = "C74" };

    /// <summary>
    /// picowatt
    /// </summary>
    public static readonly QuantityCode Picowatt = new QuantityCode { Value = "C75" };

    /// <summary>
    /// picowatt per square metre
    /// </summary>
    public static readonly QuantityCode PicowattPerSquareMetre = new QuantityCode { Value = "C76" };

    /// <summary>
    /// pound-force
    /// </summary>
    public static readonly QuantityCode PoundForce = new QuantityCode { Value = "C78" };

    /// <summary>
    /// kilovolt ampere hour
    /// </summary>
    public static readonly QuantityCode KilovoltAmpereHour = new QuantityCode { Value = "C79" };

    /// <summary>
    /// millicoulomb per kilogram
    /// </summary>
    public static readonly QuantityCode MillicoulombPerKilogram = new QuantityCode { Value = "C8" };

    /// <summary>
    /// rad
    /// </summary>
    public static readonly QuantityCode Rad = new QuantityCode { Value = "C80" };

    /// <summary>
    /// radian
    /// </summary>
    public static readonly QuantityCode Radian = new QuantityCode { Value = "C81" };

    /// <summary>
    /// radian square metre per mole
    /// </summary>
    public static readonly QuantityCode RadianSquareMetrePerMole = new QuantityCode { Value = "C82" };

    /// <summary>
    /// radian square metre per kilogram
    /// </summary>
    public static readonly QuantityCode RadianSquareMetrePerKilogram = new QuantityCode { Value = "C83" };

    /// <summary>
    /// radian per metre
    /// </summary>
    public static readonly QuantityCode RadianPerMetre = new QuantityCode { Value = "C84" };

    /// <summary>
    /// reciprocal angstrom
    /// </summary>
    public static readonly QuantityCode ReciprocalAngstrom = new QuantityCode { Value = "C85" };

    /// <summary>
    /// reciprocal cubic metre
    /// </summary>
    public static readonly QuantityCode ReciprocalCubicMetre = new QuantityCode { Value = "C86" };

    /// <summary>
    /// reciprocal cubic metre per second
    /// </summary>
    public static readonly QuantityCode ReciprocalCubicMetrePerSecond = new QuantityCode { Value = "C87" };

    /// <summary>
    /// reciprocal electron volt per cubic metre
    /// </summary>
    public static readonly QuantityCode ReciprocalElectronVoltPerCubicMetre = new QuantityCode { Value = "C88" };

    /// <summary>
    /// reciprocal henry
    /// </summary>
    public static readonly QuantityCode ReciprocalHenry = new QuantityCode { Value = "C89" };

    /// <summary>
    /// coil group
    /// </summary>
    public static readonly QuantityCode CoilGroup = new QuantityCode { Value = "C9" };

    /// <summary>
    /// reciprocal joule per cubic metre
    /// </summary>
    public static readonly QuantityCode ReciprocalJoulePerCubicMetre = new QuantityCode { Value = "C90" };

    /// <summary>
    /// reciprocal kelvin or kelvin to the power minus one
    /// </summary>
    public static readonly QuantityCode ReciprocalKelvinOrKelvinToThePowerMinusOne = new QuantityCode { Value = "C91" };

    /// <summary>
    /// reciprocal metre
    /// </summary>
    public static readonly QuantityCode ReciprocalMetre = new QuantityCode { Value = "C92" };

    /// <summary>
    /// reciprocal square metre
    /// </summary>
    public static readonly QuantityCode ReciprocalSquareMetre = new QuantityCode { Value = "C93" };

    /// <summary>
    /// reciprocal minute
    /// </summary>
    public static readonly QuantityCode ReciprocalMinute = new QuantityCode { Value = "C94" };

    /// <summary>
    /// reciprocal mole
    /// </summary>
    public static readonly QuantityCode ReciprocalMole = new QuantityCode { Value = "C95" };

    /// <summary>
    /// reciprocal pascal or pascal to the power minus one
    /// </summary>
    public static readonly QuantityCode ReciprocalPascalOrPascalToThePowerMinusOne = new QuantityCode { Value = "C96" };

    /// <summary>
    /// reciprocal second
    /// </summary>
    public static readonly QuantityCode ReciprocalSecond = new QuantityCode { Value = "C97" };

    /// <summary>
    /// reciprocal second per metre squared
    /// </summary>
    public static readonly QuantityCode ReciprocalSecondPerMetreSquared = new QuantityCode { Value = "C99" };

    /// <summary>
    /// carrying capacity in metric ton
    /// </summary>
    public static readonly QuantityCode CarryingCapacityInMetricTon = new QuantityCode { Value = "CCT" };

    /// <summary>
    /// candela
    /// </summary>
    public static readonly QuantityCode Candela = new QuantityCode { Value = "CDL" };

    /// <summary>
    /// degree Celsius
    /// </summary>
    public static readonly QuantityCode DegreeCelsius = new QuantityCode { Value = "CEL" };

    /// <summary>
    /// hundred
    /// </summary>
    public static readonly QuantityCode Hundred = new QuantityCode { Value = "CEN" };

    /// <summary>
    /// card
    /// </summary>
    public static readonly QuantityCode Card = new QuantityCode { Value = "CG" };

    /// <summary>
    /// centigram
    /// </summary>
    public static readonly QuantityCode Centigram = new QuantityCode { Value = "CGM" };

    /// <summary>
    /// coulomb per kilogram
    /// </summary>
    public static readonly QuantityCode CoulombPerKilogram = new QuantityCode { Value = "CKG" };

    /// <summary>
    /// hundred leave
    /// </summary>
    public static readonly QuantityCode HundredLeave = new QuantityCode { Value = "CLF" };

    /// <summary>
    /// centilitre
    /// </summary>
    public static readonly QuantityCode Centilitre = new QuantityCode { Value = "CLT" };

    /// <summary>
    /// square centimetre
    /// </summary>
    public static readonly QuantityCode SquareCentimetre = new QuantityCode { Value = "CMK" };

    /// <summary>
    /// cubic centimetre
    /// </summary>
    public static readonly QuantityCode CubicCentimetre = new QuantityCode { Value = "CMQ" };

    /// <summary>
    /// centimetre
    /// </summary>
    public static readonly QuantityCode Centimetre = new QuantityCode { Value = "CMT" };

    /// <summary>
    /// hundred pack
    /// </summary>
    public static readonly QuantityCode HundredPack = new QuantityCode { Value = "CNP" };

    /// <summary>
    /// cental (UK)
    /// </summary>
    public static readonly QuantityCode CentalUK = new QuantityCode { Value = "CNT" };

    /// <summary>
    /// coulomb
    /// </summary>
    public static readonly QuantityCode Coulomb = new QuantityCode { Value = "COU" };

    /// <summary>
    /// content gram
    /// </summary>
    public static readonly QuantityCode ContentGram = new QuantityCode { Value = "CTG" };

    /// <summary>
    /// metric carat
    /// </summary>
    public static readonly QuantityCode MetricCarat = new QuantityCode { Value = "CTM" };

    /// <summary>
    /// content ton (metric)
    /// </summary>
    public static readonly QuantityCode ContentTonMetric = new QuantityCode { Value = "CTN" };

    /// <summary>
    /// curie
    /// </summary>
    public static readonly QuantityCode Curie = new QuantityCode { Value = "CUR" };

    /// <summary>
    /// hundred pound (cwt) / hundred weight (US)
    /// </summary>
    public static readonly QuantityCode HundredPoundCwtHundredWeightUS = new QuantityCode { Value = "CWA" };

    /// <summary>
    /// hundred weight (UK)
    /// </summary>
    public static readonly QuantityCode HundredWeightUK = new QuantityCode { Value = "CWI" };

    /// <summary>
    /// kilowatt hour per hour
    /// </summary>
    public static readonly QuantityCode KilowattHourPerHour = new QuantityCode { Value = "D03" };

    /// <summary>
    /// lot [unit of weight]
    /// </summary>
    public static readonly QuantityCode LotUnitOfWeight = new QuantityCode { Value = "D04" };

    /// <summary>
    /// reciprocal second per steradian
    /// </summary>
    public static readonly QuantityCode ReciprocalSecondPerSteradian = new QuantityCode { Value = "D1" };

    /// <summary>
    /// siemens per metre
    /// </summary>
    public static readonly QuantityCode SiemensPerMetre = new QuantityCode { Value = "D10" };

    /// <summary>
    /// mebibit
    /// </summary>
    public static readonly QuantityCode Mebibit = new QuantityCode { Value = "D11" };

    /// <summary>
    /// siemens square metre per mole
    /// </summary>
    public static readonly QuantityCode SiemensSquareMetrePerMole = new QuantityCode { Value = "D12" };

    /// <summary>
    /// sievert
    /// </summary>
    public static readonly QuantityCode Sievert = new QuantityCode { Value = "D13" };

    /// <summary>
    /// sone
    /// </summary>
    public static readonly QuantityCode Sone = new QuantityCode { Value = "D15" };

    /// <summary>
    /// square centimetre per erg
    /// </summary>
    public static readonly QuantityCode SquareCentimetrePerErg = new QuantityCode { Value = "D16" };

    /// <summary>
    /// square centimetre per steradian erg
    /// </summary>
    public static readonly QuantityCode SquareCentimetrePerSteradianErg = new QuantityCode { Value = "D17" };

    /// <summary>
    /// metre kelvin
    /// </summary>
    public static readonly QuantityCode MetreKelvin = new QuantityCode { Value = "D18" };

    /// <summary>
    /// square metre kelvin per watt
    /// </summary>
    public static readonly QuantityCode SquareMetreKelvinPerWatt = new QuantityCode { Value = "D19" };

    /// <summary>
    /// reciprocal second per steradian metre squared
    /// </summary>
    public static readonly QuantityCode ReciprocalSecondPerSteradianMetreSquared = new QuantityCode { Value = "D2" };

    /// <summary>
    /// square metre per joule
    /// </summary>
    public static readonly QuantityCode SquareMetrePerJoule = new QuantityCode { Value = "D20" };

    /// <summary>
    /// square metre per kilogram
    /// </summary>
    public static readonly QuantityCode SquareMetrePerKilogram = new QuantityCode { Value = "D21" };

    /// <summary>
    /// square metre per mole
    /// </summary>
    public static readonly QuantityCode SquareMetrePerMole = new QuantityCode { Value = "D22" };

    /// <summary>
    /// pen gram (protein)
    /// </summary>
    public static readonly QuantityCode PenGramProtein = new QuantityCode { Value = "D23" };

    /// <summary>
    /// square metre per steradian
    /// </summary>
    public static readonly QuantityCode SquareMetrePerSteradian = new QuantityCode { Value = "D24" };

    /// <summary>
    /// square metre per steradian joule
    /// </summary>
    public static readonly QuantityCode SquareMetrePerSteradianJoule = new QuantityCode { Value = "D25" };

    /// <summary>
    /// square metre per volt second
    /// </summary>
    public static readonly QuantityCode SquareMetrePerVoltSecond = new QuantityCode { Value = "D26" };

    /// <summary>
    /// steradian
    /// </summary>
    public static readonly QuantityCode Steradian = new QuantityCode { Value = "D27" };

    /// <summary>
    /// terahertz
    /// </summary>
    public static readonly QuantityCode Terahertz = new QuantityCode { Value = "D29" };

    /// <summary>
    /// terajoule
    /// </summary>
    public static readonly QuantityCode Terajoule = new QuantityCode { Value = "D30" };

    /// <summary>
    /// terawatt
    /// </summary>
    public static readonly QuantityCode Terawatt = new QuantityCode { Value = "D31" };

    /// <summary>
    /// terawatt hour
    /// </summary>
    public static readonly QuantityCode TerawattHour = new QuantityCode { Value = "D32" };

    /// <summary>
    /// tesla
    /// </summary>
    public static readonly QuantityCode Tesla = new QuantityCode { Value = "D33" };

    /// <summary>
    /// tex
    /// </summary>
    public static readonly QuantityCode Tex = new QuantityCode { Value = "D34" };

    /// <summary>
    /// megabit
    /// </summary>
    public static readonly QuantityCode Megabit = new QuantityCode { Value = "D36" };

    /// <summary>
    /// tonne per cubic metre
    /// </summary>
    public static readonly QuantityCode TonnePerCubicMetre = new QuantityCode { Value = "D41" };

    /// <summary>
    /// tropical year
    /// </summary>
    public static readonly QuantityCode TropicalYear = new QuantityCode { Value = "D42" };

    /// <summary>
    /// unified atomic mass unit
    /// </summary>
    public static readonly QuantityCode UnifiedAtomicMassUnit = new QuantityCode { Value = "D43" };

    /// <summary>
    /// var
    /// </summary>
    public static readonly QuantityCode Var = new QuantityCode { Value = "D44" };

    /// <summary>
    /// volt squared per kelvin squared
    /// </summary>
    public static readonly QuantityCode VoltSquaredPerKelvinSquared = new QuantityCode { Value = "D45" };

    /// <summary>
    /// volt - ampere
    /// </summary>
    public static readonly QuantityCode VoltAmpere = new QuantityCode { Value = "D46" };

    /// <summary>
    /// volt per centimetre
    /// </summary>
    public static readonly QuantityCode VoltPerCentimetre = new QuantityCode { Value = "D47" };

    /// <summary>
    /// volt per kelvin
    /// </summary>
    public static readonly QuantityCode VoltPerKelvin = new QuantityCode { Value = "D48" };

    /// <summary>
    /// millivolt per kelvin
    /// </summary>
    public static readonly QuantityCode MillivoltPerKelvin = new QuantityCode { Value = "D49" };

    /// <summary>
    /// kilogram per square centimetre
    /// </summary>
    public static readonly QuantityCode KilogramPerSquareCentimetre = new QuantityCode { Value = "D5" };

    /// <summary>
    /// volt per metre
    /// </summary>
    public static readonly QuantityCode VoltPerMetre = new QuantityCode { Value = "D50" };

    /// <summary>
    /// volt per millimetre
    /// </summary>
    public static readonly QuantityCode VoltPerMillimetre = new QuantityCode { Value = "D51" };

    /// <summary>
    /// watt per kelvin
    /// </summary>
    public static readonly QuantityCode WattPerKelvin = new QuantityCode { Value = "D52" };

    /// <summary>
    /// watt per metre kelvin
    /// </summary>
    public static readonly QuantityCode WattPerMetreKelvin = new QuantityCode { Value = "D53" };

    /// <summary>
    /// watt per square metre
    /// </summary>
    public static readonly QuantityCode WattPerSquareMetre = new QuantityCode { Value = "D54" };

    /// <summary>
    /// watt per square metre kelvin
    /// </summary>
    public static readonly QuantityCode WattPerSquareMetreKelvin = new QuantityCode { Value = "D55" };

    /// <summary>
    /// watt per square metre kelvin to the fourth power
    /// </summary>
    public static readonly QuantityCode WattPerSquareMetreKelvinToTheFourthPower = new QuantityCode { Value = "D56" };

    /// <summary>
    /// watt per steradian
    /// </summary>
    public static readonly QuantityCode WattPerSteradian = new QuantityCode { Value = "D57" };

    /// <summary>
    /// watt per steradian square metre
    /// </summary>
    public static readonly QuantityCode WattPerSteradianSquareMetre = new QuantityCode { Value = "D58" };

    /// <summary>
    /// weber per metre
    /// </summary>
    public static readonly QuantityCode WeberPerMetre = new QuantityCode { Value = "D59" };

    /// <summary>
    /// roentgen per second
    /// </summary>
    public static readonly QuantityCode RoentgenPerSecond = new QuantityCode { Value = "D6" };

    /// <summary>
    /// weber per millimetre
    /// </summary>
    public static readonly QuantityCode WeberPerMillimetre = new QuantityCode { Value = "D60" };

    /// <summary>
    /// minute [unit of angle]
    /// </summary>
    public static readonly QuantityCode MinuteUnitOfAngle = new QuantityCode { Value = "D61" };

    /// <summary>
    /// second [unit of angle]
    /// </summary>
    public static readonly QuantityCode SecondUnitOfAngle = new QuantityCode { Value = "D62" };

    /// <summary>
    /// book
    /// </summary>
    public static readonly QuantityCode Book = new QuantityCode { Value = "D63" };

    /// <summary>
    /// round
    /// </summary>
    public static readonly QuantityCode Round = new QuantityCode { Value = "D65" };

    /// <summary>
    /// number of words
    /// </summary>
    public static readonly QuantityCode NumberOfWords = new QuantityCode { Value = "D68" };

    /// <summary>
    /// inch to the fourth power
    /// </summary>
    public static readonly QuantityCode InchToTheFourthPower = new QuantityCode { Value = "D69" };

    /// <summary>
    /// joule square metre
    /// </summary>
    public static readonly QuantityCode JouleSquareMetre = new QuantityCode { Value = "D73" };

    /// <summary>
    /// kilogram per mole
    /// </summary>
    public static readonly QuantityCode KilogramPerMole = new QuantityCode { Value = "D74" };

    /// <summary>
    /// megacoulomb
    /// </summary>
    public static readonly QuantityCode Megacoulomb = new QuantityCode { Value = "D77" };

    /// <summary>
    /// megajoule per second
    /// </summary>
    public static readonly QuantityCode MegajoulePerSecond = new QuantityCode { Value = "D78" };

    /// <summary>
    /// microwatt
    /// </summary>
    public static readonly QuantityCode Microwatt = new QuantityCode { Value = "D80" };

    /// <summary>
    /// microtesla
    /// </summary>
    public static readonly QuantityCode Microtesla = new QuantityCode { Value = "D81" };

    /// <summary>
    /// microvolt
    /// </summary>
    public static readonly QuantityCode Microvolt = new QuantityCode { Value = "D82" };

    /// <summary>
    /// millinewton metre
    /// </summary>
    public static readonly QuantityCode MillinewtonMetre = new QuantityCode { Value = "D83" };

    /// <summary>
    /// microwatt per square metre
    /// </summary>
    public static readonly QuantityCode MicrowattPerSquareMetre = new QuantityCode { Value = "D85" };

    /// <summary>
    /// millicoulomb
    /// </summary>
    public static readonly QuantityCode Millicoulomb = new QuantityCode { Value = "D86" };

    /// <summary>
    /// millimole per kilogram
    /// </summary>
    public static readonly QuantityCode MillimolePerKilogram = new QuantityCode { Value = "D87" };

    /// <summary>
    /// millicoulomb per cubic metre
    /// </summary>
    public static readonly QuantityCode MillicoulombPerCubicMetre = new QuantityCode { Value = "D88" };

    /// <summary>
    /// millicoulomb per square metre
    /// </summary>
    public static readonly QuantityCode MillicoulombPerSquareMetre = new QuantityCode { Value = "D89" };

    /// <summary>
    /// rem
    /// </summary>
    public static readonly QuantityCode Rem = new QuantityCode { Value = "D91" };

    /// <summary>
    /// second per cubic metre
    /// </summary>
    public static readonly QuantityCode SecondPerCubicMetre = new QuantityCode { Value = "D93" };

    /// <summary>
    /// second per cubic metre radian
    /// </summary>
    public static readonly QuantityCode SecondPerCubicMetreRadian = new QuantityCode { Value = "D94" };

    /// <summary>
    /// joule per gram
    /// </summary>
    public static readonly QuantityCode JoulePerGram = new QuantityCode { Value = "D95" };

    /// <summary>
    /// decare
    /// </summary>
    public static readonly QuantityCode Decare = new QuantityCode { Value = "DAA" };

    /// <summary>
    /// ten day
    /// </summary>
    public static readonly QuantityCode TenDay = new QuantityCode { Value = "DAD" };

    /// <summary>
    /// day
    /// </summary>
    public static readonly QuantityCode Day = new QuantityCode { Value = "DAY" };

    /// <summary>
    /// dry pound
    /// </summary>
    public static readonly QuantityCode DryPound = new QuantityCode { Value = "DB" };

    /// <summary>
    /// Decibel-milliwatts
    /// </summary>
    public static readonly QuantityCode DecibelMilliwatts = new QuantityCode { Value = "DBM" };

    /// <summary>
    /// Decibel watt
    /// </summary>
    public static readonly QuantityCode DecibelWatt = new QuantityCode { Value = "DBW" };

    /// <summary>
    /// degree [unit of angle]
    /// </summary>
    public static readonly QuantityCode DegreeUnitOfAngle = new QuantityCode { Value = "DD" };

    /// <summary>
    /// decade
    /// </summary>
    public static readonly QuantityCode Decade = new QuantityCode { Value = "DEC" };

    /// <summary>
    /// decigram
    /// </summary>
    public static readonly QuantityCode Decigram = new QuantityCode { Value = "DG" };

    /// <summary>
    /// decagram
    /// </summary>
    public static readonly QuantityCode Decagram = new QuantityCode { Value = "DJ" };

    /// <summary>
    /// decilitre
    /// </summary>
    public static readonly QuantityCode Decilitre = new QuantityCode { Value = "DLT" };

    /// <summary>
    /// cubic decametre
    /// </summary>
    public static readonly QuantityCode CubicDecametre = new QuantityCode { Value = "DMA" };

    /// <summary>
    /// square decimetre
    /// </summary>
    public static readonly QuantityCode SquareDecimetre = new QuantityCode { Value = "DMK" };

    /// <summary>
    /// standard kilolitre
    /// </summary>
    public static readonly QuantityCode StandardKilolitre = new QuantityCode { Value = "DMO" };

    /// <summary>
    /// cubic decimetre
    /// </summary>
    public static readonly QuantityCode CubicDecimetre = new QuantityCode { Value = "DMQ" };

    /// <summary>
    /// decimetre
    /// </summary>
    public static readonly QuantityCode Decimetre = new QuantityCode { Value = "DMT" };

    /// <summary>
    /// decinewton metre
    /// </summary>
    public static readonly QuantityCode DecinewtonMetre = new QuantityCode { Value = "DN" };

    /// <summary>
    /// dozen piece
    /// </summary>
    public static readonly QuantityCode DozenPiece = new QuantityCode { Value = "DPC" };

    /// <summary>
    /// dozen pair
    /// </summary>
    public static readonly QuantityCode DozenPair = new QuantityCode { Value = "DPR" };

    /// <summary>
    /// displacement tonnage
    /// </summary>
    public static readonly QuantityCode DisplacementTonnage = new QuantityCode { Value = "DPT" };

    /// <summary>
    /// dram (US)
    /// </summary>
    public static readonly QuantityCode DramUS = new QuantityCode { Value = "DRA" };

    /// <summary>
    /// dram (UK)
    /// </summary>
    public static readonly QuantityCode DramUK = new QuantityCode { Value = "DRI" };

    /// <summary>
    /// dozen roll
    /// </summary>
    public static readonly QuantityCode DozenRoll = new QuantityCode { Value = "DRL" };

    /// <summary>
    /// dry ton
    /// </summary>
    public static readonly QuantityCode DryTon = new QuantityCode { Value = "DT" };

    /// <summary>
    /// decitonne
    /// </summary>
    public static readonly QuantityCode Decitonne = new QuantityCode { Value = "DTN" };

    /// <summary>
    /// pennyweight
    /// </summary>
    public static readonly QuantityCode Pennyweight = new QuantityCode { Value = "DWT" };

    /// <summary>
    /// dozen
    /// </summary>
    public static readonly QuantityCode Dozen = new QuantityCode { Value = "DZN" };

    /// <summary>
    /// dozen pack
    /// </summary>
    public static readonly QuantityCode DozenPack = new QuantityCode { Value = "DZP" };

    /// <summary>
    /// newton per square centimetre
    /// </summary>
    public static readonly QuantityCode NewtonPerSquareCentimetre = new QuantityCode { Value = "E01" };

    /// <summary>
    /// megawatt hour per hour
    /// </summary>
    public static readonly QuantityCode MegawattHourPerHour = new QuantityCode { Value = "E07" };

    /// <summary>
    /// megawatt per hertz
    /// </summary>
    public static readonly QuantityCode MegawattPerHertz = new QuantityCode { Value = "E08" };

    /// <summary>
    /// milliampere hour
    /// </summary>
    public static readonly QuantityCode MilliampereHour = new QuantityCode { Value = "E09" };

    /// <summary>
    /// degree day
    /// </summary>
    public static readonly QuantityCode DegreeDay = new QuantityCode { Value = "E10" };

    /// <summary>
    /// mille
    /// </summary>
    public static readonly QuantityCode Mille = new QuantityCode { Value = "E12" };

    /// <summary>
    /// kilocalorie (international table)
    /// </summary>
    public static readonly QuantityCode KilocalorieInternationalTable = new QuantityCode { Value = "E14" };

    /// <summary>
    /// kilocalorie (thermochemical) per hour
    /// </summary>
    public static readonly QuantityCode KilocalorieThermochemicalPerHour = new QuantityCode { Value = "E15" };

    /// <summary>
    /// million Btu(IT) per hour
    /// </summary>
    public static readonly QuantityCode MillionBtuITPerHour = new QuantityCode { Value = "E16" };

    /// <summary>
    /// cubic foot per second
    /// </summary>
    public static readonly QuantityCode CubicFootPerSecond = new QuantityCode { Value = "E17" };

    /// <summary>
    /// tonne per hour
    /// </summary>
    public static readonly QuantityCode TonnePerHour = new QuantityCode { Value = "E18" };

    /// <summary>
    /// ping
    /// </summary>
    public static readonly QuantityCode Ping = new QuantityCode { Value = "E19" };

    /// <summary>
    /// megabit per second
    /// </summary>
    public static readonly QuantityCode MegabitPerSecond = new QuantityCode { Value = "E20" };

    /// <summary>
    /// shares
    /// </summary>
    public static readonly QuantityCode Shares = new QuantityCode { Value = "E21" };

    /// <summary>
    /// TEU
    /// </summary>
    public static readonly QuantityCode TEU = new QuantityCode { Value = "E22" };

    /// <summary>
    /// tyre
    /// </summary>
    public static readonly QuantityCode Tyre = new QuantityCode { Value = "E23" };

    /// <summary>
    /// active unit
    /// </summary>
    public static readonly QuantityCode ActiveUnit = new QuantityCode { Value = "E25" };

    /// <summary>
    /// dose
    /// </summary>
    public static readonly QuantityCode Dose = new QuantityCode { Value = "E27" };

    /// <summary>
    /// air dry ton
    /// </summary>
    public static readonly QuantityCode AirDryTon = new QuantityCode { Value = "E28" };

    /// <summary>
    /// strand
    /// </summary>
    public static readonly QuantityCode Strand = new QuantityCode { Value = "E30" };

    /// <summary>
    /// square metre per litre
    /// </summary>
    public static readonly QuantityCode SquareMetrePerLitre = new QuantityCode { Value = "E31" };

    /// <summary>
    /// litre per hour
    /// </summary>
    public static readonly QuantityCode LitrePerHour = new QuantityCode { Value = "E32" };

    /// <summary>
    /// foot per thousand
    /// </summary>
    public static readonly QuantityCode FootPerThousand = new QuantityCode { Value = "E33" };

    /// <summary>
    /// gigabyte
    /// </summary>
    public static readonly QuantityCode Gigabyte = new QuantityCode { Value = "E34" };

    /// <summary>
    /// terabyte
    /// </summary>
    public static readonly QuantityCode Terabyte = new QuantityCode { Value = "E35" };

    /// <summary>
    /// petabyte
    /// </summary>
    public static readonly QuantityCode Petabyte = new QuantityCode { Value = "E36" };

    /// <summary>
    /// pixel
    /// </summary>
    public static readonly QuantityCode Pixel = new QuantityCode { Value = "E37" };

    /// <summary>
    /// megapixel
    /// </summary>
    public static readonly QuantityCode Megapixel = new QuantityCode { Value = "E38" };

    /// <summary>
    /// dots per inch
    /// </summary>
    public static readonly QuantityCode DotsPerInch = new QuantityCode { Value = "E39" };

    /// <summary>
    /// gross kilogram
    /// </summary>
    public static readonly QuantityCode GrossKilogram = new QuantityCode { Value = "E4" };

    /// <summary>
    /// part per hundred thousand
    /// </summary>
    public static readonly QuantityCode PartPerHundredThousand = new QuantityCode { Value = "E40" };

    /// <summary>
    /// kilogram-force per square millimetre
    /// </summary>
    public static readonly QuantityCode KilogramForcePerSquareMillimetre = new QuantityCode { Value = "E41" };

    /// <summary>
    /// kilogram-force per square centimetre
    /// </summary>
    public static readonly QuantityCode KilogramForcePerSquareCentimetre = new QuantityCode { Value = "E42" };

    /// <summary>
    /// joule per square centimetre
    /// </summary>
    public static readonly QuantityCode JoulePerSquareCentimetre = new QuantityCode { Value = "E43" };

    /// <summary>
    /// kilogram-force metre per square centimetre
    /// </summary>
    public static readonly QuantityCode KilogramForceMetrePerSquareCentimetre = new QuantityCode { Value = "E44" };

    /// <summary>
    /// milliohm
    /// </summary>
    public static readonly QuantityCode Milliohm = new QuantityCode { Value = "E45" };

    /// <summary>
    /// kilowatt hour per cubic metre
    /// </summary>
    public static readonly QuantityCode KilowattHourPerCubicMetre = new QuantityCode { Value = "E46" };

    /// <summary>
    /// kilowatt hour per kelvin
    /// </summary>
    public static readonly QuantityCode KilowattHourPerKelvin = new QuantityCode { Value = "E47" };

    /// <summary>
    /// service unit
    /// </summary>
    public static readonly QuantityCode ServiceUnit = new QuantityCode { Value = "E48" };

    /// <summary>
    /// working day
    /// </summary>
    public static readonly QuantityCode WorkingDay = new QuantityCode { Value = "E49" };

    /// <summary>
    /// accounting unit
    /// </summary>
    public static readonly QuantityCode AccountingUnit = new QuantityCode { Value = "E50" };

    /// <summary>
    /// job
    /// </summary>
    public static readonly QuantityCode Job = new QuantityCode { Value = "E51" };

    /// <summary>
    /// run foot
    /// </summary>
    public static readonly QuantityCode RunFoot = new QuantityCode { Value = "E52" };

    /// <summary>
    /// test
    /// </summary>
    public static readonly QuantityCode Test = new QuantityCode { Value = "E53" };

    /// <summary>
    /// trip
    /// </summary>
    public static readonly QuantityCode Trip = new QuantityCode { Value = "E54" };

    /// <summary>
    /// use
    /// </summary>
    public static readonly QuantityCode Use = new QuantityCode { Value = "E55" };

    /// <summary>
    /// well
    /// </summary>
    public static readonly QuantityCode Well = new QuantityCode { Value = "E56" };

    /// <summary>
    /// zone
    /// </summary>
    public static readonly QuantityCode Zone = new QuantityCode { Value = "E57" };

    /// <summary>
    /// exabit per second
    /// </summary>
    public static readonly QuantityCode ExabitPerSecond = new QuantityCode { Value = "E58" };

    /// <summary>
    /// exbibyte
    /// </summary>
    public static readonly QuantityCode Exbibyte = new QuantityCode { Value = "E59" };

    /// <summary>
    /// pebibyte
    /// </summary>
    public static readonly QuantityCode Pebibyte = new QuantityCode { Value = "E60" };

    /// <summary>
    /// tebibyte
    /// </summary>
    public static readonly QuantityCode Tebibyte = new QuantityCode { Value = "E61" };

    /// <summary>
    /// gibibyte
    /// </summary>
    public static readonly QuantityCode Gibibyte = new QuantityCode { Value = "E62" };

    /// <summary>
    /// mebibyte
    /// </summary>
    public static readonly QuantityCode Mebibyte = new QuantityCode { Value = "E63" };

    /// <summary>
    /// kibibyte
    /// </summary>
    public static readonly QuantityCode Kibibyte = new QuantityCode { Value = "E64" };

    /// <summary>
    /// exbibit per metre
    /// </summary>
    public static readonly QuantityCode ExbibitPerMetre = new QuantityCode { Value = "E65" };

    /// <summary>
    /// exbibit per square metre
    /// </summary>
    public static readonly QuantityCode ExbibitPerSquareMetre = new QuantityCode { Value = "E66" };

    /// <summary>
    /// exbibit per cubic metre
    /// </summary>
    public static readonly QuantityCode ExbibitPerCubicMetre = new QuantityCode { Value = "E67" };

    /// <summary>
    /// gigabyte per second
    /// </summary>
    public static readonly QuantityCode GigabytePerSecond = new QuantityCode { Value = "E68" };

    /// <summary>
    /// gibibit per metre
    /// </summary>
    public static readonly QuantityCode GibibitPerMetre = new QuantityCode { Value = "E69" };

    /// <summary>
    /// gibibit per square metre
    /// </summary>
    public static readonly QuantityCode GibibitPerSquareMetre = new QuantityCode { Value = "E70" };

    /// <summary>
    /// gibibit per cubic metre
    /// </summary>
    public static readonly QuantityCode GibibitPerCubicMetre = new QuantityCode { Value = "E71" };

    /// <summary>
    /// kibibit per metre
    /// </summary>
    public static readonly QuantityCode KibibitPerMetre = new QuantityCode { Value = "E72" };

    /// <summary>
    /// kibibit per square metre
    /// </summary>
    public static readonly QuantityCode KibibitPerSquareMetre = new QuantityCode { Value = "E73" };

    /// <summary>
    /// kibibit per cubic metre
    /// </summary>
    public static readonly QuantityCode KibibitPerCubicMetre = new QuantityCode { Value = "E74" };

    /// <summary>
    /// mebibit per metre
    /// </summary>
    public static readonly QuantityCode MebibitPerMetre = new QuantityCode { Value = "E75" };

    /// <summary>
    /// mebibit per square metre
    /// </summary>
    public static readonly QuantityCode MebibitPerSquareMetre = new QuantityCode { Value = "E76" };

    /// <summary>
    /// mebibit per cubic metre
    /// </summary>
    public static readonly QuantityCode MebibitPerCubicMetre = new QuantityCode { Value = "E77" };

    /// <summary>
    /// petabit
    /// </summary>
    public static readonly QuantityCode Petabit = new QuantityCode { Value = "E78" };

    /// <summary>
    /// petabit per second
    /// </summary>
    public static readonly QuantityCode PetabitPerSecond = new QuantityCode { Value = "E79" };

    /// <summary>
    /// pebibit per metre
    /// </summary>
    public static readonly QuantityCode PebibitPerMetre = new QuantityCode { Value = "E80" };

    /// <summary>
    /// pebibit per square metre
    /// </summary>
    public static readonly QuantityCode PebibitPerSquareMetre = new QuantityCode { Value = "E81" };

    /// <summary>
    /// pebibit per cubic metre
    /// </summary>
    public static readonly QuantityCode PebibitPerCubicMetre = new QuantityCode { Value = "E82" };

    /// <summary>
    /// terabit
    /// </summary>
    public static readonly QuantityCode Terabit = new QuantityCode { Value = "E83" };

    /// <summary>
    /// terabit per second
    /// </summary>
    public static readonly QuantityCode TerabitPerSecond = new QuantityCode { Value = "E84" };

    /// <summary>
    /// tebibit per metre
    /// </summary>
    public static readonly QuantityCode TebibitPerMetre = new QuantityCode { Value = "E85" };

    /// <summary>
    /// tebibit per cubic metre
    /// </summary>
    public static readonly QuantityCode TebibitPerCubicMetre = new QuantityCode { Value = "E86" };

    /// <summary>
    /// tebibit per square metre
    /// </summary>
    public static readonly QuantityCode TebibitPerSquareMetre = new QuantityCode { Value = "E87" };

    /// <summary>
    /// bit per metre
    /// </summary>
    public static readonly QuantityCode BitPerMetre = new QuantityCode { Value = "E88" };

    /// <summary>
    /// bit per square metre
    /// </summary>
    public static readonly QuantityCode BitPerSquareMetre = new QuantityCode { Value = "E89" };

    /// <summary>
    /// reciprocal centimetre
    /// </summary>
    public static readonly QuantityCode ReciprocalCentimetre = new QuantityCode { Value = "E90" };

    /// <summary>
    /// reciprocal day
    /// </summary>
    public static readonly QuantityCode ReciprocalDay = new QuantityCode { Value = "E91" };

    /// <summary>
    /// cubic decimetre per hour
    /// </summary>
    public static readonly QuantityCode CubicDecimetrePerHour = new QuantityCode { Value = "E92" };

    /// <summary>
    /// kilogram per hour
    /// </summary>
    public static readonly QuantityCode KilogramPerHour = new QuantityCode { Value = "E93" };

    /// <summary>
    /// kilomole per second
    /// </summary>
    public static readonly QuantityCode KilomolePerSecond = new QuantityCode { Value = "E94" };

    /// <summary>
    /// mole per second
    /// </summary>
    public static readonly QuantityCode MolePerSecond = new QuantityCode { Value = "E95" };

    /// <summary>
    /// degree per second
    /// </summary>
    public static readonly QuantityCode DegreePerSecond = new QuantityCode { Value = "E96" };

    /// <summary>
    /// millimetre per degree Celcius metre
    /// </summary>
    public static readonly QuantityCode MillimetrePerDegreeCelciusMetre = new QuantityCode { Value = "E97" };

    /// <summary>
    /// degree Celsius per kelvin
    /// </summary>
    public static readonly QuantityCode DegreeCelsiusPerKelvin = new QuantityCode { Value = "E98" };

    /// <summary>
    /// hectopascal per bar
    /// </summary>
    public static readonly QuantityCode HectopascalPerBar = new QuantityCode { Value = "E99" };

    /// <summary>
    /// each
    /// </summary>
    public static readonly QuantityCode Each = new QuantityCode { Value = "EA" };

    /// <summary>
    /// electronic mail box
    /// </summary>
    public static readonly QuantityCode ElectronicMailBox = new QuantityCode { Value = "EB" };

    /// <summary>
    /// equivalent gallon
    /// </summary>
    public static readonly QuantityCode EquivalentGallon = new QuantityCode { Value = "EQ" };

    /// <summary>
    /// bit per cubic metre
    /// </summary>
    public static readonly QuantityCode BitPerCubicMetre = new QuantityCode { Value = "F01" };

    /// <summary>
    /// kelvin per kelvin
    /// </summary>
    public static readonly QuantityCode KelvinPerKelvin = new QuantityCode { Value = "F02" };

    /// <summary>
    /// kilopascal per bar
    /// </summary>
    public static readonly QuantityCode KilopascalPerBar = new QuantityCode { Value = "F03" };

    /// <summary>
    /// millibar per bar
    /// </summary>
    public static readonly QuantityCode MillibarPerBar = new QuantityCode { Value = "F04" };

    /// <summary>
    /// megapascal per bar
    /// </summary>
    public static readonly QuantityCode MegapascalPerBar = new QuantityCode { Value = "F05" };

    /// <summary>
    /// poise per bar
    /// </summary>
    public static readonly QuantityCode PoisePerBar = new QuantityCode { Value = "F06" };

    /// <summary>
    /// pascal per bar
    /// </summary>
    public static readonly QuantityCode PascalPerBar = new QuantityCode { Value = "F07" };

    /// <summary>
    /// milliampere per inch
    /// </summary>
    public static readonly QuantityCode MilliamperePerInch = new QuantityCode { Value = "F08" };

    /// <summary>
    /// kelvin per hour
    /// </summary>
    public static readonly QuantityCode KelvinPerHour = new QuantityCode { Value = "F10" };

    /// <summary>
    /// kelvin per minute
    /// </summary>
    public static readonly QuantityCode KelvinPerMinute = new QuantityCode { Value = "F11" };

    /// <summary>
    /// kelvin per second
    /// </summary>
    public static readonly QuantityCode KelvinPerSecond = new QuantityCode { Value = "F12" };

    /// <summary>
    /// slug
    /// </summary>
    public static readonly QuantityCode Slug = new QuantityCode { Value = "F13" };

    /// <summary>
    /// gram per kelvin
    /// </summary>
    public static readonly QuantityCode GramPerKelvin = new QuantityCode { Value = "F14" };

    /// <summary>
    /// kilogram per kelvin
    /// </summary>
    public static readonly QuantityCode KilogramPerKelvin = new QuantityCode { Value = "F15" };

    /// <summary>
    /// milligram per kelvin
    /// </summary>
    public static readonly QuantityCode MilligramPerKelvin = new QuantityCode { Value = "F16" };

    /// <summary>
    /// pound-force per foot
    /// </summary>
    public static readonly QuantityCode PoundForcePerFoot = new QuantityCode { Value = "F17" };

    /// <summary>
    /// kilogram square centimetre
    /// </summary>
    public static readonly QuantityCode KilogramSquareCentimetre = new QuantityCode { Value = "F18" };

    /// <summary>
    /// kilogram square millimetre
    /// </summary>
    public static readonly QuantityCode KilogramSquareMillimetre = new QuantityCode { Value = "F19" };

    /// <summary>
    /// pound inch squared
    /// </summary>
    public static readonly QuantityCode PoundInchSquared = new QuantityCode { Value = "F20" };

    /// <summary>
    /// pound-force inch
    /// </summary>
    public static readonly QuantityCode PoundForceInch = new QuantityCode { Value = "F21" };

    /// <summary>
    /// pound-force foot per ampere
    /// </summary>
    public static readonly QuantityCode PoundForceFootPerAmpere = new QuantityCode { Value = "F22" };

    /// <summary>
    /// gram per cubic decimetre
    /// </summary>
    public static readonly QuantityCode GramPerCubicDecimetre = new QuantityCode { Value = "F23" };

    /// <summary>
    /// kilogram per kilomol
    /// </summary>
    public static readonly QuantityCode KilogramPerKilomol = new QuantityCode { Value = "F24" };

    /// <summary>
    /// gram per hertz
    /// </summary>
    public static readonly QuantityCode GramPerHertz = new QuantityCode { Value = "F25" };

    /// <summary>
    /// gram per day
    /// </summary>
    public static readonly QuantityCode GramPerDay = new QuantityCode { Value = "F26" };

    /// <summary>
    /// gram per hour
    /// </summary>
    public static readonly QuantityCode GramPerHour = new QuantityCode { Value = "F27" };

    /// <summary>
    /// gram per minute
    /// </summary>
    public static readonly QuantityCode GramPerMinute = new QuantityCode { Value = "F28" };

    /// <summary>
    /// gram per second
    /// </summary>
    public static readonly QuantityCode GramPerSecond = new QuantityCode { Value = "F29" };

    /// <summary>
    /// kilogram per day
    /// </summary>
    public static readonly QuantityCode KilogramPerDay = new QuantityCode { Value = "F30" };

    /// <summary>
    /// kilogram per minute
    /// </summary>
    public static readonly QuantityCode KilogramPerMinute = new QuantityCode { Value = "F31" };

    /// <summary>
    /// milligram per day
    /// </summary>
    public static readonly QuantityCode MilligramPerDay = new QuantityCode { Value = "F32" };

    /// <summary>
    /// milligram per minute
    /// </summary>
    public static readonly QuantityCode MilligramPerMinute = new QuantityCode { Value = "F33" };

    /// <summary>
    /// milligram per second
    /// </summary>
    public static readonly QuantityCode MilligramPerSecond = new QuantityCode { Value = "F34" };

    /// <summary>
    /// gram per day kelvin
    /// </summary>
    public static readonly QuantityCode GramPerDayKelvin = new QuantityCode { Value = "F35" };

    /// <summary>
    /// gram per hour kelvin
    /// </summary>
    public static readonly QuantityCode GramPerHourKelvin = new QuantityCode { Value = "F36" };

    /// <summary>
    /// gram per minute kelvin
    /// </summary>
    public static readonly QuantityCode GramPerMinuteKelvin = new QuantityCode { Value = "F37" };

    /// <summary>
    /// gram per second kelvin
    /// </summary>
    public static readonly QuantityCode GramPerSecondKelvin = new QuantityCode { Value = "F38" };

    /// <summary>
    /// kilogram per day kelvin
    /// </summary>
    public static readonly QuantityCode KilogramPerDayKelvin = new QuantityCode { Value = "F39" };

    /// <summary>
    /// kilogram per hour kelvin
    /// </summary>
    public static readonly QuantityCode KilogramPerHourKelvin = new QuantityCode { Value = "F40" };

    /// <summary>
    /// kilogram per minute kelvin
    /// </summary>
    public static readonly QuantityCode KilogramPerMinuteKelvin = new QuantityCode { Value = "F41" };

    /// <summary>
    /// kilogram per second kelvin
    /// </summary>
    public static readonly QuantityCode KilogramPerSecondKelvin = new QuantityCode { Value = "F42" };

    /// <summary>
    /// milligram per day kelvin
    /// </summary>
    public static readonly QuantityCode MilligramPerDayKelvin = new QuantityCode { Value = "F43" };

    /// <summary>
    /// milligram per hour kelvin
    /// </summary>
    public static readonly QuantityCode MilligramPerHourKelvin = new QuantityCode { Value = "F44" };

    /// <summary>
    /// milligram per minute kelvin
    /// </summary>
    public static readonly QuantityCode MilligramPerMinuteKelvin = new QuantityCode { Value = "F45" };

    /// <summary>
    /// milligram per second kelvin
    /// </summary>
    public static readonly QuantityCode MilligramPerSecondKelvin = new QuantityCode { Value = "F46" };

    /// <summary>
    /// newton per millimetre
    /// </summary>
    public static readonly QuantityCode NewtonPerMillimetre = new QuantityCode { Value = "F47" };

    /// <summary>
    /// pound-force per inch
    /// </summary>
    public static readonly QuantityCode PoundForcePerInch = new QuantityCode { Value = "F48" };

    /// <summary>
    /// rod [unit of distance]
    /// </summary>
    public static readonly QuantityCode RodUnitOfDistance = new QuantityCode { Value = "F49" };

    /// <summary>
    /// micrometre per kelvin
    /// </summary>
    public static readonly QuantityCode MicrometrePerKelvin = new QuantityCode { Value = "F50" };

    /// <summary>
    /// centimetre per kelvin
    /// </summary>
    public static readonly QuantityCode CentimetrePerKelvin = new QuantityCode { Value = "F51" };

    /// <summary>
    /// metre per kelvin
    /// </summary>
    public static readonly QuantityCode MetrePerKelvin = new QuantityCode { Value = "F52" };

    /// <summary>
    /// millimetre per kelvin
    /// </summary>
    public static readonly QuantityCode MillimetrePerKelvin = new QuantityCode { Value = "F53" };

    /// <summary>
    /// milliohm per metre
    /// </summary>
    public static readonly QuantityCode MilliohmPerMetre = new QuantityCode { Value = "F54" };

    /// <summary>
    /// ohm per mile (statute mile)
    /// </summary>
    public static readonly QuantityCode OhmPerMileStatuteMile = new QuantityCode { Value = "F55" };

    /// <summary>
    /// ohm per kilometre
    /// </summary>
    public static readonly QuantityCode OhmPerKilometre = new QuantityCode { Value = "F56" };

    /// <summary>
    /// milliampere per pound-force per square inch
    /// </summary>
    public static readonly QuantityCode MilliamperePerPoundForcePerSquareInch = new QuantityCode { Value = "F57" };

    /// <summary>
    /// reciprocal bar
    /// </summary>
    public static readonly QuantityCode ReciprocalBar = new QuantityCode { Value = "F58" };

    /// <summary>
    /// milliampere per bar
    /// </summary>
    public static readonly QuantityCode MilliamperePerBar = new QuantityCode { Value = "F59" };

    /// <summary>
    /// degree Celsius per bar
    /// </summary>
    public static readonly QuantityCode DegreeCelsiusPerBar = new QuantityCode { Value = "F60" };

    /// <summary>
    /// kelvin per bar
    /// </summary>
    public static readonly QuantityCode KelvinPerBar = new QuantityCode { Value = "F61" };

    /// <summary>
    /// gram per day bar
    /// </summary>
    public static readonly QuantityCode GramPerDayBar = new QuantityCode { Value = "F62" };

    /// <summary>
    /// gram per hour bar
    /// </summary>
    public static readonly QuantityCode GramPerHourBar = new QuantityCode { Value = "F63" };

    /// <summary>
    /// gram per minute bar
    /// </summary>
    public static readonly QuantityCode GramPerMinuteBar = new QuantityCode { Value = "F64" };

    /// <summary>
    /// gram per second bar
    /// </summary>
    public static readonly QuantityCode GramPerSecondBar = new QuantityCode { Value = "F65" };

    /// <summary>
    /// kilogram per day bar
    /// </summary>
    public static readonly QuantityCode KilogramPerDayBar = new QuantityCode { Value = "F66" };

    /// <summary>
    /// kilogram per hour bar
    /// </summary>
    public static readonly QuantityCode KilogramPerHourBar = new QuantityCode { Value = "F67" };

    /// <summary>
    /// kilogram per minute bar
    /// </summary>
    public static readonly QuantityCode KilogramPerMinuteBar = new QuantityCode { Value = "F68" };

    /// <summary>
    /// kilogram per second bar
    /// </summary>
    public static readonly QuantityCode KilogramPerSecondBar = new QuantityCode { Value = "F69" };

    /// <summary>
    /// milligram per day bar
    /// </summary>
    public static readonly QuantityCode MilligramPerDayBar = new QuantityCode { Value = "F70" };

    /// <summary>
    /// milligram per hour bar
    /// </summary>
    public static readonly QuantityCode MilligramPerHourBar = new QuantityCode { Value = "F71" };

    /// <summary>
    /// milligram per minute bar
    /// </summary>
    public static readonly QuantityCode MilligramPerMinuteBar = new QuantityCode { Value = "F72" };

    /// <summary>
    /// milligram per second bar
    /// </summary>
    public static readonly QuantityCode MilligramPerSecondBar = new QuantityCode { Value = "F73" };

    /// <summary>
    /// gram per bar
    /// </summary>
    public static readonly QuantityCode GramPerBar = new QuantityCode { Value = "F74" };

    /// <summary>
    /// milligram per bar
    /// </summary>
    public static readonly QuantityCode MilligramPerBar = new QuantityCode { Value = "F75" };

    /// <summary>
    /// milliampere per millimetre
    /// </summary>
    public static readonly QuantityCode MilliamperePerMillimetre = new QuantityCode { Value = "F76" };

    /// <summary>
    /// pascal second per kelvin
    /// </summary>
    public static readonly QuantityCode PascalSecondPerKelvin = new QuantityCode { Value = "F77" };

    /// <summary>
    /// inch of water
    /// </summary>
    public static readonly QuantityCode InchOfWater = new QuantityCode { Value = "F78" };

    /// <summary>
    /// inch of mercury
    /// </summary>
    public static readonly QuantityCode InchOfMercury = new QuantityCode { Value = "F79" };

    /// <summary>
    /// water horse power
    /// </summary>
    public static readonly QuantityCode WaterHorsePower = new QuantityCode { Value = "F80" };

    /// <summary>
    /// bar per kelvin
    /// </summary>
    public static readonly QuantityCode BarPerKelvin = new QuantityCode { Value = "F81" };

    /// <summary>
    /// hectopascal per kelvin
    /// </summary>
    public static readonly QuantityCode HectopascalPerKelvin = new QuantityCode { Value = "F82" };

    /// <summary>
    /// kilopascal per kelvin
    /// </summary>
    public static readonly QuantityCode KilopascalPerKelvin = new QuantityCode { Value = "F83" };

    /// <summary>
    /// millibar per kelvin
    /// </summary>
    public static readonly QuantityCode MillibarPerKelvin = new QuantityCode { Value = "F84" };

    /// <summary>
    /// megapascal per kelvin
    /// </summary>
    public static readonly QuantityCode MegapascalPerKelvin = new QuantityCode { Value = "F85" };

    /// <summary>
    /// poise per kelvin
    /// </summary>
    public static readonly QuantityCode PoisePerKelvin = new QuantityCode { Value = "F86" };

    /// <summary>
    /// volt per litre minute
    /// </summary>
    public static readonly QuantityCode VoltPerLitreMinute = new QuantityCode { Value = "F87" };

    /// <summary>
    /// newton centimetre
    /// </summary>
    public static readonly QuantityCode NewtonCentimetre = new QuantityCode { Value = "F88" };

    /// <summary>
    /// newton metre per degree
    /// </summary>
    public static readonly QuantityCode NewtonMetrePerDegree = new QuantityCode { Value = "F89" };

    /// <summary>
    /// newton metre per ampere
    /// </summary>
    public static readonly QuantityCode NewtonMetrePerAmpere = new QuantityCode { Value = "F90" };

    /// <summary>
    /// bar litre per second
    /// </summary>
    public static readonly QuantityCode BarLitrePerSecond = new QuantityCode { Value = "F91" };

    /// <summary>
    /// bar cubic metre per second
    /// </summary>
    public static readonly QuantityCode BarCubicMetrePerSecond = new QuantityCode { Value = "F92" };

    /// <summary>
    /// hectopascal litre per second
    /// </summary>
    public static readonly QuantityCode HectopascalLitrePerSecond = new QuantityCode { Value = "F93" };

    /// <summary>
    /// hectopascal cubic metre per second
    /// </summary>
    public static readonly QuantityCode HectopascalCubicMetrePerSecond = new QuantityCode { Value = "F94" };

    /// <summary>
    /// millibar litre per second
    /// </summary>
    public static readonly QuantityCode MillibarLitrePerSecond = new QuantityCode { Value = "F95" };

    /// <summary>
    /// millibar cubic metre per second
    /// </summary>
    public static readonly QuantityCode MillibarCubicMetrePerSecond = new QuantityCode { Value = "F96" };

    /// <summary>
    /// megapascal litre per second
    /// </summary>
    public static readonly QuantityCode MegapascalLitrePerSecond = new QuantityCode { Value = "F97" };

    /// <summary>
    /// megapascal cubic metre per second
    /// </summary>
    public static readonly QuantityCode MegapascalCubicMetrePerSecond = new QuantityCode { Value = "F98" };

    /// <summary>
    /// pascal litre per second
    /// </summary>
    public static readonly QuantityCode PascalLitrePerSecond = new QuantityCode { Value = "F99" };

    /// <summary>
    /// degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode DegreeFahrenheit = new QuantityCode { Value = "FAH" };

    /// <summary>
    /// farad
    /// </summary>
    public static readonly QuantityCode Farad = new QuantityCode { Value = "FAR" };

    /// <summary>
    /// fibre metre
    /// </summary>
    public static readonly QuantityCode FibreMetre = new QuantityCode { Value = "FBM" };

    /// <summary>
    /// thousand cubic foot
    /// </summary>
    public static readonly QuantityCode ThousandCubicFoot = new QuantityCode { Value = "FC" };

    /// <summary>
    /// hundred cubic metre
    /// </summary>
    public static readonly QuantityCode HundredCubicMetre = new QuantityCode { Value = "FF" };

    /// <summary>
    /// micromole
    /// </summary>
    public static readonly QuantityCode Micromole = new QuantityCode { Value = "FH" };

    /// <summary>
    /// failures in time
    /// </summary>
    public static readonly QuantityCode FailuresInTime = new QuantityCode { Value = "FIT" };

    /// <summary>
    /// flake ton
    /// </summary>
    public static readonly QuantityCode FlakeTon = new QuantityCode { Value = "FL" };

    /// <summary>
    /// Formazin nephelometric unit
    /// </summary>
    public static readonly QuantityCode FormazinNephelometricUnit = new QuantityCode { Value = "FNU" };

    /// <summary>
    /// foot
    /// </summary>
    public static readonly QuantityCode Foot = new QuantityCode { Value = "FOT" };

    /// <summary>
    /// pound per square foot
    /// </summary>
    public static readonly QuantityCode PoundPerSquareFoot = new QuantityCode { Value = "FP" };

    /// <summary>
    /// foot per minute
    /// </summary>
    public static readonly QuantityCode FootPerMinute = new QuantityCode { Value = "FR" };

    /// <summary>
    /// foot per second
    /// </summary>
    public static readonly QuantityCode FootPerSecond = new QuantityCode { Value = "FS" };

    /// <summary>
    /// square foot
    /// </summary>
    public static readonly QuantityCode SquareFoot = new QuantityCode { Value = "FTK" };

    /// <summary>
    /// cubic foot
    /// </summary>
    public static readonly QuantityCode CubicFoot = new QuantityCode { Value = "FTQ" };

    /// <summary>
    /// pascal cubic metre per second
    /// </summary>
    public static readonly QuantityCode PascalCubicMetrePerSecond = new QuantityCode { Value = "G01" };

    /// <summary>
    /// centimetre per bar
    /// </summary>
    public static readonly QuantityCode CentimetrePerBar = new QuantityCode { Value = "G04" };

    /// <summary>
    /// metre per bar
    /// </summary>
    public static readonly QuantityCode MetrePerBar = new QuantityCode { Value = "G05" };

    /// <summary>
    /// millimetre per bar
    /// </summary>
    public static readonly QuantityCode MillimetrePerBar = new QuantityCode { Value = "G06" };

    /// <summary>
    /// square inch per second
    /// </summary>
    public static readonly QuantityCode SquareInchPerSecond = new QuantityCode { Value = "G08" };

    /// <summary>
    /// square metre per second kelvin
    /// </summary>
    public static readonly QuantityCode SquareMetrePerSecondKelvin = new QuantityCode { Value = "G09" };

    /// <summary>
    /// stokes per kelvin
    /// </summary>
    public static readonly QuantityCode StokesPerKelvin = new QuantityCode { Value = "G10" };

    /// <summary>
    /// gram per cubic centimetre bar
    /// </summary>
    public static readonly QuantityCode GramPerCubicCentimetreBar = new QuantityCode { Value = "G11" };

    /// <summary>
    /// gram per cubic decimetre bar
    /// </summary>
    public static readonly QuantityCode GramPerCubicDecimetreBar = new QuantityCode { Value = "G12" };

    /// <summary>
    /// gram per litre bar
    /// </summary>
    public static readonly QuantityCode GramPerLitreBar = new QuantityCode { Value = "G13" };

    /// <summary>
    /// gram per cubic metre bar
    /// </summary>
    public static readonly QuantityCode GramPerCubicMetreBar = new QuantityCode { Value = "G14" };

    /// <summary>
    /// gram per millilitre bar
    /// </summary>
    public static readonly QuantityCode GramPerMillilitreBar = new QuantityCode { Value = "G15" };

    /// <summary>
    /// kilogram per cubic centimetre bar
    /// </summary>
    public static readonly QuantityCode KilogramPerCubicCentimetreBar = new QuantityCode { Value = "G16" };

    /// <summary>
    /// kilogram per litre bar
    /// </summary>
    public static readonly QuantityCode KilogramPerLitreBar = new QuantityCode { Value = "G17" };

    /// <summary>
    /// kilogram per cubic metre bar
    /// </summary>
    public static readonly QuantityCode KilogramPerCubicMetreBar = new QuantityCode { Value = "G18" };

    /// <summary>
    /// newton metre per kilogram
    /// </summary>
    public static readonly QuantityCode NewtonMetrePerKilogram = new QuantityCode { Value = "G19" };

    /// <summary>
    /// US gallon per minute
    /// </summary>
    public static readonly QuantityCode USGallonPerMinute = new QuantityCode { Value = "G2" };

    /// <summary>
    /// pound-force foot per pound
    /// </summary>
    public static readonly QuantityCode PoundForceFootPerPound = new QuantityCode { Value = "G20" };

    /// <summary>
    /// cup [unit of volume]
    /// </summary>
    public static readonly QuantityCode CupUnitOfVolume = new QuantityCode { Value = "G21" };

    /// <summary>
    /// peck
    /// </summary>
    public static readonly QuantityCode Peck = new QuantityCode { Value = "G23" };

    /// <summary>
    /// tablespoon (US)
    /// </summary>
    public static readonly QuantityCode TablespoonUS = new QuantityCode { Value = "G24" };

    /// <summary>
    /// teaspoon (US)
    /// </summary>
    public static readonly QuantityCode TeaspoonUS = new QuantityCode { Value = "G25" };

    /// <summary>
    /// stere
    /// </summary>
    public static readonly QuantityCode Stere = new QuantityCode { Value = "G26" };

    /// <summary>
    /// cubic centimetre per kelvin
    /// </summary>
    public static readonly QuantityCode CubicCentimetrePerKelvin = new QuantityCode { Value = "G27" };

    /// <summary>
    /// litre per kelvin
    /// </summary>
    public static readonly QuantityCode LitrePerKelvin = new QuantityCode { Value = "G28" };

    /// <summary>
    /// cubic metre per kelvin
    /// </summary>
    public static readonly QuantityCode CubicMetrePerKelvin = new QuantityCode { Value = "G29" };

    /// <summary>
    /// Imperial gallon per minute
    /// </summary>
    public static readonly QuantityCode ImperialGallonPerMinute = new QuantityCode { Value = "G3" };

    /// <summary>
    /// millilitre per kelvin
    /// </summary>
    public static readonly QuantityCode MillilitrePerKelvin = new QuantityCode { Value = "G30" };

    /// <summary>
    /// kilogram per cubic centimetre
    /// </summary>
    public static readonly QuantityCode KilogramPerCubicCentimetre = new QuantityCode { Value = "G31" };

    /// <summary>
    /// ounce (avoirdupois) per cubic yard
    /// </summary>
    public static readonly QuantityCode OunceAvoirdupoisPerCubicYard = new QuantityCode { Value = "G32" };

    /// <summary>
    /// gram per cubic centimetre kelvin
    /// </summary>
    public static readonly QuantityCode GramPerCubicCentimetreKelvin = new QuantityCode { Value = "G33" };

    /// <summary>
    /// gram per cubic decimetre kelvin
    /// </summary>
    public static readonly QuantityCode GramPerCubicDecimetreKelvin = new QuantityCode { Value = "G34" };

    /// <summary>
    /// gram per litre kelvin
    /// </summary>
    public static readonly QuantityCode GramPerLitreKelvin = new QuantityCode { Value = "G35" };

    /// <summary>
    /// gram per cubic metre kelvin
    /// </summary>
    public static readonly QuantityCode GramPerCubicMetreKelvin = new QuantityCode { Value = "G36" };

    /// <summary>
    /// gram per millilitre kelvin
    /// </summary>
    public static readonly QuantityCode GramPerMillilitreKelvin = new QuantityCode { Value = "G37" };

    /// <summary>
    /// kilogram per cubic centimetre kelvin
    /// </summary>
    public static readonly QuantityCode KilogramPerCubicCentimetreKelvin = new QuantityCode { Value = "G38" };

    /// <summary>
    /// kilogram per litre kelvin
    /// </summary>
    public static readonly QuantityCode KilogramPerLitreKelvin = new QuantityCode { Value = "G39" };

    /// <summary>
    /// kilogram per cubic metre kelvin
    /// </summary>
    public static readonly QuantityCode KilogramPerCubicMetreKelvin = new QuantityCode { Value = "G40" };

    /// <summary>
    /// square metre per second bar
    /// </summary>
    public static readonly QuantityCode SquareMetrePerSecondBar = new QuantityCode { Value = "G41" };

    /// <summary>
    /// microsiemens per centimetre
    /// </summary>
    public static readonly QuantityCode MicrosiemensPerCentimetre = new QuantityCode { Value = "G42" };

    /// <summary>
    /// microsiemens per metre
    /// </summary>
    public static readonly QuantityCode MicrosiemensPerMetre = new QuantityCode { Value = "G43" };

    /// <summary>
    /// nanosiemens per centimetre
    /// </summary>
    public static readonly QuantityCode NanosiemensPerCentimetre = new QuantityCode { Value = "G44" };

    /// <summary>
    /// nanosiemens per metre
    /// </summary>
    public static readonly QuantityCode NanosiemensPerMetre = new QuantityCode { Value = "G45" };

    /// <summary>
    /// stokes per bar
    /// </summary>
    public static readonly QuantityCode StokesPerBar = new QuantityCode { Value = "G46" };

    /// <summary>
    /// cubic centimetre per day
    /// </summary>
    public static readonly QuantityCode CubicCentimetrePerDay = new QuantityCode { Value = "G47" };

    /// <summary>
    /// cubic centimetre per hour
    /// </summary>
    public static readonly QuantityCode CubicCentimetrePerHour = new QuantityCode { Value = "G48" };

    /// <summary>
    /// cubic centimetre per minute
    /// </summary>
    public static readonly QuantityCode CubicCentimetrePerMinute = new QuantityCode { Value = "G49" };

    /// <summary>
    /// gallon (US) per hour
    /// </summary>
    public static readonly QuantityCode GallonUSPerHour = new QuantityCode { Value = "G50" };

    /// <summary>
    /// litre per second
    /// </summary>
    public static readonly QuantityCode LitrePerSecond = new QuantityCode { Value = "G51" };

    /// <summary>
    /// cubic metre per day
    /// </summary>
    public static readonly QuantityCode CubicMetrePerDay = new QuantityCode { Value = "G52" };

    /// <summary>
    /// cubic metre per minute
    /// </summary>
    public static readonly QuantityCode CubicMetrePerMinute = new QuantityCode { Value = "G53" };

    /// <summary>
    /// millilitre per day
    /// </summary>
    public static readonly QuantityCode MillilitrePerDay = new QuantityCode { Value = "G54" };

    /// <summary>
    /// millilitre per hour
    /// </summary>
    public static readonly QuantityCode MillilitrePerHour = new QuantityCode { Value = "G55" };

    /// <summary>
    /// cubic inch per hour
    /// </summary>
    public static readonly QuantityCode CubicInchPerHour = new QuantityCode { Value = "G56" };

    /// <summary>
    /// cubic inch per minute
    /// </summary>
    public static readonly QuantityCode CubicInchPerMinute = new QuantityCode { Value = "G57" };

    /// <summary>
    /// cubic inch per second
    /// </summary>
    public static readonly QuantityCode CubicInchPerSecond = new QuantityCode { Value = "G58" };

    /// <summary>
    /// milliampere per litre minute
    /// </summary>
    public static readonly QuantityCode MilliamperePerLitreMinute = new QuantityCode { Value = "G59" };

    /// <summary>
    /// volt per bar
    /// </summary>
    public static readonly QuantityCode VoltPerBar = new QuantityCode { Value = "G60" };

    /// <summary>
    /// cubic centimetre per day kelvin
    /// </summary>
    public static readonly QuantityCode CubicCentimetrePerDayKelvin = new QuantityCode { Value = "G61" };

    /// <summary>
    /// cubic centimetre per hour kelvin
    /// </summary>
    public static readonly QuantityCode CubicCentimetrePerHourKelvin = new QuantityCode { Value = "G62" };

    /// <summary>
    /// cubic centimetre per minute kelvin
    /// </summary>
    public static readonly QuantityCode CubicCentimetrePerMinuteKelvin = new QuantityCode { Value = "G63" };

    /// <summary>
    /// cubic centimetre per second kelvin
    /// </summary>
    public static readonly QuantityCode CubicCentimetrePerSecondKelvin = new QuantityCode { Value = "G64" };

    /// <summary>
    /// litre per day kelvin
    /// </summary>
    public static readonly QuantityCode LitrePerDayKelvin = new QuantityCode { Value = "G65" };

    /// <summary>
    /// litre per hour kelvin
    /// </summary>
    public static readonly QuantityCode LitrePerHourKelvin = new QuantityCode { Value = "G66" };

    /// <summary>
    /// litre per minute kelvin
    /// </summary>
    public static readonly QuantityCode LitrePerMinuteKelvin = new QuantityCode { Value = "G67" };

    /// <summary>
    /// litre per second kelvin
    /// </summary>
    public static readonly QuantityCode LitrePerSecondKelvin = new QuantityCode { Value = "G68" };

    /// <summary>
    /// cubic metre per day kelvin
    /// </summary>
    public static readonly QuantityCode CubicMetrePerDayKelvin = new QuantityCode { Value = "G69" };

    /// <summary>
    /// cubic metre per hour kelvin
    /// </summary>
    public static readonly QuantityCode CubicMetrePerHourKelvin = new QuantityCode { Value = "G70" };

    /// <summary>
    /// cubic metre per minute kelvin
    /// </summary>
    public static readonly QuantityCode CubicMetrePerMinuteKelvin = new QuantityCode { Value = "G71" };

    /// <summary>
    /// cubic metre per second kelvin
    /// </summary>
    public static readonly QuantityCode CubicMetrePerSecondKelvin = new QuantityCode { Value = "G72" };

    /// <summary>
    /// millilitre per day kelvin
    /// </summary>
    public static readonly QuantityCode MillilitrePerDayKelvin = new QuantityCode { Value = "G73" };

    /// <summary>
    /// millilitre per hour kelvin
    /// </summary>
    public static readonly QuantityCode MillilitrePerHourKelvin = new QuantityCode { Value = "G74" };

    /// <summary>
    /// millilitre per minute kelvin
    /// </summary>
    public static readonly QuantityCode MillilitrePerMinuteKelvin = new QuantityCode { Value = "G75" };

    /// <summary>
    /// millilitre per second kelvin
    /// </summary>
    public static readonly QuantityCode MillilitrePerSecondKelvin = new QuantityCode { Value = "G76" };

    /// <summary>
    /// millimetre to the fourth power
    /// </summary>
    public static readonly QuantityCode MillimetreToTheFourthPower = new QuantityCode { Value = "G77" };

    /// <summary>
    /// cubic centimetre per day bar
    /// </summary>
    public static readonly QuantityCode CubicCentimetrePerDayBar = new QuantityCode { Value = "G78" };

    /// <summary>
    /// cubic centimetre per hour bar
    /// </summary>
    public static readonly QuantityCode CubicCentimetrePerHourBar = new QuantityCode { Value = "G79" };

    /// <summary>
    /// cubic centimetre per minute bar
    /// </summary>
    public static readonly QuantityCode CubicCentimetrePerMinuteBar = new QuantityCode { Value = "G80" };

    /// <summary>
    /// cubic centimetre per second bar
    /// </summary>
    public static readonly QuantityCode CubicCentimetrePerSecondBar = new QuantityCode { Value = "G81" };

    /// <summary>
    /// litre per day bar
    /// </summary>
    public static readonly QuantityCode LitrePerDayBar = new QuantityCode { Value = "G82" };

    /// <summary>
    /// litre per hour bar
    /// </summary>
    public static readonly QuantityCode LitrePerHourBar = new QuantityCode { Value = "G83" };

    /// <summary>
    /// litre per minute bar
    /// </summary>
    public static readonly QuantityCode LitrePerMinuteBar = new QuantityCode { Value = "G84" };

    /// <summary>
    /// litre per second bar
    /// </summary>
    public static readonly QuantityCode LitrePerSecondBar = new QuantityCode { Value = "G85" };

    /// <summary>
    /// cubic metre per day bar
    /// </summary>
    public static readonly QuantityCode CubicMetrePerDayBar = new QuantityCode { Value = "G86" };

    /// <summary>
    /// cubic metre per hour bar
    /// </summary>
    public static readonly QuantityCode CubicMetrePerHourBar = new QuantityCode { Value = "G87" };

    /// <summary>
    /// cubic metre per minute bar
    /// </summary>
    public static readonly QuantityCode CubicMetrePerMinuteBar = new QuantityCode { Value = "G88" };

    /// <summary>
    /// cubic metre per second bar
    /// </summary>
    public static readonly QuantityCode CubicMetrePerSecondBar = new QuantityCode { Value = "G89" };

    /// <summary>
    /// millilitre per day bar
    /// </summary>
    public static readonly QuantityCode MillilitrePerDayBar = new QuantityCode { Value = "G90" };

    /// <summary>
    /// millilitre per hour bar
    /// </summary>
    public static readonly QuantityCode MillilitrePerHourBar = new QuantityCode { Value = "G91" };

    /// <summary>
    /// millilitre per minute bar
    /// </summary>
    public static readonly QuantityCode MillilitrePerMinuteBar = new QuantityCode { Value = "G92" };

    /// <summary>
    /// millilitre per second bar
    /// </summary>
    public static readonly QuantityCode MillilitrePerSecondBar = new QuantityCode { Value = "G93" };

    /// <summary>
    /// cubic centimetre per bar
    /// </summary>
    public static readonly QuantityCode CubicCentimetrePerBar = new QuantityCode { Value = "G94" };

    /// <summary>
    /// litre per bar
    /// </summary>
    public static readonly QuantityCode LitrePerBar = new QuantityCode { Value = "G95" };

    /// <summary>
    /// cubic metre per bar
    /// </summary>
    public static readonly QuantityCode CubicMetrePerBar = new QuantityCode { Value = "G96" };

    /// <summary>
    /// millilitre per bar
    /// </summary>
    public static readonly QuantityCode MillilitrePerBar = new QuantityCode { Value = "G97" };

    /// <summary>
    /// microhenry per kiloohm
    /// </summary>
    public static readonly QuantityCode MicrohenryPerKiloohm = new QuantityCode { Value = "G98" };

    /// <summary>
    /// microhenry per ohm
    /// </summary>
    public static readonly QuantityCode MicrohenryPerOhm = new QuantityCode { Value = "G99" };

    /// <summary>
    /// gallon (US) per day
    /// </summary>
    public static readonly QuantityCode GallonUSPerDay = new QuantityCode { Value = "GB" };

    /// <summary>
    /// gigabecquerel
    /// </summary>
    public static readonly QuantityCode Gigabecquerel = new QuantityCode { Value = "GBQ" };

    /// <summary>
    /// gram, dry weight
    /// </summary>
    public static readonly QuantityCode GramDryWeight = new QuantityCode { Value = "GDW" };

    /// <summary>
    /// pound per gallon (US)
    /// </summary>
    public static readonly QuantityCode PoundPerGallonUS = new QuantityCode { Value = "GE" };

    /// <summary>
    /// gram per metre (gram per 100 centimetres)
    /// </summary>
    public static readonly QuantityCode GramPerMetreGramPer100Centimetres = new QuantityCode { Value = "GF" };

    /// <summary>
    /// gram of fissile isotope
    /// </summary>
    public static readonly QuantityCode GramOfFissileIsotope = new QuantityCode { Value = "GFI" };

    /// <summary>
    /// great gross
    /// </summary>
    public static readonly QuantityCode GreatGross = new QuantityCode { Value = "GGR" };

    /// <summary>
    /// gill (US)
    /// </summary>
    public static readonly QuantityCode GillUS = new QuantityCode { Value = "GIA" };

    /// <summary>
    /// gram, including container
    /// </summary>
    public static readonly QuantityCode GramIncludingContainer = new QuantityCode { Value = "GIC" };

    /// <summary>
    /// gill (UK)
    /// </summary>
    public static readonly QuantityCode GillUK = new QuantityCode { Value = "GII" };

    /// <summary>
    /// gram, including inner packaging
    /// </summary>
    public static readonly QuantityCode GramIncludingInnerPackaging = new QuantityCode { Value = "GIP" };

    /// <summary>
    /// gram per millilitre
    /// </summary>
    public static readonly QuantityCode GramPerMillilitre = new QuantityCode { Value = "GJ" };

    /// <summary>
    /// gram per litre
    /// </summary>
    public static readonly QuantityCode GramPerLitre = new QuantityCode { Value = "GL" };

    /// <summary>
    /// dry gallon (US)
    /// </summary>
    public static readonly QuantityCode DryGallonUS = new QuantityCode { Value = "GLD" };

    /// <summary>
    /// gallon (UK)
    /// </summary>
    public static readonly QuantityCode GallonUK = new QuantityCode { Value = "GLI" };

    /// <summary>
    /// gallon (US)
    /// </summary>
    public static readonly QuantityCode GallonUS = new QuantityCode { Value = "GLL" };

    /// <summary>
    /// gram per square metre
    /// </summary>
    public static readonly QuantityCode GramPerSquareMetre = new QuantityCode { Value = "GM" };

    /// <summary>
    /// milligram per square metre
    /// </summary>
    public static readonly QuantityCode MilligramPerSquareMetre = new QuantityCode { Value = "GO" };

    /// <summary>
    /// milligram per cubic metre
    /// </summary>
    public static readonly QuantityCode MilligramPerCubicMetre = new QuantityCode { Value = "GP" };

    /// <summary>
    /// microgram per cubic metre
    /// </summary>
    public static readonly QuantityCode MicrogramPerCubicMetre = new QuantityCode { Value = "GQ" };

    /// <summary>
    /// gram
    /// </summary>
    public static readonly QuantityCode Gram = new QuantityCode { Value = "GRM" };

    /// <summary>
    /// grain
    /// </summary>
    public static readonly QuantityCode Grain = new QuantityCode { Value = "GRN" };

    /// <summary>
    /// gross
    /// </summary>
    public static readonly QuantityCode Gross = new QuantityCode { Value = "GRO" };

    /// <summary>
    /// gigajoule
    /// </summary>
    public static readonly QuantityCode Gigajoule = new QuantityCode { Value = "GV" };

    /// <summary>
    /// gigawatt hour
    /// </summary>
    public static readonly QuantityCode GigawattHour = new QuantityCode { Value = "GWH" };

    /// <summary>
    /// henry per kiloohm
    /// </summary>
    public static readonly QuantityCode HenryPerKiloohm = new QuantityCode { Value = "H03" };

    /// <summary>
    /// henry per ohm
    /// </summary>
    public static readonly QuantityCode HenryPerOhm = new QuantityCode { Value = "H04" };

    /// <summary>
    /// millihenry per kiloohm
    /// </summary>
    public static readonly QuantityCode MillihenryPerKiloohm = new QuantityCode { Value = "H05" };

    /// <summary>
    /// millihenry per ohm
    /// </summary>
    public static readonly QuantityCode MillihenryPerOhm = new QuantityCode { Value = "H06" };

    /// <summary>
    /// pascal second per bar
    /// </summary>
    public static readonly QuantityCode PascalSecondPerBar = new QuantityCode { Value = "H07" };

    /// <summary>
    /// microbecquerel
    /// </summary>
    public static readonly QuantityCode Microbecquerel = new QuantityCode { Value = "H08" };

    /// <summary>
    /// reciprocal year
    /// </summary>
    public static readonly QuantityCode ReciprocalYear = new QuantityCode { Value = "H09" };

    /// <summary>
    /// reciprocal hour
    /// </summary>
    public static readonly QuantityCode ReciprocalHour = new QuantityCode { Value = "H10" };

    /// <summary>
    /// reciprocal month
    /// </summary>
    public static readonly QuantityCode ReciprocalMonth = new QuantityCode { Value = "H11" };

    /// <summary>
    /// degree Celsius per hour
    /// </summary>
    public static readonly QuantityCode DegreeCelsiusPerHour = new QuantityCode { Value = "H12" };

    /// <summary>
    /// degree Celsius per minute
    /// </summary>
    public static readonly QuantityCode DegreeCelsiusPerMinute = new QuantityCode { Value = "H13" };

    /// <summary>
    /// degree Celsius per second
    /// </summary>
    public static readonly QuantityCode DegreeCelsiusPerSecond = new QuantityCode { Value = "H14" };

    /// <summary>
    /// square centimetre per gram
    /// </summary>
    public static readonly QuantityCode SquareCentimetrePerGram = new QuantityCode { Value = "H15" };

    /// <summary>
    /// square decametre
    /// </summary>
    public static readonly QuantityCode SquareDecametre = new QuantityCode { Value = "H16" };

    /// <summary>
    /// square hectometre
    /// </summary>
    public static readonly QuantityCode SquareHectometre = new QuantityCode { Value = "H18" };

    /// <summary>
    /// cubic hectometre
    /// </summary>
    public static readonly QuantityCode CubicHectometre = new QuantityCode { Value = "H19" };

    /// <summary>
    /// cubic kilometre
    /// </summary>
    public static readonly QuantityCode CubicKilometre = new QuantityCode { Value = "H20" };

    /// <summary>
    /// blank
    /// </summary>
    public static readonly QuantityCode Blank = new QuantityCode { Value = "H21" };

    /// <summary>
    /// volt square inch per pound-force
    /// </summary>
    public static readonly QuantityCode VoltSquareInchPerPoundForce = new QuantityCode { Value = "H22" };

    /// <summary>
    /// volt per inch
    /// </summary>
    public static readonly QuantityCode VoltPerInch = new QuantityCode { Value = "H23" };

    /// <summary>
    /// volt per microsecond
    /// </summary>
    public static readonly QuantityCode VoltPerMicrosecond = new QuantityCode { Value = "H24" };

    /// <summary>
    /// percent per kelvin
    /// </summary>
    public static readonly QuantityCode PercentPerKelvin = new QuantityCode { Value = "H25" };

    /// <summary>
    /// ohm per metre
    /// </summary>
    public static readonly QuantityCode OhmPerMetre = new QuantityCode { Value = "H26" };

    /// <summary>
    /// degree per metre
    /// </summary>
    public static readonly QuantityCode DegreePerMetre = new QuantityCode { Value = "H27" };

    /// <summary>
    /// microfarad per kilometre
    /// </summary>
    public static readonly QuantityCode MicrofaradPerKilometre = new QuantityCode { Value = "H28" };

    /// <summary>
    /// microgram per litre
    /// </summary>
    public static readonly QuantityCode MicrogramPerLitre = new QuantityCode { Value = "H29" };

    /// <summary>
    /// square micrometre (square micron)
    /// </summary>
    public static readonly QuantityCode SquareMicrometreSquareMicron = new QuantityCode { Value = "H30" };

    /// <summary>
    /// ampere per kilogram
    /// </summary>
    public static readonly QuantityCode AmperePerKilogram = new QuantityCode { Value = "H31" };

    /// <summary>
    /// ampere squared second
    /// </summary>
    public static readonly QuantityCode AmpereSquaredSecond = new QuantityCode { Value = "H32" };

    /// <summary>
    /// farad per kilometre
    /// </summary>
    public static readonly QuantityCode FaradPerKilometre = new QuantityCode { Value = "H33" };

    /// <summary>
    /// hertz metre
    /// </summary>
    public static readonly QuantityCode HertzMetre = new QuantityCode { Value = "H34" };

    /// <summary>
    /// kelvin metre per watt
    /// </summary>
    public static readonly QuantityCode KelvinMetrePerWatt = new QuantityCode { Value = "H35" };

    /// <summary>
    /// megaohm per kilometre
    /// </summary>
    public static readonly QuantityCode MegaohmPerKilometre = new QuantityCode { Value = "H36" };

    /// <summary>
    /// megaohm per metre
    /// </summary>
    public static readonly QuantityCode MegaohmPerMetre = new QuantityCode { Value = "H37" };

    /// <summary>
    /// megaampere
    /// </summary>
    public static readonly QuantityCode Megaampere = new QuantityCode { Value = "H38" };

    /// <summary>
    /// megahertz kilometre
    /// </summary>
    public static readonly QuantityCode MegahertzKilometre = new QuantityCode { Value = "H39" };

    /// <summary>
    /// newton per ampere
    /// </summary>
    public static readonly QuantityCode NewtonPerAmpere = new QuantityCode { Value = "H40" };

    /// <summary>
    /// newton metre watt to the power minus 0,5
    /// </summary>
    public static readonly QuantityCode NewtonMetreWattToThePowerMinus05 = new QuantityCode { Value = "H41" };

    /// <summary>
    /// pascal per metre
    /// </summary>
    public static readonly QuantityCode PascalPerMetre = new QuantityCode { Value = "H42" };

    /// <summary>
    /// siemens per centimetre
    /// </summary>
    public static readonly QuantityCode SiemensPerCentimetre = new QuantityCode { Value = "H43" };

    /// <summary>
    /// teraohm
    /// </summary>
    public static readonly QuantityCode Teraohm = new QuantityCode { Value = "H44" };

    /// <summary>
    /// volt second per metre
    /// </summary>
    public static readonly QuantityCode VoltSecondPerMetre = new QuantityCode { Value = "H45" };

    /// <summary>
    /// volt per second
    /// </summary>
    public static readonly QuantityCode VoltPerSecond = new QuantityCode { Value = "H46" };

    /// <summary>
    /// watt per cubic metre
    /// </summary>
    public static readonly QuantityCode WattPerCubicMetre = new QuantityCode { Value = "H47" };

    /// <summary>
    /// attofarad
    /// </summary>
    public static readonly QuantityCode Attofarad = new QuantityCode { Value = "H48" };

    /// <summary>
    /// centimetre per hour
    /// </summary>
    public static readonly QuantityCode CentimetrePerHour = new QuantityCode { Value = "H49" };

    /// <summary>
    /// reciprocal cubic centimetre
    /// </summary>
    public static readonly QuantityCode ReciprocalCubicCentimetre = new QuantityCode { Value = "H50" };

    /// <summary>
    /// decibel per kilometre
    /// </summary>
    public static readonly QuantityCode DecibelPerKilometre = new QuantityCode { Value = "H51" };

    /// <summary>
    /// decibel per metre
    /// </summary>
    public static readonly QuantityCode DecibelPerMetre = new QuantityCode { Value = "H52" };

    /// <summary>
    /// kilogram per bar
    /// </summary>
    public static readonly QuantityCode KilogramPerBar = new QuantityCode { Value = "H53" };

    /// <summary>
    /// kilogram per cubic decimetre kelvin
    /// </summary>
    public static readonly QuantityCode KilogramPerCubicDecimetreKelvin = new QuantityCode { Value = "H54" };

    /// <summary>
    /// kilogram per cubic decimetre bar
    /// </summary>
    public static readonly QuantityCode KilogramPerCubicDecimetreBar = new QuantityCode { Value = "H55" };

    /// <summary>
    /// kilogram per square metre second
    /// </summary>
    public static readonly QuantityCode KilogramPerSquareMetreSecond = new QuantityCode { Value = "H56" };

    /// <summary>
    /// inch per two pi radiant
    /// </summary>
    public static readonly QuantityCode InchPerTwoPiRadiant = new QuantityCode { Value = "H57" };

    /// <summary>
    /// metre per volt second
    /// </summary>
    public static readonly QuantityCode MetrePerVoltSecond = new QuantityCode { Value = "H58" };

    /// <summary>
    /// square metre per newton
    /// </summary>
    public static readonly QuantityCode SquareMetrePerNewton = new QuantityCode { Value = "H59" };

    /// <summary>
    /// cubic metre per cubic metre
    /// </summary>
    public static readonly QuantityCode CubicMetrePerCubicMetre = new QuantityCode { Value = "H60" };

    /// <summary>
    /// millisiemens per centimetre
    /// </summary>
    public static readonly QuantityCode MillisiemensPerCentimetre = new QuantityCode { Value = "H61" };

    /// <summary>
    /// millivolt per minute
    /// </summary>
    public static readonly QuantityCode MillivoltPerMinute = new QuantityCode { Value = "H62" };

    /// <summary>
    /// milligram per square centimetre
    /// </summary>
    public static readonly QuantityCode MilligramPerSquareCentimetre = new QuantityCode { Value = "H63" };

    /// <summary>
    /// milligram per gram
    /// </summary>
    public static readonly QuantityCode MilligramPerGram = new QuantityCode { Value = "H64" };

    /// <summary>
    /// millilitre per cubic metre
    /// </summary>
    public static readonly QuantityCode MillilitrePerCubicMetre = new QuantityCode { Value = "H65" };

    /// <summary>
    /// millimetre per year
    /// </summary>
    public static readonly QuantityCode MillimetrePerYear = new QuantityCode { Value = "H66" };

    /// <summary>
    /// millimetre per hour
    /// </summary>
    public static readonly QuantityCode MillimetrePerHour = new QuantityCode { Value = "H67" };

    /// <summary>
    /// millimole per gram
    /// </summary>
    public static readonly QuantityCode MillimolePerGram = new QuantityCode { Value = "H68" };

    /// <summary>
    /// picopascal per kilometre
    /// </summary>
    public static readonly QuantityCode PicopascalPerKilometre = new QuantityCode { Value = "H69" };

    /// <summary>
    /// picosecond
    /// </summary>
    public static readonly QuantityCode Picosecond = new QuantityCode { Value = "H70" };

    /// <summary>
    /// percent per month
    /// </summary>
    public static readonly QuantityCode PercentPerMonth = new QuantityCode { Value = "H71" };

    /// <summary>
    /// percent per hectobar
    /// </summary>
    public static readonly QuantityCode PercentPerHectobar = new QuantityCode { Value = "H72" };

    /// <summary>
    /// percent per decakelvin
    /// </summary>
    public static readonly QuantityCode PercentPerDecakelvin = new QuantityCode { Value = "H73" };

    /// <summary>
    /// watt per metre
    /// </summary>
    public static readonly QuantityCode WattPerMetre = new QuantityCode { Value = "H74" };

    /// <summary>
    /// decapascal
    /// </summary>
    public static readonly QuantityCode Decapascal = new QuantityCode { Value = "H75" };

    /// <summary>
    /// gram per millimetre
    /// </summary>
    public static readonly QuantityCode GramPerMillimetre = new QuantityCode { Value = "H76" };

    /// <summary>
    /// module width
    /// </summary>
    public static readonly QuantityCode ModuleWidth = new QuantityCode { Value = "H77" };

    /// <summary>
    /// French gauge
    /// </summary>
    public static readonly QuantityCode FrenchGauge = new QuantityCode { Value = "H79" };

    /// <summary>
    /// rack unit
    /// </summary>
    public static readonly QuantityCode RackUnit = new QuantityCode { Value = "H80" };

    /// <summary>
    /// millimetre per minute
    /// </summary>
    public static readonly QuantityCode MillimetrePerMinute = new QuantityCode { Value = "H81" };

    /// <summary>
    /// big point
    /// </summary>
    public static readonly QuantityCode BigPoint = new QuantityCode { Value = "H82" };

    /// <summary>
    /// litre per kilogram
    /// </summary>
    public static readonly QuantityCode LitrePerKilogram = new QuantityCode { Value = "H83" };

    /// <summary>
    /// gram millimetre
    /// </summary>
    public static readonly QuantityCode GramMillimetre = new QuantityCode { Value = "H84" };

    /// <summary>
    /// reciprocal week
    /// </summary>
    public static readonly QuantityCode ReciprocalWeek = new QuantityCode { Value = "H85" };

    /// <summary>
    /// piece
    /// </summary>
    public static readonly QuantityCode Piece = new QuantityCode { Value = "H87" };

    /// <summary>
    /// megaohm kilometre
    /// </summary>
    public static readonly QuantityCode MegaohmKilometre = new QuantityCode { Value = "H88" };

    /// <summary>
    /// percent per ohm
    /// </summary>
    public static readonly QuantityCode PercentPerOhm = new QuantityCode { Value = "H89" };

    /// <summary>
    /// percent per degree
    /// </summary>
    public static readonly QuantityCode PercentPerDegree = new QuantityCode { Value = "H90" };

    /// <summary>
    /// percent per ten thousand
    /// </summary>
    public static readonly QuantityCode PercentPerTenThousand = new QuantityCode { Value = "H91" };

    /// <summary>
    /// percent per one hundred thousand
    /// </summary>
    public static readonly QuantityCode PercentPerOneHundredThousand = new QuantityCode { Value = "H92" };

    /// <summary>
    /// percent per hundred
    /// </summary>
    public static readonly QuantityCode PercentPerHundred = new QuantityCode { Value = "H93" };

    /// <summary>
    /// percent per thousand
    /// </summary>
    public static readonly QuantityCode PercentPerThousand = new QuantityCode { Value = "H94" };

    /// <summary>
    /// percent per volt
    /// </summary>
    public static readonly QuantityCode PercentPerVolt = new QuantityCode { Value = "H95" };

    /// <summary>
    /// percent per bar
    /// </summary>
    public static readonly QuantityCode PercentPerBar = new QuantityCode { Value = "H96" };

    /// <summary>
    /// percent per inch
    /// </summary>
    public static readonly QuantityCode PercentPerInch = new QuantityCode { Value = "H98" };

    /// <summary>
    /// percent per metre
    /// </summary>
    public static readonly QuantityCode PercentPerMetre = new QuantityCode { Value = "H99" };

    /// <summary>
    /// hank
    /// </summary>
    public static readonly QuantityCode Hank = new QuantityCode { Value = "HA" };

    /// <summary>
    /// Piece Day
    /// </summary>
    public static readonly QuantityCode PieceDay = new QuantityCode { Value = "HAD" };

    /// <summary>
    /// hectobar
    /// </summary>
    public static readonly QuantityCode Hectobar = new QuantityCode { Value = "HBA" };

    /// <summary>
    /// hundred boxes
    /// </summary>
    public static readonly QuantityCode HundredBoxes = new QuantityCode { Value = "HBX" };

    /// <summary>
    /// hundred count
    /// </summary>
    public static readonly QuantityCode HundredCount = new QuantityCode { Value = "HC" };

    /// <summary>
    /// hundred kilogram, dry weight
    /// </summary>
    public static readonly QuantityCode HundredKilogramDryWeight = new QuantityCode { Value = "HDW" };

    /// <summary>
    /// head
    /// </summary>
    public static readonly QuantityCode Head = new QuantityCode { Value = "HEA" };

    /// <summary>
    /// hectogram
    /// </summary>
    public static readonly QuantityCode Hectogram = new QuantityCode { Value = "HGM" };

    /// <summary>
    /// hundred cubic foot
    /// </summary>
    public static readonly QuantityCode HundredCubicFoot = new QuantityCode { Value = "HH" };

    /// <summary>
    /// hundred international unit
    /// </summary>
    public static readonly QuantityCode HundredInternationalUnit = new QuantityCode { Value = "HIU" };

    /// <summary>
    /// hundred kilogram, net mass
    /// </summary>
    public static readonly QuantityCode HundredKilogramNetMass = new QuantityCode { Value = "HKM" };

    /// <summary>
    /// hectolitre
    /// </summary>
    public static readonly QuantityCode Hectolitre = new QuantityCode { Value = "HLT" };

    /// <summary>
    /// mile per hour (statute mile)
    /// </summary>
    public static readonly QuantityCode MilePerHourStatuteMile = new QuantityCode { Value = "HM" };

    /// <summary>
    /// Piece Month
    /// </summary>
    public static readonly QuantityCode PieceMonth = new QuantityCode { Value = "HMO" };

    /// <summary>
    /// million cubic metre
    /// </summary>
    public static readonly QuantityCode MillionCubicMetre = new QuantityCode { Value = "HMQ" };

    /// <summary>
    /// hectometre
    /// </summary>
    public static readonly QuantityCode Hectometre = new QuantityCode { Value = "HMT" };

    /// <summary>
    /// hectolitre of pure alcohol
    /// </summary>
    public static readonly QuantityCode HectolitreOfPureAlcohol = new QuantityCode { Value = "HPA" };

    /// <summary>
    /// hertz
    /// </summary>
    public static readonly QuantityCode Hertz = new QuantityCode { Value = "HTZ" };

    /// <summary>
    /// hour
    /// </summary>
    public static readonly QuantityCode Hour = new QuantityCode { Value = "HUR" };

    /// <summary>
    /// Piece Week
    /// </summary>
    public static readonly QuantityCode PieceWeek = new QuantityCode { Value = "HWE" };

    /// <summary>
    /// inch pound (pound inch)
    /// </summary>
    public static readonly QuantityCode InchPoundPoundInch = new QuantityCode { Value = "IA" };

    /// <summary>
    /// person
    /// </summary>
    public static readonly QuantityCode Person = new QuantityCode { Value = "IE" };

    /// <summary>
    /// inch
    /// </summary>
    public static readonly QuantityCode Inch = new QuantityCode { Value = "INH" };

    /// <summary>
    /// square inch
    /// </summary>
    public static readonly QuantityCode SquareInch = new QuantityCode { Value = "INK" };

    /// <summary>
    /// cubic inch
    /// </summary>
    public static readonly QuantityCode CubicInch = new QuantityCode { Value = "INQ" };

    /// <summary>
    /// international sugar degree
    /// </summary>
    public static readonly QuantityCode InternationalSugarDegree = new QuantityCode { Value = "ISD" };

    /// <summary>
    /// inch per second
    /// </summary>
    public static readonly QuantityCode InchPerSecond = new QuantityCode { Value = "IU" };

    /// <summary>
    /// international unit per gram
    /// </summary>
    public static readonly QuantityCode InternationalUnitPerGram = new QuantityCode { Value = "IUG" };

    /// <summary>
    /// inch per second squared
    /// </summary>
    public static readonly QuantityCode InchPerSecondSquared = new QuantityCode { Value = "IV" };

    /// <summary>
    /// percent per millimetre
    /// </summary>
    public static readonly QuantityCode PercentPerMillimetre = new QuantityCode { Value = "J10" };

    /// <summary>
    /// per mille per psi
    /// </summary>
    public static readonly QuantityCode PerMillePerPsi = new QuantityCode { Value = "J12" };

    /// <summary>
    /// degree API
    /// </summary>
    public static readonly QuantityCode DegreeAPI = new QuantityCode { Value = "J13" };

    /// <summary>
    /// degree Baume (origin scale)
    /// </summary>
    public static readonly QuantityCode DegreeBaumeOriginScale = new QuantityCode { Value = "J14" };

    /// <summary>
    /// degree Baume (US heavy)
    /// </summary>
    public static readonly QuantityCode DegreeBaumeUSHeavy = new QuantityCode { Value = "J15" };

    /// <summary>
    /// degree Baume (US light)
    /// </summary>
    public static readonly QuantityCode DegreeBaumeUSLight = new QuantityCode { Value = "J16" };

    /// <summary>
    /// degree Balling
    /// </summary>
    public static readonly QuantityCode DegreeBalling = new QuantityCode { Value = "J17" };

    /// <summary>
    /// degree Brix
    /// </summary>
    public static readonly QuantityCode DegreeBrix = new QuantityCode { Value = "J18" };

    /// <summary>
    /// degree Fahrenheit hour square foot per British thermal unit (thermochemical)
    /// </summary>
    public static readonly QuantityCode DegreeFahrenheitHourSquareFootPerBritishThermalUnitThermochemical = new QuantityCode { Value = "J19" };

    /// <summary>
    /// joule per kilogram
    /// </summary>
    public static readonly QuantityCode JoulePerKilogram = new QuantityCode { Value = "J2" };

    /// <summary>
    /// degree Fahrenheit per kelvin
    /// </summary>
    public static readonly QuantityCode DegreeFahrenheitPerKelvin = new QuantityCode { Value = "J20" };

    /// <summary>
    /// degree Fahrenheit per bar
    /// </summary>
    public static readonly QuantityCode DegreeFahrenheitPerBar = new QuantityCode { Value = "J21" };

    /// <summary>
    /// degree Fahrenheit hour square foot per British thermal unit (international table)
    /// </summary>
    public static readonly QuantityCode DegreeFahrenheitHourSquareFootPerBritishThermalUnitInternationalTable = new QuantityCode { Value = "J22" };

    /// <summary>
    /// degree Fahrenheit per hour
    /// </summary>
    public static readonly QuantityCode DegreeFahrenheitPerHour = new QuantityCode { Value = "J23" };

    /// <summary>
    /// degree Fahrenheit per minute
    /// </summary>
    public static readonly QuantityCode DegreeFahrenheitPerMinute = new QuantityCode { Value = "J24" };

    /// <summary>
    /// degree Fahrenheit per second
    /// </summary>
    public static readonly QuantityCode DegreeFahrenheitPerSecond = new QuantityCode { Value = "J25" };

    /// <summary>
    /// reciprocal degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode ReciprocalDegreeFahrenheit = new QuantityCode { Value = "J26" };

    /// <summary>
    /// degree Oechsle
    /// </summary>
    public static readonly QuantityCode DegreeOechsle = new QuantityCode { Value = "J27" };

    /// <summary>
    /// degree Rankine per hour
    /// </summary>
    public static readonly QuantityCode DegreeRankinePerHour = new QuantityCode { Value = "J28" };

    /// <summary>
    /// degree Rankine per minute
    /// </summary>
    public static readonly QuantityCode DegreeRankinePerMinute = new QuantityCode { Value = "J29" };

    /// <summary>
    /// degree Rankine per second
    /// </summary>
    public static readonly QuantityCode DegreeRankinePerSecond = new QuantityCode { Value = "J30" };

    /// <summary>
    /// degree Twaddell
    /// </summary>
    public static readonly QuantityCode DegreeTwaddell = new QuantityCode { Value = "J31" };

    /// <summary>
    /// micropoise
    /// </summary>
    public static readonly QuantityCode Micropoise = new QuantityCode { Value = "J32" };

    /// <summary>
    /// microgram per kilogram
    /// </summary>
    public static readonly QuantityCode MicrogramPerKilogram = new QuantityCode { Value = "J33" };

    /// <summary>
    /// microgram per cubic metre kelvin
    /// </summary>
    public static readonly QuantityCode MicrogramPerCubicMetreKelvin = new QuantityCode { Value = "J34" };

    /// <summary>
    /// microgram per cubic metre bar
    /// </summary>
    public static readonly QuantityCode MicrogramPerCubicMetreBar = new QuantityCode { Value = "J35" };

    /// <summary>
    /// microlitre per litre
    /// </summary>
    public static readonly QuantityCode MicrolitrePerLitre = new QuantityCode { Value = "J36" };

    /// <summary>
    /// baud
    /// </summary>
    public static readonly QuantityCode Baud = new QuantityCode { Value = "J38" };

    /// <summary>
    /// British thermal unit (mean)
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitMean = new QuantityCode { Value = "J39" };

    /// <summary>
    /// British thermal unit (international table) foot per hour square foot degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitInternationalTableFootPerHourSquareFootDegreeFahrenheit = new QuantityCode { Value = "J40" };

    /// <summary>
    /// British thermal unit (international table) inch per hour square foot degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitInternationalTableInchPerHourSquareFootDegreeFahrenheit = new QuantityCode { Value = "J41" };

    /// <summary>
    /// British thermal unit (international table) inch per second square foot degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitInternationalTableInchPerSecondSquareFootDegreeFahrenheit = new QuantityCode { Value = "J42" };

    /// <summary>
    /// British thermal unit (international table) per pound degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitInternationalTablePerPoundDegreeFahrenheit = new QuantityCode { Value = "J43" };

    /// <summary>
    /// British thermal unit (international table) per minute
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitInternationalTablePerMinute = new QuantityCode { Value = "J44" };

    /// <summary>
    /// British thermal unit (international table) per second
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitInternationalTablePerSecond = new QuantityCode { Value = "J45" };

    /// <summary>
    /// British thermal unit (thermochemical) foot per hour square foot degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitThermochemicalFootPerHourSquareFootDegreeFahrenheit = new QuantityCode { Value = "J46" };

    /// <summary>
    /// British thermal unit (thermochemical) per hour
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitThermochemicalPerHour = new QuantityCode { Value = "J47" };

    /// <summary>
    /// British thermal unit (thermochemical) inch per hour square foot degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitThermochemicalInchPerHourSquareFootDegreeFahrenheit = new QuantityCode { Value = "J48" };

    /// <summary>
    /// British thermal unit (thermochemical) inch per second square foot degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitThermochemicalInchPerSecondSquareFootDegreeFahrenheit = new QuantityCode { Value = "J49" };

    /// <summary>
    /// British thermal unit (thermochemical) per pound degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitThermochemicalPerPoundDegreeFahrenheit = new QuantityCode { Value = "J50" };

    /// <summary>
    /// British thermal unit (thermochemical) per minute
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitThermochemicalPerMinute = new QuantityCode { Value = "J51" };

    /// <summary>
    /// British thermal unit (thermochemical) per second
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitThermochemicalPerSecond = new QuantityCode { Value = "J52" };

    /// <summary>
    /// coulomb square metre per kilogram
    /// </summary>
    public static readonly QuantityCode CoulombSquareMetrePerKilogram = new QuantityCode { Value = "J53" };

    /// <summary>
    /// megabaud
    /// </summary>
    public static readonly QuantityCode Megabaud = new QuantityCode { Value = "J54" };

    /// <summary>
    /// watt second
    /// </summary>
    public static readonly QuantityCode WattSecond = new QuantityCode { Value = "J55" };

    /// <summary>
    /// bar per bar
    /// </summary>
    public static readonly QuantityCode BarPerBar = new QuantityCode { Value = "J56" };

    /// <summary>
    /// barrel (UK petroleum)
    /// </summary>
    public static readonly QuantityCode BarrelUKPetroleum = new QuantityCode { Value = "J57" };

    /// <summary>
    /// barrel (UK petroleum) per minute
    /// </summary>
    public static readonly QuantityCode BarrelUKPetroleumPerMinute = new QuantityCode { Value = "J58" };

    /// <summary>
    /// barrel (UK petroleum) per day
    /// </summary>
    public static readonly QuantityCode BarrelUKPetroleumPerDay = new QuantityCode { Value = "J59" };

    /// <summary>
    /// barrel (UK petroleum) per hour
    /// </summary>
    public static readonly QuantityCode BarrelUKPetroleumPerHour = new QuantityCode { Value = "J60" };

    /// <summary>
    /// barrel (UK petroleum) per second
    /// </summary>
    public static readonly QuantityCode BarrelUKPetroleumPerSecond = new QuantityCode { Value = "J61" };

    /// <summary>
    /// barrel (US petroleum) per hour
    /// </summary>
    public static readonly QuantityCode BarrelUSPetroleumPerHour = new QuantityCode { Value = "J62" };

    /// <summary>
    /// barrel (US petroleum) per second
    /// </summary>
    public static readonly QuantityCode BarrelUSPetroleumPerSecond = new QuantityCode { Value = "J63" };

    /// <summary>
    /// bushel (UK) per day
    /// </summary>
    public static readonly QuantityCode BushelUKPerDay = new QuantityCode { Value = "J64" };

    /// <summary>
    /// bushel (UK) per hour
    /// </summary>
    public static readonly QuantityCode BushelUKPerHour = new QuantityCode { Value = "J65" };

    /// <summary>
    /// bushel (UK) per minute
    /// </summary>
    public static readonly QuantityCode BushelUKPerMinute = new QuantityCode { Value = "J66" };

    /// <summary>
    /// bushel (UK) per second
    /// </summary>
    public static readonly QuantityCode BushelUKPerSecond = new QuantityCode { Value = "J67" };

    /// <summary>
    /// bushel (US dry) per day
    /// </summary>
    public static readonly QuantityCode BushelUSDryPerDay = new QuantityCode { Value = "J68" };

    /// <summary>
    /// bushel (US dry) per hour
    /// </summary>
    public static readonly QuantityCode BushelUSDryPerHour = new QuantityCode { Value = "J69" };

    /// <summary>
    /// bushel (US dry) per minute
    /// </summary>
    public static readonly QuantityCode BushelUSDryPerMinute = new QuantityCode { Value = "J70" };

    /// <summary>
    /// bushel (US dry) per second
    /// </summary>
    public static readonly QuantityCode BushelUSDryPerSecond = new QuantityCode { Value = "J71" };

    /// <summary>
    /// centinewton metre
    /// </summary>
    public static readonly QuantityCode CentinewtonMetre = new QuantityCode { Value = "J72" };

    /// <summary>
    /// centipoise per kelvin
    /// </summary>
    public static readonly QuantityCode CentipoisePerKelvin = new QuantityCode { Value = "J73" };

    /// <summary>
    /// centipoise per bar
    /// </summary>
    public static readonly QuantityCode CentipoisePerBar = new QuantityCode { Value = "J74" };

    /// <summary>
    /// calorie (mean)
    /// </summary>
    public static readonly QuantityCode CalorieMean = new QuantityCode { Value = "J75" };

    /// <summary>
    /// calorie (international table) per gram degree Celsius
    /// </summary>
    public static readonly QuantityCode CalorieInternationalTablePerGramDegreeCelsius = new QuantityCode { Value = "J76" };

    /// <summary>
    /// calorie (thermochemical) per centimetre second degree Celsius
    /// </summary>
    public static readonly QuantityCode CalorieThermochemicalPerCentimetreSecondDegreeCelsius = new QuantityCode { Value = "J78" };

    /// <summary>
    /// calorie (thermochemical) per gram degree Celsius
    /// </summary>
    public static readonly QuantityCode CalorieThermochemicalPerGramDegreeCelsius = new QuantityCode { Value = "J79" };

    /// <summary>
    /// calorie (thermochemical) per minute
    /// </summary>
    public static readonly QuantityCode CalorieThermochemicalPerMinute = new QuantityCode { Value = "J81" };

    /// <summary>
    /// calorie (thermochemical) per second
    /// </summary>
    public static readonly QuantityCode CalorieThermochemicalPerSecond = new QuantityCode { Value = "J82" };

    /// <summary>
    /// clo
    /// </summary>
    public static readonly QuantityCode Clo = new QuantityCode { Value = "J83" };

    /// <summary>
    /// centimetre per second kelvin
    /// </summary>
    public static readonly QuantityCode CentimetrePerSecondKelvin = new QuantityCode { Value = "J84" };

    /// <summary>
    /// centimetre per second bar
    /// </summary>
    public static readonly QuantityCode CentimetrePerSecondBar = new QuantityCode { Value = "J85" };

    /// <summary>
    /// cubic centimetre per cubic metre
    /// </summary>
    public static readonly QuantityCode CubicCentimetrePerCubicMetre = new QuantityCode { Value = "J87" };

    /// <summary>
    /// cubic decimetre per day
    /// </summary>
    public static readonly QuantityCode CubicDecimetrePerDay = new QuantityCode { Value = "J90" };

    /// <summary>
    /// cubic decimetre per cubic metre
    /// </summary>
    public static readonly QuantityCode CubicDecimetrePerCubicMetre = new QuantityCode { Value = "J91" };

    /// <summary>
    /// cubic decimetre per minute
    /// </summary>
    public static readonly QuantityCode CubicDecimetrePerMinute = new QuantityCode { Value = "J92" };

    /// <summary>
    /// cubic decimetre per second
    /// </summary>
    public static readonly QuantityCode CubicDecimetrePerSecond = new QuantityCode { Value = "J93" };

    /// <summary>
    /// ounce (UK fluid) per day
    /// </summary>
    public static readonly QuantityCode OunceUKFluidPerDay = new QuantityCode { Value = "J95" };

    /// <summary>
    /// ounce (UK fluid) per hour
    /// </summary>
    public static readonly QuantityCode OunceUKFluidPerHour = new QuantityCode { Value = "J96" };

    /// <summary>
    /// ounce (UK fluid) per minute
    /// </summary>
    public static readonly QuantityCode OunceUKFluidPerMinute = new QuantityCode { Value = "J97" };

    /// <summary>
    /// ounce (UK fluid) per second
    /// </summary>
    public static readonly QuantityCode OunceUKFluidPerSecond = new QuantityCode { Value = "J98" };

    /// <summary>
    /// ounce (US fluid) per day
    /// </summary>
    public static readonly QuantityCode OunceUSFluidPerDay = new QuantityCode { Value = "J99" };

    /// <summary>
    /// joule per kelvin
    /// </summary>
    public static readonly QuantityCode JoulePerKelvin = new QuantityCode { Value = "JE" };

    /// <summary>
    /// megajoule per kilogram
    /// </summary>
    public static readonly QuantityCode MegajoulePerKilogram = new QuantityCode { Value = "JK" };

    /// <summary>
    /// megajoule per cubic metre
    /// </summary>
    public static readonly QuantityCode MegajoulePerCubicMetre = new QuantityCode { Value = "JM" };

    /// <summary>
    /// pipeline joint
    /// </summary>
    public static readonly QuantityCode PipelineJoint = new QuantityCode { Value = "JNT" };

    /// <summary>
    /// joule
    /// </summary>
    public static readonly QuantityCode Joule = new QuantityCode { Value = "JOU" };

    /// <summary>
    /// hundred metre
    /// </summary>
    public static readonly QuantityCode HundredMetre = new QuantityCode { Value = "JPS" };

    /// <summary>
    /// number of jewels
    /// </summary>
    public static readonly QuantityCode NumberOfJewels = new QuantityCode { Value = "JWL" };

    /// <summary>
    /// kilowatt demand
    /// </summary>
    public static readonly QuantityCode KilowattDemand = new QuantityCode { Value = "K1" };

    /// <summary>
    /// ounce (US fluid) per hour
    /// </summary>
    public static readonly QuantityCode OunceUSFluidPerHour = new QuantityCode { Value = "K10" };

    /// <summary>
    /// ounce (US fluid) per minute
    /// </summary>
    public static readonly QuantityCode OunceUSFluidPerMinute = new QuantityCode { Value = "K11" };

    /// <summary>
    /// ounce (US fluid) per second
    /// </summary>
    public static readonly QuantityCode OunceUSFluidPerSecond = new QuantityCode { Value = "K12" };

    /// <summary>
    /// foot per degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode FootPerDegreeFahrenheit = new QuantityCode { Value = "K13" };

    /// <summary>
    /// foot per hour
    /// </summary>
    public static readonly QuantityCode FootPerHour = new QuantityCode { Value = "K14" };

    /// <summary>
    /// foot pound-force per hour
    /// </summary>
    public static readonly QuantityCode FootPoundForcePerHour = new QuantityCode { Value = "K15" };

    /// <summary>
    /// foot pound-force per minute
    /// </summary>
    public static readonly QuantityCode FootPoundForcePerMinute = new QuantityCode { Value = "K16" };

    /// <summary>
    /// foot per psi
    /// </summary>
    public static readonly QuantityCode FootPerPsi = new QuantityCode { Value = "K17" };

    /// <summary>
    /// foot per second degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode FootPerSecondDegreeFahrenheit = new QuantityCode { Value = "K18" };

    /// <summary>
    /// foot per second psi
    /// </summary>
    public static readonly QuantityCode FootPerSecondPsi = new QuantityCode { Value = "K19" };

    /// <summary>
    /// kilovolt ampere reactive demand
    /// </summary>
    public static readonly QuantityCode KilovoltAmpereReactiveDemand = new QuantityCode { Value = "K2" };

    /// <summary>
    /// reciprocal cubic foot
    /// </summary>
    public static readonly QuantityCode ReciprocalCubicFoot = new QuantityCode { Value = "K20" };

    /// <summary>
    /// cubic foot per degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode CubicFootPerDegreeFahrenheit = new QuantityCode { Value = "K21" };

    /// <summary>
    /// cubic foot per day
    /// </summary>
    public static readonly QuantityCode CubicFootPerDay = new QuantityCode { Value = "K22" };

    /// <summary>
    /// cubic foot per psi
    /// </summary>
    public static readonly QuantityCode CubicFootPerPsi = new QuantityCode { Value = "K23" };

    /// <summary>
    /// gallon (UK) per day
    /// </summary>
    public static readonly QuantityCode GallonUKPerDay = new QuantityCode { Value = "K26" };

    /// <summary>
    /// gallon (UK) per hour
    /// </summary>
    public static readonly QuantityCode GallonUKPerHour = new QuantityCode { Value = "K27" };

    /// <summary>
    /// gallon (UK) per second
    /// </summary>
    public static readonly QuantityCode GallonUKPerSecond = new QuantityCode { Value = "K28" };

    /// <summary>
    /// kilovolt ampere reactive hour
    /// </summary>
    public static readonly QuantityCode KilovoltAmpereReactiveHour = new QuantityCode { Value = "K3" };

    /// <summary>
    /// gallon (US liquid) per second
    /// </summary>
    public static readonly QuantityCode GallonUSLiquidPerSecond = new QuantityCode { Value = "K30" };

    /// <summary>
    /// gram-force per square centimetre
    /// </summary>
    public static readonly QuantityCode GramForcePerSquareCentimetre = new QuantityCode { Value = "K31" };

    /// <summary>
    /// gill (UK) per day
    /// </summary>
    public static readonly QuantityCode GillUKPerDay = new QuantityCode { Value = "K32" };

    /// <summary>
    /// gill (UK) per hour
    /// </summary>
    public static readonly QuantityCode GillUKPerHour = new QuantityCode { Value = "K33" };

    /// <summary>
    /// gill (UK) per minute
    /// </summary>
    public static readonly QuantityCode GillUKPerMinute = new QuantityCode { Value = "K34" };

    /// <summary>
    /// gill (UK) per second
    /// </summary>
    public static readonly QuantityCode GillUKPerSecond = new QuantityCode { Value = "K35" };

    /// <summary>
    /// gill (US) per day
    /// </summary>
    public static readonly QuantityCode GillUSPerDay = new QuantityCode { Value = "K36" };

    /// <summary>
    /// gill (US) per hour
    /// </summary>
    public static readonly QuantityCode GillUSPerHour = new QuantityCode { Value = "K37" };

    /// <summary>
    /// gill (US) per minute
    /// </summary>
    public static readonly QuantityCode GillUSPerMinute = new QuantityCode { Value = "K38" };

    /// <summary>
    /// gill (US) per second
    /// </summary>
    public static readonly QuantityCode GillUSPerSecond = new QuantityCode { Value = "K39" };

    /// <summary>
    /// standard acceleration of free fall
    /// </summary>
    public static readonly QuantityCode StandardAccelerationOfFreeFall = new QuantityCode { Value = "K40" };

    /// <summary>
    /// grain per gallon (US)
    /// </summary>
    public static readonly QuantityCode GrainPerGallonUS = new QuantityCode { Value = "K41" };

    /// <summary>
    /// horsepower (boiler)
    /// </summary>
    public static readonly QuantityCode HorsepowerBoiler = new QuantityCode { Value = "K42" };

    /// <summary>
    /// horsepower (electric)
    /// </summary>
    public static readonly QuantityCode HorsepowerElectric = new QuantityCode { Value = "K43" };

    /// <summary>
    /// inch per degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode InchPerDegreeFahrenheit = new QuantityCode { Value = "K45" };

    /// <summary>
    /// inch per psi
    /// </summary>
    public static readonly QuantityCode InchPerPsi = new QuantityCode { Value = "K46" };

    /// <summary>
    /// inch per second degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode InchPerSecondDegreeFahrenheit = new QuantityCode { Value = "K47" };

    /// <summary>
    /// inch per second psi
    /// </summary>
    public static readonly QuantityCode InchPerSecondPsi = new QuantityCode { Value = "K48" };

    /// <summary>
    /// reciprocal cubic inch
    /// </summary>
    public static readonly QuantityCode ReciprocalCubicInch = new QuantityCode { Value = "K49" };

    /// <summary>
    /// kilobaud
    /// </summary>
    public static readonly QuantityCode Kilobaud = new QuantityCode { Value = "K50" };

    /// <summary>
    /// kilocalorie (mean)
    /// </summary>
    public static readonly QuantityCode KilocalorieMean = new QuantityCode { Value = "K51" };

    /// <summary>
    /// kilocalorie (international table) per hour metre degree Celsius
    /// </summary>
    public static readonly QuantityCode KilocalorieInternationalTablePerHourMetreDegreeCelsius = new QuantityCode { Value = "K52" };

    /// <summary>
    /// kilocalorie (thermochemical)
    /// </summary>
    public static readonly QuantityCode KilocalorieThermochemical = new QuantityCode { Value = "K53" };

    /// <summary>
    /// kilocalorie (thermochemical) per minute
    /// </summary>
    public static readonly QuantityCode KilocalorieThermochemicalPerMinute = new QuantityCode { Value = "K54" };

    /// <summary>
    /// kilocalorie (thermochemical) per second
    /// </summary>
    public static readonly QuantityCode KilocalorieThermochemicalPerSecond = new QuantityCode { Value = "K55" };

    /// <summary>
    /// kilomole per hour
    /// </summary>
    public static readonly QuantityCode KilomolePerHour = new QuantityCode { Value = "K58" };

    /// <summary>
    /// kilomole per cubic metre kelvin
    /// </summary>
    public static readonly QuantityCode KilomolePerCubicMetreKelvin = new QuantityCode { Value = "K59" };

    /// <summary>
    /// kilolitre
    /// </summary>
    public static readonly QuantityCode Kilolitre = new QuantityCode { Value = "K6" };

    /// <summary>
    /// kilomole per cubic metre bar
    /// </summary>
    public static readonly QuantityCode KilomolePerCubicMetreBar = new QuantityCode { Value = "K60" };

    /// <summary>
    /// kilomole per minute
    /// </summary>
    public static readonly QuantityCode KilomolePerMinute = new QuantityCode { Value = "K61" };

    /// <summary>
    /// litre per litre
    /// </summary>
    public static readonly QuantityCode LitrePerLitre = new QuantityCode { Value = "K62" };

    /// <summary>
    /// reciprocal litre
    /// </summary>
    public static readonly QuantityCode ReciprocalLitre = new QuantityCode { Value = "K63" };

    /// <summary>
    /// pound (avoirdupois) per degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode PoundAvoirdupoisPerDegreeFahrenheit = new QuantityCode { Value = "K64" };

    /// <summary>
    /// pound (avoirdupois) square foot
    /// </summary>
    public static readonly QuantityCode PoundAvoirdupoisSquareFoot = new QuantityCode { Value = "K65" };

    /// <summary>
    /// pound (avoirdupois) per day
    /// </summary>
    public static readonly QuantityCode PoundAvoirdupoisPerDay = new QuantityCode { Value = "K66" };

    /// <summary>
    /// pound per foot hour
    /// </summary>
    public static readonly QuantityCode PoundPerFootHour = new QuantityCode { Value = "K67" };

    /// <summary>
    /// pound per foot second
    /// </summary>
    public static readonly QuantityCode PoundPerFootSecond = new QuantityCode { Value = "K68" };

    /// <summary>
    /// pound (avoirdupois) per cubic foot degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode PoundAvoirdupoisPerCubicFootDegreeFahrenheit = new QuantityCode { Value = "K69" };

    /// <summary>
    /// pound (avoirdupois) per cubic foot psi
    /// </summary>
    public static readonly QuantityCode PoundAvoirdupoisPerCubicFootPsi = new QuantityCode { Value = "K70" };

    /// <summary>
    /// pound (avoirdupois) per gallon (UK)
    /// </summary>
    public static readonly QuantityCode PoundAvoirdupoisPerGallonUK = new QuantityCode { Value = "K71" };

    /// <summary>
    /// pound (avoirdupois) per hour degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode PoundAvoirdupoisPerHourDegreeFahrenheit = new QuantityCode { Value = "K73" };

    /// <summary>
    /// pound (avoirdupois) per hour psi
    /// </summary>
    public static readonly QuantityCode PoundAvoirdupoisPerHourPsi = new QuantityCode { Value = "K74" };

    /// <summary>
    /// pound (avoirdupois) per cubic inch degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode PoundAvoirdupoisPerCubicInchDegreeFahrenheit = new QuantityCode { Value = "K75" };

    /// <summary>
    /// pound (avoirdupois) per cubic inch psi
    /// </summary>
    public static readonly QuantityCode PoundAvoirdupoisPerCubicInchPsi = new QuantityCode { Value = "K76" };

    /// <summary>
    /// pound (avoirdupois) per psi
    /// </summary>
    public static readonly QuantityCode PoundAvoirdupoisPerPsi = new QuantityCode { Value = "K77" };

    /// <summary>
    /// pound (avoirdupois) per minute
    /// </summary>
    public static readonly QuantityCode PoundAvoirdupoisPerMinute = new QuantityCode { Value = "K78" };

    /// <summary>
    /// pound (avoirdupois) per minute degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode PoundAvoirdupoisPerMinuteDegreeFahrenheit = new QuantityCode { Value = "K79" };

    /// <summary>
    /// pound (avoirdupois) per minute psi
    /// </summary>
    public static readonly QuantityCode PoundAvoirdupoisPerMinutePsi = new QuantityCode { Value = "K80" };

    /// <summary>
    /// pound (avoirdupois) per second
    /// </summary>
    public static readonly QuantityCode PoundAvoirdupoisPerSecond = new QuantityCode { Value = "K81" };

    /// <summary>
    /// pound (avoirdupois) per second degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode PoundAvoirdupoisPerSecondDegreeFahrenheit = new QuantityCode { Value = "K82" };

    /// <summary>
    /// pound (avoirdupois) per second psi
    /// </summary>
    public static readonly QuantityCode PoundAvoirdupoisPerSecondPsi = new QuantityCode { Value = "K83" };

    /// <summary>
    /// pound per cubic yard
    /// </summary>
    public static readonly QuantityCode PoundPerCubicYard = new QuantityCode { Value = "K84" };

    /// <summary>
    /// pound-force per square foot
    /// </summary>
    public static readonly QuantityCode PoundForcePerSquareFoot = new QuantityCode { Value = "K85" };

    /// <summary>
    /// pound-force per square inch degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode PoundForcePerSquareInchDegreeFahrenheit = new QuantityCode { Value = "K86" };

    /// <summary>
    /// psi cubic inch per second
    /// </summary>
    public static readonly QuantityCode PsiCubicInchPerSecond = new QuantityCode { Value = "K87" };

    /// <summary>
    /// psi litre per second
    /// </summary>
    public static readonly QuantityCode PsiLitrePerSecond = new QuantityCode { Value = "K88" };

    /// <summary>
    /// psi cubic metre per second
    /// </summary>
    public static readonly QuantityCode PsiCubicMetrePerSecond = new QuantityCode { Value = "K89" };

    /// <summary>
    /// psi cubic yard per second
    /// </summary>
    public static readonly QuantityCode PsiCubicYardPerSecond = new QuantityCode { Value = "K90" };

    /// <summary>
    /// pound-force second per square foot
    /// </summary>
    public static readonly QuantityCode PoundForceSecondPerSquareFoot = new QuantityCode { Value = "K91" };

    /// <summary>
    /// pound-force second per square inch
    /// </summary>
    public static readonly QuantityCode PoundForceSecondPerSquareInch = new QuantityCode { Value = "K92" };

    /// <summary>
    /// reciprocal psi
    /// </summary>
    public static readonly QuantityCode ReciprocalPsi = new QuantityCode { Value = "K93" };

    /// <summary>
    /// quart (UK liquid) per day
    /// </summary>
    public static readonly QuantityCode QuartUKLiquidPerDay = new QuantityCode { Value = "K94" };

    /// <summary>
    /// quart (UK liquid) per hour
    /// </summary>
    public static readonly QuantityCode QuartUKLiquidPerHour = new QuantityCode { Value = "K95" };

    /// <summary>
    /// quart (UK liquid) per minute
    /// </summary>
    public static readonly QuantityCode QuartUKLiquidPerMinute = new QuantityCode { Value = "K96" };

    /// <summary>
    /// quart (UK liquid) per second
    /// </summary>
    public static readonly QuantityCode QuartUKLiquidPerSecond = new QuantityCode { Value = "K97" };

    /// <summary>
    /// quart (US liquid) per day
    /// </summary>
    public static readonly QuantityCode QuartUSLiquidPerDay = new QuantityCode { Value = "K98" };

    /// <summary>
    /// quart (US liquid) per hour
    /// </summary>
    public static readonly QuantityCode QuartUSLiquidPerHour = new QuantityCode { Value = "K99" };

    /// <summary>
    /// cake
    /// </summary>
    public static readonly QuantityCode Cake = new QuantityCode { Value = "KA" };

    /// <summary>
    /// katal
    /// </summary>
    public static readonly QuantityCode Katal = new QuantityCode { Value = "KAT" };

    /// <summary>
    /// kilocharacter
    /// </summary>
    public static readonly QuantityCode Kilocharacter = new QuantityCode { Value = "KB" };

    /// <summary>
    /// kilobar
    /// </summary>
    public static readonly QuantityCode Kilobar = new QuantityCode { Value = "KBA" };

    /// <summary>
    /// kilogram of choline chloride
    /// </summary>
    public static readonly QuantityCode KilogramOfCholineChloride = new QuantityCode { Value = "KCC" };

    /// <summary>
    /// kilogram drained net weight
    /// </summary>
    public static readonly QuantityCode KilogramDrainedNetWeight = new QuantityCode { Value = "KDW" };

    /// <summary>
    /// kelvin
    /// </summary>
    public static readonly QuantityCode Kelvin = new QuantityCode { Value = "KEL" };

    /// <summary>
    /// kilogram
    /// </summary>
    public static readonly QuantityCode Kilogram = new QuantityCode { Value = "KGM" };

    /// <summary>
    /// kilogram per second
    /// </summary>
    public static readonly QuantityCode KilogramPerSecond = new QuantityCode { Value = "KGS" };

    /// <summary>
    /// kilogram of hydrogen peroxide
    /// </summary>
    public static readonly QuantityCode KilogramOfHydrogenPeroxide = new QuantityCode { Value = "KHY" };

    /// <summary>
    /// kilohertz
    /// </summary>
    public static readonly QuantityCode Kilohertz = new QuantityCode { Value = "KHZ" };

    /// <summary>
    /// kilogram per millimetre width
    /// </summary>
    public static readonly QuantityCode KilogramPerMillimetreWidth = new QuantityCode { Value = "KI" };

    /// <summary>
    /// kilogram, including container
    /// </summary>
    public static readonly QuantityCode KilogramIncludingContainer = new QuantityCode { Value = "KIC" };

    /// <summary>
    /// kilogram, including inner packaging
    /// </summary>
    public static readonly QuantityCode KilogramIncludingInnerPackaging = new QuantityCode { Value = "KIP" };

    /// <summary>
    /// kilosegment
    /// </summary>
    public static readonly QuantityCode Kilosegment = new QuantityCode { Value = "KJ" };

    /// <summary>
    /// kilojoule
    /// </summary>
    public static readonly QuantityCode Kilojoule = new QuantityCode { Value = "KJO" };

    /// <summary>
    /// kilogram per metre
    /// </summary>
    public static readonly QuantityCode KilogramPerMetre = new QuantityCode { Value = "KL" };

    /// <summary>
    /// lactic dry material percentage
    /// </summary>
    public static readonly QuantityCode LacticDryMaterialPercentage = new QuantityCode { Value = "KLK" };

    /// <summary>
    /// kilolux
    /// </summary>
    public static readonly QuantityCode Kilolux = new QuantityCode { Value = "KLX" };

    /// <summary>
    /// kilogram of methylamine
    /// </summary>
    public static readonly QuantityCode KilogramOfMethylamine = new QuantityCode { Value = "KMA" };

    /// <summary>
    /// kilometre per hour
    /// </summary>
    public static readonly QuantityCode KilometrePerHour = new QuantityCode { Value = "KMH" };

    /// <summary>
    /// square kilometre
    /// </summary>
    public static readonly QuantityCode SquareKilometre = new QuantityCode { Value = "KMK" };

    /// <summary>
    /// kilogram per cubic metre
    /// </summary>
    public static readonly QuantityCode KilogramPerCubicMetre = new QuantityCode { Value = "KMQ" };

    /// <summary>
    /// kilometre
    /// </summary>
    public static readonly QuantityCode Kilometre = new QuantityCode { Value = "KMT" };

    /// <summary>
    /// kilogram of nitrogen
    /// </summary>
    public static readonly QuantityCode KilogramOfNitrogen = new QuantityCode { Value = "KNI" };

    /// <summary>
    /// kilonewton per square metre
    /// </summary>
    public static readonly QuantityCode KilonewtonPerSquareMetre = new QuantityCode { Value = "KNM" };

    /// <summary>
    /// kilogram named substance
    /// </summary>
    public static readonly QuantityCode KilogramNamedSubstance = new QuantityCode { Value = "KNS" };

    /// <summary>
    /// knot
    /// </summary>
    public static readonly QuantityCode Knot = new QuantityCode { Value = "KNT" };

    /// <summary>
    /// milliequivalence caustic potash per gram of product
    /// </summary>
    public static readonly QuantityCode MilliequivalenceCausticPotashPerGramOfProduct = new QuantityCode { Value = "KO" };

    /// <summary>
    /// kilopascal
    /// </summary>
    public static readonly QuantityCode Kilopascal = new QuantityCode { Value = "KPA" };

    /// <summary>
    /// kilogram of potassium hydroxide (caustic potash)
    /// </summary>
    public static readonly QuantityCode KilogramOfPotassiumHydroxideCausticPotash = new QuantityCode { Value = "KPH" };

    /// <summary>
    /// kilogram of potassium oxide
    /// </summary>
    public static readonly QuantityCode KilogramOfPotassiumOxide = new QuantityCode { Value = "KPO" };

    /// <summary>
    /// kilogram of phosphorus pentoxide (phosphoric anhydride)
    /// </summary>
    public static readonly QuantityCode KilogramOfPhosphorusPentoxidePhosphoricAnhydride = new QuantityCode { Value = "KPP" };

    /// <summary>
    /// kiloroentgen
    /// </summary>
    public static readonly QuantityCode Kiloroentgen = new QuantityCode { Value = "KR" };

    /// <summary>
    /// kilogram of substance 90 % dry
    /// </summary>
    public static readonly QuantityCode KilogramOfSubstance90Dry = new QuantityCode { Value = "KSD" };

    /// <summary>
    /// kilogram of sodium hydroxide (caustic soda)
    /// </summary>
    public static readonly QuantityCode KilogramOfSodiumHydroxideCausticSoda = new QuantityCode { Value = "KSH" };

    /// <summary>
    /// kit
    /// </summary>
    public static readonly QuantityCode Kit = new QuantityCode { Value = "KT" };

    /// <summary>
    /// kilotonne
    /// </summary>
    public static readonly QuantityCode Kilotonne = new QuantityCode { Value = "KTN" };

    /// <summary>
    /// kilogram of uranium
    /// </summary>
    public static readonly QuantityCode KilogramOfUranium = new QuantityCode { Value = "KUR" };

    /// <summary>
    /// kilovolt - ampere
    /// </summary>
    public static readonly QuantityCode KilovoltAmpere = new QuantityCode { Value = "KVA" };

    /// <summary>
    /// kilovar
    /// </summary>
    public static readonly QuantityCode Kilovar = new QuantityCode { Value = "KVR" };

    /// <summary>
    /// kilovolt
    /// </summary>
    public static readonly QuantityCode Kilovolt = new QuantityCode { Value = "KVT" };

    /// <summary>
    /// kilogram per millimetre
    /// </summary>
    public static readonly QuantityCode KilogramPerMillimetre = new QuantityCode { Value = "KW" };

    /// <summary>
    /// kilowatt hour
    /// </summary>
    public static readonly QuantityCode KilowattHour = new QuantityCode { Value = "KWH" };

    /// <summary>
    /// Kilowatt hour per normalized cubic metre
    /// </summary>
    public static readonly QuantityCode KilowattHourPerNormalizedCubicMetre = new QuantityCode { Value = "KWN" };

    /// <summary>
    /// kilogram of tungsten trioxide
    /// </summary>
    public static readonly QuantityCode KilogramOfTungstenTrioxide = new QuantityCode { Value = "KWO" };

    /// <summary>
    /// Kilowatt hour per standard cubic metre
    /// </summary>
    public static readonly QuantityCode KilowattHourPerStandardCubicMetre = new QuantityCode { Value = "KWS" };

    /// <summary>
    /// kilowatt
    /// </summary>
    public static readonly QuantityCode Kilowatt = new QuantityCode { Value = "KWT" };

    /// <summary>
    /// kilowatt year
    /// </summary>
    public static readonly QuantityCode KilowattYear = new QuantityCode { Value = "KWY" };

    /// <summary>
    /// millilitre per kilogram
    /// </summary>
    public static readonly QuantityCode MillilitrePerKilogram = new QuantityCode { Value = "KX" };

    /// <summary>
    /// quart (US liquid) per minute
    /// </summary>
    public static readonly QuantityCode QuartUSLiquidPerMinute = new QuantityCode { Value = "L10" };

    /// <summary>
    /// quart (US liquid) per second
    /// </summary>
    public static readonly QuantityCode QuartUSLiquidPerSecond = new QuantityCode { Value = "L11" };

    /// <summary>
    /// metre per second kelvin
    /// </summary>
    public static readonly QuantityCode MetrePerSecondKelvin = new QuantityCode { Value = "L12" };

    /// <summary>
    /// metre per second bar
    /// </summary>
    public static readonly QuantityCode MetrePerSecondBar = new QuantityCode { Value = "L13" };

    /// <summary>
    /// square metre hour degree Celsius per kilocalorie (international table)
    /// </summary>
    public static readonly QuantityCode SquareMetreHourDegreeCelsiusPerKilocalorieInternationalTable = new QuantityCode { Value = "L14" };

    /// <summary>
    /// millipascal second per kelvin
    /// </summary>
    public static readonly QuantityCode MillipascalSecondPerKelvin = new QuantityCode { Value = "L15" };

    /// <summary>
    /// millipascal second per bar
    /// </summary>
    public static readonly QuantityCode MillipascalSecondPerBar = new QuantityCode { Value = "L16" };

    /// <summary>
    /// milligram per cubic metre kelvin
    /// </summary>
    public static readonly QuantityCode MilligramPerCubicMetreKelvin = new QuantityCode { Value = "L17" };

    /// <summary>
    /// milligram per cubic metre bar
    /// </summary>
    public static readonly QuantityCode MilligramPerCubicMetreBar = new QuantityCode { Value = "L18" };

    /// <summary>
    /// millilitre per litre
    /// </summary>
    public static readonly QuantityCode MillilitrePerLitre = new QuantityCode { Value = "L19" };

    /// <summary>
    /// litre per minute
    /// </summary>
    public static readonly QuantityCode LitrePerMinute = new QuantityCode { Value = "L2" };

    /// <summary>
    /// reciprocal cubic millimetre
    /// </summary>
    public static readonly QuantityCode ReciprocalCubicMillimetre = new QuantityCode { Value = "L20" };

    /// <summary>
    /// cubic millimetre per cubic metre
    /// </summary>
    public static readonly QuantityCode CubicMillimetrePerCubicMetre = new QuantityCode { Value = "L21" };

    /// <summary>
    /// mole per hour
    /// </summary>
    public static readonly QuantityCode MolePerHour = new QuantityCode { Value = "L23" };

    /// <summary>
    /// mole per kilogram kelvin
    /// </summary>
    public static readonly QuantityCode MolePerKilogramKelvin = new QuantityCode { Value = "L24" };

    /// <summary>
    /// mole per kilogram bar
    /// </summary>
    public static readonly QuantityCode MolePerKilogramBar = new QuantityCode { Value = "L25" };

    /// <summary>
    /// mole per litre kelvin
    /// </summary>
    public static readonly QuantityCode MolePerLitreKelvin = new QuantityCode { Value = "L26" };

    /// <summary>
    /// mole per litre bar
    /// </summary>
    public static readonly QuantityCode MolePerLitreBar = new QuantityCode { Value = "L27" };

    /// <summary>
    /// mole per cubic metre kelvin
    /// </summary>
    public static readonly QuantityCode MolePerCubicMetreKelvin = new QuantityCode { Value = "L28" };

    /// <summary>
    /// mole per cubic metre bar
    /// </summary>
    public static readonly QuantityCode MolePerCubicMetreBar = new QuantityCode { Value = "L29" };

    /// <summary>
    /// mole per minute
    /// </summary>
    public static readonly QuantityCode MolePerMinute = new QuantityCode { Value = "L30" };

    /// <summary>
    /// milliroentgen aequivalent men
    /// </summary>
    public static readonly QuantityCode MilliroentgenAequivalentMen = new QuantityCode { Value = "L31" };

    /// <summary>
    /// nanogram per kilogram
    /// </summary>
    public static readonly QuantityCode NanogramPerKilogram = new QuantityCode { Value = "L32" };

    /// <summary>
    /// ounce (avoirdupois) per day
    /// </summary>
    public static readonly QuantityCode OunceAvoirdupoisPerDay = new QuantityCode { Value = "L33" };

    /// <summary>
    /// ounce (avoirdupois) per hour
    /// </summary>
    public static readonly QuantityCode OunceAvoirdupoisPerHour = new QuantityCode { Value = "L34" };

    /// <summary>
    /// ounce (avoirdupois) per minute
    /// </summary>
    public static readonly QuantityCode OunceAvoirdupoisPerMinute = new QuantityCode { Value = "L35" };

    /// <summary>
    /// ounce (avoirdupois) per second
    /// </summary>
    public static readonly QuantityCode OunceAvoirdupoisPerSecond = new QuantityCode { Value = "L36" };

    /// <summary>
    /// ounce (avoirdupois) per gallon (UK)
    /// </summary>
    public static readonly QuantityCode OunceAvoirdupoisPerGallonUK = new QuantityCode { Value = "L37" };

    /// <summary>
    /// ounce (avoirdupois) per gallon (US)
    /// </summary>
    public static readonly QuantityCode OunceAvoirdupoisPerGallonUS = new QuantityCode { Value = "L38" };

    /// <summary>
    /// ounce (avoirdupois) per cubic inch
    /// </summary>
    public static readonly QuantityCode OunceAvoirdupoisPerCubicInch = new QuantityCode { Value = "L39" };

    /// <summary>
    /// ounce (avoirdupois)-force
    /// </summary>
    public static readonly QuantityCode OunceAvoirdupoisForce = new QuantityCode { Value = "L40" };

    /// <summary>
    /// ounce (avoirdupois)-force inch
    /// </summary>
    public static readonly QuantityCode OunceAvoirdupoisForceInch = new QuantityCode { Value = "L41" };

    /// <summary>
    /// picosiemens per metre
    /// </summary>
    public static readonly QuantityCode PicosiemensPerMetre = new QuantityCode { Value = "L42" };

    /// <summary>
    /// peck (UK)
    /// </summary>
    public static readonly QuantityCode PeckUK = new QuantityCode { Value = "L43" };

    /// <summary>
    /// peck (UK) per day
    /// </summary>
    public static readonly QuantityCode PeckUKPerDay = new QuantityCode { Value = "L44" };

    /// <summary>
    /// peck (UK) per hour
    /// </summary>
    public static readonly QuantityCode PeckUKPerHour = new QuantityCode { Value = "L45" };

    /// <summary>
    /// peck (UK) per minute
    /// </summary>
    public static readonly QuantityCode PeckUKPerMinute = new QuantityCode { Value = "L46" };

    /// <summary>
    /// peck (UK) per second
    /// </summary>
    public static readonly QuantityCode PeckUKPerSecond = new QuantityCode { Value = "L47" };

    /// <summary>
    /// peck (US dry) per day
    /// </summary>
    public static readonly QuantityCode PeckUSDryPerDay = new QuantityCode { Value = "L48" };

    /// <summary>
    /// peck (US dry) per hour
    /// </summary>
    public static readonly QuantityCode PeckUSDryPerHour = new QuantityCode { Value = "L49" };

    /// <summary>
    /// peck (US dry) per minute
    /// </summary>
    public static readonly QuantityCode PeckUSDryPerMinute = new QuantityCode { Value = "L50" };

    /// <summary>
    /// peck (US dry) per second
    /// </summary>
    public static readonly QuantityCode PeckUSDryPerSecond = new QuantityCode { Value = "L51" };

    /// <summary>
    /// psi per psi
    /// </summary>
    public static readonly QuantityCode PsiPerPsi = new QuantityCode { Value = "L52" };

    /// <summary>
    /// pint (UK) per day
    /// </summary>
    public static readonly QuantityCode PintUKPerDay = new QuantityCode { Value = "L53" };

    /// <summary>
    /// pint (UK) per hour
    /// </summary>
    public static readonly QuantityCode PintUKPerHour = new QuantityCode { Value = "L54" };

    /// <summary>
    /// pint (UK) per minute
    /// </summary>
    public static readonly QuantityCode PintUKPerMinute = new QuantityCode { Value = "L55" };

    /// <summary>
    /// pint (UK) per second
    /// </summary>
    public static readonly QuantityCode PintUKPerSecond = new QuantityCode { Value = "L56" };

    /// <summary>
    /// pint (US liquid) per day
    /// </summary>
    public static readonly QuantityCode PintUSLiquidPerDay = new QuantityCode { Value = "L57" };

    /// <summary>
    /// pint (US liquid) per hour
    /// </summary>
    public static readonly QuantityCode PintUSLiquidPerHour = new QuantityCode { Value = "L58" };

    /// <summary>
    /// pint (US liquid) per minute
    /// </summary>
    public static readonly QuantityCode PintUSLiquidPerMinute = new QuantityCode { Value = "L59" };

    /// <summary>
    /// pint (US liquid) per second
    /// </summary>
    public static readonly QuantityCode PintUSLiquidPerSecond = new QuantityCode { Value = "L60" };

    /// <summary>
    /// slug per day
    /// </summary>
    public static readonly QuantityCode SlugPerDay = new QuantityCode { Value = "L63" };

    /// <summary>
    /// slug per foot second
    /// </summary>
    public static readonly QuantityCode SlugPerFootSecond = new QuantityCode { Value = "L64" };

    /// <summary>
    /// slug per cubic foot
    /// </summary>
    public static readonly QuantityCode SlugPerCubicFoot = new QuantityCode { Value = "L65" };

    /// <summary>
    /// slug per hour
    /// </summary>
    public static readonly QuantityCode SlugPerHour = new QuantityCode { Value = "L66" };

    /// <summary>
    /// slug per minute
    /// </summary>
    public static readonly QuantityCode SlugPerMinute = new QuantityCode { Value = "L67" };

    /// <summary>
    /// slug per second
    /// </summary>
    public static readonly QuantityCode SlugPerSecond = new QuantityCode { Value = "L68" };

    /// <summary>
    /// tonne per kelvin
    /// </summary>
    public static readonly QuantityCode TonnePerKelvin = new QuantityCode { Value = "L69" };

    /// <summary>
    /// tonne per bar
    /// </summary>
    public static readonly QuantityCode TonnePerBar = new QuantityCode { Value = "L70" };

    /// <summary>
    /// tonne per day
    /// </summary>
    public static readonly QuantityCode TonnePerDay = new QuantityCode { Value = "L71" };

    /// <summary>
    /// tonne per day kelvin
    /// </summary>
    public static readonly QuantityCode TonnePerDayKelvin = new QuantityCode { Value = "L72" };

    /// <summary>
    /// tonne per day bar
    /// </summary>
    public static readonly QuantityCode TonnePerDayBar = new QuantityCode { Value = "L73" };

    /// <summary>
    /// tonne per hour kelvin
    /// </summary>
    public static readonly QuantityCode TonnePerHourKelvin = new QuantityCode { Value = "L74" };

    /// <summary>
    /// tonne per hour bar
    /// </summary>
    public static readonly QuantityCode TonnePerHourBar = new QuantityCode { Value = "L75" };

    /// <summary>
    /// tonne per cubic metre kelvin
    /// </summary>
    public static readonly QuantityCode TonnePerCubicMetreKelvin = new QuantityCode { Value = "L76" };

    /// <summary>
    /// tonne per cubic metre bar
    /// </summary>
    public static readonly QuantityCode TonnePerCubicMetreBar = new QuantityCode { Value = "L77" };

    /// <summary>
    /// tonne per minute
    /// </summary>
    public static readonly QuantityCode TonnePerMinute = new QuantityCode { Value = "L78" };

    /// <summary>
    /// tonne per minute kelvin
    /// </summary>
    public static readonly QuantityCode TonnePerMinuteKelvin = new QuantityCode { Value = "L79" };

    /// <summary>
    /// tonne per minute bar
    /// </summary>
    public static readonly QuantityCode TonnePerMinuteBar = new QuantityCode { Value = "L80" };

    /// <summary>
    /// tonne per second
    /// </summary>
    public static readonly QuantityCode TonnePerSecond = new QuantityCode { Value = "L81" };

    /// <summary>
    /// tonne per second kelvin
    /// </summary>
    public static readonly QuantityCode TonnePerSecondKelvin = new QuantityCode { Value = "L82" };

    /// <summary>
    /// tonne per second bar
    /// </summary>
    public static readonly QuantityCode TonnePerSecondBar = new QuantityCode { Value = "L83" };

    /// <summary>
    /// ton (UK shipping)
    /// </summary>
    public static readonly QuantityCode TonUKShipping = new QuantityCode { Value = "L84" };

    /// <summary>
    /// ton long per day
    /// </summary>
    public static readonly QuantityCode TonLongPerDay = new QuantityCode { Value = "L85" };

    /// <summary>
    /// ton (US shipping)
    /// </summary>
    public static readonly QuantityCode TonUSShipping = new QuantityCode { Value = "L86" };

    /// <summary>
    /// ton short per degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode TonShortPerDegreeFahrenheit = new QuantityCode { Value = "L87" };

    /// <summary>
    /// ton short per day
    /// </summary>
    public static readonly QuantityCode TonShortPerDay = new QuantityCode { Value = "L88" };

    /// <summary>
    /// ton short per hour degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode TonShortPerHourDegreeFahrenheit = new QuantityCode { Value = "L89" };

    /// <summary>
    /// ton short per hour psi
    /// </summary>
    public static readonly QuantityCode TonShortPerHourPsi = new QuantityCode { Value = "L90" };

    /// <summary>
    /// ton short per psi
    /// </summary>
    public static readonly QuantityCode TonShortPerPsi = new QuantityCode { Value = "L91" };

    /// <summary>
    /// ton (UK long) per cubic yard
    /// </summary>
    public static readonly QuantityCode TonUKLongPerCubicYard = new QuantityCode { Value = "L92" };

    /// <summary>
    /// ton (US short) per cubic yard
    /// </summary>
    public static readonly QuantityCode TonUSShortPerCubicYard = new QuantityCode { Value = "L93" };

    /// <summary>
    /// ton-force (US short)
    /// </summary>
    public static readonly QuantityCode TonForceUSShort = new QuantityCode { Value = "L94" };

    /// <summary>
    /// common year
    /// </summary>
    public static readonly QuantityCode CommonYear = new QuantityCode { Value = "L95" };

    /// <summary>
    /// sidereal year
    /// </summary>
    public static readonly QuantityCode SiderealYear = new QuantityCode { Value = "L96" };

    /// <summary>
    /// yard per degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode YardPerDegreeFahrenheit = new QuantityCode { Value = "L98" };

    /// <summary>
    /// yard per psi
    /// </summary>
    public static readonly QuantityCode YardPerPsi = new QuantityCode { Value = "L99" };

    /// <summary>
    /// pound per cubic inch
    /// </summary>
    public static readonly QuantityCode PoundPerCubicInch = new QuantityCode { Value = "LA" };

    /// <summary>
    /// lactose excess percentage
    /// </summary>
    public static readonly QuantityCode LactoseExcessPercentage = new QuantityCode { Value = "LAC" };

    /// <summary>
    /// pound
    /// </summary>
    public static readonly QuantityCode Pound = new QuantityCode { Value = "LBR" };

    /// <summary>
    /// troy pound (US)
    /// </summary>
    public static readonly QuantityCode TroyPoundUS = new QuantityCode { Value = "LBT" };

    /// <summary>
    /// litre per day
    /// </summary>
    public static readonly QuantityCode LitrePerDay = new QuantityCode { Value = "LD" };

    /// <summary>
    /// leaf
    /// </summary>
    public static readonly QuantityCode Leaf = new QuantityCode { Value = "LEF" };

    /// <summary>
    /// linear foot
    /// </summary>
    public static readonly QuantityCode LinearFoot = new QuantityCode { Value = "LF" };

    /// <summary>
    /// labour hour
    /// </summary>
    public static readonly QuantityCode LabourHour = new QuantityCode { Value = "LH" };

    /// <summary>
    /// link
    /// </summary>
    public static readonly QuantityCode Link = new QuantityCode { Value = "LK" };

    /// <summary>
    /// linear metre
    /// </summary>
    public static readonly QuantityCode LinearMetre = new QuantityCode { Value = "LM" };

    /// <summary>
    /// length
    /// </summary>
    public static readonly QuantityCode Length = new QuantityCode { Value = "LN" };

    /// <summary>
    /// lot [unit of procurement]
    /// </summary>
    public static readonly QuantityCode LotUnitOfProcurement = new QuantityCode { Value = "LO" };

    /// <summary>
    /// liquid pound
    /// </summary>
    public static readonly QuantityCode LiquidPound = new QuantityCode { Value = "LP" };

    /// <summary>
    /// litre of pure alcohol
    /// </summary>
    public static readonly QuantityCode LitreOfPureAlcohol = new QuantityCode { Value = "LPA" };

    /// <summary>
    /// layer
    /// </summary>
    public static readonly QuantityCode Layer = new QuantityCode { Value = "LR" };

    /// <summary>
    /// lump sum
    /// </summary>
    public static readonly QuantityCode LumpSum = new QuantityCode { Value = "LS" };

    /// <summary>
    /// ton (UK) or long ton (US)
    /// </summary>
    public static readonly QuantityCode TonUKOrLongTonUS = new QuantityCode { Value = "LTN" };

    /// <summary>
    /// litre
    /// </summary>
    public static readonly QuantityCode Litre = new QuantityCode { Value = "LTR" };

    /// <summary>
    /// metric ton, lubricating oil
    /// </summary>
    public static readonly QuantityCode MetricTonLubricatingOil = new QuantityCode { Value = "LUB" };

    /// <summary>
    /// lumen
    /// </summary>
    public static readonly QuantityCode Lumen = new QuantityCode { Value = "LUM" };

    /// <summary>
    /// lux
    /// </summary>
    public static readonly QuantityCode Lux = new QuantityCode { Value = "LUX" };

    /// <summary>
    /// linear yard
    /// </summary>
    public static readonly QuantityCode LinearYard = new QuantityCode { Value = "LY" };

    /// <summary>
    /// milligram per litre
    /// </summary>
    public static readonly QuantityCode MilligramPerLitre = new QuantityCode { Value = "M1" };

    /// <summary>
    /// reciprocal cubic yard
    /// </summary>
    public static readonly QuantityCode ReciprocalCubicYard = new QuantityCode { Value = "M10" };

    /// <summary>
    /// cubic yard per degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode CubicYardPerDegreeFahrenheit = new QuantityCode { Value = "M11" };

    /// <summary>
    /// cubic yard per day
    /// </summary>
    public static readonly QuantityCode CubicYardPerDay = new QuantityCode { Value = "M12" };

    /// <summary>
    /// cubic yard per hour
    /// </summary>
    public static readonly QuantityCode CubicYardPerHour = new QuantityCode { Value = "M13" };

    /// <summary>
    /// cubic yard per psi
    /// </summary>
    public static readonly QuantityCode CubicYardPerPsi = new QuantityCode { Value = "M14" };

    /// <summary>
    /// cubic yard per minute
    /// </summary>
    public static readonly QuantityCode CubicYardPerMinute = new QuantityCode { Value = "M15" };

    /// <summary>
    /// cubic yard per second
    /// </summary>
    public static readonly QuantityCode CubicYardPerSecond = new QuantityCode { Value = "M16" };

    /// <summary>
    /// kilohertz metre
    /// </summary>
    public static readonly QuantityCode KilohertzMetre = new QuantityCode { Value = "M17" };

    /// <summary>
    /// gigahertz metre
    /// </summary>
    public static readonly QuantityCode GigahertzMetre = new QuantityCode { Value = "M18" };

    /// <summary>
    /// Beaufort
    /// </summary>
    public static readonly QuantityCode Beaufort = new QuantityCode { Value = "M19" };

    /// <summary>
    /// reciprocal megakelvin or megakelvin to the power minus one
    /// </summary>
    public static readonly QuantityCode ReciprocalMegakelvinOrMegakelvinToThePowerMinusOne = new QuantityCode { Value = "M20" };

    /// <summary>
    /// reciprocal kilovolt - ampere reciprocal hour
    /// </summary>
    public static readonly QuantityCode ReciprocalKilovoltAmpereReciprocalHour = new QuantityCode { Value = "M21" };

    /// <summary>
    /// millilitre per square centimetre minute
    /// </summary>
    public static readonly QuantityCode MillilitrePerSquareCentimetreMinute = new QuantityCode { Value = "M22" };

    /// <summary>
    /// newton per centimetre
    /// </summary>
    public static readonly QuantityCode NewtonPerCentimetre = new QuantityCode { Value = "M23" };

    /// <summary>
    /// ohm kilometre
    /// </summary>
    public static readonly QuantityCode OhmKilometre = new QuantityCode { Value = "M24" };

    /// <summary>
    /// percent per degree Celsius
    /// </summary>
    public static readonly QuantityCode PercentPerDegreeCelsius = new QuantityCode { Value = "M25" };

    /// <summary>
    /// gigaohm per metre
    /// </summary>
    public static readonly QuantityCode GigaohmPerMetre = new QuantityCode { Value = "M26" };

    /// <summary>
    /// megahertz metre
    /// </summary>
    public static readonly QuantityCode MegahertzMetre = new QuantityCode { Value = "M27" };

    /// <summary>
    /// kilogram per kilogram
    /// </summary>
    public static readonly QuantityCode KilogramPerKilogram = new QuantityCode { Value = "M29" };

    /// <summary>
    /// reciprocal volt - ampere reciprocal second
    /// </summary>
    public static readonly QuantityCode ReciprocalVoltAmpereReciprocalSecond = new QuantityCode { Value = "M30" };

    /// <summary>
    /// kilogram per kilometre
    /// </summary>
    public static readonly QuantityCode KilogramPerKilometre = new QuantityCode { Value = "M31" };

    /// <summary>
    /// pascal second per litre
    /// </summary>
    public static readonly QuantityCode PascalSecondPerLitre = new QuantityCode { Value = "M32" };

    /// <summary>
    /// millimole per litre
    /// </summary>
    public static readonly QuantityCode MillimolePerLitre = new QuantityCode { Value = "M33" };

    /// <summary>
    /// newton metre per square metre
    /// </summary>
    public static readonly QuantityCode NewtonMetrePerSquareMetre = new QuantityCode { Value = "M34" };

    /// <summary>
    /// millivolt - ampere
    /// </summary>
    public static readonly QuantityCode MillivoltAmpere = new QuantityCode { Value = "M35" };

    /// <summary>
    /// 30-day month
    /// </summary>
    public static readonly QuantityCode Code30DayMonth = new QuantityCode { Value = "M36" };

    /// <summary>
    /// actual/360
    /// </summary>
    public static readonly QuantityCode Actual360 = new QuantityCode { Value = "M37" };

    /// <summary>
    /// kilometre per second squared
    /// </summary>
    public static readonly QuantityCode KilometrePerSecondSquared = new QuantityCode { Value = "M38" };

    /// <summary>
    /// centimetre per second squared
    /// </summary>
    public static readonly QuantityCode CentimetrePerSecondSquared = new QuantityCode { Value = "M39" };

    /// <summary>
    /// monetary value
    /// </summary>
    public static readonly QuantityCode MonetaryValue = new QuantityCode { Value = "M4" };

    /// <summary>
    /// yard per second squared
    /// </summary>
    public static readonly QuantityCode YardPerSecondSquared = new QuantityCode { Value = "M40" };

    /// <summary>
    /// millimetre per second squared
    /// </summary>
    public static readonly QuantityCode MillimetrePerSecondSquared = new QuantityCode { Value = "M41" };

    /// <summary>
    /// mile (statute mile) per second squared
    /// </summary>
    public static readonly QuantityCode MileStatuteMilePerSecondSquared = new QuantityCode { Value = "M42" };

    /// <summary>
    /// mil
    /// </summary>
    public static readonly QuantityCode Mil = new QuantityCode { Value = "M43" };

    /// <summary>
    /// revolution
    /// </summary>
    public static readonly QuantityCode Revolution = new QuantityCode { Value = "M44" };

    /// <summary>
    /// degree [unit of angle] per second squared
    /// </summary>
    public static readonly QuantityCode DegreeUnitOfAnglePerSecondSquared = new QuantityCode { Value = "M45" };

    /// <summary>
    /// revolution per minute
    /// </summary>
    public static readonly QuantityCode RevolutionPerMinute = new QuantityCode { Value = "M46" };

    /// <summary>
    /// circular mil
    /// </summary>
    public static readonly QuantityCode CircularMil = new QuantityCode { Value = "M47" };

    /// <summary>
    /// square mile (based on U.S. survey foot)
    /// </summary>
    public static readonly QuantityCode SquareMileBasedOnUSSurveyFoot = new QuantityCode { Value = "M48" };

    /// <summary>
    /// chain (based on U.S. survey foot)
    /// </summary>
    public static readonly QuantityCode ChainBasedOnUSSurveyFoot = new QuantityCode { Value = "M49" };

    /// <summary>
    /// microcurie
    /// </summary>
    public static readonly QuantityCode Microcurie = new QuantityCode { Value = "M5" };

    /// <summary>
    /// furlong
    /// </summary>
    public static readonly QuantityCode Furlong = new QuantityCode { Value = "M50" };

    /// <summary>
    /// foot (U.S. survey)
    /// </summary>
    public static readonly QuantityCode FootUSSurvey = new QuantityCode { Value = "M51" };

    /// <summary>
    /// mile (based on U.S. survey foot)
    /// </summary>
    public static readonly QuantityCode MileBasedOnUSSurveyFoot = new QuantityCode { Value = "M52" };

    /// <summary>
    /// metre per pascal
    /// </summary>
    public static readonly QuantityCode MetrePerPascal = new QuantityCode { Value = "M53" };

    /// <summary>
    /// metre per radiant
    /// </summary>
    public static readonly QuantityCode MetrePerRadiant = new QuantityCode { Value = "M55" };

    /// <summary>
    /// shake
    /// </summary>
    public static readonly QuantityCode Shake = new QuantityCode { Value = "M56" };

    /// <summary>
    /// mile per minute
    /// </summary>
    public static readonly QuantityCode MilePerMinute = new QuantityCode { Value = "M57" };

    /// <summary>
    /// mile per second
    /// </summary>
    public static readonly QuantityCode MilePerSecond = new QuantityCode { Value = "M58" };

    /// <summary>
    /// metre per second pascal
    /// </summary>
    public static readonly QuantityCode MetrePerSecondPascal = new QuantityCode { Value = "M59" };

    /// <summary>
    /// metre per hour
    /// </summary>
    public static readonly QuantityCode MetrePerHour = new QuantityCode { Value = "M60" };

    /// <summary>
    /// inch per year
    /// </summary>
    public static readonly QuantityCode InchPerYear = new QuantityCode { Value = "M61" };

    /// <summary>
    /// kilometre per second
    /// </summary>
    public static readonly QuantityCode KilometrePerSecond = new QuantityCode { Value = "M62" };

    /// <summary>
    /// inch per minute
    /// </summary>
    public static readonly QuantityCode InchPerMinute = new QuantityCode { Value = "M63" };

    /// <summary>
    /// yard per second
    /// </summary>
    public static readonly QuantityCode YardPerSecond = new QuantityCode { Value = "M64" };

    /// <summary>
    /// yard per minute
    /// </summary>
    public static readonly QuantityCode YardPerMinute = new QuantityCode { Value = "M65" };

    /// <summary>
    /// yard per hour
    /// </summary>
    public static readonly QuantityCode YardPerHour = new QuantityCode { Value = "M66" };

    /// <summary>
    /// acre-foot (based on U.S. survey foot)
    /// </summary>
    public static readonly QuantityCode AcreFootBasedOnUSSurveyFoot = new QuantityCode { Value = "M67" };

    /// <summary>
    /// cord (128 ft3)
    /// </summary>
    public static readonly QuantityCode Cord128Ft3 = new QuantityCode { Value = "M68" };

    /// <summary>
    /// cubic mile (UK statute)
    /// </summary>
    public static readonly QuantityCode CubicMileUKStatute = new QuantityCode { Value = "M69" };

    /// <summary>
    /// micro-inch
    /// </summary>
    public static readonly QuantityCode MicroInch = new QuantityCode { Value = "M7" };

    /// <summary>
    /// ton, register
    /// </summary>
    public static readonly QuantityCode TonRegister = new QuantityCode { Value = "M70" };

    /// <summary>
    /// cubic metre per pascal
    /// </summary>
    public static readonly QuantityCode CubicMetrePerPascal = new QuantityCode { Value = "M71" };

    /// <summary>
    /// bel
    /// </summary>
    public static readonly QuantityCode Bel = new QuantityCode { Value = "M72" };

    /// <summary>
    /// kilogram per cubic metre pascal
    /// </summary>
    public static readonly QuantityCode KilogramPerCubicMetrePascal = new QuantityCode { Value = "M73" };

    /// <summary>
    /// kilogram per pascal
    /// </summary>
    public static readonly QuantityCode KilogramPerPascal = new QuantityCode { Value = "M74" };

    /// <summary>
    /// kilopound-force
    /// </summary>
    public static readonly QuantityCode KilopoundForce = new QuantityCode { Value = "M75" };

    /// <summary>
    /// poundal
    /// </summary>
    public static readonly QuantityCode Poundal = new QuantityCode { Value = "M76" };

    /// <summary>
    /// kilogram metre per second squared
    /// </summary>
    public static readonly QuantityCode KilogramMetrePerSecondSquared = new QuantityCode { Value = "M77" };

    /// <summary>
    /// pond
    /// </summary>
    public static readonly QuantityCode Pond = new QuantityCode { Value = "M78" };

    /// <summary>
    /// square foot per hour
    /// </summary>
    public static readonly QuantityCode SquareFootPerHour = new QuantityCode { Value = "M79" };

    /// <summary>
    /// stokes per pascal
    /// </summary>
    public static readonly QuantityCode StokesPerPascal = new QuantityCode { Value = "M80" };

    /// <summary>
    /// square centimetre per second
    /// </summary>
    public static readonly QuantityCode SquareCentimetrePerSecond = new QuantityCode { Value = "M81" };

    /// <summary>
    /// square metre per second pascal
    /// </summary>
    public static readonly QuantityCode SquareMetrePerSecondPascal = new QuantityCode { Value = "M82" };

    /// <summary>
    /// denier
    /// </summary>
    public static readonly QuantityCode DenierM83 = new QuantityCode { Value = "M83" };

    /// <summary>
    /// pound per yard
    /// </summary>
    public static readonly QuantityCode PoundPerYard = new QuantityCode { Value = "M84" };

    /// <summary>
    /// ton, assay
    /// </summary>
    public static readonly QuantityCode TonAssay = new QuantityCode { Value = "M85" };

    /// <summary>
    /// pfund
    /// </summary>
    public static readonly QuantityCode Pfund = new QuantityCode { Value = "M86" };

    /// <summary>
    /// kilogram per second pascal
    /// </summary>
    public static readonly QuantityCode KilogramPerSecondPascal = new QuantityCode { Value = "M87" };

    /// <summary>
    /// tonne per month
    /// </summary>
    public static readonly QuantityCode TonnePerMonth = new QuantityCode { Value = "M88" };

    /// <summary>
    /// tonne per year
    /// </summary>
    public static readonly QuantityCode TonnePerYear = new QuantityCode { Value = "M89" };

    /// <summary>
    /// million Btu per 1000 cubic foot
    /// </summary>
    public static readonly QuantityCode MillionBtuPer1000CubicFoot = new QuantityCode { Value = "M9" };

    /// <summary>
    /// kilopound per hour
    /// </summary>
    public static readonly QuantityCode KilopoundPerHour = new QuantityCode { Value = "M90" };

    /// <summary>
    /// pound per pound
    /// </summary>
    public static readonly QuantityCode PoundPerPound = new QuantityCode { Value = "M91" };

    /// <summary>
    /// pound-force foot
    /// </summary>
    public static readonly QuantityCode PoundForceFoot = new QuantityCode { Value = "M92" };

    /// <summary>
    /// newton metre per radian
    /// </summary>
    public static readonly QuantityCode NewtonMetrePerRadian = new QuantityCode { Value = "M93" };

    /// <summary>
    /// kilogram metre
    /// </summary>
    public static readonly QuantityCode KilogramMetre = new QuantityCode { Value = "M94" };

    /// <summary>
    /// poundal foot
    /// </summary>
    public static readonly QuantityCode PoundalFoot = new QuantityCode { Value = "M95" };

    /// <summary>
    /// poundal inch
    /// </summary>
    public static readonly QuantityCode PoundalInch = new QuantityCode { Value = "M96" };

    /// <summary>
    /// dyne metre
    /// </summary>
    public static readonly QuantityCode DyneMetre = new QuantityCode { Value = "M97" };

    /// <summary>
    /// kilogram centimetre per second
    /// </summary>
    public static readonly QuantityCode KilogramCentimetrePerSecond = new QuantityCode { Value = "M98" };

    /// <summary>
    /// gram centimetre per second
    /// </summary>
    public static readonly QuantityCode GramCentimetrePerSecond = new QuantityCode { Value = "M99" };

    /// <summary>
    /// megavolt ampere reactive hour
    /// </summary>
    public static readonly QuantityCode MegavoltAmpereReactiveHour = new QuantityCode { Value = "MAH" };

    /// <summary>
    /// megalitre
    /// </summary>
    public static readonly QuantityCode Megalitre = new QuantityCode { Value = "MAL" };

    /// <summary>
    /// megametre
    /// </summary>
    public static readonly QuantityCode Megametre = new QuantityCode { Value = "MAM" };

    /// <summary>
    /// megavar
    /// </summary>
    public static readonly QuantityCode Megavar = new QuantityCode { Value = "MAR" };

    /// <summary>
    /// megawatt
    /// </summary>
    public static readonly QuantityCode Megawatt = new QuantityCode { Value = "MAW" };

    /// <summary>
    /// thousand standard brick equivalent
    /// </summary>
    public static readonly QuantityCode ThousandStandardBrickEquivalent = new QuantityCode { Value = "MBE" };

    /// <summary>
    /// thousand board foot
    /// </summary>
    public static readonly QuantityCode ThousandBoardFoot = new QuantityCode { Value = "MBF" };

    /// <summary>
    /// millibar
    /// </summary>
    public static readonly QuantityCode Millibar = new QuantityCode { Value = "MBR" };

    /// <summary>
    /// microgram
    /// </summary>
    public static readonly QuantityCode Microgram = new QuantityCode { Value = "MC" };

    /// <summary>
    /// millicurie
    /// </summary>
    public static readonly QuantityCode Millicurie = new QuantityCode { Value = "MCU" };

    /// <summary>
    /// air dry metric ton
    /// </summary>
    public static readonly QuantityCode AirDryMetricTon = new QuantityCode { Value = "MD" };

    /// <summary>
    /// milligram
    /// </summary>
    public static readonly QuantityCode Milligram = new QuantityCode { Value = "MGM" };

    /// <summary>
    /// megahertz
    /// </summary>
    public static readonly QuantityCode Megahertz = new QuantityCode { Value = "MHZ" };

    /// <summary>
    /// square mile (statute mile)
    /// </summary>
    public static readonly QuantityCode SquareMileStatuteMile = new QuantityCode { Value = "MIK" };

    /// <summary>
    /// thousand
    /// </summary>
    public static readonly QuantityCode Thousand = new QuantityCode { Value = "MIL" };

    /// <summary>
    /// minute [unit of time]
    /// </summary>
    public static readonly QuantityCode MinuteUnitOfTime = new QuantityCode { Value = "MIN" };

    /// <summary>
    /// million
    /// </summary>
    public static readonly QuantityCode Million = new QuantityCode { Value = "MIO" };

    /// <summary>
    /// million international unit
    /// </summary>
    public static readonly QuantityCode MillionInternationalUnit = new QuantityCode { Value = "MIU" };

    /// <summary>
    /// Square Metre Day
    /// </summary>
    public static readonly QuantityCode SquareMetreDay = new QuantityCode { Value = "MKD" };

    /// <summary>
    /// Square Metre Month
    /// </summary>
    public static readonly QuantityCode SquareMetreMonth = new QuantityCode { Value = "MKM" };

    /// <summary>
    /// Square Metre Week
    /// </summary>
    public static readonly QuantityCode SquareMetreWeek = new QuantityCode { Value = "MKW" };

    /// <summary>
    /// milliard
    /// </summary>
    public static readonly QuantityCode Milliard = new QuantityCode { Value = "MLD" };

    /// <summary>
    /// millilitre
    /// </summary>
    public static readonly QuantityCode Millilitre = new QuantityCode { Value = "MLT" };

    /// <summary>
    /// square millimetre
    /// </summary>
    public static readonly QuantityCode SquareMillimetre = new QuantityCode { Value = "MMK" };

    /// <summary>
    /// cubic millimetre
    /// </summary>
    public static readonly QuantityCode CubicMillimetre = new QuantityCode { Value = "MMQ" };

    /// <summary>
    /// millimetre
    /// </summary>
    public static readonly QuantityCode Millimetre = new QuantityCode { Value = "MMT" };

    /// <summary>
    /// kilogram, dry weight
    /// </summary>
    public static readonly QuantityCode KilogramDryWeight = new QuantityCode { Value = "MND" };

    /// <summary>
    /// Mega Joule per Normalised cubic Metre
    /// </summary>
    public static readonly QuantityCode MegaJoulePerNormalisedCubicMetre = new QuantityCode { Value = "MNJ" };

    /// <summary>
    /// month
    /// </summary>
    public static readonly QuantityCode Month = new QuantityCode { Value = "MON" };

    /// <summary>
    /// megapascal
    /// </summary>
    public static readonly QuantityCode Megapascal = new QuantityCode { Value = "MPA" };

    /// <summary>
    /// Cubic Metre Day
    /// </summary>
    public static readonly QuantityCode CubicMetreDay = new QuantityCode { Value = "MQD" };

    /// <summary>
    /// cubic metre per hour
    /// </summary>
    public static readonly QuantityCode CubicMetrePerHour = new QuantityCode { Value = "MQH" };

    /// <summary>
    /// Cubic Metre Month
    /// </summary>
    public static readonly QuantityCode CubicMetreMonth = new QuantityCode { Value = "MQM" };

    /// <summary>
    /// cubic metre per second
    /// </summary>
    public static readonly QuantityCode CubicMetrePerSecond = new QuantityCode { Value = "MQS" };

    /// <summary>
    /// Cubic Metre Week
    /// </summary>
    public static readonly QuantityCode CubicMetreWeek = new QuantityCode { Value = "MQW" };

    /// <summary>
    /// Metre Day
    /// </summary>
    public static readonly QuantityCode MetreDay = new QuantityCode { Value = "MRD" };

    /// <summary>
    /// Metre Month
    /// </summary>
    public static readonly QuantityCode MetreMonth = new QuantityCode { Value = "MRM" };

    /// <summary>
    /// Metre Week
    /// </summary>
    public static readonly QuantityCode MetreWeek = new QuantityCode { Value = "MRW" };

    /// <summary>
    /// metre per second squared
    /// </summary>
    public static readonly QuantityCode MetrePerSecondSquared = new QuantityCode { Value = "MSK" };

    /// <summary>
    /// square metre
    /// </summary>
    public static readonly QuantityCode SquareMetre = new QuantityCode { Value = "MTK" };

    /// <summary>
    /// cubic metre
    /// </summary>
    public static readonly QuantityCode CubicMetre = new QuantityCode { Value = "MTQ" };

    /// <summary>
    /// metre
    /// </summary>
    public static readonly QuantityCode Metre = new QuantityCode { Value = "MTR" };

    /// <summary>
    /// metre per second
    /// </summary>
    public static readonly QuantityCode MetrePerSecond = new QuantityCode { Value = "MTS" };

    /// <summary>
    /// millihertz
    /// </summary>
    public static readonly QuantityCode Millihertz = new QuantityCode { Value = "MTZ" };

    /// <summary>
    /// megavolt - ampere
    /// </summary>
    public static readonly QuantityCode MegavoltAmpere = new QuantityCode { Value = "MVA" };

    /// <summary>
    /// megawatt hour (1000 kW.h)
    /// </summary>
    public static readonly QuantityCode MegawattHour1000KWH = new QuantityCode { Value = "MWH" };

    /// <summary>
    /// pen calorie
    /// </summary>
    public static readonly QuantityCode PenCalorie = new QuantityCode { Value = "N1" };

    /// <summary>
    /// pound foot per second
    /// </summary>
    public static readonly QuantityCode PoundFootPerSecond = new QuantityCode { Value = "N10" };

    /// <summary>
    /// pound inch per second
    /// </summary>
    public static readonly QuantityCode PoundInchPerSecond = new QuantityCode { Value = "N11" };

    /// <summary>
    /// Pferdestaerke
    /// </summary>
    public static readonly QuantityCode Pferdestaerke = new QuantityCode { Value = "N12" };

    /// <summary>
    /// centimetre of mercury (0 ºC)
    /// </summary>
    public static readonly QuantityCode CentimetreOfMercury0C = new QuantityCode { Value = "N13" };

    /// <summary>
    /// centimetre of water (4 ºC)
    /// </summary>
    public static readonly QuantityCode CentimetreOfWater4C = new QuantityCode { Value = "N14" };

    /// <summary>
    /// foot of water (39.2 ºF)
    /// </summary>
    public static readonly QuantityCode FootOfWater392F = new QuantityCode { Value = "N15" };

    /// <summary>
    /// inch of mercury (32 ºF)
    /// </summary>
    public static readonly QuantityCode InchOfMercury32F = new QuantityCode { Value = "N16" };

    /// <summary>
    /// inch of mercury (60 ºF)
    /// </summary>
    public static readonly QuantityCode InchOfMercury60F = new QuantityCode { Value = "N17" };

    /// <summary>
    /// inch of water (39.2 ºF)
    /// </summary>
    public static readonly QuantityCode InchOfWater392F = new QuantityCode { Value = "N18" };

    /// <summary>
    /// inch of water (60 ºF)
    /// </summary>
    public static readonly QuantityCode InchOfWater60F = new QuantityCode { Value = "N19" };

    /// <summary>
    /// kip per square inch
    /// </summary>
    public static readonly QuantityCode KipPerSquareInch = new QuantityCode { Value = "N20" };

    /// <summary>
    /// poundal per square foot
    /// </summary>
    public static readonly QuantityCode PoundalPerSquareFoot = new QuantityCode { Value = "N21" };

    /// <summary>
    /// ounce (avoirdupois) per square inch
    /// </summary>
    public static readonly QuantityCode OunceAvoirdupoisPerSquareInch = new QuantityCode { Value = "N22" };

    /// <summary>
    /// conventional metre of water
    /// </summary>
    public static readonly QuantityCode ConventionalMetreOfWater = new QuantityCode { Value = "N23" };

    /// <summary>
    /// gram per square millimetre
    /// </summary>
    public static readonly QuantityCode GramPerSquareMillimetre = new QuantityCode { Value = "N24" };

    /// <summary>
    /// pound per square yard
    /// </summary>
    public static readonly QuantityCode PoundPerSquareYard = new QuantityCode { Value = "N25" };

    /// <summary>
    /// poundal per square inch
    /// </summary>
    public static readonly QuantityCode PoundalPerSquareInch = new QuantityCode { Value = "N26" };

    /// <summary>
    /// foot to the fourth power
    /// </summary>
    public static readonly QuantityCode FootToTheFourthPower = new QuantityCode { Value = "N27" };

    /// <summary>
    /// cubic decimetre per kilogram
    /// </summary>
    public static readonly QuantityCode CubicDecimetrePerKilogram = new QuantityCode { Value = "N28" };

    /// <summary>
    /// cubic foot per pound
    /// </summary>
    public static readonly QuantityCode CubicFootPerPound = new QuantityCode { Value = "N29" };

    /// <summary>
    /// print point
    /// </summary>
    public static readonly QuantityCode PrintPoint = new QuantityCode { Value = "N3" };

    /// <summary>
    /// cubic inch per pound
    /// </summary>
    public static readonly QuantityCode CubicInchPerPound = new QuantityCode { Value = "N30" };

    /// <summary>
    /// kilonewton per metre
    /// </summary>
    public static readonly QuantityCode KilonewtonPerMetre = new QuantityCode { Value = "N31" };

    /// <summary>
    /// poundal per inch
    /// </summary>
    public static readonly QuantityCode PoundalPerInch = new QuantityCode { Value = "N32" };

    /// <summary>
    /// pound-force per yard
    /// </summary>
    public static readonly QuantityCode PoundForcePerYard = new QuantityCode { Value = "N33" };

    /// <summary>
    /// poundal second per square foot
    /// </summary>
    public static readonly QuantityCode PoundalSecondPerSquareFoot = new QuantityCode { Value = "N34" };

    /// <summary>
    /// poise per pascal
    /// </summary>
    public static readonly QuantityCode PoisePerPascal = new QuantityCode { Value = "N35" };

    /// <summary>
    /// newton second per square metre
    /// </summary>
    public static readonly QuantityCode NewtonSecondPerSquareMetre = new QuantityCode { Value = "N36" };

    /// <summary>
    /// kilogram per metre second
    /// </summary>
    public static readonly QuantityCode KilogramPerMetreSecond = new QuantityCode { Value = "N37" };

    /// <summary>
    /// kilogram per metre minute
    /// </summary>
    public static readonly QuantityCode KilogramPerMetreMinute = new QuantityCode { Value = "N38" };

    /// <summary>
    /// kilogram per metre day
    /// </summary>
    public static readonly QuantityCode KilogramPerMetreDay = new QuantityCode { Value = "N39" };

    /// <summary>
    /// kilogram per metre hour
    /// </summary>
    public static readonly QuantityCode KilogramPerMetreHour = new QuantityCode { Value = "N40" };

    /// <summary>
    /// gram per centimetre second
    /// </summary>
    public static readonly QuantityCode GramPerCentimetreSecond = new QuantityCode { Value = "N41" };

    /// <summary>
    /// poundal second per square inch
    /// </summary>
    public static readonly QuantityCode PoundalSecondPerSquareInch = new QuantityCode { Value = "N42" };

    /// <summary>
    /// pound per foot minute
    /// </summary>
    public static readonly QuantityCode PoundPerFootMinute = new QuantityCode { Value = "N43" };

    /// <summary>
    /// pound per foot day
    /// </summary>
    public static readonly QuantityCode PoundPerFootDay = new QuantityCode { Value = "N44" };

    /// <summary>
    /// cubic metre per second pascal
    /// </summary>
    public static readonly QuantityCode CubicMetrePerSecondPascal = new QuantityCode { Value = "N45" };

    /// <summary>
    /// foot poundal
    /// </summary>
    public static readonly QuantityCode FootPoundal = new QuantityCode { Value = "N46" };

    /// <summary>
    /// inch poundal
    /// </summary>
    public static readonly QuantityCode InchPoundal = new QuantityCode { Value = "N47" };

    /// <summary>
    /// watt per square centimetre
    /// </summary>
    public static readonly QuantityCode WattPerSquareCentimetre = new QuantityCode { Value = "N48" };

    /// <summary>
    /// watt per square inch
    /// </summary>
    public static readonly QuantityCode WattPerSquareInch = new QuantityCode { Value = "N49" };

    /// <summary>
    /// British thermal unit (international table) per square foot hour
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitInternationalTablePerSquareFootHour = new QuantityCode { Value = "N50" };

    /// <summary>
    /// British thermal unit (thermochemical) per square foot hour
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitThermochemicalPerSquareFootHour = new QuantityCode { Value = "N51" };

    /// <summary>
    /// British thermal unit (thermochemical) per square foot minute
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitThermochemicalPerSquareFootMinute = new QuantityCode { Value = "N52" };

    /// <summary>
    /// British thermal unit (international table) per square foot second
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitInternationalTablePerSquareFootSecond = new QuantityCode { Value = "N53" };

    /// <summary>
    /// British thermal unit (thermochemical) per square foot second
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitThermochemicalPerSquareFootSecond = new QuantityCode { Value = "N54" };

    /// <summary>
    /// British thermal unit (international table) per square inch second
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitInternationalTablePerSquareInchSecond = new QuantityCode { Value = "N55" };

    /// <summary>
    /// calorie (thermochemical) per square centimetre minute
    /// </summary>
    public static readonly QuantityCode CalorieThermochemicalPerSquareCentimetreMinute = new QuantityCode { Value = "N56" };

    /// <summary>
    /// calorie (thermochemical) per square centimetre second
    /// </summary>
    public static readonly QuantityCode CalorieThermochemicalPerSquareCentimetreSecond = new QuantityCode { Value = "N57" };

    /// <summary>
    /// British thermal unit (international table) per cubic foot
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitInternationalTablePerCubicFoot = new QuantityCode { Value = "N58" };

    /// <summary>
    /// British thermal unit (thermochemical) per cubic foot
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitThermochemicalPerCubicFoot = new QuantityCode { Value = "N59" };

    /// <summary>
    /// British thermal unit (international table) per degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitInternationalTablePerDegreeFahrenheit = new QuantityCode { Value = "N60" };

    /// <summary>
    /// British thermal unit (thermochemical) per degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitThermochemicalPerDegreeFahrenheit = new QuantityCode { Value = "N61" };

    /// <summary>
    /// British thermal unit (international table) per degree Rankine
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitInternationalTablePerDegreeRankine = new QuantityCode { Value = "N62" };

    /// <summary>
    /// British thermal unit (thermochemical) per degree Rankine
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitThermochemicalPerDegreeRankine = new QuantityCode { Value = "N63" };

    /// <summary>
    /// British thermal unit (thermochemical) per pound degree Rankine
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitThermochemicalPerPoundDegreeRankine = new QuantityCode { Value = "N64" };

    /// <summary>
    /// kilocalorie (international table) per gram kelvin
    /// </summary>
    public static readonly QuantityCode KilocalorieInternationalTablePerGramKelvin = new QuantityCode { Value = "N65" };

    /// <summary>
    /// British thermal unit (39 ºF)
    /// </summary>
    public static readonly QuantityCode BritishThermalUnit39F = new QuantityCode { Value = "N66" };

    /// <summary>
    /// British thermal unit (59 ºF)
    /// </summary>
    public static readonly QuantityCode BritishThermalUnit59F = new QuantityCode { Value = "N67" };

    /// <summary>
    /// British thermal unit (60 ºF)
    /// </summary>
    public static readonly QuantityCode BritishThermalUnit60F = new QuantityCode { Value = "N68" };

    /// <summary>
    /// calorie (20 ºC)
    /// </summary>
    public static readonly QuantityCode Calorie20C = new QuantityCode { Value = "N69" };

    /// <summary>
    /// quad (1015 BtuIT)
    /// </summary>
    public static readonly QuantityCode Quad1015BtuIT = new QuantityCode { Value = "N70" };

    /// <summary>
    /// therm (EC)
    /// </summary>
    public static readonly QuantityCode ThermEC = new QuantityCode { Value = "N71" };

    /// <summary>
    /// therm (U.S.)
    /// </summary>
    public static readonly QuantityCode ThermUS = new QuantityCode { Value = "N72" };

    /// <summary>
    /// British thermal unit (thermochemical) per pound
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitThermochemicalPerPound = new QuantityCode { Value = "N73" };

    /// <summary>
    /// British thermal unit (international table) per hour square foot degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitInternationalTablePerHourSquareFootDegreeFahrenheit = new QuantityCode { Value = "N74" };

    /// <summary>
    /// British thermal unit (thermochemical) per hour square foot degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitThermochemicalPerHourSquareFootDegreeFahrenheit = new QuantityCode { Value = "N75" };

    /// <summary>
    /// British thermal unit (international table) per second square foot degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitInternationalTablePerSecondSquareFootDegreeFahrenheit = new QuantityCode { Value = "N76" };

    /// <summary>
    /// British thermal unit (thermochemical) per second square foot degree Fahrenheit
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitThermochemicalPerSecondSquareFootDegreeFahrenheit = new QuantityCode { Value = "N77" };

    /// <summary>
    /// kilowatt per square metre kelvin
    /// </summary>
    public static readonly QuantityCode KilowattPerSquareMetreKelvin = new QuantityCode { Value = "N78" };

    /// <summary>
    /// kelvin per pascal
    /// </summary>
    public static readonly QuantityCode KelvinPerPascal = new QuantityCode { Value = "N79" };

    /// <summary>
    /// watt per metre degree Celsius
    /// </summary>
    public static readonly QuantityCode WattPerMetreDegreeCelsius = new QuantityCode { Value = "N80" };

    /// <summary>
    /// kilowatt per metre kelvin
    /// </summary>
    public static readonly QuantityCode KilowattPerMetreKelvin = new QuantityCode { Value = "N81" };

    /// <summary>
    /// kilowatt per metre degree Celsius
    /// </summary>
    public static readonly QuantityCode KilowattPerMetreDegreeCelsius = new QuantityCode { Value = "N82" };

    /// <summary>
    /// metre per degree Celcius metre
    /// </summary>
    public static readonly QuantityCode MetrePerDegreeCelciusMetre = new QuantityCode { Value = "N83" };

    /// <summary>
    /// degree Fahrenheit hour per British thermal unit (international table)
    /// </summary>
    public static readonly QuantityCode DegreeFahrenheitHourPerBritishThermalUnitInternationalTable = new QuantityCode { Value = "N84" };

    /// <summary>
    /// degree Fahrenheit hour per British thermal unit (thermochemical)
    /// </summary>
    public static readonly QuantityCode DegreeFahrenheitHourPerBritishThermalUnitThermochemical = new QuantityCode { Value = "N85" };

    /// <summary>
    /// degree Fahrenheit second per British thermal unit (international table)
    /// </summary>
    public static readonly QuantityCode DegreeFahrenheitSecondPerBritishThermalUnitInternationalTable = new QuantityCode { Value = "N86" };

    /// <summary>
    /// degree Fahrenheit second per British thermal unit (thermochemical)
    /// </summary>
    public static readonly QuantityCode DegreeFahrenheitSecondPerBritishThermalUnitThermochemical = new QuantityCode { Value = "N87" };

    /// <summary>
    /// degree Fahrenheit hour square foot per British thermal unit (international table) inch
    /// </summary>
    public static readonly QuantityCode DegreeFahrenheitHourSquareFootPerBritishThermalUnitInternationalTableInch = new QuantityCode { Value = "N88" };

    /// <summary>
    /// degree Fahrenheit hour square foot per British thermal unit (thermochemical) inch
    /// </summary>
    public static readonly QuantityCode DegreeFahrenheitHourSquareFootPerBritishThermalUnitThermochemicalInch = new QuantityCode { Value = "N89" };

    /// <summary>
    /// kilofarad
    /// </summary>
    public static readonly QuantityCode Kilofarad = new QuantityCode { Value = "N90" };

    /// <summary>
    /// reciprocal joule
    /// </summary>
    public static readonly QuantityCode ReciprocalJoule = new QuantityCode { Value = "N91" };

    /// <summary>
    /// picosiemens
    /// </summary>
    public static readonly QuantityCode Picosiemens = new QuantityCode { Value = "N92" };

    /// <summary>
    /// ampere per pascal
    /// </summary>
    public static readonly QuantityCode AmperePerPascal = new QuantityCode { Value = "N93" };

    /// <summary>
    /// franklin
    /// </summary>
    public static readonly QuantityCode Franklin = new QuantityCode { Value = "N94" };

    /// <summary>
    /// ampere minute
    /// </summary>
    public static readonly QuantityCode AmpereMinute = new QuantityCode { Value = "N95" };

    /// <summary>
    /// biot
    /// </summary>
    public static readonly QuantityCode Biot = new QuantityCode { Value = "N96" };

    /// <summary>
    /// gilbert
    /// </summary>
    public static readonly QuantityCode Gilbert = new QuantityCode { Value = "N97" };

    /// <summary>
    /// volt per pascal
    /// </summary>
    public static readonly QuantityCode VoltPerPascal = new QuantityCode { Value = "N98" };

    /// <summary>
    /// picovolt
    /// </summary>
    public static readonly QuantityCode Picovolt = new QuantityCode { Value = "N99" };

    /// <summary>
    /// milligram per kilogram
    /// </summary>
    public static readonly QuantityCode MilligramPerKilogram = new QuantityCode { Value = "NA" };

    /// <summary>
    /// number of articles
    /// </summary>
    public static readonly QuantityCode NumberOfArticles = new QuantityCode { Value = "NAR" };

    /// <summary>
    /// number of cells
    /// </summary>
    public static readonly QuantityCode NumberOfCells = new QuantityCode { Value = "NCL" };

    /// <summary>
    /// newton
    /// </summary>
    public static readonly QuantityCode Newton = new QuantityCode { Value = "NEW" };

    /// <summary>
    /// message
    /// </summary>
    public static readonly QuantityCode Message = new QuantityCode { Value = "NF" };

    /// <summary>
    /// nil
    /// </summary>
    public static readonly QuantityCode Nil = new QuantityCode { Value = "NIL" };

    /// <summary>
    /// number of international units
    /// </summary>
    public static readonly QuantityCode NumberOfInternationalUnits = new QuantityCode { Value = "NIU" };

    /// <summary>
    /// load
    /// </summary>
    public static readonly QuantityCode Load = new QuantityCode { Value = "NL" };

    /// <summary>
    /// Normalised cubic metre
    /// </summary>
    public static readonly QuantityCode NormalisedCubicMetre = new QuantityCode { Value = "NM3" };

    /// <summary>
    /// nautical mile
    /// </summary>
    public static readonly QuantityCode NauticalMile = new QuantityCode { Value = "NMI" };

    /// <summary>
    /// number of packs
    /// </summary>
    public static readonly QuantityCode NumberOfPacks = new QuantityCode { Value = "NMP" };

    /// <summary>
    /// number of parts
    /// </summary>
    public static readonly QuantityCode NumberOfParts = new QuantityCode { Value = "NPT" };

    /// <summary>
    /// net ton
    /// </summary>
    public static readonly QuantityCode NetTon = new QuantityCode { Value = "NT" };

    /// <summary>
    /// Nephelometric turbidity unit
    /// </summary>
    public static readonly QuantityCode NephelometricTurbidityUnit = new QuantityCode { Value = "NTU" };

    /// <summary>
    /// newton metre
    /// </summary>
    public static readonly QuantityCode NewtonMetre = new QuantityCode { Value = "NU" };

    /// <summary>
    /// part per thousand
    /// </summary>
    public static readonly QuantityCode PartPerThousand = new QuantityCode { Value = "NX" };

    /// <summary>
    /// panel
    /// </summary>
    public static readonly QuantityCode Panel = new QuantityCode { Value = "OA" };

    /// <summary>
    /// ozone depletion equivalent
    /// </summary>
    public static readonly QuantityCode OzoneDepletionEquivalent = new QuantityCode { Value = "ODE" };

    /// <summary>
    /// ODS Grams
    /// </summary>
    public static readonly QuantityCode ODSGrams = new QuantityCode { Value = "ODG" };

    /// <summary>
    /// ODS Kilograms
    /// </summary>
    public static readonly QuantityCode ODSKilograms = new QuantityCode { Value = "ODK" };

    /// <summary>
    /// ODS Milligrams
    /// </summary>
    public static readonly QuantityCode ODSMilligrams = new QuantityCode { Value = "ODM" };

    /// <summary>
    /// ohm
    /// </summary>
    public static readonly QuantityCode Ohm = new QuantityCode { Value = "OHM" };

    /// <summary>
    /// ounce per square yard
    /// </summary>
    public static readonly QuantityCode OuncePerSquareYard = new QuantityCode { Value = "ON" };

    /// <summary>
    /// ounce (avoirdupois)
    /// </summary>
    public static readonly QuantityCode OunceAvoirdupois = new QuantityCode { Value = "ONZ" };

    /// <summary>
    /// oscillations per minute
    /// </summary>
    public static readonly QuantityCode OscillationsPerMinute = new QuantityCode { Value = "OPM" };

    /// <summary>
    /// overtime hour
    /// </summary>
    public static readonly QuantityCode OvertimeHour = new QuantityCode { Value = "OT" };

    /// <summary>
    /// fluid ounce (US)
    /// </summary>
    public static readonly QuantityCode FluidOunceUS = new QuantityCode { Value = "OZA" };

    /// <summary>
    /// fluid ounce (UK)
    /// </summary>
    public static readonly QuantityCode FluidOunceUK = new QuantityCode { Value = "OZI" };

    /// <summary>
    /// percent
    /// </summary>
    public static readonly QuantityCode Percent = new QuantityCode { Value = "P1" };

    /// <summary>
    /// coulomb per metre
    /// </summary>
    public static readonly QuantityCode CoulombPerMetre = new QuantityCode { Value = "P10" };

    /// <summary>
    /// kiloweber
    /// </summary>
    public static readonly QuantityCode Kiloweber = new QuantityCode { Value = "P11" };

    /// <summary>
    /// gamma
    /// </summary>
    public static readonly QuantityCode Gamma = new QuantityCode { Value = "P12" };

    /// <summary>
    /// kilotesla
    /// </summary>
    public static readonly QuantityCode Kilotesla = new QuantityCode { Value = "P13" };

    /// <summary>
    /// joule per second
    /// </summary>
    public static readonly QuantityCode JoulePerSecond = new QuantityCode { Value = "P14" };

    /// <summary>
    /// joule per minute
    /// </summary>
    public static readonly QuantityCode JoulePerMinute = new QuantityCode { Value = "P15" };

    /// <summary>
    /// joule per hour
    /// </summary>
    public static readonly QuantityCode JoulePerHour = new QuantityCode { Value = "P16" };

    /// <summary>
    /// joule per day
    /// </summary>
    public static readonly QuantityCode JoulePerDay = new QuantityCode { Value = "P17" };

    /// <summary>
    /// kilojoule per second
    /// </summary>
    public static readonly QuantityCode KilojoulePerSecond = new QuantityCode { Value = "P18" };

    /// <summary>
    /// kilojoule per minute
    /// </summary>
    public static readonly QuantityCode KilojoulePerMinute = new QuantityCode { Value = "P19" };

    /// <summary>
    /// pound per foot
    /// </summary>
    public static readonly QuantityCode PoundPerFoot = new QuantityCode { Value = "P2" };

    /// <summary>
    /// kilojoule per hour
    /// </summary>
    public static readonly QuantityCode KilojoulePerHour = new QuantityCode { Value = "P20" };

    /// <summary>
    /// kilojoule per day
    /// </summary>
    public static readonly QuantityCode KilojoulePerDay = new QuantityCode { Value = "P21" };

    /// <summary>
    /// nanoohm
    /// </summary>
    public static readonly QuantityCode Nanoohm = new QuantityCode { Value = "P22" };

    /// <summary>
    /// ohm circular-mil per foot
    /// </summary>
    public static readonly QuantityCode OhmCircularMilPerFoot = new QuantityCode { Value = "P23" };

    /// <summary>
    /// kilohenry
    /// </summary>
    public static readonly QuantityCode Kilohenry = new QuantityCode { Value = "P24" };

    /// <summary>
    /// lumen per square foot
    /// </summary>
    public static readonly QuantityCode LumenPerSquareFoot = new QuantityCode { Value = "P25" };

    /// <summary>
    /// phot
    /// </summary>
    public static readonly QuantityCode Phot = new QuantityCode { Value = "P26" };

    /// <summary>
    /// footcandle
    /// </summary>
    public static readonly QuantityCode Footcandle = new QuantityCode { Value = "P27" };

    /// <summary>
    /// candela per square inch
    /// </summary>
    public static readonly QuantityCode CandelaPerSquareInch = new QuantityCode { Value = "P28" };

    /// <summary>
    /// footlambert
    /// </summary>
    public static readonly QuantityCode Footlambert = new QuantityCode { Value = "P29" };

    /// <summary>
    /// lambert
    /// </summary>
    public static readonly QuantityCode Lambert = new QuantityCode { Value = "P30" };

    /// <summary>
    /// stilb
    /// </summary>
    public static readonly QuantityCode Stilb = new QuantityCode { Value = "P31" };

    /// <summary>
    /// candela per square foot
    /// </summary>
    public static readonly QuantityCode CandelaPerSquareFoot = new QuantityCode { Value = "P32" };

    /// <summary>
    /// kilocandela
    /// </summary>
    public static readonly QuantityCode Kilocandela = new QuantityCode { Value = "P33" };

    /// <summary>
    /// millicandela
    /// </summary>
    public static readonly QuantityCode Millicandela = new QuantityCode { Value = "P34" };

    /// <summary>
    /// Hefner-Kerze
    /// </summary>
    public static readonly QuantityCode HefnerKerze = new QuantityCode { Value = "P35" };

    /// <summary>
    /// international candle
    /// </summary>
    public static readonly QuantityCode InternationalCandle = new QuantityCode { Value = "P36" };

    /// <summary>
    /// British thermal unit (international table) per square foot
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitInternationalTablePerSquareFoot = new QuantityCode { Value = "P37" };

    /// <summary>
    /// British thermal unit (thermochemical) per square foot
    /// </summary>
    public static readonly QuantityCode BritishThermalUnitThermochemicalPerSquareFoot = new QuantityCode { Value = "P38" };

    /// <summary>
    /// calorie (thermochemical) per square centimetre
    /// </summary>
    public static readonly QuantityCode CalorieThermochemicalPerSquareCentimetre = new QuantityCode { Value = "P39" };

    /// <summary>
    /// langley
    /// </summary>
    public static readonly QuantityCode Langley = new QuantityCode { Value = "P40" };

    /// <summary>
    /// decade (logarithmic)
    /// </summary>
    public static readonly QuantityCode DecadeLogarithmic = new QuantityCode { Value = "P41" };

    /// <summary>
    /// pascal squared second
    /// </summary>
    public static readonly QuantityCode PascalSquaredSecond = new QuantityCode { Value = "P42" };

    /// <summary>
    /// bel per metre
    /// </summary>
    public static readonly QuantityCode BelPerMetre = new QuantityCode { Value = "P43" };

    /// <summary>
    /// pound mole
    /// </summary>
    public static readonly QuantityCode PoundMole = new QuantityCode { Value = "P44" };

    /// <summary>
    /// pound mole per second
    /// </summary>
    public static readonly QuantityCode PoundMolePerSecond = new QuantityCode { Value = "P45" };

    /// <summary>
    /// pound mole per minute
    /// </summary>
    public static readonly QuantityCode PoundMolePerMinute = new QuantityCode { Value = "P46" };

    /// <summary>
    /// kilomole per kilogram
    /// </summary>
    public static readonly QuantityCode KilomolePerKilogram = new QuantityCode { Value = "P47" };

    /// <summary>
    /// pound mole per pound
    /// </summary>
    public static readonly QuantityCode PoundMolePerPound = new QuantityCode { Value = "P48" };

    /// <summary>
    /// newton square metre per ampere
    /// </summary>
    public static readonly QuantityCode NewtonSquareMetrePerAmpere = new QuantityCode { Value = "P49" };

    /// <summary>
    /// five pack
    /// </summary>
    public static readonly QuantityCode FivePack = new QuantityCode { Value = "P5" };

    /// <summary>
    /// weber metre
    /// </summary>
    public static readonly QuantityCode WeberMetre = new QuantityCode { Value = "P50" };

    /// <summary>
    /// mol per kilogram pascal
    /// </summary>
    public static readonly QuantityCode MolPerKilogramPascal = new QuantityCode { Value = "P51" };

    /// <summary>
    /// mol per cubic metre pascal
    /// </summary>
    public static readonly QuantityCode MolPerCubicMetrePascal = new QuantityCode { Value = "P52" };

    /// <summary>
    /// unit pole
    /// </summary>
    public static readonly QuantityCode UnitPole = new QuantityCode { Value = "P53" };

    /// <summary>
    /// milligray per second
    /// </summary>
    public static readonly QuantityCode MilligrayPerSecond = new QuantityCode { Value = "P54" };

    /// <summary>
    /// microgray per second
    /// </summary>
    public static readonly QuantityCode MicrograyPerSecond = new QuantityCode { Value = "P55" };

    /// <summary>
    /// nanogray per second
    /// </summary>
    public static readonly QuantityCode NanograyPerSecond = new QuantityCode { Value = "P56" };

    /// <summary>
    /// gray per minute
    /// </summary>
    public static readonly QuantityCode GrayPerMinute = new QuantityCode { Value = "P57" };

    /// <summary>
    /// milligray per minute
    /// </summary>
    public static readonly QuantityCode MilligrayPerMinute = new QuantityCode { Value = "P58" };

    /// <summary>
    /// microgray per minute
    /// </summary>
    public static readonly QuantityCode MicrograyPerMinute = new QuantityCode { Value = "P59" };

    /// <summary>
    /// nanogray per minute
    /// </summary>
    public static readonly QuantityCode NanograyPerMinute = new QuantityCode { Value = "P60" };

    /// <summary>
    /// gray per hour
    /// </summary>
    public static readonly QuantityCode GrayPerHour = new QuantityCode { Value = "P61" };

    /// <summary>
    /// milligray per hour
    /// </summary>
    public static readonly QuantityCode MilligrayPerHour = new QuantityCode { Value = "P62" };

    /// <summary>
    /// microgray per hour
    /// </summary>
    public static readonly QuantityCode MicrograyPerHour = new QuantityCode { Value = "P63" };

    /// <summary>
    /// nanogray per hour
    /// </summary>
    public static readonly QuantityCode NanograyPerHour = new QuantityCode { Value = "P64" };

    /// <summary>
    /// sievert per second
    /// </summary>
    public static readonly QuantityCode SievertPerSecond = new QuantityCode { Value = "P65" };

    /// <summary>
    /// millisievert per second
    /// </summary>
    public static readonly QuantityCode MillisievertPerSecond = new QuantityCode { Value = "P66" };

    /// <summary>
    /// microsievert per second
    /// </summary>
    public static readonly QuantityCode MicrosievertPerSecond = new QuantityCode { Value = "P67" };

    /// <summary>
    /// nanosievert per second
    /// </summary>
    public static readonly QuantityCode NanosievertPerSecond = new QuantityCode { Value = "P68" };

    /// <summary>
    /// rem per second
    /// </summary>
    public static readonly QuantityCode RemPerSecond = new QuantityCode { Value = "P69" };

    /// <summary>
    /// sievert per hour
    /// </summary>
    public static readonly QuantityCode SievertPerHour = new QuantityCode { Value = "P70" };

    /// <summary>
    /// millisievert per hour
    /// </summary>
    public static readonly QuantityCode MillisievertPerHour = new QuantityCode { Value = "P71" };

    /// <summary>
    /// microsievert per hour
    /// </summary>
    public static readonly QuantityCode MicrosievertPerHour = new QuantityCode { Value = "P72" };

    /// <summary>
    /// nanosievert per hour
    /// </summary>
    public static readonly QuantityCode NanosievertPerHour = new QuantityCode { Value = "P73" };

    /// <summary>
    /// sievert per minute
    /// </summary>
    public static readonly QuantityCode SievertPerMinute = new QuantityCode { Value = "P74" };

    /// <summary>
    /// millisievert per minute
    /// </summary>
    public static readonly QuantityCode MillisievertPerMinute = new QuantityCode { Value = "P75" };

    /// <summary>
    /// microsievert per minute
    /// </summary>
    public static readonly QuantityCode MicrosievertPerMinute = new QuantityCode { Value = "P76" };

    /// <summary>
    /// nanosievert per minute
    /// </summary>
    public static readonly QuantityCode NanosievertPerMinute = new QuantityCode { Value = "P77" };

    /// <summary>
    /// reciprocal square inch
    /// </summary>
    public static readonly QuantityCode ReciprocalSquareInch = new QuantityCode { Value = "P78" };

    /// <summary>
    /// pascal square metre per kilogram
    /// </summary>
    public static readonly QuantityCode PascalSquareMetrePerKilogram = new QuantityCode { Value = "P79" };

    /// <summary>
    /// millipascal per metre
    /// </summary>
    public static readonly QuantityCode MillipascalPerMetre = new QuantityCode { Value = "P80" };

    /// <summary>
    /// kilopascal per metre
    /// </summary>
    public static readonly QuantityCode KilopascalPerMetre = new QuantityCode { Value = "P81" };

    /// <summary>
    /// hectopascal per metre
    /// </summary>
    public static readonly QuantityCode HectopascalPerMetre = new QuantityCode { Value = "P82" };

    /// <summary>
    /// standard atmosphere per metre
    /// </summary>
    public static readonly QuantityCode StandardAtmospherePerMetre = new QuantityCode { Value = "P83" };

    /// <summary>
    /// technical atmosphere per metre
    /// </summary>
    public static readonly QuantityCode TechnicalAtmospherePerMetre = new QuantityCode { Value = "P84" };

    /// <summary>
    /// torr per metre
    /// </summary>
    public static readonly QuantityCode TorrPerMetre = new QuantityCode { Value = "P85" };

    /// <summary>
    /// psi per inch
    /// </summary>
    public static readonly QuantityCode PsiPerInch = new QuantityCode { Value = "P86" };

    /// <summary>
    /// cubic metre per second square metre
    /// </summary>
    public static readonly QuantityCode CubicMetrePerSecondSquareMetre = new QuantityCode { Value = "P87" };

    /// <summary>
    /// rhe
    /// </summary>
    public static readonly QuantityCode Rhe = new QuantityCode { Value = "P88" };

    /// <summary>
    /// pound-force foot per inch
    /// </summary>
    public static readonly QuantityCode PoundForceFootPerInch = new QuantityCode { Value = "P89" };

    /// <summary>
    /// pound-force inch per inch
    /// </summary>
    public static readonly QuantityCode PoundForceInchPerInch = new QuantityCode { Value = "P90" };

    /// <summary>
    /// perm (0 ºC)
    /// </summary>
    public static readonly QuantityCode Perm0C = new QuantityCode { Value = "P91" };

    /// <summary>
    /// perm (23 ºC)
    /// </summary>
    public static readonly QuantityCode Perm23C = new QuantityCode { Value = "P92" };

    /// <summary>
    /// byte per second
    /// </summary>
    public static readonly QuantityCode BytePerSecond = new QuantityCode { Value = "P93" };

    /// <summary>
    /// kilobyte per second
    /// </summary>
    public static readonly QuantityCode KilobytePerSecond = new QuantityCode { Value = "P94" };

    /// <summary>
    /// megabyte per second
    /// </summary>
    public static readonly QuantityCode MegabytePerSecond = new QuantityCode { Value = "P95" };

    /// <summary>
    /// reciprocal volt
    /// </summary>
    public static readonly QuantityCode ReciprocalVolt = new QuantityCode { Value = "P96" };

    /// <summary>
    /// reciprocal radian
    /// </summary>
    public static readonly QuantityCode ReciprocalRadian = new QuantityCode { Value = "P97" };

    /// <summary>
    /// pascal to the power sum of stoichiometric numbers
    /// </summary>
    public static readonly QuantityCode PascalToThePowerSumOfStoichiometricNumbers = new QuantityCode { Value = "P98" };

    /// <summary>
    /// mole per cubiv metre to the power sum of stoichiometric numbers
    /// </summary>
    public static readonly QuantityCode MolePerCubivMetreToThePowerSumOfStoichiometricNumbers = new QuantityCode { Value = "P99" };

    /// <summary>
    /// pascal
    /// </summary>
    public static readonly QuantityCode Pascal = new QuantityCode { Value = "PAL" };

    /// <summary>
    /// pad
    /// </summary>
    public static readonly QuantityCode Pad = new QuantityCode { Value = "PD" };

    /// <summary>
    /// proof litre
    /// </summary>
    public static readonly QuantityCode ProofLitre = new QuantityCode { Value = "PFL" };

    /// <summary>
    /// proof gallon
    /// </summary>
    public static readonly QuantityCode ProofGallon = new QuantityCode { Value = "PGL" };

    /// <summary>
    /// pitch
    /// </summary>
    public static readonly QuantityCode Pitch = new QuantityCode { Value = "PI" };

    /// <summary>
    /// degree Plato
    /// </summary>
    public static readonly QuantityCode DegreePlato = new QuantityCode { Value = "PLA" };

    /// <summary>
    /// pound per inch of length
    /// </summary>
    public static readonly QuantityCode PoundPerInchOfLength = new QuantityCode { Value = "PO" };

    /// <summary>
    /// page per inch
    /// </summary>
    public static readonly QuantityCode PagePerInch = new QuantityCode { Value = "PQ" };

    /// <summary>
    /// pair
    /// </summary>
    public static readonly QuantityCode Pair = new QuantityCode { Value = "PR" };

    /// <summary>
    /// pound-force per square inch
    /// </summary>
    public static readonly QuantityCode PoundForcePerSquareInch = new QuantityCode { Value = "PS" };

    /// <summary>
    /// dry pint (US)
    /// </summary>
    public static readonly QuantityCode DryPintUS = new QuantityCode { Value = "PTD" };

    /// <summary>
    /// pint (UK)
    /// </summary>
    public static readonly QuantityCode PintUK = new QuantityCode { Value = "PTI" };

    /// <summary>
    /// liquid pint (US)
    /// </summary>
    public static readonly QuantityCode LiquidPintUS = new QuantityCode { Value = "PTL" };

    /// <summary>
    /// portion
    /// </summary>
    public static readonly QuantityCode Portion = new QuantityCode { Value = "PTN" };

    /// <summary>
    /// joule per tesla
    /// </summary>
    public static readonly QuantityCode JoulePerTesla = new QuantityCode { Value = "Q10" };

    /// <summary>
    /// erlang
    /// </summary>
    public static readonly QuantityCode Erlang = new QuantityCode { Value = "Q11" };

    /// <summary>
    /// octet
    /// </summary>
    public static readonly QuantityCode Octet = new QuantityCode { Value = "Q12" };

    /// <summary>
    /// octet per second
    /// </summary>
    public static readonly QuantityCode OctetPerSecond = new QuantityCode { Value = "Q13" };

    /// <summary>
    /// shannon
    /// </summary>
    public static readonly QuantityCode Shannon = new QuantityCode { Value = "Q14" };

    /// <summary>
    /// hartley
    /// </summary>
    public static readonly QuantityCode Hartley = new QuantityCode { Value = "Q15" };

    /// <summary>
    /// natural unit of information
    /// </summary>
    public static readonly QuantityCode NaturalUnitOfInformation = new QuantityCode { Value = "Q16" };

    /// <summary>
    /// shannon per second
    /// </summary>
    public static readonly QuantityCode ShannonPerSecond = new QuantityCode { Value = "Q17" };

    /// <summary>
    /// hartley per second
    /// </summary>
    public static readonly QuantityCode HartleyPerSecond = new QuantityCode { Value = "Q18" };

    /// <summary>
    /// natural unit of information per second
    /// </summary>
    public static readonly QuantityCode NaturalUnitOfInformationPerSecond = new QuantityCode { Value = "Q19" };

    /// <summary>
    /// second per kilogramm
    /// </summary>
    public static readonly QuantityCode SecondPerKilogramm = new QuantityCode { Value = "Q20" };

    /// <summary>
    /// watt square metre
    /// </summary>
    public static readonly QuantityCode WattSquareMetre = new QuantityCode { Value = "Q21" };

    /// <summary>
    /// second per radian cubic metre
    /// </summary>
    public static readonly QuantityCode SecondPerRadianCubicMetre = new QuantityCode { Value = "Q22" };

    /// <summary>
    /// weber to the power minus one
    /// </summary>
    public static readonly QuantityCode WeberToThePowerMinusOne = new QuantityCode { Value = "Q23" };

    /// <summary>
    /// reciprocal inch
    /// </summary>
    public static readonly QuantityCode ReciprocalInch = new QuantityCode { Value = "Q24" };

    /// <summary>
    /// dioptre
    /// </summary>
    public static readonly QuantityCode Dioptre = new QuantityCode { Value = "Q25" };

    /// <summary>
    /// one per one
    /// </summary>
    public static readonly QuantityCode OnePerOne = new QuantityCode { Value = "Q26" };

    /// <summary>
    /// newton metre per metre
    /// </summary>
    public static readonly QuantityCode NewtonMetrePerMetre = new QuantityCode { Value = "Q27" };

    /// <summary>
    /// kilogram per square metre pascal second
    /// </summary>
    public static readonly QuantityCode KilogramPerSquareMetrePascalSecond = new QuantityCode { Value = "Q28" };

    /// <summary>
    /// microgram per hectogram
    /// </summary>
    public static readonly QuantityCode MicrogramPerHectogram = new QuantityCode { Value = "Q29" };

    /// <summary>
    /// meal
    /// </summary>
    public static readonly QuantityCode Meal = new QuantityCode { Value = "Q3" };

    /// <summary>
    /// pH (potential of Hydrogen)
    /// </summary>
    public static readonly QuantityCode PHPotentialOfHydrogen = new QuantityCode { Value = "Q30" };

    /// <summary>
    /// kilojoule per gram
    /// </summary>
    public static readonly QuantityCode KilojoulePerGram = new QuantityCode { Value = "Q31" };

    /// <summary>
    /// femtolitre
    /// </summary>
    public static readonly QuantityCode Femtolitre = new QuantityCode { Value = "Q32" };

    /// <summary>
    /// picolitre
    /// </summary>
    public static readonly QuantityCode Picolitre = new QuantityCode { Value = "Q33" };

    /// <summary>
    /// nanolitre
    /// </summary>
    public static readonly QuantityCode Nanolitre = new QuantityCode { Value = "Q34" };

    /// <summary>
    /// megawatts per minute
    /// </summary>
    public static readonly QuantityCode MegawattsPerMinute = new QuantityCode { Value = "Q35" };

    /// <summary>
    /// square metre per cubic metre
    /// </summary>
    public static readonly QuantityCode SquareMetrePerCubicMetre = new QuantityCode { Value = "Q36" };

    /// <summary>
    /// Standard cubic metre per day
    /// </summary>
    public static readonly QuantityCode StandardCubicMetrePerDay = new QuantityCode { Value = "Q37" };

    /// <summary>
    /// Standard cubic metre per hour
    /// </summary>
    public static readonly QuantityCode StandardCubicMetrePerHour = new QuantityCode { Value = "Q38" };

    /// <summary>
    /// Normalized cubic metre per day
    /// </summary>
    public static readonly QuantityCode NormalizedCubicMetrePerDay = new QuantityCode { Value = "Q39" };

    /// <summary>
    /// Normalized cubic metre per hour
    /// </summary>
    public static readonly QuantityCode NormalizedCubicMetrePerHour = new QuantityCode { Value = "Q40" };

    /// <summary>
    /// Joule per normalised cubic metre
    /// </summary>
    public static readonly QuantityCode JoulePerNormalisedCubicMetre = new QuantityCode { Value = "Q41" };

    /// <summary>
    /// Joule per standard cubic metre
    /// </summary>
    public static readonly QuantityCode JoulePerStandardCubicMetre = new QuantityCode { Value = "Q42" };

    /// <summary>
    /// page - facsimile
    /// </summary>
    public static readonly QuantityCode PageFacsimile = new QuantityCode { Value = "QA" };

    /// <summary>
    /// quarter (of a year)
    /// </summary>
    public static readonly QuantityCode QuarterOfAYear = new QuantityCode { Value = "QAN" };

    /// <summary>
    /// page - hardcopy
    /// </summary>
    public static readonly QuantityCode PageHardcopy = new QuantityCode { Value = "QB" };

    /// <summary>
    /// quire
    /// </summary>
    public static readonly QuantityCode Quire = new QuantityCode { Value = "QR" };

    /// <summary>
    /// dry quart (US)
    /// </summary>
    public static readonly QuantityCode DryQuartUS = new QuantityCode { Value = "QTD" };

    /// <summary>
    /// quart (UK)
    /// </summary>
    public static readonly QuantityCode QuartUK = new QuantityCode { Value = "QTI" };

    /// <summary>
    /// liquid quart (US)
    /// </summary>
    public static readonly QuantityCode LiquidQuartUS = new QuantityCode { Value = "QTL" };

    /// <summary>
    /// quarter (UK)
    /// </summary>
    public static readonly QuantityCode QuarterUK = new QuantityCode { Value = "QTR" };

    /// <summary>
    /// pica
    /// </summary>
    public static readonly QuantityCode Pica = new QuantityCode { Value = "R1" };

    /// <summary>
    /// thousand cubic metre
    /// </summary>
    public static readonly QuantityCode ThousandCubicMetre = new QuantityCode { Value = "R9" };

    /// <summary>
    /// running or operating hour
    /// </summary>
    public static readonly QuantityCode RunningOrOperatingHour = new QuantityCode { Value = "RH" };

    /// <summary>
    /// ream
    /// </summary>
    public static readonly QuantityCode Ream = new QuantityCode { Value = "RM" };

    /// <summary>
    /// room
    /// </summary>
    public static readonly QuantityCode Room = new QuantityCode { Value = "ROM" };

    /// <summary>
    /// pound per ream
    /// </summary>
    public static readonly QuantityCode PoundPerReam = new QuantityCode { Value = "RP" };

    /// <summary>
    /// revolutions per minute
    /// </summary>
    public static readonly QuantityCode RevolutionsPerMinute = new QuantityCode { Value = "RPM" };

    /// <summary>
    /// revolutions per second
    /// </summary>
    public static readonly QuantityCode RevolutionsPerSecond = new QuantityCode { Value = "RPS" };

    /// <summary>
    /// revenue ton mile
    /// </summary>
    public static readonly QuantityCode RevenueTonMile = new QuantityCode { Value = "RT" };

    /// <summary>
    /// square foot per second
    /// </summary>
    public static readonly QuantityCode SquareFootPerSecond = new QuantityCode { Value = "S3" };

    /// <summary>
    /// square metre per second
    /// </summary>
    public static readonly QuantityCode SquareMetrePerSecond = new QuantityCode { Value = "S4" };

    /// <summary>
    /// half year (6 months)
    /// </summary>
    public static readonly QuantityCode HalfYear6Months = new QuantityCode { Value = "SAN" };

    /// <summary>
    /// score
    /// </summary>
    public static readonly QuantityCode Score = new QuantityCode { Value = "SCO" };

    /// <summary>
    /// scruple
    /// </summary>
    public static readonly QuantityCode Scruple = new QuantityCode { Value = "SCR" };

    /// <summary>
    /// second [unit of time]
    /// </summary>
    public static readonly QuantityCode SecondUnitOfTime = new QuantityCode { Value = "SEC" };

    /// <summary>
    /// set
    /// </summary>
    public static readonly QuantityCode Set = new QuantityCode { Value = "SET" };

    /// <summary>
    /// segment
    /// </summary>
    public static readonly QuantityCode Segment = new QuantityCode { Value = "SG" };

    /// <summary>
    /// siemens
    /// </summary>
    public static readonly QuantityCode Siemens = new QuantityCode { Value = "SIE" };

    /// <summary>
    /// Standard cubic metre
    /// </summary>
    public static readonly QuantityCode StandardCubicMetre = new QuantityCode { Value = "SM3" };

    /// <summary>
    /// mile (statute mile)
    /// </summary>
    public static readonly QuantityCode MileStatuteMile = new QuantityCode { Value = "SMI" };

    /// <summary>
    /// square
    /// </summary>
    public static readonly QuantityCode Square = new QuantityCode { Value = "SQ" };

    /// <summary>
    /// square, roofing
    /// </summary>
    public static readonly QuantityCode SquareRoofing = new QuantityCode { Value = "SQR" };

    /// <summary>
    /// strip
    /// </summary>
    public static readonly QuantityCode Strip = new QuantityCode { Value = "SR" };

    /// <summary>
    /// stick
    /// </summary>
    public static readonly QuantityCode Stick = new QuantityCode { Value = "STC" };

    /// <summary>
    /// stone (UK)
    /// </summary>
    public static readonly QuantityCode StoneUK = new QuantityCode { Value = "STI" };

    /// <summary>
    /// stick, cigarette
    /// </summary>
    public static readonly QuantityCode StickCigarette = new QuantityCode { Value = "STK" };

    /// <summary>
    /// standard litre
    /// </summary>
    public static readonly QuantityCode StandardLitre = new QuantityCode { Value = "STL" };

    /// <summary>
    /// ton (US) or short ton (UK/US)
    /// </summary>
    public static readonly QuantityCode TonUSOrShortTonUKUS = new QuantityCode { Value = "STN" };

    /// <summary>
    /// straw
    /// </summary>
    public static readonly QuantityCode Straw = new QuantityCode { Value = "STW" };

    /// <summary>
    /// skein
    /// </summary>
    public static readonly QuantityCode Skein = new QuantityCode { Value = "SW" };

    /// <summary>
    /// shipment
    /// </summary>
    public static readonly QuantityCode Shipment = new QuantityCode { Value = "SX" };

    /// <summary>
    /// syringe
    /// </summary>
    public static readonly QuantityCode Syringe = new QuantityCode { Value = "SYR" };

    /// <summary>
    /// telecommunication line in service
    /// </summary>
    public static readonly QuantityCode TelecommunicationLineInService = new QuantityCode { Value = "T0" };

    /// <summary>
    /// thousand piece
    /// </summary>
    public static readonly QuantityCode ThousandPiece = new QuantityCode { Value = "T3" };

    /// <summary>
    /// kiloampere hour (thousand ampere hour)
    /// </summary>
    public static readonly QuantityCode KiloampereHourThousandAmpereHour = new QuantityCode { Value = "TAH" };

    /// <summary>
    /// total acid number
    /// </summary>
    public static readonly QuantityCode TotalAcidNumber = new QuantityCode { Value = "TAN" };

    /// <summary>
    /// thousand square inch
    /// </summary>
    public static readonly QuantityCode ThousandSquareInch = new QuantityCode { Value = "TI" };

    /// <summary>
    /// metric ton, including container
    /// </summary>
    public static readonly QuantityCode MetricTonIncludingContainer = new QuantityCode { Value = "TIC" };

    /// <summary>
    /// metric ton, including inner packaging
    /// </summary>
    public static readonly QuantityCode MetricTonIncludingInnerPackaging = new QuantityCode { Value = "TIP" };

    /// <summary>
    /// tonne kilometre
    /// </summary>
    public static readonly QuantityCode TonneKilometre = new QuantityCode { Value = "TKM" };

    /// <summary>
    /// kilogram of imported meat, less offal
    /// </summary>
    public static readonly QuantityCode KilogramOfImportedMeatLessOffal = new QuantityCode { Value = "TMS" };

    /// <summary>
    /// tonne (metric ton)
    /// </summary>
    public static readonly QuantityCode TonneMetricTon = new QuantityCode { Value = "TNE" };

    /// <summary>
    /// ten pack
    /// </summary>
    public static readonly QuantityCode TenPack = new QuantityCode { Value = "TP" };

    /// <summary>
    /// teeth per inch
    /// </summary>
    public static readonly QuantityCode TeethPerInch = new QuantityCode { Value = "TPI" };

    /// <summary>
    /// ten pair
    /// </summary>
    public static readonly QuantityCode TenPair = new QuantityCode { Value = "TPR" };

    /// <summary>
    /// thousand cubic metre per day
    /// </summary>
    public static readonly QuantityCode ThousandCubicMetrePerDay = new QuantityCode { Value = "TQD" };

    /// <summary>
    /// trillion (EUR)
    /// </summary>
    public static readonly QuantityCode TrillionEUR = new QuantityCode { Value = "TRL" };

    /// <summary>
    /// ten set
    /// </summary>
    public static readonly QuantityCode TenSet = new QuantityCode { Value = "TST" };

    /// <summary>
    /// ten thousand sticks
    /// </summary>
    public static readonly QuantityCode TenThousandSticks = new QuantityCode { Value = "TTS" };

    /// <summary>
    /// treatment
    /// </summary>
    public static readonly QuantityCode Treatment = new QuantityCode { Value = "U1" };

    /// <summary>
    /// tablet
    /// </summary>
    public static readonly QuantityCode Tablet = new QuantityCode { Value = "U2" };

    /// <summary>
    /// telecommunication line in service average
    /// </summary>
    public static readonly QuantityCode TelecommunicationLineInServiceAverage = new QuantityCode { Value = "UB" };

    /// <summary>
    /// telecommunication port
    /// </summary>
    public static readonly QuantityCode TelecommunicationPort = new QuantityCode { Value = "UC" };

    /// <summary>
    /// volt - ampere per kilogram
    /// </summary>
    public static readonly QuantityCode VoltAmperePerKilogram = new QuantityCode { Value = "VA" };

    /// <summary>
    /// volt
    /// </summary>
    public static readonly QuantityCode Volt = new QuantityCode { Value = "VLT" };

    /// <summary>
    /// percent volume
    /// </summary>
    public static readonly QuantityCode PercentVolume = new QuantityCode { Value = "VP" };

    /// <summary>
    /// wet kilo
    /// </summary>
    public static readonly QuantityCode WetKilo = new QuantityCode { Value = "W2" };

    /// <summary>
    /// watt per kilogram
    /// </summary>
    public static readonly QuantityCode WattPerKilogram = new QuantityCode { Value = "WA" };

    /// <summary>
    /// wet pound
    /// </summary>
    public static readonly QuantityCode WetPound = new QuantityCode { Value = "WB" };

    /// <summary>
    /// cord
    /// </summary>
    public static readonly QuantityCode Cord = new QuantityCode { Value = "WCD" };

    /// <summary>
    /// wet ton
    /// </summary>
    public static readonly QuantityCode WetTon = new QuantityCode { Value = "WE" };

    /// <summary>
    /// weber
    /// </summary>
    public static readonly QuantityCode Weber = new QuantityCode { Value = "WEB" };

    /// <summary>
    /// week
    /// </summary>
    public static readonly QuantityCode Week = new QuantityCode { Value = "WEE" };

    /// <summary>
    /// wine gallon
    /// </summary>
    public static readonly QuantityCode WineGallon = new QuantityCode { Value = "WG" };

    /// <summary>
    /// watt hour
    /// </summary>
    public static readonly QuantityCode WattHour = new QuantityCode { Value = "WHR" };

    /// <summary>
    /// working month
    /// </summary>
    public static readonly QuantityCode WorkingMonth = new QuantityCode { Value = "WM" };

    /// <summary>
    /// standard
    /// </summary>
    public static readonly QuantityCode Standard = new QuantityCode { Value = "WSD" };

    /// <summary>
    /// watt
    /// </summary>
    public static readonly QuantityCode Watt = new QuantityCode { Value = "WTT" };

    /// <summary>
    /// Gunter's chain
    /// </summary>
    public static readonly QuantityCode GunterSChain = new QuantityCode { Value = "X1" };

    /// <summary>
    /// square yard
    /// </summary>
    public static readonly QuantityCode SquareYard = new QuantityCode { Value = "YDK" };

    /// <summary>
    /// cubic yard
    /// </summary>
    public static readonly QuantityCode CubicYard = new QuantityCode { Value = "YDQ" };

    /// <summary>
    /// yard
    /// </summary>
    public static readonly QuantityCode Yard = new QuantityCode { Value = "YRD" };

    /// <summary>
    /// hanging container
    /// </summary>
    public static readonly QuantityCode HangingContainer = new QuantityCode { Value = "Z11" };

    /// <summary>
    /// nanomole
    /// </summary>
    public static readonly QuantityCode Nanomole = new QuantityCode { Value = "Z9" };

    /// <summary>
    /// page
    /// </summary>
    public static readonly QuantityCode Page = new QuantityCode { Value = "ZP" };

    /// <summary>
    /// mutually defined
    /// </summary>
    public static readonly QuantityCode MutuallyDefined = new QuantityCode { Value = "ZZ" };

}
