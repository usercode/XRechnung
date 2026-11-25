namespace XRechnung;

/// <summary>
/// Codes for Units of Measure Used in International Trade (UN/ECE Recommendation N°20)
/// <br /><br />
/// ie Codeliste basiert auf UN/ECE Recommendation N°20. Als gelöscht oder veraltet markierte Codes werden nicht in die Codeliste übernommen. Die Codeliste kann im Zusammenhang mit EN16931-1:2017 und der darauf basierenden XRechnung (Standard und Extension) verwendet werden. Für Verwendungshinweise in diesem Kontext siehe: EN16931-3-2, 3-3, 3-4 Annex A bzw. die XRechnung-Spezifikation. Des Weiteren enthält die Codeliste alle Einträge, die für die Nutzung im Kontext des Standards XBestellung benötigt werden.
/// <br /><br />
/// https://www.xrepository.de/details/urn:xoev-de:kosit:codeliste:rec20_3
/// </summary>
public record class QuantityCode : Code
{
    /// <summary>
    /// group
    /// </summary>
    public static QuantityCode Group => new() { Value = "10" };

    /// <summary>
    /// outfit
    /// </summary>
    public static QuantityCode Outfit => new() { Value = "11" };

    /// <summary>
    /// ration
    /// </summary>
    public static QuantityCode Ration => new() { Value = "13" };

    /// <summary>
    /// shot
    /// </summary>
    public static QuantityCode Shot => new() { Value = "14" };

    /// <summary>
    /// stick, military
    /// </summary>
    public static QuantityCode StickMilitary => new() { Value = "15" };

    /// <summary>
    /// twenty foot container
    /// </summary>
    public static QuantityCode TwentyFootContainer => new() { Value = "20" };

    /// <summary>
    /// forty foot container
    /// </summary>
    public static QuantityCode FortyFootContainer => new() { Value = "21" };

    /// <summary>
    /// decilitre per gram
    /// </summary>
    public static QuantityCode DecilitrePerGram => new() { Value = "22" };

    /// <summary>
    /// gram per cubic centimetre
    /// </summary>
    public static QuantityCode GramPerCubicCentimetre => new() { Value = "23" };

    /// <summary>
    /// theoretical pound
    /// </summary>
    public static QuantityCode TheoreticalPound => new() { Value = "24" };

    /// <summary>
    /// gram per square centimetre
    /// </summary>
    public static QuantityCode GramPerSquareCentimetre => new() { Value = "25" };

    /// <summary>
    /// theoretical ton
    /// </summary>
    public static QuantityCode TheoreticalTon => new() { Value = "27" };

    /// <summary>
    /// kilogram per square metre
    /// </summary>
    public static QuantityCode KilogramPerSquareMetre => new() { Value = "28" };

    /// <summary>
    /// kilopascal square metre per gram
    /// </summary>
    public static QuantityCode KilopascalSquareMetrePerGram => new() { Value = "33" };

    /// <summary>
    /// kilopascal per millimetre
    /// </summary>
    public static QuantityCode KilopascalPerMillimetre => new() { Value = "34" };

    /// <summary>
    /// millilitre per square centimetre second
    /// </summary>
    public static QuantityCode MillilitrePerSquareCentimetreSecond => new() { Value = "35" };

    /// <summary>
    /// ounce per square foot
    /// </summary>
    public static QuantityCode OuncePerSquareFoot => new() { Value = "37" };

    /// <summary>
    /// ounce per square foot per 0,01inch
    /// </summary>
    public static QuantityCode OuncePerSquareFootPer001inch => new() { Value = "38" };

    /// <summary>
    /// millilitre per second
    /// </summary>
    public static QuantityCode MillilitrePerSecond => new() { Value = "40" };

    /// <summary>
    /// millilitre per minute
    /// </summary>
    public static QuantityCode MillilitrePerMinute => new() { Value = "41" };

    /// <summary>
    /// sitas
    /// </summary>
    public static QuantityCode Sitas => new() { Value = "56" };

    /// <summary>
    /// mesh
    /// </summary>
    public static QuantityCode Mesh => new() { Value = "57" };

    /// <summary>
    /// net kilogram
    /// </summary>
    public static QuantityCode NetKilogram => new() { Value = "58" };

    /// <summary>
    /// part per million
    /// </summary>
    public static QuantityCode PartPerMillion => new() { Value = "59" };

    /// <summary>
    /// percent weight
    /// </summary>
    public static QuantityCode PercentWeight => new() { Value = "60" };

    /// <summary>
    /// part per billion (US)
    /// </summary>
    public static QuantityCode PartPerBillionUS => new() { Value = "61" };

    /// <summary>
    /// millipascal
    /// </summary>
    public static QuantityCode Millipascal => new() { Value = "74" };

    /// <summary>
    /// milli-inch
    /// </summary>
    public static QuantityCode MilliInch => new() { Value = "77" };

    /// <summary>
    /// pound per square inch absolute
    /// </summary>
    public static QuantityCode PoundPerSquareInchAbsolute => new() { Value = "80" };

    /// <summary>
    /// henry
    /// </summary>
    public static QuantityCode Henry => new() { Value = "81" };

    /// <summary>
    /// foot pound-force
    /// </summary>
    public static QuantityCode FootPoundForce => new() { Value = "85" };

    /// <summary>
    /// pound per cubic foot
    /// </summary>
    public static QuantityCode PoundPerCubicFoot => new() { Value = "87" };

    /// <summary>
    /// poise
    /// </summary>
    public static QuantityCode Poise => new() { Value = "89" };

    /// <summary>
    /// stokes
    /// </summary>
    public static QuantityCode Stokes => new() { Value = "91" };

    /// <summary>
    /// fixed rate
    /// </summary>
    public static QuantityCode FixedRate => new() { Value = "1I" };

    /// <summary>
    /// radian per second
    /// </summary>
    public static QuantityCode RadianPerSecond => new() { Value = "2A" };

    /// <summary>
    /// radian per second squared
    /// </summary>
    public static QuantityCode RadianPerSecondSquared => new() { Value = "2B" };

    /// <summary>
    /// roentgen
    /// </summary>
    public static QuantityCode Roentgen => new() { Value = "2C" };

    /// <summary>
    /// volt AC
    /// </summary>
    public static QuantityCode VoltAC => new() { Value = "2G" };

    /// <summary>
    /// volt DC
    /// </summary>
    public static QuantityCode VoltDC => new() { Value = "2H" };

    /// <summary>
    /// British thermal unit (international table) per hour
    /// </summary>
    public static QuantityCode BritishThermalUnitInternationalTablePerHour => new() { Value = "2I" };

    /// <summary>
    /// cubic centimetre per second
    /// </summary>
    public static QuantityCode CubicCentimetrePerSecond => new() { Value = "2J" };

    /// <summary>
    /// cubic foot per hour
    /// </summary>
    public static QuantityCode CubicFootPerHour => new() { Value = "2K" };

    /// <summary>
    /// cubic foot per minute
    /// </summary>
    public static QuantityCode CubicFootPerMinute => new() { Value = "2L" };

    /// <summary>
    /// centimetre per second
    /// </summary>
    public static QuantityCode CentimetrePerSecond => new() { Value = "2M" };

    /// <summary>
    /// decibel
    /// </summary>
    public static QuantityCode Decibel => new() { Value = "2N" };

    /// <summary>
    /// kilobyte
    /// </summary>
    public static QuantityCode Kilobyte => new() { Value = "2P" };

    /// <summary>
    /// kilobecquerel
    /// </summary>
    public static QuantityCode Kilobecquerel => new() { Value = "2Q" };

    /// <summary>
    /// kilocurie
    /// </summary>
    public static QuantityCode Kilocurie => new() { Value = "2R" };

    /// <summary>
    /// megagram
    /// </summary>
    public static QuantityCode Megagram => new() { Value = "2U" };

    /// <summary>
    /// metre per minute
    /// </summary>
    public static QuantityCode MetrePerMinute => new() { Value = "2X" };

    /// <summary>
    /// milliroentgen
    /// </summary>
    public static QuantityCode Milliroentgen => new() { Value = "2Y" };

    /// <summary>
    /// millivolt
    /// </summary>
    public static QuantityCode Millivolt => new() { Value = "2Z" };

    /// <summary>
    /// megajoule
    /// </summary>
    public static QuantityCode Megajoule => new() { Value = "3B" };

    /// <summary>
    /// manmonth
    /// </summary>
    public static QuantityCode Manmonth => new() { Value = "3C" };

    /// <summary>
    /// centistokes
    /// </summary>
    public static QuantityCode Centistokes => new() { Value = "4C" };

    /// <summary>
    /// microlitre
    /// </summary>
    public static QuantityCode Microlitre => new() { Value = "4G" };

    /// <summary>
    /// micrometre (micron)
    /// </summary>
    public static QuantityCode MicrometreMicron => new() { Value = "4H" };

    /// <summary>
    /// milliampere
    /// </summary>
    public static QuantityCode Milliampere => new() { Value = "4K" };

    /// <summary>
    /// megabyte
    /// </summary>
    public static QuantityCode Megabyte => new() { Value = "4L" };

    /// <summary>
    /// milligram per hour
    /// </summary>
    public static QuantityCode MilligramPerHour => new() { Value = "4M" };

    /// <summary>
    /// megabecquerel
    /// </summary>
    public static QuantityCode Megabecquerel => new() { Value = "4N" };

    /// <summary>
    /// microfarad
    /// </summary>
    public static QuantityCode Microfarad => new() { Value = "4O" };

    /// <summary>
    /// newton per metre
    /// </summary>
    public static QuantityCode NewtonPerMetre => new() { Value = "4P" };

    /// <summary>
    /// ounce inch
    /// </summary>
    public static QuantityCode OunceInch => new() { Value = "4Q" };

    /// <summary>
    /// ounce foot
    /// </summary>
    public static QuantityCode OunceFoot => new() { Value = "4R" };

    /// <summary>
    /// picofarad
    /// </summary>
    public static QuantityCode Picofarad => new() { Value = "4T" };

    /// <summary>
    /// pound per hour
    /// </summary>
    public static QuantityCode PoundPerHour => new() { Value = "4U" };

    /// <summary>
    /// ton (US) per hour
    /// </summary>
    public static QuantityCode TonUSPerHour => new() { Value = "4W" };

    /// <summary>
    /// kilolitre per hour
    /// </summary>
    public static QuantityCode KilolitrePerHour => new() { Value = "4X" };

    /// <summary>
    /// barrel (US) per minute
    /// </summary>
    public static QuantityCode BarrelUSPerMinute => new() { Value = "5A" };

    /// <summary>
    /// batch
    /// </summary>
    public static QuantityCode Batch => new() { Value = "5B" };

    /// <summary>
    /// MMSCF/day
    /// </summary>
    public static QuantityCode MMSCFDay => new() { Value = "5E" };

    /// <summary>
    /// hydraulic horse power
    /// </summary>
    public static QuantityCode HydraulicHorsePower => new() { Value = "5J" };

    /// <summary>
    /// ampere square metre per joule second
    /// </summary>
    public static QuantityCode AmpereSquareMetrePerJouleSecond => new() { Value = "A10" };

    /// <summary>
    /// angstrom
    /// </summary>
    public static QuantityCode Angstrom => new() { Value = "A11" };

    /// <summary>
    /// astronomical unit
    /// </summary>
    public static QuantityCode AstronomicalUnit => new() { Value = "A12" };

    /// <summary>
    /// attojoule
    /// </summary>
    public static QuantityCode Attojoule => new() { Value = "A13" };

    /// <summary>
    /// barn
    /// </summary>
    public static QuantityCode Barn => new() { Value = "A14" };

    /// <summary>
    /// barn per electronvolt
    /// </summary>
    public static QuantityCode BarnPerElectronvolt => new() { Value = "A15" };

    /// <summary>
    /// barn per steradian electronvolt
    /// </summary>
    public static QuantityCode BarnPerSteradianElectronvolt => new() { Value = "A16" };

    /// <summary>
    /// barn per steradian
    /// </summary>
    public static QuantityCode BarnPerSteradian => new() { Value = "A17" };

    /// <summary>
    /// becquerel per kilogram
    /// </summary>
    public static QuantityCode BecquerelPerKilogram => new() { Value = "A18" };

    /// <summary>
    /// becquerel per cubic metre
    /// </summary>
    public static QuantityCode BecquerelPerCubicMetre => new() { Value = "A19" };

    /// <summary>
    /// ampere per centimetre
    /// </summary>
    public static QuantityCode AmperePerCentimetre => new() { Value = "A2" };

    /// <summary>
    /// British thermal unit (international table) per second square foot degree Rankine
    /// </summary>
    public static QuantityCode BritishThermalUnitInternationalTablePerSecondSquareFootDegreeRankine => new() { Value = "A20" };

    /// <summary>
    /// British thermal unit (international table) per pound degree Rankine
    /// </summary>
    public static QuantityCode BritishThermalUnitInternationalTablePerPoundDegreeRankine => new() { Value = "A21" };

    /// <summary>
    /// British thermal unit (international table) per second foot degree Rankine
    /// </summary>
    public static QuantityCode BritishThermalUnitInternationalTablePerSecondFootDegreeRankine => new() { Value = "A22" };

    /// <summary>
    /// British thermal unit (international table) per hour square foot degree Rankine
    /// </summary>
    public static QuantityCode BritishThermalUnitInternationalTablePerHourSquareFootDegreeRankine => new() { Value = "A23" };

    /// <summary>
    /// candela per square metre
    /// </summary>
    public static QuantityCode CandelaPerSquareMetre => new() { Value = "A24" };

    /// <summary>
    /// coulomb metre
    /// </summary>
    public static QuantityCode CoulombMetre => new() { Value = "A26" };

    /// <summary>
    /// coulomb metre squared per volt
    /// </summary>
    public static QuantityCode CoulombMetreSquaredPerVolt => new() { Value = "A27" };

    /// <summary>
    /// coulomb per cubic centimetre
    /// </summary>
    public static QuantityCode CoulombPerCubicCentimetre => new() { Value = "A28" };

    /// <summary>
    /// coulomb per cubic metre
    /// </summary>
    public static QuantityCode CoulombPerCubicMetre => new() { Value = "A29" };

    /// <summary>
    /// ampere per millimetre
    /// </summary>
    public static QuantityCode AmperePerMillimetre => new() { Value = "A3" };

    /// <summary>
    /// coulomb per cubic millimetre
    /// </summary>
    public static QuantityCode CoulombPerCubicMillimetre => new() { Value = "A30" };

    /// <summary>
    /// coulomb per kilogram second
    /// </summary>
    public static QuantityCode CoulombPerKilogramSecond => new() { Value = "A31" };

    /// <summary>
    /// coulomb per mole
    /// </summary>
    public static QuantityCode CoulombPerMole => new() { Value = "A32" };

    /// <summary>
    /// coulomb per square centimetre
    /// </summary>
    public static QuantityCode CoulombPerSquareCentimetre => new() { Value = "A33" };

    /// <summary>
    /// coulomb per square metre
    /// </summary>
    public static QuantityCode CoulombPerSquareMetre => new() { Value = "A34" };

    /// <summary>
    /// coulomb per square millimetre
    /// </summary>
    public static QuantityCode CoulombPerSquareMillimetre => new() { Value = "A35" };

    /// <summary>
    /// cubic centimetre per mole
    /// </summary>
    public static QuantityCode CubicCentimetrePerMole => new() { Value = "A36" };

    /// <summary>
    /// cubic decimetre per mole
    /// </summary>
    public static QuantityCode CubicDecimetrePerMole => new() { Value = "A37" };

    /// <summary>
    /// cubic metre per coulomb
    /// </summary>
    public static QuantityCode CubicMetrePerCoulomb => new() { Value = "A38" };

    /// <summary>
    /// cubic metre per kilogram
    /// </summary>
    public static QuantityCode CubicMetrePerKilogram => new() { Value = "A39" };

    /// <summary>
    /// ampere per square centimetre
    /// </summary>
    public static QuantityCode AmperePerSquareCentimetre => new() { Value = "A4" };

    /// <summary>
    /// cubic metre per mole
    /// </summary>
    public static QuantityCode CubicMetrePerMole => new() { Value = "A40" };

    /// <summary>
    /// ampere per square metre
    /// </summary>
    public static QuantityCode AmperePerSquareMetre => new() { Value = "A41" };

    /// <summary>
    /// curie per kilogram
    /// </summary>
    public static QuantityCode CuriePerKilogram => new() { Value = "A42" };

    /// <summary>
    /// deadweight tonnage
    /// </summary>
    public static QuantityCode DeadweightTonnage => new() { Value = "A43" };

    /// <summary>
    /// decalitre
    /// </summary>
    public static QuantityCode Decalitre => new() { Value = "A44" };

    /// <summary>
    /// decametre
    /// </summary>
    public static QuantityCode Decametre => new() { Value = "A45" };

    /// <summary>
    /// decitex
    /// </summary>
    public static QuantityCode Decitex => new() { Value = "A47" };

    /// <summary>
    /// degree Rankine
    /// </summary>
    public static QuantityCode DegreeRankine => new() { Value = "A48" };

    /// <summary>
    /// denier
    /// </summary>
    public static QuantityCode Denier => new() { Value = "A49" };

    /// <summary>
    /// ampere square metre
    /// </summary>
    public static QuantityCode AmpereSquareMetre => new() { Value = "A5" };

    /// <summary>
    /// electronvolt
    /// </summary>
    public static QuantityCode Electronvolt => new() { Value = "A53" };

    /// <summary>
    /// electronvolt per metre
    /// </summary>
    public static QuantityCode ElectronvoltPerMetre => new() { Value = "A54" };

    /// <summary>
    /// electronvolt square metre
    /// </summary>
    public static QuantityCode ElectronvoltSquareMetre => new() { Value = "A55" };

    /// <summary>
    /// electronvolt square metre per kilogram
    /// </summary>
    public static QuantityCode ElectronvoltSquareMetrePerKilogram => new() { Value = "A56" };

    /// <summary>
    /// 8-part cloud cover
    /// </summary>
    public static QuantityCode Code8PartCloudCover => new() { Value = "A59" };

    /// <summary>
    /// ampere per square metre kelvin squared
    /// </summary>
    public static QuantityCode AmperePerSquareMetreKelvinSquared => new() { Value = "A6" };

    /// <summary>
    /// exajoule
    /// </summary>
    public static QuantityCode Exajoule => new() { Value = "A68" };

    /// <summary>
    /// farad per metre
    /// </summary>
    public static QuantityCode FaradPerMetre => new() { Value = "A69" };

    /// <summary>
    /// ampere per square millimetre
    /// </summary>
    public static QuantityCode AmperePerSquareMillimetre => new() { Value = "A7" };

    /// <summary>
    /// femtojoule
    /// </summary>
    public static QuantityCode Femtojoule => new() { Value = "A70" };

    /// <summary>
    /// femtometre
    /// </summary>
    public static QuantityCode Femtometre => new() { Value = "A71" };

    /// <summary>
    /// foot per second squared
    /// </summary>
    public static QuantityCode FootPerSecondSquared => new() { Value = "A73" };

    /// <summary>
    /// foot pound-force per second
    /// </summary>
    public static QuantityCode FootPoundForcePerSecond => new() { Value = "A74" };

    /// <summary>
    /// freight ton
    /// </summary>
    public static QuantityCode FreightTon => new() { Value = "A75" };

    /// <summary>
    /// gal
    /// </summary>
    public static QuantityCode Gal => new() { Value = "A76" };

    /// <summary>
    /// ampere second
    /// </summary>
    public static QuantityCode AmpereSecond => new() { Value = "A8" };

    /// <summary>
    /// gigacoulomb per cubic metre
    /// </summary>
    public static QuantityCode GigacoulombPerCubicMetre => new() { Value = "A84" };

    /// <summary>
    /// gigaelectronvolt
    /// </summary>
    public static QuantityCode Gigaelectronvolt => new() { Value = "A85" };

    /// <summary>
    /// gigahertz
    /// </summary>
    public static QuantityCode Gigahertz => new() { Value = "A86" };

    /// <summary>
    /// gigaohm
    /// </summary>
    public static QuantityCode Gigaohm => new() { Value = "A87" };

    /// <summary>
    /// gigaohm metre
    /// </summary>
    public static QuantityCode GigaohmMetre => new() { Value = "A88" };

    /// <summary>
    /// gigapascal
    /// </summary>
    public static QuantityCode Gigapascal => new() { Value = "A89" };

    /// <summary>
    /// rate
    /// </summary>
    public static QuantityCode Rate => new() { Value = "A9" };

    /// <summary>
    /// gigawatt
    /// </summary>
    public static QuantityCode Gigawatt => new() { Value = "A90" };

    /// <summary>
    /// gon
    /// </summary>
    public static QuantityCode Gon => new() { Value = "A91" };

    /// <summary>
    /// gram per cubic metre
    /// </summary>
    public static QuantityCode GramPerCubicMetre => new() { Value = "A93" };

    /// <summary>
    /// gram per mole
    /// </summary>
    public static QuantityCode GramPerMole => new() { Value = "A94" };

    /// <summary>
    /// gray
    /// </summary>
    public static QuantityCode Gray => new() { Value = "A95" };

    /// <summary>
    /// gray per second
    /// </summary>
    public static QuantityCode GrayPerSecond => new() { Value = "A96" };

    /// <summary>
    /// hectopascal
    /// </summary>
    public static QuantityCode Hectopascal => new() { Value = "A97" };

    /// <summary>
    /// henry per metre
    /// </summary>
    public static QuantityCode HenryPerMetre => new() { Value = "A98" };

    /// <summary>
    /// bit
    /// </summary>
    public static QuantityCode Bit => new() { Value = "A99" };

    /// <summary>
    /// ball
    /// </summary>
    public static QuantityCode Ball => new() { Value = "AA" };

    /// <summary>
    /// bulk pack
    /// </summary>
    public static QuantityCode BulkPack => new() { Value = "AB" };

    /// <summary>
    /// acre
    /// </summary>
    public static QuantityCode Acre => new() { Value = "ACR" };

    /// <summary>
    /// activity
    /// </summary>
    public static QuantityCode Activity => new() { Value = "ACT" };

    /// <summary>
    /// byte
    /// </summary>
    public static QuantityCode Byte => new() { Value = "AD" };

    /// <summary>
    /// ampere per metre
    /// </summary>
    public static QuantityCode AmperePerMetre => new() { Value = "AE" };

    /// <summary>
    /// additional minute
    /// </summary>
    public static QuantityCode AdditionalMinute => new() { Value = "AH" };

    /// <summary>
    /// average minute per call
    /// </summary>
    public static QuantityCode AverageMinutePerCall => new() { Value = "AI" };

    /// <summary>
    /// fathom
    /// </summary>
    public static QuantityCode Fathom => new() { Value = "AK" };

    /// <summary>
    /// access line
    /// </summary>
    public static QuantityCode AccessLine => new() { Value = "AL" };

    /// <summary>
    /// ampere hour
    /// </summary>
    public static QuantityCode AmpereHour => new() { Value = "AMH" };

    /// <summary>
    /// ampere
    /// </summary>
    public static QuantityCode Ampere => new() { Value = "AMP" };

    /// <summary>
    /// year
    /// </summary>
    public static QuantityCode Year => new() { Value = "ANN" };

    /// <summary>
    /// troy ounce or apothecary ounce
    /// </summary>
    public static QuantityCode TroyOunceOrApothecaryOunce => new() { Value = "APZ" };

    /// <summary>
    /// anti-hemophilic factor (AHF) unit
    /// </summary>
    public static QuantityCode AntiHemophilicFactorAHFUnit => new() { Value = "AQ" };

    /// <summary>
    /// assortment
    /// </summary>
    public static QuantityCode Assortment => new() { Value = "AS" };

    /// <summary>
    /// alcoholic strength by mass
    /// </summary>
    public static QuantityCode AlcoholicStrengthByMass => new() { Value = "ASM" };

    /// <summary>
    /// alcoholic strength by volume
    /// </summary>
    public static QuantityCode AlcoholicStrengthByVolume => new() { Value = "ASU" };

    /// <summary>
    /// standard atmosphere
    /// </summary>
    public static QuantityCode StandardAtmosphere => new() { Value = "ATM" };

    /// <summary>
    /// american wire gauge
    /// </summary>
    public static QuantityCode AmericanWireGauge => new() { Value = "AWG" };

    /// <summary>
    /// assembly
    /// </summary>
    public static QuantityCode Assembly => new() { Value = "AY" };

    /// <summary>
    /// British thermal unit (international table) per pound
    /// </summary>
    public static QuantityCode BritishThermalUnitInternationalTablePerPound => new() { Value = "AZ" };

    /// <summary>
    /// barrel (US) per day
    /// </summary>
    public static QuantityCode BarrelUSPerDay => new() { Value = "B1" };

    /// <summary>
    /// bit per second
    /// </summary>
    public static QuantityCode BitPerSecond => new() { Value = "B10" };

    /// <summary>
    /// joule per kilogram kelvin
    /// </summary>
    public static QuantityCode JoulePerKilogramKelvin => new() { Value = "B11" };

    /// <summary>
    /// joule per metre
    /// </summary>
    public static QuantityCode JoulePerMetre => new() { Value = "B12" };

    /// <summary>
    /// joule per square metre
    /// </summary>
    public static QuantityCode JoulePerSquareMetre => new() { Value = "B13" };

    /// <summary>
    /// joule per metre to the fourth power
    /// </summary>
    public static QuantityCode JoulePerMetreToTheFourthPower => new() { Value = "B14" };

    /// <summary>
    /// joule per mole
    /// </summary>
    public static QuantityCode JoulePerMole => new() { Value = "B15" };

    /// <summary>
    /// joule per mole kelvin
    /// </summary>
    public static QuantityCode JoulePerMoleKelvin => new() { Value = "B16" };

    /// <summary>
    /// credit
    /// </summary>
    public static QuantityCode Credit => new() { Value = "B17" };

    /// <summary>
    /// joule second
    /// </summary>
    public static QuantityCode JouleSecond => new() { Value = "B18" };

    /// <summary>
    /// digit
    /// </summary>
    public static QuantityCode Digit => new() { Value = "B19" };

    /// <summary>
    /// joule square metre per kilogram
    /// </summary>
    public static QuantityCode JouleSquareMetrePerKilogram => new() { Value = "B20" };

    /// <summary>
    /// kelvin per watt
    /// </summary>
    public static QuantityCode KelvinPerWatt => new() { Value = "B21" };

    /// <summary>
    /// kiloampere
    /// </summary>
    public static QuantityCode Kiloampere => new() { Value = "B22" };

    /// <summary>
    /// kiloampere per square metre
    /// </summary>
    public static QuantityCode KiloamperePerSquareMetre => new() { Value = "B23" };

    /// <summary>
    /// kiloampere per metre
    /// </summary>
    public static QuantityCode KiloamperePerMetre => new() { Value = "B24" };

    /// <summary>
    /// kilobecquerel per kilogram
    /// </summary>
    public static QuantityCode KilobecquerelPerKilogram => new() { Value = "B25" };

    /// <summary>
    /// kilocoulomb
    /// </summary>
    public static QuantityCode Kilocoulomb => new() { Value = "B26" };

    /// <summary>
    /// kilocoulomb per cubic metre
    /// </summary>
    public static QuantityCode KilocoulombPerCubicMetre => new() { Value = "B27" };

    /// <summary>
    /// kilocoulomb per square metre
    /// </summary>
    public static QuantityCode KilocoulombPerSquareMetre => new() { Value = "B28" };

    /// <summary>
    /// kiloelectronvolt
    /// </summary>
    public static QuantityCode Kiloelectronvolt => new() { Value = "B29" };

    /// <summary>
    /// batting pound
    /// </summary>
    public static QuantityCode BattingPound => new() { Value = "B3" };

    /// <summary>
    /// gibibit
    /// </summary>
    public static QuantityCode Gibibit => new() { Value = "B30" };

    /// <summary>
    /// kilogram metre per second
    /// </summary>
    public static QuantityCode KilogramMetrePerSecond => new() { Value = "B31" };

    /// <summary>
    /// kilogram metre squared
    /// </summary>
    public static QuantityCode KilogramMetreSquared => new() { Value = "B32" };

    /// <summary>
    /// kilogram metre squared per second
    /// </summary>
    public static QuantityCode KilogramMetreSquaredPerSecond => new() { Value = "B33" };

    /// <summary>
    /// kilogram per cubic decimetre
    /// </summary>
    public static QuantityCode KilogramPerCubicDecimetre => new() { Value = "B34" };

    /// <summary>
    /// kilogram per litre
    /// </summary>
    public static QuantityCode KilogramPerLitre => new() { Value = "B35" };

    /// <summary>
    /// barrel, imperial
    /// </summary>
    public static QuantityCode BarrelImperial => new() { Value = "B4" };

    /// <summary>
    /// kilojoule per kelvin
    /// </summary>
    public static QuantityCode KilojoulePerKelvin => new() { Value = "B41" };

    /// <summary>
    /// kilojoule per kilogram
    /// </summary>
    public static QuantityCode KilojoulePerKilogram => new() { Value = "B42" };

    /// <summary>
    /// kilojoule per kilogram kelvin
    /// </summary>
    public static QuantityCode KilojoulePerKilogramKelvin => new() { Value = "B43" };

    /// <summary>
    /// kilojoule per mole
    /// </summary>
    public static QuantityCode KilojoulePerMole => new() { Value = "B44" };

    /// <summary>
    /// kilomole
    /// </summary>
    public static QuantityCode Kilomole => new() { Value = "B45" };

    /// <summary>
    /// kilomole per cubic metre
    /// </summary>
    public static QuantityCode KilomolePerCubicMetre => new() { Value = "B46" };

    /// <summary>
    /// kilonewton
    /// </summary>
    public static QuantityCode Kilonewton => new() { Value = "B47" };

    /// <summary>
    /// kilonewton metre
    /// </summary>
    public static QuantityCode KilonewtonMetre => new() { Value = "B48" };

    /// <summary>
    /// kiloohm
    /// </summary>
    public static QuantityCode Kiloohm => new() { Value = "B49" };

    /// <summary>
    /// kiloohm metre
    /// </summary>
    public static QuantityCode KiloohmMetre => new() { Value = "B50" };

    /// <summary>
    /// kilosecond
    /// </summary>
    public static QuantityCode Kilosecond => new() { Value = "B52" };

    /// <summary>
    /// kilosiemens
    /// </summary>
    public static QuantityCode Kilosiemens => new() { Value = "B53" };

    /// <summary>
    /// kilosiemens per metre
    /// </summary>
    public static QuantityCode KilosiemensPerMetre => new() { Value = "B54" };

    /// <summary>
    /// kilovolt per metre
    /// </summary>
    public static QuantityCode KilovoltPerMetre => new() { Value = "B55" };

    /// <summary>
    /// kiloweber per metre
    /// </summary>
    public static QuantityCode KiloweberPerMetre => new() { Value = "B56" };

    /// <summary>
    /// light year
    /// </summary>
    public static QuantityCode LightYear => new() { Value = "B57" };

    /// <summary>
    /// litre per mole
    /// </summary>
    public static QuantityCode LitrePerMole => new() { Value = "B58" };

    /// <summary>
    /// lumen hour
    /// </summary>
    public static QuantityCode LumenHour => new() { Value = "B59" };

    /// <summary>
    /// lumen per square metre
    /// </summary>
    public static QuantityCode LumenPerSquareMetre => new() { Value = "B60" };

    /// <summary>
    /// lumen per watt
    /// </summary>
    public static QuantityCode LumenPerWatt => new() { Value = "B61" };

    /// <summary>
    /// lumen second
    /// </summary>
    public static QuantityCode LumenSecond => new() { Value = "B62" };

    /// <summary>
    /// lux hour
    /// </summary>
    public static QuantityCode LuxHour => new() { Value = "B63" };

    /// <summary>
    /// lux second
    /// </summary>
    public static QuantityCode LuxSecond => new() { Value = "B64" };

    /// <summary>
    /// megaampere per square metre
    /// </summary>
    public static QuantityCode MegaamperePerSquareMetre => new() { Value = "B66" };

    /// <summary>
    /// megabecquerel per kilogram
    /// </summary>
    public static QuantityCode MegabecquerelPerKilogram => new() { Value = "B67" };

    /// <summary>
    /// gigabit
    /// </summary>
    public static QuantityCode Gigabit => new() { Value = "B68" };

    /// <summary>
    /// megacoulomb per cubic metre
    /// </summary>
    public static QuantityCode MegacoulombPerCubicMetre => new() { Value = "B69" };

    /// <summary>
    /// cycle
    /// </summary>
    public static QuantityCode Cycle => new() { Value = "B7" };

    /// <summary>
    /// megacoulomb per square metre
    /// </summary>
    public static QuantityCode MegacoulombPerSquareMetre => new() { Value = "B70" };

    /// <summary>
    /// megaelectronvolt
    /// </summary>
    public static QuantityCode Megaelectronvolt => new() { Value = "B71" };

    /// <summary>
    /// megagram per cubic metre
    /// </summary>
    public static QuantityCode MegagramPerCubicMetre => new() { Value = "B72" };

    /// <summary>
    /// meganewton
    /// </summary>
    public static QuantityCode Meganewton => new() { Value = "B73" };

    /// <summary>
    /// meganewton metre
    /// </summary>
    public static QuantityCode MeganewtonMetre => new() { Value = "B74" };

    /// <summary>
    /// megaohm
    /// </summary>
    public static QuantityCode Megaohm => new() { Value = "B75" };

    /// <summary>
    /// megaohm metre
    /// </summary>
    public static QuantityCode MegaohmMetre => new() { Value = "B76" };

    /// <summary>
    /// megasiemens per metre
    /// </summary>
    public static QuantityCode MegasiemensPerMetre => new() { Value = "B77" };

    /// <summary>
    /// megavolt
    /// </summary>
    public static QuantityCode Megavolt => new() { Value = "B78" };

    /// <summary>
    /// megavolt per metre
    /// </summary>
    public static QuantityCode MegavoltPerMetre => new() { Value = "B79" };

    /// <summary>
    /// joule per cubic metre
    /// </summary>
    public static QuantityCode JoulePerCubicMetre => new() { Value = "B8" };

    /// <summary>
    /// gigabit per second
    /// </summary>
    public static QuantityCode GigabitPerSecond => new() { Value = "B80" };

    /// <summary>
    /// reciprocal metre squared reciprocal second
    /// </summary>
    public static QuantityCode ReciprocalMetreSquaredReciprocalSecond => new() { Value = "B81" };

    /// <summary>
    /// inch per linear foot
    /// </summary>
    public static QuantityCode InchPerLinearFoot => new() { Value = "B82" };

    /// <summary>
    /// metre to the fourth power
    /// </summary>
    public static QuantityCode MetreToTheFourthPower => new() { Value = "B83" };

    /// <summary>
    /// microampere
    /// </summary>
    public static QuantityCode Microampere => new() { Value = "B84" };

    /// <summary>
    /// microbar
    /// </summary>
    public static QuantityCode Microbar => new() { Value = "B85" };

    /// <summary>
    /// microcoulomb
    /// </summary>
    public static QuantityCode Microcoulomb => new() { Value = "B86" };

    /// <summary>
    /// microcoulomb per cubic metre
    /// </summary>
    public static QuantityCode MicrocoulombPerCubicMetre => new() { Value = "B87" };

    /// <summary>
    /// microcoulomb per square metre
    /// </summary>
    public static QuantityCode MicrocoulombPerSquareMetre => new() { Value = "B88" };

    /// <summary>
    /// microfarad per metre
    /// </summary>
    public static QuantityCode MicrofaradPerMetre => new() { Value = "B89" };

    /// <summary>
    /// microhenry
    /// </summary>
    public static QuantityCode Microhenry => new() { Value = "B90" };

    /// <summary>
    /// microhenry per metre
    /// </summary>
    public static QuantityCode MicrohenryPerMetre => new() { Value = "B91" };

    /// <summary>
    /// micronewton
    /// </summary>
    public static QuantityCode Micronewton => new() { Value = "B92" };

    /// <summary>
    /// micronewton metre
    /// </summary>
    public static QuantityCode MicronewtonMetre => new() { Value = "B93" };

    /// <summary>
    /// microohm
    /// </summary>
    public static QuantityCode Microohm => new() { Value = "B94" };

    /// <summary>
    /// microohm metre
    /// </summary>
    public static QuantityCode MicroohmMetre => new() { Value = "B95" };

    /// <summary>
    /// micropascal
    /// </summary>
    public static QuantityCode Micropascal => new() { Value = "B96" };

    /// <summary>
    /// microradian
    /// </summary>
    public static QuantityCode Microradian => new() { Value = "B97" };

    /// <summary>
    /// microsecond
    /// </summary>
    public static QuantityCode Microsecond => new() { Value = "B98" };

    /// <summary>
    /// microsiemens
    /// </summary>
    public static QuantityCode Microsiemens => new() { Value = "B99" };

    /// <summary>
    /// bar [unit of pressure]
    /// </summary>
    public static QuantityCode BarUnitOfPressure => new() { Value = "BAR" };

    /// <summary>
    /// base box
    /// </summary>
    public static QuantityCode BaseBox => new() { Value = "BB" };

    /// <summary>
    /// board foot
    /// </summary>
    public static QuantityCode BoardFoot => new() { Value = "BFT" };

    /// <summary>
    /// brake horse power
    /// </summary>
    public static QuantityCode BrakeHorsePower => new() { Value = "BHP" };

    /// <summary>
    /// billion (EUR)
    /// </summary>
    public static QuantityCode BillionEUR => new() { Value = "BIL" };

    /// <summary>
    /// dry barrel (US)
    /// </summary>
    public static QuantityCode DryBarrelUS => new() { Value = "BLD" };

    /// <summary>
    /// barrel (US)
    /// </summary>
    public static QuantityCode BarrelUS => new() { Value = "BLL" };

    /// <summary>
    /// hundred board foot
    /// </summary>
    public static QuantityCode HundredBoardFoot => new() { Value = "BP" };

    /// <summary>
    /// beats per minute
    /// </summary>
    public static QuantityCode BeatsPerMinute => new() { Value = "BPM" };

    /// <summary>
    /// becquerel
    /// </summary>
    public static QuantityCode Becquerel => new() { Value = "BQL" };

    /// <summary>
    /// British thermal unit (international table)
    /// </summary>
    public static QuantityCode BritishThermalUnitInternationalTable => new() { Value = "BTU" };

    /// <summary>
    /// bushel (US)
    /// </summary>
    public static QuantityCode BushelUS => new() { Value = "BUA" };

    /// <summary>
    /// bushel (UK)
    /// </summary>
    public static QuantityCode BushelUK => new() { Value = "BUI" };

    /// <summary>
    /// call
    /// </summary>
    public static QuantityCode Call => new() { Value = "C0" };

    /// <summary>
    /// millifarad
    /// </summary>
    public static QuantityCode Millifarad => new() { Value = "C10" };

    /// <summary>
    /// milligal
    /// </summary>
    public static QuantityCode Milligal => new() { Value = "C11" };

    /// <summary>
    /// milligram per metre
    /// </summary>
    public static QuantityCode MilligramPerMetre => new() { Value = "C12" };

    /// <summary>
    /// milligray
    /// </summary>
    public static QuantityCode Milligray => new() { Value = "C13" };

    /// <summary>
    /// millihenry
    /// </summary>
    public static QuantityCode Millihenry => new() { Value = "C14" };

    /// <summary>
    /// millijoule
    /// </summary>
    public static QuantityCode Millijoule => new() { Value = "C15" };

    /// <summary>
    /// millimetre per second
    /// </summary>
    public static QuantityCode MillimetrePerSecond => new() { Value = "C16" };

    /// <summary>
    /// millimetre squared per second
    /// </summary>
    public static QuantityCode MillimetreSquaredPerSecond => new() { Value = "C17" };

    /// <summary>
    /// millimole
    /// </summary>
    public static QuantityCode Millimole => new() { Value = "C18" };

    /// <summary>
    /// mole per kilogram
    /// </summary>
    public static QuantityCode MolePerKilogram => new() { Value = "C19" };

    /// <summary>
    /// millinewton
    /// </summary>
    public static QuantityCode Millinewton => new() { Value = "C20" };

    /// <summary>
    /// kibibit
    /// </summary>
    public static QuantityCode Kibibit => new() { Value = "C21" };

    /// <summary>
    /// millinewton per metre
    /// </summary>
    public static QuantityCode MillinewtonPerMetre => new() { Value = "C22" };

    /// <summary>
    /// milliohm metre
    /// </summary>
    public static QuantityCode MilliohmMetre => new() { Value = "C23" };

    /// <summary>
    /// millipascal second
    /// </summary>
    public static QuantityCode MillipascalSecond => new() { Value = "C24" };

    /// <summary>
    /// milliradian
    /// </summary>
    public static QuantityCode Milliradian => new() { Value = "C25" };

    /// <summary>
    /// millisecond
    /// </summary>
    public static QuantityCode Millisecond => new() { Value = "C26" };

    /// <summary>
    /// millisiemens
    /// </summary>
    public static QuantityCode Millisiemens => new() { Value = "C27" };

    /// <summary>
    /// millisievert
    /// </summary>
    public static QuantityCode Millisievert => new() { Value = "C28" };

    /// <summary>
    /// millitesla
    /// </summary>
    public static QuantityCode Millitesla => new() { Value = "C29" };

    /// <summary>
    /// microvolt per metre
    /// </summary>
    public static QuantityCode MicrovoltPerMetre => new() { Value = "C3" };

    /// <summary>
    /// millivolt per metre
    /// </summary>
    public static QuantityCode MillivoltPerMetre => new() { Value = "C30" };

    /// <summary>
    /// milliwatt
    /// </summary>
    public static QuantityCode Milliwatt => new() { Value = "C31" };

    /// <summary>
    /// milliwatt per square metre
    /// </summary>
    public static QuantityCode MilliwattPerSquareMetre => new() { Value = "C32" };

    /// <summary>
    /// milliweber
    /// </summary>
    public static QuantityCode Milliweber => new() { Value = "C33" };

    /// <summary>
    /// mole
    /// </summary>
    public static QuantityCode Mole => new() { Value = "C34" };

    /// <summary>
    /// mole per cubic decimetre
    /// </summary>
    public static QuantityCode MolePerCubicDecimetre => new() { Value = "C35" };

    /// <summary>
    /// mole per cubic metre
    /// </summary>
    public static QuantityCode MolePerCubicMetre => new() { Value = "C36" };

    /// <summary>
    /// kilobit
    /// </summary>
    public static QuantityCode Kilobit => new() { Value = "C37" };

    /// <summary>
    /// mole per litre
    /// </summary>
    public static QuantityCode MolePerLitre => new() { Value = "C38" };

    /// <summary>
    /// nanoampere
    /// </summary>
    public static QuantityCode Nanoampere => new() { Value = "C39" };

    /// <summary>
    /// nanocoulomb
    /// </summary>
    public static QuantityCode Nanocoulomb => new() { Value = "C40" };

    /// <summary>
    /// nanofarad
    /// </summary>
    public static QuantityCode Nanofarad => new() { Value = "C41" };

    /// <summary>
    /// nanofarad per metre
    /// </summary>
    public static QuantityCode NanofaradPerMetre => new() { Value = "C42" };

    /// <summary>
    /// nanohenry
    /// </summary>
    public static QuantityCode Nanohenry => new() { Value = "C43" };

    /// <summary>
    /// nanohenry per metre
    /// </summary>
    public static QuantityCode NanohenryPerMetre => new() { Value = "C44" };

    /// <summary>
    /// nanometre
    /// </summary>
    public static QuantityCode Nanometre => new() { Value = "C45" };

    /// <summary>
    /// nanoohm metre
    /// </summary>
    public static QuantityCode NanoohmMetre => new() { Value = "C46" };

    /// <summary>
    /// nanosecond
    /// </summary>
    public static QuantityCode Nanosecond => new() { Value = "C47" };

    /// <summary>
    /// nanotesla
    /// </summary>
    public static QuantityCode Nanotesla => new() { Value = "C48" };

    /// <summary>
    /// nanowatt
    /// </summary>
    public static QuantityCode Nanowatt => new() { Value = "C49" };

    /// <summary>
    /// neper
    /// </summary>
    public static QuantityCode Neper => new() { Value = "C50" };

    /// <summary>
    /// neper per second
    /// </summary>
    public static QuantityCode NeperPerSecond => new() { Value = "C51" };

    /// <summary>
    /// picometre
    /// </summary>
    public static QuantityCode Picometre => new() { Value = "C52" };

    /// <summary>
    /// newton metre second
    /// </summary>
    public static QuantityCode NewtonMetreSecond => new() { Value = "C53" };

    /// <summary>
    /// newton metre squared per kilogram squared
    /// </summary>
    public static QuantityCode NewtonMetreSquaredPerKilogramSquared => new() { Value = "C54" };

    /// <summary>
    /// newton per square metre
    /// </summary>
    public static QuantityCode NewtonPerSquareMetre => new() { Value = "C55" };

    /// <summary>
    /// newton per square millimetre
    /// </summary>
    public static QuantityCode NewtonPerSquareMillimetre => new() { Value = "C56" };

    /// <summary>
    /// newton second
    /// </summary>
    public static QuantityCode NewtonSecond => new() { Value = "C57" };

    /// <summary>
    /// newton second per metre
    /// </summary>
    public static QuantityCode NewtonSecondPerMetre => new() { Value = "C58" };

    /// <summary>
    /// octave
    /// </summary>
    public static QuantityCode Octave => new() { Value = "C59" };

    /// <summary>
    /// ohm centimetre
    /// </summary>
    public static QuantityCode OhmCentimetre => new() { Value = "C60" };

    /// <summary>
    /// ohm metre
    /// </summary>
    public static QuantityCode OhmMetre => new() { Value = "C61" };

    /// <summary>
    /// one
    /// </summary>
    public static QuantityCode One => new() { Value = "C62" };

    /// <summary>
    /// parsec
    /// </summary>
    public static QuantityCode Parsec => new() { Value = "C63" };

    /// <summary>
    /// pascal per kelvin
    /// </summary>
    public static QuantityCode PascalPerKelvin => new() { Value = "C64" };

    /// <summary>
    /// pascal second
    /// </summary>
    public static QuantityCode PascalSecond => new() { Value = "C65" };

    /// <summary>
    /// pascal second per cubic metre
    /// </summary>
    public static QuantityCode PascalSecondPerCubicMetre => new() { Value = "C66" };

    /// <summary>
    /// pascal second per metre
    /// </summary>
    public static QuantityCode PascalSecondPerMetre => new() { Value = "C67" };

    /// <summary>
    /// petajoule
    /// </summary>
    public static QuantityCode Petajoule => new() { Value = "C68" };

    /// <summary>
    /// phon
    /// </summary>
    public static QuantityCode Phon => new() { Value = "C69" };

    /// <summary>
    /// centipoise
    /// </summary>
    public static QuantityCode Centipoise => new() { Value = "C7" };

    /// <summary>
    /// picoampere
    /// </summary>
    public static QuantityCode Picoampere => new() { Value = "C70" };

    /// <summary>
    /// picocoulomb
    /// </summary>
    public static QuantityCode Picocoulomb => new() { Value = "C71" };

    /// <summary>
    /// picofarad per metre
    /// </summary>
    public static QuantityCode PicofaradPerMetre => new() { Value = "C72" };

    /// <summary>
    /// picohenry
    /// </summary>
    public static QuantityCode Picohenry => new() { Value = "C73" };

    /// <summary>
    /// kilobit per second
    /// </summary>
    public static QuantityCode KilobitPerSecond => new() { Value = "C74" };

    /// <summary>
    /// picowatt
    /// </summary>
    public static QuantityCode Picowatt => new() { Value = "C75" };

    /// <summary>
    /// picowatt per square metre
    /// </summary>
    public static QuantityCode PicowattPerSquareMetre => new() { Value = "C76" };

    /// <summary>
    /// pound-force
    /// </summary>
    public static QuantityCode PoundForce => new() { Value = "C78" };

    /// <summary>
    /// kilovolt ampere hour
    /// </summary>
    public static QuantityCode KilovoltAmpereHour => new() { Value = "C79" };

    /// <summary>
    /// millicoulomb per kilogram
    /// </summary>
    public static QuantityCode MillicoulombPerKilogram => new() { Value = "C8" };

    /// <summary>
    /// rad
    /// </summary>
    public static QuantityCode Rad => new() { Value = "C80" };

    /// <summary>
    /// radian
    /// </summary>
    public static QuantityCode Radian => new() { Value = "C81" };

    /// <summary>
    /// radian square metre per mole
    /// </summary>
    public static QuantityCode RadianSquareMetrePerMole => new() { Value = "C82" };

    /// <summary>
    /// radian square metre per kilogram
    /// </summary>
    public static QuantityCode RadianSquareMetrePerKilogram => new() { Value = "C83" };

    /// <summary>
    /// radian per metre
    /// </summary>
    public static QuantityCode RadianPerMetre => new() { Value = "C84" };

    /// <summary>
    /// reciprocal angstrom
    /// </summary>
    public static QuantityCode ReciprocalAngstrom => new() { Value = "C85" };

    /// <summary>
    /// reciprocal cubic metre
    /// </summary>
    public static QuantityCode ReciprocalCubicMetre => new() { Value = "C86" };

    /// <summary>
    /// reciprocal cubic metre per second
    /// </summary>
    public static QuantityCode ReciprocalCubicMetrePerSecond => new() { Value = "C87" };

    /// <summary>
    /// reciprocal electron volt per cubic metre
    /// </summary>
    public static QuantityCode ReciprocalElectronVoltPerCubicMetre => new() { Value = "C88" };

    /// <summary>
    /// reciprocal henry
    /// </summary>
    public static QuantityCode ReciprocalHenry => new() { Value = "C89" };

    /// <summary>
    /// coil group
    /// </summary>
    public static QuantityCode CoilGroup => new() { Value = "C9" };

    /// <summary>
    /// reciprocal joule per cubic metre
    /// </summary>
    public static QuantityCode ReciprocalJoulePerCubicMetre => new() { Value = "C90" };

    /// <summary>
    /// reciprocal kelvin or kelvin to the power minus one
    /// </summary>
    public static QuantityCode ReciprocalKelvinOrKelvinToThePowerMinusOne => new() { Value = "C91" };

    /// <summary>
    /// reciprocal metre
    /// </summary>
    public static QuantityCode ReciprocalMetre => new() { Value = "C92" };

    /// <summary>
    /// reciprocal square metre
    /// </summary>
    public static QuantityCode ReciprocalSquareMetre => new() { Value = "C93" };

    /// <summary>
    /// reciprocal minute
    /// </summary>
    public static QuantityCode ReciprocalMinute => new() { Value = "C94" };

    /// <summary>
    /// reciprocal mole
    /// </summary>
    public static QuantityCode ReciprocalMole => new() { Value = "C95" };

    /// <summary>
    /// reciprocal pascal or pascal to the power minus one
    /// </summary>
    public static QuantityCode ReciprocalPascalOrPascalToThePowerMinusOne => new() { Value = "C96" };

    /// <summary>
    /// reciprocal second
    /// </summary>
    public static QuantityCode ReciprocalSecond => new() { Value = "C97" };

    /// <summary>
    /// reciprocal second per metre squared
    /// </summary>
    public static QuantityCode ReciprocalSecondPerMetreSquared => new() { Value = "C99" };

    /// <summary>
    /// carrying capacity in metric ton
    /// </summary>
    public static QuantityCode CarryingCapacityInMetricTon => new() { Value = "CCT" };

    /// <summary>
    /// candela
    /// </summary>
    public static QuantityCode Candela => new() { Value = "CDL" };

    /// <summary>
    /// degree Celsius
    /// </summary>
    public static QuantityCode DegreeCelsius => new() { Value = "CEL" };

    /// <summary>
    /// hundred
    /// </summary>
    public static QuantityCode Hundred => new() { Value = "CEN" };

    /// <summary>
    /// card
    /// </summary>
    public static QuantityCode Card => new() { Value = "CG" };

    /// <summary>
    /// centigram
    /// </summary>
    public static QuantityCode Centigram => new() { Value = "CGM" };

    /// <summary>
    /// coulomb per kilogram
    /// </summary>
    public static QuantityCode CoulombPerKilogram => new() { Value = "CKG" };

    /// <summary>
    /// hundred leave
    /// </summary>
    public static QuantityCode HundredLeave => new() { Value = "CLF" };

    /// <summary>
    /// centilitre
    /// </summary>
    public static QuantityCode Centilitre => new() { Value = "CLT" };

    /// <summary>
    /// square centimetre
    /// </summary>
    public static QuantityCode SquareCentimetre => new() { Value = "CMK" };

    /// <summary>
    /// cubic centimetre
    /// </summary>
    public static QuantityCode CubicCentimetre => new() { Value = "CMQ" };

    /// <summary>
    /// centimetre
    /// </summary>
    public static QuantityCode Centimetre => new() { Value = "CMT" };

    /// <summary>
    /// hundred pack
    /// </summary>
    public static QuantityCode HundredPack => new() { Value = "CNP" };

    /// <summary>
    /// cental (UK)
    /// </summary>
    public static QuantityCode CentalUK => new() { Value = "CNT" };

    /// <summary>
    /// coulomb
    /// </summary>
    public static QuantityCode Coulomb => new() { Value = "COU" };

    /// <summary>
    /// content gram
    /// </summary>
    public static QuantityCode ContentGram => new() { Value = "CTG" };

    /// <summary>
    /// metric carat
    /// </summary>
    public static QuantityCode MetricCarat => new() { Value = "CTM" };

    /// <summary>
    /// content ton (metric)
    /// </summary>
    public static QuantityCode ContentTonMetric => new() { Value = "CTN" };

    /// <summary>
    /// curie
    /// </summary>
    public static QuantityCode Curie => new() { Value = "CUR" };

    /// <summary>
    /// hundred pound (cwt) / hundred weight (US)
    /// </summary>
    public static QuantityCode HundredPoundCwtHundredWeightUS => new() { Value = "CWA" };

    /// <summary>
    /// hundred weight (UK)
    /// </summary>
    public static QuantityCode HundredWeightUK => new() { Value = "CWI" };

    /// <summary>
    /// kilowatt hour per hour
    /// </summary>
    public static QuantityCode KilowattHourPerHour => new() { Value = "D03" };

    /// <summary>
    /// lot [unit of weight]
    /// </summary>
    public static QuantityCode LotUnitOfWeight => new() { Value = "D04" };

    /// <summary>
    /// reciprocal second per steradian
    /// </summary>
    public static QuantityCode ReciprocalSecondPerSteradian => new() { Value = "D1" };

    /// <summary>
    /// siemens per metre
    /// </summary>
    public static QuantityCode SiemensPerMetre => new() { Value = "D10" };

    /// <summary>
    /// mebibit
    /// </summary>
    public static QuantityCode Mebibit => new() { Value = "D11" };

    /// <summary>
    /// siemens square metre per mole
    /// </summary>
    public static QuantityCode SiemensSquareMetrePerMole => new() { Value = "D12" };

    /// <summary>
    /// sievert
    /// </summary>
    public static QuantityCode Sievert => new() { Value = "D13" };

    /// <summary>
    /// sone
    /// </summary>
    public static QuantityCode Sone => new() { Value = "D15" };

    /// <summary>
    /// square centimetre per erg
    /// </summary>
    public static QuantityCode SquareCentimetrePerErg => new() { Value = "D16" };

    /// <summary>
    /// square centimetre per steradian erg
    /// </summary>
    public static QuantityCode SquareCentimetrePerSteradianErg => new() { Value = "D17" };

    /// <summary>
    /// metre kelvin
    /// </summary>
    public static QuantityCode MetreKelvin => new() { Value = "D18" };

    /// <summary>
    /// square metre kelvin per watt
    /// </summary>
    public static QuantityCode SquareMetreKelvinPerWatt => new() { Value = "D19" };

    /// <summary>
    /// reciprocal second per steradian metre squared
    /// </summary>
    public static QuantityCode ReciprocalSecondPerSteradianMetreSquared => new() { Value = "D2" };

    /// <summary>
    /// square metre per joule
    /// </summary>
    public static QuantityCode SquareMetrePerJoule => new() { Value = "D20" };

    /// <summary>
    /// square metre per kilogram
    /// </summary>
    public static QuantityCode SquareMetrePerKilogram => new() { Value = "D21" };

    /// <summary>
    /// square metre per mole
    /// </summary>
    public static QuantityCode SquareMetrePerMole => new() { Value = "D22" };

    /// <summary>
    /// pen gram (protein)
    /// </summary>
    public static QuantityCode PenGramProtein => new() { Value = "D23" };

    /// <summary>
    /// square metre per steradian
    /// </summary>
    public static QuantityCode SquareMetrePerSteradian => new() { Value = "D24" };

    /// <summary>
    /// square metre per steradian joule
    /// </summary>
    public static QuantityCode SquareMetrePerSteradianJoule => new() { Value = "D25" };

    /// <summary>
    /// square metre per volt second
    /// </summary>
    public static QuantityCode SquareMetrePerVoltSecond => new() { Value = "D26" };

    /// <summary>
    /// steradian
    /// </summary>
    public static QuantityCode Steradian => new() { Value = "D27" };

    /// <summary>
    /// terahertz
    /// </summary>
    public static QuantityCode Terahertz => new() { Value = "D29" };

    /// <summary>
    /// terajoule
    /// </summary>
    public static QuantityCode Terajoule => new() { Value = "D30" };

    /// <summary>
    /// terawatt
    /// </summary>
    public static QuantityCode Terawatt => new() { Value = "D31" };

    /// <summary>
    /// terawatt hour
    /// </summary>
    public static QuantityCode TerawattHour => new() { Value = "D32" };

    /// <summary>
    /// tesla
    /// </summary>
    public static QuantityCode Tesla => new() { Value = "D33" };

    /// <summary>
    /// tex
    /// </summary>
    public static QuantityCode Tex => new() { Value = "D34" };

    /// <summary>
    /// megabit
    /// </summary>
    public static QuantityCode Megabit => new() { Value = "D36" };

    /// <summary>
    /// tonne per cubic metre
    /// </summary>
    public static QuantityCode TonnePerCubicMetre => new() { Value = "D41" };

    /// <summary>
    /// tropical year
    /// </summary>
    public static QuantityCode TropicalYear => new() { Value = "D42" };

    /// <summary>
    /// unified atomic mass unit
    /// </summary>
    public static QuantityCode UnifiedAtomicMassUnit => new() { Value = "D43" };

    /// <summary>
    /// var
    /// </summary>
    public static QuantityCode Var => new() { Value = "D44" };

    /// <summary>
    /// volt squared per kelvin squared
    /// </summary>
    public static QuantityCode VoltSquaredPerKelvinSquared => new() { Value = "D45" };

    /// <summary>
    /// volt - ampere
    /// </summary>
    public static QuantityCode VoltAmpere => new() { Value = "D46" };

    /// <summary>
    /// volt per centimetre
    /// </summary>
    public static QuantityCode VoltPerCentimetre => new() { Value = "D47" };

    /// <summary>
    /// volt per kelvin
    /// </summary>
    public static QuantityCode VoltPerKelvin => new() { Value = "D48" };

    /// <summary>
    /// millivolt per kelvin
    /// </summary>
    public static QuantityCode MillivoltPerKelvin => new() { Value = "D49" };

    /// <summary>
    /// kilogram per square centimetre
    /// </summary>
    public static QuantityCode KilogramPerSquareCentimetre => new() { Value = "D5" };

    /// <summary>
    /// volt per metre
    /// </summary>
    public static QuantityCode VoltPerMetre => new() { Value = "D50" };

    /// <summary>
    /// volt per millimetre
    /// </summary>
    public static QuantityCode VoltPerMillimetre => new() { Value = "D51" };

    /// <summary>
    /// watt per kelvin
    /// </summary>
    public static QuantityCode WattPerKelvin => new() { Value = "D52" };

    /// <summary>
    /// watt per metre kelvin
    /// </summary>
    public static QuantityCode WattPerMetreKelvin => new() { Value = "D53" };

    /// <summary>
    /// watt per square metre
    /// </summary>
    public static QuantityCode WattPerSquareMetre => new() { Value = "D54" };

    /// <summary>
    /// watt per square metre kelvin
    /// </summary>
    public static QuantityCode WattPerSquareMetreKelvin => new() { Value = "D55" };

    /// <summary>
    /// watt per square metre kelvin to the fourth power
    /// </summary>
    public static QuantityCode WattPerSquareMetreKelvinToTheFourthPower => new() { Value = "D56" };

    /// <summary>
    /// watt per steradian
    /// </summary>
    public static QuantityCode WattPerSteradian => new() { Value = "D57" };

    /// <summary>
    /// watt per steradian square metre
    /// </summary>
    public static QuantityCode WattPerSteradianSquareMetre => new() { Value = "D58" };

    /// <summary>
    /// weber per metre
    /// </summary>
    public static QuantityCode WeberPerMetre => new() { Value = "D59" };

    /// <summary>
    /// roentgen per second
    /// </summary>
    public static QuantityCode RoentgenPerSecond => new() { Value = "D6" };

    /// <summary>
    /// weber per millimetre
    /// </summary>
    public static QuantityCode WeberPerMillimetre => new() { Value = "D60" };

    /// <summary>
    /// minute [unit of angle]
    /// </summary>
    public static QuantityCode MinuteUnitOfAngle => new() { Value = "D61" };

    /// <summary>
    /// second [unit of angle]
    /// </summary>
    public static QuantityCode SecondUnitOfAngle => new() { Value = "D62" };

    /// <summary>
    /// book
    /// </summary>
    public static QuantityCode Book => new() { Value = "D63" };

    /// <summary>
    /// round
    /// </summary>
    public static QuantityCode Round => new() { Value = "D65" };

    /// <summary>
    /// number of words
    /// </summary>
    public static QuantityCode NumberOfWords => new() { Value = "D68" };

    /// <summary>
    /// inch to the fourth power
    /// </summary>
    public static QuantityCode InchToTheFourthPower => new() { Value = "D69" };

    /// <summary>
    /// joule square metre
    /// </summary>
    public static QuantityCode JouleSquareMetre => new() { Value = "D73" };

    /// <summary>
    /// kilogram per mole
    /// </summary>
    public static QuantityCode KilogramPerMole => new() { Value = "D74" };

    /// <summary>
    /// megacoulomb
    /// </summary>
    public static QuantityCode Megacoulomb => new() { Value = "D77" };

    /// <summary>
    /// megajoule per second
    /// </summary>
    public static QuantityCode MegajoulePerSecond => new() { Value = "D78" };

    /// <summary>
    /// microwatt
    /// </summary>
    public static QuantityCode Microwatt => new() { Value = "D80" };

    /// <summary>
    /// microtesla
    /// </summary>
    public static QuantityCode Microtesla => new() { Value = "D81" };

    /// <summary>
    /// microvolt
    /// </summary>
    public static QuantityCode Microvolt => new() { Value = "D82" };

    /// <summary>
    /// millinewton metre
    /// </summary>
    public static QuantityCode MillinewtonMetre => new() { Value = "D83" };

    /// <summary>
    /// microwatt per square metre
    /// </summary>
    public static QuantityCode MicrowattPerSquareMetre => new() { Value = "D85" };

    /// <summary>
    /// millicoulomb
    /// </summary>
    public static QuantityCode Millicoulomb => new() { Value = "D86" };

    /// <summary>
    /// millimole per kilogram
    /// </summary>
    public static QuantityCode MillimolePerKilogram => new() { Value = "D87" };

    /// <summary>
    /// millicoulomb per cubic metre
    /// </summary>
    public static QuantityCode MillicoulombPerCubicMetre => new() { Value = "D88" };

    /// <summary>
    /// millicoulomb per square metre
    /// </summary>
    public static QuantityCode MillicoulombPerSquareMetre => new() { Value = "D89" };

    /// <summary>
    /// rem
    /// </summary>
    public static QuantityCode Rem => new() { Value = "D91" };

    /// <summary>
    /// second per cubic metre
    /// </summary>
    public static QuantityCode SecondPerCubicMetre => new() { Value = "D93" };

    /// <summary>
    /// second per cubic metre radian
    /// </summary>
    public static QuantityCode SecondPerCubicMetreRadian => new() { Value = "D94" };

    /// <summary>
    /// joule per gram
    /// </summary>
    public static QuantityCode JoulePerGram => new() { Value = "D95" };

    /// <summary>
    /// decare
    /// </summary>
    public static QuantityCode Decare => new() { Value = "DAA" };

    /// <summary>
    /// ten day
    /// </summary>
    public static QuantityCode TenDay => new() { Value = "DAD" };

    /// <summary>
    /// day
    /// </summary>
    public static QuantityCode Day => new() { Value = "DAY" };

    /// <summary>
    /// dry pound
    /// </summary>
    public static QuantityCode DryPound => new() { Value = "DB" };

    /// <summary>
    /// Decibel-milliwatts
    /// </summary>
    public static QuantityCode DecibelMilliwatts => new() { Value = "DBM" };

    /// <summary>
    /// Decibel watt
    /// </summary>
    public static QuantityCode DecibelWatt => new() { Value = "DBW" };

    /// <summary>
    /// degree [unit of angle]
    /// </summary>
    public static QuantityCode DegreeUnitOfAngle => new() { Value = "DD" };

    /// <summary>
    /// decade
    /// </summary>
    public static QuantityCode Decade => new() { Value = "DEC" };

    /// <summary>
    /// decigram
    /// </summary>
    public static QuantityCode Decigram => new() { Value = "DG" };

    /// <summary>
    /// decagram
    /// </summary>
    public static QuantityCode Decagram => new() { Value = "DJ" };

    /// <summary>
    /// decilitre
    /// </summary>
    public static QuantityCode Decilitre => new() { Value = "DLT" };

    /// <summary>
    /// cubic decametre
    /// </summary>
    public static QuantityCode CubicDecametre => new() { Value = "DMA" };

    /// <summary>
    /// square decimetre
    /// </summary>
    public static QuantityCode SquareDecimetre => new() { Value = "DMK" };

    /// <summary>
    /// standard kilolitre
    /// </summary>
    public static QuantityCode StandardKilolitre => new() { Value = "DMO" };

    /// <summary>
    /// cubic decimetre
    /// </summary>
    public static QuantityCode CubicDecimetre => new() { Value = "DMQ" };

    /// <summary>
    /// decimetre
    /// </summary>
    public static QuantityCode Decimetre => new() { Value = "DMT" };

    /// <summary>
    /// decinewton metre
    /// </summary>
    public static QuantityCode DecinewtonMetre => new() { Value = "DN" };

    /// <summary>
    /// dozen piece
    /// </summary>
    public static QuantityCode DozenPiece => new() { Value = "DPC" };

    /// <summary>
    /// dozen pair
    /// </summary>
    public static QuantityCode DozenPair => new() { Value = "DPR" };

    /// <summary>
    /// displacement tonnage
    /// </summary>
    public static QuantityCode DisplacementTonnage => new() { Value = "DPT" };

    /// <summary>
    /// dram (US)
    /// </summary>
    public static QuantityCode DramUS => new() { Value = "DRA" };

    /// <summary>
    /// dram (UK)
    /// </summary>
    public static QuantityCode DramUK => new() { Value = "DRI" };

    /// <summary>
    /// dozen roll
    /// </summary>
    public static QuantityCode DozenRoll => new() { Value = "DRL" };

    /// <summary>
    /// dry ton
    /// </summary>
    public static QuantityCode DryTon => new() { Value = "DT" };

    /// <summary>
    /// decitonne
    /// </summary>
    public static QuantityCode Decitonne => new() { Value = "DTN" };

    /// <summary>
    /// pennyweight
    /// </summary>
    public static QuantityCode Pennyweight => new() { Value = "DWT" };

    /// <summary>
    /// dozen
    /// </summary>
    public static QuantityCode Dozen => new() { Value = "DZN" };

    /// <summary>
    /// dozen pack
    /// </summary>
    public static QuantityCode DozenPack => new() { Value = "DZP" };

    /// <summary>
    /// newton per square centimetre
    /// </summary>
    public static QuantityCode NewtonPerSquareCentimetre => new() { Value = "E01" };

    /// <summary>
    /// megawatt hour per hour
    /// </summary>
    public static QuantityCode MegawattHourPerHour => new() { Value = "E07" };

    /// <summary>
    /// megawatt per hertz
    /// </summary>
    public static QuantityCode MegawattPerHertz => new() { Value = "E08" };

    /// <summary>
    /// milliampere hour
    /// </summary>
    public static QuantityCode MilliampereHour => new() { Value = "E09" };

    /// <summary>
    /// degree day
    /// </summary>
    public static QuantityCode DegreeDay => new() { Value = "E10" };

    /// <summary>
    /// mille
    /// </summary>
    public static QuantityCode Mille => new() { Value = "E12" };

    /// <summary>
    /// kilocalorie (international table)
    /// </summary>
    public static QuantityCode KilocalorieInternationalTable => new() { Value = "E14" };

    /// <summary>
    /// kilocalorie (thermochemical) per hour
    /// </summary>
    public static QuantityCode KilocalorieThermochemicalPerHour => new() { Value = "E15" };

    /// <summary>
    /// million Btu(IT) per hour
    /// </summary>
    public static QuantityCode MillionBtuITPerHour => new() { Value = "E16" };

    /// <summary>
    /// cubic foot per second
    /// </summary>
    public static QuantityCode CubicFootPerSecond => new() { Value = "E17" };

    /// <summary>
    /// tonne per hour
    /// </summary>
    public static QuantityCode TonnePerHour => new() { Value = "E18" };

    /// <summary>
    /// ping
    /// </summary>
    public static QuantityCode Ping => new() { Value = "E19" };

    /// <summary>
    /// megabit per second
    /// </summary>
    public static QuantityCode MegabitPerSecond => new() { Value = "E20" };

    /// <summary>
    /// shares
    /// </summary>
    public static QuantityCode Shares => new() { Value = "E21" };

    /// <summary>
    /// TEU
    /// </summary>
    public static QuantityCode TEU => new() { Value = "E22" };

    /// <summary>
    /// tyre
    /// </summary>
    public static QuantityCode Tyre => new() { Value = "E23" };

    /// <summary>
    /// active unit
    /// </summary>
    public static QuantityCode ActiveUnit => new() { Value = "E25" };

    /// <summary>
    /// dose
    /// </summary>
    public static QuantityCode Dose => new() { Value = "E27" };

    /// <summary>
    /// air dry ton
    /// </summary>
    public static QuantityCode AirDryTon => new() { Value = "E28" };

    /// <summary>
    /// strand
    /// </summary>
    public static QuantityCode Strand => new() { Value = "E30" };

    /// <summary>
    /// square metre per litre
    /// </summary>
    public static QuantityCode SquareMetrePerLitre => new() { Value = "E31" };

    /// <summary>
    /// litre per hour
    /// </summary>
    public static QuantityCode LitrePerHour => new() { Value = "E32" };

    /// <summary>
    /// foot per thousand
    /// </summary>
    public static QuantityCode FootPerThousand => new() { Value = "E33" };

    /// <summary>
    /// gigabyte
    /// </summary>
    public static QuantityCode Gigabyte => new() { Value = "E34" };

    /// <summary>
    /// terabyte
    /// </summary>
    public static QuantityCode Terabyte => new() { Value = "E35" };

    /// <summary>
    /// petabyte
    /// </summary>
    public static QuantityCode Petabyte => new() { Value = "E36" };

    /// <summary>
    /// pixel
    /// </summary>
    public static QuantityCode Pixel => new() { Value = "E37" };

    /// <summary>
    /// megapixel
    /// </summary>
    public static QuantityCode Megapixel => new() { Value = "E38" };

    /// <summary>
    /// dots per inch
    /// </summary>
    public static QuantityCode DotsPerInch => new() { Value = "E39" };

    /// <summary>
    /// gross kilogram
    /// </summary>
    public static QuantityCode GrossKilogram => new() { Value = "E4" };

    /// <summary>
    /// part per hundred thousand
    /// </summary>
    public static QuantityCode PartPerHundredThousand => new() { Value = "E40" };

    /// <summary>
    /// kilogram-force per square millimetre
    /// </summary>
    public static QuantityCode KilogramForcePerSquareMillimetre => new() { Value = "E41" };

    /// <summary>
    /// kilogram-force per square centimetre
    /// </summary>
    public static QuantityCode KilogramForcePerSquareCentimetre => new() { Value = "E42" };

    /// <summary>
    /// joule per square centimetre
    /// </summary>
    public static QuantityCode JoulePerSquareCentimetre => new() { Value = "E43" };

    /// <summary>
    /// kilogram-force metre per square centimetre
    /// </summary>
    public static QuantityCode KilogramForceMetrePerSquareCentimetre => new() { Value = "E44" };

    /// <summary>
    /// milliohm
    /// </summary>
    public static QuantityCode Milliohm => new() { Value = "E45" };

    /// <summary>
    /// kilowatt hour per cubic metre
    /// </summary>
    public static QuantityCode KilowattHourPerCubicMetre => new() { Value = "E46" };

    /// <summary>
    /// kilowatt hour per kelvin
    /// </summary>
    public static QuantityCode KilowattHourPerKelvin => new() { Value = "E47" };

    /// <summary>
    /// service unit
    /// </summary>
    public static QuantityCode ServiceUnit => new() { Value = "E48" };

    /// <summary>
    /// working day
    /// </summary>
    public static QuantityCode WorkingDay => new() { Value = "E49" };

    /// <summary>
    /// accounting unit
    /// </summary>
    public static QuantityCode AccountingUnit => new() { Value = "E50" };

    /// <summary>
    /// job
    /// </summary>
    public static QuantityCode Job => new() { Value = "E51" };

    /// <summary>
    /// run foot
    /// </summary>
    public static QuantityCode RunFoot => new() { Value = "E52" };

    /// <summary>
    /// test
    /// </summary>
    public static QuantityCode Test => new() { Value = "E53" };

    /// <summary>
    /// trip
    /// </summary>
    public static QuantityCode Trip => new() { Value = "E54" };

    /// <summary>
    /// use
    /// </summary>
    public static QuantityCode Use => new() { Value = "E55" };

    /// <summary>
    /// well
    /// </summary>
    public static QuantityCode Well => new() { Value = "E56" };

    /// <summary>
    /// zone
    /// </summary>
    public static QuantityCode Zone => new() { Value = "E57" };

    /// <summary>
    /// exabit per second
    /// </summary>
    public static QuantityCode ExabitPerSecond => new() { Value = "E58" };

    /// <summary>
    /// exbibyte
    /// </summary>
    public static QuantityCode Exbibyte => new() { Value = "E59" };

    /// <summary>
    /// pebibyte
    /// </summary>
    public static QuantityCode Pebibyte => new() { Value = "E60" };

    /// <summary>
    /// tebibyte
    /// </summary>
    public static QuantityCode Tebibyte => new() { Value = "E61" };

    /// <summary>
    /// gibibyte
    /// </summary>
    public static QuantityCode Gibibyte => new() { Value = "E62" };

    /// <summary>
    /// mebibyte
    /// </summary>
    public static QuantityCode Mebibyte => new() { Value = "E63" };

    /// <summary>
    /// kibibyte
    /// </summary>
    public static QuantityCode Kibibyte => new() { Value = "E64" };

    /// <summary>
    /// exbibit per metre
    /// </summary>
    public static QuantityCode ExbibitPerMetre => new() { Value = "E65" };

    /// <summary>
    /// exbibit per square metre
    /// </summary>
    public static QuantityCode ExbibitPerSquareMetre => new() { Value = "E66" };

    /// <summary>
    /// exbibit per cubic metre
    /// </summary>
    public static QuantityCode ExbibitPerCubicMetre => new() { Value = "E67" };

    /// <summary>
    /// gigabyte per second
    /// </summary>
    public static QuantityCode GigabytePerSecond => new() { Value = "E68" };

    /// <summary>
    /// gibibit per metre
    /// </summary>
    public static QuantityCode GibibitPerMetre => new() { Value = "E69" };

    /// <summary>
    /// gibibit per square metre
    /// </summary>
    public static QuantityCode GibibitPerSquareMetre => new() { Value = "E70" };

    /// <summary>
    /// gibibit per cubic metre
    /// </summary>
    public static QuantityCode GibibitPerCubicMetre => new() { Value = "E71" };

    /// <summary>
    /// kibibit per metre
    /// </summary>
    public static QuantityCode KibibitPerMetre => new() { Value = "E72" };

    /// <summary>
    /// kibibit per square metre
    /// </summary>
    public static QuantityCode KibibitPerSquareMetre => new() { Value = "E73" };

    /// <summary>
    /// kibibit per cubic metre
    /// </summary>
    public static QuantityCode KibibitPerCubicMetre => new() { Value = "E74" };

    /// <summary>
    /// mebibit per metre
    /// </summary>
    public static QuantityCode MebibitPerMetre => new() { Value = "E75" };

    /// <summary>
    /// mebibit per square metre
    /// </summary>
    public static QuantityCode MebibitPerSquareMetre => new() { Value = "E76" };

    /// <summary>
    /// mebibit per cubic metre
    /// </summary>
    public static QuantityCode MebibitPerCubicMetre => new() { Value = "E77" };

    /// <summary>
    /// petabit
    /// </summary>
    public static QuantityCode Petabit => new() { Value = "E78" };

    /// <summary>
    /// petabit per second
    /// </summary>
    public static QuantityCode PetabitPerSecond => new() { Value = "E79" };

    /// <summary>
    /// pebibit per metre
    /// </summary>
    public static QuantityCode PebibitPerMetre => new() { Value = "E80" };

    /// <summary>
    /// pebibit per square metre
    /// </summary>
    public static QuantityCode PebibitPerSquareMetre => new() { Value = "E81" };

    /// <summary>
    /// pebibit per cubic metre
    /// </summary>
    public static QuantityCode PebibitPerCubicMetre => new() { Value = "E82" };

    /// <summary>
    /// terabit
    /// </summary>
    public static QuantityCode Terabit => new() { Value = "E83" };

    /// <summary>
    /// terabit per second
    /// </summary>
    public static QuantityCode TerabitPerSecond => new() { Value = "E84" };

    /// <summary>
    /// tebibit per metre
    /// </summary>
    public static QuantityCode TebibitPerMetre => new() { Value = "E85" };

    /// <summary>
    /// tebibit per cubic metre
    /// </summary>
    public static QuantityCode TebibitPerCubicMetre => new() { Value = "E86" };

    /// <summary>
    /// tebibit per square metre
    /// </summary>
    public static QuantityCode TebibitPerSquareMetre => new() { Value = "E87" };

    /// <summary>
    /// bit per metre
    /// </summary>
    public static QuantityCode BitPerMetre => new() { Value = "E88" };

    /// <summary>
    /// bit per square metre
    /// </summary>
    public static QuantityCode BitPerSquareMetre => new() { Value = "E89" };

    /// <summary>
    /// reciprocal centimetre
    /// </summary>
    public static QuantityCode ReciprocalCentimetre => new() { Value = "E90" };

    /// <summary>
    /// reciprocal day
    /// </summary>
    public static QuantityCode ReciprocalDay => new() { Value = "E91" };

    /// <summary>
    /// cubic decimetre per hour
    /// </summary>
    public static QuantityCode CubicDecimetrePerHour => new() { Value = "E92" };

    /// <summary>
    /// kilogram per hour
    /// </summary>
    public static QuantityCode KilogramPerHour => new() { Value = "E93" };

    /// <summary>
    /// kilomole per second
    /// </summary>
    public static QuantityCode KilomolePerSecond => new() { Value = "E94" };

    /// <summary>
    /// mole per second
    /// </summary>
    public static QuantityCode MolePerSecond => new() { Value = "E95" };

    /// <summary>
    /// degree per second
    /// </summary>
    public static QuantityCode DegreePerSecond => new() { Value = "E96" };

    /// <summary>
    /// millimetre per degree Celcius metre
    /// </summary>
    public static QuantityCode MillimetrePerDegreeCelciusMetre => new() { Value = "E97" };

    /// <summary>
    /// degree Celsius per kelvin
    /// </summary>
    public static QuantityCode DegreeCelsiusPerKelvin => new() { Value = "E98" };

    /// <summary>
    /// hectopascal per bar
    /// </summary>
    public static QuantityCode HectopascalPerBar => new() { Value = "E99" };

    /// <summary>
    /// each
    /// </summary>
    public static QuantityCode Each => new() { Value = "EA" };

    /// <summary>
    /// electronic mail box
    /// </summary>
    public static QuantityCode ElectronicMailBox => new() { Value = "EB" };

    /// <summary>
    /// equivalent gallon
    /// </summary>
    public static QuantityCode EquivalentGallon => new() { Value = "EQ" };

    /// <summary>
    /// bit per cubic metre
    /// </summary>
    public static QuantityCode BitPerCubicMetre => new() { Value = "F01" };

    /// <summary>
    /// kelvin per kelvin
    /// </summary>
    public static QuantityCode KelvinPerKelvin => new() { Value = "F02" };

    /// <summary>
    /// kilopascal per bar
    /// </summary>
    public static QuantityCode KilopascalPerBar => new() { Value = "F03" };

    /// <summary>
    /// millibar per bar
    /// </summary>
    public static QuantityCode MillibarPerBar => new() { Value = "F04" };

    /// <summary>
    /// megapascal per bar
    /// </summary>
    public static QuantityCode MegapascalPerBar => new() { Value = "F05" };

    /// <summary>
    /// poise per bar
    /// </summary>
    public static QuantityCode PoisePerBar => new() { Value = "F06" };

    /// <summary>
    /// pascal per bar
    /// </summary>
    public static QuantityCode PascalPerBar => new() { Value = "F07" };

    /// <summary>
    /// milliampere per inch
    /// </summary>
    public static QuantityCode MilliamperePerInch => new() { Value = "F08" };

    /// <summary>
    /// kelvin per hour
    /// </summary>
    public static QuantityCode KelvinPerHour => new() { Value = "F10" };

    /// <summary>
    /// kelvin per minute
    /// </summary>
    public static QuantityCode KelvinPerMinute => new() { Value = "F11" };

    /// <summary>
    /// kelvin per second
    /// </summary>
    public static QuantityCode KelvinPerSecond => new() { Value = "F12" };

    /// <summary>
    /// slug
    /// </summary>
    public static QuantityCode Slug => new() { Value = "F13" };

    /// <summary>
    /// gram per kelvin
    /// </summary>
    public static QuantityCode GramPerKelvin => new() { Value = "F14" };

    /// <summary>
    /// kilogram per kelvin
    /// </summary>
    public static QuantityCode KilogramPerKelvin => new() { Value = "F15" };

    /// <summary>
    /// milligram per kelvin
    /// </summary>
    public static QuantityCode MilligramPerKelvin => new() { Value = "F16" };

    /// <summary>
    /// pound-force per foot
    /// </summary>
    public static QuantityCode PoundForcePerFoot => new() { Value = "F17" };

    /// <summary>
    /// kilogram square centimetre
    /// </summary>
    public static QuantityCode KilogramSquareCentimetre => new() { Value = "F18" };

    /// <summary>
    /// kilogram square millimetre
    /// </summary>
    public static QuantityCode KilogramSquareMillimetre => new() { Value = "F19" };

    /// <summary>
    /// pound inch squared
    /// </summary>
    public static QuantityCode PoundInchSquared => new() { Value = "F20" };

    /// <summary>
    /// pound-force inch
    /// </summary>
    public static QuantityCode PoundForceInch => new() { Value = "F21" };

    /// <summary>
    /// pound-force foot per ampere
    /// </summary>
    public static QuantityCode PoundForceFootPerAmpere => new() { Value = "F22" };

    /// <summary>
    /// gram per cubic decimetre
    /// </summary>
    public static QuantityCode GramPerCubicDecimetre => new() { Value = "F23" };

    /// <summary>
    /// kilogram per kilomol
    /// </summary>
    public static QuantityCode KilogramPerKilomol => new() { Value = "F24" };

    /// <summary>
    /// gram per hertz
    /// </summary>
    public static QuantityCode GramPerHertz => new() { Value = "F25" };

    /// <summary>
    /// gram per day
    /// </summary>
    public static QuantityCode GramPerDay => new() { Value = "F26" };

    /// <summary>
    /// gram per hour
    /// </summary>
    public static QuantityCode GramPerHour => new() { Value = "F27" };

    /// <summary>
    /// gram per minute
    /// </summary>
    public static QuantityCode GramPerMinute => new() { Value = "F28" };

    /// <summary>
    /// gram per second
    /// </summary>
    public static QuantityCode GramPerSecond => new() { Value = "F29" };

    /// <summary>
    /// kilogram per day
    /// </summary>
    public static QuantityCode KilogramPerDay => new() { Value = "F30" };

    /// <summary>
    /// kilogram per minute
    /// </summary>
    public static QuantityCode KilogramPerMinute => new() { Value = "F31" };

    /// <summary>
    /// milligram per day
    /// </summary>
    public static QuantityCode MilligramPerDay => new() { Value = "F32" };

    /// <summary>
    /// milligram per minute
    /// </summary>
    public static QuantityCode MilligramPerMinute => new() { Value = "F33" };

    /// <summary>
    /// milligram per second
    /// </summary>
    public static QuantityCode MilligramPerSecond => new() { Value = "F34" };

    /// <summary>
    /// gram per day kelvin
    /// </summary>
    public static QuantityCode GramPerDayKelvin => new() { Value = "F35" };

    /// <summary>
    /// gram per hour kelvin
    /// </summary>
    public static QuantityCode GramPerHourKelvin => new() { Value = "F36" };

    /// <summary>
    /// gram per minute kelvin
    /// </summary>
    public static QuantityCode GramPerMinuteKelvin => new() { Value = "F37" };

    /// <summary>
    /// gram per second kelvin
    /// </summary>
    public static QuantityCode GramPerSecondKelvin => new() { Value = "F38" };

    /// <summary>
    /// kilogram per day kelvin
    /// </summary>
    public static QuantityCode KilogramPerDayKelvin => new() { Value = "F39" };

    /// <summary>
    /// kilogram per hour kelvin
    /// </summary>
    public static QuantityCode KilogramPerHourKelvin => new() { Value = "F40" };

    /// <summary>
    /// kilogram per minute kelvin
    /// </summary>
    public static QuantityCode KilogramPerMinuteKelvin => new() { Value = "F41" };

    /// <summary>
    /// kilogram per second kelvin
    /// </summary>
    public static QuantityCode KilogramPerSecondKelvin => new() { Value = "F42" };

    /// <summary>
    /// milligram per day kelvin
    /// </summary>
    public static QuantityCode MilligramPerDayKelvin => new() { Value = "F43" };

    /// <summary>
    /// milligram per hour kelvin
    /// </summary>
    public static QuantityCode MilligramPerHourKelvin => new() { Value = "F44" };

    /// <summary>
    /// milligram per minute kelvin
    /// </summary>
    public static QuantityCode MilligramPerMinuteKelvin => new() { Value = "F45" };

    /// <summary>
    /// milligram per second kelvin
    /// </summary>
    public static QuantityCode MilligramPerSecondKelvin => new() { Value = "F46" };

    /// <summary>
    /// newton per millimetre
    /// </summary>
    public static QuantityCode NewtonPerMillimetre => new() { Value = "F47" };

    /// <summary>
    /// pound-force per inch
    /// </summary>
    public static QuantityCode PoundForcePerInch => new() { Value = "F48" };

    /// <summary>
    /// rod [unit of distance]
    /// </summary>
    public static QuantityCode RodUnitOfDistance => new() { Value = "F49" };

    /// <summary>
    /// micrometre per kelvin
    /// </summary>
    public static QuantityCode MicrometrePerKelvin => new() { Value = "F50" };

    /// <summary>
    /// centimetre per kelvin
    /// </summary>
    public static QuantityCode CentimetrePerKelvin => new() { Value = "F51" };

    /// <summary>
    /// metre per kelvin
    /// </summary>
    public static QuantityCode MetrePerKelvin => new() { Value = "F52" };

    /// <summary>
    /// millimetre per kelvin
    /// </summary>
    public static QuantityCode MillimetrePerKelvin => new() { Value = "F53" };

    /// <summary>
    /// milliohm per metre
    /// </summary>
    public static QuantityCode MilliohmPerMetre => new() { Value = "F54" };

    /// <summary>
    /// ohm per mile (statute mile)
    /// </summary>
    public static QuantityCode OhmPerMileStatuteMile => new() { Value = "F55" };

    /// <summary>
    /// ohm per kilometre
    /// </summary>
    public static QuantityCode OhmPerKilometre => new() { Value = "F56" };

    /// <summary>
    /// milliampere per pound-force per square inch
    /// </summary>
    public static QuantityCode MilliamperePerPoundForcePerSquareInch => new() { Value = "F57" };

    /// <summary>
    /// reciprocal bar
    /// </summary>
    public static QuantityCode ReciprocalBar => new() { Value = "F58" };

    /// <summary>
    /// milliampere per bar
    /// </summary>
    public static QuantityCode MilliamperePerBar => new() { Value = "F59" };

    /// <summary>
    /// degree Celsius per bar
    /// </summary>
    public static QuantityCode DegreeCelsiusPerBar => new() { Value = "F60" };

    /// <summary>
    /// kelvin per bar
    /// </summary>
    public static QuantityCode KelvinPerBar => new() { Value = "F61" };

    /// <summary>
    /// gram per day bar
    /// </summary>
    public static QuantityCode GramPerDayBar => new() { Value = "F62" };

    /// <summary>
    /// gram per hour bar
    /// </summary>
    public static QuantityCode GramPerHourBar => new() { Value = "F63" };

    /// <summary>
    /// gram per minute bar
    /// </summary>
    public static QuantityCode GramPerMinuteBar => new() { Value = "F64" };

    /// <summary>
    /// gram per second bar
    /// </summary>
    public static QuantityCode GramPerSecondBar => new() { Value = "F65" };

    /// <summary>
    /// kilogram per day bar
    /// </summary>
    public static QuantityCode KilogramPerDayBar => new() { Value = "F66" };

    /// <summary>
    /// kilogram per hour bar
    /// </summary>
    public static QuantityCode KilogramPerHourBar => new() { Value = "F67" };

    /// <summary>
    /// kilogram per minute bar
    /// </summary>
    public static QuantityCode KilogramPerMinuteBar => new() { Value = "F68" };

    /// <summary>
    /// kilogram per second bar
    /// </summary>
    public static QuantityCode KilogramPerSecondBar => new() { Value = "F69" };

    /// <summary>
    /// milligram per day bar
    /// </summary>
    public static QuantityCode MilligramPerDayBar => new() { Value = "F70" };

    /// <summary>
    /// milligram per hour bar
    /// </summary>
    public static QuantityCode MilligramPerHourBar => new() { Value = "F71" };

    /// <summary>
    /// milligram per minute bar
    /// </summary>
    public static QuantityCode MilligramPerMinuteBar => new() { Value = "F72" };

    /// <summary>
    /// milligram per second bar
    /// </summary>
    public static QuantityCode MilligramPerSecondBar => new() { Value = "F73" };

    /// <summary>
    /// gram per bar
    /// </summary>
    public static QuantityCode GramPerBar => new() { Value = "F74" };

    /// <summary>
    /// milligram per bar
    /// </summary>
    public static QuantityCode MilligramPerBar => new() { Value = "F75" };

    /// <summary>
    /// milliampere per millimetre
    /// </summary>
    public static QuantityCode MilliamperePerMillimetre => new() { Value = "F76" };

    /// <summary>
    /// pascal second per kelvin
    /// </summary>
    public static QuantityCode PascalSecondPerKelvin => new() { Value = "F77" };

    /// <summary>
    /// inch of water
    /// </summary>
    public static QuantityCode InchOfWater => new() { Value = "F78" };

    /// <summary>
    /// inch of mercury
    /// </summary>
    public static QuantityCode InchOfMercury => new() { Value = "F79" };

    /// <summary>
    /// water horse power
    /// </summary>
    public static QuantityCode WaterHorsePower => new() { Value = "F80" };

    /// <summary>
    /// bar per kelvin
    /// </summary>
    public static QuantityCode BarPerKelvin => new() { Value = "F81" };

    /// <summary>
    /// hectopascal per kelvin
    /// </summary>
    public static QuantityCode HectopascalPerKelvin => new() { Value = "F82" };

    /// <summary>
    /// kilopascal per kelvin
    /// </summary>
    public static QuantityCode KilopascalPerKelvin => new() { Value = "F83" };

    /// <summary>
    /// millibar per kelvin
    /// </summary>
    public static QuantityCode MillibarPerKelvin => new() { Value = "F84" };

    /// <summary>
    /// megapascal per kelvin
    /// </summary>
    public static QuantityCode MegapascalPerKelvin => new() { Value = "F85" };

    /// <summary>
    /// poise per kelvin
    /// </summary>
    public static QuantityCode PoisePerKelvin => new() { Value = "F86" };

    /// <summary>
    /// volt per litre minute
    /// </summary>
    public static QuantityCode VoltPerLitreMinute => new() { Value = "F87" };

    /// <summary>
    /// newton centimetre
    /// </summary>
    public static QuantityCode NewtonCentimetre => new() { Value = "F88" };

    /// <summary>
    /// newton metre per degree
    /// </summary>
    public static QuantityCode NewtonMetrePerDegree => new() { Value = "F89" };

    /// <summary>
    /// newton metre per ampere
    /// </summary>
    public static QuantityCode NewtonMetrePerAmpere => new() { Value = "F90" };

    /// <summary>
    /// bar litre per second
    /// </summary>
    public static QuantityCode BarLitrePerSecond => new() { Value = "F91" };

    /// <summary>
    /// bar cubic metre per second
    /// </summary>
    public static QuantityCode BarCubicMetrePerSecond => new() { Value = "F92" };

    /// <summary>
    /// hectopascal litre per second
    /// </summary>
    public static QuantityCode HectopascalLitrePerSecond => new() { Value = "F93" };

    /// <summary>
    /// hectopascal cubic metre per second
    /// </summary>
    public static QuantityCode HectopascalCubicMetrePerSecond => new() { Value = "F94" };

    /// <summary>
    /// millibar litre per second
    /// </summary>
    public static QuantityCode MillibarLitrePerSecond => new() { Value = "F95" };

    /// <summary>
    /// millibar cubic metre per second
    /// </summary>
    public static QuantityCode MillibarCubicMetrePerSecond => new() { Value = "F96" };

    /// <summary>
    /// megapascal litre per second
    /// </summary>
    public static QuantityCode MegapascalLitrePerSecond => new() { Value = "F97" };

    /// <summary>
    /// megapascal cubic metre per second
    /// </summary>
    public static QuantityCode MegapascalCubicMetrePerSecond => new() { Value = "F98" };

    /// <summary>
    /// pascal litre per second
    /// </summary>
    public static QuantityCode PascalLitrePerSecond => new() { Value = "F99" };

    /// <summary>
    /// degree Fahrenheit
    /// </summary>
    public static QuantityCode DegreeFahrenheit => new() { Value = "FAH" };

    /// <summary>
    /// farad
    /// </summary>
    public static QuantityCode Farad => new() { Value = "FAR" };

    /// <summary>
    /// fibre metre
    /// </summary>
    public static QuantityCode FibreMetre => new() { Value = "FBM" };

    /// <summary>
    /// thousand cubic foot
    /// </summary>
    public static QuantityCode ThousandCubicFoot => new() { Value = "FC" };

    /// <summary>
    /// hundred cubic metre
    /// </summary>
    public static QuantityCode HundredCubicMetre => new() { Value = "FF" };

    /// <summary>
    /// micromole
    /// </summary>
    public static QuantityCode Micromole => new() { Value = "FH" };

    /// <summary>
    /// failures in time
    /// </summary>
    public static QuantityCode FailuresInTime => new() { Value = "FIT" };

    /// <summary>
    /// flake ton
    /// </summary>
    public static QuantityCode FlakeTon => new() { Value = "FL" };

    /// <summary>
    /// Formazin nephelometric unit
    /// </summary>
    public static QuantityCode FormazinNephelometricUnit => new() { Value = "FNU" };

    /// <summary>
    /// foot
    /// </summary>
    public static QuantityCode Foot => new() { Value = "FOT" };

    /// <summary>
    /// pound per square foot
    /// </summary>
    public static QuantityCode PoundPerSquareFoot => new() { Value = "FP" };

    /// <summary>
    /// foot per minute
    /// </summary>
    public static QuantityCode FootPerMinute => new() { Value = "FR" };

    /// <summary>
    /// foot per second
    /// </summary>
    public static QuantityCode FootPerSecond => new() { Value = "FS" };

    /// <summary>
    /// square foot
    /// </summary>
    public static QuantityCode SquareFoot => new() { Value = "FTK" };

    /// <summary>
    /// cubic foot
    /// </summary>
    public static QuantityCode CubicFoot => new() { Value = "FTQ" };

    /// <summary>
    /// pascal cubic metre per second
    /// </summary>
    public static QuantityCode PascalCubicMetrePerSecond => new() { Value = "G01" };

    /// <summary>
    /// centimetre per bar
    /// </summary>
    public static QuantityCode CentimetrePerBar => new() { Value = "G04" };

    /// <summary>
    /// metre per bar
    /// </summary>
    public static QuantityCode MetrePerBar => new() { Value = "G05" };

    /// <summary>
    /// millimetre per bar
    /// </summary>
    public static QuantityCode MillimetrePerBar => new() { Value = "G06" };

    /// <summary>
    /// square inch per second
    /// </summary>
    public static QuantityCode SquareInchPerSecond => new() { Value = "G08" };

    /// <summary>
    /// square metre per second kelvin
    /// </summary>
    public static QuantityCode SquareMetrePerSecondKelvin => new() { Value = "G09" };

    /// <summary>
    /// stokes per kelvin
    /// </summary>
    public static QuantityCode StokesPerKelvin => new() { Value = "G10" };

    /// <summary>
    /// gram per cubic centimetre bar
    /// </summary>
    public static QuantityCode GramPerCubicCentimetreBar => new() { Value = "G11" };

    /// <summary>
    /// gram per cubic decimetre bar
    /// </summary>
    public static QuantityCode GramPerCubicDecimetreBar => new() { Value = "G12" };

    /// <summary>
    /// gram per litre bar
    /// </summary>
    public static QuantityCode GramPerLitreBar => new() { Value = "G13" };

    /// <summary>
    /// gram per cubic metre bar
    /// </summary>
    public static QuantityCode GramPerCubicMetreBar => new() { Value = "G14" };

    /// <summary>
    /// gram per millilitre bar
    /// </summary>
    public static QuantityCode GramPerMillilitreBar => new() { Value = "G15" };

    /// <summary>
    /// kilogram per cubic centimetre bar
    /// </summary>
    public static QuantityCode KilogramPerCubicCentimetreBar => new() { Value = "G16" };

    /// <summary>
    /// kilogram per litre bar
    /// </summary>
    public static QuantityCode KilogramPerLitreBar => new() { Value = "G17" };

    /// <summary>
    /// kilogram per cubic metre bar
    /// </summary>
    public static QuantityCode KilogramPerCubicMetreBar => new() { Value = "G18" };

    /// <summary>
    /// newton metre per kilogram
    /// </summary>
    public static QuantityCode NewtonMetrePerKilogram => new() { Value = "G19" };

    /// <summary>
    /// US gallon per minute
    /// </summary>
    public static QuantityCode USGallonPerMinute => new() { Value = "G2" };

    /// <summary>
    /// pound-force foot per pound
    /// </summary>
    public static QuantityCode PoundForceFootPerPound => new() { Value = "G20" };

    /// <summary>
    /// cup [unit of volume]
    /// </summary>
    public static QuantityCode CupUnitOfVolume => new() { Value = "G21" };

    /// <summary>
    /// peck
    /// </summary>
    public static QuantityCode Peck => new() { Value = "G23" };

    /// <summary>
    /// tablespoon (US)
    /// </summary>
    public static QuantityCode TablespoonUS => new() { Value = "G24" };

    /// <summary>
    /// teaspoon (US)
    /// </summary>
    public static QuantityCode TeaspoonUS => new() { Value = "G25" };

    /// <summary>
    /// stere
    /// </summary>
    public static QuantityCode Stere => new() { Value = "G26" };

    /// <summary>
    /// cubic centimetre per kelvin
    /// </summary>
    public static QuantityCode CubicCentimetrePerKelvin => new() { Value = "G27" };

    /// <summary>
    /// litre per kelvin
    /// </summary>
    public static QuantityCode LitrePerKelvin => new() { Value = "G28" };

    /// <summary>
    /// cubic metre per kelvin
    /// </summary>
    public static QuantityCode CubicMetrePerKelvin => new() { Value = "G29" };

    /// <summary>
    /// Imperial gallon per minute
    /// </summary>
    public static QuantityCode ImperialGallonPerMinute => new() { Value = "G3" };

    /// <summary>
    /// millilitre per kelvin
    /// </summary>
    public static QuantityCode MillilitrePerKelvin => new() { Value = "G30" };

    /// <summary>
    /// kilogram per cubic centimetre
    /// </summary>
    public static QuantityCode KilogramPerCubicCentimetre => new() { Value = "G31" };

    /// <summary>
    /// ounce (avoirdupois) per cubic yard
    /// </summary>
    public static QuantityCode OunceAvoirdupoisPerCubicYard => new() { Value = "G32" };

    /// <summary>
    /// gram per cubic centimetre kelvin
    /// </summary>
    public static QuantityCode GramPerCubicCentimetreKelvin => new() { Value = "G33" };

    /// <summary>
    /// gram per cubic decimetre kelvin
    /// </summary>
    public static QuantityCode GramPerCubicDecimetreKelvin => new() { Value = "G34" };

    /// <summary>
    /// gram per litre kelvin
    /// </summary>
    public static QuantityCode GramPerLitreKelvin => new() { Value = "G35" };

    /// <summary>
    /// gram per cubic metre kelvin
    /// </summary>
    public static QuantityCode GramPerCubicMetreKelvin => new() { Value = "G36" };

    /// <summary>
    /// gram per millilitre kelvin
    /// </summary>
    public static QuantityCode GramPerMillilitreKelvin => new() { Value = "G37" };

    /// <summary>
    /// kilogram per cubic centimetre kelvin
    /// </summary>
    public static QuantityCode KilogramPerCubicCentimetreKelvin => new() { Value = "G38" };

    /// <summary>
    /// kilogram per litre kelvin
    /// </summary>
    public static QuantityCode KilogramPerLitreKelvin => new() { Value = "G39" };

    /// <summary>
    /// kilogram per cubic metre kelvin
    /// </summary>
    public static QuantityCode KilogramPerCubicMetreKelvin => new() { Value = "G40" };

    /// <summary>
    /// square metre per second bar
    /// </summary>
    public static QuantityCode SquareMetrePerSecondBar => new() { Value = "G41" };

    /// <summary>
    /// microsiemens per centimetre
    /// </summary>
    public static QuantityCode MicrosiemensPerCentimetre => new() { Value = "G42" };

    /// <summary>
    /// microsiemens per metre
    /// </summary>
    public static QuantityCode MicrosiemensPerMetre => new() { Value = "G43" };

    /// <summary>
    /// nanosiemens per centimetre
    /// </summary>
    public static QuantityCode NanosiemensPerCentimetre => new() { Value = "G44" };

    /// <summary>
    /// nanosiemens per metre
    /// </summary>
    public static QuantityCode NanosiemensPerMetre => new() { Value = "G45" };

    /// <summary>
    /// stokes per bar
    /// </summary>
    public static QuantityCode StokesPerBar => new() { Value = "G46" };

    /// <summary>
    /// cubic centimetre per day
    /// </summary>
    public static QuantityCode CubicCentimetrePerDay => new() { Value = "G47" };

    /// <summary>
    /// cubic centimetre per hour
    /// </summary>
    public static QuantityCode CubicCentimetrePerHour => new() { Value = "G48" };

    /// <summary>
    /// cubic centimetre per minute
    /// </summary>
    public static QuantityCode CubicCentimetrePerMinute => new() { Value = "G49" };

    /// <summary>
    /// gallon (US) per hour
    /// </summary>
    public static QuantityCode GallonUSPerHour => new() { Value = "G50" };

    /// <summary>
    /// litre per second
    /// </summary>
    public static QuantityCode LitrePerSecond => new() { Value = "G51" };

    /// <summary>
    /// cubic metre per day
    /// </summary>
    public static QuantityCode CubicMetrePerDay => new() { Value = "G52" };

    /// <summary>
    /// cubic metre per minute
    /// </summary>
    public static QuantityCode CubicMetrePerMinute => new() { Value = "G53" };

    /// <summary>
    /// millilitre per day
    /// </summary>
    public static QuantityCode MillilitrePerDay => new() { Value = "G54" };

    /// <summary>
    /// millilitre per hour
    /// </summary>
    public static QuantityCode MillilitrePerHour => new() { Value = "G55" };

    /// <summary>
    /// cubic inch per hour
    /// </summary>
    public static QuantityCode CubicInchPerHour => new() { Value = "G56" };

    /// <summary>
    /// cubic inch per minute
    /// </summary>
    public static QuantityCode CubicInchPerMinute => new() { Value = "G57" };

    /// <summary>
    /// cubic inch per second
    /// </summary>
    public static QuantityCode CubicInchPerSecond => new() { Value = "G58" };

    /// <summary>
    /// milliampere per litre minute
    /// </summary>
    public static QuantityCode MilliamperePerLitreMinute => new() { Value = "G59" };

    /// <summary>
    /// volt per bar
    /// </summary>
    public static QuantityCode VoltPerBar => new() { Value = "G60" };

    /// <summary>
    /// cubic centimetre per day kelvin
    /// </summary>
    public static QuantityCode CubicCentimetrePerDayKelvin => new() { Value = "G61" };

    /// <summary>
    /// cubic centimetre per hour kelvin
    /// </summary>
    public static QuantityCode CubicCentimetrePerHourKelvin => new() { Value = "G62" };

    /// <summary>
    /// cubic centimetre per minute kelvin
    /// </summary>
    public static QuantityCode CubicCentimetrePerMinuteKelvin => new() { Value = "G63" };

    /// <summary>
    /// cubic centimetre per second kelvin
    /// </summary>
    public static QuantityCode CubicCentimetrePerSecondKelvin => new() { Value = "G64" };

    /// <summary>
    /// litre per day kelvin
    /// </summary>
    public static QuantityCode LitrePerDayKelvin => new() { Value = "G65" };

    /// <summary>
    /// litre per hour kelvin
    /// </summary>
    public static QuantityCode LitrePerHourKelvin => new() { Value = "G66" };

    /// <summary>
    /// litre per minute kelvin
    /// </summary>
    public static QuantityCode LitrePerMinuteKelvin => new() { Value = "G67" };

    /// <summary>
    /// litre per second kelvin
    /// </summary>
    public static QuantityCode LitrePerSecondKelvin => new() { Value = "G68" };

    /// <summary>
    /// cubic metre per day kelvin
    /// </summary>
    public static QuantityCode CubicMetrePerDayKelvin => new() { Value = "G69" };

    /// <summary>
    /// cubic metre per hour kelvin
    /// </summary>
    public static QuantityCode CubicMetrePerHourKelvin => new() { Value = "G70" };

    /// <summary>
    /// cubic metre per minute kelvin
    /// </summary>
    public static QuantityCode CubicMetrePerMinuteKelvin => new() { Value = "G71" };

    /// <summary>
    /// cubic metre per second kelvin
    /// </summary>
    public static QuantityCode CubicMetrePerSecondKelvin => new() { Value = "G72" };

    /// <summary>
    /// millilitre per day kelvin
    /// </summary>
    public static QuantityCode MillilitrePerDayKelvin => new() { Value = "G73" };

    /// <summary>
    /// millilitre per hour kelvin
    /// </summary>
    public static QuantityCode MillilitrePerHourKelvin => new() { Value = "G74" };

    /// <summary>
    /// millilitre per minute kelvin
    /// </summary>
    public static QuantityCode MillilitrePerMinuteKelvin => new() { Value = "G75" };

    /// <summary>
    /// millilitre per second kelvin
    /// </summary>
    public static QuantityCode MillilitrePerSecondKelvin => new() { Value = "G76" };

    /// <summary>
    /// millimetre to the fourth power
    /// </summary>
    public static QuantityCode MillimetreToTheFourthPower => new() { Value = "G77" };

    /// <summary>
    /// cubic centimetre per day bar
    /// </summary>
    public static QuantityCode CubicCentimetrePerDayBar => new() { Value = "G78" };

    /// <summary>
    /// cubic centimetre per hour bar
    /// </summary>
    public static QuantityCode CubicCentimetrePerHourBar => new() { Value = "G79" };

    /// <summary>
    /// cubic centimetre per minute bar
    /// </summary>
    public static QuantityCode CubicCentimetrePerMinuteBar => new() { Value = "G80" };

    /// <summary>
    /// cubic centimetre per second bar
    /// </summary>
    public static QuantityCode CubicCentimetrePerSecondBar => new() { Value = "G81" };

    /// <summary>
    /// litre per day bar
    /// </summary>
    public static QuantityCode LitrePerDayBar => new() { Value = "G82" };

    /// <summary>
    /// litre per hour bar
    /// </summary>
    public static QuantityCode LitrePerHourBar => new() { Value = "G83" };

    /// <summary>
    /// litre per minute bar
    /// </summary>
    public static QuantityCode LitrePerMinuteBar => new() { Value = "G84" };

    /// <summary>
    /// litre per second bar
    /// </summary>
    public static QuantityCode LitrePerSecondBar => new() { Value = "G85" };

    /// <summary>
    /// cubic metre per day bar
    /// </summary>
    public static QuantityCode CubicMetrePerDayBar => new() { Value = "G86" };

    /// <summary>
    /// cubic metre per hour bar
    /// </summary>
    public static QuantityCode CubicMetrePerHourBar => new() { Value = "G87" };

    /// <summary>
    /// cubic metre per minute bar
    /// </summary>
    public static QuantityCode CubicMetrePerMinuteBar => new() { Value = "G88" };

    /// <summary>
    /// cubic metre per second bar
    /// </summary>
    public static QuantityCode CubicMetrePerSecondBar => new() { Value = "G89" };

    /// <summary>
    /// millilitre per day bar
    /// </summary>
    public static QuantityCode MillilitrePerDayBar => new() { Value = "G90" };

    /// <summary>
    /// millilitre per hour bar
    /// </summary>
    public static QuantityCode MillilitrePerHourBar => new() { Value = "G91" };

    /// <summary>
    /// millilitre per minute bar
    /// </summary>
    public static QuantityCode MillilitrePerMinuteBar => new() { Value = "G92" };

    /// <summary>
    /// millilitre per second bar
    /// </summary>
    public static QuantityCode MillilitrePerSecondBar => new() { Value = "G93" };

    /// <summary>
    /// cubic centimetre per bar
    /// </summary>
    public static QuantityCode CubicCentimetrePerBar => new() { Value = "G94" };

    /// <summary>
    /// litre per bar
    /// </summary>
    public static QuantityCode LitrePerBar => new() { Value = "G95" };

    /// <summary>
    /// cubic metre per bar
    /// </summary>
    public static QuantityCode CubicMetrePerBar => new() { Value = "G96" };

    /// <summary>
    /// millilitre per bar
    /// </summary>
    public static QuantityCode MillilitrePerBar => new() { Value = "G97" };

    /// <summary>
    /// microhenry per kiloohm
    /// </summary>
    public static QuantityCode MicrohenryPerKiloohm => new() { Value = "G98" };

    /// <summary>
    /// microhenry per ohm
    /// </summary>
    public static QuantityCode MicrohenryPerOhm => new() { Value = "G99" };

    /// <summary>
    /// gallon (US) per day
    /// </summary>
    public static QuantityCode GallonUSPerDay => new() { Value = "GB" };

    /// <summary>
    /// gigabecquerel
    /// </summary>
    public static QuantityCode Gigabecquerel => new() { Value = "GBQ" };

    /// <summary>
    /// gram, dry weight
    /// </summary>
    public static QuantityCode GramDryWeight => new() { Value = "GDW" };

    /// <summary>
    /// pound per gallon (US)
    /// </summary>
    public static QuantityCode PoundPerGallonUS => new() { Value = "GE" };

    /// <summary>
    /// gram per metre (gram per 100 centimetres)
    /// </summary>
    public static QuantityCode GramPerMetreGramPer100Centimetres => new() { Value = "GF" };

    /// <summary>
    /// gram of fissile isotope
    /// </summary>
    public static QuantityCode GramOfFissileIsotope => new() { Value = "GFI" };

    /// <summary>
    /// great gross
    /// </summary>
    public static QuantityCode GreatGross => new() { Value = "GGR" };

    /// <summary>
    /// gill (US)
    /// </summary>
    public static QuantityCode GillUS => new() { Value = "GIA" };

    /// <summary>
    /// gram, including container
    /// </summary>
    public static QuantityCode GramIncludingContainer => new() { Value = "GIC" };

    /// <summary>
    /// gill (UK)
    /// </summary>
    public static QuantityCode GillUK => new() { Value = "GII" };

    /// <summary>
    /// gram, including inner packaging
    /// </summary>
    public static QuantityCode GramIncludingInnerPackaging => new() { Value = "GIP" };

    /// <summary>
    /// gram per millilitre
    /// </summary>
    public static QuantityCode GramPerMillilitre => new() { Value = "GJ" };

    /// <summary>
    /// gram per litre
    /// </summary>
    public static QuantityCode GramPerLitre => new() { Value = "GL" };

    /// <summary>
    /// dry gallon (US)
    /// </summary>
    public static QuantityCode DryGallonUS => new() { Value = "GLD" };

    /// <summary>
    /// gallon (UK)
    /// </summary>
    public static QuantityCode GallonUK => new() { Value = "GLI" };

    /// <summary>
    /// gallon (US)
    /// </summary>
    public static QuantityCode GallonUS => new() { Value = "GLL" };

    /// <summary>
    /// gram per square metre
    /// </summary>
    public static QuantityCode GramPerSquareMetre => new() { Value = "GM" };

    /// <summary>
    /// milligram per square metre
    /// </summary>
    public static QuantityCode MilligramPerSquareMetre => new() { Value = "GO" };

    /// <summary>
    /// milligram per cubic metre
    /// </summary>
    public static QuantityCode MilligramPerCubicMetre => new() { Value = "GP" };

    /// <summary>
    /// microgram per cubic metre
    /// </summary>
    public static QuantityCode MicrogramPerCubicMetre => new() { Value = "GQ" };

    /// <summary>
    /// gram
    /// </summary>
    public static QuantityCode Gram => new() { Value = "GRM" };

    /// <summary>
    /// grain
    /// </summary>
    public static QuantityCode Grain => new() { Value = "GRN" };

    /// <summary>
    /// gross
    /// </summary>
    public static QuantityCode Gross => new() { Value = "GRO" };

    /// <summary>
    /// gigajoule
    /// </summary>
    public static QuantityCode Gigajoule => new() { Value = "GV" };

    /// <summary>
    /// gigawatt hour
    /// </summary>
    public static QuantityCode GigawattHour => new() { Value = "GWH" };

    /// <summary>
    /// henry per kiloohm
    /// </summary>
    public static QuantityCode HenryPerKiloohm => new() { Value = "H03" };

    /// <summary>
    /// henry per ohm
    /// </summary>
    public static QuantityCode HenryPerOhm => new() { Value = "H04" };

    /// <summary>
    /// millihenry per kiloohm
    /// </summary>
    public static QuantityCode MillihenryPerKiloohm => new() { Value = "H05" };

    /// <summary>
    /// millihenry per ohm
    /// </summary>
    public static QuantityCode MillihenryPerOhm => new() { Value = "H06" };

    /// <summary>
    /// pascal second per bar
    /// </summary>
    public static QuantityCode PascalSecondPerBar => new() { Value = "H07" };

    /// <summary>
    /// microbecquerel
    /// </summary>
    public static QuantityCode Microbecquerel => new() { Value = "H08" };

    /// <summary>
    /// reciprocal year
    /// </summary>
    public static QuantityCode ReciprocalYear => new() { Value = "H09" };

    /// <summary>
    /// reciprocal hour
    /// </summary>
    public static QuantityCode ReciprocalHour => new() { Value = "H10" };

    /// <summary>
    /// reciprocal month
    /// </summary>
    public static QuantityCode ReciprocalMonth => new() { Value = "H11" };

    /// <summary>
    /// degree Celsius per hour
    /// </summary>
    public static QuantityCode DegreeCelsiusPerHour => new() { Value = "H12" };

    /// <summary>
    /// degree Celsius per minute
    /// </summary>
    public static QuantityCode DegreeCelsiusPerMinute => new() { Value = "H13" };

    /// <summary>
    /// degree Celsius per second
    /// </summary>
    public static QuantityCode DegreeCelsiusPerSecond => new() { Value = "H14" };

    /// <summary>
    /// square centimetre per gram
    /// </summary>
    public static QuantityCode SquareCentimetrePerGram => new() { Value = "H15" };

    /// <summary>
    /// square decametre
    /// </summary>
    public static QuantityCode SquareDecametre => new() { Value = "H16" };

    /// <summary>
    /// square hectometre
    /// </summary>
    public static QuantityCode SquareHectometre => new() { Value = "H18" };

    /// <summary>
    /// cubic hectometre
    /// </summary>
    public static QuantityCode CubicHectometre => new() { Value = "H19" };

    /// <summary>
    /// cubic kilometre
    /// </summary>
    public static QuantityCode CubicKilometre => new() { Value = "H20" };

    /// <summary>
    /// blank
    /// </summary>
    public static QuantityCode Blank => new() { Value = "H21" };

    /// <summary>
    /// volt square inch per pound-force
    /// </summary>
    public static QuantityCode VoltSquareInchPerPoundForce => new() { Value = "H22" };

    /// <summary>
    /// volt per inch
    /// </summary>
    public static QuantityCode VoltPerInch => new() { Value = "H23" };

    /// <summary>
    /// volt per microsecond
    /// </summary>
    public static QuantityCode VoltPerMicrosecond => new() { Value = "H24" };

    /// <summary>
    /// percent per kelvin
    /// </summary>
    public static QuantityCode PercentPerKelvin => new() { Value = "H25" };

    /// <summary>
    /// ohm per metre
    /// </summary>
    public static QuantityCode OhmPerMetre => new() { Value = "H26" };

    /// <summary>
    /// degree per metre
    /// </summary>
    public static QuantityCode DegreePerMetre => new() { Value = "H27" };

    /// <summary>
    /// microfarad per kilometre
    /// </summary>
    public static QuantityCode MicrofaradPerKilometre => new() { Value = "H28" };

    /// <summary>
    /// microgram per litre
    /// </summary>
    public static QuantityCode MicrogramPerLitre => new() { Value = "H29" };

    /// <summary>
    /// square micrometre (square micron)
    /// </summary>
    public static QuantityCode SquareMicrometreSquareMicron => new() { Value = "H30" };

    /// <summary>
    /// ampere per kilogram
    /// </summary>
    public static QuantityCode AmperePerKilogram => new() { Value = "H31" };

    /// <summary>
    /// ampere squared second
    /// </summary>
    public static QuantityCode AmpereSquaredSecond => new() { Value = "H32" };

    /// <summary>
    /// farad per kilometre
    /// </summary>
    public static QuantityCode FaradPerKilometre => new() { Value = "H33" };

    /// <summary>
    /// hertz metre
    /// </summary>
    public static QuantityCode HertzMetre => new() { Value = "H34" };

    /// <summary>
    /// kelvin metre per watt
    /// </summary>
    public static QuantityCode KelvinMetrePerWatt => new() { Value = "H35" };

    /// <summary>
    /// megaohm per kilometre
    /// </summary>
    public static QuantityCode MegaohmPerKilometre => new() { Value = "H36" };

    /// <summary>
    /// megaohm per metre
    /// </summary>
    public static QuantityCode MegaohmPerMetre => new() { Value = "H37" };

    /// <summary>
    /// megaampere
    /// </summary>
    public static QuantityCode Megaampere => new() { Value = "H38" };

    /// <summary>
    /// megahertz kilometre
    /// </summary>
    public static QuantityCode MegahertzKilometre => new() { Value = "H39" };

    /// <summary>
    /// newton per ampere
    /// </summary>
    public static QuantityCode NewtonPerAmpere => new() { Value = "H40" };

    /// <summary>
    /// newton metre watt to the power minus 0,5
    /// </summary>
    public static QuantityCode NewtonMetreWattToThePowerMinus05 => new() { Value = "H41" };

    /// <summary>
    /// pascal per metre
    /// </summary>
    public static QuantityCode PascalPerMetre => new() { Value = "H42" };

    /// <summary>
    /// siemens per centimetre
    /// </summary>
    public static QuantityCode SiemensPerCentimetre => new() { Value = "H43" };

    /// <summary>
    /// teraohm
    /// </summary>
    public static QuantityCode Teraohm => new() { Value = "H44" };

    /// <summary>
    /// volt second per metre
    /// </summary>
    public static QuantityCode VoltSecondPerMetre => new() { Value = "H45" };

    /// <summary>
    /// volt per second
    /// </summary>
    public static QuantityCode VoltPerSecond => new() { Value = "H46" };

    /// <summary>
    /// watt per cubic metre
    /// </summary>
    public static QuantityCode WattPerCubicMetre => new() { Value = "H47" };

    /// <summary>
    /// attofarad
    /// </summary>
    public static QuantityCode Attofarad => new() { Value = "H48" };

    /// <summary>
    /// centimetre per hour
    /// </summary>
    public static QuantityCode CentimetrePerHour => new() { Value = "H49" };

    /// <summary>
    /// reciprocal cubic centimetre
    /// </summary>
    public static QuantityCode ReciprocalCubicCentimetre => new() { Value = "H50" };

    /// <summary>
    /// decibel per kilometre
    /// </summary>
    public static QuantityCode DecibelPerKilometre => new() { Value = "H51" };

    /// <summary>
    /// decibel per metre
    /// </summary>
    public static QuantityCode DecibelPerMetre => new() { Value = "H52" };

    /// <summary>
    /// kilogram per bar
    /// </summary>
    public static QuantityCode KilogramPerBar => new() { Value = "H53" };

    /// <summary>
    /// kilogram per cubic decimetre kelvin
    /// </summary>
    public static QuantityCode KilogramPerCubicDecimetreKelvin => new() { Value = "H54" };

    /// <summary>
    /// kilogram per cubic decimetre bar
    /// </summary>
    public static QuantityCode KilogramPerCubicDecimetreBar => new() { Value = "H55" };

    /// <summary>
    /// kilogram per square metre second
    /// </summary>
    public static QuantityCode KilogramPerSquareMetreSecond => new() { Value = "H56" };

    /// <summary>
    /// inch per two pi radiant
    /// </summary>
    public static QuantityCode InchPerTwoPiRadiant => new() { Value = "H57" };

    /// <summary>
    /// metre per volt second
    /// </summary>
    public static QuantityCode MetrePerVoltSecond => new() { Value = "H58" };

    /// <summary>
    /// square metre per newton
    /// </summary>
    public static QuantityCode SquareMetrePerNewton => new() { Value = "H59" };

    /// <summary>
    /// cubic metre per cubic metre
    /// </summary>
    public static QuantityCode CubicMetrePerCubicMetre => new() { Value = "H60" };

    /// <summary>
    /// millisiemens per centimetre
    /// </summary>
    public static QuantityCode MillisiemensPerCentimetre => new() { Value = "H61" };

    /// <summary>
    /// millivolt per minute
    /// </summary>
    public static QuantityCode MillivoltPerMinute => new() { Value = "H62" };

    /// <summary>
    /// milligram per square centimetre
    /// </summary>
    public static QuantityCode MilligramPerSquareCentimetre => new() { Value = "H63" };

    /// <summary>
    /// milligram per gram
    /// </summary>
    public static QuantityCode MilligramPerGram => new() { Value = "H64" };

    /// <summary>
    /// millilitre per cubic metre
    /// </summary>
    public static QuantityCode MillilitrePerCubicMetre => new() { Value = "H65" };

    /// <summary>
    /// millimetre per year
    /// </summary>
    public static QuantityCode MillimetrePerYear => new() { Value = "H66" };

    /// <summary>
    /// millimetre per hour
    /// </summary>
    public static QuantityCode MillimetrePerHour => new() { Value = "H67" };

    /// <summary>
    /// millimole per gram
    /// </summary>
    public static QuantityCode MillimolePerGram => new() { Value = "H68" };

    /// <summary>
    /// picopascal per kilometre
    /// </summary>
    public static QuantityCode PicopascalPerKilometre => new() { Value = "H69" };

    /// <summary>
    /// picosecond
    /// </summary>
    public static QuantityCode Picosecond => new() { Value = "H70" };

    /// <summary>
    /// percent per month
    /// </summary>
    public static QuantityCode PercentPerMonth => new() { Value = "H71" };

    /// <summary>
    /// percent per hectobar
    /// </summary>
    public static QuantityCode PercentPerHectobar => new() { Value = "H72" };

    /// <summary>
    /// percent per decakelvin
    /// </summary>
    public static QuantityCode PercentPerDecakelvin => new() { Value = "H73" };

    /// <summary>
    /// watt per metre
    /// </summary>
    public static QuantityCode WattPerMetre => new() { Value = "H74" };

    /// <summary>
    /// decapascal
    /// </summary>
    public static QuantityCode Decapascal => new() { Value = "H75" };

    /// <summary>
    /// gram per millimetre
    /// </summary>
    public static QuantityCode GramPerMillimetre => new() { Value = "H76" };

    /// <summary>
    /// module width
    /// </summary>
    public static QuantityCode ModuleWidth => new() { Value = "H77" };

    /// <summary>
    /// French gauge
    /// </summary>
    public static QuantityCode FrenchGauge => new() { Value = "H79" };

    /// <summary>
    /// rack unit
    /// </summary>
    public static QuantityCode RackUnit => new() { Value = "H80" };

    /// <summary>
    /// millimetre per minute
    /// </summary>
    public static QuantityCode MillimetrePerMinute => new() { Value = "H81" };

    /// <summary>
    /// big point
    /// </summary>
    public static QuantityCode BigPoint => new() { Value = "H82" };

    /// <summary>
    /// litre per kilogram
    /// </summary>
    public static QuantityCode LitrePerKilogram => new() { Value = "H83" };

    /// <summary>
    /// gram millimetre
    /// </summary>
    public static QuantityCode GramMillimetre => new() { Value = "H84" };

    /// <summary>
    /// reciprocal week
    /// </summary>
    public static QuantityCode ReciprocalWeek => new() { Value = "H85" };

    /// <summary>
    /// piece
    /// </summary>
    public static QuantityCode Piece => new() { Value = "H87" };

    /// <summary>
    /// megaohm kilometre
    /// </summary>
    public static QuantityCode MegaohmKilometre => new() { Value = "H88" };

    /// <summary>
    /// percent per ohm
    /// </summary>
    public static QuantityCode PercentPerOhm => new() { Value = "H89" };

    /// <summary>
    /// percent per degree
    /// </summary>
    public static QuantityCode PercentPerDegree => new() { Value = "H90" };

    /// <summary>
    /// percent per ten thousand
    /// </summary>
    public static QuantityCode PercentPerTenThousand => new() { Value = "H91" };

    /// <summary>
    /// percent per one hundred thousand
    /// </summary>
    public static QuantityCode PercentPerOneHundredThousand => new() { Value = "H92" };

    /// <summary>
    /// percent per hundred
    /// </summary>
    public static QuantityCode PercentPerHundred => new() { Value = "H93" };

    /// <summary>
    /// percent per thousand
    /// </summary>
    public static QuantityCode PercentPerThousand => new() { Value = "H94" };

    /// <summary>
    /// percent per volt
    /// </summary>
    public static QuantityCode PercentPerVolt => new() { Value = "H95" };

    /// <summary>
    /// percent per bar
    /// </summary>
    public static QuantityCode PercentPerBar => new() { Value = "H96" };

    /// <summary>
    /// percent per inch
    /// </summary>
    public static QuantityCode PercentPerInch => new() { Value = "H98" };

    /// <summary>
    /// percent per metre
    /// </summary>
    public static QuantityCode PercentPerMetre => new() { Value = "H99" };

    /// <summary>
    /// hank
    /// </summary>
    public static QuantityCode Hank => new() { Value = "HA" };

    /// <summary>
    /// Piece Day
    /// </summary>
    public static QuantityCode PieceDay => new() { Value = "HAD" };

    /// <summary>
    /// hectobar
    /// </summary>
    public static QuantityCode Hectobar => new() { Value = "HBA" };

    /// <summary>
    /// hundred boxes
    /// </summary>
    public static QuantityCode HundredBoxes => new() { Value = "HBX" };

    /// <summary>
    /// hundred count
    /// </summary>
    public static QuantityCode HundredCount => new() { Value = "HC" };

    /// <summary>
    /// hundred kilogram, dry weight
    /// </summary>
    public static QuantityCode HundredKilogramDryWeight => new() { Value = "HDW" };

    /// <summary>
    /// head
    /// </summary>
    public static QuantityCode Head => new() { Value = "HEA" };

    /// <summary>
    /// hectogram
    /// </summary>
    public static QuantityCode Hectogram => new() { Value = "HGM" };

    /// <summary>
    /// hundred cubic foot
    /// </summary>
    public static QuantityCode HundredCubicFoot => new() { Value = "HH" };

    /// <summary>
    /// hundred international unit
    /// </summary>
    public static QuantityCode HundredInternationalUnit => new() { Value = "HIU" };

    /// <summary>
    /// hundred kilogram, net mass
    /// </summary>
    public static QuantityCode HundredKilogramNetMass => new() { Value = "HKM" };

    /// <summary>
    /// hectolitre
    /// </summary>
    public static QuantityCode Hectolitre => new() { Value = "HLT" };

    /// <summary>
    /// mile per hour (statute mile)
    /// </summary>
    public static QuantityCode MilePerHourStatuteMile => new() { Value = "HM" };

    /// <summary>
    /// Piece Month
    /// </summary>
    public static QuantityCode PieceMonth => new() { Value = "HMO" };

    /// <summary>
    /// million cubic metre
    /// </summary>
    public static QuantityCode MillionCubicMetre => new() { Value = "HMQ" };

    /// <summary>
    /// hectometre
    /// </summary>
    public static QuantityCode Hectometre => new() { Value = "HMT" };

    /// <summary>
    /// hectolitre of pure alcohol
    /// </summary>
    public static QuantityCode HectolitreOfPureAlcohol => new() { Value = "HPA" };

    /// <summary>
    /// hertz
    /// </summary>
    public static QuantityCode Hertz => new() { Value = "HTZ" };

    /// <summary>
    /// hour
    /// </summary>
    public static QuantityCode Hour => new() { Value = "HUR" };

    /// <summary>
    /// Piece Week
    /// </summary>
    public static QuantityCode PieceWeek => new() { Value = "HWE" };

    /// <summary>
    /// inch pound (pound inch)
    /// </summary>
    public static QuantityCode InchPoundPoundInch => new() { Value = "IA" };

    /// <summary>
    /// person
    /// </summary>
    public static QuantityCode Person => new() { Value = "IE" };

    /// <summary>
    /// inch
    /// </summary>
    public static QuantityCode Inch => new() { Value = "INH" };

    /// <summary>
    /// square inch
    /// </summary>
    public static QuantityCode SquareInch => new() { Value = "INK" };

    /// <summary>
    /// cubic inch
    /// </summary>
    public static QuantityCode CubicInch => new() { Value = "INQ" };

    /// <summary>
    /// international sugar degree
    /// </summary>
    public static QuantityCode InternationalSugarDegree => new() { Value = "ISD" };

    /// <summary>
    /// inch per second
    /// </summary>
    public static QuantityCode InchPerSecond => new() { Value = "IU" };

    /// <summary>
    /// international unit per gram
    /// </summary>
    public static QuantityCode InternationalUnitPerGram => new() { Value = "IUG" };

    /// <summary>
    /// inch per second squared
    /// </summary>
    public static QuantityCode InchPerSecondSquared => new() { Value = "IV" };

    /// <summary>
    /// percent per millimetre
    /// </summary>
    public static QuantityCode PercentPerMillimetre => new() { Value = "J10" };

    /// <summary>
    /// per mille per psi
    /// </summary>
    public static QuantityCode PerMillePerPsi => new() { Value = "J12" };

    /// <summary>
    /// degree API
    /// </summary>
    public static QuantityCode DegreeAPI => new() { Value = "J13" };

    /// <summary>
    /// degree Baume (origin scale)
    /// </summary>
    public static QuantityCode DegreeBaumeOriginScale => new() { Value = "J14" };

    /// <summary>
    /// degree Baume (US heavy)
    /// </summary>
    public static QuantityCode DegreeBaumeUSHeavy => new() { Value = "J15" };

    /// <summary>
    /// degree Baume (US light)
    /// </summary>
    public static QuantityCode DegreeBaumeUSLight => new() { Value = "J16" };

    /// <summary>
    /// degree Balling
    /// </summary>
    public static QuantityCode DegreeBalling => new() { Value = "J17" };

    /// <summary>
    /// degree Brix
    /// </summary>
    public static QuantityCode DegreeBrix => new() { Value = "J18" };

    /// <summary>
    /// degree Fahrenheit hour square foot per British thermal unit (thermochemical)
    /// </summary>
    public static QuantityCode DegreeFahrenheitHourSquareFootPerBritishThermalUnitThermochemical => new() { Value = "J19" };

    /// <summary>
    /// joule per kilogram
    /// </summary>
    public static QuantityCode JoulePerKilogram => new() { Value = "J2" };

    /// <summary>
    /// degree Fahrenheit per kelvin
    /// </summary>
    public static QuantityCode DegreeFahrenheitPerKelvin => new() { Value = "J20" };

    /// <summary>
    /// degree Fahrenheit per bar
    /// </summary>
    public static QuantityCode DegreeFahrenheitPerBar => new() { Value = "J21" };

    /// <summary>
    /// degree Fahrenheit hour square foot per British thermal unit (international table)
    /// </summary>
    public static QuantityCode DegreeFahrenheitHourSquareFootPerBritishThermalUnitInternationalTable => new() { Value = "J22" };

    /// <summary>
    /// degree Fahrenheit per hour
    /// </summary>
    public static QuantityCode DegreeFahrenheitPerHour => new() { Value = "J23" };

    /// <summary>
    /// degree Fahrenheit per minute
    /// </summary>
    public static QuantityCode DegreeFahrenheitPerMinute => new() { Value = "J24" };

    /// <summary>
    /// degree Fahrenheit per second
    /// </summary>
    public static QuantityCode DegreeFahrenheitPerSecond => new() { Value = "J25" };

    /// <summary>
    /// reciprocal degree Fahrenheit
    /// </summary>
    public static QuantityCode ReciprocalDegreeFahrenheit => new() { Value = "J26" };

    /// <summary>
    /// degree Oechsle
    /// </summary>
    public static QuantityCode DegreeOechsle => new() { Value = "J27" };

    /// <summary>
    /// degree Rankine per hour
    /// </summary>
    public static QuantityCode DegreeRankinePerHour => new() { Value = "J28" };

    /// <summary>
    /// degree Rankine per minute
    /// </summary>
    public static QuantityCode DegreeRankinePerMinute => new() { Value = "J29" };

    /// <summary>
    /// degree Rankine per second
    /// </summary>
    public static QuantityCode DegreeRankinePerSecond => new() { Value = "J30" };

    /// <summary>
    /// degree Twaddell
    /// </summary>
    public static QuantityCode DegreeTwaddell => new() { Value = "J31" };

    /// <summary>
    /// micropoise
    /// </summary>
    public static QuantityCode Micropoise => new() { Value = "J32" };

    /// <summary>
    /// microgram per kilogram
    /// </summary>
    public static QuantityCode MicrogramPerKilogram => new() { Value = "J33" };

    /// <summary>
    /// microgram per cubic metre kelvin
    /// </summary>
    public static QuantityCode MicrogramPerCubicMetreKelvin => new() { Value = "J34" };

    /// <summary>
    /// microgram per cubic metre bar
    /// </summary>
    public static QuantityCode MicrogramPerCubicMetreBar => new() { Value = "J35" };

    /// <summary>
    /// microlitre per litre
    /// </summary>
    public static QuantityCode MicrolitrePerLitre => new() { Value = "J36" };

    /// <summary>
    /// baud
    /// </summary>
    public static QuantityCode Baud => new() { Value = "J38" };

    /// <summary>
    /// British thermal unit (mean)
    /// </summary>
    public static QuantityCode BritishThermalUnitMean => new() { Value = "J39" };

    /// <summary>
    /// British thermal unit (international table) foot per hour square foot degree Fahrenheit
    /// </summary>
    public static QuantityCode BritishThermalUnitInternationalTableFootPerHourSquareFootDegreeFahrenheit => new() { Value = "J40" };

    /// <summary>
    /// British thermal unit (international table) inch per hour square foot degree Fahrenheit
    /// </summary>
    public static QuantityCode BritishThermalUnitInternationalTableInchPerHourSquareFootDegreeFahrenheit => new() { Value = "J41" };

    /// <summary>
    /// British thermal unit (international table) inch per second square foot degree Fahrenheit
    /// </summary>
    public static QuantityCode BritishThermalUnitInternationalTableInchPerSecondSquareFootDegreeFahrenheit => new() { Value = "J42" };

    /// <summary>
    /// British thermal unit (international table) per pound degree Fahrenheit
    /// </summary>
    public static QuantityCode BritishThermalUnitInternationalTablePerPoundDegreeFahrenheit => new() { Value = "J43" };

    /// <summary>
    /// British thermal unit (international table) per minute
    /// </summary>
    public static QuantityCode BritishThermalUnitInternationalTablePerMinute => new() { Value = "J44" };

    /// <summary>
    /// British thermal unit (international table) per second
    /// </summary>
    public static QuantityCode BritishThermalUnitInternationalTablePerSecond => new() { Value = "J45" };

    /// <summary>
    /// British thermal unit (thermochemical) foot per hour square foot degree Fahrenheit
    /// </summary>
    public static QuantityCode BritishThermalUnitThermochemicalFootPerHourSquareFootDegreeFahrenheit => new() { Value = "J46" };

    /// <summary>
    /// British thermal unit (thermochemical) per hour
    /// </summary>
    public static QuantityCode BritishThermalUnitThermochemicalPerHour => new() { Value = "J47" };

    /// <summary>
    /// British thermal unit (thermochemical) inch per hour square foot degree Fahrenheit
    /// </summary>
    public static QuantityCode BritishThermalUnitThermochemicalInchPerHourSquareFootDegreeFahrenheit => new() { Value = "J48" };

    /// <summary>
    /// British thermal unit (thermochemical) inch per second square foot degree Fahrenheit
    /// </summary>
    public static QuantityCode BritishThermalUnitThermochemicalInchPerSecondSquareFootDegreeFahrenheit => new() { Value = "J49" };

    /// <summary>
    /// British thermal unit (thermochemical) per pound degree Fahrenheit
    /// </summary>
    public static QuantityCode BritishThermalUnitThermochemicalPerPoundDegreeFahrenheit => new() { Value = "J50" };

    /// <summary>
    /// British thermal unit (thermochemical) per minute
    /// </summary>
    public static QuantityCode BritishThermalUnitThermochemicalPerMinute => new() { Value = "J51" };

    /// <summary>
    /// British thermal unit (thermochemical) per second
    /// </summary>
    public static QuantityCode BritishThermalUnitThermochemicalPerSecond => new() { Value = "J52" };

    /// <summary>
    /// coulomb square metre per kilogram
    /// </summary>
    public static QuantityCode CoulombSquareMetrePerKilogram => new() { Value = "J53" };

    /// <summary>
    /// megabaud
    /// </summary>
    public static QuantityCode Megabaud => new() { Value = "J54" };

    /// <summary>
    /// watt second
    /// </summary>
    public static QuantityCode WattSecond => new() { Value = "J55" };

    /// <summary>
    /// bar per bar
    /// </summary>
    public static QuantityCode BarPerBar => new() { Value = "J56" };

    /// <summary>
    /// barrel (UK petroleum)
    /// </summary>
    public static QuantityCode BarrelUKPetroleum => new() { Value = "J57" };

    /// <summary>
    /// barrel (UK petroleum) per minute
    /// </summary>
    public static QuantityCode BarrelUKPetroleumPerMinute => new() { Value = "J58" };

    /// <summary>
    /// barrel (UK petroleum) per day
    /// </summary>
    public static QuantityCode BarrelUKPetroleumPerDay => new() { Value = "J59" };

    /// <summary>
    /// barrel (UK petroleum) per hour
    /// </summary>
    public static QuantityCode BarrelUKPetroleumPerHour => new() { Value = "J60" };

    /// <summary>
    /// barrel (UK petroleum) per second
    /// </summary>
    public static QuantityCode BarrelUKPetroleumPerSecond => new() { Value = "J61" };

    /// <summary>
    /// barrel (US petroleum) per hour
    /// </summary>
    public static QuantityCode BarrelUSPetroleumPerHour => new() { Value = "J62" };

    /// <summary>
    /// barrel (US petroleum) per second
    /// </summary>
    public static QuantityCode BarrelUSPetroleumPerSecond => new() { Value = "J63" };

    /// <summary>
    /// bushel (UK) per day
    /// </summary>
    public static QuantityCode BushelUKPerDay => new() { Value = "J64" };

    /// <summary>
    /// bushel (UK) per hour
    /// </summary>
    public static QuantityCode BushelUKPerHour => new() { Value = "J65" };

    /// <summary>
    /// bushel (UK) per minute
    /// </summary>
    public static QuantityCode BushelUKPerMinute => new() { Value = "J66" };

    /// <summary>
    /// bushel (UK) per second
    /// </summary>
    public static QuantityCode BushelUKPerSecond => new() { Value = "J67" };

    /// <summary>
    /// bushel (US dry) per day
    /// </summary>
    public static QuantityCode BushelUSDryPerDay => new() { Value = "J68" };

    /// <summary>
    /// bushel (US dry) per hour
    /// </summary>
    public static QuantityCode BushelUSDryPerHour => new() { Value = "J69" };

    /// <summary>
    /// bushel (US dry) per minute
    /// </summary>
    public static QuantityCode BushelUSDryPerMinute => new() { Value = "J70" };

    /// <summary>
    /// bushel (US dry) per second
    /// </summary>
    public static QuantityCode BushelUSDryPerSecond => new() { Value = "J71" };

    /// <summary>
    /// centinewton metre
    /// </summary>
    public static QuantityCode CentinewtonMetre => new() { Value = "J72" };

    /// <summary>
    /// centipoise per kelvin
    /// </summary>
    public static QuantityCode CentipoisePerKelvin => new() { Value = "J73" };

    /// <summary>
    /// centipoise per bar
    /// </summary>
    public static QuantityCode CentipoisePerBar => new() { Value = "J74" };

    /// <summary>
    /// calorie (mean)
    /// </summary>
    public static QuantityCode CalorieMean => new() { Value = "J75" };

    /// <summary>
    /// calorie (international table) per gram degree Celsius
    /// </summary>
    public static QuantityCode CalorieInternationalTablePerGramDegreeCelsius => new() { Value = "J76" };

    /// <summary>
    /// calorie (thermochemical) per centimetre second degree Celsius
    /// </summary>
    public static QuantityCode CalorieThermochemicalPerCentimetreSecondDegreeCelsius => new() { Value = "J78" };

    /// <summary>
    /// calorie (thermochemical) per gram degree Celsius
    /// </summary>
    public static QuantityCode CalorieThermochemicalPerGramDegreeCelsius => new() { Value = "J79" };

    /// <summary>
    /// calorie (thermochemical) per minute
    /// </summary>
    public static QuantityCode CalorieThermochemicalPerMinute => new() { Value = "J81" };

    /// <summary>
    /// calorie (thermochemical) per second
    /// </summary>
    public static QuantityCode CalorieThermochemicalPerSecond => new() { Value = "J82" };

    /// <summary>
    /// clo
    /// </summary>
    public static QuantityCode Clo => new() { Value = "J83" };

    /// <summary>
    /// centimetre per second kelvin
    /// </summary>
    public static QuantityCode CentimetrePerSecondKelvin => new() { Value = "J84" };

    /// <summary>
    /// centimetre per second bar
    /// </summary>
    public static QuantityCode CentimetrePerSecondBar => new() { Value = "J85" };

    /// <summary>
    /// cubic centimetre per cubic metre
    /// </summary>
    public static QuantityCode CubicCentimetrePerCubicMetre => new() { Value = "J87" };

    /// <summary>
    /// cubic decimetre per day
    /// </summary>
    public static QuantityCode CubicDecimetrePerDay => new() { Value = "J90" };

    /// <summary>
    /// cubic decimetre per cubic metre
    /// </summary>
    public static QuantityCode CubicDecimetrePerCubicMetre => new() { Value = "J91" };

    /// <summary>
    /// cubic decimetre per minute
    /// </summary>
    public static QuantityCode CubicDecimetrePerMinute => new() { Value = "J92" };

    /// <summary>
    /// cubic decimetre per second
    /// </summary>
    public static QuantityCode CubicDecimetrePerSecond => new() { Value = "J93" };

    /// <summary>
    /// ounce (UK fluid) per day
    /// </summary>
    public static QuantityCode OunceUKFluidPerDay => new() { Value = "J95" };

    /// <summary>
    /// ounce (UK fluid) per hour
    /// </summary>
    public static QuantityCode OunceUKFluidPerHour => new() { Value = "J96" };

    /// <summary>
    /// ounce (UK fluid) per minute
    /// </summary>
    public static QuantityCode OunceUKFluidPerMinute => new() { Value = "J97" };

    /// <summary>
    /// ounce (UK fluid) per second
    /// </summary>
    public static QuantityCode OunceUKFluidPerSecond => new() { Value = "J98" };

    /// <summary>
    /// ounce (US fluid) per day
    /// </summary>
    public static QuantityCode OunceUSFluidPerDay => new() { Value = "J99" };

    /// <summary>
    /// joule per kelvin
    /// </summary>
    public static QuantityCode JoulePerKelvin => new() { Value = "JE" };

    /// <summary>
    /// megajoule per kilogram
    /// </summary>
    public static QuantityCode MegajoulePerKilogram => new() { Value = "JK" };

    /// <summary>
    /// megajoule per cubic metre
    /// </summary>
    public static QuantityCode MegajoulePerCubicMetre => new() { Value = "JM" };

    /// <summary>
    /// pipeline joint
    /// </summary>
    public static QuantityCode PipelineJoint => new() { Value = "JNT" };

    /// <summary>
    /// joule
    /// </summary>
    public static QuantityCode Joule => new() { Value = "JOU" };

    /// <summary>
    /// hundred metre
    /// </summary>
    public static QuantityCode HundredMetre => new() { Value = "JPS" };

    /// <summary>
    /// number of jewels
    /// </summary>
    public static QuantityCode NumberOfJewels => new() { Value = "JWL" };

    /// <summary>
    /// kilowatt demand
    /// </summary>
    public static QuantityCode KilowattDemand => new() { Value = "K1" };

    /// <summary>
    /// ounce (US fluid) per hour
    /// </summary>
    public static QuantityCode OunceUSFluidPerHour => new() { Value = "K10" };

    /// <summary>
    /// ounce (US fluid) per minute
    /// </summary>
    public static QuantityCode OunceUSFluidPerMinute => new() { Value = "K11" };

    /// <summary>
    /// ounce (US fluid) per second
    /// </summary>
    public static QuantityCode OunceUSFluidPerSecond => new() { Value = "K12" };

    /// <summary>
    /// foot per degree Fahrenheit
    /// </summary>
    public static QuantityCode FootPerDegreeFahrenheit => new() { Value = "K13" };

    /// <summary>
    /// foot per hour
    /// </summary>
    public static QuantityCode FootPerHour => new() { Value = "K14" };

    /// <summary>
    /// foot pound-force per hour
    /// </summary>
    public static QuantityCode FootPoundForcePerHour => new() { Value = "K15" };

    /// <summary>
    /// foot pound-force per minute
    /// </summary>
    public static QuantityCode FootPoundForcePerMinute => new() { Value = "K16" };

    /// <summary>
    /// foot per psi
    /// </summary>
    public static QuantityCode FootPerPsi => new() { Value = "K17" };

    /// <summary>
    /// foot per second degree Fahrenheit
    /// </summary>
    public static QuantityCode FootPerSecondDegreeFahrenheit => new() { Value = "K18" };

    /// <summary>
    /// foot per second psi
    /// </summary>
    public static QuantityCode FootPerSecondPsi => new() { Value = "K19" };

    /// <summary>
    /// kilovolt ampere reactive demand
    /// </summary>
    public static QuantityCode KilovoltAmpereReactiveDemand => new() { Value = "K2" };

    /// <summary>
    /// reciprocal cubic foot
    /// </summary>
    public static QuantityCode ReciprocalCubicFoot => new() { Value = "K20" };

    /// <summary>
    /// cubic foot per degree Fahrenheit
    /// </summary>
    public static QuantityCode CubicFootPerDegreeFahrenheit => new() { Value = "K21" };

    /// <summary>
    /// cubic foot per day
    /// </summary>
    public static QuantityCode CubicFootPerDay => new() { Value = "K22" };

    /// <summary>
    /// cubic foot per psi
    /// </summary>
    public static QuantityCode CubicFootPerPsi => new() { Value = "K23" };

    /// <summary>
    /// gallon (UK) per day
    /// </summary>
    public static QuantityCode GallonUKPerDay => new() { Value = "K26" };

    /// <summary>
    /// gallon (UK) per hour
    /// </summary>
    public static QuantityCode GallonUKPerHour => new() { Value = "K27" };

    /// <summary>
    /// gallon (UK) per second
    /// </summary>
    public static QuantityCode GallonUKPerSecond => new() { Value = "K28" };

    /// <summary>
    /// kilovolt ampere reactive hour
    /// </summary>
    public static QuantityCode KilovoltAmpereReactiveHour => new() { Value = "K3" };

    /// <summary>
    /// gallon (US liquid) per second
    /// </summary>
    public static QuantityCode GallonUSLiquidPerSecond => new() { Value = "K30" };

    /// <summary>
    /// gram-force per square centimetre
    /// </summary>
    public static QuantityCode GramForcePerSquareCentimetre => new() { Value = "K31" };

    /// <summary>
    /// gill (UK) per day
    /// </summary>
    public static QuantityCode GillUKPerDay => new() { Value = "K32" };

    /// <summary>
    /// gill (UK) per hour
    /// </summary>
    public static QuantityCode GillUKPerHour => new() { Value = "K33" };

    /// <summary>
    /// gill (UK) per minute
    /// </summary>
    public static QuantityCode GillUKPerMinute => new() { Value = "K34" };

    /// <summary>
    /// gill (UK) per second
    /// </summary>
    public static QuantityCode GillUKPerSecond => new() { Value = "K35" };

    /// <summary>
    /// gill (US) per day
    /// </summary>
    public static QuantityCode GillUSPerDay => new() { Value = "K36" };

    /// <summary>
    /// gill (US) per hour
    /// </summary>
    public static QuantityCode GillUSPerHour => new() { Value = "K37" };

    /// <summary>
    /// gill (US) per minute
    /// </summary>
    public static QuantityCode GillUSPerMinute => new() { Value = "K38" };

    /// <summary>
    /// gill (US) per second
    /// </summary>
    public static QuantityCode GillUSPerSecond => new() { Value = "K39" };

    /// <summary>
    /// standard acceleration of free fall
    /// </summary>
    public static QuantityCode StandardAccelerationOfFreeFall => new() { Value = "K40" };

    /// <summary>
    /// grain per gallon (US)
    /// </summary>
    public static QuantityCode GrainPerGallonUS => new() { Value = "K41" };

    /// <summary>
    /// horsepower (boiler)
    /// </summary>
    public static QuantityCode HorsepowerBoiler => new() { Value = "K42" };

    /// <summary>
    /// horsepower (electric)
    /// </summary>
    public static QuantityCode HorsepowerElectric => new() { Value = "K43" };

    /// <summary>
    /// inch per degree Fahrenheit
    /// </summary>
    public static QuantityCode InchPerDegreeFahrenheit => new() { Value = "K45" };

    /// <summary>
    /// inch per psi
    /// </summary>
    public static QuantityCode InchPerPsi => new() { Value = "K46" };

    /// <summary>
    /// inch per second degree Fahrenheit
    /// </summary>
    public static QuantityCode InchPerSecondDegreeFahrenheit => new() { Value = "K47" };

    /// <summary>
    /// inch per second psi
    /// </summary>
    public static QuantityCode InchPerSecondPsi => new() { Value = "K48" };

    /// <summary>
    /// reciprocal cubic inch
    /// </summary>
    public static QuantityCode ReciprocalCubicInch => new() { Value = "K49" };

    /// <summary>
    /// kilobaud
    /// </summary>
    public static QuantityCode Kilobaud => new() { Value = "K50" };

    /// <summary>
    /// kilocalorie (mean)
    /// </summary>
    public static QuantityCode KilocalorieMean => new() { Value = "K51" };

    /// <summary>
    /// kilocalorie (international table) per hour metre degree Celsius
    /// </summary>
    public static QuantityCode KilocalorieInternationalTablePerHourMetreDegreeCelsius => new() { Value = "K52" };

    /// <summary>
    /// kilocalorie (thermochemical)
    /// </summary>
    public static QuantityCode KilocalorieThermochemical => new() { Value = "K53" };

    /// <summary>
    /// kilocalorie (thermochemical) per minute
    /// </summary>
    public static QuantityCode KilocalorieThermochemicalPerMinute => new() { Value = "K54" };

    /// <summary>
    /// kilocalorie (thermochemical) per second
    /// </summary>
    public static QuantityCode KilocalorieThermochemicalPerSecond => new() { Value = "K55" };

    /// <summary>
    /// kilomole per hour
    /// </summary>
    public static QuantityCode KilomolePerHour => new() { Value = "K58" };

    /// <summary>
    /// kilomole per cubic metre kelvin
    /// </summary>
    public static QuantityCode KilomolePerCubicMetreKelvin => new() { Value = "K59" };

    /// <summary>
    /// kilolitre
    /// </summary>
    public static QuantityCode Kilolitre => new() { Value = "K6" };

    /// <summary>
    /// kilomole per cubic metre bar
    /// </summary>
    public static QuantityCode KilomolePerCubicMetreBar => new() { Value = "K60" };

    /// <summary>
    /// kilomole per minute
    /// </summary>
    public static QuantityCode KilomolePerMinute => new() { Value = "K61" };

    /// <summary>
    /// litre per litre
    /// </summary>
    public static QuantityCode LitrePerLitre => new() { Value = "K62" };

    /// <summary>
    /// reciprocal litre
    /// </summary>
    public static QuantityCode ReciprocalLitre => new() { Value = "K63" };

    /// <summary>
    /// pound (avoirdupois) per degree Fahrenheit
    /// </summary>
    public static QuantityCode PoundAvoirdupoisPerDegreeFahrenheit => new() { Value = "K64" };

    /// <summary>
    /// pound (avoirdupois) square foot
    /// </summary>
    public static QuantityCode PoundAvoirdupoisSquareFoot => new() { Value = "K65" };

    /// <summary>
    /// pound (avoirdupois) per day
    /// </summary>
    public static QuantityCode PoundAvoirdupoisPerDay => new() { Value = "K66" };

    /// <summary>
    /// pound per foot hour
    /// </summary>
    public static QuantityCode PoundPerFootHour => new() { Value = "K67" };

    /// <summary>
    /// pound per foot second
    /// </summary>
    public static QuantityCode PoundPerFootSecond => new() { Value = "K68" };

    /// <summary>
    /// pound (avoirdupois) per cubic foot degree Fahrenheit
    /// </summary>
    public static QuantityCode PoundAvoirdupoisPerCubicFootDegreeFahrenheit => new() { Value = "K69" };

    /// <summary>
    /// pound (avoirdupois) per cubic foot psi
    /// </summary>
    public static QuantityCode PoundAvoirdupoisPerCubicFootPsi => new() { Value = "K70" };

    /// <summary>
    /// pound (avoirdupois) per gallon (UK)
    /// </summary>
    public static QuantityCode PoundAvoirdupoisPerGallonUK => new() { Value = "K71" };

    /// <summary>
    /// pound (avoirdupois) per hour degree Fahrenheit
    /// </summary>
    public static QuantityCode PoundAvoirdupoisPerHourDegreeFahrenheit => new() { Value = "K73" };

    /// <summary>
    /// pound (avoirdupois) per hour psi
    /// </summary>
    public static QuantityCode PoundAvoirdupoisPerHourPsi => new() { Value = "K74" };

    /// <summary>
    /// pound (avoirdupois) per cubic inch degree Fahrenheit
    /// </summary>
    public static QuantityCode PoundAvoirdupoisPerCubicInchDegreeFahrenheit => new() { Value = "K75" };

    /// <summary>
    /// pound (avoirdupois) per cubic inch psi
    /// </summary>
    public static QuantityCode PoundAvoirdupoisPerCubicInchPsi => new() { Value = "K76" };

    /// <summary>
    /// pound (avoirdupois) per psi
    /// </summary>
    public static QuantityCode PoundAvoirdupoisPerPsi => new() { Value = "K77" };

    /// <summary>
    /// pound (avoirdupois) per minute
    /// </summary>
    public static QuantityCode PoundAvoirdupoisPerMinute => new() { Value = "K78" };

    /// <summary>
    /// pound (avoirdupois) per minute degree Fahrenheit
    /// </summary>
    public static QuantityCode PoundAvoirdupoisPerMinuteDegreeFahrenheit => new() { Value = "K79" };

    /// <summary>
    /// pound (avoirdupois) per minute psi
    /// </summary>
    public static QuantityCode PoundAvoirdupoisPerMinutePsi => new() { Value = "K80" };

    /// <summary>
    /// pound (avoirdupois) per second
    /// </summary>
    public static QuantityCode PoundAvoirdupoisPerSecond => new() { Value = "K81" };

    /// <summary>
    /// pound (avoirdupois) per second degree Fahrenheit
    /// </summary>
    public static QuantityCode PoundAvoirdupoisPerSecondDegreeFahrenheit => new() { Value = "K82" };

    /// <summary>
    /// pound (avoirdupois) per second psi
    /// </summary>
    public static QuantityCode PoundAvoirdupoisPerSecondPsi => new() { Value = "K83" };

    /// <summary>
    /// pound per cubic yard
    /// </summary>
    public static QuantityCode PoundPerCubicYard => new() { Value = "K84" };

    /// <summary>
    /// pound-force per square foot
    /// </summary>
    public static QuantityCode PoundForcePerSquareFoot => new() { Value = "K85" };

    /// <summary>
    /// pound-force per square inch degree Fahrenheit
    /// </summary>
    public static QuantityCode PoundForcePerSquareInchDegreeFahrenheit => new() { Value = "K86" };

    /// <summary>
    /// psi cubic inch per second
    /// </summary>
    public static QuantityCode PsiCubicInchPerSecond => new() { Value = "K87" };

    /// <summary>
    /// psi litre per second
    /// </summary>
    public static QuantityCode PsiLitrePerSecond => new() { Value = "K88" };

    /// <summary>
    /// psi cubic metre per second
    /// </summary>
    public static QuantityCode PsiCubicMetrePerSecond => new() { Value = "K89" };

    /// <summary>
    /// psi cubic yard per second
    /// </summary>
    public static QuantityCode PsiCubicYardPerSecond => new() { Value = "K90" };

    /// <summary>
    /// pound-force second per square foot
    /// </summary>
    public static QuantityCode PoundForceSecondPerSquareFoot => new() { Value = "K91" };

    /// <summary>
    /// pound-force second per square inch
    /// </summary>
    public static QuantityCode PoundForceSecondPerSquareInch => new() { Value = "K92" };

    /// <summary>
    /// reciprocal psi
    /// </summary>
    public static QuantityCode ReciprocalPsi => new() { Value = "K93" };

    /// <summary>
    /// quart (UK liquid) per day
    /// </summary>
    public static QuantityCode QuartUKLiquidPerDay => new() { Value = "K94" };

    /// <summary>
    /// quart (UK liquid) per hour
    /// </summary>
    public static QuantityCode QuartUKLiquidPerHour => new() { Value = "K95" };

    /// <summary>
    /// quart (UK liquid) per minute
    /// </summary>
    public static QuantityCode QuartUKLiquidPerMinute => new() { Value = "K96" };

    /// <summary>
    /// quart (UK liquid) per second
    /// </summary>
    public static QuantityCode QuartUKLiquidPerSecond => new() { Value = "K97" };

    /// <summary>
    /// quart (US liquid) per day
    /// </summary>
    public static QuantityCode QuartUSLiquidPerDay => new() { Value = "K98" };

    /// <summary>
    /// quart (US liquid) per hour
    /// </summary>
    public static QuantityCode QuartUSLiquidPerHour => new() { Value = "K99" };

    /// <summary>
    /// cake
    /// </summary>
    public static QuantityCode Cake => new() { Value = "KA" };

    /// <summary>
    /// katal
    /// </summary>
    public static QuantityCode Katal => new() { Value = "KAT" };

    /// <summary>
    /// kilocharacter
    /// </summary>
    public static QuantityCode Kilocharacter => new() { Value = "KB" };

    /// <summary>
    /// kilobar
    /// </summary>
    public static QuantityCode Kilobar => new() { Value = "KBA" };

    /// <summary>
    /// kilogram of choline chloride
    /// </summary>
    public static QuantityCode KilogramOfCholineChloride => new() { Value = "KCC" };

    /// <summary>
    /// kilogram drained net weight
    /// </summary>
    public static QuantityCode KilogramDrainedNetWeight => new() { Value = "KDW" };

    /// <summary>
    /// kelvin
    /// </summary>
    public static QuantityCode Kelvin => new() { Value = "KEL" };

    /// <summary>
    /// kilogram
    /// </summary>
    public static QuantityCode Kilogram => new() { Value = "KGM" };

    /// <summary>
    /// kilogram per second
    /// </summary>
    public static QuantityCode KilogramPerSecond => new() { Value = "KGS" };

    /// <summary>
    /// kilogram of hydrogen peroxide
    /// </summary>
    public static QuantityCode KilogramOfHydrogenPeroxide => new() { Value = "KHY" };

    /// <summary>
    /// kilohertz
    /// </summary>
    public static QuantityCode Kilohertz => new() { Value = "KHZ" };

    /// <summary>
    /// kilogram per millimetre width
    /// </summary>
    public static QuantityCode KilogramPerMillimetreWidth => new() { Value = "KI" };

    /// <summary>
    /// kilogram, including container
    /// </summary>
    public static QuantityCode KilogramIncludingContainer => new() { Value = "KIC" };

    /// <summary>
    /// kilogram, including inner packaging
    /// </summary>
    public static QuantityCode KilogramIncludingInnerPackaging => new() { Value = "KIP" };

    /// <summary>
    /// kilosegment
    /// </summary>
    public static QuantityCode Kilosegment => new() { Value = "KJ" };

    /// <summary>
    /// kilojoule
    /// </summary>
    public static QuantityCode Kilojoule => new() { Value = "KJO" };

    /// <summary>
    /// kilogram per metre
    /// </summary>
    public static QuantityCode KilogramPerMetre => new() { Value = "KL" };

    /// <summary>
    /// lactic dry material percentage
    /// </summary>
    public static QuantityCode LacticDryMaterialPercentage => new() { Value = "KLK" };

    /// <summary>
    /// kilolux
    /// </summary>
    public static QuantityCode Kilolux => new() { Value = "KLX" };

    /// <summary>
    /// kilogram of methylamine
    /// </summary>
    public static QuantityCode KilogramOfMethylamine => new() { Value = "KMA" };

    /// <summary>
    /// kilometre per hour
    /// </summary>
    public static QuantityCode KilometrePerHour => new() { Value = "KMH" };

    /// <summary>
    /// square kilometre
    /// </summary>
    public static QuantityCode SquareKilometre => new() { Value = "KMK" };

    /// <summary>
    /// kilogram per cubic metre
    /// </summary>
    public static QuantityCode KilogramPerCubicMetre => new() { Value = "KMQ" };

    /// <summary>
    /// kilometre
    /// </summary>
    public static QuantityCode Kilometre => new() { Value = "KMT" };

    /// <summary>
    /// kilogram of nitrogen
    /// </summary>
    public static QuantityCode KilogramOfNitrogen => new() { Value = "KNI" };

    /// <summary>
    /// kilonewton per square metre
    /// </summary>
    public static QuantityCode KilonewtonPerSquareMetre => new() { Value = "KNM" };

    /// <summary>
    /// kilogram named substance
    /// </summary>
    public static QuantityCode KilogramNamedSubstance => new() { Value = "KNS" };

    /// <summary>
    /// knot
    /// </summary>
    public static QuantityCode Knot => new() { Value = "KNT" };

    /// <summary>
    /// milliequivalence caustic potash per gram of product
    /// </summary>
    public static QuantityCode MilliequivalenceCausticPotashPerGramOfProduct => new() { Value = "KO" };

    /// <summary>
    /// kilopascal
    /// </summary>
    public static QuantityCode Kilopascal => new() { Value = "KPA" };

    /// <summary>
    /// kilogram of potassium hydroxide (caustic potash)
    /// </summary>
    public static QuantityCode KilogramOfPotassiumHydroxideCausticPotash => new() { Value = "KPH" };

    /// <summary>
    /// kilogram of potassium oxide
    /// </summary>
    public static QuantityCode KilogramOfPotassiumOxide => new() { Value = "KPO" };

    /// <summary>
    /// kilogram of phosphorus pentoxide (phosphoric anhydride)
    /// </summary>
    public static QuantityCode KilogramOfPhosphorusPentoxidePhosphoricAnhydride => new() { Value = "KPP" };

    /// <summary>
    /// kiloroentgen
    /// </summary>
    public static QuantityCode Kiloroentgen => new() { Value = "KR" };

    /// <summary>
    /// kilogram of substance 90 % dry
    /// </summary>
    public static QuantityCode KilogramOfSubstance90Dry => new() { Value = "KSD" };

    /// <summary>
    /// kilogram of sodium hydroxide (caustic soda)
    /// </summary>
    public static QuantityCode KilogramOfSodiumHydroxideCausticSoda => new() { Value = "KSH" };

    /// <summary>
    /// kit
    /// </summary>
    public static QuantityCode Kit => new() { Value = "KT" };

    /// <summary>
    /// kilotonne
    /// </summary>
    public static QuantityCode Kilotonne => new() { Value = "KTN" };

    /// <summary>
    /// kilogram of uranium
    /// </summary>
    public static QuantityCode KilogramOfUranium => new() { Value = "KUR" };

    /// <summary>
    /// kilovolt - ampere
    /// </summary>
    public static QuantityCode KilovoltAmpere => new() { Value = "KVA" };

    /// <summary>
    /// kilovar
    /// </summary>
    public static QuantityCode Kilovar => new() { Value = "KVR" };

    /// <summary>
    /// kilovolt
    /// </summary>
    public static QuantityCode Kilovolt => new() { Value = "KVT" };

    /// <summary>
    /// kilogram per millimetre
    /// </summary>
    public static QuantityCode KilogramPerMillimetre => new() { Value = "KW" };

    /// <summary>
    /// kilowatt hour
    /// </summary>
    public static QuantityCode KilowattHour => new() { Value = "KWH" };

    /// <summary>
    /// Kilowatt hour per normalized cubic metre
    /// </summary>
    public static QuantityCode KilowattHourPerNormalizedCubicMetre => new() { Value = "KWN" };

    /// <summary>
    /// kilogram of tungsten trioxide
    /// </summary>
    public static QuantityCode KilogramOfTungstenTrioxide => new() { Value = "KWO" };

    /// <summary>
    /// Kilowatt hour per standard cubic metre
    /// </summary>
    public static QuantityCode KilowattHourPerStandardCubicMetre => new() { Value = "KWS" };

    /// <summary>
    /// kilowatt
    /// </summary>
    public static QuantityCode Kilowatt => new() { Value = "KWT" };

    /// <summary>
    /// kilowatt year
    /// </summary>
    public static QuantityCode KilowattYear => new() { Value = "KWY" };

    /// <summary>
    /// millilitre per kilogram
    /// </summary>
    public static QuantityCode MillilitrePerKilogram => new() { Value = "KX" };

    /// <summary>
    /// quart (US liquid) per minute
    /// </summary>
    public static QuantityCode QuartUSLiquidPerMinute => new() { Value = "L10" };

    /// <summary>
    /// quart (US liquid) per second
    /// </summary>
    public static QuantityCode QuartUSLiquidPerSecond => new() { Value = "L11" };

    /// <summary>
    /// metre per second kelvin
    /// </summary>
    public static QuantityCode MetrePerSecondKelvin => new() { Value = "L12" };

    /// <summary>
    /// metre per second bar
    /// </summary>
    public static QuantityCode MetrePerSecondBar => new() { Value = "L13" };

    /// <summary>
    /// square metre hour degree Celsius per kilocalorie (international table)
    /// </summary>
    public static QuantityCode SquareMetreHourDegreeCelsiusPerKilocalorieInternationalTable => new() { Value = "L14" };

    /// <summary>
    /// millipascal second per kelvin
    /// </summary>
    public static QuantityCode MillipascalSecondPerKelvin => new() { Value = "L15" };

    /// <summary>
    /// millipascal second per bar
    /// </summary>
    public static QuantityCode MillipascalSecondPerBar => new() { Value = "L16" };

    /// <summary>
    /// milligram per cubic metre kelvin
    /// </summary>
    public static QuantityCode MilligramPerCubicMetreKelvin => new() { Value = "L17" };

    /// <summary>
    /// milligram per cubic metre bar
    /// </summary>
    public static QuantityCode MilligramPerCubicMetreBar => new() { Value = "L18" };

    /// <summary>
    /// millilitre per litre
    /// </summary>
    public static QuantityCode MillilitrePerLitre => new() { Value = "L19" };

    /// <summary>
    /// litre per minute
    /// </summary>
    public static QuantityCode LitrePerMinute => new() { Value = "L2" };

    /// <summary>
    /// reciprocal cubic millimetre
    /// </summary>
    public static QuantityCode ReciprocalCubicMillimetre => new() { Value = "L20" };

    /// <summary>
    /// cubic millimetre per cubic metre
    /// </summary>
    public static QuantityCode CubicMillimetrePerCubicMetre => new() { Value = "L21" };

    /// <summary>
    /// mole per hour
    /// </summary>
    public static QuantityCode MolePerHour => new() { Value = "L23" };

    /// <summary>
    /// mole per kilogram kelvin
    /// </summary>
    public static QuantityCode MolePerKilogramKelvin => new() { Value = "L24" };

    /// <summary>
    /// mole per kilogram bar
    /// </summary>
    public static QuantityCode MolePerKilogramBar => new() { Value = "L25" };

    /// <summary>
    /// mole per litre kelvin
    /// </summary>
    public static QuantityCode MolePerLitreKelvin => new() { Value = "L26" };

    /// <summary>
    /// mole per litre bar
    /// </summary>
    public static QuantityCode MolePerLitreBar => new() { Value = "L27" };

    /// <summary>
    /// mole per cubic metre kelvin
    /// </summary>
    public static QuantityCode MolePerCubicMetreKelvin => new() { Value = "L28" };

    /// <summary>
    /// mole per cubic metre bar
    /// </summary>
    public static QuantityCode MolePerCubicMetreBar => new() { Value = "L29" };

    /// <summary>
    /// mole per minute
    /// </summary>
    public static QuantityCode MolePerMinute => new() { Value = "L30" };

    /// <summary>
    /// milliroentgen aequivalent men
    /// </summary>
    public static QuantityCode MilliroentgenAequivalentMen => new() { Value = "L31" };

    /// <summary>
    /// nanogram per kilogram
    /// </summary>
    public static QuantityCode NanogramPerKilogram => new() { Value = "L32" };

    /// <summary>
    /// ounce (avoirdupois) per day
    /// </summary>
    public static QuantityCode OunceAvoirdupoisPerDay => new() { Value = "L33" };

    /// <summary>
    /// ounce (avoirdupois) per hour
    /// </summary>
    public static QuantityCode OunceAvoirdupoisPerHour => new() { Value = "L34" };

    /// <summary>
    /// ounce (avoirdupois) per minute
    /// </summary>
    public static QuantityCode OunceAvoirdupoisPerMinute => new() { Value = "L35" };

    /// <summary>
    /// ounce (avoirdupois) per second
    /// </summary>
    public static QuantityCode OunceAvoirdupoisPerSecond => new() { Value = "L36" };

    /// <summary>
    /// ounce (avoirdupois) per gallon (UK)
    /// </summary>
    public static QuantityCode OunceAvoirdupoisPerGallonUK => new() { Value = "L37" };

    /// <summary>
    /// ounce (avoirdupois) per gallon (US)
    /// </summary>
    public static QuantityCode OunceAvoirdupoisPerGallonUS => new() { Value = "L38" };

    /// <summary>
    /// ounce (avoirdupois) per cubic inch
    /// </summary>
    public static QuantityCode OunceAvoirdupoisPerCubicInch => new() { Value = "L39" };

    /// <summary>
    /// ounce (avoirdupois)-force
    /// </summary>
    public static QuantityCode OunceAvoirdupoisForce => new() { Value = "L40" };

    /// <summary>
    /// ounce (avoirdupois)-force inch
    /// </summary>
    public static QuantityCode OunceAvoirdupoisForceInch => new() { Value = "L41" };

    /// <summary>
    /// picosiemens per metre
    /// </summary>
    public static QuantityCode PicosiemensPerMetre => new() { Value = "L42" };

    /// <summary>
    /// peck (UK)
    /// </summary>
    public static QuantityCode PeckUK => new() { Value = "L43" };

    /// <summary>
    /// peck (UK) per day
    /// </summary>
    public static QuantityCode PeckUKPerDay => new() { Value = "L44" };

    /// <summary>
    /// peck (UK) per hour
    /// </summary>
    public static QuantityCode PeckUKPerHour => new() { Value = "L45" };

    /// <summary>
    /// peck (UK) per minute
    /// </summary>
    public static QuantityCode PeckUKPerMinute => new() { Value = "L46" };

    /// <summary>
    /// peck (UK) per second
    /// </summary>
    public static QuantityCode PeckUKPerSecond => new() { Value = "L47" };

    /// <summary>
    /// peck (US dry) per day
    /// </summary>
    public static QuantityCode PeckUSDryPerDay => new() { Value = "L48" };

    /// <summary>
    /// peck (US dry) per hour
    /// </summary>
    public static QuantityCode PeckUSDryPerHour => new() { Value = "L49" };

    /// <summary>
    /// peck (US dry) per minute
    /// </summary>
    public static QuantityCode PeckUSDryPerMinute => new() { Value = "L50" };

    /// <summary>
    /// peck (US dry) per second
    /// </summary>
    public static QuantityCode PeckUSDryPerSecond => new() { Value = "L51" };

    /// <summary>
    /// psi per psi
    /// </summary>
    public static QuantityCode PsiPerPsi => new() { Value = "L52" };

    /// <summary>
    /// pint (UK) per day
    /// </summary>
    public static QuantityCode PintUKPerDay => new() { Value = "L53" };

    /// <summary>
    /// pint (UK) per hour
    /// </summary>
    public static QuantityCode PintUKPerHour => new() { Value = "L54" };

    /// <summary>
    /// pint (UK) per minute
    /// </summary>
    public static QuantityCode PintUKPerMinute => new() { Value = "L55" };

    /// <summary>
    /// pint (UK) per second
    /// </summary>
    public static QuantityCode PintUKPerSecond => new() { Value = "L56" };

    /// <summary>
    /// pint (US liquid) per day
    /// </summary>
    public static QuantityCode PintUSLiquidPerDay => new() { Value = "L57" };

    /// <summary>
    /// pint (US liquid) per hour
    /// </summary>
    public static QuantityCode PintUSLiquidPerHour => new() { Value = "L58" };

    /// <summary>
    /// pint (US liquid) per minute
    /// </summary>
    public static QuantityCode PintUSLiquidPerMinute => new() { Value = "L59" };

    /// <summary>
    /// pint (US liquid) per second
    /// </summary>
    public static QuantityCode PintUSLiquidPerSecond => new() { Value = "L60" };

    /// <summary>
    /// slug per day
    /// </summary>
    public static QuantityCode SlugPerDay => new() { Value = "L63" };

    /// <summary>
    /// slug per foot second
    /// </summary>
    public static QuantityCode SlugPerFootSecond => new() { Value = "L64" };

    /// <summary>
    /// slug per cubic foot
    /// </summary>
    public static QuantityCode SlugPerCubicFoot => new() { Value = "L65" };

    /// <summary>
    /// slug per hour
    /// </summary>
    public static QuantityCode SlugPerHour => new() { Value = "L66" };

    /// <summary>
    /// slug per minute
    /// </summary>
    public static QuantityCode SlugPerMinute => new() { Value = "L67" };

    /// <summary>
    /// slug per second
    /// </summary>
    public static QuantityCode SlugPerSecond => new() { Value = "L68" };

    /// <summary>
    /// tonne per kelvin
    /// </summary>
    public static QuantityCode TonnePerKelvin => new() { Value = "L69" };

    /// <summary>
    /// tonne per bar
    /// </summary>
    public static QuantityCode TonnePerBar => new() { Value = "L70" };

    /// <summary>
    /// tonne per day
    /// </summary>
    public static QuantityCode TonnePerDay => new() { Value = "L71" };

    /// <summary>
    /// tonne per day kelvin
    /// </summary>
    public static QuantityCode TonnePerDayKelvin => new() { Value = "L72" };

    /// <summary>
    /// tonne per day bar
    /// </summary>
    public static QuantityCode TonnePerDayBar => new() { Value = "L73" };

    /// <summary>
    /// tonne per hour kelvin
    /// </summary>
    public static QuantityCode TonnePerHourKelvin => new() { Value = "L74" };

    /// <summary>
    /// tonne per hour bar
    /// </summary>
    public static QuantityCode TonnePerHourBar => new() { Value = "L75" };

    /// <summary>
    /// tonne per cubic metre kelvin
    /// </summary>
    public static QuantityCode TonnePerCubicMetreKelvin => new() { Value = "L76" };

    /// <summary>
    /// tonne per cubic metre bar
    /// </summary>
    public static QuantityCode TonnePerCubicMetreBar => new() { Value = "L77" };

    /// <summary>
    /// tonne per minute
    /// </summary>
    public static QuantityCode TonnePerMinute => new() { Value = "L78" };

    /// <summary>
    /// tonne per minute kelvin
    /// </summary>
    public static QuantityCode TonnePerMinuteKelvin => new() { Value = "L79" };

    /// <summary>
    /// tonne per minute bar
    /// </summary>
    public static QuantityCode TonnePerMinuteBar => new() { Value = "L80" };

    /// <summary>
    /// tonne per second
    /// </summary>
    public static QuantityCode TonnePerSecond => new() { Value = "L81" };

    /// <summary>
    /// tonne per second kelvin
    /// </summary>
    public static QuantityCode TonnePerSecondKelvin => new() { Value = "L82" };

    /// <summary>
    /// tonne per second bar
    /// </summary>
    public static QuantityCode TonnePerSecondBar => new() { Value = "L83" };

    /// <summary>
    /// ton (UK shipping)
    /// </summary>
    public static QuantityCode TonUKShipping => new() { Value = "L84" };

    /// <summary>
    /// ton long per day
    /// </summary>
    public static QuantityCode TonLongPerDay => new() { Value = "L85" };

    /// <summary>
    /// ton (US shipping)
    /// </summary>
    public static QuantityCode TonUSShipping => new() { Value = "L86" };

    /// <summary>
    /// ton short per degree Fahrenheit
    /// </summary>
    public static QuantityCode TonShortPerDegreeFahrenheit => new() { Value = "L87" };

    /// <summary>
    /// ton short per day
    /// </summary>
    public static QuantityCode TonShortPerDay => new() { Value = "L88" };

    /// <summary>
    /// ton short per hour degree Fahrenheit
    /// </summary>
    public static QuantityCode TonShortPerHourDegreeFahrenheit => new() { Value = "L89" };

    /// <summary>
    /// ton short per hour psi
    /// </summary>
    public static QuantityCode TonShortPerHourPsi => new() { Value = "L90" };

    /// <summary>
    /// ton short per psi
    /// </summary>
    public static QuantityCode TonShortPerPsi => new() { Value = "L91" };

    /// <summary>
    /// ton (UK long) per cubic yard
    /// </summary>
    public static QuantityCode TonUKLongPerCubicYard => new() { Value = "L92" };

    /// <summary>
    /// ton (US short) per cubic yard
    /// </summary>
    public static QuantityCode TonUSShortPerCubicYard => new() { Value = "L93" };

    /// <summary>
    /// ton-force (US short)
    /// </summary>
    public static QuantityCode TonForceUSShort => new() { Value = "L94" };

    /// <summary>
    /// common year
    /// </summary>
    public static QuantityCode CommonYear => new() { Value = "L95" };

    /// <summary>
    /// sidereal year
    /// </summary>
    public static QuantityCode SiderealYear => new() { Value = "L96" };

    /// <summary>
    /// yard per degree Fahrenheit
    /// </summary>
    public static QuantityCode YardPerDegreeFahrenheit => new() { Value = "L98" };

    /// <summary>
    /// yard per psi
    /// </summary>
    public static QuantityCode YardPerPsi => new() { Value = "L99" };

    /// <summary>
    /// pound per cubic inch
    /// </summary>
    public static QuantityCode PoundPerCubicInch => new() { Value = "LA" };

    /// <summary>
    /// lactose excess percentage
    /// </summary>
    public static QuantityCode LactoseExcessPercentage => new() { Value = "LAC" };

    /// <summary>
    /// pound
    /// </summary>
    public static QuantityCode Pound => new() { Value = "LBR" };

    /// <summary>
    /// troy pound (US)
    /// </summary>
    public static QuantityCode TroyPoundUS => new() { Value = "LBT" };

    /// <summary>
    /// litre per day
    /// </summary>
    public static QuantityCode LitrePerDay => new() { Value = "LD" };

    /// <summary>
    /// leaf
    /// </summary>
    public static QuantityCode Leaf => new() { Value = "LEF" };

    /// <summary>
    /// linear foot
    /// </summary>
    public static QuantityCode LinearFoot => new() { Value = "LF" };

    /// <summary>
    /// labour hour
    /// </summary>
    public static QuantityCode LabourHour => new() { Value = "LH" };

    /// <summary>
    /// link
    /// </summary>
    public static QuantityCode Link => new() { Value = "LK" };

    /// <summary>
    /// linear metre
    /// </summary>
    public static QuantityCode LinearMetre => new() { Value = "LM" };

    /// <summary>
    /// length
    /// </summary>
    public static QuantityCode Length => new() { Value = "LN" };

    /// <summary>
    /// lot [unit of procurement]
    /// </summary>
    public static QuantityCode LotUnitOfProcurement => new() { Value = "LO" };

    /// <summary>
    /// liquid pound
    /// </summary>
    public static QuantityCode LiquidPound => new() { Value = "LP" };

    /// <summary>
    /// litre of pure alcohol
    /// </summary>
    public static QuantityCode LitreOfPureAlcohol => new() { Value = "LPA" };

    /// <summary>
    /// layer
    /// </summary>
    public static QuantityCode Layer => new() { Value = "LR" };

    /// <summary>
    /// lump sum
    /// </summary>
    public static QuantityCode LumpSum => new() { Value = "LS" };

    /// <summary>
    /// ton (UK) or long ton (US)
    /// </summary>
    public static QuantityCode TonUKOrLongTonUS => new() { Value = "LTN" };

    /// <summary>
    /// litre
    /// </summary>
    public static QuantityCode Litre => new() { Value = "LTR" };

    /// <summary>
    /// metric ton, lubricating oil
    /// </summary>
    public static QuantityCode MetricTonLubricatingOil => new() { Value = "LUB" };

    /// <summary>
    /// lumen
    /// </summary>
    public static QuantityCode Lumen => new() { Value = "LUM" };

    /// <summary>
    /// lux
    /// </summary>
    public static QuantityCode Lux => new() { Value = "LUX" };

    /// <summary>
    /// linear yard
    /// </summary>
    public static QuantityCode LinearYard => new() { Value = "LY" };

    /// <summary>
    /// milligram per litre
    /// </summary>
    public static QuantityCode MilligramPerLitre => new() { Value = "M1" };

    /// <summary>
    /// reciprocal cubic yard
    /// </summary>
    public static QuantityCode ReciprocalCubicYard => new() { Value = "M10" };

    /// <summary>
    /// cubic yard per degree Fahrenheit
    /// </summary>
    public static QuantityCode CubicYardPerDegreeFahrenheit => new() { Value = "M11" };

    /// <summary>
    /// cubic yard per day
    /// </summary>
    public static QuantityCode CubicYardPerDay => new() { Value = "M12" };

    /// <summary>
    /// cubic yard per hour
    /// </summary>
    public static QuantityCode CubicYardPerHour => new() { Value = "M13" };

    /// <summary>
    /// cubic yard per psi
    /// </summary>
    public static QuantityCode CubicYardPerPsi => new() { Value = "M14" };

    /// <summary>
    /// cubic yard per minute
    /// </summary>
    public static QuantityCode CubicYardPerMinute => new() { Value = "M15" };

    /// <summary>
    /// cubic yard per second
    /// </summary>
    public static QuantityCode CubicYardPerSecond => new() { Value = "M16" };

    /// <summary>
    /// kilohertz metre
    /// </summary>
    public static QuantityCode KilohertzMetre => new() { Value = "M17" };

    /// <summary>
    /// gigahertz metre
    /// </summary>
    public static QuantityCode GigahertzMetre => new() { Value = "M18" };

    /// <summary>
    /// Beaufort
    /// </summary>
    public static QuantityCode Beaufort => new() { Value = "M19" };

    /// <summary>
    /// reciprocal megakelvin or megakelvin to the power minus one
    /// </summary>
    public static QuantityCode ReciprocalMegakelvinOrMegakelvinToThePowerMinusOne => new() { Value = "M20" };

    /// <summary>
    /// reciprocal kilovolt - ampere reciprocal hour
    /// </summary>
    public static QuantityCode ReciprocalKilovoltAmpereReciprocalHour => new() { Value = "M21" };

    /// <summary>
    /// millilitre per square centimetre minute
    /// </summary>
    public static QuantityCode MillilitrePerSquareCentimetreMinute => new() { Value = "M22" };

    /// <summary>
    /// newton per centimetre
    /// </summary>
    public static QuantityCode NewtonPerCentimetre => new() { Value = "M23" };

    /// <summary>
    /// ohm kilometre
    /// </summary>
    public static QuantityCode OhmKilometre => new() { Value = "M24" };

    /// <summary>
    /// percent per degree Celsius
    /// </summary>
    public static QuantityCode PercentPerDegreeCelsius => new() { Value = "M25" };

    /// <summary>
    /// gigaohm per metre
    /// </summary>
    public static QuantityCode GigaohmPerMetre => new() { Value = "M26" };

    /// <summary>
    /// megahertz metre
    /// </summary>
    public static QuantityCode MegahertzMetre => new() { Value = "M27" };

    /// <summary>
    /// kilogram per kilogram
    /// </summary>
    public static QuantityCode KilogramPerKilogram => new() { Value = "M29" };

    /// <summary>
    /// reciprocal volt - ampere reciprocal second
    /// </summary>
    public static QuantityCode ReciprocalVoltAmpereReciprocalSecond => new() { Value = "M30" };

    /// <summary>
    /// kilogram per kilometre
    /// </summary>
    public static QuantityCode KilogramPerKilometre => new() { Value = "M31" };

    /// <summary>
    /// pascal second per litre
    /// </summary>
    public static QuantityCode PascalSecondPerLitre => new() { Value = "M32" };

    /// <summary>
    /// millimole per litre
    /// </summary>
    public static QuantityCode MillimolePerLitre => new() { Value = "M33" };

    /// <summary>
    /// newton metre per square metre
    /// </summary>
    public static QuantityCode NewtonMetrePerSquareMetre => new() { Value = "M34" };

    /// <summary>
    /// millivolt - ampere
    /// </summary>
    public static QuantityCode MillivoltAmpere => new() { Value = "M35" };

    /// <summary>
    /// 30-day month
    /// </summary>
    public static QuantityCode Code30DayMonth => new() { Value = "M36" };

    /// <summary>
    /// actual/360
    /// </summary>
    public static QuantityCode Actual360 => new() { Value = "M37" };

    /// <summary>
    /// kilometre per second squared
    /// </summary>
    public static QuantityCode KilometrePerSecondSquared => new() { Value = "M38" };

    /// <summary>
    /// centimetre per second squared
    /// </summary>
    public static QuantityCode CentimetrePerSecondSquared => new() { Value = "M39" };

    /// <summary>
    /// monetary value
    /// </summary>
    public static QuantityCode MonetaryValue => new() { Value = "M4" };

    /// <summary>
    /// yard per second squared
    /// </summary>
    public static QuantityCode YardPerSecondSquared => new() { Value = "M40" };

    /// <summary>
    /// millimetre per second squared
    /// </summary>
    public static QuantityCode MillimetrePerSecondSquared => new() { Value = "M41" };

    /// <summary>
    /// mile (statute mile) per second squared
    /// </summary>
    public static QuantityCode MileStatuteMilePerSecondSquared => new() { Value = "M42" };

    /// <summary>
    /// mil
    /// </summary>
    public static QuantityCode Mil => new() { Value = "M43" };

    /// <summary>
    /// revolution
    /// </summary>
    public static QuantityCode Revolution => new() { Value = "M44" };

    /// <summary>
    /// degree [unit of angle] per second squared
    /// </summary>
    public static QuantityCode DegreeUnitOfAnglePerSecondSquared => new() { Value = "M45" };

    /// <summary>
    /// revolution per minute
    /// </summary>
    public static QuantityCode RevolutionPerMinute => new() { Value = "M46" };

    /// <summary>
    /// circular mil
    /// </summary>
    public static QuantityCode CircularMil => new() { Value = "M47" };

    /// <summary>
    /// square mile (based on U.S. survey foot)
    /// </summary>
    public static QuantityCode SquareMileBasedOnUSSurveyFoot => new() { Value = "M48" };

    /// <summary>
    /// chain (based on U.S. survey foot)
    /// </summary>
    public static QuantityCode ChainBasedOnUSSurveyFoot => new() { Value = "M49" };

    /// <summary>
    /// microcurie
    /// </summary>
    public static QuantityCode Microcurie => new() { Value = "M5" };

    /// <summary>
    /// furlong
    /// </summary>
    public static QuantityCode Furlong => new() { Value = "M50" };

    /// <summary>
    /// foot (U.S. survey)
    /// </summary>
    public static QuantityCode FootUSSurvey => new() { Value = "M51" };

    /// <summary>
    /// mile (based on U.S. survey foot)
    /// </summary>
    public static QuantityCode MileBasedOnUSSurveyFoot => new() { Value = "M52" };

    /// <summary>
    /// metre per pascal
    /// </summary>
    public static QuantityCode MetrePerPascal => new() { Value = "M53" };

    /// <summary>
    /// metre per radiant
    /// </summary>
    public static QuantityCode MetrePerRadiant => new() { Value = "M55" };

    /// <summary>
    /// shake
    /// </summary>
    public static QuantityCode Shake => new() { Value = "M56" };

    /// <summary>
    /// mile per minute
    /// </summary>
    public static QuantityCode MilePerMinute => new() { Value = "M57" };

    /// <summary>
    /// mile per second
    /// </summary>
    public static QuantityCode MilePerSecond => new() { Value = "M58" };

    /// <summary>
    /// metre per second pascal
    /// </summary>
    public static QuantityCode MetrePerSecondPascal => new() { Value = "M59" };

    /// <summary>
    /// metre per hour
    /// </summary>
    public static QuantityCode MetrePerHour => new() { Value = "M60" };

    /// <summary>
    /// inch per year
    /// </summary>
    public static QuantityCode InchPerYear => new() { Value = "M61" };

    /// <summary>
    /// kilometre per second
    /// </summary>
    public static QuantityCode KilometrePerSecond => new() { Value = "M62" };

    /// <summary>
    /// inch per minute
    /// </summary>
    public static QuantityCode InchPerMinute => new() { Value = "M63" };

    /// <summary>
    /// yard per second
    /// </summary>
    public static QuantityCode YardPerSecond => new() { Value = "M64" };

    /// <summary>
    /// yard per minute
    /// </summary>
    public static QuantityCode YardPerMinute => new() { Value = "M65" };

    /// <summary>
    /// yard per hour
    /// </summary>
    public static QuantityCode YardPerHour => new() { Value = "M66" };

    /// <summary>
    /// acre-foot (based on U.S. survey foot)
    /// </summary>
    public static QuantityCode AcreFootBasedOnUSSurveyFoot => new() { Value = "M67" };

    /// <summary>
    /// cord (128 ft3)
    /// </summary>
    public static QuantityCode Cord128Ft3 => new() { Value = "M68" };

    /// <summary>
    /// cubic mile (UK statute)
    /// </summary>
    public static QuantityCode CubicMileUKStatute => new() { Value = "M69" };

    /// <summary>
    /// micro-inch
    /// </summary>
    public static QuantityCode MicroInch => new() { Value = "M7" };

    /// <summary>
    /// ton, register
    /// </summary>
    public static QuantityCode TonRegister => new() { Value = "M70" };

    /// <summary>
    /// cubic metre per pascal
    /// </summary>
    public static QuantityCode CubicMetrePerPascal => new() { Value = "M71" };

    /// <summary>
    /// bel
    /// </summary>
    public static QuantityCode Bel => new() { Value = "M72" };

    /// <summary>
    /// kilogram per cubic metre pascal
    /// </summary>
    public static QuantityCode KilogramPerCubicMetrePascal => new() { Value = "M73" };

    /// <summary>
    /// kilogram per pascal
    /// </summary>
    public static QuantityCode KilogramPerPascal => new() { Value = "M74" };

    /// <summary>
    /// kilopound-force
    /// </summary>
    public static QuantityCode KilopoundForce => new() { Value = "M75" };

    /// <summary>
    /// poundal
    /// </summary>
    public static QuantityCode Poundal => new() { Value = "M76" };

    /// <summary>
    /// kilogram metre per second squared
    /// </summary>
    public static QuantityCode KilogramMetrePerSecondSquared => new() { Value = "M77" };

    /// <summary>
    /// pond
    /// </summary>
    public static QuantityCode Pond => new() { Value = "M78" };

    /// <summary>
    /// square foot per hour
    /// </summary>
    public static QuantityCode SquareFootPerHour => new() { Value = "M79" };

    /// <summary>
    /// stokes per pascal
    /// </summary>
    public static QuantityCode StokesPerPascal => new() { Value = "M80" };

    /// <summary>
    /// square centimetre per second
    /// </summary>
    public static QuantityCode SquareCentimetrePerSecond => new() { Value = "M81" };

    /// <summary>
    /// square metre per second pascal
    /// </summary>
    public static QuantityCode SquareMetrePerSecondPascal => new() { Value = "M82" };

    /// <summary>
    /// denier
    /// </summary>
    public static QuantityCode DenierM83 => new() { Value = "M83" };

    /// <summary>
    /// pound per yard
    /// </summary>
    public static QuantityCode PoundPerYard => new() { Value = "M84" };

    /// <summary>
    /// ton, assay
    /// </summary>
    public static QuantityCode TonAssay => new() { Value = "M85" };

    /// <summary>
    /// pfund
    /// </summary>
    public static QuantityCode Pfund => new() { Value = "M86" };

    /// <summary>
    /// kilogram per second pascal
    /// </summary>
    public static QuantityCode KilogramPerSecondPascal => new() { Value = "M87" };

    /// <summary>
    /// tonne per month
    /// </summary>
    public static QuantityCode TonnePerMonth => new() { Value = "M88" };

    /// <summary>
    /// tonne per year
    /// </summary>
    public static QuantityCode TonnePerYear => new() { Value = "M89" };

    /// <summary>
    /// million Btu per 1000 cubic foot
    /// </summary>
    public static QuantityCode MillionBtuPer1000CubicFoot => new() { Value = "M9" };

    /// <summary>
    /// kilopound per hour
    /// </summary>
    public static QuantityCode KilopoundPerHour => new() { Value = "M90" };

    /// <summary>
    /// pound per pound
    /// </summary>
    public static QuantityCode PoundPerPound => new() { Value = "M91" };

    /// <summary>
    /// pound-force foot
    /// </summary>
    public static QuantityCode PoundForceFoot => new() { Value = "M92" };

    /// <summary>
    /// newton metre per radian
    /// </summary>
    public static QuantityCode NewtonMetrePerRadian => new() { Value = "M93" };

    /// <summary>
    /// kilogram metre
    /// </summary>
    public static QuantityCode KilogramMetre => new() { Value = "M94" };

    /// <summary>
    /// poundal foot
    /// </summary>
    public static QuantityCode PoundalFoot => new() { Value = "M95" };

    /// <summary>
    /// poundal inch
    /// </summary>
    public static QuantityCode PoundalInch => new() { Value = "M96" };

    /// <summary>
    /// dyne metre
    /// </summary>
    public static QuantityCode DyneMetre => new() { Value = "M97" };

    /// <summary>
    /// kilogram centimetre per second
    /// </summary>
    public static QuantityCode KilogramCentimetrePerSecond => new() { Value = "M98" };

    /// <summary>
    /// gram centimetre per second
    /// </summary>
    public static QuantityCode GramCentimetrePerSecond => new() { Value = "M99" };

    /// <summary>
    /// megavolt ampere reactive hour
    /// </summary>
    public static QuantityCode MegavoltAmpereReactiveHour => new() { Value = "MAH" };

    /// <summary>
    /// megalitre
    /// </summary>
    public static QuantityCode Megalitre => new() { Value = "MAL" };

    /// <summary>
    /// megametre
    /// </summary>
    public static QuantityCode Megametre => new() { Value = "MAM" };

    /// <summary>
    /// megavar
    /// </summary>
    public static QuantityCode Megavar => new() { Value = "MAR" };

    /// <summary>
    /// megawatt
    /// </summary>
    public static QuantityCode Megawatt => new() { Value = "MAW" };

    /// <summary>
    /// thousand standard brick equivalent
    /// </summary>
    public static QuantityCode ThousandStandardBrickEquivalent => new() { Value = "MBE" };

    /// <summary>
    /// thousand board foot
    /// </summary>
    public static QuantityCode ThousandBoardFoot => new() { Value = "MBF" };

    /// <summary>
    /// millibar
    /// </summary>
    public static QuantityCode Millibar => new() { Value = "MBR" };

    /// <summary>
    /// microgram
    /// </summary>
    public static QuantityCode Microgram => new() { Value = "MC" };

    /// <summary>
    /// millicurie
    /// </summary>
    public static QuantityCode Millicurie => new() { Value = "MCU" };

    /// <summary>
    /// air dry metric ton
    /// </summary>
    public static QuantityCode AirDryMetricTon => new() { Value = "MD" };

    /// <summary>
    /// milligram
    /// </summary>
    public static QuantityCode Milligram => new() { Value = "MGM" };

    /// <summary>
    /// megahertz
    /// </summary>
    public static QuantityCode Megahertz => new() { Value = "MHZ" };

    /// <summary>
    /// square mile (statute mile)
    /// </summary>
    public static QuantityCode SquareMileStatuteMile => new() { Value = "MIK" };

    /// <summary>
    /// thousand
    /// </summary>
    public static QuantityCode Thousand => new() { Value = "MIL" };

    /// <summary>
    /// minute [unit of time]
    /// </summary>
    public static QuantityCode MinuteUnitOfTime => new() { Value = "MIN" };

    /// <summary>
    /// million
    /// </summary>
    public static QuantityCode Million => new() { Value = "MIO" };

    /// <summary>
    /// million international unit
    /// </summary>
    public static QuantityCode MillionInternationalUnit => new() { Value = "MIU" };

    /// <summary>
    /// Square Metre Day
    /// </summary>
    public static QuantityCode SquareMetreDay => new() { Value = "MKD" };

    /// <summary>
    /// Square Metre Month
    /// </summary>
    public static QuantityCode SquareMetreMonth => new() { Value = "MKM" };

    /// <summary>
    /// Square Metre Week
    /// </summary>
    public static QuantityCode SquareMetreWeek => new() { Value = "MKW" };

    /// <summary>
    /// milliard
    /// </summary>
    public static QuantityCode Milliard => new() { Value = "MLD" };

    /// <summary>
    /// millilitre
    /// </summary>
    public static QuantityCode Millilitre => new() { Value = "MLT" };

    /// <summary>
    /// square millimetre
    /// </summary>
    public static QuantityCode SquareMillimetre => new() { Value = "MMK" };

    /// <summary>
    /// cubic millimetre
    /// </summary>
    public static QuantityCode CubicMillimetre => new() { Value = "MMQ" };

    /// <summary>
    /// millimetre
    /// </summary>
    public static QuantityCode Millimetre => new() { Value = "MMT" };

    /// <summary>
    /// kilogram, dry weight
    /// </summary>
    public static QuantityCode KilogramDryWeight => new() { Value = "MND" };

    /// <summary>
    /// Mega Joule per Normalised cubic Metre
    /// </summary>
    public static QuantityCode MegaJoulePerNormalisedCubicMetre => new() { Value = "MNJ" };

    /// <summary>
    /// month
    /// </summary>
    public static QuantityCode Month => new() { Value = "MON" };

    /// <summary>
    /// megapascal
    /// </summary>
    public static QuantityCode Megapascal => new() { Value = "MPA" };

    /// <summary>
    /// Cubic Metre Day
    /// </summary>
    public static QuantityCode CubicMetreDay => new() { Value = "MQD" };

    /// <summary>
    /// cubic metre per hour
    /// </summary>
    public static QuantityCode CubicMetrePerHour => new() { Value = "MQH" };

    /// <summary>
    /// Cubic Metre Month
    /// </summary>
    public static QuantityCode CubicMetreMonth => new() { Value = "MQM" };

    /// <summary>
    /// cubic metre per second
    /// </summary>
    public static QuantityCode CubicMetrePerSecond => new() { Value = "MQS" };

    /// <summary>
    /// Cubic Metre Week
    /// </summary>
    public static QuantityCode CubicMetreWeek => new() { Value = "MQW" };

    /// <summary>
    /// Metre Day
    /// </summary>
    public static QuantityCode MetreDay => new() { Value = "MRD" };

    /// <summary>
    /// Metre Month
    /// </summary>
    public static QuantityCode MetreMonth => new() { Value = "MRM" };

    /// <summary>
    /// Metre Week
    /// </summary>
    public static QuantityCode MetreWeek => new() { Value = "MRW" };

    /// <summary>
    /// metre per second squared
    /// </summary>
    public static QuantityCode MetrePerSecondSquared => new() { Value = "MSK" };

    /// <summary>
    /// square metre
    /// </summary>
    public static QuantityCode SquareMetre => new() { Value = "MTK" };

    /// <summary>
    /// cubic metre
    /// </summary>
    public static QuantityCode CubicMetre => new() { Value = "MTQ" };

    /// <summary>
    /// metre
    /// </summary>
    public static QuantityCode Metre => new() { Value = "MTR" };

    /// <summary>
    /// metre per second
    /// </summary>
    public static QuantityCode MetrePerSecond => new() { Value = "MTS" };

    /// <summary>
    /// millihertz
    /// </summary>
    public static QuantityCode Millihertz => new() { Value = "MTZ" };

    /// <summary>
    /// megavolt - ampere
    /// </summary>
    public static QuantityCode MegavoltAmpere => new() { Value = "MVA" };

    /// <summary>
    /// megawatt hour (1000 kW.h)
    /// </summary>
    public static QuantityCode MegawattHour1000KWH => new() { Value = "MWH" };

    /// <summary>
    /// pen calorie
    /// </summary>
    public static QuantityCode PenCalorie => new() { Value = "N1" };

    /// <summary>
    /// pound foot per second
    /// </summary>
    public static QuantityCode PoundFootPerSecond => new() { Value = "N10" };

    /// <summary>
    /// pound inch per second
    /// </summary>
    public static QuantityCode PoundInchPerSecond => new() { Value = "N11" };

    /// <summary>
    /// Pferdestaerke
    /// </summary>
    public static QuantityCode Pferdestaerke => new() { Value = "N12" };

    /// <summary>
    /// centimetre of mercury (0 ºC)
    /// </summary>
    public static QuantityCode CentimetreOfMercury0C => new() { Value = "N13" };

    /// <summary>
    /// centimetre of water (4 ºC)
    /// </summary>
    public static QuantityCode CentimetreOfWater4C => new() { Value = "N14" };

    /// <summary>
    /// foot of water (39.2 ºF)
    /// </summary>
    public static QuantityCode FootOfWater392F => new() { Value = "N15" };

    /// <summary>
    /// inch of mercury (32 ºF)
    /// </summary>
    public static QuantityCode InchOfMercury32F => new() { Value = "N16" };

    /// <summary>
    /// inch of mercury (60 ºF)
    /// </summary>
    public static QuantityCode InchOfMercury60F => new() { Value = "N17" };

    /// <summary>
    /// inch of water (39.2 ºF)
    /// </summary>
    public static QuantityCode InchOfWater392F => new() { Value = "N18" };

    /// <summary>
    /// inch of water (60 ºF)
    /// </summary>
    public static QuantityCode InchOfWater60F => new() { Value = "N19" };

    /// <summary>
    /// kip per square inch
    /// </summary>
    public static QuantityCode KipPerSquareInch => new() { Value = "N20" };

    /// <summary>
    /// poundal per square foot
    /// </summary>
    public static QuantityCode PoundalPerSquareFoot => new() { Value = "N21" };

    /// <summary>
    /// ounce (avoirdupois) per square inch
    /// </summary>
    public static QuantityCode OunceAvoirdupoisPerSquareInch => new() { Value = "N22" };

    /// <summary>
    /// conventional metre of water
    /// </summary>
    public static QuantityCode ConventionalMetreOfWater => new() { Value = "N23" };

    /// <summary>
    /// gram per square millimetre
    /// </summary>
    public static QuantityCode GramPerSquareMillimetre => new() { Value = "N24" };

    /// <summary>
    /// pound per square yard
    /// </summary>
    public static QuantityCode PoundPerSquareYard => new() { Value = "N25" };

    /// <summary>
    /// poundal per square inch
    /// </summary>
    public static QuantityCode PoundalPerSquareInch => new() { Value = "N26" };

    /// <summary>
    /// foot to the fourth power
    /// </summary>
    public static QuantityCode FootToTheFourthPower => new() { Value = "N27" };

    /// <summary>
    /// cubic decimetre per kilogram
    /// </summary>
    public static QuantityCode CubicDecimetrePerKilogram => new() { Value = "N28" };

    /// <summary>
    /// cubic foot per pound
    /// </summary>
    public static QuantityCode CubicFootPerPound => new() { Value = "N29" };

    /// <summary>
    /// print point
    /// </summary>
    public static QuantityCode PrintPoint => new() { Value = "N3" };

    /// <summary>
    /// cubic inch per pound
    /// </summary>
    public static QuantityCode CubicInchPerPound => new() { Value = "N30" };

    /// <summary>
    /// kilonewton per metre
    /// </summary>
    public static QuantityCode KilonewtonPerMetre => new() { Value = "N31" };

    /// <summary>
    /// poundal per inch
    /// </summary>
    public static QuantityCode PoundalPerInch => new() { Value = "N32" };

    /// <summary>
    /// pound-force per yard
    /// </summary>
    public static QuantityCode PoundForcePerYard => new() { Value = "N33" };

    /// <summary>
    /// poundal second per square foot
    /// </summary>
    public static QuantityCode PoundalSecondPerSquareFoot => new() { Value = "N34" };

    /// <summary>
    /// poise per pascal
    /// </summary>
    public static QuantityCode PoisePerPascal => new() { Value = "N35" };

    /// <summary>
    /// newton second per square metre
    /// </summary>
    public static QuantityCode NewtonSecondPerSquareMetre => new() { Value = "N36" };

    /// <summary>
    /// kilogram per metre second
    /// </summary>
    public static QuantityCode KilogramPerMetreSecond => new() { Value = "N37" };

    /// <summary>
    /// kilogram per metre minute
    /// </summary>
    public static QuantityCode KilogramPerMetreMinute => new() { Value = "N38" };

    /// <summary>
    /// kilogram per metre day
    /// </summary>
    public static QuantityCode KilogramPerMetreDay => new() { Value = "N39" };

    /// <summary>
    /// kilogram per metre hour
    /// </summary>
    public static QuantityCode KilogramPerMetreHour => new() { Value = "N40" };

    /// <summary>
    /// gram per centimetre second
    /// </summary>
    public static QuantityCode GramPerCentimetreSecond => new() { Value = "N41" };

    /// <summary>
    /// poundal second per square inch
    /// </summary>
    public static QuantityCode PoundalSecondPerSquareInch => new() { Value = "N42" };

    /// <summary>
    /// pound per foot minute
    /// </summary>
    public static QuantityCode PoundPerFootMinute => new() { Value = "N43" };

    /// <summary>
    /// pound per foot day
    /// </summary>
    public static QuantityCode PoundPerFootDay => new() { Value = "N44" };

    /// <summary>
    /// cubic metre per second pascal
    /// </summary>
    public static QuantityCode CubicMetrePerSecondPascal => new() { Value = "N45" };

    /// <summary>
    /// foot poundal
    /// </summary>
    public static QuantityCode FootPoundal => new() { Value = "N46" };

    /// <summary>
    /// inch poundal
    /// </summary>
    public static QuantityCode InchPoundal => new() { Value = "N47" };

    /// <summary>
    /// watt per square centimetre
    /// </summary>
    public static QuantityCode WattPerSquareCentimetre => new() { Value = "N48" };

    /// <summary>
    /// watt per square inch
    /// </summary>
    public static QuantityCode WattPerSquareInch => new() { Value = "N49" };

    /// <summary>
    /// British thermal unit (international table) per square foot hour
    /// </summary>
    public static QuantityCode BritishThermalUnitInternationalTablePerSquareFootHour => new() { Value = "N50" };

    /// <summary>
    /// British thermal unit (thermochemical) per square foot hour
    /// </summary>
    public static QuantityCode BritishThermalUnitThermochemicalPerSquareFootHour => new() { Value = "N51" };

    /// <summary>
    /// British thermal unit (thermochemical) per square foot minute
    /// </summary>
    public static QuantityCode BritishThermalUnitThermochemicalPerSquareFootMinute => new() { Value = "N52" };

    /// <summary>
    /// British thermal unit (international table) per square foot second
    /// </summary>
    public static QuantityCode BritishThermalUnitInternationalTablePerSquareFootSecond => new() { Value = "N53" };

    /// <summary>
    /// British thermal unit (thermochemical) per square foot second
    /// </summary>
    public static QuantityCode BritishThermalUnitThermochemicalPerSquareFootSecond => new() { Value = "N54" };

    /// <summary>
    /// British thermal unit (international table) per square inch second
    /// </summary>
    public static QuantityCode BritishThermalUnitInternationalTablePerSquareInchSecond => new() { Value = "N55" };

    /// <summary>
    /// calorie (thermochemical) per square centimetre minute
    /// </summary>
    public static QuantityCode CalorieThermochemicalPerSquareCentimetreMinute => new() { Value = "N56" };

    /// <summary>
    /// calorie (thermochemical) per square centimetre second
    /// </summary>
    public static QuantityCode CalorieThermochemicalPerSquareCentimetreSecond => new() { Value = "N57" };

    /// <summary>
    /// British thermal unit (international table) per cubic foot
    /// </summary>
    public static QuantityCode BritishThermalUnitInternationalTablePerCubicFoot => new() { Value = "N58" };

    /// <summary>
    /// British thermal unit (thermochemical) per cubic foot
    /// </summary>
    public static QuantityCode BritishThermalUnitThermochemicalPerCubicFoot => new() { Value = "N59" };

    /// <summary>
    /// British thermal unit (international table) per degree Fahrenheit
    /// </summary>
    public static QuantityCode BritishThermalUnitInternationalTablePerDegreeFahrenheit => new() { Value = "N60" };

    /// <summary>
    /// British thermal unit (thermochemical) per degree Fahrenheit
    /// </summary>
    public static QuantityCode BritishThermalUnitThermochemicalPerDegreeFahrenheit => new() { Value = "N61" };

    /// <summary>
    /// British thermal unit (international table) per degree Rankine
    /// </summary>
    public static QuantityCode BritishThermalUnitInternationalTablePerDegreeRankine => new() { Value = "N62" };

    /// <summary>
    /// British thermal unit (thermochemical) per degree Rankine
    /// </summary>
    public static QuantityCode BritishThermalUnitThermochemicalPerDegreeRankine => new() { Value = "N63" };

    /// <summary>
    /// British thermal unit (thermochemical) per pound degree Rankine
    /// </summary>
    public static QuantityCode BritishThermalUnitThermochemicalPerPoundDegreeRankine => new() { Value = "N64" };

    /// <summary>
    /// kilocalorie (international table) per gram kelvin
    /// </summary>
    public static QuantityCode KilocalorieInternationalTablePerGramKelvin => new() { Value = "N65" };

    /// <summary>
    /// British thermal unit (39 ºF)
    /// </summary>
    public static QuantityCode BritishThermalUnit39F => new() { Value = "N66" };

    /// <summary>
    /// British thermal unit (59 ºF)
    /// </summary>
    public static QuantityCode BritishThermalUnit59F => new() { Value = "N67" };

    /// <summary>
    /// British thermal unit (60 ºF)
    /// </summary>
    public static QuantityCode BritishThermalUnit60F => new() { Value = "N68" };

    /// <summary>
    /// calorie (20 ºC)
    /// </summary>
    public static QuantityCode Calorie20C => new() { Value = "N69" };

    /// <summary>
    /// quad (1015 BtuIT)
    /// </summary>
    public static QuantityCode Quad1015BtuIT => new() { Value = "N70" };

    /// <summary>
    /// therm (EC)
    /// </summary>
    public static QuantityCode ThermEC => new() { Value = "N71" };

    /// <summary>
    /// therm (U.S.)
    /// </summary>
    public static QuantityCode ThermUS => new() { Value = "N72" };

    /// <summary>
    /// British thermal unit (thermochemical) per pound
    /// </summary>
    public static QuantityCode BritishThermalUnitThermochemicalPerPound => new() { Value = "N73" };

    /// <summary>
    /// British thermal unit (international table) per hour square foot degree Fahrenheit
    /// </summary>
    public static QuantityCode BritishThermalUnitInternationalTablePerHourSquareFootDegreeFahrenheit => new() { Value = "N74" };

    /// <summary>
    /// British thermal unit (thermochemical) per hour square foot degree Fahrenheit
    /// </summary>
    public static QuantityCode BritishThermalUnitThermochemicalPerHourSquareFootDegreeFahrenheit => new() { Value = "N75" };

    /// <summary>
    /// British thermal unit (international table) per second square foot degree Fahrenheit
    /// </summary>
    public static QuantityCode BritishThermalUnitInternationalTablePerSecondSquareFootDegreeFahrenheit => new() { Value = "N76" };

    /// <summary>
    /// British thermal unit (thermochemical) per second square foot degree Fahrenheit
    /// </summary>
    public static QuantityCode BritishThermalUnitThermochemicalPerSecondSquareFootDegreeFahrenheit => new() { Value = "N77" };

    /// <summary>
    /// kilowatt per square metre kelvin
    /// </summary>
    public static QuantityCode KilowattPerSquareMetreKelvin => new() { Value = "N78" };

    /// <summary>
    /// kelvin per pascal
    /// </summary>
    public static QuantityCode KelvinPerPascal => new() { Value = "N79" };

    /// <summary>
    /// watt per metre degree Celsius
    /// </summary>
    public static QuantityCode WattPerMetreDegreeCelsius => new() { Value = "N80" };

    /// <summary>
    /// kilowatt per metre kelvin
    /// </summary>
    public static QuantityCode KilowattPerMetreKelvin => new() { Value = "N81" };

    /// <summary>
    /// kilowatt per metre degree Celsius
    /// </summary>
    public static QuantityCode KilowattPerMetreDegreeCelsius => new() { Value = "N82" };

    /// <summary>
    /// metre per degree Celcius metre
    /// </summary>
    public static QuantityCode MetrePerDegreeCelciusMetre => new() { Value = "N83" };

    /// <summary>
    /// degree Fahrenheit hour per British thermal unit (international table)
    /// </summary>
    public static QuantityCode DegreeFahrenheitHourPerBritishThermalUnitInternationalTable => new() { Value = "N84" };

    /// <summary>
    /// degree Fahrenheit hour per British thermal unit (thermochemical)
    /// </summary>
    public static QuantityCode DegreeFahrenheitHourPerBritishThermalUnitThermochemical => new() { Value = "N85" };

    /// <summary>
    /// degree Fahrenheit second per British thermal unit (international table)
    /// </summary>
    public static QuantityCode DegreeFahrenheitSecondPerBritishThermalUnitInternationalTable => new() { Value = "N86" };

    /// <summary>
    /// degree Fahrenheit second per British thermal unit (thermochemical)
    /// </summary>
    public static QuantityCode DegreeFahrenheitSecondPerBritishThermalUnitThermochemical => new() { Value = "N87" };

    /// <summary>
    /// degree Fahrenheit hour square foot per British thermal unit (international table) inch
    /// </summary>
    public static QuantityCode DegreeFahrenheitHourSquareFootPerBritishThermalUnitInternationalTableInch => new() { Value = "N88" };

    /// <summary>
    /// degree Fahrenheit hour square foot per British thermal unit (thermochemical) inch
    /// </summary>
    public static QuantityCode DegreeFahrenheitHourSquareFootPerBritishThermalUnitThermochemicalInch => new() { Value = "N89" };

    /// <summary>
    /// kilofarad
    /// </summary>
    public static QuantityCode Kilofarad => new() { Value = "N90" };

    /// <summary>
    /// reciprocal joule
    /// </summary>
    public static QuantityCode ReciprocalJoule => new() { Value = "N91" };

    /// <summary>
    /// picosiemens
    /// </summary>
    public static QuantityCode Picosiemens => new() { Value = "N92" };

    /// <summary>
    /// ampere per pascal
    /// </summary>
    public static QuantityCode AmperePerPascal => new() { Value = "N93" };

    /// <summary>
    /// franklin
    /// </summary>
    public static QuantityCode Franklin => new() { Value = "N94" };

    /// <summary>
    /// ampere minute
    /// </summary>
    public static QuantityCode AmpereMinute => new() { Value = "N95" };

    /// <summary>
    /// biot
    /// </summary>
    public static QuantityCode Biot => new() { Value = "N96" };

    /// <summary>
    /// gilbert
    /// </summary>
    public static QuantityCode Gilbert => new() { Value = "N97" };

    /// <summary>
    /// volt per pascal
    /// </summary>
    public static QuantityCode VoltPerPascal => new() { Value = "N98" };

    /// <summary>
    /// picovolt
    /// </summary>
    public static QuantityCode Picovolt => new() { Value = "N99" };

    /// <summary>
    /// milligram per kilogram
    /// </summary>
    public static QuantityCode MilligramPerKilogram => new() { Value = "NA" };

    /// <summary>
    /// number of articles
    /// </summary>
    public static QuantityCode NumberOfArticles => new() { Value = "NAR" };

    /// <summary>
    /// number of cells
    /// </summary>
    public static QuantityCode NumberOfCells => new() { Value = "NCL" };

    /// <summary>
    /// newton
    /// </summary>
    public static QuantityCode Newton => new() { Value = "NEW" };

    /// <summary>
    /// message
    /// </summary>
    public static QuantityCode Message => new() { Value = "NF" };

    /// <summary>
    /// nil
    /// </summary>
    public static QuantityCode Nil => new() { Value = "NIL" };

    /// <summary>
    /// number of international units
    /// </summary>
    public static QuantityCode NumberOfInternationalUnits => new() { Value = "NIU" };

    /// <summary>
    /// load
    /// </summary>
    public static QuantityCode Load => new() { Value = "NL" };

    /// <summary>
    /// Normalised cubic metre
    /// </summary>
    public static QuantityCode NormalisedCubicMetre => new() { Value = "NM3" };

    /// <summary>
    /// nautical mile
    /// </summary>
    public static QuantityCode NauticalMile => new() { Value = "NMI" };

    /// <summary>
    /// number of packs
    /// </summary>
    public static QuantityCode NumberOfPacks => new() { Value = "NMP" };

    /// <summary>
    /// number of parts
    /// </summary>
    public static QuantityCode NumberOfParts => new() { Value = "NPT" };

    /// <summary>
    /// net ton
    /// </summary>
    public static QuantityCode NetTon => new() { Value = "NT" };

    /// <summary>
    /// Nephelometric turbidity unit
    /// </summary>
    public static QuantityCode NephelometricTurbidityUnit => new() { Value = "NTU" };

    /// <summary>
    /// newton metre
    /// </summary>
    public static QuantityCode NewtonMetre => new() { Value = "NU" };

    /// <summary>
    /// part per thousand
    /// </summary>
    public static QuantityCode PartPerThousand => new() { Value = "NX" };

    /// <summary>
    /// panel
    /// </summary>
    public static QuantityCode Panel => new() { Value = "OA" };

    /// <summary>
    /// ozone depletion equivalent
    /// </summary>
    public static QuantityCode OzoneDepletionEquivalent => new() { Value = "ODE" };

    /// <summary>
    /// ODS Grams
    /// </summary>
    public static QuantityCode ODSGrams => new() { Value = "ODG" };

    /// <summary>
    /// ODS Kilograms
    /// </summary>
    public static QuantityCode ODSKilograms => new() { Value = "ODK" };

    /// <summary>
    /// ODS Milligrams
    /// </summary>
    public static QuantityCode ODSMilligrams => new() { Value = "ODM" };

    /// <summary>
    /// ohm
    /// </summary>
    public static QuantityCode Ohm => new() { Value = "OHM" };

    /// <summary>
    /// ounce per square yard
    /// </summary>
    public static QuantityCode OuncePerSquareYard => new() { Value = "ON" };

    /// <summary>
    /// ounce (avoirdupois)
    /// </summary>
    public static QuantityCode OunceAvoirdupois => new() { Value = "ONZ" };

    /// <summary>
    /// oscillations per minute
    /// </summary>
    public static QuantityCode OscillationsPerMinute => new() { Value = "OPM" };

    /// <summary>
    /// overtime hour
    /// </summary>
    public static QuantityCode OvertimeHour => new() { Value = "OT" };

    /// <summary>
    /// fluid ounce (US)
    /// </summary>
    public static QuantityCode FluidOunceUS => new() { Value = "OZA" };

    /// <summary>
    /// fluid ounce (UK)
    /// </summary>
    public static QuantityCode FluidOunceUK => new() { Value = "OZI" };

    /// <summary>
    /// percent
    /// </summary>
    public static QuantityCode Percent => new() { Value = "P1" };

    /// <summary>
    /// coulomb per metre
    /// </summary>
    public static QuantityCode CoulombPerMetre => new() { Value = "P10" };

    /// <summary>
    /// kiloweber
    /// </summary>
    public static QuantityCode Kiloweber => new() { Value = "P11" };

    /// <summary>
    /// gamma
    /// </summary>
    public static QuantityCode Gamma => new() { Value = "P12" };

    /// <summary>
    /// kilotesla
    /// </summary>
    public static QuantityCode Kilotesla => new() { Value = "P13" };

    /// <summary>
    /// joule per second
    /// </summary>
    public static QuantityCode JoulePerSecond => new() { Value = "P14" };

    /// <summary>
    /// joule per minute
    /// </summary>
    public static QuantityCode JoulePerMinute => new() { Value = "P15" };

    /// <summary>
    /// joule per hour
    /// </summary>
    public static QuantityCode JoulePerHour => new() { Value = "P16" };

    /// <summary>
    /// joule per day
    /// </summary>
    public static QuantityCode JoulePerDay => new() { Value = "P17" };

    /// <summary>
    /// kilojoule per second
    /// </summary>
    public static QuantityCode KilojoulePerSecond => new() { Value = "P18" };

    /// <summary>
    /// kilojoule per minute
    /// </summary>
    public static QuantityCode KilojoulePerMinute => new() { Value = "P19" };

    /// <summary>
    /// pound per foot
    /// </summary>
    public static QuantityCode PoundPerFoot => new() { Value = "P2" };

    /// <summary>
    /// kilojoule per hour
    /// </summary>
    public static QuantityCode KilojoulePerHour => new() { Value = "P20" };

    /// <summary>
    /// kilojoule per day
    /// </summary>
    public static QuantityCode KilojoulePerDay => new() { Value = "P21" };

    /// <summary>
    /// nanoohm
    /// </summary>
    public static QuantityCode Nanoohm => new() { Value = "P22" };

    /// <summary>
    /// ohm circular-mil per foot
    /// </summary>
    public static QuantityCode OhmCircularMilPerFoot => new() { Value = "P23" };

    /// <summary>
    /// kilohenry
    /// </summary>
    public static QuantityCode Kilohenry => new() { Value = "P24" };

    /// <summary>
    /// lumen per square foot
    /// </summary>
    public static QuantityCode LumenPerSquareFoot => new() { Value = "P25" };

    /// <summary>
    /// phot
    /// </summary>
    public static QuantityCode Phot => new() { Value = "P26" };

    /// <summary>
    /// footcandle
    /// </summary>
    public static QuantityCode Footcandle => new() { Value = "P27" };

    /// <summary>
    /// candela per square inch
    /// </summary>
    public static QuantityCode CandelaPerSquareInch => new() { Value = "P28" };

    /// <summary>
    /// footlambert
    /// </summary>
    public static QuantityCode Footlambert => new() { Value = "P29" };

    /// <summary>
    /// lambert
    /// </summary>
    public static QuantityCode Lambert => new() { Value = "P30" };

    /// <summary>
    /// stilb
    /// </summary>
    public static QuantityCode Stilb => new() { Value = "P31" };

    /// <summary>
    /// candela per square foot
    /// </summary>
    public static QuantityCode CandelaPerSquareFoot => new() { Value = "P32" };

    /// <summary>
    /// kilocandela
    /// </summary>
    public static QuantityCode Kilocandela => new() { Value = "P33" };

    /// <summary>
    /// millicandela
    /// </summary>
    public static QuantityCode Millicandela => new() { Value = "P34" };

    /// <summary>
    /// Hefner-Kerze
    /// </summary>
    public static QuantityCode HefnerKerze => new() { Value = "P35" };

    /// <summary>
    /// international candle
    /// </summary>
    public static QuantityCode InternationalCandle => new() { Value = "P36" };

    /// <summary>
    /// British thermal unit (international table) per square foot
    /// </summary>
    public static QuantityCode BritishThermalUnitInternationalTablePerSquareFoot => new() { Value = "P37" };

    /// <summary>
    /// British thermal unit (thermochemical) per square foot
    /// </summary>
    public static QuantityCode BritishThermalUnitThermochemicalPerSquareFoot => new() { Value = "P38" };

    /// <summary>
    /// calorie (thermochemical) per square centimetre
    /// </summary>
    public static QuantityCode CalorieThermochemicalPerSquareCentimetre => new() { Value = "P39" };

    /// <summary>
    /// langley
    /// </summary>
    public static QuantityCode Langley => new() { Value = "P40" };

    /// <summary>
    /// decade (logarithmic)
    /// </summary>
    public static QuantityCode DecadeLogarithmic => new() { Value = "P41" };

    /// <summary>
    /// pascal squared second
    /// </summary>
    public static QuantityCode PascalSquaredSecond => new() { Value = "P42" };

    /// <summary>
    /// bel per metre
    /// </summary>
    public static QuantityCode BelPerMetre => new() { Value = "P43" };

    /// <summary>
    /// pound mole
    /// </summary>
    public static QuantityCode PoundMole => new() { Value = "P44" };

    /// <summary>
    /// pound mole per second
    /// </summary>
    public static QuantityCode PoundMolePerSecond => new() { Value = "P45" };

    /// <summary>
    /// pound mole per minute
    /// </summary>
    public static QuantityCode PoundMolePerMinute => new() { Value = "P46" };

    /// <summary>
    /// kilomole per kilogram
    /// </summary>
    public static QuantityCode KilomolePerKilogram => new() { Value = "P47" };

    /// <summary>
    /// pound mole per pound
    /// </summary>
    public static QuantityCode PoundMolePerPound => new() { Value = "P48" };

    /// <summary>
    /// newton square metre per ampere
    /// </summary>
    public static QuantityCode NewtonSquareMetrePerAmpere => new() { Value = "P49" };

    /// <summary>
    /// five pack
    /// </summary>
    public static QuantityCode FivePack => new() { Value = "P5" };

    /// <summary>
    /// weber metre
    /// </summary>
    public static QuantityCode WeberMetre => new() { Value = "P50" };

    /// <summary>
    /// mol per kilogram pascal
    /// </summary>
    public static QuantityCode MolPerKilogramPascal => new() { Value = "P51" };

    /// <summary>
    /// mol per cubic metre pascal
    /// </summary>
    public static QuantityCode MolPerCubicMetrePascal => new() { Value = "P52" };

    /// <summary>
    /// unit pole
    /// </summary>
    public static QuantityCode UnitPole => new() { Value = "P53" };

    /// <summary>
    /// milligray per second
    /// </summary>
    public static QuantityCode MilligrayPerSecond => new() { Value = "P54" };

    /// <summary>
    /// microgray per second
    /// </summary>
    public static QuantityCode MicrograyPerSecond => new() { Value = "P55" };

    /// <summary>
    /// nanogray per second
    /// </summary>
    public static QuantityCode NanograyPerSecond => new() { Value = "P56" };

    /// <summary>
    /// gray per minute
    /// </summary>
    public static QuantityCode GrayPerMinute => new() { Value = "P57" };

    /// <summary>
    /// milligray per minute
    /// </summary>
    public static QuantityCode MilligrayPerMinute => new() { Value = "P58" };

    /// <summary>
    /// microgray per minute
    /// </summary>
    public static QuantityCode MicrograyPerMinute => new() { Value = "P59" };

    /// <summary>
    /// nanogray per minute
    /// </summary>
    public static QuantityCode NanograyPerMinute => new() { Value = "P60" };

    /// <summary>
    /// gray per hour
    /// </summary>
    public static QuantityCode GrayPerHour => new() { Value = "P61" };

    /// <summary>
    /// milligray per hour
    /// </summary>
    public static QuantityCode MilligrayPerHour => new() { Value = "P62" };

    /// <summary>
    /// microgray per hour
    /// </summary>
    public static QuantityCode MicrograyPerHour => new() { Value = "P63" };

    /// <summary>
    /// nanogray per hour
    /// </summary>
    public static QuantityCode NanograyPerHour => new() { Value = "P64" };

    /// <summary>
    /// sievert per second
    /// </summary>
    public static QuantityCode SievertPerSecond => new() { Value = "P65" };

    /// <summary>
    /// millisievert per second
    /// </summary>
    public static QuantityCode MillisievertPerSecond => new() { Value = "P66" };

    /// <summary>
    /// microsievert per second
    /// </summary>
    public static QuantityCode MicrosievertPerSecond => new() { Value = "P67" };

    /// <summary>
    /// nanosievert per second
    /// </summary>
    public static QuantityCode NanosievertPerSecond => new() { Value = "P68" };

    /// <summary>
    /// rem per second
    /// </summary>
    public static QuantityCode RemPerSecond => new() { Value = "P69" };

    /// <summary>
    /// sievert per hour
    /// </summary>
    public static QuantityCode SievertPerHour => new() { Value = "P70" };

    /// <summary>
    /// millisievert per hour
    /// </summary>
    public static QuantityCode MillisievertPerHour => new() { Value = "P71" };

    /// <summary>
    /// microsievert per hour
    /// </summary>
    public static QuantityCode MicrosievertPerHour => new() { Value = "P72" };

    /// <summary>
    /// nanosievert per hour
    /// </summary>
    public static QuantityCode NanosievertPerHour => new() { Value = "P73" };

    /// <summary>
    /// sievert per minute
    /// </summary>
    public static QuantityCode SievertPerMinute => new() { Value = "P74" };

    /// <summary>
    /// millisievert per minute
    /// </summary>
    public static QuantityCode MillisievertPerMinute => new() { Value = "P75" };

    /// <summary>
    /// microsievert per minute
    /// </summary>
    public static QuantityCode MicrosievertPerMinute => new() { Value = "P76" };

    /// <summary>
    /// nanosievert per minute
    /// </summary>
    public static QuantityCode NanosievertPerMinute => new() { Value = "P77" };

    /// <summary>
    /// reciprocal square inch
    /// </summary>
    public static QuantityCode ReciprocalSquareInch => new() { Value = "P78" };

    /// <summary>
    /// pascal square metre per kilogram
    /// </summary>
    public static QuantityCode PascalSquareMetrePerKilogram => new() { Value = "P79" };

    /// <summary>
    /// millipascal per metre
    /// </summary>
    public static QuantityCode MillipascalPerMetre => new() { Value = "P80" };

    /// <summary>
    /// kilopascal per metre
    /// </summary>
    public static QuantityCode KilopascalPerMetre => new() { Value = "P81" };

    /// <summary>
    /// hectopascal per metre
    /// </summary>
    public static QuantityCode HectopascalPerMetre => new() { Value = "P82" };

    /// <summary>
    /// standard atmosphere per metre
    /// </summary>
    public static QuantityCode StandardAtmospherePerMetre => new() { Value = "P83" };

    /// <summary>
    /// technical atmosphere per metre
    /// </summary>
    public static QuantityCode TechnicalAtmospherePerMetre => new() { Value = "P84" };

    /// <summary>
    /// torr per metre
    /// </summary>
    public static QuantityCode TorrPerMetre => new() { Value = "P85" };

    /// <summary>
    /// psi per inch
    /// </summary>
    public static QuantityCode PsiPerInch => new() { Value = "P86" };

    /// <summary>
    /// cubic metre per second square metre
    /// </summary>
    public static QuantityCode CubicMetrePerSecondSquareMetre => new() { Value = "P87" };

    /// <summary>
    /// rhe
    /// </summary>
    public static QuantityCode Rhe => new() { Value = "P88" };

    /// <summary>
    /// pound-force foot per inch
    /// </summary>
    public static QuantityCode PoundForceFootPerInch => new() { Value = "P89" };

    /// <summary>
    /// pound-force inch per inch
    /// </summary>
    public static QuantityCode PoundForceInchPerInch => new() { Value = "P90" };

    /// <summary>
    /// perm (0 ºC)
    /// </summary>
    public static QuantityCode Perm0C => new() { Value = "P91" };

    /// <summary>
    /// perm (23 ºC)
    /// </summary>
    public static QuantityCode Perm23C => new() { Value = "P92" };

    /// <summary>
    /// byte per second
    /// </summary>
    public static QuantityCode BytePerSecond => new() { Value = "P93" };

    /// <summary>
    /// kilobyte per second
    /// </summary>
    public static QuantityCode KilobytePerSecond => new() { Value = "P94" };

    /// <summary>
    /// megabyte per second
    /// </summary>
    public static QuantityCode MegabytePerSecond => new() { Value = "P95" };

    /// <summary>
    /// reciprocal volt
    /// </summary>
    public static QuantityCode ReciprocalVolt => new() { Value = "P96" };

    /// <summary>
    /// reciprocal radian
    /// </summary>
    public static QuantityCode ReciprocalRadian => new() { Value = "P97" };

    /// <summary>
    /// pascal to the power sum of stoichiometric numbers
    /// </summary>
    public static QuantityCode PascalToThePowerSumOfStoichiometricNumbers => new() { Value = "P98" };

    /// <summary>
    /// mole per cubiv metre to the power sum of stoichiometric numbers
    /// </summary>
    public static QuantityCode MolePerCubivMetreToThePowerSumOfStoichiometricNumbers => new() { Value = "P99" };

    /// <summary>
    /// pascal
    /// </summary>
    public static QuantityCode Pascal => new() { Value = "PAL" };

    /// <summary>
    /// pad
    /// </summary>
    public static QuantityCode Pad => new() { Value = "PD" };

    /// <summary>
    /// proof litre
    /// </summary>
    public static QuantityCode ProofLitre => new() { Value = "PFL" };

    /// <summary>
    /// proof gallon
    /// </summary>
    public static QuantityCode ProofGallon => new() { Value = "PGL" };

    /// <summary>
    /// pitch
    /// </summary>
    public static QuantityCode Pitch => new() { Value = "PI" };

    /// <summary>
    /// degree Plato
    /// </summary>
    public static QuantityCode DegreePlato => new() { Value = "PLA" };

    /// <summary>
    /// pound per inch of length
    /// </summary>
    public static QuantityCode PoundPerInchOfLength => new() { Value = "PO" };

    /// <summary>
    /// page per inch
    /// </summary>
    public static QuantityCode PagePerInch => new() { Value = "PQ" };

    /// <summary>
    /// pair
    /// </summary>
    public static QuantityCode Pair => new() { Value = "PR" };

    /// <summary>
    /// pound-force per square inch
    /// </summary>
    public static QuantityCode PoundForcePerSquareInch => new() { Value = "PS" };

    /// <summary>
    /// dry pint (US)
    /// </summary>
    public static QuantityCode DryPintUS => new() { Value = "PTD" };

    /// <summary>
    /// pint (UK)
    /// </summary>
    public static QuantityCode PintUK => new() { Value = "PTI" };

    /// <summary>
    /// liquid pint (US)
    /// </summary>
    public static QuantityCode LiquidPintUS => new() { Value = "PTL" };

    /// <summary>
    /// portion
    /// </summary>
    public static QuantityCode Portion => new() { Value = "PTN" };

    /// <summary>
    /// joule per tesla
    /// </summary>
    public static QuantityCode JoulePerTesla => new() { Value = "Q10" };

    /// <summary>
    /// erlang
    /// </summary>
    public static QuantityCode Erlang => new() { Value = "Q11" };

    /// <summary>
    /// octet
    /// </summary>
    public static QuantityCode Octet => new() { Value = "Q12" };

    /// <summary>
    /// octet per second
    /// </summary>
    public static QuantityCode OctetPerSecond => new() { Value = "Q13" };

    /// <summary>
    /// shannon
    /// </summary>
    public static QuantityCode Shannon => new() { Value = "Q14" };

    /// <summary>
    /// hartley
    /// </summary>
    public static QuantityCode Hartley => new() { Value = "Q15" };

    /// <summary>
    /// natural unit of information
    /// </summary>
    public static QuantityCode NaturalUnitOfInformation => new() { Value = "Q16" };

    /// <summary>
    /// shannon per second
    /// </summary>
    public static QuantityCode ShannonPerSecond => new() { Value = "Q17" };

    /// <summary>
    /// hartley per second
    /// </summary>
    public static QuantityCode HartleyPerSecond => new() { Value = "Q18" };

    /// <summary>
    /// natural unit of information per second
    /// </summary>
    public static QuantityCode NaturalUnitOfInformationPerSecond => new() { Value = "Q19" };

    /// <summary>
    /// second per kilogramm
    /// </summary>
    public static QuantityCode SecondPerKilogramm => new() { Value = "Q20" };

    /// <summary>
    /// watt square metre
    /// </summary>
    public static QuantityCode WattSquareMetre => new() { Value = "Q21" };

    /// <summary>
    /// second per radian cubic metre
    /// </summary>
    public static QuantityCode SecondPerRadianCubicMetre => new() { Value = "Q22" };

    /// <summary>
    /// weber to the power minus one
    /// </summary>
    public static QuantityCode WeberToThePowerMinusOne => new() { Value = "Q23" };

    /// <summary>
    /// reciprocal inch
    /// </summary>
    public static QuantityCode ReciprocalInch => new() { Value = "Q24" };

    /// <summary>
    /// dioptre
    /// </summary>
    public static QuantityCode Dioptre => new() { Value = "Q25" };

    /// <summary>
    /// one per one
    /// </summary>
    public static QuantityCode OnePerOne => new() { Value = "Q26" };

    /// <summary>
    /// newton metre per metre
    /// </summary>
    public static QuantityCode NewtonMetrePerMetre => new() { Value = "Q27" };

    /// <summary>
    /// kilogram per square metre pascal second
    /// </summary>
    public static QuantityCode KilogramPerSquareMetrePascalSecond => new() { Value = "Q28" };

    /// <summary>
    /// microgram per hectogram
    /// </summary>
    public static QuantityCode MicrogramPerHectogram => new() { Value = "Q29" };

    /// <summary>
    /// meal
    /// </summary>
    public static QuantityCode Meal => new() { Value = "Q3" };

    /// <summary>
    /// pH (potential of Hydrogen)
    /// </summary>
    public static QuantityCode PHPotentialOfHydrogen => new() { Value = "Q30" };

    /// <summary>
    /// kilojoule per gram
    /// </summary>
    public static QuantityCode KilojoulePerGram => new() { Value = "Q31" };

    /// <summary>
    /// femtolitre
    /// </summary>
    public static QuantityCode Femtolitre => new() { Value = "Q32" };

    /// <summary>
    /// picolitre
    /// </summary>
    public static QuantityCode Picolitre => new() { Value = "Q33" };

    /// <summary>
    /// nanolitre
    /// </summary>
    public static QuantityCode Nanolitre => new() { Value = "Q34" };

    /// <summary>
    /// megawatts per minute
    /// </summary>
    public static QuantityCode MegawattsPerMinute => new() { Value = "Q35" };

    /// <summary>
    /// square metre per cubic metre
    /// </summary>
    public static QuantityCode SquareMetrePerCubicMetre => new() { Value = "Q36" };

    /// <summary>
    /// Standard cubic metre per day
    /// </summary>
    public static QuantityCode StandardCubicMetrePerDay => new() { Value = "Q37" };

    /// <summary>
    /// Standard cubic metre per hour
    /// </summary>
    public static QuantityCode StandardCubicMetrePerHour => new() { Value = "Q38" };

    /// <summary>
    /// Normalized cubic metre per day
    /// </summary>
    public static QuantityCode NormalizedCubicMetrePerDay => new() { Value = "Q39" };

    /// <summary>
    /// Normalized cubic metre per hour
    /// </summary>
    public static QuantityCode NormalizedCubicMetrePerHour => new() { Value = "Q40" };

    /// <summary>
    /// Joule per normalised cubic metre
    /// </summary>
    public static QuantityCode JoulePerNormalisedCubicMetre => new() { Value = "Q41" };

    /// <summary>
    /// Joule per standard cubic metre
    /// </summary>
    public static QuantityCode JoulePerStandardCubicMetre => new() { Value = "Q42" };

    /// <summary>
    /// page - facsimile
    /// </summary>
    public static QuantityCode PageFacsimile => new() { Value = "QA" };

    /// <summary>
    /// quarter (of a year)
    /// </summary>
    public static QuantityCode QuarterOfAYear => new() { Value = "QAN" };

    /// <summary>
    /// page - hardcopy
    /// </summary>
    public static QuantityCode PageHardcopy => new() { Value = "QB" };

    /// <summary>
    /// quire
    /// </summary>
    public static QuantityCode Quire => new() { Value = "QR" };

    /// <summary>
    /// dry quart (US)
    /// </summary>
    public static QuantityCode DryQuartUS => new() { Value = "QTD" };

    /// <summary>
    /// quart (UK)
    /// </summary>
    public static QuantityCode QuartUK => new() { Value = "QTI" };

    /// <summary>
    /// liquid quart (US)
    /// </summary>
    public static QuantityCode LiquidQuartUS => new() { Value = "QTL" };

    /// <summary>
    /// quarter (UK)
    /// </summary>
    public static QuantityCode QuarterUK => new() { Value = "QTR" };

    /// <summary>
    /// pica
    /// </summary>
    public static QuantityCode Pica => new() { Value = "R1" };

    /// <summary>
    /// thousand cubic metre
    /// </summary>
    public static QuantityCode ThousandCubicMetre => new() { Value = "R9" };

    /// <summary>
    /// running or operating hour
    /// </summary>
    public static QuantityCode RunningOrOperatingHour => new() { Value = "RH" };

    /// <summary>
    /// ream
    /// </summary>
    public static QuantityCode Ream => new() { Value = "RM" };

    /// <summary>
    /// room
    /// </summary>
    public static QuantityCode Room => new() { Value = "ROM" };

    /// <summary>
    /// pound per ream
    /// </summary>
    public static QuantityCode PoundPerReam => new() { Value = "RP" };

    /// <summary>
    /// revolutions per minute
    /// </summary>
    public static QuantityCode RevolutionsPerMinute => new() { Value = "RPM" };

    /// <summary>
    /// revolutions per second
    /// </summary>
    public static QuantityCode RevolutionsPerSecond => new() { Value = "RPS" };

    /// <summary>
    /// revenue ton mile
    /// </summary>
    public static QuantityCode RevenueTonMile => new() { Value = "RT" };

    /// <summary>
    /// square foot per second
    /// </summary>
    public static QuantityCode SquareFootPerSecond => new() { Value = "S3" };

    /// <summary>
    /// square metre per second
    /// </summary>
    public static QuantityCode SquareMetrePerSecond => new() { Value = "S4" };

    /// <summary>
    /// half year (6 months)
    /// </summary>
    public static QuantityCode HalfYear6Months => new() { Value = "SAN" };

    /// <summary>
    /// score
    /// </summary>
    public static QuantityCode Score => new() { Value = "SCO" };

    /// <summary>
    /// scruple
    /// </summary>
    public static QuantityCode Scruple => new() { Value = "SCR" };

    /// <summary>
    /// second [unit of time]
    /// </summary>
    public static QuantityCode SecondUnitOfTime => new() { Value = "SEC" };

    /// <summary>
    /// set
    /// </summary>
    public static QuantityCode Set => new() { Value = "SET" };

    /// <summary>
    /// segment
    /// </summary>
    public static QuantityCode Segment => new() { Value = "SG" };

    /// <summary>
    /// siemens
    /// </summary>
    public static QuantityCode Siemens => new() { Value = "SIE" };

    /// <summary>
    /// Standard cubic metre
    /// </summary>
    public static QuantityCode StandardCubicMetre => new() { Value = "SM3" };

    /// <summary>
    /// mile (statute mile)
    /// </summary>
    public static QuantityCode MileStatuteMile => new() { Value = "SMI" };

    /// <summary>
    /// square
    /// </summary>
    public static QuantityCode Square => new() { Value = "SQ" };

    /// <summary>
    /// square, roofing
    /// </summary>
    public static QuantityCode SquareRoofing => new() { Value = "SQR" };

    /// <summary>
    /// strip
    /// </summary>
    public static QuantityCode Strip => new() { Value = "SR" };

    /// <summary>
    /// stick
    /// </summary>
    public static QuantityCode Stick => new() { Value = "STC" };

    /// <summary>
    /// stone (UK)
    /// </summary>
    public static QuantityCode StoneUK => new() { Value = "STI" };

    /// <summary>
    /// stick, cigarette
    /// </summary>
    public static QuantityCode StickCigarette => new() { Value = "STK" };

    /// <summary>
    /// standard litre
    /// </summary>
    public static QuantityCode StandardLitre => new() { Value = "STL" };

    /// <summary>
    /// ton (US) or short ton (UK/US)
    /// </summary>
    public static QuantityCode TonUSOrShortTonUKUS => new() { Value = "STN" };

    /// <summary>
    /// straw
    /// </summary>
    public static QuantityCode Straw => new() { Value = "STW" };

    /// <summary>
    /// skein
    /// </summary>
    public static QuantityCode Skein => new() { Value = "SW" };

    /// <summary>
    /// shipment
    /// </summary>
    public static QuantityCode Shipment => new() { Value = "SX" };

    /// <summary>
    /// syringe
    /// </summary>
    public static QuantityCode Syringe => new() { Value = "SYR" };

    /// <summary>
    /// telecommunication line in service
    /// </summary>
    public static QuantityCode TelecommunicationLineInService => new() { Value = "T0" };

    /// <summary>
    /// thousand piece
    /// </summary>
    public static QuantityCode ThousandPiece => new() { Value = "T3" };

    /// <summary>
    /// kiloampere hour (thousand ampere hour)
    /// </summary>
    public static QuantityCode KiloampereHourThousandAmpereHour => new() { Value = "TAH" };

    /// <summary>
    /// total acid number
    /// </summary>
    public static QuantityCode TotalAcidNumber => new() { Value = "TAN" };

    /// <summary>
    /// thousand square inch
    /// </summary>
    public static QuantityCode ThousandSquareInch => new() { Value = "TI" };

    /// <summary>
    /// metric ton, including container
    /// </summary>
    public static QuantityCode MetricTonIncludingContainer => new() { Value = "TIC" };

    /// <summary>
    /// metric ton, including inner packaging
    /// </summary>
    public static QuantityCode MetricTonIncludingInnerPackaging => new() { Value = "TIP" };

    /// <summary>
    /// tonne kilometre
    /// </summary>
    public static QuantityCode TonneKilometre => new() { Value = "TKM" };

    /// <summary>
    /// kilogram of imported meat, less offal
    /// </summary>
    public static QuantityCode KilogramOfImportedMeatLessOffal => new() { Value = "TMS" };

    /// <summary>
    /// tonne (metric ton)
    /// </summary>
    public static QuantityCode TonneMetricTon => new() { Value = "TNE" };

    /// <summary>
    /// ten pack
    /// </summary>
    public static QuantityCode TenPack => new() { Value = "TP" };

    /// <summary>
    /// teeth per inch
    /// </summary>
    public static QuantityCode TeethPerInch => new() { Value = "TPI" };

    /// <summary>
    /// ten pair
    /// </summary>
    public static QuantityCode TenPair => new() { Value = "TPR" };

    /// <summary>
    /// thousand cubic metre per day
    /// </summary>
    public static QuantityCode ThousandCubicMetrePerDay => new() { Value = "TQD" };

    /// <summary>
    /// trillion (EUR)
    /// </summary>
    public static QuantityCode TrillionEUR => new() { Value = "TRL" };

    /// <summary>
    /// ten set
    /// </summary>
    public static QuantityCode TenSet => new() { Value = "TST" };

    /// <summary>
    /// ten thousand sticks
    /// </summary>
    public static QuantityCode TenThousandSticks => new() { Value = "TTS" };

    /// <summary>
    /// treatment
    /// </summary>
    public static QuantityCode Treatment => new() { Value = "U1" };

    /// <summary>
    /// tablet
    /// </summary>
    public static QuantityCode Tablet => new() { Value = "U2" };

    /// <summary>
    /// telecommunication line in service average
    /// </summary>
    public static QuantityCode TelecommunicationLineInServiceAverage => new() { Value = "UB" };

    /// <summary>
    /// telecommunication port
    /// </summary>
    public static QuantityCode TelecommunicationPort => new() { Value = "UC" };

    /// <summary>
    /// volt - ampere per kilogram
    /// </summary>
    public static QuantityCode VoltAmperePerKilogram => new() { Value = "VA" };

    /// <summary>
    /// volt
    /// </summary>
    public static QuantityCode Volt => new() { Value = "VLT" };

    /// <summary>
    /// percent volume
    /// </summary>
    public static QuantityCode PercentVolume => new() { Value = "VP" };

    /// <summary>
    /// wet kilo
    /// </summary>
    public static QuantityCode WetKilo => new() { Value = "W2" };

    /// <summary>
    /// watt per kilogram
    /// </summary>
    public static QuantityCode WattPerKilogram => new() { Value = "WA" };

    /// <summary>
    /// wet pound
    /// </summary>
    public static QuantityCode WetPound => new() { Value = "WB" };

    /// <summary>
    /// cord
    /// </summary>
    public static QuantityCode Cord => new() { Value = "WCD" };

    /// <summary>
    /// wet ton
    /// </summary>
    public static QuantityCode WetTon => new() { Value = "WE" };

    /// <summary>
    /// weber
    /// </summary>
    public static QuantityCode Weber => new() { Value = "WEB" };

    /// <summary>
    /// week
    /// </summary>
    public static QuantityCode Week => new() { Value = "WEE" };

    /// <summary>
    /// wine gallon
    /// </summary>
    public static QuantityCode WineGallon => new() { Value = "WG" };

    /// <summary>
    /// watt hour
    /// </summary>
    public static QuantityCode WattHour => new() { Value = "WHR" };

    /// <summary>
    /// working month
    /// </summary>
    public static QuantityCode WorkingMonth => new() { Value = "WM" };

    /// <summary>
    /// standard
    /// </summary>
    public static QuantityCode Standard => new() { Value = "WSD" };

    /// <summary>
    /// watt
    /// </summary>
    public static QuantityCode Watt => new() { Value = "WTT" };

    /// <summary>
    /// Gunter's chain
    /// </summary>
    public static QuantityCode GunterSChain => new() { Value = "X1" };

    /// <summary>
    /// square yard
    /// </summary>
    public static QuantityCode SquareYard => new() { Value = "YDK" };

    /// <summary>
    /// cubic yard
    /// </summary>
    public static QuantityCode CubicYard => new() { Value = "YDQ" };

    /// <summary>
    /// yard
    /// </summary>
    public static QuantityCode Yard => new() { Value = "YRD" };

    /// <summary>
    /// hanging container
    /// </summary>
    public static QuantityCode HangingContainer => new() { Value = "Z11" };

    /// <summary>
    /// nanomole
    /// </summary>
    public static QuantityCode Nanomole => new() { Value = "Z9" };

    /// <summary>
    /// page
    /// </summary>
    public static QuantityCode Page => new() { Value = "ZP" };

    /// <summary>
    /// mutually defined
    /// </summary>
    public static QuantityCode MutuallyDefined => new() { Value = "ZZ" };

}
