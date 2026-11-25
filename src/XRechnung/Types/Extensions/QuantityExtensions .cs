namespace XRechnung;

public static class QuantityExtensions
{
    extension(Quantity)
    {
        /// <summary>
        /// piece
        /// </summary>
        public static Quantity Piece(decimal value) => new() { Value = value, UnitCode = QuantityCode.Piece };

        /// <summary>
        /// hour
        /// </summary>
        public static Quantity Hour(decimal value) => new() { Value = value, UnitCode = QuantityCode.Hour };

        /// <summary>
        /// group
        /// </summary>
        public static Quantity Group(decimal value) => new() { Value = value, UnitCode = QuantityCode.Group };

        /// <summary>
        /// outfit
        /// </summary>
        public static Quantity Outfit(decimal value) => new() { Value = value, UnitCode = QuantityCode.Outfit };

        /// <summary>
        /// ration
        /// </summary>
        public static Quantity Ration(decimal value) => new() { Value = value, UnitCode = QuantityCode.Ration };

        /// <summary>
        /// shot
        /// </summary>
        public static Quantity Shot(decimal value) => new() { Value = value, UnitCode = QuantityCode.Shot };

        /// <summary>
        /// stick, military
        /// </summary>
        public static Quantity StickMilitary(decimal value) => new() { Value = value, UnitCode = QuantityCode.StickMilitary };

        /// <summary>
        /// twenty foot container
        /// </summary>
        public static Quantity TwentyFootContainer(decimal value) => new() { Value = value, UnitCode = QuantityCode.TwentyFootContainer };

        /// <summary>
        /// forty foot container
        /// </summary>
        public static Quantity FortyFootContainer(decimal value) => new() { Value = value, UnitCode = QuantityCode.FortyFootContainer };

        /// <summary>
        /// decilitre per gram
        /// </summary>
        public static Quantity DecilitrePerGram(decimal value) => new() { Value = value, UnitCode = QuantityCode.DecilitrePerGram };

        /// <summary>
        /// gram per cubic centimetre
        /// </summary>
        public static Quantity GramPerCubicCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerCubicCentimetre };

        /// <summary>
        /// theoretical pound
        /// </summary>
        public static Quantity TheoreticalPound(decimal value) => new() { Value = value, UnitCode = QuantityCode.TheoreticalPound };

        /// <summary>
        /// gram per square centimetre
        /// </summary>
        public static Quantity GramPerSquareCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerSquareCentimetre };

        /// <summary>
        /// theoretical ton
        /// </summary>
        public static Quantity TheoreticalTon(decimal value) => new() { Value = value, UnitCode = QuantityCode.TheoreticalTon };

        /// <summary>
        /// kilogram per square metre
        /// </summary>
        public static Quantity KilogramPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerSquareMetre };

        /// <summary>
        /// kilopascal square metre per gram
        /// </summary>
        public static Quantity KilopascalSquareMetrePerGram(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilopascalSquareMetrePerGram };

        /// <summary>
        /// kilopascal per millimetre
        /// </summary>
        public static Quantity KilopascalPerMillimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilopascalPerMillimetre };

        /// <summary>
        /// millilitre per square centimetre second
        /// </summary>
        public static Quantity MillilitrePerSquareCentimetreSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillilitrePerSquareCentimetreSecond };

        /// <summary>
        /// ounce per square foot
        /// </summary>
        public static Quantity OuncePerSquareFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.OuncePerSquareFoot };

        /// <summary>
        /// ounce per square foot per 0,01inch
        /// </summary>
        public static Quantity OuncePerSquareFootPer001inch(decimal value) => new() { Value = value, UnitCode = QuantityCode.OuncePerSquareFootPer001inch };

        /// <summary>
        /// millilitre per second
        /// </summary>
        public static Quantity MillilitrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillilitrePerSecond };

        /// <summary>
        /// millilitre per minute
        /// </summary>
        public static Quantity MillilitrePerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillilitrePerMinute };

        /// <summary>
        /// sitas
        /// </summary>
        public static Quantity Sitas(decimal value) => new() { Value = value, UnitCode = QuantityCode.Sitas };

        /// <summary>
        /// mesh
        /// </summary>
        public static Quantity Mesh(decimal value) => new() { Value = value, UnitCode = QuantityCode.Mesh };

        /// <summary>
        /// net kilogram
        /// </summary>
        public static Quantity NetKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.NetKilogram };

        /// <summary>
        /// part per million
        /// </summary>
        public static Quantity PartPerMillion(decimal value) => new() { Value = value, UnitCode = QuantityCode.PartPerMillion };

        /// <summary>
        /// percent weight
        /// </summary>
        public static Quantity PercentWeight(decimal value) => new() { Value = value, UnitCode = QuantityCode.PercentWeight };

        /// <summary>
        /// part per billion (US)
        /// </summary>
        public static Quantity PartPerBillionUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.PartPerBillionUS };

        /// <summary>
        /// millipascal
        /// </summary>
        public static Quantity Millipascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.Millipascal };

        /// <summary>
        /// milli-inch
        /// </summary>
        public static Quantity MilliInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilliInch };

        /// <summary>
        /// pound per square inch absolute
        /// </summary>
        public static Quantity PoundPerSquareInchAbsolute(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundPerSquareInchAbsolute };

        /// <summary>
        /// henry
        /// </summary>
        public static Quantity Henry(decimal value) => new() { Value = value, UnitCode = QuantityCode.Henry };

        /// <summary>
        /// foot pound-force
        /// </summary>
        public static Quantity FootPoundForce(decimal value) => new() { Value = value, UnitCode = QuantityCode.FootPoundForce };

        /// <summary>
        /// pound per cubic foot
        /// </summary>
        public static Quantity PoundPerCubicFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundPerCubicFoot };

        /// <summary>
        /// poise
        /// </summary>
        public static Quantity Poise(decimal value) => new() { Value = value, UnitCode = QuantityCode.Poise };

        /// <summary>
        /// stokes
        /// </summary>
        public static Quantity Stokes(decimal value) => new() { Value = value, UnitCode = QuantityCode.Stokes };

        /// <summary>
        /// fixed rate
        /// </summary>
        public static Quantity FixedRate(decimal value) => new() { Value = value, UnitCode = QuantityCode.FixedRate };

        /// <summary>
        /// radian per second
        /// </summary>
        public static Quantity RadianPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.RadianPerSecond };

        /// <summary>
        /// radian per second squared
        /// </summary>
        public static Quantity RadianPerSecondSquared(decimal value) => new() { Value = value, UnitCode = QuantityCode.RadianPerSecondSquared };

        /// <summary>
        /// roentgen
        /// </summary>
        public static Quantity Roentgen(decimal value) => new() { Value = value, UnitCode = QuantityCode.Roentgen };

        /// <summary>
        /// volt AC
        /// </summary>
        public static Quantity VoltAC(decimal value) => new() { Value = value, UnitCode = QuantityCode.VoltAC };

        /// <summary>
        /// volt DC
        /// </summary>
        public static Quantity VoltDC(decimal value) => new() { Value = value, UnitCode = QuantityCode.VoltDC };

        /// <summary>
        /// British thermal unit (international table) per hour
        /// </summary>
        public static Quantity BritishThermalUnitInternationalTablePerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitInternationalTablePerHour };

        /// <summary>
        /// cubic centimetre per second
        /// </summary>
        public static Quantity CubicCentimetrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicCentimetrePerSecond };

        /// <summary>
        /// cubic foot per hour
        /// </summary>
        public static Quantity CubicFootPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicFootPerHour };

        /// <summary>
        /// cubic foot per minute
        /// </summary>
        public static Quantity CubicFootPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicFootPerMinute };

        /// <summary>
        /// centimetre per second
        /// </summary>
        public static Quantity CentimetrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.CentimetrePerSecond };

        /// <summary>
        /// decibel
        /// </summary>
        public static Quantity Decibel(decimal value) => new() { Value = value, UnitCode = QuantityCode.Decibel };

        /// <summary>
        /// kilobyte
        /// </summary>
        public static Quantity Kilobyte(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilobyte };

        /// <summary>
        /// kilobecquerel
        /// </summary>
        public static Quantity Kilobecquerel(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilobecquerel };

        /// <summary>
        /// kilocurie
        /// </summary>
        public static Quantity Kilocurie(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilocurie };

        /// <summary>
        /// megagram
        /// </summary>
        public static Quantity Megagram(decimal value) => new() { Value = value, UnitCode = QuantityCode.Megagram };

        /// <summary>
        /// metre per minute
        /// </summary>
        public static Quantity MetrePerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.MetrePerMinute };

        /// <summary>
        /// milliroentgen
        /// </summary>
        public static Quantity Milliroentgen(decimal value) => new() { Value = value, UnitCode = QuantityCode.Milliroentgen };

        /// <summary>
        /// millivolt
        /// </summary>
        public static Quantity Millivolt(decimal value) => new() { Value = value, UnitCode = QuantityCode.Millivolt };

        /// <summary>
        /// megajoule
        /// </summary>
        public static Quantity Megajoule(decimal value) => new() { Value = value, UnitCode = QuantityCode.Megajoule };

        /// <summary>
        /// manmonth
        /// </summary>
        public static Quantity Manmonth(decimal value) => new() { Value = value, UnitCode = QuantityCode.Manmonth };

        /// <summary>
        /// centistokes
        /// </summary>
        public static Quantity Centistokes(decimal value) => new() { Value = value, UnitCode = QuantityCode.Centistokes };

        /// <summary>
        /// microlitre
        /// </summary>
        public static Quantity Microlitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Microlitre };

        /// <summary>
        /// micrometre (micron)
        /// </summary>
        public static Quantity MicrometreMicron(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrometreMicron };

        /// <summary>
        /// milliampere
        /// </summary>
        public static Quantity Milliampere(decimal value) => new() { Value = value, UnitCode = QuantityCode.Milliampere };

        /// <summary>
        /// megabyte
        /// </summary>
        public static Quantity Megabyte(decimal value) => new() { Value = value, UnitCode = QuantityCode.Megabyte };

        /// <summary>
        /// milligram per hour
        /// </summary>
        public static Quantity MilligramPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerHour };

        /// <summary>
        /// megabecquerel
        /// </summary>
        public static Quantity Megabecquerel(decimal value) => new() { Value = value, UnitCode = QuantityCode.Megabecquerel };

        /// <summary>
        /// microfarad
        /// </summary>
        public static Quantity Microfarad(decimal value) => new() { Value = value, UnitCode = QuantityCode.Microfarad };

        /// <summary>
        /// newton per metre
        /// </summary>
        public static Quantity NewtonPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.NewtonPerMetre };

        /// <summary>
        /// ounce inch
        /// </summary>
        public static Quantity OunceInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.OunceInch };

        /// <summary>
        /// ounce foot
        /// </summary>
        public static Quantity OunceFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.OunceFoot };

        /// <summary>
        /// picofarad
        /// </summary>
        public static Quantity Picofarad(decimal value) => new() { Value = value, UnitCode = QuantityCode.Picofarad };

        /// <summary>
        /// pound per hour
        /// </summary>
        public static Quantity PoundPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundPerHour };

        /// <summary>
        /// ton (US) per hour
        /// </summary>
        public static Quantity TonUSPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonUSPerHour };

        /// <summary>
        /// kilolitre per hour
        /// </summary>
        public static Quantity KilolitrePerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilolitrePerHour };

        /// <summary>
        /// barrel (US) per minute
        /// </summary>
        public static Quantity BarrelUSPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.BarrelUSPerMinute };

        /// <summary>
        /// batch
        /// </summary>
        public static Quantity Batch(decimal value) => new() { Value = value, UnitCode = QuantityCode.Batch };

        /// <summary>
        /// MMSCF/day
        /// </summary>
        public static Quantity MMSCFDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.MMSCFDay };

        /// <summary>
        /// hydraulic horse power
        /// </summary>
        public static Quantity HydraulicHorsePower(decimal value) => new() { Value = value, UnitCode = QuantityCode.HydraulicHorsePower };

        /// <summary>
        /// ampere square metre per joule second
        /// </summary>
        public static Quantity AmpereSquareMetrePerJouleSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.AmpereSquareMetrePerJouleSecond };

        /// <summary>
        /// angstrom
        /// </summary>
        public static Quantity Angstrom(decimal value) => new() { Value = value, UnitCode = QuantityCode.Angstrom };

        /// <summary>
        /// astronomical unit
        /// </summary>
        public static Quantity AstronomicalUnit(decimal value) => new() { Value = value, UnitCode = QuantityCode.AstronomicalUnit };

        /// <summary>
        /// attojoule
        /// </summary>
        public static Quantity Attojoule(decimal value) => new() { Value = value, UnitCode = QuantityCode.Attojoule };

        /// <summary>
        /// barn
        /// </summary>
        public static Quantity Barn(decimal value) => new() { Value = value, UnitCode = QuantityCode.Barn };

        /// <summary>
        /// barn per electronvolt
        /// </summary>
        public static Quantity BarnPerElectronvolt(decimal value) => new() { Value = value, UnitCode = QuantityCode.BarnPerElectronvolt };

        /// <summary>
        /// barn per steradian electronvolt
        /// </summary>
        public static Quantity BarnPerSteradianElectronvolt(decimal value) => new() { Value = value, UnitCode = QuantityCode.BarnPerSteradianElectronvolt };

        /// <summary>
        /// barn per steradian
        /// </summary>
        public static Quantity BarnPerSteradian(decimal value) => new() { Value = value, UnitCode = QuantityCode.BarnPerSteradian };

        /// <summary>
        /// becquerel per kilogram
        /// </summary>
        public static Quantity BecquerelPerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.BecquerelPerKilogram };

        /// <summary>
        /// becquerel per cubic metre
        /// </summary>
        public static Quantity BecquerelPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.BecquerelPerCubicMetre };

        /// <summary>
        /// ampere per centimetre
        /// </summary>
        public static Quantity AmperePerCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.AmperePerCentimetre };

        /// <summary>
        /// British thermal unit (international table) per second square foot degree Rankine
        /// </summary>
        public static Quantity BritishThermalUnitInternationalTablePerSecondSquareFootDegreeRankine(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitInternationalTablePerSecondSquareFootDegreeRankine };

        /// <summary>
        /// British thermal unit (international table) per pound degree Rankine
        /// </summary>
        public static Quantity BritishThermalUnitInternationalTablePerPoundDegreeRankine(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitInternationalTablePerPoundDegreeRankine };

        /// <summary>
        /// British thermal unit (international table) per second foot degree Rankine
        /// </summary>
        public static Quantity BritishThermalUnitInternationalTablePerSecondFootDegreeRankine(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitInternationalTablePerSecondFootDegreeRankine };

        /// <summary>
        /// British thermal unit (international table) per hour square foot degree Rankine
        /// </summary>
        public static Quantity BritishThermalUnitInternationalTablePerHourSquareFootDegreeRankine(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitInternationalTablePerHourSquareFootDegreeRankine };

        /// <summary>
        /// candela per square metre
        /// </summary>
        public static Quantity CandelaPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CandelaPerSquareMetre };

        /// <summary>
        /// coulomb metre
        /// </summary>
        public static Quantity CoulombMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CoulombMetre };

        /// <summary>
        /// coulomb metre squared per volt
        /// </summary>
        public static Quantity CoulombMetreSquaredPerVolt(decimal value) => new() { Value = value, UnitCode = QuantityCode.CoulombMetreSquaredPerVolt };

        /// <summary>
        /// coulomb per cubic centimetre
        /// </summary>
        public static Quantity CoulombPerCubicCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CoulombPerCubicCentimetre };

        /// <summary>
        /// coulomb per cubic metre
        /// </summary>
        public static Quantity CoulombPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CoulombPerCubicMetre };

        /// <summary>
        /// ampere per millimetre
        /// </summary>
        public static Quantity AmperePerMillimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.AmperePerMillimetre };

        /// <summary>
        /// coulomb per cubic millimetre
        /// </summary>
        public static Quantity CoulombPerCubicMillimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CoulombPerCubicMillimetre };

        /// <summary>
        /// coulomb per kilogram second
        /// </summary>
        public static Quantity CoulombPerKilogramSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.CoulombPerKilogramSecond };

        /// <summary>
        /// coulomb per mole
        /// </summary>
        public static Quantity CoulombPerMole(decimal value) => new() { Value = value, UnitCode = QuantityCode.CoulombPerMole };

        /// <summary>
        /// coulomb per square centimetre
        /// </summary>
        public static Quantity CoulombPerSquareCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CoulombPerSquareCentimetre };

        /// <summary>
        /// coulomb per square metre
        /// </summary>
        public static Quantity CoulombPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CoulombPerSquareMetre };

        /// <summary>
        /// coulomb per square millimetre
        /// </summary>
        public static Quantity CoulombPerSquareMillimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CoulombPerSquareMillimetre };

        /// <summary>
        /// cubic centimetre per mole
        /// </summary>
        public static Quantity CubicCentimetrePerMole(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicCentimetrePerMole };

        /// <summary>
        /// cubic decimetre per mole
        /// </summary>
        public static Quantity CubicDecimetrePerMole(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicDecimetrePerMole };

        /// <summary>
        /// cubic metre per coulomb
        /// </summary>
        public static Quantity CubicMetrePerCoulomb(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetrePerCoulomb };

        /// <summary>
        /// cubic metre per kilogram
        /// </summary>
        public static Quantity CubicMetrePerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetrePerKilogram };

        /// <summary>
        /// ampere per square centimetre
        /// </summary>
        public static Quantity AmperePerSquareCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.AmperePerSquareCentimetre };

        /// <summary>
        /// cubic metre per mole
        /// </summary>
        public static Quantity CubicMetrePerMole(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetrePerMole };

        /// <summary>
        /// ampere per square metre
        /// </summary>
        public static Quantity AmperePerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.AmperePerSquareMetre };

        /// <summary>
        /// curie per kilogram
        /// </summary>
        public static Quantity CuriePerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.CuriePerKilogram };

        /// <summary>
        /// deadweight tonnage
        /// </summary>
        public static Quantity DeadweightTonnage(decimal value) => new() { Value = value, UnitCode = QuantityCode.DeadweightTonnage };

        /// <summary>
        /// decalitre
        /// </summary>
        public static Quantity Decalitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Decalitre };

        /// <summary>
        /// decametre
        /// </summary>
        public static Quantity Decametre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Decametre };

        /// <summary>
        /// decitex
        /// </summary>
        public static Quantity Decitex(decimal value) => new() { Value = value, UnitCode = QuantityCode.Decitex };

        /// <summary>
        /// degree Rankine
        /// </summary>
        public static Quantity DegreeRankine(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeRankine };

        /// <summary>
        /// denier
        /// </summary>
        public static Quantity Denier(decimal value) => new() { Value = value, UnitCode = QuantityCode.Denier };

        /// <summary>
        /// ampere square metre
        /// </summary>
        public static Quantity AmpereSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.AmpereSquareMetre };

        /// <summary>
        /// electronvolt
        /// </summary>
        public static Quantity Electronvolt(decimal value) => new() { Value = value, UnitCode = QuantityCode.Electronvolt };

        /// <summary>
        /// electronvolt per metre
        /// </summary>
        public static Quantity ElectronvoltPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.ElectronvoltPerMetre };

        /// <summary>
        /// electronvolt square metre
        /// </summary>
        public static Quantity ElectronvoltSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.ElectronvoltSquareMetre };

        /// <summary>
        /// electronvolt square metre per kilogram
        /// </summary>
        public static Quantity ElectronvoltSquareMetrePerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.ElectronvoltSquareMetrePerKilogram };

        /// <summary>
        /// 8-part cloud cover
        /// </summary>
        public static Quantity Code8PartCloudCover(decimal value) => new() { Value = value, UnitCode = QuantityCode.Code8PartCloudCover };

        /// <summary>
        /// ampere per square metre kelvin squared
        /// </summary>
        public static Quantity AmperePerSquareMetreKelvinSquared(decimal value) => new() { Value = value, UnitCode = QuantityCode.AmperePerSquareMetreKelvinSquared };

        /// <summary>
        /// exajoule
        /// </summary>
        public static Quantity Exajoule(decimal value) => new() { Value = value, UnitCode = QuantityCode.Exajoule };

        /// <summary>
        /// farad per metre
        /// </summary>
        public static Quantity FaradPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.FaradPerMetre };

        /// <summary>
        /// ampere per square millimetre
        /// </summary>
        public static Quantity AmperePerSquareMillimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.AmperePerSquareMillimetre };

        /// <summary>
        /// femtojoule
        /// </summary>
        public static Quantity Femtojoule(decimal value) => new() { Value = value, UnitCode = QuantityCode.Femtojoule };

        /// <summary>
        /// femtometre
        /// </summary>
        public static Quantity Femtometre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Femtometre };

        /// <summary>
        /// foot per second squared
        /// </summary>
        public static Quantity FootPerSecondSquared(decimal value) => new() { Value = value, UnitCode = QuantityCode.FootPerSecondSquared };

        /// <summary>
        /// foot pound-force per second
        /// </summary>
        public static Quantity FootPoundForcePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.FootPoundForcePerSecond };

        /// <summary>
        /// freight ton
        /// </summary>
        public static Quantity FreightTon(decimal value) => new() { Value = value, UnitCode = QuantityCode.FreightTon };

        /// <summary>
        /// gal
        /// </summary>
        public static Quantity Gal(decimal value) => new() { Value = value, UnitCode = QuantityCode.Gal };

        /// <summary>
        /// ampere second
        /// </summary>
        public static Quantity AmpereSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.AmpereSecond };

        /// <summary>
        /// gigacoulomb per cubic metre
        /// </summary>
        public static Quantity GigacoulombPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.GigacoulombPerCubicMetre };

        /// <summary>
        /// gigaelectronvolt
        /// </summary>
        public static Quantity Gigaelectronvolt(decimal value) => new() { Value = value, UnitCode = QuantityCode.Gigaelectronvolt };

        /// <summary>
        /// gigahertz
        /// </summary>
        public static Quantity Gigahertz(decimal value) => new() { Value = value, UnitCode = QuantityCode.Gigahertz };

        /// <summary>
        /// gigaohm
        /// </summary>
        public static Quantity Gigaohm(decimal value) => new() { Value = value, UnitCode = QuantityCode.Gigaohm };

        /// <summary>
        /// gigaohm metre
        /// </summary>
        public static Quantity GigaohmMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.GigaohmMetre };

        /// <summary>
        /// gigapascal
        /// </summary>
        public static Quantity Gigapascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.Gigapascal };

        /// <summary>
        /// rate
        /// </summary>
        public static Quantity Rate(decimal value) => new() { Value = value, UnitCode = QuantityCode.Rate };

        /// <summary>
        /// gigawatt
        /// </summary>
        public static Quantity Gigawatt(decimal value) => new() { Value = value, UnitCode = QuantityCode.Gigawatt };

        /// <summary>
        /// gon
        /// </summary>
        public static Quantity Gon(decimal value) => new() { Value = value, UnitCode = QuantityCode.Gon };

        /// <summary>
        /// gram per cubic metre
        /// </summary>
        public static Quantity GramPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerCubicMetre };

        /// <summary>
        /// gram per mole
        /// </summary>
        public static Quantity GramPerMole(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerMole };

        /// <summary>
        /// gray
        /// </summary>
        public static Quantity Gray(decimal value) => new() { Value = value, UnitCode = QuantityCode.Gray };

        /// <summary>
        /// gray per second
        /// </summary>
        public static Quantity GrayPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.GrayPerSecond };

        /// <summary>
        /// hectopascal
        /// </summary>
        public static Quantity Hectopascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.Hectopascal };

        /// <summary>
        /// henry per metre
        /// </summary>
        public static Quantity HenryPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.HenryPerMetre };

        /// <summary>
        /// bit
        /// </summary>
        public static Quantity Bit(decimal value) => new() { Value = value, UnitCode = QuantityCode.Bit };

        /// <summary>
        /// ball
        /// </summary>
        public static Quantity Ball(decimal value) => new() { Value = value, UnitCode = QuantityCode.Ball };

        /// <summary>
        /// bulk pack
        /// </summary>
        public static Quantity BulkPack(decimal value) => new() { Value = value, UnitCode = QuantityCode.BulkPack };

        /// <summary>
        /// acre
        /// </summary>
        public static Quantity Acre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Acre };

        /// <summary>
        /// activity
        /// </summary>
        public static Quantity Activity(decimal value) => new() { Value = value, UnitCode = QuantityCode.Activity };

        /// <summary>
        /// byte
        /// </summary>
        public static Quantity Byte(decimal value) => new() { Value = value, UnitCode = QuantityCode.Byte };

        /// <summary>
        /// ampere per metre
        /// </summary>
        public static Quantity AmperePerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.AmperePerMetre };

        /// <summary>
        /// additional minute
        /// </summary>
        public static Quantity AdditionalMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.AdditionalMinute };

        /// <summary>
        /// average minute per call
        /// </summary>
        public static Quantity AverageMinutePerCall(decimal value) => new() { Value = value, UnitCode = QuantityCode.AverageMinutePerCall };

        /// <summary>
        /// fathom
        /// </summary>
        public static Quantity Fathom(decimal value) => new() { Value = value, UnitCode = QuantityCode.Fathom };

        /// <summary>
        /// access line
        /// </summary>
        public static Quantity AccessLine(decimal value) => new() { Value = value, UnitCode = QuantityCode.AccessLine };

        /// <summary>
        /// ampere hour
        /// </summary>
        public static Quantity AmpereHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.AmpereHour };

        /// <summary>
        /// ampere
        /// </summary>
        public static Quantity Ampere(decimal value) => new() { Value = value, UnitCode = QuantityCode.Ampere };

        /// <summary>
        /// year
        /// </summary>
        public static Quantity Year(decimal value) => new() { Value = value, UnitCode = QuantityCode.Year };

        /// <summary>
        /// troy ounce or apothecary ounce
        /// </summary>
        public static Quantity TroyOunceOrApothecaryOunce(decimal value) => new() { Value = value, UnitCode = QuantityCode.TroyOunceOrApothecaryOunce };

        /// <summary>
        /// anti-hemophilic factor (AHF) unit
        /// </summary>
        public static Quantity AntiHemophilicFactorAHFUnit(decimal value) => new() { Value = value, UnitCode = QuantityCode.AntiHemophilicFactorAHFUnit };

        /// <summary>
        /// assortment
        /// </summary>
        public static Quantity Assortment(decimal value) => new() { Value = value, UnitCode = QuantityCode.Assortment };

        /// <summary>
        /// alcoholic strength by mass
        /// </summary>
        public static Quantity AlcoholicStrengthByMass(decimal value) => new() { Value = value, UnitCode = QuantityCode.AlcoholicStrengthByMass };

        /// <summary>
        /// alcoholic strength by volume
        /// </summary>
        public static Quantity AlcoholicStrengthByVolume(decimal value) => new() { Value = value, UnitCode = QuantityCode.AlcoholicStrengthByVolume };

        /// <summary>
        /// standard atmosphere
        /// </summary>
        public static Quantity StandardAtmosphere(decimal value) => new() { Value = value, UnitCode = QuantityCode.StandardAtmosphere };

        /// <summary>
        /// american wire gauge
        /// </summary>
        public static Quantity AmericanWireGauge(decimal value) => new() { Value = value, UnitCode = QuantityCode.AmericanWireGauge };

        /// <summary>
        /// assembly
        /// </summary>
        public static Quantity Assembly(decimal value) => new() { Value = value, UnitCode = QuantityCode.Assembly };

        /// <summary>
        /// British thermal unit (international table) per pound
        /// </summary>
        public static Quantity BritishThermalUnitInternationalTablePerPound(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitInternationalTablePerPound };

        /// <summary>
        /// barrel (US) per day
        /// </summary>
        public static Quantity BarrelUSPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.BarrelUSPerDay };

        /// <summary>
        /// bit per second
        /// </summary>
        public static Quantity BitPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.BitPerSecond };

        /// <summary>
        /// joule per kilogram kelvin
        /// </summary>
        public static Quantity JoulePerKilogramKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.JoulePerKilogramKelvin };

        /// <summary>
        /// joule per metre
        /// </summary>
        public static Quantity JoulePerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.JoulePerMetre };

        /// <summary>
        /// joule per square metre
        /// </summary>
        public static Quantity JoulePerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.JoulePerSquareMetre };

        /// <summary>
        /// joule per metre to the fourth power
        /// </summary>
        public static Quantity JoulePerMetreToTheFourthPower(decimal value) => new() { Value = value, UnitCode = QuantityCode.JoulePerMetreToTheFourthPower };

        /// <summary>
        /// joule per mole
        /// </summary>
        public static Quantity JoulePerMole(decimal value) => new() { Value = value, UnitCode = QuantityCode.JoulePerMole };

        /// <summary>
        /// joule per mole kelvin
        /// </summary>
        public static Quantity JoulePerMoleKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.JoulePerMoleKelvin };

        /// <summary>
        /// credit
        /// </summary>
        public static Quantity Credit(decimal value) => new() { Value = value, UnitCode = QuantityCode.Credit };

        /// <summary>
        /// joule second
        /// </summary>
        public static Quantity JouleSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.JouleSecond };

        /// <summary>
        /// digit
        /// </summary>
        public static Quantity Digit(decimal value) => new() { Value = value, UnitCode = QuantityCode.Digit };

        /// <summary>
        /// joule square metre per kilogram
        /// </summary>
        public static Quantity JouleSquareMetrePerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.JouleSquareMetrePerKilogram };

        /// <summary>
        /// kelvin per watt
        /// </summary>
        public static Quantity KelvinPerWatt(decimal value) => new() { Value = value, UnitCode = QuantityCode.KelvinPerWatt };

        /// <summary>
        /// kiloampere
        /// </summary>
        public static Quantity Kiloampere(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kiloampere };

        /// <summary>
        /// kiloampere per square metre
        /// </summary>
        public static Quantity KiloamperePerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KiloamperePerSquareMetre };

        /// <summary>
        /// kiloampere per metre
        /// </summary>
        public static Quantity KiloamperePerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KiloamperePerMetre };

        /// <summary>
        /// kilobecquerel per kilogram
        /// </summary>
        public static Quantity KilobecquerelPerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilobecquerelPerKilogram };

        /// <summary>
        /// kilocoulomb
        /// </summary>
        public static Quantity Kilocoulomb(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilocoulomb };

        /// <summary>
        /// kilocoulomb per cubic metre
        /// </summary>
        public static Quantity KilocoulombPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilocoulombPerCubicMetre };

        /// <summary>
        /// kilocoulomb per square metre
        /// </summary>
        public static Quantity KilocoulombPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilocoulombPerSquareMetre };

        /// <summary>
        /// kiloelectronvolt
        /// </summary>
        public static Quantity Kiloelectronvolt(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kiloelectronvolt };

        /// <summary>
        /// batting pound
        /// </summary>
        public static Quantity BattingPound(decimal value) => new() { Value = value, UnitCode = QuantityCode.BattingPound };

        /// <summary>
        /// gibibit
        /// </summary>
        public static Quantity Gibibit(decimal value) => new() { Value = value, UnitCode = QuantityCode.Gibibit };

        /// <summary>
        /// kilogram metre per second
        /// </summary>
        public static Quantity KilogramMetrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramMetrePerSecond };

        /// <summary>
        /// kilogram metre squared
        /// </summary>
        public static Quantity KilogramMetreSquared(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramMetreSquared };

        /// <summary>
        /// kilogram metre squared per second
        /// </summary>
        public static Quantity KilogramMetreSquaredPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramMetreSquaredPerSecond };

        /// <summary>
        /// kilogram per cubic decimetre
        /// </summary>
        public static Quantity KilogramPerCubicDecimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerCubicDecimetre };

        /// <summary>
        /// kilogram per litre
        /// </summary>
        public static Quantity KilogramPerLitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerLitre };

        /// <summary>
        /// barrel, imperial
        /// </summary>
        public static Quantity BarrelImperial(decimal value) => new() { Value = value, UnitCode = QuantityCode.BarrelImperial };

        /// <summary>
        /// kilojoule per kelvin
        /// </summary>
        public static Quantity KilojoulePerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilojoulePerKelvin };

        /// <summary>
        /// kilojoule per kilogram
        /// </summary>
        public static Quantity KilojoulePerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilojoulePerKilogram };

        /// <summary>
        /// kilojoule per kilogram kelvin
        /// </summary>
        public static Quantity KilojoulePerKilogramKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilojoulePerKilogramKelvin };

        /// <summary>
        /// kilojoule per mole
        /// </summary>
        public static Quantity KilojoulePerMole(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilojoulePerMole };

        /// <summary>
        /// kilomole
        /// </summary>
        public static Quantity Kilomole(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilomole };

        /// <summary>
        /// kilomole per cubic metre
        /// </summary>
        public static Quantity KilomolePerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilomolePerCubicMetre };

        /// <summary>
        /// kilonewton
        /// </summary>
        public static Quantity Kilonewton(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilonewton };

        /// <summary>
        /// kilonewton metre
        /// </summary>
        public static Quantity KilonewtonMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilonewtonMetre };

        /// <summary>
        /// kiloohm
        /// </summary>
        public static Quantity Kiloohm(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kiloohm };

        /// <summary>
        /// kiloohm metre
        /// </summary>
        public static Quantity KiloohmMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KiloohmMetre };

        /// <summary>
        /// kilosecond
        /// </summary>
        public static Quantity Kilosecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilosecond };

        /// <summary>
        /// kilosiemens
        /// </summary>
        public static Quantity Kilosiemens(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilosiemens };

        /// <summary>
        /// kilosiemens per metre
        /// </summary>
        public static Quantity KilosiemensPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilosiemensPerMetre };

        /// <summary>
        /// kilovolt per metre
        /// </summary>
        public static Quantity KilovoltPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilovoltPerMetre };

        /// <summary>
        /// kiloweber per metre
        /// </summary>
        public static Quantity KiloweberPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KiloweberPerMetre };

        /// <summary>
        /// light year
        /// </summary>
        public static Quantity LightYear(decimal value) => new() { Value = value, UnitCode = QuantityCode.LightYear };

        /// <summary>
        /// litre per mole
        /// </summary>
        public static Quantity LitrePerMole(decimal value) => new() { Value = value, UnitCode = QuantityCode.LitrePerMole };

        /// <summary>
        /// lumen hour
        /// </summary>
        public static Quantity LumenHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.LumenHour };

        /// <summary>
        /// lumen per square metre
        /// </summary>
        public static Quantity LumenPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.LumenPerSquareMetre };

        /// <summary>
        /// lumen per watt
        /// </summary>
        public static Quantity LumenPerWatt(decimal value) => new() { Value = value, UnitCode = QuantityCode.LumenPerWatt };

        /// <summary>
        /// lumen second
        /// </summary>
        public static Quantity LumenSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.LumenSecond };

        /// <summary>
        /// lux hour
        /// </summary>
        public static Quantity LuxHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.LuxHour };

        /// <summary>
        /// lux second
        /// </summary>
        public static Quantity LuxSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.LuxSecond };

        /// <summary>
        /// megaampere per square metre
        /// </summary>
        public static Quantity MegaamperePerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegaamperePerSquareMetre };

        /// <summary>
        /// megabecquerel per kilogram
        /// </summary>
        public static Quantity MegabecquerelPerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegabecquerelPerKilogram };

        /// <summary>
        /// gigabit
        /// </summary>
        public static Quantity Gigabit(decimal value) => new() { Value = value, UnitCode = QuantityCode.Gigabit };

        /// <summary>
        /// megacoulomb per cubic metre
        /// </summary>
        public static Quantity MegacoulombPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegacoulombPerCubicMetre };

        /// <summary>
        /// cycle
        /// </summary>
        public static Quantity Cycle(decimal value) => new() { Value = value, UnitCode = QuantityCode.Cycle };

        /// <summary>
        /// megacoulomb per square metre
        /// </summary>
        public static Quantity MegacoulombPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegacoulombPerSquareMetre };

        /// <summary>
        /// megaelectronvolt
        /// </summary>
        public static Quantity Megaelectronvolt(decimal value) => new() { Value = value, UnitCode = QuantityCode.Megaelectronvolt };

        /// <summary>
        /// megagram per cubic metre
        /// </summary>
        public static Quantity MegagramPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegagramPerCubicMetre };

        /// <summary>
        /// meganewton
        /// </summary>
        public static Quantity Meganewton(decimal value) => new() { Value = value, UnitCode = QuantityCode.Meganewton };

        /// <summary>
        /// meganewton metre
        /// </summary>
        public static Quantity MeganewtonMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MeganewtonMetre };

        /// <summary>
        /// megaohm
        /// </summary>
        public static Quantity Megaohm(decimal value) => new() { Value = value, UnitCode = QuantityCode.Megaohm };

        /// <summary>
        /// megaohm metre
        /// </summary>
        public static Quantity MegaohmMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegaohmMetre };

        /// <summary>
        /// megasiemens per metre
        /// </summary>
        public static Quantity MegasiemensPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegasiemensPerMetre };

        /// <summary>
        /// megavolt
        /// </summary>
        public static Quantity Megavolt(decimal value) => new() { Value = value, UnitCode = QuantityCode.Megavolt };

        /// <summary>
        /// megavolt per metre
        /// </summary>
        public static Quantity MegavoltPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegavoltPerMetre };

        /// <summary>
        /// joule per cubic metre
        /// </summary>
        public static Quantity JoulePerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.JoulePerCubicMetre };

        /// <summary>
        /// gigabit per second
        /// </summary>
        public static Quantity GigabitPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.GigabitPerSecond };

        /// <summary>
        /// reciprocal metre squared reciprocal second
        /// </summary>
        public static Quantity ReciprocalMetreSquaredReciprocalSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalMetreSquaredReciprocalSecond };

        /// <summary>
        /// inch per linear foot
        /// </summary>
        public static Quantity InchPerLinearFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.InchPerLinearFoot };

        /// <summary>
        /// metre to the fourth power
        /// </summary>
        public static Quantity MetreToTheFourthPower(decimal value) => new() { Value = value, UnitCode = QuantityCode.MetreToTheFourthPower };

        /// <summary>
        /// microampere
        /// </summary>
        public static Quantity Microampere(decimal value) => new() { Value = value, UnitCode = QuantityCode.Microampere };

        /// <summary>
        /// microbar
        /// </summary>
        public static Quantity Microbar(decimal value) => new() { Value = value, UnitCode = QuantityCode.Microbar };

        /// <summary>
        /// microcoulomb
        /// </summary>
        public static Quantity Microcoulomb(decimal value) => new() { Value = value, UnitCode = QuantityCode.Microcoulomb };

        /// <summary>
        /// microcoulomb per cubic metre
        /// </summary>
        public static Quantity MicrocoulombPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrocoulombPerCubicMetre };

        /// <summary>
        /// microcoulomb per square metre
        /// </summary>
        public static Quantity MicrocoulombPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrocoulombPerSquareMetre };

        /// <summary>
        /// microfarad per metre
        /// </summary>
        public static Quantity MicrofaradPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrofaradPerMetre };

        /// <summary>
        /// microhenry
        /// </summary>
        public static Quantity Microhenry(decimal value) => new() { Value = value, UnitCode = QuantityCode.Microhenry };

        /// <summary>
        /// microhenry per metre
        /// </summary>
        public static Quantity MicrohenryPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrohenryPerMetre };

        /// <summary>
        /// micronewton
        /// </summary>
        public static Quantity Micronewton(decimal value) => new() { Value = value, UnitCode = QuantityCode.Micronewton };

        /// <summary>
        /// micronewton metre
        /// </summary>
        public static Quantity MicronewtonMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicronewtonMetre };

        /// <summary>
        /// microohm
        /// </summary>
        public static Quantity Microohm(decimal value) => new() { Value = value, UnitCode = QuantityCode.Microohm };

        /// <summary>
        /// microohm metre
        /// </summary>
        public static Quantity MicroohmMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicroohmMetre };

        /// <summary>
        /// micropascal
        /// </summary>
        public static Quantity Micropascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.Micropascal };

        /// <summary>
        /// microradian
        /// </summary>
        public static Quantity Microradian(decimal value) => new() { Value = value, UnitCode = QuantityCode.Microradian };

        /// <summary>
        /// microsecond
        /// </summary>
        public static Quantity Microsecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.Microsecond };

        /// <summary>
        /// microsiemens
        /// </summary>
        public static Quantity Microsiemens(decimal value) => new() { Value = value, UnitCode = QuantityCode.Microsiemens };

        /// <summary>
        /// bar [unit of pressure]
        /// </summary>
        public static Quantity BarUnitOfPressure(decimal value) => new() { Value = value, UnitCode = QuantityCode.BarUnitOfPressure };

        /// <summary>
        /// base box
        /// </summary>
        public static Quantity BaseBox(decimal value) => new() { Value = value, UnitCode = QuantityCode.BaseBox };

        /// <summary>
        /// board foot
        /// </summary>
        public static Quantity BoardFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.BoardFoot };

        /// <summary>
        /// brake horse power
        /// </summary>
        public static Quantity BrakeHorsePower(decimal value) => new() { Value = value, UnitCode = QuantityCode.BrakeHorsePower };

        /// <summary>
        /// billion (EUR)
        /// </summary>
        public static Quantity BillionEUR(decimal value) => new() { Value = value, UnitCode = QuantityCode.BillionEUR };

        /// <summary>
        /// dry barrel (US)
        /// </summary>
        public static Quantity DryBarrelUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.DryBarrelUS };

        /// <summary>
        /// barrel (US)
        /// </summary>
        public static Quantity BarrelUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.BarrelUS };

        /// <summary>
        /// hundred board foot
        /// </summary>
        public static Quantity HundredBoardFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.HundredBoardFoot };

        /// <summary>
        /// beats per minute
        /// </summary>
        public static Quantity BeatsPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.BeatsPerMinute };

        /// <summary>
        /// becquerel
        /// </summary>
        public static Quantity Becquerel(decimal value) => new() { Value = value, UnitCode = QuantityCode.Becquerel };

        /// <summary>
        /// British thermal unit (international table)
        /// </summary>
        public static Quantity BritishThermalUnitInternationalTable(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitInternationalTable };

        /// <summary>
        /// bushel (US)
        /// </summary>
        public static Quantity BushelUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.BushelUS };

        /// <summary>
        /// bushel (UK)
        /// </summary>
        public static Quantity BushelUK(decimal value) => new() { Value = value, UnitCode = QuantityCode.BushelUK };

        /// <summary>
        /// call
        /// </summary>
        public static Quantity Call(decimal value) => new() { Value = value, UnitCode = QuantityCode.Call };

        /// <summary>
        /// millifarad
        /// </summary>
        public static Quantity Millifarad(decimal value) => new() { Value = value, UnitCode = QuantityCode.Millifarad };

        /// <summary>
        /// milligal
        /// </summary>
        public static Quantity Milligal(decimal value) => new() { Value = value, UnitCode = QuantityCode.Milligal };

        /// <summary>
        /// milligram per metre
        /// </summary>
        public static Quantity MilligramPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerMetre };

        /// <summary>
        /// milligray
        /// </summary>
        public static Quantity Milligray(decimal value) => new() { Value = value, UnitCode = QuantityCode.Milligray };

        /// <summary>
        /// millihenry
        /// </summary>
        public static Quantity Millihenry(decimal value) => new() { Value = value, UnitCode = QuantityCode.Millihenry };

        /// <summary>
        /// millijoule
        /// </summary>
        public static Quantity Millijoule(decimal value) => new() { Value = value, UnitCode = QuantityCode.Millijoule };

        /// <summary>
        /// millimetre per second
        /// </summary>
        public static Quantity MillimetrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillimetrePerSecond };

        /// <summary>
        /// millimetre squared per second
        /// </summary>
        public static Quantity MillimetreSquaredPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillimetreSquaredPerSecond };

        /// <summary>
        /// millimole
        /// </summary>
        public static Quantity Millimole(decimal value) => new() { Value = value, UnitCode = QuantityCode.Millimole };

        /// <summary>
        /// mole per kilogram
        /// </summary>
        public static Quantity MolePerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.MolePerKilogram };

        /// <summary>
        /// millinewton
        /// </summary>
        public static Quantity Millinewton(decimal value) => new() { Value = value, UnitCode = QuantityCode.Millinewton };

        /// <summary>
        /// kibibit
        /// </summary>
        public static Quantity Kibibit(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kibibit };

        /// <summary>
        /// millinewton per metre
        /// </summary>
        public static Quantity MillinewtonPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillinewtonPerMetre };

        /// <summary>
        /// milliohm metre
        /// </summary>
        public static Quantity MilliohmMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilliohmMetre };

        /// <summary>
        /// millipascal second
        /// </summary>
        public static Quantity MillipascalSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillipascalSecond };

        /// <summary>
        /// milliradian
        /// </summary>
        public static Quantity Milliradian(decimal value) => new() { Value = value, UnitCode = QuantityCode.Milliradian };

        /// <summary>
        /// millisecond
        /// </summary>
        public static Quantity Millisecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.Millisecond };

        /// <summary>
        /// millisiemens
        /// </summary>
        public static Quantity Millisiemens(decimal value) => new() { Value = value, UnitCode = QuantityCode.Millisiemens };

        /// <summary>
        /// millisievert
        /// </summary>
        public static Quantity Millisievert(decimal value) => new() { Value = value, UnitCode = QuantityCode.Millisievert };

        /// <summary>
        /// millitesla
        /// </summary>
        public static Quantity Millitesla(decimal value) => new() { Value = value, UnitCode = QuantityCode.Millitesla };

        /// <summary>
        /// microvolt per metre
        /// </summary>
        public static Quantity MicrovoltPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrovoltPerMetre };

        /// <summary>
        /// millivolt per metre
        /// </summary>
        public static Quantity MillivoltPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillivoltPerMetre };

        /// <summary>
        /// milliwatt
        /// </summary>
        public static Quantity Milliwatt(decimal value) => new() { Value = value, UnitCode = QuantityCode.Milliwatt };

        /// <summary>
        /// milliwatt per square metre
        /// </summary>
        public static Quantity MilliwattPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilliwattPerSquareMetre };

        /// <summary>
        /// milliweber
        /// </summary>
        public static Quantity Milliweber(decimal value) => new() { Value = value, UnitCode = QuantityCode.Milliweber };

        /// <summary>
        /// mole
        /// </summary>
        public static Quantity Mole(decimal value) => new() { Value = value, UnitCode = QuantityCode.Mole };

        /// <summary>
        /// mole per cubic decimetre
        /// </summary>
        public static Quantity MolePerCubicDecimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MolePerCubicDecimetre };

        /// <summary>
        /// mole per cubic metre
        /// </summary>
        public static Quantity MolePerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MolePerCubicMetre };

        /// <summary>
        /// kilobit
        /// </summary>
        public static Quantity Kilobit(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilobit };

        /// <summary>
        /// mole per litre
        /// </summary>
        public static Quantity MolePerLitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MolePerLitre };

        /// <summary>
        /// nanoampere
        /// </summary>
        public static Quantity Nanoampere(decimal value) => new() { Value = value, UnitCode = QuantityCode.Nanoampere };

        /// <summary>
        /// nanocoulomb
        /// </summary>
        public static Quantity Nanocoulomb(decimal value) => new() { Value = value, UnitCode = QuantityCode.Nanocoulomb };

        /// <summary>
        /// nanofarad
        /// </summary>
        public static Quantity Nanofarad(decimal value) => new() { Value = value, UnitCode = QuantityCode.Nanofarad };

        /// <summary>
        /// nanofarad per metre
        /// </summary>
        public static Quantity NanofaradPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.NanofaradPerMetre };

        /// <summary>
        /// nanohenry
        /// </summary>
        public static Quantity Nanohenry(decimal value) => new() { Value = value, UnitCode = QuantityCode.Nanohenry };

        /// <summary>
        /// nanohenry per metre
        /// </summary>
        public static Quantity NanohenryPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.NanohenryPerMetre };

        /// <summary>
        /// nanometre
        /// </summary>
        public static Quantity Nanometre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Nanometre };

        /// <summary>
        /// nanoohm metre
        /// </summary>
        public static Quantity NanoohmMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.NanoohmMetre };

        /// <summary>
        /// nanosecond
        /// </summary>
        public static Quantity Nanosecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.Nanosecond };

        /// <summary>
        /// nanotesla
        /// </summary>
        public static Quantity Nanotesla(decimal value) => new() { Value = value, UnitCode = QuantityCode.Nanotesla };

        /// <summary>
        /// nanowatt
        /// </summary>
        public static Quantity Nanowatt(decimal value) => new() { Value = value, UnitCode = QuantityCode.Nanowatt };

        /// <summary>
        /// neper
        /// </summary>
        public static Quantity Neper(decimal value) => new() { Value = value, UnitCode = QuantityCode.Neper };

        /// <summary>
        /// neper per second
        /// </summary>
        public static Quantity NeperPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.NeperPerSecond };

        /// <summary>
        /// picometre
        /// </summary>
        public static Quantity Picometre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Picometre };

        /// <summary>
        /// newton metre second
        /// </summary>
        public static Quantity NewtonMetreSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.NewtonMetreSecond };

        /// <summary>
        /// newton metre squared per kilogram squared
        /// </summary>
        public static Quantity NewtonMetreSquaredPerKilogramSquared(decimal value) => new() { Value = value, UnitCode = QuantityCode.NewtonMetreSquaredPerKilogramSquared };

        /// <summary>
        /// newton per square metre
        /// </summary>
        public static Quantity NewtonPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.NewtonPerSquareMetre };

        /// <summary>
        /// newton per square millimetre
        /// </summary>
        public static Quantity NewtonPerSquareMillimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.NewtonPerSquareMillimetre };

        /// <summary>
        /// newton second
        /// </summary>
        public static Quantity NewtonSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.NewtonSecond };

        /// <summary>
        /// newton second per metre
        /// </summary>
        public static Quantity NewtonSecondPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.NewtonSecondPerMetre };

        /// <summary>
        /// octave
        /// </summary>
        public static Quantity Octave(decimal value) => new() { Value = value, UnitCode = QuantityCode.Octave };

        /// <summary>
        /// ohm centimetre
        /// </summary>
        public static Quantity OhmCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.OhmCentimetre };

        /// <summary>
        /// ohm metre
        /// </summary>
        public static Quantity OhmMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.OhmMetre };

        /// <summary>
        /// one
        /// </summary>
        public static Quantity One(decimal value) => new() { Value = value, UnitCode = QuantityCode.One };

        /// <summary>
        /// parsec
        /// </summary>
        public static Quantity Parsec(decimal value) => new() { Value = value, UnitCode = QuantityCode.Parsec };

        /// <summary>
        /// pascal per kelvin
        /// </summary>
        public static Quantity PascalPerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.PascalPerKelvin };

        /// <summary>
        /// pascal second
        /// </summary>
        public static Quantity PascalSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.PascalSecond };

        /// <summary>
        /// pascal second per cubic metre
        /// </summary>
        public static Quantity PascalSecondPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.PascalSecondPerCubicMetre };

        /// <summary>
        /// pascal second per metre
        /// </summary>
        public static Quantity PascalSecondPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.PascalSecondPerMetre };

        /// <summary>
        /// petajoule
        /// </summary>
        public static Quantity Petajoule(decimal value) => new() { Value = value, UnitCode = QuantityCode.Petajoule };

        /// <summary>
        /// phon
        /// </summary>
        public static Quantity Phon(decimal value) => new() { Value = value, UnitCode = QuantityCode.Phon };

        /// <summary>
        /// centipoise
        /// </summary>
        public static Quantity Centipoise(decimal value) => new() { Value = value, UnitCode = QuantityCode.Centipoise };

        /// <summary>
        /// picoampere
        /// </summary>
        public static Quantity Picoampere(decimal value) => new() { Value = value, UnitCode = QuantityCode.Picoampere };

        /// <summary>
        /// picocoulomb
        /// </summary>
        public static Quantity Picocoulomb(decimal value) => new() { Value = value, UnitCode = QuantityCode.Picocoulomb };

        /// <summary>
        /// picofarad per metre
        /// </summary>
        public static Quantity PicofaradPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.PicofaradPerMetre };

        /// <summary>
        /// picohenry
        /// </summary>
        public static Quantity Picohenry(decimal value) => new() { Value = value, UnitCode = QuantityCode.Picohenry };

        /// <summary>
        /// kilobit per second
        /// </summary>
        public static Quantity KilobitPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilobitPerSecond };

        /// <summary>
        /// picowatt
        /// </summary>
        public static Quantity Picowatt(decimal value) => new() { Value = value, UnitCode = QuantityCode.Picowatt };

        /// <summary>
        /// picowatt per square metre
        /// </summary>
        public static Quantity PicowattPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.PicowattPerSquareMetre };

        /// <summary>
        /// pound-force
        /// </summary>
        public static Quantity PoundForce(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundForce };

        /// <summary>
        /// kilovolt ampere hour
        /// </summary>
        public static Quantity KilovoltAmpereHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilovoltAmpereHour };

        /// <summary>
        /// millicoulomb per kilogram
        /// </summary>
        public static Quantity MillicoulombPerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillicoulombPerKilogram };

        /// <summary>
        /// rad
        /// </summary>
        public static Quantity Rad(decimal value) => new() { Value = value, UnitCode = QuantityCode.Rad };

        /// <summary>
        /// radian
        /// </summary>
        public static Quantity Radian(decimal value) => new() { Value = value, UnitCode = QuantityCode.Radian };

        /// <summary>
        /// radian square metre per mole
        /// </summary>
        public static Quantity RadianSquareMetrePerMole(decimal value) => new() { Value = value, UnitCode = QuantityCode.RadianSquareMetrePerMole };

        /// <summary>
        /// radian square metre per kilogram
        /// </summary>
        public static Quantity RadianSquareMetrePerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.RadianSquareMetrePerKilogram };

        /// <summary>
        /// radian per metre
        /// </summary>
        public static Quantity RadianPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.RadianPerMetre };

        /// <summary>
        /// reciprocal angstrom
        /// </summary>
        public static Quantity ReciprocalAngstrom(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalAngstrom };

        /// <summary>
        /// reciprocal cubic metre
        /// </summary>
        public static Quantity ReciprocalCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalCubicMetre };

        /// <summary>
        /// reciprocal cubic metre per second
        /// </summary>
        public static Quantity ReciprocalCubicMetrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalCubicMetrePerSecond };

        /// <summary>
        /// reciprocal electron volt per cubic metre
        /// </summary>
        public static Quantity ReciprocalElectronVoltPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalElectronVoltPerCubicMetre };

        /// <summary>
        /// reciprocal henry
        /// </summary>
        public static Quantity ReciprocalHenry(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalHenry };

        /// <summary>
        /// coil group
        /// </summary>
        public static Quantity CoilGroup(decimal value) => new() { Value = value, UnitCode = QuantityCode.CoilGroup };

        /// <summary>
        /// reciprocal joule per cubic metre
        /// </summary>
        public static Quantity ReciprocalJoulePerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalJoulePerCubicMetre };

        /// <summary>
        /// reciprocal kelvin or kelvin to the power minus one
        /// </summary>
        public static Quantity ReciprocalKelvinOrKelvinToThePowerMinusOne(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalKelvinOrKelvinToThePowerMinusOne };

        /// <summary>
        /// reciprocal metre
        /// </summary>
        public static Quantity ReciprocalMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalMetre };

        /// <summary>
        /// reciprocal square metre
        /// </summary>
        public static Quantity ReciprocalSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalSquareMetre };

        /// <summary>
        /// reciprocal minute
        /// </summary>
        public static Quantity ReciprocalMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalMinute };

        /// <summary>
        /// reciprocal mole
        /// </summary>
        public static Quantity ReciprocalMole(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalMole };

        /// <summary>
        /// reciprocal pascal or pascal to the power minus one
        /// </summary>
        public static Quantity ReciprocalPascalOrPascalToThePowerMinusOne(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalPascalOrPascalToThePowerMinusOne };

        /// <summary>
        /// reciprocal second
        /// </summary>
        public static Quantity ReciprocalSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalSecond };

        /// <summary>
        /// reciprocal second per metre squared
        /// </summary>
        public static Quantity ReciprocalSecondPerMetreSquared(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalSecondPerMetreSquared };

        /// <summary>
        /// carrying capacity in metric ton
        /// </summary>
        public static Quantity CarryingCapacityInMetricTon(decimal value) => new() { Value = value, UnitCode = QuantityCode.CarryingCapacityInMetricTon };

        /// <summary>
        /// candela
        /// </summary>
        public static Quantity Candela(decimal value) => new() { Value = value, UnitCode = QuantityCode.Candela };

        /// <summary>
        /// degree Celsius
        /// </summary>
        public static Quantity DegreeCelsius(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeCelsius };

        /// <summary>
        /// hundred
        /// </summary>
        public static Quantity Hundred(decimal value) => new() { Value = value, UnitCode = QuantityCode.Hundred };

        /// <summary>
        /// card
        /// </summary>
        public static Quantity Card(decimal value) => new() { Value = value, UnitCode = QuantityCode.Card };

        /// <summary>
        /// centigram
        /// </summary>
        public static Quantity Centigram(decimal value) => new() { Value = value, UnitCode = QuantityCode.Centigram };

        /// <summary>
        /// coulomb per kilogram
        /// </summary>
        public static Quantity CoulombPerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.CoulombPerKilogram };

        /// <summary>
        /// hundred leave
        /// </summary>
        public static Quantity HundredLeave(decimal value) => new() { Value = value, UnitCode = QuantityCode.HundredLeave };

        /// <summary>
        /// centilitre
        /// </summary>
        public static Quantity Centilitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Centilitre };

        /// <summary>
        /// square centimetre
        /// </summary>
        public static Quantity SquareCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareCentimetre };

        /// <summary>
        /// cubic centimetre
        /// </summary>
        public static Quantity CubicCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicCentimetre };

        /// <summary>
        /// centimetre
        /// </summary>
        public static Quantity Centimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Centimetre };

        /// <summary>
        /// hundred pack
        /// </summary>
        public static Quantity HundredPack(decimal value) => new() { Value = value, UnitCode = QuantityCode.HundredPack };

        /// <summary>
        /// cental (UK)
        /// </summary>
        public static Quantity CentalUK(decimal value) => new() { Value = value, UnitCode = QuantityCode.CentalUK };

        /// <summary>
        /// coulomb
        /// </summary>
        public static Quantity Coulomb(decimal value) => new() { Value = value, UnitCode = QuantityCode.Coulomb };

        /// <summary>
        /// content gram
        /// </summary>
        public static Quantity ContentGram(decimal value) => new() { Value = value, UnitCode = QuantityCode.ContentGram };

        /// <summary>
        /// metric carat
        /// </summary>
        public static Quantity MetricCarat(decimal value) => new() { Value = value, UnitCode = QuantityCode.MetricCarat };

        /// <summary>
        /// content ton (metric)
        /// </summary>
        public static Quantity ContentTonMetric(decimal value) => new() { Value = value, UnitCode = QuantityCode.ContentTonMetric };

        /// <summary>
        /// curie
        /// </summary>
        public static Quantity Curie(decimal value) => new() { Value = value, UnitCode = QuantityCode.Curie };

        /// <summary>
        /// hundred pound (cwt) / hundred weight (US)
        /// </summary>
        public static Quantity HundredPoundCwtHundredWeightUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.HundredPoundCwtHundredWeightUS };

        /// <summary>
        /// hundred weight (UK)
        /// </summary>
        public static Quantity HundredWeightUK(decimal value) => new() { Value = value, UnitCode = QuantityCode.HundredWeightUK };

        /// <summary>
        /// kilowatt hour per hour
        /// </summary>
        public static Quantity KilowattHourPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilowattHourPerHour };

        /// <summary>
        /// lot [unit of weight]
        /// </summary>
        public static Quantity LotUnitOfWeight(decimal value) => new() { Value = value, UnitCode = QuantityCode.LotUnitOfWeight };

        /// <summary>
        /// reciprocal second per steradian
        /// </summary>
        public static Quantity ReciprocalSecondPerSteradian(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalSecondPerSteradian };

        /// <summary>
        /// siemens per metre
        /// </summary>
        public static Quantity SiemensPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.SiemensPerMetre };

        /// <summary>
        /// mebibit
        /// </summary>
        public static Quantity Mebibit(decimal value) => new() { Value = value, UnitCode = QuantityCode.Mebibit };

        /// <summary>
        /// siemens square metre per mole
        /// </summary>
        public static Quantity SiemensSquareMetrePerMole(decimal value) => new() { Value = value, UnitCode = QuantityCode.SiemensSquareMetrePerMole };

        /// <summary>
        /// sievert
        /// </summary>
        public static Quantity Sievert(decimal value) => new() { Value = value, UnitCode = QuantityCode.Sievert };

        /// <summary>
        /// sone
        /// </summary>
        public static Quantity Sone(decimal value) => new() { Value = value, UnitCode = QuantityCode.Sone };

        /// <summary>
        /// square centimetre per erg
        /// </summary>
        public static Quantity SquareCentimetrePerErg(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareCentimetrePerErg };

        /// <summary>
        /// square centimetre per steradian erg
        /// </summary>
        public static Quantity SquareCentimetrePerSteradianErg(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareCentimetrePerSteradianErg };

        /// <summary>
        /// metre kelvin
        /// </summary>
        public static Quantity MetreKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MetreKelvin };

        /// <summary>
        /// square metre kelvin per watt
        /// </summary>
        public static Quantity SquareMetreKelvinPerWatt(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMetreKelvinPerWatt };

        /// <summary>
        /// reciprocal second per steradian metre squared
        /// </summary>
        public static Quantity ReciprocalSecondPerSteradianMetreSquared(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalSecondPerSteradianMetreSquared };

        /// <summary>
        /// square metre per joule
        /// </summary>
        public static Quantity SquareMetrePerJoule(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMetrePerJoule };

        /// <summary>
        /// square metre per kilogram
        /// </summary>
        public static Quantity SquareMetrePerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMetrePerKilogram };

        /// <summary>
        /// square metre per mole
        /// </summary>
        public static Quantity SquareMetrePerMole(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMetrePerMole };

        /// <summary>
        /// pen gram (protein)
        /// </summary>
        public static Quantity PenGramProtein(decimal value) => new() { Value = value, UnitCode = QuantityCode.PenGramProtein };

        /// <summary>
        /// square metre per steradian
        /// </summary>
        public static Quantity SquareMetrePerSteradian(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMetrePerSteradian };

        /// <summary>
        /// square metre per steradian joule
        /// </summary>
        public static Quantity SquareMetrePerSteradianJoule(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMetrePerSteradianJoule };

        /// <summary>
        /// square metre per volt second
        /// </summary>
        public static Quantity SquareMetrePerVoltSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMetrePerVoltSecond };

        /// <summary>
        /// steradian
        /// </summary>
        public static Quantity Steradian(decimal value) => new() { Value = value, UnitCode = QuantityCode.Steradian };

        /// <summary>
        /// terahertz
        /// </summary>
        public static Quantity Terahertz(decimal value) => new() { Value = value, UnitCode = QuantityCode.Terahertz };

        /// <summary>
        /// terajoule
        /// </summary>
        public static Quantity Terajoule(decimal value) => new() { Value = value, UnitCode = QuantityCode.Terajoule };

        /// <summary>
        /// terawatt
        /// </summary>
        public static Quantity Terawatt(decimal value) => new() { Value = value, UnitCode = QuantityCode.Terawatt };

        /// <summary>
        /// terawatt hour
        /// </summary>
        public static Quantity TerawattHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.TerawattHour };

        /// <summary>
        /// tesla
        /// </summary>
        public static Quantity Tesla(decimal value) => new() { Value = value, UnitCode = QuantityCode.Tesla };

        /// <summary>
        /// tex
        /// </summary>
        public static Quantity Tex(decimal value) => new() { Value = value, UnitCode = QuantityCode.Tex };

        /// <summary>
        /// megabit
        /// </summary>
        public static Quantity Megabit(decimal value) => new() { Value = value, UnitCode = QuantityCode.Megabit };

        /// <summary>
        /// tonne per cubic metre
        /// </summary>
        public static Quantity TonnePerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonnePerCubicMetre };

        /// <summary>
        /// tropical year
        /// </summary>
        public static Quantity TropicalYear(decimal value) => new() { Value = value, UnitCode = QuantityCode.TropicalYear };

        /// <summary>
        /// unified atomic mass unit
        /// </summary>
        public static Quantity UnifiedAtomicMassUnit(decimal value) => new() { Value = value, UnitCode = QuantityCode.UnifiedAtomicMassUnit };

        /// <summary>
        /// var
        /// </summary>
        public static Quantity Var(decimal value) => new() { Value = value, UnitCode = QuantityCode.Var };

        /// <summary>
        /// volt squared per kelvin squared
        /// </summary>
        public static Quantity VoltSquaredPerKelvinSquared(decimal value) => new() { Value = value, UnitCode = QuantityCode.VoltSquaredPerKelvinSquared };

        /// <summary>
        /// volt - ampere
        /// </summary>
        public static Quantity VoltAmpere(decimal value) => new() { Value = value, UnitCode = QuantityCode.VoltAmpere };

        /// <summary>
        /// volt per centimetre
        /// </summary>
        public static Quantity VoltPerCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.VoltPerCentimetre };

        /// <summary>
        /// volt per kelvin
        /// </summary>
        public static Quantity VoltPerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.VoltPerKelvin };

        /// <summary>
        /// millivolt per kelvin
        /// </summary>
        public static Quantity MillivoltPerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillivoltPerKelvin };

        /// <summary>
        /// kilogram per square centimetre
        /// </summary>
        public static Quantity KilogramPerSquareCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerSquareCentimetre };

        /// <summary>
        /// volt per metre
        /// </summary>
        public static Quantity VoltPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.VoltPerMetre };

        /// <summary>
        /// volt per millimetre
        /// </summary>
        public static Quantity VoltPerMillimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.VoltPerMillimetre };

        /// <summary>
        /// watt per kelvin
        /// </summary>
        public static Quantity WattPerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.WattPerKelvin };

        /// <summary>
        /// watt per metre kelvin
        /// </summary>
        public static Quantity WattPerMetreKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.WattPerMetreKelvin };

        /// <summary>
        /// watt per square metre
        /// </summary>
        public static Quantity WattPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.WattPerSquareMetre };

        /// <summary>
        /// watt per square metre kelvin
        /// </summary>
        public static Quantity WattPerSquareMetreKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.WattPerSquareMetreKelvin };

        /// <summary>
        /// watt per square metre kelvin to the fourth power
        /// </summary>
        public static Quantity WattPerSquareMetreKelvinToTheFourthPower(decimal value) => new() { Value = value, UnitCode = QuantityCode.WattPerSquareMetreKelvinToTheFourthPower };

        /// <summary>
        /// watt per steradian
        /// </summary>
        public static Quantity WattPerSteradian(decimal value) => new() { Value = value, UnitCode = QuantityCode.WattPerSteradian };

        /// <summary>
        /// watt per steradian square metre
        /// </summary>
        public static Quantity WattPerSteradianSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.WattPerSteradianSquareMetre };

        /// <summary>
        /// weber per metre
        /// </summary>
        public static Quantity WeberPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.WeberPerMetre };

        /// <summary>
        /// roentgen per second
        /// </summary>
        public static Quantity RoentgenPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.RoentgenPerSecond };

        /// <summary>
        /// weber per millimetre
        /// </summary>
        public static Quantity WeberPerMillimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.WeberPerMillimetre };

        /// <summary>
        /// minute [unit of angle]
        /// </summary>
        public static Quantity MinuteUnitOfAngle(decimal value) => new() { Value = value, UnitCode = QuantityCode.MinuteUnitOfAngle };

        /// <summary>
        /// second [unit of angle]
        /// </summary>
        public static Quantity SecondUnitOfAngle(decimal value) => new() { Value = value, UnitCode = QuantityCode.SecondUnitOfAngle };

        /// <summary>
        /// book
        /// </summary>
        public static Quantity Book(decimal value) => new() { Value = value, UnitCode = QuantityCode.Book };

        /// <summary>
        /// round
        /// </summary>
        public static Quantity Round(decimal value) => new() { Value = value, UnitCode = QuantityCode.Round };

        /// <summary>
        /// number of words
        /// </summary>
        public static Quantity NumberOfWords(decimal value) => new() { Value = value, UnitCode = QuantityCode.NumberOfWords };

        /// <summary>
        /// inch to the fourth power
        /// </summary>
        public static Quantity InchToTheFourthPower(decimal value) => new() { Value = value, UnitCode = QuantityCode.InchToTheFourthPower };

        /// <summary>
        /// joule square metre
        /// </summary>
        public static Quantity JouleSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.JouleSquareMetre };

        /// <summary>
        /// kilogram per mole
        /// </summary>
        public static Quantity KilogramPerMole(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerMole };

        /// <summary>
        /// megacoulomb
        /// </summary>
        public static Quantity Megacoulomb(decimal value) => new() { Value = value, UnitCode = QuantityCode.Megacoulomb };

        /// <summary>
        /// megajoule per second
        /// </summary>
        public static Quantity MegajoulePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegajoulePerSecond };

        /// <summary>
        /// microwatt
        /// </summary>
        public static Quantity Microwatt(decimal value) => new() { Value = value, UnitCode = QuantityCode.Microwatt };

        /// <summary>
        /// microtesla
        /// </summary>
        public static Quantity Microtesla(decimal value) => new() { Value = value, UnitCode = QuantityCode.Microtesla };

        /// <summary>
        /// microvolt
        /// </summary>
        public static Quantity Microvolt(decimal value) => new() { Value = value, UnitCode = QuantityCode.Microvolt };

        /// <summary>
        /// millinewton metre
        /// </summary>
        public static Quantity MillinewtonMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillinewtonMetre };

        /// <summary>
        /// microwatt per square metre
        /// </summary>
        public static Quantity MicrowattPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrowattPerSquareMetre };

        /// <summary>
        /// millicoulomb
        /// </summary>
        public static Quantity Millicoulomb(decimal value) => new() { Value = value, UnitCode = QuantityCode.Millicoulomb };

        /// <summary>
        /// millimole per kilogram
        /// </summary>
        public static Quantity MillimolePerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillimolePerKilogram };

        /// <summary>
        /// millicoulomb per cubic metre
        /// </summary>
        public static Quantity MillicoulombPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillicoulombPerCubicMetre };

        /// <summary>
        /// millicoulomb per square metre
        /// </summary>
        public static Quantity MillicoulombPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillicoulombPerSquareMetre };

        /// <summary>
        /// rem
        /// </summary>
        public static Quantity Rem(decimal value) => new() { Value = value, UnitCode = QuantityCode.Rem };

        /// <summary>
        /// second per cubic metre
        /// </summary>
        public static Quantity SecondPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.SecondPerCubicMetre };

        /// <summary>
        /// second per cubic metre radian
        /// </summary>
        public static Quantity SecondPerCubicMetreRadian(decimal value) => new() { Value = value, UnitCode = QuantityCode.SecondPerCubicMetreRadian };

        /// <summary>
        /// joule per gram
        /// </summary>
        public static Quantity JoulePerGram(decimal value) => new() { Value = value, UnitCode = QuantityCode.JoulePerGram };

        /// <summary>
        /// decare
        /// </summary>
        public static Quantity Decare(decimal value) => new() { Value = value, UnitCode = QuantityCode.Decare };

        /// <summary>
        /// ten day
        /// </summary>
        public static Quantity TenDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.TenDay };

        /// <summary>
        /// day
        /// </summary>
        public static Quantity Day(decimal value) => new() { Value = value, UnitCode = QuantityCode.Day };

        /// <summary>
        /// dry pound
        /// </summary>
        public static Quantity DryPound(decimal value) => new() { Value = value, UnitCode = QuantityCode.DryPound };

        /// <summary>
        /// Decibel-milliwatts
        /// </summary>
        public static Quantity DecibelMilliwatts(decimal value) => new() { Value = value, UnitCode = QuantityCode.DecibelMilliwatts };

        /// <summary>
        /// Decibel watt
        /// </summary>
        public static Quantity DecibelWatt(decimal value) => new() { Value = value, UnitCode = QuantityCode.DecibelWatt };

        /// <summary>
        /// degree [unit of angle]
        /// </summary>
        public static Quantity DegreeUnitOfAngle(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeUnitOfAngle };

        /// <summary>
        /// decade
        /// </summary>
        public static Quantity Decade(decimal value) => new() { Value = value, UnitCode = QuantityCode.Decade };

        /// <summary>
        /// decigram
        /// </summary>
        public static Quantity Decigram(decimal value) => new() { Value = value, UnitCode = QuantityCode.Decigram };

        /// <summary>
        /// decagram
        /// </summary>
        public static Quantity Decagram(decimal value) => new() { Value = value, UnitCode = QuantityCode.Decagram };

        /// <summary>
        /// decilitre
        /// </summary>
        public static Quantity Decilitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Decilitre };

        /// <summary>
        /// cubic decametre
        /// </summary>
        public static Quantity CubicDecametre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicDecametre };

        /// <summary>
        /// square decimetre
        /// </summary>
        public static Quantity SquareDecimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareDecimetre };

        /// <summary>
        /// standard kilolitre
        /// </summary>
        public static Quantity StandardKilolitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.StandardKilolitre };

        /// <summary>
        /// cubic decimetre
        /// </summary>
        public static Quantity CubicDecimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicDecimetre };

        /// <summary>
        /// decimetre
        /// </summary>
        public static Quantity Decimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Decimetre };

        /// <summary>
        /// decinewton metre
        /// </summary>
        public static Quantity DecinewtonMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.DecinewtonMetre };

        /// <summary>
        /// dozen piece
        /// </summary>
        public static Quantity DozenPiece(decimal value) => new() { Value = value, UnitCode = QuantityCode.DozenPiece };

        /// <summary>
        /// dozen pair
        /// </summary>
        public static Quantity DozenPair(decimal value) => new() { Value = value, UnitCode = QuantityCode.DozenPair };

        /// <summary>
        /// displacement tonnage
        /// </summary>
        public static Quantity DisplacementTonnage(decimal value) => new() { Value = value, UnitCode = QuantityCode.DisplacementTonnage };

        /// <summary>
        /// dram (US)
        /// </summary>
        public static Quantity DramUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.DramUS };

        /// <summary>
        /// dram (UK)
        /// </summary>
        public static Quantity DramUK(decimal value) => new() { Value = value, UnitCode = QuantityCode.DramUK };

        /// <summary>
        /// dozen roll
        /// </summary>
        public static Quantity DozenRoll(decimal value) => new() { Value = value, UnitCode = QuantityCode.DozenRoll };

        /// <summary>
        /// dry ton
        /// </summary>
        public static Quantity DryTon(decimal value) => new() { Value = value, UnitCode = QuantityCode.DryTon };

        /// <summary>
        /// decitonne
        /// </summary>
        public static Quantity Decitonne(decimal value) => new() { Value = value, UnitCode = QuantityCode.Decitonne };

        /// <summary>
        /// pennyweight
        /// </summary>
        public static Quantity Pennyweight(decimal value) => new() { Value = value, UnitCode = QuantityCode.Pennyweight };

        /// <summary>
        /// dozen
        /// </summary>
        public static Quantity Dozen(decimal value) => new() { Value = value, UnitCode = QuantityCode.Dozen };

        /// <summary>
        /// dozen pack
        /// </summary>
        public static Quantity DozenPack(decimal value) => new() { Value = value, UnitCode = QuantityCode.DozenPack };

        /// <summary>
        /// newton per square centimetre
        /// </summary>
        public static Quantity NewtonPerSquareCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.NewtonPerSquareCentimetre };

        /// <summary>
        /// megawatt hour per hour
        /// </summary>
        public static Quantity MegawattHourPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegawattHourPerHour };

        /// <summary>
        /// megawatt per hertz
        /// </summary>
        public static Quantity MegawattPerHertz(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegawattPerHertz };

        /// <summary>
        /// milliampere hour
        /// </summary>
        public static Quantity MilliampereHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilliampereHour };

        /// <summary>
        /// degree day
        /// </summary>
        public static Quantity DegreeDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeDay };

        /// <summary>
        /// mille
        /// </summary>
        public static Quantity Mille(decimal value) => new() { Value = value, UnitCode = QuantityCode.Mille };

        /// <summary>
        /// kilocalorie (international table)
        /// </summary>
        public static Quantity KilocalorieInternationalTable(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilocalorieInternationalTable };

        /// <summary>
        /// kilocalorie (thermochemical) per hour
        /// </summary>
        public static Quantity KilocalorieThermochemicalPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilocalorieThermochemicalPerHour };

        /// <summary>
        /// million Btu(IT) per hour
        /// </summary>
        public static Quantity MillionBtuITPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillionBtuITPerHour };

        /// <summary>
        /// cubic foot per second
        /// </summary>
        public static Quantity CubicFootPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicFootPerSecond };

        /// <summary>
        /// tonne per hour
        /// </summary>
        public static Quantity TonnePerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonnePerHour };

        /// <summary>
        /// ping
        /// </summary>
        public static Quantity Ping(decimal value) => new() { Value = value, UnitCode = QuantityCode.Ping };

        /// <summary>
        /// megabit per second
        /// </summary>
        public static Quantity MegabitPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegabitPerSecond };

        /// <summary>
        /// shares
        /// </summary>
        public static Quantity Shares(decimal value) => new() { Value = value, UnitCode = QuantityCode.Shares };

        /// <summary>
        /// TEU
        /// </summary>
        public static Quantity TEU(decimal value) => new() { Value = value, UnitCode = QuantityCode.TEU };

        /// <summary>
        /// tyre
        /// </summary>
        public static Quantity Tyre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Tyre };

        /// <summary>
        /// active unit
        /// </summary>
        public static Quantity ActiveUnit(decimal value) => new() { Value = value, UnitCode = QuantityCode.ActiveUnit };

        /// <summary>
        /// dose
        /// </summary>
        public static Quantity Dose(decimal value) => new() { Value = value, UnitCode = QuantityCode.Dose };

        /// <summary>
        /// air dry ton
        /// </summary>
        public static Quantity AirDryTon(decimal value) => new() { Value = value, UnitCode = QuantityCode.AirDryTon };

        /// <summary>
        /// strand
        /// </summary>
        public static Quantity Strand(decimal value) => new() { Value = value, UnitCode = QuantityCode.Strand };

        /// <summary>
        /// square metre per litre
        /// </summary>
        public static Quantity SquareMetrePerLitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMetrePerLitre };

        /// <summary>
        /// litre per hour
        /// </summary>
        public static Quantity LitrePerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.LitrePerHour };

        /// <summary>
        /// foot per thousand
        /// </summary>
        public static Quantity FootPerThousand(decimal value) => new() { Value = value, UnitCode = QuantityCode.FootPerThousand };

        /// <summary>
        /// gigabyte
        /// </summary>
        public static Quantity Gigabyte(decimal value) => new() { Value = value, UnitCode = QuantityCode.Gigabyte };

        /// <summary>
        /// terabyte
        /// </summary>
        public static Quantity Terabyte(decimal value) => new() { Value = value, UnitCode = QuantityCode.Terabyte };

        /// <summary>
        /// petabyte
        /// </summary>
        public static Quantity Petabyte(decimal value) => new() { Value = value, UnitCode = QuantityCode.Petabyte };

        /// <summary>
        /// pixel
        /// </summary>
        public static Quantity Pixel(decimal value) => new() { Value = value, UnitCode = QuantityCode.Pixel };

        /// <summary>
        /// megapixel
        /// </summary>
        public static Quantity Megapixel(decimal value) => new() { Value = value, UnitCode = QuantityCode.Megapixel };

        /// <summary>
        /// dots per inch
        /// </summary>
        public static Quantity DotsPerInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.DotsPerInch };

        /// <summary>
        /// gross kilogram
        /// </summary>
        public static Quantity GrossKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.GrossKilogram };

        /// <summary>
        /// part per hundred thousand
        /// </summary>
        public static Quantity PartPerHundredThousand(decimal value) => new() { Value = value, UnitCode = QuantityCode.PartPerHundredThousand };

        /// <summary>
        /// kilogram-force per square millimetre
        /// </summary>
        public static Quantity KilogramForcePerSquareMillimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramForcePerSquareMillimetre };

        /// <summary>
        /// kilogram-force per square centimetre
        /// </summary>
        public static Quantity KilogramForcePerSquareCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramForcePerSquareCentimetre };

        /// <summary>
        /// joule per square centimetre
        /// </summary>
        public static Quantity JoulePerSquareCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.JoulePerSquareCentimetre };

        /// <summary>
        /// kilogram-force metre per square centimetre
        /// </summary>
        public static Quantity KilogramForceMetrePerSquareCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramForceMetrePerSquareCentimetre };

        /// <summary>
        /// milliohm
        /// </summary>
        public static Quantity Milliohm(decimal value) => new() { Value = value, UnitCode = QuantityCode.Milliohm };

        /// <summary>
        /// kilowatt hour per cubic metre
        /// </summary>
        public static Quantity KilowattHourPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilowattHourPerCubicMetre };

        /// <summary>
        /// kilowatt hour per kelvin
        /// </summary>
        public static Quantity KilowattHourPerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilowattHourPerKelvin };

        /// <summary>
        /// service unit
        /// </summary>
        public static Quantity ServiceUnit(decimal value) => new() { Value = value, UnitCode = QuantityCode.ServiceUnit };

        /// <summary>
        /// working day
        /// </summary>
        public static Quantity WorkingDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.WorkingDay };

        /// <summary>
        /// accounting unit
        /// </summary>
        public static Quantity AccountingUnit(decimal value) => new() { Value = value, UnitCode = QuantityCode.AccountingUnit };

        /// <summary>
        /// job
        /// </summary>
        public static Quantity Job(decimal value) => new() { Value = value, UnitCode = QuantityCode.Job };

        /// <summary>
        /// run foot
        /// </summary>
        public static Quantity RunFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.RunFoot };

        /// <summary>
        /// test
        /// </summary>
        public static Quantity Test(decimal value) => new() { Value = value, UnitCode = QuantityCode.Test };

        /// <summary>
        /// trip
        /// </summary>
        public static Quantity Trip(decimal value) => new() { Value = value, UnitCode = QuantityCode.Trip };

        /// <summary>
        /// use
        /// </summary>
        public static Quantity Use(decimal value) => new() { Value = value, UnitCode = QuantityCode.Use };

        /// <summary>
        /// well
        /// </summary>
        public static Quantity Well(decimal value) => new() { Value = value, UnitCode = QuantityCode.Well };

        /// <summary>
        /// zone
        /// </summary>
        public static Quantity Zone(decimal value) => new() { Value = value, UnitCode = QuantityCode.Zone };

        /// <summary>
        /// exabit per second
        /// </summary>
        public static Quantity ExabitPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.ExabitPerSecond };

        /// <summary>
        /// exbibyte
        /// </summary>
        public static Quantity Exbibyte(decimal value) => new() { Value = value, UnitCode = QuantityCode.Exbibyte };

        /// <summary>
        /// pebibyte
        /// </summary>
        public static Quantity Pebibyte(decimal value) => new() { Value = value, UnitCode = QuantityCode.Pebibyte };

        /// <summary>
        /// tebibyte
        /// </summary>
        public static Quantity Tebibyte(decimal value) => new() { Value = value, UnitCode = QuantityCode.Tebibyte };

        /// <summary>
        /// gibibyte
        /// </summary>
        public static Quantity Gibibyte(decimal value) => new() { Value = value, UnitCode = QuantityCode.Gibibyte };

        /// <summary>
        /// mebibyte
        /// </summary>
        public static Quantity Mebibyte(decimal value) => new() { Value = value, UnitCode = QuantityCode.Mebibyte };

        /// <summary>
        /// kibibyte
        /// </summary>
        public static Quantity Kibibyte(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kibibyte };

        /// <summary>
        /// exbibit per metre
        /// </summary>
        public static Quantity ExbibitPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.ExbibitPerMetre };

        /// <summary>
        /// exbibit per square metre
        /// </summary>
        public static Quantity ExbibitPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.ExbibitPerSquareMetre };

        /// <summary>
        /// exbibit per cubic metre
        /// </summary>
        public static Quantity ExbibitPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.ExbibitPerCubicMetre };

        /// <summary>
        /// gigabyte per second
        /// </summary>
        public static Quantity GigabytePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.GigabytePerSecond };

        /// <summary>
        /// gibibit per metre
        /// </summary>
        public static Quantity GibibitPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.GibibitPerMetre };

        /// <summary>
        /// gibibit per square metre
        /// </summary>
        public static Quantity GibibitPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.GibibitPerSquareMetre };

        /// <summary>
        /// gibibit per cubic metre
        /// </summary>
        public static Quantity GibibitPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.GibibitPerCubicMetre };

        /// <summary>
        /// kibibit per metre
        /// </summary>
        public static Quantity KibibitPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KibibitPerMetre };

        /// <summary>
        /// kibibit per square metre
        /// </summary>
        public static Quantity KibibitPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KibibitPerSquareMetre };

        /// <summary>
        /// kibibit per cubic metre
        /// </summary>
        public static Quantity KibibitPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KibibitPerCubicMetre };

        /// <summary>
        /// mebibit per metre
        /// </summary>
        public static Quantity MebibitPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MebibitPerMetre };

        /// <summary>
        /// mebibit per square metre
        /// </summary>
        public static Quantity MebibitPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MebibitPerSquareMetre };

        /// <summary>
        /// mebibit per cubic metre
        /// </summary>
        public static Quantity MebibitPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MebibitPerCubicMetre };

        /// <summary>
        /// petabit
        /// </summary>
        public static Quantity Petabit(decimal value) => new() { Value = value, UnitCode = QuantityCode.Petabit };

        /// <summary>
        /// petabit per second
        /// </summary>
        public static Quantity PetabitPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.PetabitPerSecond };

        /// <summary>
        /// pebibit per metre
        /// </summary>
        public static Quantity PebibitPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.PebibitPerMetre };

        /// <summary>
        /// pebibit per square metre
        /// </summary>
        public static Quantity PebibitPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.PebibitPerSquareMetre };

        /// <summary>
        /// pebibit per cubic metre
        /// </summary>
        public static Quantity PebibitPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.PebibitPerCubicMetre };

        /// <summary>
        /// terabit
        /// </summary>
        public static Quantity Terabit(decimal value) => new() { Value = value, UnitCode = QuantityCode.Terabit };

        /// <summary>
        /// terabit per second
        /// </summary>
        public static Quantity TerabitPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.TerabitPerSecond };

        /// <summary>
        /// tebibit per metre
        /// </summary>
        public static Quantity TebibitPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.TebibitPerMetre };

        /// <summary>
        /// tebibit per cubic metre
        /// </summary>
        public static Quantity TebibitPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.TebibitPerCubicMetre };

        /// <summary>
        /// tebibit per square metre
        /// </summary>
        public static Quantity TebibitPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.TebibitPerSquareMetre };

        /// <summary>
        /// bit per metre
        /// </summary>
        public static Quantity BitPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.BitPerMetre };

        /// <summary>
        /// bit per square metre
        /// </summary>
        public static Quantity BitPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.BitPerSquareMetre };

        /// <summary>
        /// reciprocal centimetre
        /// </summary>
        public static Quantity ReciprocalCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalCentimetre };

        /// <summary>
        /// reciprocal day
        /// </summary>
        public static Quantity ReciprocalDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalDay };

        /// <summary>
        /// cubic decimetre per hour
        /// </summary>
        public static Quantity CubicDecimetrePerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicDecimetrePerHour };

        /// <summary>
        /// kilogram per hour
        /// </summary>
        public static Quantity KilogramPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerHour };

        /// <summary>
        /// kilomole per second
        /// </summary>
        public static Quantity KilomolePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilomolePerSecond };

        /// <summary>
        /// mole per second
        /// </summary>
        public static Quantity MolePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.MolePerSecond };

        /// <summary>
        /// degree per second
        /// </summary>
        public static Quantity DegreePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreePerSecond };

        /// <summary>
        /// millimetre per degree Celcius metre
        /// </summary>
        public static Quantity MillimetrePerDegreeCelciusMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillimetrePerDegreeCelciusMetre };

        /// <summary>
        /// degree Celsius per kelvin
        /// </summary>
        public static Quantity DegreeCelsiusPerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeCelsiusPerKelvin };

        /// <summary>
        /// hectopascal per bar
        /// </summary>
        public static Quantity HectopascalPerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.HectopascalPerBar };

        /// <summary>
        /// each
        /// </summary>
        public static Quantity Each(decimal value) => new() { Value = value, UnitCode = QuantityCode.Each };

        /// <summary>
        /// electronic mail box
        /// </summary>
        public static Quantity ElectronicMailBox(decimal value) => new() { Value = value, UnitCode = QuantityCode.ElectronicMailBox };

        /// <summary>
        /// equivalent gallon
        /// </summary>
        public static Quantity EquivalentGallon(decimal value) => new() { Value = value, UnitCode = QuantityCode.EquivalentGallon };

        /// <summary>
        /// bit per cubic metre
        /// </summary>
        public static Quantity BitPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.BitPerCubicMetre };

        /// <summary>
        /// kelvin per kelvin
        /// </summary>
        public static Quantity KelvinPerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.KelvinPerKelvin };

        /// <summary>
        /// kilopascal per bar
        /// </summary>
        public static Quantity KilopascalPerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilopascalPerBar };

        /// <summary>
        /// millibar per bar
        /// </summary>
        public static Quantity MillibarPerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillibarPerBar };

        /// <summary>
        /// megapascal per bar
        /// </summary>
        public static Quantity MegapascalPerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegapascalPerBar };

        /// <summary>
        /// poise per bar
        /// </summary>
        public static Quantity PoisePerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoisePerBar };

        /// <summary>
        /// pascal per bar
        /// </summary>
        public static Quantity PascalPerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.PascalPerBar };

        /// <summary>
        /// milliampere per inch
        /// </summary>
        public static Quantity MilliamperePerInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilliamperePerInch };

        /// <summary>
        /// kelvin per hour
        /// </summary>
        public static Quantity KelvinPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.KelvinPerHour };

        /// <summary>
        /// kelvin per minute
        /// </summary>
        public static Quantity KelvinPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.KelvinPerMinute };

        /// <summary>
        /// kelvin per second
        /// </summary>
        public static Quantity KelvinPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.KelvinPerSecond };

        /// <summary>
        /// slug
        /// </summary>
        public static Quantity Slug(decimal value) => new() { Value = value, UnitCode = QuantityCode.Slug };

        /// <summary>
        /// gram per kelvin
        /// </summary>
        public static Quantity GramPerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerKelvin };

        /// <summary>
        /// kilogram per kelvin
        /// </summary>
        public static Quantity KilogramPerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerKelvin };

        /// <summary>
        /// milligram per kelvin
        /// </summary>
        public static Quantity MilligramPerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerKelvin };

        /// <summary>
        /// pound-force per foot
        /// </summary>
        public static Quantity PoundForcePerFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundForcePerFoot };

        /// <summary>
        /// kilogram square centimetre
        /// </summary>
        public static Quantity KilogramSquareCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramSquareCentimetre };

        /// <summary>
        /// kilogram square millimetre
        /// </summary>
        public static Quantity KilogramSquareMillimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramSquareMillimetre };

        /// <summary>
        /// pound inch squared
        /// </summary>
        public static Quantity PoundInchSquared(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundInchSquared };

        /// <summary>
        /// pound-force inch
        /// </summary>
        public static Quantity PoundForceInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundForceInch };

        /// <summary>
        /// pound-force foot per ampere
        /// </summary>
        public static Quantity PoundForceFootPerAmpere(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundForceFootPerAmpere };

        /// <summary>
        /// gram per cubic decimetre
        /// </summary>
        public static Quantity GramPerCubicDecimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerCubicDecimetre };

        /// <summary>
        /// kilogram per kilomol
        /// </summary>
        public static Quantity KilogramPerKilomol(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerKilomol };

        /// <summary>
        /// gram per hertz
        /// </summary>
        public static Quantity GramPerHertz(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerHertz };

        /// <summary>
        /// gram per day
        /// </summary>
        public static Quantity GramPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerDay };

        /// <summary>
        /// gram per hour
        /// </summary>
        public static Quantity GramPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerHour };

        /// <summary>
        /// gram per minute
        /// </summary>
        public static Quantity GramPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerMinute };

        /// <summary>
        /// gram per second
        /// </summary>
        public static Quantity GramPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerSecond };

        /// <summary>
        /// kilogram per day
        /// </summary>
        public static Quantity KilogramPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerDay };

        /// <summary>
        /// kilogram per minute
        /// </summary>
        public static Quantity KilogramPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerMinute };

        /// <summary>
        /// milligram per day
        /// </summary>
        public static Quantity MilligramPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerDay };

        /// <summary>
        /// milligram per minute
        /// </summary>
        public static Quantity MilligramPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerMinute };

        /// <summary>
        /// milligram per second
        /// </summary>
        public static Quantity MilligramPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerSecond };

        /// <summary>
        /// gram per day kelvin
        /// </summary>
        public static Quantity GramPerDayKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerDayKelvin };

        /// <summary>
        /// gram per hour kelvin
        /// </summary>
        public static Quantity GramPerHourKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerHourKelvin };

        /// <summary>
        /// gram per minute kelvin
        /// </summary>
        public static Quantity GramPerMinuteKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerMinuteKelvin };

        /// <summary>
        /// gram per second kelvin
        /// </summary>
        public static Quantity GramPerSecondKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerSecondKelvin };

        /// <summary>
        /// kilogram per day kelvin
        /// </summary>
        public static Quantity KilogramPerDayKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerDayKelvin };

        /// <summary>
        /// kilogram per hour kelvin
        /// </summary>
        public static Quantity KilogramPerHourKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerHourKelvin };

        /// <summary>
        /// kilogram per minute kelvin
        /// </summary>
        public static Quantity KilogramPerMinuteKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerMinuteKelvin };

        /// <summary>
        /// kilogram per second kelvin
        /// </summary>
        public static Quantity KilogramPerSecondKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerSecondKelvin };

        /// <summary>
        /// milligram per day kelvin
        /// </summary>
        public static Quantity MilligramPerDayKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerDayKelvin };

        /// <summary>
        /// milligram per hour kelvin
        /// </summary>
        public static Quantity MilligramPerHourKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerHourKelvin };

        /// <summary>
        /// milligram per minute kelvin
        /// </summary>
        public static Quantity MilligramPerMinuteKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerMinuteKelvin };

        /// <summary>
        /// milligram per second kelvin
        /// </summary>
        public static Quantity MilligramPerSecondKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerSecondKelvin };

        /// <summary>
        /// newton per millimetre
        /// </summary>
        public static Quantity NewtonPerMillimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.NewtonPerMillimetre };

        /// <summary>
        /// pound-force per inch
        /// </summary>
        public static Quantity PoundForcePerInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundForcePerInch };

        /// <summary>
        /// rod [unit of distance]
        /// </summary>
        public static Quantity RodUnitOfDistance(decimal value) => new() { Value = value, UnitCode = QuantityCode.RodUnitOfDistance };

        /// <summary>
        /// micrometre per kelvin
        /// </summary>
        public static Quantity MicrometrePerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrometrePerKelvin };

        /// <summary>
        /// centimetre per kelvin
        /// </summary>
        public static Quantity CentimetrePerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.CentimetrePerKelvin };

        /// <summary>
        /// metre per kelvin
        /// </summary>
        public static Quantity MetrePerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MetrePerKelvin };

        /// <summary>
        /// millimetre per kelvin
        /// </summary>
        public static Quantity MillimetrePerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillimetrePerKelvin };

        /// <summary>
        /// milliohm per metre
        /// </summary>
        public static Quantity MilliohmPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilliohmPerMetre };

        /// <summary>
        /// ohm per mile (statute mile)
        /// </summary>
        public static Quantity OhmPerMileStatuteMile(decimal value) => new() { Value = value, UnitCode = QuantityCode.OhmPerMileStatuteMile };

        /// <summary>
        /// ohm per kilometre
        /// </summary>
        public static Quantity OhmPerKilometre(decimal value) => new() { Value = value, UnitCode = QuantityCode.OhmPerKilometre };

        /// <summary>
        /// milliampere per pound-force per square inch
        /// </summary>
        public static Quantity MilliamperePerPoundForcePerSquareInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilliamperePerPoundForcePerSquareInch };

        /// <summary>
        /// reciprocal bar
        /// </summary>
        public static Quantity ReciprocalBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalBar };

        /// <summary>
        /// milliampere per bar
        /// </summary>
        public static Quantity MilliamperePerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilliamperePerBar };

        /// <summary>
        /// degree Celsius per bar
        /// </summary>
        public static Quantity DegreeCelsiusPerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeCelsiusPerBar };

        /// <summary>
        /// kelvin per bar
        /// </summary>
        public static Quantity KelvinPerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.KelvinPerBar };

        /// <summary>
        /// gram per day bar
        /// </summary>
        public static Quantity GramPerDayBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerDayBar };

        /// <summary>
        /// gram per hour bar
        /// </summary>
        public static Quantity GramPerHourBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerHourBar };

        /// <summary>
        /// gram per minute bar
        /// </summary>
        public static Quantity GramPerMinuteBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerMinuteBar };

        /// <summary>
        /// gram per second bar
        /// </summary>
        public static Quantity GramPerSecondBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerSecondBar };

        /// <summary>
        /// kilogram per day bar
        /// </summary>
        public static Quantity KilogramPerDayBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerDayBar };

        /// <summary>
        /// kilogram per hour bar
        /// </summary>
        public static Quantity KilogramPerHourBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerHourBar };

        /// <summary>
        /// kilogram per minute bar
        /// </summary>
        public static Quantity KilogramPerMinuteBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerMinuteBar };

        /// <summary>
        /// kilogram per second bar
        /// </summary>
        public static Quantity KilogramPerSecondBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerSecondBar };

        /// <summary>
        /// milligram per day bar
        /// </summary>
        public static Quantity MilligramPerDayBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerDayBar };

        /// <summary>
        /// milligram per hour bar
        /// </summary>
        public static Quantity MilligramPerHourBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerHourBar };

        /// <summary>
        /// milligram per minute bar
        /// </summary>
        public static Quantity MilligramPerMinuteBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerMinuteBar };

        /// <summary>
        /// milligram per second bar
        /// </summary>
        public static Quantity MilligramPerSecondBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerSecondBar };

        /// <summary>
        /// gram per bar
        /// </summary>
        public static Quantity GramPerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerBar };

        /// <summary>
        /// milligram per bar
        /// </summary>
        public static Quantity MilligramPerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerBar };

        /// <summary>
        /// milliampere per millimetre
        /// </summary>
        public static Quantity MilliamperePerMillimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilliamperePerMillimetre };

        /// <summary>
        /// pascal second per kelvin
        /// </summary>
        public static Quantity PascalSecondPerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.PascalSecondPerKelvin };

        /// <summary>
        /// inch of water
        /// </summary>
        public static Quantity InchOfWater(decimal value) => new() { Value = value, UnitCode = QuantityCode.InchOfWater };

        /// <summary>
        /// inch of mercury
        /// </summary>
        public static Quantity InchOfMercury(decimal value) => new() { Value = value, UnitCode = QuantityCode.InchOfMercury };

        /// <summary>
        /// water horse power
        /// </summary>
        public static Quantity WaterHorsePower(decimal value) => new() { Value = value, UnitCode = QuantityCode.WaterHorsePower };

        /// <summary>
        /// bar per kelvin
        /// </summary>
        public static Quantity BarPerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.BarPerKelvin };

        /// <summary>
        /// hectopascal per kelvin
        /// </summary>
        public static Quantity HectopascalPerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.HectopascalPerKelvin };

        /// <summary>
        /// kilopascal per kelvin
        /// </summary>
        public static Quantity KilopascalPerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilopascalPerKelvin };

        /// <summary>
        /// millibar per kelvin
        /// </summary>
        public static Quantity MillibarPerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillibarPerKelvin };

        /// <summary>
        /// megapascal per kelvin
        /// </summary>
        public static Quantity MegapascalPerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegapascalPerKelvin };

        /// <summary>
        /// poise per kelvin
        /// </summary>
        public static Quantity PoisePerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoisePerKelvin };

        /// <summary>
        /// volt per litre minute
        /// </summary>
        public static Quantity VoltPerLitreMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.VoltPerLitreMinute };

        /// <summary>
        /// newton centimetre
        /// </summary>
        public static Quantity NewtonCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.NewtonCentimetre };

        /// <summary>
        /// newton metre per degree
        /// </summary>
        public static Quantity NewtonMetrePerDegree(decimal value) => new() { Value = value, UnitCode = QuantityCode.NewtonMetrePerDegree };

        /// <summary>
        /// newton metre per ampere
        /// </summary>
        public static Quantity NewtonMetrePerAmpere(decimal value) => new() { Value = value, UnitCode = QuantityCode.NewtonMetrePerAmpere };

        /// <summary>
        /// bar litre per second
        /// </summary>
        public static Quantity BarLitrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.BarLitrePerSecond };

        /// <summary>
        /// bar cubic metre per second
        /// </summary>
        public static Quantity BarCubicMetrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.BarCubicMetrePerSecond };

        /// <summary>
        /// hectopascal litre per second
        /// </summary>
        public static Quantity HectopascalLitrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.HectopascalLitrePerSecond };

        /// <summary>
        /// hectopascal cubic metre per second
        /// </summary>
        public static Quantity HectopascalCubicMetrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.HectopascalCubicMetrePerSecond };

        /// <summary>
        /// millibar litre per second
        /// </summary>
        public static Quantity MillibarLitrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillibarLitrePerSecond };

        /// <summary>
        /// millibar cubic metre per second
        /// </summary>
        public static Quantity MillibarCubicMetrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillibarCubicMetrePerSecond };

        /// <summary>
        /// megapascal litre per second
        /// </summary>
        public static Quantity MegapascalLitrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegapascalLitrePerSecond };

        /// <summary>
        /// megapascal cubic metre per second
        /// </summary>
        public static Quantity MegapascalCubicMetrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegapascalCubicMetrePerSecond };

        /// <summary>
        /// pascal litre per second
        /// </summary>
        public static Quantity PascalLitrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.PascalLitrePerSecond };

        /// <summary>
        /// degree Fahrenheit
        /// </summary>
        public static Quantity DegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeFahrenheit };

        /// <summary>
        /// farad
        /// </summary>
        public static Quantity Farad(decimal value) => new() { Value = value, UnitCode = QuantityCode.Farad };

        /// <summary>
        /// fibre metre
        /// </summary>
        public static Quantity FibreMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.FibreMetre };

        /// <summary>
        /// thousand cubic foot
        /// </summary>
        public static Quantity ThousandCubicFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.ThousandCubicFoot };

        /// <summary>
        /// hundred cubic metre
        /// </summary>
        public static Quantity HundredCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.HundredCubicMetre };

        /// <summary>
        /// micromole
        /// </summary>
        public static Quantity Micromole(decimal value) => new() { Value = value, UnitCode = QuantityCode.Micromole };

        /// <summary>
        /// failures in time
        /// </summary>
        public static Quantity FailuresInTime(decimal value) => new() { Value = value, UnitCode = QuantityCode.FailuresInTime };

        /// <summary>
        /// flake ton
        /// </summary>
        public static Quantity FlakeTon(decimal value) => new() { Value = value, UnitCode = QuantityCode.FlakeTon };

        /// <summary>
        /// Formazin nephelometric unit
        /// </summary>
        public static Quantity FormazinNephelometricUnit(decimal value) => new() { Value = value, UnitCode = QuantityCode.FormazinNephelometricUnit };

        /// <summary>
        /// foot
        /// </summary>
        public static Quantity Foot(decimal value) => new() { Value = value, UnitCode = QuantityCode.Foot };

        /// <summary>
        /// pound per square foot
        /// </summary>
        public static Quantity PoundPerSquareFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundPerSquareFoot };

        /// <summary>
        /// foot per minute
        /// </summary>
        public static Quantity FootPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.FootPerMinute };

        /// <summary>
        /// foot per second
        /// </summary>
        public static Quantity FootPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.FootPerSecond };

        /// <summary>
        /// square foot
        /// </summary>
        public static Quantity SquareFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareFoot };

        /// <summary>
        /// cubic foot
        /// </summary>
        public static Quantity CubicFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicFoot };

        /// <summary>
        /// pascal cubic metre per second
        /// </summary>
        public static Quantity PascalCubicMetrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.PascalCubicMetrePerSecond };

        /// <summary>
        /// centimetre per bar
        /// </summary>
        public static Quantity CentimetrePerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.CentimetrePerBar };

        /// <summary>
        /// metre per bar
        /// </summary>
        public static Quantity MetrePerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.MetrePerBar };

        /// <summary>
        /// millimetre per bar
        /// </summary>
        public static Quantity MillimetrePerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillimetrePerBar };

        /// <summary>
        /// square inch per second
        /// </summary>
        public static Quantity SquareInchPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareInchPerSecond };

        /// <summary>
        /// square metre per second kelvin
        /// </summary>
        public static Quantity SquareMetrePerSecondKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMetrePerSecondKelvin };

        /// <summary>
        /// stokes per kelvin
        /// </summary>
        public static Quantity StokesPerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.StokesPerKelvin };

        /// <summary>
        /// gram per cubic centimetre bar
        /// </summary>
        public static Quantity GramPerCubicCentimetreBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerCubicCentimetreBar };

        /// <summary>
        /// gram per cubic decimetre bar
        /// </summary>
        public static Quantity GramPerCubicDecimetreBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerCubicDecimetreBar };

        /// <summary>
        /// gram per litre bar
        /// </summary>
        public static Quantity GramPerLitreBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerLitreBar };

        /// <summary>
        /// gram per cubic metre bar
        /// </summary>
        public static Quantity GramPerCubicMetreBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerCubicMetreBar };

        /// <summary>
        /// gram per millilitre bar
        /// </summary>
        public static Quantity GramPerMillilitreBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerMillilitreBar };

        /// <summary>
        /// kilogram per cubic centimetre bar
        /// </summary>
        public static Quantity KilogramPerCubicCentimetreBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerCubicCentimetreBar };

        /// <summary>
        /// kilogram per litre bar
        /// </summary>
        public static Quantity KilogramPerLitreBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerLitreBar };

        /// <summary>
        /// kilogram per cubic metre bar
        /// </summary>
        public static Quantity KilogramPerCubicMetreBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerCubicMetreBar };

        /// <summary>
        /// newton metre per kilogram
        /// </summary>
        public static Quantity NewtonMetrePerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.NewtonMetrePerKilogram };

        /// <summary>
        /// US gallon per minute
        /// </summary>
        public static Quantity USGallonPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.USGallonPerMinute };

        /// <summary>
        /// pound-force foot per pound
        /// </summary>
        public static Quantity PoundForceFootPerPound(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundForceFootPerPound };

        /// <summary>
        /// cup [unit of volume]
        /// </summary>
        public static Quantity CupUnitOfVolume(decimal value) => new() { Value = value, UnitCode = QuantityCode.CupUnitOfVolume };

        /// <summary>
        /// peck
        /// </summary>
        public static Quantity Peck(decimal value) => new() { Value = value, UnitCode = QuantityCode.Peck };

        /// <summary>
        /// tablespoon (US)
        /// </summary>
        public static Quantity TablespoonUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.TablespoonUS };

        /// <summary>
        /// teaspoon (US)
        /// </summary>
        public static Quantity TeaspoonUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.TeaspoonUS };

        /// <summary>
        /// stere
        /// </summary>
        public static Quantity Stere(decimal value) => new() { Value = value, UnitCode = QuantityCode.Stere };

        /// <summary>
        /// cubic centimetre per kelvin
        /// </summary>
        public static Quantity CubicCentimetrePerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicCentimetrePerKelvin };

        /// <summary>
        /// litre per kelvin
        /// </summary>
        public static Quantity LitrePerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.LitrePerKelvin };

        /// <summary>
        /// cubic metre per kelvin
        /// </summary>
        public static Quantity CubicMetrePerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetrePerKelvin };

        /// <summary>
        /// Imperial gallon per minute
        /// </summary>
        public static Quantity ImperialGallonPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.ImperialGallonPerMinute };

        /// <summary>
        /// millilitre per kelvin
        /// </summary>
        public static Quantity MillilitrePerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillilitrePerKelvin };

        /// <summary>
        /// kilogram per cubic centimetre
        /// </summary>
        public static Quantity KilogramPerCubicCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerCubicCentimetre };

        /// <summary>
        /// ounce (avoirdupois) per cubic yard
        /// </summary>
        public static Quantity OunceAvoirdupoisPerCubicYard(decimal value) => new() { Value = value, UnitCode = QuantityCode.OunceAvoirdupoisPerCubicYard };

        /// <summary>
        /// gram per cubic centimetre kelvin
        /// </summary>
        public static Quantity GramPerCubicCentimetreKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerCubicCentimetreKelvin };

        /// <summary>
        /// gram per cubic decimetre kelvin
        /// </summary>
        public static Quantity GramPerCubicDecimetreKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerCubicDecimetreKelvin };

        /// <summary>
        /// gram per litre kelvin
        /// </summary>
        public static Quantity GramPerLitreKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerLitreKelvin };

        /// <summary>
        /// gram per cubic metre kelvin
        /// </summary>
        public static Quantity GramPerCubicMetreKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerCubicMetreKelvin };

        /// <summary>
        /// gram per millilitre kelvin
        /// </summary>
        public static Quantity GramPerMillilitreKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerMillilitreKelvin };

        /// <summary>
        /// kilogram per cubic centimetre kelvin
        /// </summary>
        public static Quantity KilogramPerCubicCentimetreKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerCubicCentimetreKelvin };

        /// <summary>
        /// kilogram per litre kelvin
        /// </summary>
        public static Quantity KilogramPerLitreKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerLitreKelvin };

        /// <summary>
        /// kilogram per cubic metre kelvin
        /// </summary>
        public static Quantity KilogramPerCubicMetreKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerCubicMetreKelvin };

        /// <summary>
        /// square metre per second bar
        /// </summary>
        public static Quantity SquareMetrePerSecondBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMetrePerSecondBar };

        /// <summary>
        /// microsiemens per centimetre
        /// </summary>
        public static Quantity MicrosiemensPerCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrosiemensPerCentimetre };

        /// <summary>
        /// microsiemens per metre
        /// </summary>
        public static Quantity MicrosiemensPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrosiemensPerMetre };

        /// <summary>
        /// nanosiemens per centimetre
        /// </summary>
        public static Quantity NanosiemensPerCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.NanosiemensPerCentimetre };

        /// <summary>
        /// nanosiemens per metre
        /// </summary>
        public static Quantity NanosiemensPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.NanosiemensPerMetre };

        /// <summary>
        /// stokes per bar
        /// </summary>
        public static Quantity StokesPerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.StokesPerBar };

        /// <summary>
        /// cubic centimetre per day
        /// </summary>
        public static Quantity CubicCentimetrePerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicCentimetrePerDay };

        /// <summary>
        /// cubic centimetre per hour
        /// </summary>
        public static Quantity CubicCentimetrePerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicCentimetrePerHour };

        /// <summary>
        /// cubic centimetre per minute
        /// </summary>
        public static Quantity CubicCentimetrePerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicCentimetrePerMinute };

        /// <summary>
        /// gallon (US) per hour
        /// </summary>
        public static Quantity GallonUSPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.GallonUSPerHour };

        /// <summary>
        /// litre per second
        /// </summary>
        public static Quantity LitrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.LitrePerSecond };

        /// <summary>
        /// cubic metre per day
        /// </summary>
        public static Quantity CubicMetrePerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetrePerDay };

        /// <summary>
        /// cubic metre per minute
        /// </summary>
        public static Quantity CubicMetrePerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetrePerMinute };

        /// <summary>
        /// millilitre per day
        /// </summary>
        public static Quantity MillilitrePerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillilitrePerDay };

        /// <summary>
        /// millilitre per hour
        /// </summary>
        public static Quantity MillilitrePerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillilitrePerHour };

        /// <summary>
        /// cubic inch per hour
        /// </summary>
        public static Quantity CubicInchPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicInchPerHour };

        /// <summary>
        /// cubic inch per minute
        /// </summary>
        public static Quantity CubicInchPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicInchPerMinute };

        /// <summary>
        /// cubic inch per second
        /// </summary>
        public static Quantity CubicInchPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicInchPerSecond };

        /// <summary>
        /// milliampere per litre minute
        /// </summary>
        public static Quantity MilliamperePerLitreMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilliamperePerLitreMinute };

        /// <summary>
        /// volt per bar
        /// </summary>
        public static Quantity VoltPerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.VoltPerBar };

        /// <summary>
        /// cubic centimetre per day kelvin
        /// </summary>
        public static Quantity CubicCentimetrePerDayKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicCentimetrePerDayKelvin };

        /// <summary>
        /// cubic centimetre per hour kelvin
        /// </summary>
        public static Quantity CubicCentimetrePerHourKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicCentimetrePerHourKelvin };

        /// <summary>
        /// cubic centimetre per minute kelvin
        /// </summary>
        public static Quantity CubicCentimetrePerMinuteKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicCentimetrePerMinuteKelvin };

        /// <summary>
        /// cubic centimetre per second kelvin
        /// </summary>
        public static Quantity CubicCentimetrePerSecondKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicCentimetrePerSecondKelvin };

        /// <summary>
        /// litre per day kelvin
        /// </summary>
        public static Quantity LitrePerDayKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.LitrePerDayKelvin };

        /// <summary>
        /// litre per hour kelvin
        /// </summary>
        public static Quantity LitrePerHourKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.LitrePerHourKelvin };

        /// <summary>
        /// litre per minute kelvin
        /// </summary>
        public static Quantity LitrePerMinuteKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.LitrePerMinuteKelvin };

        /// <summary>
        /// litre per second kelvin
        /// </summary>
        public static Quantity LitrePerSecondKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.LitrePerSecondKelvin };

        /// <summary>
        /// cubic metre per day kelvin
        /// </summary>
        public static Quantity CubicMetrePerDayKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetrePerDayKelvin };

        /// <summary>
        /// cubic metre per hour kelvin
        /// </summary>
        public static Quantity CubicMetrePerHourKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetrePerHourKelvin };

        /// <summary>
        /// cubic metre per minute kelvin
        /// </summary>
        public static Quantity CubicMetrePerMinuteKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetrePerMinuteKelvin };

        /// <summary>
        /// cubic metre per second kelvin
        /// </summary>
        public static Quantity CubicMetrePerSecondKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetrePerSecondKelvin };

        /// <summary>
        /// millilitre per day kelvin
        /// </summary>
        public static Quantity MillilitrePerDayKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillilitrePerDayKelvin };

        /// <summary>
        /// millilitre per hour kelvin
        /// </summary>
        public static Quantity MillilitrePerHourKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillilitrePerHourKelvin };

        /// <summary>
        /// millilitre per minute kelvin
        /// </summary>
        public static Quantity MillilitrePerMinuteKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillilitrePerMinuteKelvin };

        /// <summary>
        /// millilitre per second kelvin
        /// </summary>
        public static Quantity MillilitrePerSecondKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillilitrePerSecondKelvin };

        /// <summary>
        /// millimetre to the fourth power
        /// </summary>
        public static Quantity MillimetreToTheFourthPower(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillimetreToTheFourthPower };

        /// <summary>
        /// cubic centimetre per day bar
        /// </summary>
        public static Quantity CubicCentimetrePerDayBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicCentimetrePerDayBar };

        /// <summary>
        /// cubic centimetre per hour bar
        /// </summary>
        public static Quantity CubicCentimetrePerHourBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicCentimetrePerHourBar };

        /// <summary>
        /// cubic centimetre per minute bar
        /// </summary>
        public static Quantity CubicCentimetrePerMinuteBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicCentimetrePerMinuteBar };

        /// <summary>
        /// cubic centimetre per second bar
        /// </summary>
        public static Quantity CubicCentimetrePerSecondBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicCentimetrePerSecondBar };

        /// <summary>
        /// litre per day bar
        /// </summary>
        public static Quantity LitrePerDayBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.LitrePerDayBar };

        /// <summary>
        /// litre per hour bar
        /// </summary>
        public static Quantity LitrePerHourBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.LitrePerHourBar };

        /// <summary>
        /// litre per minute bar
        /// </summary>
        public static Quantity LitrePerMinuteBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.LitrePerMinuteBar };

        /// <summary>
        /// litre per second bar
        /// </summary>
        public static Quantity LitrePerSecondBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.LitrePerSecondBar };

        /// <summary>
        /// cubic metre per day bar
        /// </summary>
        public static Quantity CubicMetrePerDayBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetrePerDayBar };

        /// <summary>
        /// cubic metre per hour bar
        /// </summary>
        public static Quantity CubicMetrePerHourBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetrePerHourBar };

        /// <summary>
        /// cubic metre per minute bar
        /// </summary>
        public static Quantity CubicMetrePerMinuteBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetrePerMinuteBar };

        /// <summary>
        /// cubic metre per second bar
        /// </summary>
        public static Quantity CubicMetrePerSecondBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetrePerSecondBar };

        /// <summary>
        /// millilitre per day bar
        /// </summary>
        public static Quantity MillilitrePerDayBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillilitrePerDayBar };

        /// <summary>
        /// millilitre per hour bar
        /// </summary>
        public static Quantity MillilitrePerHourBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillilitrePerHourBar };

        /// <summary>
        /// millilitre per minute bar
        /// </summary>
        public static Quantity MillilitrePerMinuteBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillilitrePerMinuteBar };

        /// <summary>
        /// millilitre per second bar
        /// </summary>
        public static Quantity MillilitrePerSecondBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillilitrePerSecondBar };

        /// <summary>
        /// cubic centimetre per bar
        /// </summary>
        public static Quantity CubicCentimetrePerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicCentimetrePerBar };

        /// <summary>
        /// litre per bar
        /// </summary>
        public static Quantity LitrePerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.LitrePerBar };

        /// <summary>
        /// cubic metre per bar
        /// </summary>
        public static Quantity CubicMetrePerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetrePerBar };

        /// <summary>
        /// millilitre per bar
        /// </summary>
        public static Quantity MillilitrePerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillilitrePerBar };

        /// <summary>
        /// microhenry per kiloohm
        /// </summary>
        public static Quantity MicrohenryPerKiloohm(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrohenryPerKiloohm };

        /// <summary>
        /// microhenry per ohm
        /// </summary>
        public static Quantity MicrohenryPerOhm(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrohenryPerOhm };

        /// <summary>
        /// gallon (US) per day
        /// </summary>
        public static Quantity GallonUSPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.GallonUSPerDay };

        /// <summary>
        /// gigabecquerel
        /// </summary>
        public static Quantity Gigabecquerel(decimal value) => new() { Value = value, UnitCode = QuantityCode.Gigabecquerel };

        /// <summary>
        /// gram, dry weight
        /// </summary>
        public static Quantity GramDryWeight(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramDryWeight };

        /// <summary>
        /// pound per gallon (US)
        /// </summary>
        public static Quantity PoundPerGallonUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundPerGallonUS };

        /// <summary>
        /// gram per metre (gram per 100 centimetres)
        /// </summary>
        public static Quantity GramPerMetreGramPer100Centimetres(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerMetreGramPer100Centimetres };

        /// <summary>
        /// gram of fissile isotope
        /// </summary>
        public static Quantity GramOfFissileIsotope(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramOfFissileIsotope };

        /// <summary>
        /// great gross
        /// </summary>
        public static Quantity GreatGross(decimal value) => new() { Value = value, UnitCode = QuantityCode.GreatGross };

        /// <summary>
        /// gill (US)
        /// </summary>
        public static Quantity GillUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.GillUS };

        /// <summary>
        /// gram, including container
        /// </summary>
        public static Quantity GramIncludingContainer(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramIncludingContainer };

        /// <summary>
        /// gill (UK)
        /// </summary>
        public static Quantity GillUK(decimal value) => new() { Value = value, UnitCode = QuantityCode.GillUK };

        /// <summary>
        /// gram, including inner packaging
        /// </summary>
        public static Quantity GramIncludingInnerPackaging(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramIncludingInnerPackaging };

        /// <summary>
        /// gram per millilitre
        /// </summary>
        public static Quantity GramPerMillilitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerMillilitre };

        /// <summary>
        /// gram per litre
        /// </summary>
        public static Quantity GramPerLitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerLitre };

        /// <summary>
        /// dry gallon (US)
        /// </summary>
        public static Quantity DryGallonUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.DryGallonUS };

        /// <summary>
        /// gallon (UK)
        /// </summary>
        public static Quantity GallonUK(decimal value) => new() { Value = value, UnitCode = QuantityCode.GallonUK };

        /// <summary>
        /// gallon (US)
        /// </summary>
        public static Quantity GallonUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.GallonUS };

        /// <summary>
        /// gram per square metre
        /// </summary>
        public static Quantity GramPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerSquareMetre };

        /// <summary>
        /// milligram per square metre
        /// </summary>
        public static Quantity MilligramPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerSquareMetre };

        /// <summary>
        /// milligram per cubic metre
        /// </summary>
        public static Quantity MilligramPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerCubicMetre };

        /// <summary>
        /// microgram per cubic metre
        /// </summary>
        public static Quantity MicrogramPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrogramPerCubicMetre };

        /// <summary>
        /// gram
        /// </summary>
        public static Quantity Gram(decimal value) => new() { Value = value, UnitCode = QuantityCode.Gram };

        /// <summary>
        /// grain
        /// </summary>
        public static Quantity Grain(decimal value) => new() { Value = value, UnitCode = QuantityCode.Grain };

        /// <summary>
        /// gross
        /// </summary>
        public static Quantity Gross(decimal value) => new() { Value = value, UnitCode = QuantityCode.Gross };

        /// <summary>
        /// gigajoule
        /// </summary>
        public static Quantity Gigajoule(decimal value) => new() { Value = value, UnitCode = QuantityCode.Gigajoule };

        /// <summary>
        /// gigawatt hour
        /// </summary>
        public static Quantity GigawattHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.GigawattHour };

        /// <summary>
        /// henry per kiloohm
        /// </summary>
        public static Quantity HenryPerKiloohm(decimal value) => new() { Value = value, UnitCode = QuantityCode.HenryPerKiloohm };

        /// <summary>
        /// henry per ohm
        /// </summary>
        public static Quantity HenryPerOhm(decimal value) => new() { Value = value, UnitCode = QuantityCode.HenryPerOhm };

        /// <summary>
        /// millihenry per kiloohm
        /// </summary>
        public static Quantity MillihenryPerKiloohm(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillihenryPerKiloohm };

        /// <summary>
        /// millihenry per ohm
        /// </summary>
        public static Quantity MillihenryPerOhm(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillihenryPerOhm };

        /// <summary>
        /// pascal second per bar
        /// </summary>
        public static Quantity PascalSecondPerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.PascalSecondPerBar };

        /// <summary>
        /// microbecquerel
        /// </summary>
        public static Quantity Microbecquerel(decimal value) => new() { Value = value, UnitCode = QuantityCode.Microbecquerel };

        /// <summary>
        /// reciprocal year
        /// </summary>
        public static Quantity ReciprocalYear(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalYear };

        /// <summary>
        /// reciprocal hour
        /// </summary>
        public static Quantity ReciprocalHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalHour };

        /// <summary>
        /// reciprocal month
        /// </summary>
        public static Quantity ReciprocalMonth(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalMonth };

        /// <summary>
        /// degree Celsius per hour
        /// </summary>
        public static Quantity DegreeCelsiusPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeCelsiusPerHour };

        /// <summary>
        /// degree Celsius per minute
        /// </summary>
        public static Quantity DegreeCelsiusPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeCelsiusPerMinute };

        /// <summary>
        /// degree Celsius per second
        /// </summary>
        public static Quantity DegreeCelsiusPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeCelsiusPerSecond };

        /// <summary>
        /// square centimetre per gram
        /// </summary>
        public static Quantity SquareCentimetrePerGram(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareCentimetrePerGram };

        /// <summary>
        /// square decametre
        /// </summary>
        public static Quantity SquareDecametre(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareDecametre };

        /// <summary>
        /// square hectometre
        /// </summary>
        public static Quantity SquareHectometre(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareHectometre };

        /// <summary>
        /// cubic hectometre
        /// </summary>
        public static Quantity CubicHectometre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicHectometre };

        /// <summary>
        /// cubic kilometre
        /// </summary>
        public static Quantity CubicKilometre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicKilometre };

        /// <summary>
        /// blank
        /// </summary>
        public static Quantity Blank(decimal value) => new() { Value = value, UnitCode = QuantityCode.Blank };

        /// <summary>
        /// volt square inch per pound-force
        /// </summary>
        public static Quantity VoltSquareInchPerPoundForce(decimal value) => new() { Value = value, UnitCode = QuantityCode.VoltSquareInchPerPoundForce };

        /// <summary>
        /// volt per inch
        /// </summary>
        public static Quantity VoltPerInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.VoltPerInch };

        /// <summary>
        /// volt per microsecond
        /// </summary>
        public static Quantity VoltPerMicrosecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.VoltPerMicrosecond };

        /// <summary>
        /// percent per kelvin
        /// </summary>
        public static Quantity PercentPerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.PercentPerKelvin };

        /// <summary>
        /// ohm per metre
        /// </summary>
        public static Quantity OhmPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.OhmPerMetre };

        /// <summary>
        /// degree per metre
        /// </summary>
        public static Quantity DegreePerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreePerMetre };

        /// <summary>
        /// microfarad per kilometre
        /// </summary>
        public static Quantity MicrofaradPerKilometre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrofaradPerKilometre };

        /// <summary>
        /// microgram per litre
        /// </summary>
        public static Quantity MicrogramPerLitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrogramPerLitre };

        /// <summary>
        /// square micrometre (square micron)
        /// </summary>
        public static Quantity SquareMicrometreSquareMicron(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMicrometreSquareMicron };

        /// <summary>
        /// ampere per kilogram
        /// </summary>
        public static Quantity AmperePerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.AmperePerKilogram };

        /// <summary>
        /// ampere squared second
        /// </summary>
        public static Quantity AmpereSquaredSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.AmpereSquaredSecond };

        /// <summary>
        /// farad per kilometre
        /// </summary>
        public static Quantity FaradPerKilometre(decimal value) => new() { Value = value, UnitCode = QuantityCode.FaradPerKilometre };

        /// <summary>
        /// hertz metre
        /// </summary>
        public static Quantity HertzMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.HertzMetre };

        /// <summary>
        /// kelvin metre per watt
        /// </summary>
        public static Quantity KelvinMetrePerWatt(decimal value) => new() { Value = value, UnitCode = QuantityCode.KelvinMetrePerWatt };

        /// <summary>
        /// megaohm per kilometre
        /// </summary>
        public static Quantity MegaohmPerKilometre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegaohmPerKilometre };

        /// <summary>
        /// megaohm per metre
        /// </summary>
        public static Quantity MegaohmPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegaohmPerMetre };

        /// <summary>
        /// megaampere
        /// </summary>
        public static Quantity Megaampere(decimal value) => new() { Value = value, UnitCode = QuantityCode.Megaampere };

        /// <summary>
        /// megahertz kilometre
        /// </summary>
        public static Quantity MegahertzKilometre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegahertzKilometre };

        /// <summary>
        /// newton per ampere
        /// </summary>
        public static Quantity NewtonPerAmpere(decimal value) => new() { Value = value, UnitCode = QuantityCode.NewtonPerAmpere };

        /// <summary>
        /// newton metre watt to the power minus 0,5
        /// </summary>
        public static Quantity NewtonMetreWattToThePowerMinus05(decimal value) => new() { Value = value, UnitCode = QuantityCode.NewtonMetreWattToThePowerMinus05 };

        /// <summary>
        /// pascal per metre
        /// </summary>
        public static Quantity PascalPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.PascalPerMetre };

        /// <summary>
        /// siemens per centimetre
        /// </summary>
        public static Quantity SiemensPerCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.SiemensPerCentimetre };

        /// <summary>
        /// teraohm
        /// </summary>
        public static Quantity Teraohm(decimal value) => new() { Value = value, UnitCode = QuantityCode.Teraohm };

        /// <summary>
        /// volt second per metre
        /// </summary>
        public static Quantity VoltSecondPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.VoltSecondPerMetre };

        /// <summary>
        /// volt per second
        /// </summary>
        public static Quantity VoltPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.VoltPerSecond };

        /// <summary>
        /// watt per cubic metre
        /// </summary>
        public static Quantity WattPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.WattPerCubicMetre };

        /// <summary>
        /// attofarad
        /// </summary>
        public static Quantity Attofarad(decimal value) => new() { Value = value, UnitCode = QuantityCode.Attofarad };

        /// <summary>
        /// centimetre per hour
        /// </summary>
        public static Quantity CentimetrePerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.CentimetrePerHour };

        /// <summary>
        /// reciprocal cubic centimetre
        /// </summary>
        public static Quantity ReciprocalCubicCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalCubicCentimetre };

        /// <summary>
        /// decibel per kilometre
        /// </summary>
        public static Quantity DecibelPerKilometre(decimal value) => new() { Value = value, UnitCode = QuantityCode.DecibelPerKilometre };

        /// <summary>
        /// decibel per metre
        /// </summary>
        public static Quantity DecibelPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.DecibelPerMetre };

        /// <summary>
        /// kilogram per bar
        /// </summary>
        public static Quantity KilogramPerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerBar };

        /// <summary>
        /// kilogram per cubic decimetre kelvin
        /// </summary>
        public static Quantity KilogramPerCubicDecimetreKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerCubicDecimetreKelvin };

        /// <summary>
        /// kilogram per cubic decimetre bar
        /// </summary>
        public static Quantity KilogramPerCubicDecimetreBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerCubicDecimetreBar };

        /// <summary>
        /// kilogram per square metre second
        /// </summary>
        public static Quantity KilogramPerSquareMetreSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerSquareMetreSecond };

        /// <summary>
        /// inch per two pi radiant
        /// </summary>
        public static Quantity InchPerTwoPiRadiant(decimal value) => new() { Value = value, UnitCode = QuantityCode.InchPerTwoPiRadiant };

        /// <summary>
        /// metre per volt second
        /// </summary>
        public static Quantity MetrePerVoltSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.MetrePerVoltSecond };

        /// <summary>
        /// square metre per newton
        /// </summary>
        public static Quantity SquareMetrePerNewton(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMetrePerNewton };

        /// <summary>
        /// cubic metre per cubic metre
        /// </summary>
        public static Quantity CubicMetrePerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetrePerCubicMetre };

        /// <summary>
        /// millisiemens per centimetre
        /// </summary>
        public static Quantity MillisiemensPerCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillisiemensPerCentimetre };

        /// <summary>
        /// millivolt per minute
        /// </summary>
        public static Quantity MillivoltPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillivoltPerMinute };

        /// <summary>
        /// milligram per square centimetre
        /// </summary>
        public static Quantity MilligramPerSquareCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerSquareCentimetre };

        /// <summary>
        /// milligram per gram
        /// </summary>
        public static Quantity MilligramPerGram(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerGram };

        /// <summary>
        /// millilitre per cubic metre
        /// </summary>
        public static Quantity MillilitrePerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillilitrePerCubicMetre };

        /// <summary>
        /// millimetre per year
        /// </summary>
        public static Quantity MillimetrePerYear(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillimetrePerYear };

        /// <summary>
        /// millimetre per hour
        /// </summary>
        public static Quantity MillimetrePerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillimetrePerHour };

        /// <summary>
        /// millimole per gram
        /// </summary>
        public static Quantity MillimolePerGram(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillimolePerGram };

        /// <summary>
        /// picopascal per kilometre
        /// </summary>
        public static Quantity PicopascalPerKilometre(decimal value) => new() { Value = value, UnitCode = QuantityCode.PicopascalPerKilometre };

        /// <summary>
        /// picosecond
        /// </summary>
        public static Quantity Picosecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.Picosecond };

        /// <summary>
        /// percent per month
        /// </summary>
        public static Quantity PercentPerMonth(decimal value) => new() { Value = value, UnitCode = QuantityCode.PercentPerMonth };

        /// <summary>
        /// percent per hectobar
        /// </summary>
        public static Quantity PercentPerHectobar(decimal value) => new() { Value = value, UnitCode = QuantityCode.PercentPerHectobar };

        /// <summary>
        /// percent per decakelvin
        /// </summary>
        public static Quantity PercentPerDecakelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.PercentPerDecakelvin };

        /// <summary>
        /// watt per metre
        /// </summary>
        public static Quantity WattPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.WattPerMetre };

        /// <summary>
        /// decapascal
        /// </summary>
        public static Quantity Decapascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.Decapascal };

        /// <summary>
        /// gram per millimetre
        /// </summary>
        public static Quantity GramPerMillimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerMillimetre };

        /// <summary>
        /// module width
        /// </summary>
        public static Quantity ModuleWidth(decimal value) => new() { Value = value, UnitCode = QuantityCode.ModuleWidth };

        /// <summary>
        /// French gauge
        /// </summary>
        public static Quantity FrenchGauge(decimal value) => new() { Value = value, UnitCode = QuantityCode.FrenchGauge };

        /// <summary>
        /// rack unit
        /// </summary>
        public static Quantity RackUnit(decimal value) => new() { Value = value, UnitCode = QuantityCode.RackUnit };

        /// <summary>
        /// millimetre per minute
        /// </summary>
        public static Quantity MillimetrePerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillimetrePerMinute };

        /// <summary>
        /// big point
        /// </summary>
        public static Quantity BigPoint(decimal value) => new() { Value = value, UnitCode = QuantityCode.BigPoint };

        /// <summary>
        /// litre per kilogram
        /// </summary>
        public static Quantity LitrePerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.LitrePerKilogram };

        /// <summary>
        /// gram millimetre
        /// </summary>
        public static Quantity GramMillimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramMillimetre };

        /// <summary>
        /// reciprocal week
        /// </summary>
        public static Quantity ReciprocalWeek(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalWeek };

        /// <summary>
        /// megaohm kilometre
        /// </summary>
        public static Quantity MegaohmKilometre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegaohmKilometre };

        /// <summary>
        /// percent per ohm
        /// </summary>
        public static Quantity PercentPerOhm(decimal value) => new() { Value = value, UnitCode = QuantityCode.PercentPerOhm };

        /// <summary>
        /// percent per degree
        /// </summary>
        public static Quantity PercentPerDegree(decimal value) => new() { Value = value, UnitCode = QuantityCode.PercentPerDegree };

        /// <summary>
        /// percent per ten thousand
        /// </summary>
        public static Quantity PercentPerTenThousand(decimal value) => new() { Value = value, UnitCode = QuantityCode.PercentPerTenThousand };

        /// <summary>
        /// percent per one hundred thousand
        /// </summary>
        public static Quantity PercentPerOneHundredThousand(decimal value) => new() { Value = value, UnitCode = QuantityCode.PercentPerOneHundredThousand };

        /// <summary>
        /// percent per hundred
        /// </summary>
        public static Quantity PercentPerHundred(decimal value) => new() { Value = value, UnitCode = QuantityCode.PercentPerHundred };

        /// <summary>
        /// percent per thousand
        /// </summary>
        public static Quantity PercentPerThousand(decimal value) => new() { Value = value, UnitCode = QuantityCode.PercentPerThousand };

        /// <summary>
        /// percent per volt
        /// </summary>
        public static Quantity PercentPerVolt(decimal value) => new() { Value = value, UnitCode = QuantityCode.PercentPerVolt };

        /// <summary>
        /// percent per bar
        /// </summary>
        public static Quantity PercentPerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.PercentPerBar };

        /// <summary>
        /// percent per inch
        /// </summary>
        public static Quantity PercentPerInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.PercentPerInch };

        /// <summary>
        /// percent per metre
        /// </summary>
        public static Quantity PercentPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.PercentPerMetre };

        /// <summary>
        /// hank
        /// </summary>
        public static Quantity Hank(decimal value) => new() { Value = value, UnitCode = QuantityCode.Hank };

        /// <summary>
        /// Piece Day
        /// </summary>
        public static Quantity PieceDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.PieceDay };

        /// <summary>
        /// hectobar
        /// </summary>
        public static Quantity Hectobar(decimal value) => new() { Value = value, UnitCode = QuantityCode.Hectobar };

        /// <summary>
        /// hundred boxes
        /// </summary>
        public static Quantity HundredBoxes(decimal value) => new() { Value = value, UnitCode = QuantityCode.HundredBoxes };

        /// <summary>
        /// hundred count
        /// </summary>
        public static Quantity HundredCount(decimal value) => new() { Value = value, UnitCode = QuantityCode.HundredCount };

        /// <summary>
        /// hundred kilogram, dry weight
        /// </summary>
        public static Quantity HundredKilogramDryWeight(decimal value) => new() { Value = value, UnitCode = QuantityCode.HundredKilogramDryWeight };

        /// <summary>
        /// head
        /// </summary>
        public static Quantity Head(decimal value) => new() { Value = value, UnitCode = QuantityCode.Head };

        /// <summary>
        /// hectogram
        /// </summary>
        public static Quantity Hectogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.Hectogram };

        /// <summary>
        /// hundred cubic foot
        /// </summary>
        public static Quantity HundredCubicFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.HundredCubicFoot };

        /// <summary>
        /// hundred international unit
        /// </summary>
        public static Quantity HundredInternationalUnit(decimal value) => new() { Value = value, UnitCode = QuantityCode.HundredInternationalUnit };

        /// <summary>
        /// hundred kilogram, net mass
        /// </summary>
        public static Quantity HundredKilogramNetMass(decimal value) => new() { Value = value, UnitCode = QuantityCode.HundredKilogramNetMass };

        /// <summary>
        /// hectolitre
        /// </summary>
        public static Quantity Hectolitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Hectolitre };

        /// <summary>
        /// mile per hour (statute mile)
        /// </summary>
        public static Quantity MilePerHourStatuteMile(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilePerHourStatuteMile };

        /// <summary>
        /// Piece Month
        /// </summary>
        public static Quantity PieceMonth(decimal value) => new() { Value = value, UnitCode = QuantityCode.PieceMonth };

        /// <summary>
        /// million cubic metre
        /// </summary>
        public static Quantity MillionCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillionCubicMetre };

        /// <summary>
        /// hectometre
        /// </summary>
        public static Quantity Hectometre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Hectometre };

        /// <summary>
        /// hectolitre of pure alcohol
        /// </summary>
        public static Quantity HectolitreOfPureAlcohol(decimal value) => new() { Value = value, UnitCode = QuantityCode.HectolitreOfPureAlcohol };

        /// <summary>
        /// hertz
        /// </summary>
        public static Quantity Hertz(decimal value) => new() { Value = value, UnitCode = QuantityCode.Hertz };

        /// <summary>
        /// Piece Week
        /// </summary>
        public static Quantity PieceWeek(decimal value) => new() { Value = value, UnitCode = QuantityCode.PieceWeek };

        /// <summary>
        /// inch pound (pound inch)
        /// </summary>
        public static Quantity InchPoundPoundInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.InchPoundPoundInch };

        /// <summary>
        /// person
        /// </summary>
        public static Quantity Person(decimal value) => new() { Value = value, UnitCode = QuantityCode.Person };

        /// <summary>
        /// inch
        /// </summary>
        public static Quantity Inch(decimal value) => new() { Value = value, UnitCode = QuantityCode.Inch };

        /// <summary>
        /// square inch
        /// </summary>
        public static Quantity SquareInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareInch };

        /// <summary>
        /// cubic inch
        /// </summary>
        public static Quantity CubicInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicInch };

        /// <summary>
        /// international sugar degree
        /// </summary>
        public static Quantity InternationalSugarDegree(decimal value) => new() { Value = value, UnitCode = QuantityCode.InternationalSugarDegree };

        /// <summary>
        /// inch per second
        /// </summary>
        public static Quantity InchPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.InchPerSecond };

        /// <summary>
        /// international unit per gram
        /// </summary>
        public static Quantity InternationalUnitPerGram(decimal value) => new() { Value = value, UnitCode = QuantityCode.InternationalUnitPerGram };

        /// <summary>
        /// inch per second squared
        /// </summary>
        public static Quantity InchPerSecondSquared(decimal value) => new() { Value = value, UnitCode = QuantityCode.InchPerSecondSquared };

        /// <summary>
        /// percent per millimetre
        /// </summary>
        public static Quantity PercentPerMillimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.PercentPerMillimetre };

        /// <summary>
        /// per mille per psi
        /// </summary>
        public static Quantity PerMillePerPsi(decimal value) => new() { Value = value, UnitCode = QuantityCode.PerMillePerPsi };

        /// <summary>
        /// degree API
        /// </summary>
        public static Quantity DegreeAPI(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeAPI };

        /// <summary>
        /// degree Baume (origin scale)
        /// </summary>
        public static Quantity DegreeBaumeOriginScale(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeBaumeOriginScale };

        /// <summary>
        /// degree Baume (US heavy)
        /// </summary>
        public static Quantity DegreeBaumeUSHeavy(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeBaumeUSHeavy };

        /// <summary>
        /// degree Baume (US light)
        /// </summary>
        public static Quantity DegreeBaumeUSLight(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeBaumeUSLight };

        /// <summary>
        /// degree Balling
        /// </summary>
        public static Quantity DegreeBalling(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeBalling };

        /// <summary>
        /// degree Brix
        /// </summary>
        public static Quantity DegreeBrix(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeBrix };

        /// <summary>
        /// degree Fahrenheit hour square foot per British thermal unit (thermochemical)
        /// </summary>
        public static Quantity DegreeFahrenheitHourSquareFootPerBritishThermalUnitThermochemical(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeFahrenheitHourSquareFootPerBritishThermalUnitThermochemical };

        /// <summary>
        /// joule per kilogram
        /// </summary>
        public static Quantity JoulePerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.JoulePerKilogram };

        /// <summary>
        /// degree Fahrenheit per kelvin
        /// </summary>
        public static Quantity DegreeFahrenheitPerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeFahrenheitPerKelvin };

        /// <summary>
        /// degree Fahrenheit per bar
        /// </summary>
        public static Quantity DegreeFahrenheitPerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeFahrenheitPerBar };

        /// <summary>
        /// degree Fahrenheit hour square foot per British thermal unit (international table)
        /// </summary>
        public static Quantity DegreeFahrenheitHourSquareFootPerBritishThermalUnitInternationalTable(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeFahrenheitHourSquareFootPerBritishThermalUnitInternationalTable };

        /// <summary>
        /// degree Fahrenheit per hour
        /// </summary>
        public static Quantity DegreeFahrenheitPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeFahrenheitPerHour };

        /// <summary>
        /// degree Fahrenheit per minute
        /// </summary>
        public static Quantity DegreeFahrenheitPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeFahrenheitPerMinute };

        /// <summary>
        /// degree Fahrenheit per second
        /// </summary>
        public static Quantity DegreeFahrenheitPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeFahrenheitPerSecond };

        /// <summary>
        /// reciprocal degree Fahrenheit
        /// </summary>
        public static Quantity ReciprocalDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalDegreeFahrenheit };

        /// <summary>
        /// degree Oechsle
        /// </summary>
        public static Quantity DegreeOechsle(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeOechsle };

        /// <summary>
        /// degree Rankine per hour
        /// </summary>
        public static Quantity DegreeRankinePerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeRankinePerHour };

        /// <summary>
        /// degree Rankine per minute
        /// </summary>
        public static Quantity DegreeRankinePerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeRankinePerMinute };

        /// <summary>
        /// degree Rankine per second
        /// </summary>
        public static Quantity DegreeRankinePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeRankinePerSecond };

        /// <summary>
        /// degree Twaddell
        /// </summary>
        public static Quantity DegreeTwaddell(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeTwaddell };

        /// <summary>
        /// micropoise
        /// </summary>
        public static Quantity Micropoise(decimal value) => new() { Value = value, UnitCode = QuantityCode.Micropoise };

        /// <summary>
        /// microgram per kilogram
        /// </summary>
        public static Quantity MicrogramPerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrogramPerKilogram };

        /// <summary>
        /// microgram per cubic metre kelvin
        /// </summary>
        public static Quantity MicrogramPerCubicMetreKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrogramPerCubicMetreKelvin };

        /// <summary>
        /// microgram per cubic metre bar
        /// </summary>
        public static Quantity MicrogramPerCubicMetreBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrogramPerCubicMetreBar };

        /// <summary>
        /// microlitre per litre
        /// </summary>
        public static Quantity MicrolitrePerLitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrolitrePerLitre };

        /// <summary>
        /// baud
        /// </summary>
        public static Quantity Baud(decimal value) => new() { Value = value, UnitCode = QuantityCode.Baud };

        /// <summary>
        /// British thermal unit (mean)
        /// </summary>
        public static Quantity BritishThermalUnitMean(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitMean };

        /// <summary>
        /// British thermal unit (international table) foot per hour square foot degree Fahrenheit
        /// </summary>
        public static Quantity BritishThermalUnitInternationalTableFootPerHourSquareFootDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitInternationalTableFootPerHourSquareFootDegreeFahrenheit };

        /// <summary>
        /// British thermal unit (international table) inch per hour square foot degree Fahrenheit
        /// </summary>
        public static Quantity BritishThermalUnitInternationalTableInchPerHourSquareFootDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitInternationalTableInchPerHourSquareFootDegreeFahrenheit };

        /// <summary>
        /// British thermal unit (international table) inch per second square foot degree Fahrenheit
        /// </summary>
        public static Quantity BritishThermalUnitInternationalTableInchPerSecondSquareFootDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitInternationalTableInchPerSecondSquareFootDegreeFahrenheit };

        /// <summary>
        /// British thermal unit (international table) per pound degree Fahrenheit
        /// </summary>
        public static Quantity BritishThermalUnitInternationalTablePerPoundDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitInternationalTablePerPoundDegreeFahrenheit };

        /// <summary>
        /// British thermal unit (international table) per minute
        /// </summary>
        public static Quantity BritishThermalUnitInternationalTablePerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitInternationalTablePerMinute };

        /// <summary>
        /// British thermal unit (international table) per second
        /// </summary>
        public static Quantity BritishThermalUnitInternationalTablePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitInternationalTablePerSecond };

        /// <summary>
        /// British thermal unit (thermochemical) foot per hour square foot degree Fahrenheit
        /// </summary>
        public static Quantity BritishThermalUnitThermochemicalFootPerHourSquareFootDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitThermochemicalFootPerHourSquareFootDegreeFahrenheit };

        /// <summary>
        /// British thermal unit (thermochemical) per hour
        /// </summary>
        public static Quantity BritishThermalUnitThermochemicalPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitThermochemicalPerHour };

        /// <summary>
        /// British thermal unit (thermochemical) inch per hour square foot degree Fahrenheit
        /// </summary>
        public static Quantity BritishThermalUnitThermochemicalInchPerHourSquareFootDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitThermochemicalInchPerHourSquareFootDegreeFahrenheit };

        /// <summary>
        /// British thermal unit (thermochemical) inch per second square foot degree Fahrenheit
        /// </summary>
        public static Quantity BritishThermalUnitThermochemicalInchPerSecondSquareFootDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitThermochemicalInchPerSecondSquareFootDegreeFahrenheit };

        /// <summary>
        /// British thermal unit (thermochemical) per pound degree Fahrenheit
        /// </summary>
        public static Quantity BritishThermalUnitThermochemicalPerPoundDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitThermochemicalPerPoundDegreeFahrenheit };

        /// <summary>
        /// British thermal unit (thermochemical) per minute
        /// </summary>
        public static Quantity BritishThermalUnitThermochemicalPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitThermochemicalPerMinute };

        /// <summary>
        /// British thermal unit (thermochemical) per second
        /// </summary>
        public static Quantity BritishThermalUnitThermochemicalPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitThermochemicalPerSecond };

        /// <summary>
        /// coulomb square metre per kilogram
        /// </summary>
        public static Quantity CoulombSquareMetrePerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.CoulombSquareMetrePerKilogram };

        /// <summary>
        /// megabaud
        /// </summary>
        public static Quantity Megabaud(decimal value) => new() { Value = value, UnitCode = QuantityCode.Megabaud };

        /// <summary>
        /// watt second
        /// </summary>
        public static Quantity WattSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.WattSecond };

        /// <summary>
        /// bar per bar
        /// </summary>
        public static Quantity BarPerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.BarPerBar };

        /// <summary>
        /// barrel (UK petroleum)
        /// </summary>
        public static Quantity BarrelUKPetroleum(decimal value) => new() { Value = value, UnitCode = QuantityCode.BarrelUKPetroleum };

        /// <summary>
        /// barrel (UK petroleum) per minute
        /// </summary>
        public static Quantity BarrelUKPetroleumPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.BarrelUKPetroleumPerMinute };

        /// <summary>
        /// barrel (UK petroleum) per day
        /// </summary>
        public static Quantity BarrelUKPetroleumPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.BarrelUKPetroleumPerDay };

        /// <summary>
        /// barrel (UK petroleum) per hour
        /// </summary>
        public static Quantity BarrelUKPetroleumPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.BarrelUKPetroleumPerHour };

        /// <summary>
        /// barrel (UK petroleum) per second
        /// </summary>
        public static Quantity BarrelUKPetroleumPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.BarrelUKPetroleumPerSecond };

        /// <summary>
        /// barrel (US petroleum) per hour
        /// </summary>
        public static Quantity BarrelUSPetroleumPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.BarrelUSPetroleumPerHour };

        /// <summary>
        /// barrel (US petroleum) per second
        /// </summary>
        public static Quantity BarrelUSPetroleumPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.BarrelUSPetroleumPerSecond };

        /// <summary>
        /// bushel (UK) per day
        /// </summary>
        public static Quantity BushelUKPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.BushelUKPerDay };

        /// <summary>
        /// bushel (UK) per hour
        /// </summary>
        public static Quantity BushelUKPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.BushelUKPerHour };

        /// <summary>
        /// bushel (UK) per minute
        /// </summary>
        public static Quantity BushelUKPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.BushelUKPerMinute };

        /// <summary>
        /// bushel (UK) per second
        /// </summary>
        public static Quantity BushelUKPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.BushelUKPerSecond };

        /// <summary>
        /// bushel (US dry) per day
        /// </summary>
        public static Quantity BushelUSDryPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.BushelUSDryPerDay };

        /// <summary>
        /// bushel (US dry) per hour
        /// </summary>
        public static Quantity BushelUSDryPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.BushelUSDryPerHour };

        /// <summary>
        /// bushel (US dry) per minute
        /// </summary>
        public static Quantity BushelUSDryPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.BushelUSDryPerMinute };

        /// <summary>
        /// bushel (US dry) per second
        /// </summary>
        public static Quantity BushelUSDryPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.BushelUSDryPerSecond };

        /// <summary>
        /// centinewton metre
        /// </summary>
        public static Quantity CentinewtonMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CentinewtonMetre };

        /// <summary>
        /// centipoise per kelvin
        /// </summary>
        public static Quantity CentipoisePerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.CentipoisePerKelvin };

        /// <summary>
        /// centipoise per bar
        /// </summary>
        public static Quantity CentipoisePerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.CentipoisePerBar };

        /// <summary>
        /// calorie (mean)
        /// </summary>
        public static Quantity CalorieMean(decimal value) => new() { Value = value, UnitCode = QuantityCode.CalorieMean };

        /// <summary>
        /// calorie (international table) per gram degree Celsius
        /// </summary>
        public static Quantity CalorieInternationalTablePerGramDegreeCelsius(decimal value) => new() { Value = value, UnitCode = QuantityCode.CalorieInternationalTablePerGramDegreeCelsius };

        /// <summary>
        /// calorie (thermochemical) per centimetre second degree Celsius
        /// </summary>
        public static Quantity CalorieThermochemicalPerCentimetreSecondDegreeCelsius(decimal value) => new() { Value = value, UnitCode = QuantityCode.CalorieThermochemicalPerCentimetreSecondDegreeCelsius };

        /// <summary>
        /// calorie (thermochemical) per gram degree Celsius
        /// </summary>
        public static Quantity CalorieThermochemicalPerGramDegreeCelsius(decimal value) => new() { Value = value, UnitCode = QuantityCode.CalorieThermochemicalPerGramDegreeCelsius };

        /// <summary>
        /// calorie (thermochemical) per minute
        /// </summary>
        public static Quantity CalorieThermochemicalPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.CalorieThermochemicalPerMinute };

        /// <summary>
        /// calorie (thermochemical) per second
        /// </summary>
        public static Quantity CalorieThermochemicalPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.CalorieThermochemicalPerSecond };

        /// <summary>
        /// clo
        /// </summary>
        public static Quantity Clo(decimal value) => new() { Value = value, UnitCode = QuantityCode.Clo };

        /// <summary>
        /// centimetre per second kelvin
        /// </summary>
        public static Quantity CentimetrePerSecondKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.CentimetrePerSecondKelvin };

        /// <summary>
        /// centimetre per second bar
        /// </summary>
        public static Quantity CentimetrePerSecondBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.CentimetrePerSecondBar };

        /// <summary>
        /// cubic centimetre per cubic metre
        /// </summary>
        public static Quantity CubicCentimetrePerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicCentimetrePerCubicMetre };

        /// <summary>
        /// cubic decimetre per day
        /// </summary>
        public static Quantity CubicDecimetrePerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicDecimetrePerDay };

        /// <summary>
        /// cubic decimetre per cubic metre
        /// </summary>
        public static Quantity CubicDecimetrePerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicDecimetrePerCubicMetre };

        /// <summary>
        /// cubic decimetre per minute
        /// </summary>
        public static Quantity CubicDecimetrePerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicDecimetrePerMinute };

        /// <summary>
        /// cubic decimetre per second
        /// </summary>
        public static Quantity CubicDecimetrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicDecimetrePerSecond };

        /// <summary>
        /// ounce (UK fluid) per day
        /// </summary>
        public static Quantity OunceUKFluidPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.OunceUKFluidPerDay };

        /// <summary>
        /// ounce (UK fluid) per hour
        /// </summary>
        public static Quantity OunceUKFluidPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.OunceUKFluidPerHour };

        /// <summary>
        /// ounce (UK fluid) per minute
        /// </summary>
        public static Quantity OunceUKFluidPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.OunceUKFluidPerMinute };

        /// <summary>
        /// ounce (UK fluid) per second
        /// </summary>
        public static Quantity OunceUKFluidPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.OunceUKFluidPerSecond };

        /// <summary>
        /// ounce (US fluid) per day
        /// </summary>
        public static Quantity OunceUSFluidPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.OunceUSFluidPerDay };

        /// <summary>
        /// joule per kelvin
        /// </summary>
        public static Quantity JoulePerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.JoulePerKelvin };

        /// <summary>
        /// megajoule per kilogram
        /// </summary>
        public static Quantity MegajoulePerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegajoulePerKilogram };

        /// <summary>
        /// megajoule per cubic metre
        /// </summary>
        public static Quantity MegajoulePerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegajoulePerCubicMetre };

        /// <summary>
        /// pipeline joint
        /// </summary>
        public static Quantity PipelineJoint(decimal value) => new() { Value = value, UnitCode = QuantityCode.PipelineJoint };

        /// <summary>
        /// joule
        /// </summary>
        public static Quantity Joule(decimal value) => new() { Value = value, UnitCode = QuantityCode.Joule };

        /// <summary>
        /// hundred metre
        /// </summary>
        public static Quantity HundredMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.HundredMetre };

        /// <summary>
        /// number of jewels
        /// </summary>
        public static Quantity NumberOfJewels(decimal value) => new() { Value = value, UnitCode = QuantityCode.NumberOfJewels };

        /// <summary>
        /// kilowatt demand
        /// </summary>
        public static Quantity KilowattDemand(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilowattDemand };

        /// <summary>
        /// ounce (US fluid) per hour
        /// </summary>
        public static Quantity OunceUSFluidPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.OunceUSFluidPerHour };

        /// <summary>
        /// ounce (US fluid) per minute
        /// </summary>
        public static Quantity OunceUSFluidPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.OunceUSFluidPerMinute };

        /// <summary>
        /// ounce (US fluid) per second
        /// </summary>
        public static Quantity OunceUSFluidPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.OunceUSFluidPerSecond };

        /// <summary>
        /// foot per degree Fahrenheit
        /// </summary>
        public static Quantity FootPerDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.FootPerDegreeFahrenheit };

        /// <summary>
        /// foot per hour
        /// </summary>
        public static Quantity FootPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.FootPerHour };

        /// <summary>
        /// foot pound-force per hour
        /// </summary>
        public static Quantity FootPoundForcePerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.FootPoundForcePerHour };

        /// <summary>
        /// foot pound-force per minute
        /// </summary>
        public static Quantity FootPoundForcePerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.FootPoundForcePerMinute };

        /// <summary>
        /// foot per psi
        /// </summary>
        public static Quantity FootPerPsi(decimal value) => new() { Value = value, UnitCode = QuantityCode.FootPerPsi };

        /// <summary>
        /// foot per second degree Fahrenheit
        /// </summary>
        public static Quantity FootPerSecondDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.FootPerSecondDegreeFahrenheit };

        /// <summary>
        /// foot per second psi
        /// </summary>
        public static Quantity FootPerSecondPsi(decimal value) => new() { Value = value, UnitCode = QuantityCode.FootPerSecondPsi };

        /// <summary>
        /// kilovolt ampere reactive demand
        /// </summary>
        public static Quantity KilovoltAmpereReactiveDemand(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilovoltAmpereReactiveDemand };

        /// <summary>
        /// reciprocal cubic foot
        /// </summary>
        public static Quantity ReciprocalCubicFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalCubicFoot };

        /// <summary>
        /// cubic foot per degree Fahrenheit
        /// </summary>
        public static Quantity CubicFootPerDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicFootPerDegreeFahrenheit };

        /// <summary>
        /// cubic foot per day
        /// </summary>
        public static Quantity CubicFootPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicFootPerDay };

        /// <summary>
        /// cubic foot per psi
        /// </summary>
        public static Quantity CubicFootPerPsi(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicFootPerPsi };

        /// <summary>
        /// gallon (UK) per day
        /// </summary>
        public static Quantity GallonUKPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.GallonUKPerDay };

        /// <summary>
        /// gallon (UK) per hour
        /// </summary>
        public static Quantity GallonUKPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.GallonUKPerHour };

        /// <summary>
        /// gallon (UK) per second
        /// </summary>
        public static Quantity GallonUKPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.GallonUKPerSecond };

        /// <summary>
        /// kilovolt ampere reactive hour
        /// </summary>
        public static Quantity KilovoltAmpereReactiveHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilovoltAmpereReactiveHour };

        /// <summary>
        /// gallon (US liquid) per second
        /// </summary>
        public static Quantity GallonUSLiquidPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.GallonUSLiquidPerSecond };

        /// <summary>
        /// gram-force per square centimetre
        /// </summary>
        public static Quantity GramForcePerSquareCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramForcePerSquareCentimetre };

        /// <summary>
        /// gill (UK) per day
        /// </summary>
        public static Quantity GillUKPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.GillUKPerDay };

        /// <summary>
        /// gill (UK) per hour
        /// </summary>
        public static Quantity GillUKPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.GillUKPerHour };

        /// <summary>
        /// gill (UK) per minute
        /// </summary>
        public static Quantity GillUKPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.GillUKPerMinute };

        /// <summary>
        /// gill (UK) per second
        /// </summary>
        public static Quantity GillUKPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.GillUKPerSecond };

        /// <summary>
        /// gill (US) per day
        /// </summary>
        public static Quantity GillUSPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.GillUSPerDay };

        /// <summary>
        /// gill (US) per hour
        /// </summary>
        public static Quantity GillUSPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.GillUSPerHour };

        /// <summary>
        /// gill (US) per minute
        /// </summary>
        public static Quantity GillUSPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.GillUSPerMinute };

        /// <summary>
        /// gill (US) per second
        /// </summary>
        public static Quantity GillUSPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.GillUSPerSecond };

        /// <summary>
        /// standard acceleration of free fall
        /// </summary>
        public static Quantity StandardAccelerationOfFreeFall(decimal value) => new() { Value = value, UnitCode = QuantityCode.StandardAccelerationOfFreeFall };

        /// <summary>
        /// grain per gallon (US)
        /// </summary>
        public static Quantity GrainPerGallonUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.GrainPerGallonUS };

        /// <summary>
        /// horsepower (boiler)
        /// </summary>
        public static Quantity HorsepowerBoiler(decimal value) => new() { Value = value, UnitCode = QuantityCode.HorsepowerBoiler };

        /// <summary>
        /// horsepower (electric)
        /// </summary>
        public static Quantity HorsepowerElectric(decimal value) => new() { Value = value, UnitCode = QuantityCode.HorsepowerElectric };

        /// <summary>
        /// inch per degree Fahrenheit
        /// </summary>
        public static Quantity InchPerDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.InchPerDegreeFahrenheit };

        /// <summary>
        /// inch per psi
        /// </summary>
        public static Quantity InchPerPsi(decimal value) => new() { Value = value, UnitCode = QuantityCode.InchPerPsi };

        /// <summary>
        /// inch per second degree Fahrenheit
        /// </summary>
        public static Quantity InchPerSecondDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.InchPerSecondDegreeFahrenheit };

        /// <summary>
        /// inch per second psi
        /// </summary>
        public static Quantity InchPerSecondPsi(decimal value) => new() { Value = value, UnitCode = QuantityCode.InchPerSecondPsi };

        /// <summary>
        /// reciprocal cubic inch
        /// </summary>
        public static Quantity ReciprocalCubicInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalCubicInch };

        /// <summary>
        /// kilobaud
        /// </summary>
        public static Quantity Kilobaud(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilobaud };

        /// <summary>
        /// kilocalorie (mean)
        /// </summary>
        public static Quantity KilocalorieMean(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilocalorieMean };

        /// <summary>
        /// kilocalorie (international table) per hour metre degree Celsius
        /// </summary>
        public static Quantity KilocalorieInternationalTablePerHourMetreDegreeCelsius(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilocalorieInternationalTablePerHourMetreDegreeCelsius };

        /// <summary>
        /// kilocalorie (thermochemical)
        /// </summary>
        public static Quantity KilocalorieThermochemical(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilocalorieThermochemical };

        /// <summary>
        /// kilocalorie (thermochemical) per minute
        /// </summary>
        public static Quantity KilocalorieThermochemicalPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilocalorieThermochemicalPerMinute };

        /// <summary>
        /// kilocalorie (thermochemical) per second
        /// </summary>
        public static Quantity KilocalorieThermochemicalPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilocalorieThermochemicalPerSecond };

        /// <summary>
        /// kilomole per hour
        /// </summary>
        public static Quantity KilomolePerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilomolePerHour };

        /// <summary>
        /// kilomole per cubic metre kelvin
        /// </summary>
        public static Quantity KilomolePerCubicMetreKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilomolePerCubicMetreKelvin };

        /// <summary>
        /// kilolitre
        /// </summary>
        public static Quantity Kilolitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilolitre };

        /// <summary>
        /// kilomole per cubic metre bar
        /// </summary>
        public static Quantity KilomolePerCubicMetreBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilomolePerCubicMetreBar };

        /// <summary>
        /// kilomole per minute
        /// </summary>
        public static Quantity KilomolePerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilomolePerMinute };

        /// <summary>
        /// litre per litre
        /// </summary>
        public static Quantity LitrePerLitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.LitrePerLitre };

        /// <summary>
        /// reciprocal litre
        /// </summary>
        public static Quantity ReciprocalLitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalLitre };

        /// <summary>
        /// pound (avoirdupois) per degree Fahrenheit
        /// </summary>
        public static Quantity PoundAvoirdupoisPerDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundAvoirdupoisPerDegreeFahrenheit };

        /// <summary>
        /// pound (avoirdupois) square foot
        /// </summary>
        public static Quantity PoundAvoirdupoisSquareFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundAvoirdupoisSquareFoot };

        /// <summary>
        /// pound (avoirdupois) per day
        /// </summary>
        public static Quantity PoundAvoirdupoisPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundAvoirdupoisPerDay };

        /// <summary>
        /// pound per foot hour
        /// </summary>
        public static Quantity PoundPerFootHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundPerFootHour };

        /// <summary>
        /// pound per foot second
        /// </summary>
        public static Quantity PoundPerFootSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundPerFootSecond };

        /// <summary>
        /// pound (avoirdupois) per cubic foot degree Fahrenheit
        /// </summary>
        public static Quantity PoundAvoirdupoisPerCubicFootDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundAvoirdupoisPerCubicFootDegreeFahrenheit };

        /// <summary>
        /// pound (avoirdupois) per cubic foot psi
        /// </summary>
        public static Quantity PoundAvoirdupoisPerCubicFootPsi(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundAvoirdupoisPerCubicFootPsi };

        /// <summary>
        /// pound (avoirdupois) per gallon (UK)
        /// </summary>
        public static Quantity PoundAvoirdupoisPerGallonUK(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundAvoirdupoisPerGallonUK };

        /// <summary>
        /// pound (avoirdupois) per hour degree Fahrenheit
        /// </summary>
        public static Quantity PoundAvoirdupoisPerHourDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundAvoirdupoisPerHourDegreeFahrenheit };

        /// <summary>
        /// pound (avoirdupois) per hour psi
        /// </summary>
        public static Quantity PoundAvoirdupoisPerHourPsi(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundAvoirdupoisPerHourPsi };

        /// <summary>
        /// pound (avoirdupois) per cubic inch degree Fahrenheit
        /// </summary>
        public static Quantity PoundAvoirdupoisPerCubicInchDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundAvoirdupoisPerCubicInchDegreeFahrenheit };

        /// <summary>
        /// pound (avoirdupois) per cubic inch psi
        /// </summary>
        public static Quantity PoundAvoirdupoisPerCubicInchPsi(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundAvoirdupoisPerCubicInchPsi };

        /// <summary>
        /// pound (avoirdupois) per psi
        /// </summary>
        public static Quantity PoundAvoirdupoisPerPsi(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundAvoirdupoisPerPsi };

        /// <summary>
        /// pound (avoirdupois) per minute
        /// </summary>
        public static Quantity PoundAvoirdupoisPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundAvoirdupoisPerMinute };

        /// <summary>
        /// pound (avoirdupois) per minute degree Fahrenheit
        /// </summary>
        public static Quantity PoundAvoirdupoisPerMinuteDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundAvoirdupoisPerMinuteDegreeFahrenheit };

        /// <summary>
        /// pound (avoirdupois) per minute psi
        /// </summary>
        public static Quantity PoundAvoirdupoisPerMinutePsi(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundAvoirdupoisPerMinutePsi };

        /// <summary>
        /// pound (avoirdupois) per second
        /// </summary>
        public static Quantity PoundAvoirdupoisPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundAvoirdupoisPerSecond };

        /// <summary>
        /// pound (avoirdupois) per second degree Fahrenheit
        /// </summary>
        public static Quantity PoundAvoirdupoisPerSecondDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundAvoirdupoisPerSecondDegreeFahrenheit };

        /// <summary>
        /// pound (avoirdupois) per second psi
        /// </summary>
        public static Quantity PoundAvoirdupoisPerSecondPsi(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundAvoirdupoisPerSecondPsi };

        /// <summary>
        /// pound per cubic yard
        /// </summary>
        public static Quantity PoundPerCubicYard(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundPerCubicYard };

        /// <summary>
        /// pound-force per square foot
        /// </summary>
        public static Quantity PoundForcePerSquareFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundForcePerSquareFoot };

        /// <summary>
        /// pound-force per square inch degree Fahrenheit
        /// </summary>
        public static Quantity PoundForcePerSquareInchDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundForcePerSquareInchDegreeFahrenheit };

        /// <summary>
        /// psi cubic inch per second
        /// </summary>
        public static Quantity PsiCubicInchPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.PsiCubicInchPerSecond };

        /// <summary>
        /// psi litre per second
        /// </summary>
        public static Quantity PsiLitrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.PsiLitrePerSecond };

        /// <summary>
        /// psi cubic metre per second
        /// </summary>
        public static Quantity PsiCubicMetrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.PsiCubicMetrePerSecond };

        /// <summary>
        /// psi cubic yard per second
        /// </summary>
        public static Quantity PsiCubicYardPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.PsiCubicYardPerSecond };

        /// <summary>
        /// pound-force second per square foot
        /// </summary>
        public static Quantity PoundForceSecondPerSquareFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundForceSecondPerSquareFoot };

        /// <summary>
        /// pound-force second per square inch
        /// </summary>
        public static Quantity PoundForceSecondPerSquareInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundForceSecondPerSquareInch };

        /// <summary>
        /// reciprocal psi
        /// </summary>
        public static Quantity ReciprocalPsi(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalPsi };

        /// <summary>
        /// quart (UK liquid) per day
        /// </summary>
        public static Quantity QuartUKLiquidPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.QuartUKLiquidPerDay };

        /// <summary>
        /// quart (UK liquid) per hour
        /// </summary>
        public static Quantity QuartUKLiquidPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.QuartUKLiquidPerHour };

        /// <summary>
        /// quart (UK liquid) per minute
        /// </summary>
        public static Quantity QuartUKLiquidPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.QuartUKLiquidPerMinute };

        /// <summary>
        /// quart (UK liquid) per second
        /// </summary>
        public static Quantity QuartUKLiquidPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.QuartUKLiquidPerSecond };

        /// <summary>
        /// quart (US liquid) per day
        /// </summary>
        public static Quantity QuartUSLiquidPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.QuartUSLiquidPerDay };

        /// <summary>
        /// quart (US liquid) per hour
        /// </summary>
        public static Quantity QuartUSLiquidPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.QuartUSLiquidPerHour };

        /// <summary>
        /// cake
        /// </summary>
        public static Quantity Cake(decimal value) => new() { Value = value, UnitCode = QuantityCode.Cake };

        /// <summary>
        /// katal
        /// </summary>
        public static Quantity Katal(decimal value) => new() { Value = value, UnitCode = QuantityCode.Katal };

        /// <summary>
        /// kilocharacter
        /// </summary>
        public static Quantity Kilocharacter(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilocharacter };

        /// <summary>
        /// kilobar
        /// </summary>
        public static Quantity Kilobar(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilobar };

        /// <summary>
        /// kilogram of choline chloride
        /// </summary>
        public static Quantity KilogramOfCholineChloride(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramOfCholineChloride };

        /// <summary>
        /// kilogram drained net weight
        /// </summary>
        public static Quantity KilogramDrainedNetWeight(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramDrainedNetWeight };

        /// <summary>
        /// kelvin
        /// </summary>
        public static Quantity Kelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kelvin };

        /// <summary>
        /// kilogram
        /// </summary>
        public static Quantity Kilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilogram };

        /// <summary>
        /// kilogram per second
        /// </summary>
        public static Quantity KilogramPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerSecond };

        /// <summary>
        /// kilogram of hydrogen peroxide
        /// </summary>
        public static Quantity KilogramOfHydrogenPeroxide(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramOfHydrogenPeroxide };

        /// <summary>
        /// kilohertz
        /// </summary>
        public static Quantity Kilohertz(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilohertz };

        /// <summary>
        /// kilogram per millimetre width
        /// </summary>
        public static Quantity KilogramPerMillimetreWidth(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerMillimetreWidth };

        /// <summary>
        /// kilogram, including container
        /// </summary>
        public static Quantity KilogramIncludingContainer(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramIncludingContainer };

        /// <summary>
        /// kilogram, including inner packaging
        /// </summary>
        public static Quantity KilogramIncludingInnerPackaging(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramIncludingInnerPackaging };

        /// <summary>
        /// kilosegment
        /// </summary>
        public static Quantity Kilosegment(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilosegment };

        /// <summary>
        /// kilojoule
        /// </summary>
        public static Quantity Kilojoule(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilojoule };

        /// <summary>
        /// kilogram per metre
        /// </summary>
        public static Quantity KilogramPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerMetre };

        /// <summary>
        /// lactic dry material percentage
        /// </summary>
        public static Quantity LacticDryMaterialPercentage(decimal value) => new() { Value = value, UnitCode = QuantityCode.LacticDryMaterialPercentage };

        /// <summary>
        /// kilolux
        /// </summary>
        public static Quantity Kilolux(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilolux };

        /// <summary>
        /// kilogram of methylamine
        /// </summary>
        public static Quantity KilogramOfMethylamine(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramOfMethylamine };

        /// <summary>
        /// kilometre per hour
        /// </summary>
        public static Quantity KilometrePerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilometrePerHour };

        /// <summary>
        /// square kilometre
        /// </summary>
        public static Quantity SquareKilometre(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareKilometre };

        /// <summary>
        /// kilogram per cubic metre
        /// </summary>
        public static Quantity KilogramPerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerCubicMetre };

        /// <summary>
        /// kilometre
        /// </summary>
        public static Quantity Kilometre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilometre };

        /// <summary>
        /// kilogram of nitrogen
        /// </summary>
        public static Quantity KilogramOfNitrogen(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramOfNitrogen };

        /// <summary>
        /// kilonewton per square metre
        /// </summary>
        public static Quantity KilonewtonPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilonewtonPerSquareMetre };

        /// <summary>
        /// kilogram named substance
        /// </summary>
        public static Quantity KilogramNamedSubstance(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramNamedSubstance };

        /// <summary>
        /// knot
        /// </summary>
        public static Quantity Knot(decimal value) => new() { Value = value, UnitCode = QuantityCode.Knot };

        /// <summary>
        /// milliequivalence caustic potash per gram of product
        /// </summary>
        public static Quantity MilliequivalenceCausticPotashPerGramOfProduct(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilliequivalenceCausticPotashPerGramOfProduct };

        /// <summary>
        /// kilopascal
        /// </summary>
        public static Quantity Kilopascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilopascal };

        /// <summary>
        /// kilogram of potassium hydroxide (caustic potash)
        /// </summary>
        public static Quantity KilogramOfPotassiumHydroxideCausticPotash(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramOfPotassiumHydroxideCausticPotash };

        /// <summary>
        /// kilogram of potassium oxide
        /// </summary>
        public static Quantity KilogramOfPotassiumOxide(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramOfPotassiumOxide };

        /// <summary>
        /// kilogram of phosphorus pentoxide (phosphoric anhydride)
        /// </summary>
        public static Quantity KilogramOfPhosphorusPentoxidePhosphoricAnhydride(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramOfPhosphorusPentoxidePhosphoricAnhydride };

        /// <summary>
        /// kiloroentgen
        /// </summary>
        public static Quantity Kiloroentgen(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kiloroentgen };

        /// <summary>
        /// kilogram of substance 90 % dry
        /// </summary>
        public static Quantity KilogramOfSubstance90Dry(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramOfSubstance90Dry };

        /// <summary>
        /// kilogram of sodium hydroxide (caustic soda)
        /// </summary>
        public static Quantity KilogramOfSodiumHydroxideCausticSoda(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramOfSodiumHydroxideCausticSoda };

        /// <summary>
        /// kit
        /// </summary>
        public static Quantity Kit(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kit };

        /// <summary>
        /// kilotonne
        /// </summary>
        public static Quantity Kilotonne(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilotonne };

        /// <summary>
        /// kilogram of uranium
        /// </summary>
        public static Quantity KilogramOfUranium(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramOfUranium };

        /// <summary>
        /// kilovolt - ampere
        /// </summary>
        public static Quantity KilovoltAmpere(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilovoltAmpere };

        /// <summary>
        /// kilovar
        /// </summary>
        public static Quantity Kilovar(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilovar };

        /// <summary>
        /// kilovolt
        /// </summary>
        public static Quantity Kilovolt(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilovolt };

        /// <summary>
        /// kilogram per millimetre
        /// </summary>
        public static Quantity KilogramPerMillimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerMillimetre };

        /// <summary>
        /// kilowatt hour
        /// </summary>
        public static Quantity KilowattHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilowattHour };

        /// <summary>
        /// Kilowatt hour per normalized cubic metre
        /// </summary>
        public static Quantity KilowattHourPerNormalizedCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilowattHourPerNormalizedCubicMetre };

        /// <summary>
        /// kilogram of tungsten trioxide
        /// </summary>
        public static Quantity KilogramOfTungstenTrioxide(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramOfTungstenTrioxide };

        /// <summary>
        /// Kilowatt hour per standard cubic metre
        /// </summary>
        public static Quantity KilowattHourPerStandardCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilowattHourPerStandardCubicMetre };

        /// <summary>
        /// kilowatt
        /// </summary>
        public static Quantity Kilowatt(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilowatt };

        /// <summary>
        /// kilowatt year
        /// </summary>
        public static Quantity KilowattYear(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilowattYear };

        /// <summary>
        /// millilitre per kilogram
        /// </summary>
        public static Quantity MillilitrePerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillilitrePerKilogram };

        /// <summary>
        /// quart (US liquid) per minute
        /// </summary>
        public static Quantity QuartUSLiquidPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.QuartUSLiquidPerMinute };

        /// <summary>
        /// quart (US liquid) per second
        /// </summary>
        public static Quantity QuartUSLiquidPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.QuartUSLiquidPerSecond };

        /// <summary>
        /// metre per second kelvin
        /// </summary>
        public static Quantity MetrePerSecondKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MetrePerSecondKelvin };

        /// <summary>
        /// metre per second bar
        /// </summary>
        public static Quantity MetrePerSecondBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.MetrePerSecondBar };

        /// <summary>
        /// square metre hour degree Celsius per kilocalorie (international table)
        /// </summary>
        public static Quantity SquareMetreHourDegreeCelsiusPerKilocalorieInternationalTable(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMetreHourDegreeCelsiusPerKilocalorieInternationalTable };

        /// <summary>
        /// millipascal second per kelvin
        /// </summary>
        public static Quantity MillipascalSecondPerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillipascalSecondPerKelvin };

        /// <summary>
        /// millipascal second per bar
        /// </summary>
        public static Quantity MillipascalSecondPerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillipascalSecondPerBar };

        /// <summary>
        /// milligram per cubic metre kelvin
        /// </summary>
        public static Quantity MilligramPerCubicMetreKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerCubicMetreKelvin };

        /// <summary>
        /// milligram per cubic metre bar
        /// </summary>
        public static Quantity MilligramPerCubicMetreBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerCubicMetreBar };

        /// <summary>
        /// millilitre per litre
        /// </summary>
        public static Quantity MillilitrePerLitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillilitrePerLitre };

        /// <summary>
        /// litre per minute
        /// </summary>
        public static Quantity LitrePerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.LitrePerMinute };

        /// <summary>
        /// reciprocal cubic millimetre
        /// </summary>
        public static Quantity ReciprocalCubicMillimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalCubicMillimetre };

        /// <summary>
        /// cubic millimetre per cubic metre
        /// </summary>
        public static Quantity CubicMillimetrePerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMillimetrePerCubicMetre };

        /// <summary>
        /// mole per hour
        /// </summary>
        public static Quantity MolePerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.MolePerHour };

        /// <summary>
        /// mole per kilogram kelvin
        /// </summary>
        public static Quantity MolePerKilogramKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MolePerKilogramKelvin };

        /// <summary>
        /// mole per kilogram bar
        /// </summary>
        public static Quantity MolePerKilogramBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.MolePerKilogramBar };

        /// <summary>
        /// mole per litre kelvin
        /// </summary>
        public static Quantity MolePerLitreKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MolePerLitreKelvin };

        /// <summary>
        /// mole per litre bar
        /// </summary>
        public static Quantity MolePerLitreBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.MolePerLitreBar };

        /// <summary>
        /// mole per cubic metre kelvin
        /// </summary>
        public static Quantity MolePerCubicMetreKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.MolePerCubicMetreKelvin };

        /// <summary>
        /// mole per cubic metre bar
        /// </summary>
        public static Quantity MolePerCubicMetreBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.MolePerCubicMetreBar };

        /// <summary>
        /// mole per minute
        /// </summary>
        public static Quantity MolePerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.MolePerMinute };

        /// <summary>
        /// milliroentgen aequivalent men
        /// </summary>
        public static Quantity MilliroentgenAequivalentMen(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilliroentgenAequivalentMen };

        /// <summary>
        /// nanogram per kilogram
        /// </summary>
        public static Quantity NanogramPerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.NanogramPerKilogram };

        /// <summary>
        /// ounce (avoirdupois) per day
        /// </summary>
        public static Quantity OunceAvoirdupoisPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.OunceAvoirdupoisPerDay };

        /// <summary>
        /// ounce (avoirdupois) per hour
        /// </summary>
        public static Quantity OunceAvoirdupoisPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.OunceAvoirdupoisPerHour };

        /// <summary>
        /// ounce (avoirdupois) per minute
        /// </summary>
        public static Quantity OunceAvoirdupoisPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.OunceAvoirdupoisPerMinute };

        /// <summary>
        /// ounce (avoirdupois) per second
        /// </summary>
        public static Quantity OunceAvoirdupoisPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.OunceAvoirdupoisPerSecond };

        /// <summary>
        /// ounce (avoirdupois) per gallon (UK)
        /// </summary>
        public static Quantity OunceAvoirdupoisPerGallonUK(decimal value) => new() { Value = value, UnitCode = QuantityCode.OunceAvoirdupoisPerGallonUK };

        /// <summary>
        /// ounce (avoirdupois) per gallon (US)
        /// </summary>
        public static Quantity OunceAvoirdupoisPerGallonUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.OunceAvoirdupoisPerGallonUS };

        /// <summary>
        /// ounce (avoirdupois) per cubic inch
        /// </summary>
        public static Quantity OunceAvoirdupoisPerCubicInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.OunceAvoirdupoisPerCubicInch };

        /// <summary>
        /// ounce (avoirdupois)-force
        /// </summary>
        public static Quantity OunceAvoirdupoisForce(decimal value) => new() { Value = value, UnitCode = QuantityCode.OunceAvoirdupoisForce };

        /// <summary>
        /// ounce (avoirdupois)-force inch
        /// </summary>
        public static Quantity OunceAvoirdupoisForceInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.OunceAvoirdupoisForceInch };

        /// <summary>
        /// picosiemens per metre
        /// </summary>
        public static Quantity PicosiemensPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.PicosiemensPerMetre };

        /// <summary>
        /// peck (UK)
        /// </summary>
        public static Quantity PeckUK(decimal value) => new() { Value = value, UnitCode = QuantityCode.PeckUK };

        /// <summary>
        /// peck (UK) per day
        /// </summary>
        public static Quantity PeckUKPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.PeckUKPerDay };

        /// <summary>
        /// peck (UK) per hour
        /// </summary>
        public static Quantity PeckUKPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.PeckUKPerHour };

        /// <summary>
        /// peck (UK) per minute
        /// </summary>
        public static Quantity PeckUKPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.PeckUKPerMinute };

        /// <summary>
        /// peck (UK) per second
        /// </summary>
        public static Quantity PeckUKPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.PeckUKPerSecond };

        /// <summary>
        /// peck (US dry) per day
        /// </summary>
        public static Quantity PeckUSDryPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.PeckUSDryPerDay };

        /// <summary>
        /// peck (US dry) per hour
        /// </summary>
        public static Quantity PeckUSDryPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.PeckUSDryPerHour };

        /// <summary>
        /// peck (US dry) per minute
        /// </summary>
        public static Quantity PeckUSDryPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.PeckUSDryPerMinute };

        /// <summary>
        /// peck (US dry) per second
        /// </summary>
        public static Quantity PeckUSDryPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.PeckUSDryPerSecond };

        /// <summary>
        /// psi per psi
        /// </summary>
        public static Quantity PsiPerPsi(decimal value) => new() { Value = value, UnitCode = QuantityCode.PsiPerPsi };

        /// <summary>
        /// pint (UK) per day
        /// </summary>
        public static Quantity PintUKPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.PintUKPerDay };

        /// <summary>
        /// pint (UK) per hour
        /// </summary>
        public static Quantity PintUKPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.PintUKPerHour };

        /// <summary>
        /// pint (UK) per minute
        /// </summary>
        public static Quantity PintUKPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.PintUKPerMinute };

        /// <summary>
        /// pint (UK) per second
        /// </summary>
        public static Quantity PintUKPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.PintUKPerSecond };

        /// <summary>
        /// pint (US liquid) per day
        /// </summary>
        public static Quantity PintUSLiquidPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.PintUSLiquidPerDay };

        /// <summary>
        /// pint (US liquid) per hour
        /// </summary>
        public static Quantity PintUSLiquidPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.PintUSLiquidPerHour };

        /// <summary>
        /// pint (US liquid) per minute
        /// </summary>
        public static Quantity PintUSLiquidPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.PintUSLiquidPerMinute };

        /// <summary>
        /// pint (US liquid) per second
        /// </summary>
        public static Quantity PintUSLiquidPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.PintUSLiquidPerSecond };

        /// <summary>
        /// slug per day
        /// </summary>
        public static Quantity SlugPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.SlugPerDay };

        /// <summary>
        /// slug per foot second
        /// </summary>
        public static Quantity SlugPerFootSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.SlugPerFootSecond };

        /// <summary>
        /// slug per cubic foot
        /// </summary>
        public static Quantity SlugPerCubicFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.SlugPerCubicFoot };

        /// <summary>
        /// slug per hour
        /// </summary>
        public static Quantity SlugPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.SlugPerHour };

        /// <summary>
        /// slug per minute
        /// </summary>
        public static Quantity SlugPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.SlugPerMinute };

        /// <summary>
        /// slug per second
        /// </summary>
        public static Quantity SlugPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.SlugPerSecond };

        /// <summary>
        /// tonne per kelvin
        /// </summary>
        public static Quantity TonnePerKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonnePerKelvin };

        /// <summary>
        /// tonne per bar
        /// </summary>
        public static Quantity TonnePerBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonnePerBar };

        /// <summary>
        /// tonne per day
        /// </summary>
        public static Quantity TonnePerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonnePerDay };

        /// <summary>
        /// tonne per day kelvin
        /// </summary>
        public static Quantity TonnePerDayKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonnePerDayKelvin };

        /// <summary>
        /// tonne per day bar
        /// </summary>
        public static Quantity TonnePerDayBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonnePerDayBar };

        /// <summary>
        /// tonne per hour kelvin
        /// </summary>
        public static Quantity TonnePerHourKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonnePerHourKelvin };

        /// <summary>
        /// tonne per hour bar
        /// </summary>
        public static Quantity TonnePerHourBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonnePerHourBar };

        /// <summary>
        /// tonne per cubic metre kelvin
        /// </summary>
        public static Quantity TonnePerCubicMetreKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonnePerCubicMetreKelvin };

        /// <summary>
        /// tonne per cubic metre bar
        /// </summary>
        public static Quantity TonnePerCubicMetreBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonnePerCubicMetreBar };

        /// <summary>
        /// tonne per minute
        /// </summary>
        public static Quantity TonnePerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonnePerMinute };

        /// <summary>
        /// tonne per minute kelvin
        /// </summary>
        public static Quantity TonnePerMinuteKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonnePerMinuteKelvin };

        /// <summary>
        /// tonne per minute bar
        /// </summary>
        public static Quantity TonnePerMinuteBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonnePerMinuteBar };

        /// <summary>
        /// tonne per second
        /// </summary>
        public static Quantity TonnePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonnePerSecond };

        /// <summary>
        /// tonne per second kelvin
        /// </summary>
        public static Quantity TonnePerSecondKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonnePerSecondKelvin };

        /// <summary>
        /// tonne per second bar
        /// </summary>
        public static Quantity TonnePerSecondBar(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonnePerSecondBar };

        /// <summary>
        /// ton (UK shipping)
        /// </summary>
        public static Quantity TonUKShipping(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonUKShipping };

        /// <summary>
        /// ton long per day
        /// </summary>
        public static Quantity TonLongPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonLongPerDay };

        /// <summary>
        /// ton (US shipping)
        /// </summary>
        public static Quantity TonUSShipping(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonUSShipping };

        /// <summary>
        /// ton short per degree Fahrenheit
        /// </summary>
        public static Quantity TonShortPerDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonShortPerDegreeFahrenheit };

        /// <summary>
        /// ton short per day
        /// </summary>
        public static Quantity TonShortPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonShortPerDay };

        /// <summary>
        /// ton short per hour degree Fahrenheit
        /// </summary>
        public static Quantity TonShortPerHourDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonShortPerHourDegreeFahrenheit };

        /// <summary>
        /// ton short per hour psi
        /// </summary>
        public static Quantity TonShortPerHourPsi(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonShortPerHourPsi };

        /// <summary>
        /// ton short per psi
        /// </summary>
        public static Quantity TonShortPerPsi(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonShortPerPsi };

        /// <summary>
        /// ton (UK long) per cubic yard
        /// </summary>
        public static Quantity TonUKLongPerCubicYard(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonUKLongPerCubicYard };

        /// <summary>
        /// ton (US short) per cubic yard
        /// </summary>
        public static Quantity TonUSShortPerCubicYard(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonUSShortPerCubicYard };

        /// <summary>
        /// ton-force (US short)
        /// </summary>
        public static Quantity TonForceUSShort(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonForceUSShort };

        /// <summary>
        /// common year
        /// </summary>
        public static Quantity CommonYear(decimal value) => new() { Value = value, UnitCode = QuantityCode.CommonYear };

        /// <summary>
        /// sidereal year
        /// </summary>
        public static Quantity SiderealYear(decimal value) => new() { Value = value, UnitCode = QuantityCode.SiderealYear };

        /// <summary>
        /// yard per degree Fahrenheit
        /// </summary>
        public static Quantity YardPerDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.YardPerDegreeFahrenheit };

        /// <summary>
        /// yard per psi
        /// </summary>
        public static Quantity YardPerPsi(decimal value) => new() { Value = value, UnitCode = QuantityCode.YardPerPsi };

        /// <summary>
        /// pound per cubic inch
        /// </summary>
        public static Quantity PoundPerCubicInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundPerCubicInch };

        /// <summary>
        /// lactose excess percentage
        /// </summary>
        public static Quantity LactoseExcessPercentage(decimal value) => new() { Value = value, UnitCode = QuantityCode.LactoseExcessPercentage };

        /// <summary>
        /// pound
        /// </summary>
        public static Quantity Pound(decimal value) => new() { Value = value, UnitCode = QuantityCode.Pound };

        /// <summary>
        /// troy pound (US)
        /// </summary>
        public static Quantity TroyPoundUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.TroyPoundUS };

        /// <summary>
        /// litre per day
        /// </summary>
        public static Quantity LitrePerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.LitrePerDay };

        /// <summary>
        /// leaf
        /// </summary>
        public static Quantity Leaf(decimal value) => new() { Value = value, UnitCode = QuantityCode.Leaf };

        /// <summary>
        /// linear foot
        /// </summary>
        public static Quantity LinearFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.LinearFoot };

        /// <summary>
        /// labour hour
        /// </summary>
        public static Quantity LabourHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.LabourHour };

        /// <summary>
        /// link
        /// </summary>
        public static Quantity Link(decimal value) => new() { Value = value, UnitCode = QuantityCode.Link };

        /// <summary>
        /// linear metre
        /// </summary>
        public static Quantity LinearMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.LinearMetre };

        /// <summary>
        /// length
        /// </summary>
        public static Quantity Length(decimal value) => new() { Value = value, UnitCode = QuantityCode.Length };

        /// <summary>
        /// lot [unit of procurement]
        /// </summary>
        public static Quantity LotUnitOfProcurement(decimal value) => new() { Value = value, UnitCode = QuantityCode.LotUnitOfProcurement };

        /// <summary>
        /// liquid pound
        /// </summary>
        public static Quantity LiquidPound(decimal value) => new() { Value = value, UnitCode = QuantityCode.LiquidPound };

        /// <summary>
        /// litre of pure alcohol
        /// </summary>
        public static Quantity LitreOfPureAlcohol(decimal value) => new() { Value = value, UnitCode = QuantityCode.LitreOfPureAlcohol };

        /// <summary>
        /// layer
        /// </summary>
        public static Quantity Layer(decimal value) => new() { Value = value, UnitCode = QuantityCode.Layer };

        /// <summary>
        /// lump sum
        /// </summary>
        public static Quantity LumpSum(decimal value) => new() { Value = value, UnitCode = QuantityCode.LumpSum };

        /// <summary>
        /// ton (UK) or long ton (US)
        /// </summary>
        public static Quantity TonUKOrLongTonUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonUKOrLongTonUS };

        /// <summary>
        /// litre
        /// </summary>
        public static Quantity Litre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Litre };

        /// <summary>
        /// metric ton, lubricating oil
        /// </summary>
        public static Quantity MetricTonLubricatingOil(decimal value) => new() { Value = value, UnitCode = QuantityCode.MetricTonLubricatingOil };

        /// <summary>
        /// lumen
        /// </summary>
        public static Quantity Lumen(decimal value) => new() { Value = value, UnitCode = QuantityCode.Lumen };

        /// <summary>
        /// lux
        /// </summary>
        public static Quantity Lux(decimal value) => new() { Value = value, UnitCode = QuantityCode.Lux };

        /// <summary>
        /// linear yard
        /// </summary>
        public static Quantity LinearYard(decimal value) => new() { Value = value, UnitCode = QuantityCode.LinearYard };

        /// <summary>
        /// milligram per litre
        /// </summary>
        public static Quantity MilligramPerLitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerLitre };

        /// <summary>
        /// reciprocal cubic yard
        /// </summary>
        public static Quantity ReciprocalCubicYard(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalCubicYard };

        /// <summary>
        /// cubic yard per degree Fahrenheit
        /// </summary>
        public static Quantity CubicYardPerDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicYardPerDegreeFahrenheit };

        /// <summary>
        /// cubic yard per day
        /// </summary>
        public static Quantity CubicYardPerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicYardPerDay };

        /// <summary>
        /// cubic yard per hour
        /// </summary>
        public static Quantity CubicYardPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicYardPerHour };

        /// <summary>
        /// cubic yard per psi
        /// </summary>
        public static Quantity CubicYardPerPsi(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicYardPerPsi };

        /// <summary>
        /// cubic yard per minute
        /// </summary>
        public static Quantity CubicYardPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicYardPerMinute };

        /// <summary>
        /// cubic yard per second
        /// </summary>
        public static Quantity CubicYardPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicYardPerSecond };

        /// <summary>
        /// kilohertz metre
        /// </summary>
        public static Quantity KilohertzMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilohertzMetre };

        /// <summary>
        /// gigahertz metre
        /// </summary>
        public static Quantity GigahertzMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.GigahertzMetre };

        /// <summary>
        /// Beaufort
        /// </summary>
        public static Quantity Beaufort(decimal value) => new() { Value = value, UnitCode = QuantityCode.Beaufort };

        /// <summary>
        /// reciprocal megakelvin or megakelvin to the power minus one
        /// </summary>
        public static Quantity ReciprocalMegakelvinOrMegakelvinToThePowerMinusOne(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalMegakelvinOrMegakelvinToThePowerMinusOne };

        /// <summary>
        /// reciprocal kilovolt - ampere reciprocal hour
        /// </summary>
        public static Quantity ReciprocalKilovoltAmpereReciprocalHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalKilovoltAmpereReciprocalHour };

        /// <summary>
        /// millilitre per square centimetre minute
        /// </summary>
        public static Quantity MillilitrePerSquareCentimetreMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillilitrePerSquareCentimetreMinute };

        /// <summary>
        /// newton per centimetre
        /// </summary>
        public static Quantity NewtonPerCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.NewtonPerCentimetre };

        /// <summary>
        /// ohm kilometre
        /// </summary>
        public static Quantity OhmKilometre(decimal value) => new() { Value = value, UnitCode = QuantityCode.OhmKilometre };

        /// <summary>
        /// percent per degree Celsius
        /// </summary>
        public static Quantity PercentPerDegreeCelsius(decimal value) => new() { Value = value, UnitCode = QuantityCode.PercentPerDegreeCelsius };

        /// <summary>
        /// gigaohm per metre
        /// </summary>
        public static Quantity GigaohmPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.GigaohmPerMetre };

        /// <summary>
        /// megahertz metre
        /// </summary>
        public static Quantity MegahertzMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegahertzMetre };

        /// <summary>
        /// kilogram per kilogram
        /// </summary>
        public static Quantity KilogramPerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerKilogram };

        /// <summary>
        /// reciprocal volt - ampere reciprocal second
        /// </summary>
        public static Quantity ReciprocalVoltAmpereReciprocalSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalVoltAmpereReciprocalSecond };

        /// <summary>
        /// kilogram per kilometre
        /// </summary>
        public static Quantity KilogramPerKilometre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerKilometre };

        /// <summary>
        /// pascal second per litre
        /// </summary>
        public static Quantity PascalSecondPerLitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.PascalSecondPerLitre };

        /// <summary>
        /// millimole per litre
        /// </summary>
        public static Quantity MillimolePerLitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillimolePerLitre };

        /// <summary>
        /// newton metre per square metre
        /// </summary>
        public static Quantity NewtonMetrePerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.NewtonMetrePerSquareMetre };

        /// <summary>
        /// millivolt - ampere
        /// </summary>
        public static Quantity MillivoltAmpere(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillivoltAmpere };

        /// <summary>
        /// 30-day month
        /// </summary>
        public static Quantity Code30DayMonth(decimal value) => new() { Value = value, UnitCode = QuantityCode.Code30DayMonth };

        /// <summary>
        /// actual/360
        /// </summary>
        public static Quantity Actual360(decimal value) => new() { Value = value, UnitCode = QuantityCode.Actual360 };

        /// <summary>
        /// kilometre per second squared
        /// </summary>
        public static Quantity KilometrePerSecondSquared(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilometrePerSecondSquared };

        /// <summary>
        /// centimetre per second squared
        /// </summary>
        public static Quantity CentimetrePerSecondSquared(decimal value) => new() { Value = value, UnitCode = QuantityCode.CentimetrePerSecondSquared };

        /// <summary>
        /// monetary value
        /// </summary>
        public static Quantity MonetaryValue(decimal value) => new() { Value = value, UnitCode = QuantityCode.MonetaryValue };

        /// <summary>
        /// yard per second squared
        /// </summary>
        public static Quantity YardPerSecondSquared(decimal value) => new() { Value = value, UnitCode = QuantityCode.YardPerSecondSquared };

        /// <summary>
        /// millimetre per second squared
        /// </summary>
        public static Quantity MillimetrePerSecondSquared(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillimetrePerSecondSquared };

        /// <summary>
        /// mile (statute mile) per second squared
        /// </summary>
        public static Quantity MileStatuteMilePerSecondSquared(decimal value) => new() { Value = value, UnitCode = QuantityCode.MileStatuteMilePerSecondSquared };

        /// <summary>
        /// mil
        /// </summary>
        public static Quantity Mil(decimal value) => new() { Value = value, UnitCode = QuantityCode.Mil };

        /// <summary>
        /// revolution
        /// </summary>
        public static Quantity Revolution(decimal value) => new() { Value = value, UnitCode = QuantityCode.Revolution };

        /// <summary>
        /// degree [unit of angle] per second squared
        /// </summary>
        public static Quantity DegreeUnitOfAnglePerSecondSquared(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeUnitOfAnglePerSecondSquared };

        /// <summary>
        /// revolution per minute
        /// </summary>
        public static Quantity RevolutionPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.RevolutionPerMinute };

        /// <summary>
        /// circular mil
        /// </summary>
        public static Quantity CircularMil(decimal value) => new() { Value = value, UnitCode = QuantityCode.CircularMil };

        /// <summary>
        /// square mile (based on U.S. survey foot)
        /// </summary>
        public static Quantity SquareMileBasedOnUSSurveyFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMileBasedOnUSSurveyFoot };

        /// <summary>
        /// chain (based on U.S. survey foot)
        /// </summary>
        public static Quantity ChainBasedOnUSSurveyFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.ChainBasedOnUSSurveyFoot };

        /// <summary>
        /// microcurie
        /// </summary>
        public static Quantity Microcurie(decimal value) => new() { Value = value, UnitCode = QuantityCode.Microcurie };

        /// <summary>
        /// furlong
        /// </summary>
        public static Quantity Furlong(decimal value) => new() { Value = value, UnitCode = QuantityCode.Furlong };

        /// <summary>
        /// foot (U.S. survey)
        /// </summary>
        public static Quantity FootUSSurvey(decimal value) => new() { Value = value, UnitCode = QuantityCode.FootUSSurvey };

        /// <summary>
        /// mile (based on U.S. survey foot)
        /// </summary>
        public static Quantity MileBasedOnUSSurveyFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.MileBasedOnUSSurveyFoot };

        /// <summary>
        /// metre per pascal
        /// </summary>
        public static Quantity MetrePerPascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.MetrePerPascal };

        /// <summary>
        /// metre per radiant
        /// </summary>
        public static Quantity MetrePerRadiant(decimal value) => new() { Value = value, UnitCode = QuantityCode.MetrePerRadiant };

        /// <summary>
        /// shake
        /// </summary>
        public static Quantity Shake(decimal value) => new() { Value = value, UnitCode = QuantityCode.Shake };

        /// <summary>
        /// mile per minute
        /// </summary>
        public static Quantity MilePerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilePerMinute };

        /// <summary>
        /// mile per second
        /// </summary>
        public static Quantity MilePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilePerSecond };

        /// <summary>
        /// metre per second pascal
        /// </summary>
        public static Quantity MetrePerSecondPascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.MetrePerSecondPascal };

        /// <summary>
        /// metre per hour
        /// </summary>
        public static Quantity MetrePerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.MetrePerHour };

        /// <summary>
        /// inch per year
        /// </summary>
        public static Quantity InchPerYear(decimal value) => new() { Value = value, UnitCode = QuantityCode.InchPerYear };

        /// <summary>
        /// kilometre per second
        /// </summary>
        public static Quantity KilometrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilometrePerSecond };

        /// <summary>
        /// inch per minute
        /// </summary>
        public static Quantity InchPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.InchPerMinute };

        /// <summary>
        /// yard per second
        /// </summary>
        public static Quantity YardPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.YardPerSecond };

        /// <summary>
        /// yard per minute
        /// </summary>
        public static Quantity YardPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.YardPerMinute };

        /// <summary>
        /// yard per hour
        /// </summary>
        public static Quantity YardPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.YardPerHour };

        /// <summary>
        /// acre-foot (based on U.S. survey foot)
        /// </summary>
        public static Quantity AcreFootBasedOnUSSurveyFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.AcreFootBasedOnUSSurveyFoot };

        /// <summary>
        /// cord (128 ft3)
        /// </summary>
        public static Quantity Cord128Ft3(decimal value) => new() { Value = value, UnitCode = QuantityCode.Cord128Ft3 };

        /// <summary>
        /// cubic mile (UK statute)
        /// </summary>
        public static Quantity CubicMileUKStatute(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMileUKStatute };

        /// <summary>
        /// micro-inch
        /// </summary>
        public static Quantity MicroInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicroInch };

        /// <summary>
        /// ton, register
        /// </summary>
        public static Quantity TonRegister(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonRegister };

        /// <summary>
        /// cubic metre per pascal
        /// </summary>
        public static Quantity CubicMetrePerPascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetrePerPascal };

        /// <summary>
        /// bel
        /// </summary>
        public static Quantity Bel(decimal value) => new() { Value = value, UnitCode = QuantityCode.Bel };

        /// <summary>
        /// kilogram per cubic metre pascal
        /// </summary>
        public static Quantity KilogramPerCubicMetrePascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerCubicMetrePascal };

        /// <summary>
        /// kilogram per pascal
        /// </summary>
        public static Quantity KilogramPerPascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerPascal };

        /// <summary>
        /// kilopound-force
        /// </summary>
        public static Quantity KilopoundForce(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilopoundForce };

        /// <summary>
        /// poundal
        /// </summary>
        public static Quantity Poundal(decimal value) => new() { Value = value, UnitCode = QuantityCode.Poundal };

        /// <summary>
        /// kilogram metre per second squared
        /// </summary>
        public static Quantity KilogramMetrePerSecondSquared(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramMetrePerSecondSquared };

        /// <summary>
        /// pond
        /// </summary>
        public static Quantity Pond(decimal value) => new() { Value = value, UnitCode = QuantityCode.Pond };

        /// <summary>
        /// square foot per hour
        /// </summary>
        public static Quantity SquareFootPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareFootPerHour };

        /// <summary>
        /// stokes per pascal
        /// </summary>
        public static Quantity StokesPerPascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.StokesPerPascal };

        /// <summary>
        /// square centimetre per second
        /// </summary>
        public static Quantity SquareCentimetrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareCentimetrePerSecond };

        /// <summary>
        /// square metre per second pascal
        /// </summary>
        public static Quantity SquareMetrePerSecondPascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMetrePerSecondPascal };

        /// <summary>
        /// denier
        /// </summary>
        public static Quantity DenierM83(decimal value) => new() { Value = value, UnitCode = QuantityCode.DenierM83 };

        /// <summary>
        /// pound per yard
        /// </summary>
        public static Quantity PoundPerYard(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundPerYard };

        /// <summary>
        /// ton, assay
        /// </summary>
        public static Quantity TonAssay(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonAssay };

        /// <summary>
        /// pfund
        /// </summary>
        public static Quantity Pfund(decimal value) => new() { Value = value, UnitCode = QuantityCode.Pfund };

        /// <summary>
        /// kilogram per second pascal
        /// </summary>
        public static Quantity KilogramPerSecondPascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerSecondPascal };

        /// <summary>
        /// tonne per month
        /// </summary>
        public static Quantity TonnePerMonth(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonnePerMonth };

        /// <summary>
        /// tonne per year
        /// </summary>
        public static Quantity TonnePerYear(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonnePerYear };

        /// <summary>
        /// million Btu per 1000 cubic foot
        /// </summary>
        public static Quantity MillionBtuPer1000CubicFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillionBtuPer1000CubicFoot };

        /// <summary>
        /// kilopound per hour
        /// </summary>
        public static Quantity KilopoundPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilopoundPerHour };

        /// <summary>
        /// pound per pound
        /// </summary>
        public static Quantity PoundPerPound(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundPerPound };

        /// <summary>
        /// pound-force foot
        /// </summary>
        public static Quantity PoundForceFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundForceFoot };

        /// <summary>
        /// newton metre per radian
        /// </summary>
        public static Quantity NewtonMetrePerRadian(decimal value) => new() { Value = value, UnitCode = QuantityCode.NewtonMetrePerRadian };

        /// <summary>
        /// kilogram metre
        /// </summary>
        public static Quantity KilogramMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramMetre };

        /// <summary>
        /// poundal foot
        /// </summary>
        public static Quantity PoundalFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundalFoot };

        /// <summary>
        /// poundal inch
        /// </summary>
        public static Quantity PoundalInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundalInch };

        /// <summary>
        /// dyne metre
        /// </summary>
        public static Quantity DyneMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.DyneMetre };

        /// <summary>
        /// kilogram centimetre per second
        /// </summary>
        public static Quantity KilogramCentimetrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramCentimetrePerSecond };

        /// <summary>
        /// gram centimetre per second
        /// </summary>
        public static Quantity GramCentimetrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramCentimetrePerSecond };

        /// <summary>
        /// megavolt ampere reactive hour
        /// </summary>
        public static Quantity MegavoltAmpereReactiveHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegavoltAmpereReactiveHour };

        /// <summary>
        /// megalitre
        /// </summary>
        public static Quantity Megalitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Megalitre };

        /// <summary>
        /// megametre
        /// </summary>
        public static Quantity Megametre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Megametre };

        /// <summary>
        /// megavar
        /// </summary>
        public static Quantity Megavar(decimal value) => new() { Value = value, UnitCode = QuantityCode.Megavar };

        /// <summary>
        /// megawatt
        /// </summary>
        public static Quantity Megawatt(decimal value) => new() { Value = value, UnitCode = QuantityCode.Megawatt };

        /// <summary>
        /// thousand standard brick equivalent
        /// </summary>
        public static Quantity ThousandStandardBrickEquivalent(decimal value) => new() { Value = value, UnitCode = QuantityCode.ThousandStandardBrickEquivalent };

        /// <summary>
        /// thousand board foot
        /// </summary>
        public static Quantity ThousandBoardFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.ThousandBoardFoot };

        /// <summary>
        /// millibar
        /// </summary>
        public static Quantity Millibar(decimal value) => new() { Value = value, UnitCode = QuantityCode.Millibar };

        /// <summary>
        /// microgram
        /// </summary>
        public static Quantity Microgram(decimal value) => new() { Value = value, UnitCode = QuantityCode.Microgram };

        /// <summary>
        /// millicurie
        /// </summary>
        public static Quantity Millicurie(decimal value) => new() { Value = value, UnitCode = QuantityCode.Millicurie };

        /// <summary>
        /// air dry metric ton
        /// </summary>
        public static Quantity AirDryMetricTon(decimal value) => new() { Value = value, UnitCode = QuantityCode.AirDryMetricTon };

        /// <summary>
        /// milligram
        /// </summary>
        public static Quantity Milligram(decimal value) => new() { Value = value, UnitCode = QuantityCode.Milligram };

        /// <summary>
        /// megahertz
        /// </summary>
        public static Quantity Megahertz(decimal value) => new() { Value = value, UnitCode = QuantityCode.Megahertz };

        /// <summary>
        /// square mile (statute mile)
        /// </summary>
        public static Quantity SquareMileStatuteMile(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMileStatuteMile };

        /// <summary>
        /// thousand
        /// </summary>
        public static Quantity Thousand(decimal value) => new() { Value = value, UnitCode = QuantityCode.Thousand };

        /// <summary>
        /// minute [unit of time]
        /// </summary>
        public static Quantity MinuteUnitOfTime(decimal value) => new() { Value = value, UnitCode = QuantityCode.MinuteUnitOfTime };

        /// <summary>
        /// million
        /// </summary>
        public static Quantity Million(decimal value) => new() { Value = value, UnitCode = QuantityCode.Million };

        /// <summary>
        /// million international unit
        /// </summary>
        public static Quantity MillionInternationalUnit(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillionInternationalUnit };

        /// <summary>
        /// Square Metre Day
        /// </summary>
        public static Quantity SquareMetreDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMetreDay };

        /// <summary>
        /// Square Metre Month
        /// </summary>
        public static Quantity SquareMetreMonth(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMetreMonth };

        /// <summary>
        /// Square Metre Week
        /// </summary>
        public static Quantity SquareMetreWeek(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMetreWeek };

        /// <summary>
        /// milliard
        /// </summary>
        public static Quantity Milliard(decimal value) => new() { Value = value, UnitCode = QuantityCode.Milliard };

        /// <summary>
        /// millilitre
        /// </summary>
        public static Quantity Millilitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Millilitre };

        /// <summary>
        /// square millimetre
        /// </summary>
        public static Quantity SquareMillimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMillimetre };

        /// <summary>
        /// cubic millimetre
        /// </summary>
        public static Quantity CubicMillimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMillimetre };

        /// <summary>
        /// millimetre
        /// </summary>
        public static Quantity Millimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Millimetre };

        /// <summary>
        /// kilogram, dry weight
        /// </summary>
        public static Quantity KilogramDryWeight(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramDryWeight };

        /// <summary>
        /// Mega Joule per Normalised cubic Metre
        /// </summary>
        public static Quantity MegaJoulePerNormalisedCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegaJoulePerNormalisedCubicMetre };

        /// <summary>
        /// month
        /// </summary>
        public static Quantity Month(decimal value) => new() { Value = value, UnitCode = QuantityCode.Month };

        /// <summary>
        /// megapascal
        /// </summary>
        public static Quantity Megapascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.Megapascal };

        /// <summary>
        /// Cubic Metre Day
        /// </summary>
        public static Quantity CubicMetreDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetreDay };

        /// <summary>
        /// cubic metre per hour
        /// </summary>
        public static Quantity CubicMetrePerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetrePerHour };

        /// <summary>
        /// Cubic Metre Month
        /// </summary>
        public static Quantity CubicMetreMonth(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetreMonth };

        /// <summary>
        /// cubic metre per second
        /// </summary>
        public static Quantity CubicMetrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetrePerSecond };

        /// <summary>
        /// Cubic Metre Week
        /// </summary>
        public static Quantity CubicMetreWeek(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetreWeek };

        /// <summary>
        /// Metre Day
        /// </summary>
        public static Quantity MetreDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.MetreDay };

        /// <summary>
        /// Metre Month
        /// </summary>
        public static Quantity MetreMonth(decimal value) => new() { Value = value, UnitCode = QuantityCode.MetreMonth };

        /// <summary>
        /// Metre Week
        /// </summary>
        public static Quantity MetreWeek(decimal value) => new() { Value = value, UnitCode = QuantityCode.MetreWeek };

        /// <summary>
        /// metre per second squared
        /// </summary>
        public static Quantity MetrePerSecondSquared(decimal value) => new() { Value = value, UnitCode = QuantityCode.MetrePerSecondSquared };

        /// <summary>
        /// square metre
        /// </summary>
        public static Quantity SquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMetre };

        /// <summary>
        /// cubic metre
        /// </summary>
        public static Quantity CubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetre };

        /// <summary>
        /// metre
        /// </summary>
        public static Quantity Metre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Metre };

        /// <summary>
        /// metre per second
        /// </summary>
        public static Quantity MetrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.MetrePerSecond };

        /// <summary>
        /// millihertz
        /// </summary>
        public static Quantity Millihertz(decimal value) => new() { Value = value, UnitCode = QuantityCode.Millihertz };

        /// <summary>
        /// megavolt - ampere
        /// </summary>
        public static Quantity MegavoltAmpere(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegavoltAmpere };

        /// <summary>
        /// megawatt hour (1000 kW.h)
        /// </summary>
        public static Quantity MegawattHour1000KWH(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegawattHour1000KWH };

        /// <summary>
        /// pen calorie
        /// </summary>
        public static Quantity PenCalorie(decimal value) => new() { Value = value, UnitCode = QuantityCode.PenCalorie };

        /// <summary>
        /// pound foot per second
        /// </summary>
        public static Quantity PoundFootPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundFootPerSecond };

        /// <summary>
        /// pound inch per second
        /// </summary>
        public static Quantity PoundInchPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundInchPerSecond };

        /// <summary>
        /// Pferdestaerke
        /// </summary>
        public static Quantity Pferdestaerke(decimal value) => new() { Value = value, UnitCode = QuantityCode.Pferdestaerke };

        /// <summary>
        /// centimetre of mercury (0 ºC)
        /// </summary>
        public static Quantity CentimetreOfMercury0C(decimal value) => new() { Value = value, UnitCode = QuantityCode.CentimetreOfMercury0C };

        /// <summary>
        /// centimetre of water (4 ºC)
        /// </summary>
        public static Quantity CentimetreOfWater4C(decimal value) => new() { Value = value, UnitCode = QuantityCode.CentimetreOfWater4C };

        /// <summary>
        /// foot of water (39.2 ºF)
        /// </summary>
        public static Quantity FootOfWater392F(decimal value) => new() { Value = value, UnitCode = QuantityCode.FootOfWater392F };

        /// <summary>
        /// inch of mercury (32 ºF)
        /// </summary>
        public static Quantity InchOfMercury32F(decimal value) => new() { Value = value, UnitCode = QuantityCode.InchOfMercury32F };

        /// <summary>
        /// inch of mercury (60 ºF)
        /// </summary>
        public static Quantity InchOfMercury60F(decimal value) => new() { Value = value, UnitCode = QuantityCode.InchOfMercury60F };

        /// <summary>
        /// inch of water (39.2 ºF)
        /// </summary>
        public static Quantity InchOfWater392F(decimal value) => new() { Value = value, UnitCode = QuantityCode.InchOfWater392F };

        /// <summary>
        /// inch of water (60 ºF)
        /// </summary>
        public static Quantity InchOfWater60F(decimal value) => new() { Value = value, UnitCode = QuantityCode.InchOfWater60F };

        /// <summary>
        /// kip per square inch
        /// </summary>
        public static Quantity KipPerSquareInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.KipPerSquareInch };

        /// <summary>
        /// poundal per square foot
        /// </summary>
        public static Quantity PoundalPerSquareFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundalPerSquareFoot };

        /// <summary>
        /// ounce (avoirdupois) per square inch
        /// </summary>
        public static Quantity OunceAvoirdupoisPerSquareInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.OunceAvoirdupoisPerSquareInch };

        /// <summary>
        /// conventional metre of water
        /// </summary>
        public static Quantity ConventionalMetreOfWater(decimal value) => new() { Value = value, UnitCode = QuantityCode.ConventionalMetreOfWater };

        /// <summary>
        /// gram per square millimetre
        /// </summary>
        public static Quantity GramPerSquareMillimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerSquareMillimetre };

        /// <summary>
        /// pound per square yard
        /// </summary>
        public static Quantity PoundPerSquareYard(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundPerSquareYard };

        /// <summary>
        /// poundal per square inch
        /// </summary>
        public static Quantity PoundalPerSquareInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundalPerSquareInch };

        /// <summary>
        /// foot to the fourth power
        /// </summary>
        public static Quantity FootToTheFourthPower(decimal value) => new() { Value = value, UnitCode = QuantityCode.FootToTheFourthPower };

        /// <summary>
        /// cubic decimetre per kilogram
        /// </summary>
        public static Quantity CubicDecimetrePerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicDecimetrePerKilogram };

        /// <summary>
        /// cubic foot per pound
        /// </summary>
        public static Quantity CubicFootPerPound(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicFootPerPound };

        /// <summary>
        /// print point
        /// </summary>
        public static Quantity PrintPoint(decimal value) => new() { Value = value, UnitCode = QuantityCode.PrintPoint };

        /// <summary>
        /// cubic inch per pound
        /// </summary>
        public static Quantity CubicInchPerPound(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicInchPerPound };

        /// <summary>
        /// kilonewton per metre
        /// </summary>
        public static Quantity KilonewtonPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilonewtonPerMetre };

        /// <summary>
        /// poundal per inch
        /// </summary>
        public static Quantity PoundalPerInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundalPerInch };

        /// <summary>
        /// pound-force per yard
        /// </summary>
        public static Quantity PoundForcePerYard(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundForcePerYard };

        /// <summary>
        /// poundal second per square foot
        /// </summary>
        public static Quantity PoundalSecondPerSquareFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundalSecondPerSquareFoot };

        /// <summary>
        /// poise per pascal
        /// </summary>
        public static Quantity PoisePerPascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoisePerPascal };

        /// <summary>
        /// newton second per square metre
        /// </summary>
        public static Quantity NewtonSecondPerSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.NewtonSecondPerSquareMetre };

        /// <summary>
        /// kilogram per metre second
        /// </summary>
        public static Quantity KilogramPerMetreSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerMetreSecond };

        /// <summary>
        /// kilogram per metre minute
        /// </summary>
        public static Quantity KilogramPerMetreMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerMetreMinute };

        /// <summary>
        /// kilogram per metre day
        /// </summary>
        public static Quantity KilogramPerMetreDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerMetreDay };

        /// <summary>
        /// kilogram per metre hour
        /// </summary>
        public static Quantity KilogramPerMetreHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerMetreHour };

        /// <summary>
        /// gram per centimetre second
        /// </summary>
        public static Quantity GramPerCentimetreSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.GramPerCentimetreSecond };

        /// <summary>
        /// poundal second per square inch
        /// </summary>
        public static Quantity PoundalSecondPerSquareInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundalSecondPerSquareInch };

        /// <summary>
        /// pound per foot minute
        /// </summary>
        public static Quantity PoundPerFootMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundPerFootMinute };

        /// <summary>
        /// pound per foot day
        /// </summary>
        public static Quantity PoundPerFootDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundPerFootDay };

        /// <summary>
        /// cubic metre per second pascal
        /// </summary>
        public static Quantity CubicMetrePerSecondPascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetrePerSecondPascal };

        /// <summary>
        /// foot poundal
        /// </summary>
        public static Quantity FootPoundal(decimal value) => new() { Value = value, UnitCode = QuantityCode.FootPoundal };

        /// <summary>
        /// inch poundal
        /// </summary>
        public static Quantity InchPoundal(decimal value) => new() { Value = value, UnitCode = QuantityCode.InchPoundal };

        /// <summary>
        /// watt per square centimetre
        /// </summary>
        public static Quantity WattPerSquareCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.WattPerSquareCentimetre };

        /// <summary>
        /// watt per square inch
        /// </summary>
        public static Quantity WattPerSquareInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.WattPerSquareInch };

        /// <summary>
        /// British thermal unit (international table) per square foot hour
        /// </summary>
        public static Quantity BritishThermalUnitInternationalTablePerSquareFootHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitInternationalTablePerSquareFootHour };

        /// <summary>
        /// British thermal unit (thermochemical) per square foot hour
        /// </summary>
        public static Quantity BritishThermalUnitThermochemicalPerSquareFootHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitThermochemicalPerSquareFootHour };

        /// <summary>
        /// British thermal unit (thermochemical) per square foot minute
        /// </summary>
        public static Quantity BritishThermalUnitThermochemicalPerSquareFootMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitThermochemicalPerSquareFootMinute };

        /// <summary>
        /// British thermal unit (international table) per square foot second
        /// </summary>
        public static Quantity BritishThermalUnitInternationalTablePerSquareFootSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitInternationalTablePerSquareFootSecond };

        /// <summary>
        /// British thermal unit (thermochemical) per square foot second
        /// </summary>
        public static Quantity BritishThermalUnitThermochemicalPerSquareFootSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitThermochemicalPerSquareFootSecond };

        /// <summary>
        /// British thermal unit (international table) per square inch second
        /// </summary>
        public static Quantity BritishThermalUnitInternationalTablePerSquareInchSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitInternationalTablePerSquareInchSecond };

        /// <summary>
        /// calorie (thermochemical) per square centimetre minute
        /// </summary>
        public static Quantity CalorieThermochemicalPerSquareCentimetreMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.CalorieThermochemicalPerSquareCentimetreMinute };

        /// <summary>
        /// calorie (thermochemical) per square centimetre second
        /// </summary>
        public static Quantity CalorieThermochemicalPerSquareCentimetreSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.CalorieThermochemicalPerSquareCentimetreSecond };

        /// <summary>
        /// British thermal unit (international table) per cubic foot
        /// </summary>
        public static Quantity BritishThermalUnitInternationalTablePerCubicFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitInternationalTablePerCubicFoot };

        /// <summary>
        /// British thermal unit (thermochemical) per cubic foot
        /// </summary>
        public static Quantity BritishThermalUnitThermochemicalPerCubicFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitThermochemicalPerCubicFoot };

        /// <summary>
        /// British thermal unit (international table) per degree Fahrenheit
        /// </summary>
        public static Quantity BritishThermalUnitInternationalTablePerDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitInternationalTablePerDegreeFahrenheit };

        /// <summary>
        /// British thermal unit (thermochemical) per degree Fahrenheit
        /// </summary>
        public static Quantity BritishThermalUnitThermochemicalPerDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitThermochemicalPerDegreeFahrenheit };

        /// <summary>
        /// British thermal unit (international table) per degree Rankine
        /// </summary>
        public static Quantity BritishThermalUnitInternationalTablePerDegreeRankine(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitInternationalTablePerDegreeRankine };

        /// <summary>
        /// British thermal unit (thermochemical) per degree Rankine
        /// </summary>
        public static Quantity BritishThermalUnitThermochemicalPerDegreeRankine(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitThermochemicalPerDegreeRankine };

        /// <summary>
        /// British thermal unit (thermochemical) per pound degree Rankine
        /// </summary>
        public static Quantity BritishThermalUnitThermochemicalPerPoundDegreeRankine(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitThermochemicalPerPoundDegreeRankine };

        /// <summary>
        /// kilocalorie (international table) per gram kelvin
        /// </summary>
        public static Quantity KilocalorieInternationalTablePerGramKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilocalorieInternationalTablePerGramKelvin };

        /// <summary>
        /// British thermal unit (39 ºF)
        /// </summary>
        public static Quantity BritishThermalUnit39F(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnit39F };

        /// <summary>
        /// British thermal unit (59 ºF)
        /// </summary>
        public static Quantity BritishThermalUnit59F(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnit59F };

        /// <summary>
        /// British thermal unit (60 ºF)
        /// </summary>
        public static Quantity BritishThermalUnit60F(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnit60F };

        /// <summary>
        /// calorie (20 ºC)
        /// </summary>
        public static Quantity Calorie20C(decimal value) => new() { Value = value, UnitCode = QuantityCode.Calorie20C };

        /// <summary>
        /// quad (1015 BtuIT)
        /// </summary>
        public static Quantity Quad1015BtuIT(decimal value) => new() { Value = value, UnitCode = QuantityCode.Quad1015BtuIT };

        /// <summary>
        /// therm (EC)
        /// </summary>
        public static Quantity ThermEC(decimal value) => new() { Value = value, UnitCode = QuantityCode.ThermEC };

        /// <summary>
        /// therm (U.S.)
        /// </summary>
        public static Quantity ThermUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.ThermUS };

        /// <summary>
        /// British thermal unit (thermochemical) per pound
        /// </summary>
        public static Quantity BritishThermalUnitThermochemicalPerPound(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitThermochemicalPerPound };

        /// <summary>
        /// British thermal unit (international table) per hour square foot degree Fahrenheit
        /// </summary>
        public static Quantity BritishThermalUnitInternationalTablePerHourSquareFootDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitInternationalTablePerHourSquareFootDegreeFahrenheit };

        /// <summary>
        /// British thermal unit (thermochemical) per hour square foot degree Fahrenheit
        /// </summary>
        public static Quantity BritishThermalUnitThermochemicalPerHourSquareFootDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitThermochemicalPerHourSquareFootDegreeFahrenheit };

        /// <summary>
        /// British thermal unit (international table) per second square foot degree Fahrenheit
        /// </summary>
        public static Quantity BritishThermalUnitInternationalTablePerSecondSquareFootDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitInternationalTablePerSecondSquareFootDegreeFahrenheit };

        /// <summary>
        /// British thermal unit (thermochemical) per second square foot degree Fahrenheit
        /// </summary>
        public static Quantity BritishThermalUnitThermochemicalPerSecondSquareFootDegreeFahrenheit(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitThermochemicalPerSecondSquareFootDegreeFahrenheit };

        /// <summary>
        /// kilowatt per square metre kelvin
        /// </summary>
        public static Quantity KilowattPerSquareMetreKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilowattPerSquareMetreKelvin };

        /// <summary>
        /// kelvin per pascal
        /// </summary>
        public static Quantity KelvinPerPascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.KelvinPerPascal };

        /// <summary>
        /// watt per metre degree Celsius
        /// </summary>
        public static Quantity WattPerMetreDegreeCelsius(decimal value) => new() { Value = value, UnitCode = QuantityCode.WattPerMetreDegreeCelsius };

        /// <summary>
        /// kilowatt per metre kelvin
        /// </summary>
        public static Quantity KilowattPerMetreKelvin(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilowattPerMetreKelvin };

        /// <summary>
        /// kilowatt per metre degree Celsius
        /// </summary>
        public static Quantity KilowattPerMetreDegreeCelsius(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilowattPerMetreDegreeCelsius };

        /// <summary>
        /// metre per degree Celcius metre
        /// </summary>
        public static Quantity MetrePerDegreeCelciusMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MetrePerDegreeCelciusMetre };

        /// <summary>
        /// degree Fahrenheit hour per British thermal unit (international table)
        /// </summary>
        public static Quantity DegreeFahrenheitHourPerBritishThermalUnitInternationalTable(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeFahrenheitHourPerBritishThermalUnitInternationalTable };

        /// <summary>
        /// degree Fahrenheit hour per British thermal unit (thermochemical)
        /// </summary>
        public static Quantity DegreeFahrenheitHourPerBritishThermalUnitThermochemical(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeFahrenheitHourPerBritishThermalUnitThermochemical };

        /// <summary>
        /// degree Fahrenheit second per British thermal unit (international table)
        /// </summary>
        public static Quantity DegreeFahrenheitSecondPerBritishThermalUnitInternationalTable(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeFahrenheitSecondPerBritishThermalUnitInternationalTable };

        /// <summary>
        /// degree Fahrenheit second per British thermal unit (thermochemical)
        /// </summary>
        public static Quantity DegreeFahrenheitSecondPerBritishThermalUnitThermochemical(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeFahrenheitSecondPerBritishThermalUnitThermochemical };

        /// <summary>
        /// degree Fahrenheit hour square foot per British thermal unit (international table) inch
        /// </summary>
        public static Quantity DegreeFahrenheitHourSquareFootPerBritishThermalUnitInternationalTableInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeFahrenheitHourSquareFootPerBritishThermalUnitInternationalTableInch };

        /// <summary>
        /// degree Fahrenheit hour square foot per British thermal unit (thermochemical) inch
        /// </summary>
        public static Quantity DegreeFahrenheitHourSquareFootPerBritishThermalUnitThermochemicalInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreeFahrenheitHourSquareFootPerBritishThermalUnitThermochemicalInch };

        /// <summary>
        /// kilofarad
        /// </summary>
        public static Quantity Kilofarad(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilofarad };

        /// <summary>
        /// reciprocal joule
        /// </summary>
        public static Quantity ReciprocalJoule(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalJoule };

        /// <summary>
        /// picosiemens
        /// </summary>
        public static Quantity Picosiemens(decimal value) => new() { Value = value, UnitCode = QuantityCode.Picosiemens };

        /// <summary>
        /// ampere per pascal
        /// </summary>
        public static Quantity AmperePerPascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.AmperePerPascal };

        /// <summary>
        /// franklin
        /// </summary>
        public static Quantity Franklin(decimal value) => new() { Value = value, UnitCode = QuantityCode.Franklin };

        /// <summary>
        /// ampere minute
        /// </summary>
        public static Quantity AmpereMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.AmpereMinute };

        /// <summary>
        /// biot
        /// </summary>
        public static Quantity Biot(decimal value) => new() { Value = value, UnitCode = QuantityCode.Biot };

        /// <summary>
        /// gilbert
        /// </summary>
        public static Quantity Gilbert(decimal value) => new() { Value = value, UnitCode = QuantityCode.Gilbert };

        /// <summary>
        /// volt per pascal
        /// </summary>
        public static Quantity VoltPerPascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.VoltPerPascal };

        /// <summary>
        /// picovolt
        /// </summary>
        public static Quantity Picovolt(decimal value) => new() { Value = value, UnitCode = QuantityCode.Picovolt };

        /// <summary>
        /// milligram per kilogram
        /// </summary>
        public static Quantity MilligramPerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligramPerKilogram };

        /// <summary>
        /// number of articles
        /// </summary>
        public static Quantity NumberOfArticles(decimal value) => new() { Value = value, UnitCode = QuantityCode.NumberOfArticles };

        /// <summary>
        /// number of cells
        /// </summary>
        public static Quantity NumberOfCells(decimal value) => new() { Value = value, UnitCode = QuantityCode.NumberOfCells };

        /// <summary>
        /// newton
        /// </summary>
        public static Quantity Newton(decimal value) => new() { Value = value, UnitCode = QuantityCode.Newton };

        /// <summary>
        /// message
        /// </summary>
        public static Quantity Message(decimal value) => new() { Value = value, UnitCode = QuantityCode.Message };

        /// <summary>
        /// nil
        /// </summary>
        public static Quantity Nil(decimal value) => new() { Value = value, UnitCode = QuantityCode.Nil };

        /// <summary>
        /// number of international units
        /// </summary>
        public static Quantity NumberOfInternationalUnits(decimal value) => new() { Value = value, UnitCode = QuantityCode.NumberOfInternationalUnits };

        /// <summary>
        /// load
        /// </summary>
        public static Quantity Load(decimal value) => new() { Value = value, UnitCode = QuantityCode.Load };

        /// <summary>
        /// Normalised cubic metre
        /// </summary>
        public static Quantity NormalisedCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.NormalisedCubicMetre };

        /// <summary>
        /// nautical mile
        /// </summary>
        public static Quantity NauticalMile(decimal value) => new() { Value = value, UnitCode = QuantityCode.NauticalMile };

        /// <summary>
        /// number of packs
        /// </summary>
        public static Quantity NumberOfPacks(decimal value) => new() { Value = value, UnitCode = QuantityCode.NumberOfPacks };

        /// <summary>
        /// number of parts
        /// </summary>
        public static Quantity NumberOfParts(decimal value) => new() { Value = value, UnitCode = QuantityCode.NumberOfParts };

        /// <summary>
        /// net ton
        /// </summary>
        public static Quantity NetTon(decimal value) => new() { Value = value, UnitCode = QuantityCode.NetTon };

        /// <summary>
        /// Nephelometric turbidity unit
        /// </summary>
        public static Quantity NephelometricTurbidityUnit(decimal value) => new() { Value = value, UnitCode = QuantityCode.NephelometricTurbidityUnit };

        /// <summary>
        /// newton metre
        /// </summary>
        public static Quantity NewtonMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.NewtonMetre };

        /// <summary>
        /// part per thousand
        /// </summary>
        public static Quantity PartPerThousand(decimal value) => new() { Value = value, UnitCode = QuantityCode.PartPerThousand };

        /// <summary>
        /// panel
        /// </summary>
        public static Quantity Panel(decimal value) => new() { Value = value, UnitCode = QuantityCode.Panel };

        /// <summary>
        /// ozone depletion equivalent
        /// </summary>
        public static Quantity OzoneDepletionEquivalent(decimal value) => new() { Value = value, UnitCode = QuantityCode.OzoneDepletionEquivalent };

        /// <summary>
        /// ODS Grams
        /// </summary>
        public static Quantity ODSGrams(decimal value) => new() { Value = value, UnitCode = QuantityCode.ODSGrams };

        /// <summary>
        /// ODS Kilograms
        /// </summary>
        public static Quantity ODSKilograms(decimal value) => new() { Value = value, UnitCode = QuantityCode.ODSKilograms };

        /// <summary>
        /// ODS Milligrams
        /// </summary>
        public static Quantity ODSMilligrams(decimal value) => new() { Value = value, UnitCode = QuantityCode.ODSMilligrams };

        /// <summary>
        /// ohm
        /// </summary>
        public static Quantity Ohm(decimal value) => new() { Value = value, UnitCode = QuantityCode.Ohm };

        /// <summary>
        /// ounce per square yard
        /// </summary>
        public static Quantity OuncePerSquareYard(decimal value) => new() { Value = value, UnitCode = QuantityCode.OuncePerSquareYard };

        /// <summary>
        /// ounce (avoirdupois)
        /// </summary>
        public static Quantity OunceAvoirdupois(decimal value) => new() { Value = value, UnitCode = QuantityCode.OunceAvoirdupois };

        /// <summary>
        /// oscillations per minute
        /// </summary>
        public static Quantity OscillationsPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.OscillationsPerMinute };

        /// <summary>
        /// overtime hour
        /// </summary>
        public static Quantity OvertimeHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.OvertimeHour };

        /// <summary>
        /// fluid ounce (US)
        /// </summary>
        public static Quantity FluidOunceUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.FluidOunceUS };

        /// <summary>
        /// fluid ounce (UK)
        /// </summary>
        public static Quantity FluidOunceUK(decimal value) => new() { Value = value, UnitCode = QuantityCode.FluidOunceUK };

        /// <summary>
        /// percent
        /// </summary>
        public static Quantity Percent(decimal value) => new() { Value = value, UnitCode = QuantityCode.Percent };

        /// <summary>
        /// coulomb per metre
        /// </summary>
        public static Quantity CoulombPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CoulombPerMetre };

        /// <summary>
        /// kiloweber
        /// </summary>
        public static Quantity Kiloweber(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kiloweber };

        /// <summary>
        /// gamma
        /// </summary>
        public static Quantity Gamma(decimal value) => new() { Value = value, UnitCode = QuantityCode.Gamma };

        /// <summary>
        /// kilotesla
        /// </summary>
        public static Quantity Kilotesla(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilotesla };

        /// <summary>
        /// joule per second
        /// </summary>
        public static Quantity JoulePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.JoulePerSecond };

        /// <summary>
        /// joule per minute
        /// </summary>
        public static Quantity JoulePerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.JoulePerMinute };

        /// <summary>
        /// joule per hour
        /// </summary>
        public static Quantity JoulePerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.JoulePerHour };

        /// <summary>
        /// joule per day
        /// </summary>
        public static Quantity JoulePerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.JoulePerDay };

        /// <summary>
        /// kilojoule per second
        /// </summary>
        public static Quantity KilojoulePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilojoulePerSecond };

        /// <summary>
        /// kilojoule per minute
        /// </summary>
        public static Quantity KilojoulePerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilojoulePerMinute };

        /// <summary>
        /// pound per foot
        /// </summary>
        public static Quantity PoundPerFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundPerFoot };

        /// <summary>
        /// kilojoule per hour
        /// </summary>
        public static Quantity KilojoulePerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilojoulePerHour };

        /// <summary>
        /// kilojoule per day
        /// </summary>
        public static Quantity KilojoulePerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilojoulePerDay };

        /// <summary>
        /// nanoohm
        /// </summary>
        public static Quantity Nanoohm(decimal value) => new() { Value = value, UnitCode = QuantityCode.Nanoohm };

        /// <summary>
        /// ohm circular-mil per foot
        /// </summary>
        public static Quantity OhmCircularMilPerFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.OhmCircularMilPerFoot };

        /// <summary>
        /// kilohenry
        /// </summary>
        public static Quantity Kilohenry(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilohenry };

        /// <summary>
        /// lumen per square foot
        /// </summary>
        public static Quantity LumenPerSquareFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.LumenPerSquareFoot };

        /// <summary>
        /// phot
        /// </summary>
        public static Quantity Phot(decimal value) => new() { Value = value, UnitCode = QuantityCode.Phot };

        /// <summary>
        /// footcandle
        /// </summary>
        public static Quantity Footcandle(decimal value) => new() { Value = value, UnitCode = QuantityCode.Footcandle };

        /// <summary>
        /// candela per square inch
        /// </summary>
        public static Quantity CandelaPerSquareInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.CandelaPerSquareInch };

        /// <summary>
        /// footlambert
        /// </summary>
        public static Quantity Footlambert(decimal value) => new() { Value = value, UnitCode = QuantityCode.Footlambert };

        /// <summary>
        /// lambert
        /// </summary>
        public static Quantity Lambert(decimal value) => new() { Value = value, UnitCode = QuantityCode.Lambert };

        /// <summary>
        /// stilb
        /// </summary>
        public static Quantity Stilb(decimal value) => new() { Value = value, UnitCode = QuantityCode.Stilb };

        /// <summary>
        /// candela per square foot
        /// </summary>
        public static Quantity CandelaPerSquareFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.CandelaPerSquareFoot };

        /// <summary>
        /// kilocandela
        /// </summary>
        public static Quantity Kilocandela(decimal value) => new() { Value = value, UnitCode = QuantityCode.Kilocandela };

        /// <summary>
        /// millicandela
        /// </summary>
        public static Quantity Millicandela(decimal value) => new() { Value = value, UnitCode = QuantityCode.Millicandela };

        /// <summary>
        /// Hefner-Kerze
        /// </summary>
        public static Quantity HefnerKerze(decimal value) => new() { Value = value, UnitCode = QuantityCode.HefnerKerze };

        /// <summary>
        /// international candle
        /// </summary>
        public static Quantity InternationalCandle(decimal value) => new() { Value = value, UnitCode = QuantityCode.InternationalCandle };

        /// <summary>
        /// British thermal unit (international table) per square foot
        /// </summary>
        public static Quantity BritishThermalUnitInternationalTablePerSquareFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitInternationalTablePerSquareFoot };

        /// <summary>
        /// British thermal unit (thermochemical) per square foot
        /// </summary>
        public static Quantity BritishThermalUnitThermochemicalPerSquareFoot(decimal value) => new() { Value = value, UnitCode = QuantityCode.BritishThermalUnitThermochemicalPerSquareFoot };

        /// <summary>
        /// calorie (thermochemical) per square centimetre
        /// </summary>
        public static Quantity CalorieThermochemicalPerSquareCentimetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CalorieThermochemicalPerSquareCentimetre };

        /// <summary>
        /// langley
        /// </summary>
        public static Quantity Langley(decimal value) => new() { Value = value, UnitCode = QuantityCode.Langley };

        /// <summary>
        /// decade (logarithmic)
        /// </summary>
        public static Quantity DecadeLogarithmic(decimal value) => new() { Value = value, UnitCode = QuantityCode.DecadeLogarithmic };

        /// <summary>
        /// pascal squared second
        /// </summary>
        public static Quantity PascalSquaredSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.PascalSquaredSecond };

        /// <summary>
        /// bel per metre
        /// </summary>
        public static Quantity BelPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.BelPerMetre };

        /// <summary>
        /// pound mole
        /// </summary>
        public static Quantity PoundMole(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundMole };

        /// <summary>
        /// pound mole per second
        /// </summary>
        public static Quantity PoundMolePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundMolePerSecond };

        /// <summary>
        /// pound mole per minute
        /// </summary>
        public static Quantity PoundMolePerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundMolePerMinute };

        /// <summary>
        /// kilomole per kilogram
        /// </summary>
        public static Quantity KilomolePerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilomolePerKilogram };

        /// <summary>
        /// pound mole per pound
        /// </summary>
        public static Quantity PoundMolePerPound(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundMolePerPound };

        /// <summary>
        /// newton square metre per ampere
        /// </summary>
        public static Quantity NewtonSquareMetrePerAmpere(decimal value) => new() { Value = value, UnitCode = QuantityCode.NewtonSquareMetrePerAmpere };

        /// <summary>
        /// five pack
        /// </summary>
        public static Quantity FivePack(decimal value) => new() { Value = value, UnitCode = QuantityCode.FivePack };

        /// <summary>
        /// weber metre
        /// </summary>
        public static Quantity WeberMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.WeberMetre };

        /// <summary>
        /// mol per kilogram pascal
        /// </summary>
        public static Quantity MolPerKilogramPascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.MolPerKilogramPascal };

        /// <summary>
        /// mol per cubic metre pascal
        /// </summary>
        public static Quantity MolPerCubicMetrePascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.MolPerCubicMetrePascal };

        /// <summary>
        /// unit pole
        /// </summary>
        public static Quantity UnitPole(decimal value) => new() { Value = value, UnitCode = QuantityCode.UnitPole };

        /// <summary>
        /// milligray per second
        /// </summary>
        public static Quantity MilligrayPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligrayPerSecond };

        /// <summary>
        /// microgray per second
        /// </summary>
        public static Quantity MicrograyPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrograyPerSecond };

        /// <summary>
        /// nanogray per second
        /// </summary>
        public static Quantity NanograyPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.NanograyPerSecond };

        /// <summary>
        /// gray per minute
        /// </summary>
        public static Quantity GrayPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.GrayPerMinute };

        /// <summary>
        /// milligray per minute
        /// </summary>
        public static Quantity MilligrayPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligrayPerMinute };

        /// <summary>
        /// microgray per minute
        /// </summary>
        public static Quantity MicrograyPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrograyPerMinute };

        /// <summary>
        /// nanogray per minute
        /// </summary>
        public static Quantity NanograyPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.NanograyPerMinute };

        /// <summary>
        /// gray per hour
        /// </summary>
        public static Quantity GrayPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.GrayPerHour };

        /// <summary>
        /// milligray per hour
        /// </summary>
        public static Quantity MilligrayPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.MilligrayPerHour };

        /// <summary>
        /// microgray per hour
        /// </summary>
        public static Quantity MicrograyPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrograyPerHour };

        /// <summary>
        /// nanogray per hour
        /// </summary>
        public static Quantity NanograyPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.NanograyPerHour };

        /// <summary>
        /// sievert per second
        /// </summary>
        public static Quantity SievertPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.SievertPerSecond };

        /// <summary>
        /// millisievert per second
        /// </summary>
        public static Quantity MillisievertPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillisievertPerSecond };

        /// <summary>
        /// microsievert per second
        /// </summary>
        public static Quantity MicrosievertPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrosievertPerSecond };

        /// <summary>
        /// nanosievert per second
        /// </summary>
        public static Quantity NanosievertPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.NanosievertPerSecond };

        /// <summary>
        /// rem per second
        /// </summary>
        public static Quantity RemPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.RemPerSecond };

        /// <summary>
        /// sievert per hour
        /// </summary>
        public static Quantity SievertPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.SievertPerHour };

        /// <summary>
        /// millisievert per hour
        /// </summary>
        public static Quantity MillisievertPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillisievertPerHour };

        /// <summary>
        /// microsievert per hour
        /// </summary>
        public static Quantity MicrosievertPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrosievertPerHour };

        /// <summary>
        /// nanosievert per hour
        /// </summary>
        public static Quantity NanosievertPerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.NanosievertPerHour };

        /// <summary>
        /// sievert per minute
        /// </summary>
        public static Quantity SievertPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.SievertPerMinute };

        /// <summary>
        /// millisievert per minute
        /// </summary>
        public static Quantity MillisievertPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillisievertPerMinute };

        /// <summary>
        /// microsievert per minute
        /// </summary>
        public static Quantity MicrosievertPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrosievertPerMinute };

        /// <summary>
        /// nanosievert per minute
        /// </summary>
        public static Quantity NanosievertPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.NanosievertPerMinute };

        /// <summary>
        /// reciprocal square inch
        /// </summary>
        public static Quantity ReciprocalSquareInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalSquareInch };

        /// <summary>
        /// pascal square metre per kilogram
        /// </summary>
        public static Quantity PascalSquareMetrePerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.PascalSquareMetrePerKilogram };

        /// <summary>
        /// millipascal per metre
        /// </summary>
        public static Quantity MillipascalPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.MillipascalPerMetre };

        /// <summary>
        /// kilopascal per metre
        /// </summary>
        public static Quantity KilopascalPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilopascalPerMetre };

        /// <summary>
        /// hectopascal per metre
        /// </summary>
        public static Quantity HectopascalPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.HectopascalPerMetre };

        /// <summary>
        /// standard atmosphere per metre
        /// </summary>
        public static Quantity StandardAtmospherePerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.StandardAtmospherePerMetre };

        /// <summary>
        /// technical atmosphere per metre
        /// </summary>
        public static Quantity TechnicalAtmospherePerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.TechnicalAtmospherePerMetre };

        /// <summary>
        /// torr per metre
        /// </summary>
        public static Quantity TorrPerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.TorrPerMetre };

        /// <summary>
        /// psi per inch
        /// </summary>
        public static Quantity PsiPerInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.PsiPerInch };

        /// <summary>
        /// cubic metre per second square metre
        /// </summary>
        public static Quantity CubicMetrePerSecondSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicMetrePerSecondSquareMetre };

        /// <summary>
        /// rhe
        /// </summary>
        public static Quantity Rhe(decimal value) => new() { Value = value, UnitCode = QuantityCode.Rhe };

        /// <summary>
        /// pound-force foot per inch
        /// </summary>
        public static Quantity PoundForceFootPerInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundForceFootPerInch };

        /// <summary>
        /// pound-force inch per inch
        /// </summary>
        public static Quantity PoundForceInchPerInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundForceInchPerInch };

        /// <summary>
        /// perm (0 ºC)
        /// </summary>
        public static Quantity Perm0C(decimal value) => new() { Value = value, UnitCode = QuantityCode.Perm0C };

        /// <summary>
        /// perm (23 ºC)
        /// </summary>
        public static Quantity Perm23C(decimal value) => new() { Value = value, UnitCode = QuantityCode.Perm23C };

        /// <summary>
        /// byte per second
        /// </summary>
        public static Quantity BytePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.BytePerSecond };

        /// <summary>
        /// kilobyte per second
        /// </summary>
        public static Quantity KilobytePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilobytePerSecond };

        /// <summary>
        /// megabyte per second
        /// </summary>
        public static Quantity MegabytePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegabytePerSecond };

        /// <summary>
        /// reciprocal volt
        /// </summary>
        public static Quantity ReciprocalVolt(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalVolt };

        /// <summary>
        /// reciprocal radian
        /// </summary>
        public static Quantity ReciprocalRadian(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalRadian };

        /// <summary>
        /// pascal to the power sum of stoichiometric numbers
        /// </summary>
        public static Quantity PascalToThePowerSumOfStoichiometricNumbers(decimal value) => new() { Value = value, UnitCode = QuantityCode.PascalToThePowerSumOfStoichiometricNumbers };

        /// <summary>
        /// mole per cubiv metre to the power sum of stoichiometric numbers
        /// </summary>
        public static Quantity MolePerCubivMetreToThePowerSumOfStoichiometricNumbers(decimal value) => new() { Value = value, UnitCode = QuantityCode.MolePerCubivMetreToThePowerSumOfStoichiometricNumbers };

        /// <summary>
        /// pascal
        /// </summary>
        public static Quantity Pascal(decimal value) => new() { Value = value, UnitCode = QuantityCode.Pascal };

        /// <summary>
        /// pad
        /// </summary>
        public static Quantity Pad(decimal value) => new() { Value = value, UnitCode = QuantityCode.Pad };

        /// <summary>
        /// proof litre
        /// </summary>
        public static Quantity ProofLitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.ProofLitre };

        /// <summary>
        /// proof gallon
        /// </summary>
        public static Quantity ProofGallon(decimal value) => new() { Value = value, UnitCode = QuantityCode.ProofGallon };

        /// <summary>
        /// pitch
        /// </summary>
        public static Quantity Pitch(decimal value) => new() { Value = value, UnitCode = QuantityCode.Pitch };

        /// <summary>
        /// degree Plato
        /// </summary>
        public static Quantity DegreePlato(decimal value) => new() { Value = value, UnitCode = QuantityCode.DegreePlato };

        /// <summary>
        /// pound per inch of length
        /// </summary>
        public static Quantity PoundPerInchOfLength(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundPerInchOfLength };

        /// <summary>
        /// page per inch
        /// </summary>
        public static Quantity PagePerInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.PagePerInch };

        /// <summary>
        /// pair
        /// </summary>
        public static Quantity Pair(decimal value) => new() { Value = value, UnitCode = QuantityCode.Pair };

        /// <summary>
        /// pound-force per square inch
        /// </summary>
        public static Quantity PoundForcePerSquareInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundForcePerSquareInch };

        /// <summary>
        /// dry pint (US)
        /// </summary>
        public static Quantity DryPintUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.DryPintUS };

        /// <summary>
        /// pint (UK)
        /// </summary>
        public static Quantity PintUK(decimal value) => new() { Value = value, UnitCode = QuantityCode.PintUK };

        /// <summary>
        /// liquid pint (US)
        /// </summary>
        public static Quantity LiquidPintUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.LiquidPintUS };

        /// <summary>
        /// portion
        /// </summary>
        public static Quantity Portion(decimal value) => new() { Value = value, UnitCode = QuantityCode.Portion };

        /// <summary>
        /// joule per tesla
        /// </summary>
        public static Quantity JoulePerTesla(decimal value) => new() { Value = value, UnitCode = QuantityCode.JoulePerTesla };

        /// <summary>
        /// erlang
        /// </summary>
        public static Quantity Erlang(decimal value) => new() { Value = value, UnitCode = QuantityCode.Erlang };

        /// <summary>
        /// octet
        /// </summary>
        public static Quantity Octet(decimal value) => new() { Value = value, UnitCode = QuantityCode.Octet };

        /// <summary>
        /// octet per second
        /// </summary>
        public static Quantity OctetPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.OctetPerSecond };

        /// <summary>
        /// shannon
        /// </summary>
        public static Quantity Shannon(decimal value) => new() { Value = value, UnitCode = QuantityCode.Shannon };

        /// <summary>
        /// hartley
        /// </summary>
        public static Quantity Hartley(decimal value) => new() { Value = value, UnitCode = QuantityCode.Hartley };

        /// <summary>
        /// natural unit of information
        /// </summary>
        public static Quantity NaturalUnitOfInformation(decimal value) => new() { Value = value, UnitCode = QuantityCode.NaturalUnitOfInformation };

        /// <summary>
        /// shannon per second
        /// </summary>
        public static Quantity ShannonPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.ShannonPerSecond };

        /// <summary>
        /// hartley per second
        /// </summary>
        public static Quantity HartleyPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.HartleyPerSecond };

        /// <summary>
        /// natural unit of information per second
        /// </summary>
        public static Quantity NaturalUnitOfInformationPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.NaturalUnitOfInformationPerSecond };

        /// <summary>
        /// second per kilogramm
        /// </summary>
        public static Quantity SecondPerKilogramm(decimal value) => new() { Value = value, UnitCode = QuantityCode.SecondPerKilogramm };

        /// <summary>
        /// watt square metre
        /// </summary>
        public static Quantity WattSquareMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.WattSquareMetre };

        /// <summary>
        /// second per radian cubic metre
        /// </summary>
        public static Quantity SecondPerRadianCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.SecondPerRadianCubicMetre };

        /// <summary>
        /// weber to the power minus one
        /// </summary>
        public static Quantity WeberToThePowerMinusOne(decimal value) => new() { Value = value, UnitCode = QuantityCode.WeberToThePowerMinusOne };

        /// <summary>
        /// reciprocal inch
        /// </summary>
        public static Quantity ReciprocalInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.ReciprocalInch };

        /// <summary>
        /// dioptre
        /// </summary>
        public static Quantity Dioptre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Dioptre };

        /// <summary>
        /// one per one
        /// </summary>
        public static Quantity OnePerOne(decimal value) => new() { Value = value, UnitCode = QuantityCode.OnePerOne };

        /// <summary>
        /// newton metre per metre
        /// </summary>
        public static Quantity NewtonMetrePerMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.NewtonMetrePerMetre };

        /// <summary>
        /// kilogram per square metre pascal second
        /// </summary>
        public static Quantity KilogramPerSquareMetrePascalSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramPerSquareMetrePascalSecond };

        /// <summary>
        /// microgram per hectogram
        /// </summary>
        public static Quantity MicrogramPerHectogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.MicrogramPerHectogram };

        /// <summary>
        /// meal
        /// </summary>
        public static Quantity Meal(decimal value) => new() { Value = value, UnitCode = QuantityCode.Meal };

        /// <summary>
        /// pH (potential of Hydrogen)
        /// </summary>
        public static Quantity PHPotentialOfHydrogen(decimal value) => new() { Value = value, UnitCode = QuantityCode.PHPotentialOfHydrogen };

        /// <summary>
        /// kilojoule per gram
        /// </summary>
        public static Quantity KilojoulePerGram(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilojoulePerGram };

        /// <summary>
        /// femtolitre
        /// </summary>
        public static Quantity Femtolitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Femtolitre };

        /// <summary>
        /// picolitre
        /// </summary>
        public static Quantity Picolitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Picolitre };

        /// <summary>
        /// nanolitre
        /// </summary>
        public static Quantity Nanolitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.Nanolitre };

        /// <summary>
        /// megawatts per minute
        /// </summary>
        public static Quantity MegawattsPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.MegawattsPerMinute };

        /// <summary>
        /// square metre per cubic metre
        /// </summary>
        public static Quantity SquareMetrePerCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMetrePerCubicMetre };

        /// <summary>
        /// Standard cubic metre per day
        /// </summary>
        public static Quantity StandardCubicMetrePerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.StandardCubicMetrePerDay };

        /// <summary>
        /// Standard cubic metre per hour
        /// </summary>
        public static Quantity StandardCubicMetrePerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.StandardCubicMetrePerHour };

        /// <summary>
        /// Normalized cubic metre per day
        /// </summary>
        public static Quantity NormalizedCubicMetrePerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.NormalizedCubicMetrePerDay };

        /// <summary>
        /// Normalized cubic metre per hour
        /// </summary>
        public static Quantity NormalizedCubicMetrePerHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.NormalizedCubicMetrePerHour };

        /// <summary>
        /// Joule per normalised cubic metre
        /// </summary>
        public static Quantity JoulePerNormalisedCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.JoulePerNormalisedCubicMetre };

        /// <summary>
        /// Joule per standard cubic metre
        /// </summary>
        public static Quantity JoulePerStandardCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.JoulePerStandardCubicMetre };

        /// <summary>
        /// page - facsimile
        /// </summary>
        public static Quantity PageFacsimile(decimal value) => new() { Value = value, UnitCode = QuantityCode.PageFacsimile };

        /// <summary>
        /// quarter (of a year)
        /// </summary>
        public static Quantity QuarterOfAYear(decimal value) => new() { Value = value, UnitCode = QuantityCode.QuarterOfAYear };

        /// <summary>
        /// page - hardcopy
        /// </summary>
        public static Quantity PageHardcopy(decimal value) => new() { Value = value, UnitCode = QuantityCode.PageHardcopy };

        /// <summary>
        /// quire
        /// </summary>
        public static Quantity Quire(decimal value) => new() { Value = value, UnitCode = QuantityCode.Quire };

        /// <summary>
        /// dry quart (US)
        /// </summary>
        public static Quantity DryQuartUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.DryQuartUS };

        /// <summary>
        /// quart (UK)
        /// </summary>
        public static Quantity QuartUK(decimal value) => new() { Value = value, UnitCode = QuantityCode.QuartUK };

        /// <summary>
        /// liquid quart (US)
        /// </summary>
        public static Quantity LiquidQuartUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.LiquidQuartUS };

        /// <summary>
        /// quarter (UK)
        /// </summary>
        public static Quantity QuarterUK(decimal value) => new() { Value = value, UnitCode = QuantityCode.QuarterUK };

        /// <summary>
        /// pica
        /// </summary>
        public static Quantity Pica(decimal value) => new() { Value = value, UnitCode = QuantityCode.Pica };

        /// <summary>
        /// thousand cubic metre
        /// </summary>
        public static Quantity ThousandCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.ThousandCubicMetre };

        /// <summary>
        /// running or operating hour
        /// </summary>
        public static Quantity RunningOrOperatingHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.RunningOrOperatingHour };

        /// <summary>
        /// ream
        /// </summary>
        public static Quantity Ream(decimal value) => new() { Value = value, UnitCode = QuantityCode.Ream };

        /// <summary>
        /// room
        /// </summary>
        public static Quantity Room(decimal value) => new() { Value = value, UnitCode = QuantityCode.Room };

        /// <summary>
        /// pound per ream
        /// </summary>
        public static Quantity PoundPerReam(decimal value) => new() { Value = value, UnitCode = QuantityCode.PoundPerReam };

        /// <summary>
        /// revolutions per minute
        /// </summary>
        public static Quantity RevolutionsPerMinute(decimal value) => new() { Value = value, UnitCode = QuantityCode.RevolutionsPerMinute };

        /// <summary>
        /// revolutions per second
        /// </summary>
        public static Quantity RevolutionsPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.RevolutionsPerSecond };

        /// <summary>
        /// revenue ton mile
        /// </summary>
        public static Quantity RevenueTonMile(decimal value) => new() { Value = value, UnitCode = QuantityCode.RevenueTonMile };

        /// <summary>
        /// square foot per second
        /// </summary>
        public static Quantity SquareFootPerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareFootPerSecond };

        /// <summary>
        /// square metre per second
        /// </summary>
        public static Quantity SquareMetrePerSecond(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareMetrePerSecond };

        /// <summary>
        /// half year (6 months)
        /// </summary>
        public static Quantity HalfYear6Months(decimal value) => new() { Value = value, UnitCode = QuantityCode.HalfYear6Months };

        /// <summary>
        /// score
        /// </summary>
        public static Quantity Score(decimal value) => new() { Value = value, UnitCode = QuantityCode.Score };

        /// <summary>
        /// scruple
        /// </summary>
        public static Quantity Scruple(decimal value) => new() { Value = value, UnitCode = QuantityCode.Scruple };

        /// <summary>
        /// second [unit of time]
        /// </summary>
        public static Quantity SecondUnitOfTime(decimal value) => new() { Value = value, UnitCode = QuantityCode.SecondUnitOfTime };

        /// <summary>
        /// set
        /// </summary>
        public static Quantity Set(decimal value) => new() { Value = value, UnitCode = QuantityCode.Set };

        /// <summary>
        /// segment
        /// </summary>
        public static Quantity Segment(decimal value) => new() { Value = value, UnitCode = QuantityCode.Segment };

        /// <summary>
        /// siemens
        /// </summary>
        public static Quantity Siemens(decimal value) => new() { Value = value, UnitCode = QuantityCode.Siemens };

        /// <summary>
        /// Standard cubic metre
        /// </summary>
        public static Quantity StandardCubicMetre(decimal value) => new() { Value = value, UnitCode = QuantityCode.StandardCubicMetre };

        /// <summary>
        /// mile (statute mile)
        /// </summary>
        public static Quantity MileStatuteMile(decimal value) => new() { Value = value, UnitCode = QuantityCode.MileStatuteMile };

        /// <summary>
        /// square
        /// </summary>
        public static Quantity Square(decimal value) => new() { Value = value, UnitCode = QuantityCode.Square };

        /// <summary>
        /// square, roofing
        /// </summary>
        public static Quantity SquareRoofing(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareRoofing };

        /// <summary>
        /// strip
        /// </summary>
        public static Quantity Strip(decimal value) => new() { Value = value, UnitCode = QuantityCode.Strip };

        /// <summary>
        /// stick
        /// </summary>
        public static Quantity Stick(decimal value) => new() { Value = value, UnitCode = QuantityCode.Stick };

        /// <summary>
        /// stone (UK)
        /// </summary>
        public static Quantity StoneUK(decimal value) => new() { Value = value, UnitCode = QuantityCode.StoneUK };

        /// <summary>
        /// stick, cigarette
        /// </summary>
        public static Quantity StickCigarette(decimal value) => new() { Value = value, UnitCode = QuantityCode.StickCigarette };

        /// <summary>
        /// standard litre
        /// </summary>
        public static Quantity StandardLitre(decimal value) => new() { Value = value, UnitCode = QuantityCode.StandardLitre };

        /// <summary>
        /// ton (US) or short ton (UK/US)
        /// </summary>
        public static Quantity TonUSOrShortTonUKUS(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonUSOrShortTonUKUS };

        /// <summary>
        /// straw
        /// </summary>
        public static Quantity Straw(decimal value) => new() { Value = value, UnitCode = QuantityCode.Straw };

        /// <summary>
        /// skein
        /// </summary>
        public static Quantity Skein(decimal value) => new() { Value = value, UnitCode = QuantityCode.Skein };

        /// <summary>
        /// shipment
        /// </summary>
        public static Quantity Shipment(decimal value) => new() { Value = value, UnitCode = QuantityCode.Shipment };

        /// <summary>
        /// syringe
        /// </summary>
        public static Quantity Syringe(decimal value) => new() { Value = value, UnitCode = QuantityCode.Syringe };

        /// <summary>
        /// telecommunication line in service
        /// </summary>
        public static Quantity TelecommunicationLineInService(decimal value) => new() { Value = value, UnitCode = QuantityCode.TelecommunicationLineInService };

        /// <summary>
        /// thousand piece
        /// </summary>
        public static Quantity ThousandPiece(decimal value) => new() { Value = value, UnitCode = QuantityCode.ThousandPiece };

        /// <summary>
        /// kiloampere hour (thousand ampere hour)
        /// </summary>
        public static Quantity KiloampereHourThousandAmpereHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.KiloampereHourThousandAmpereHour };

        /// <summary>
        /// total acid number
        /// </summary>
        public static Quantity TotalAcidNumber(decimal value) => new() { Value = value, UnitCode = QuantityCode.TotalAcidNumber };

        /// <summary>
        /// thousand square inch
        /// </summary>
        public static Quantity ThousandSquareInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.ThousandSquareInch };

        /// <summary>
        /// metric ton, including container
        /// </summary>
        public static Quantity MetricTonIncludingContainer(decimal value) => new() { Value = value, UnitCode = QuantityCode.MetricTonIncludingContainer };

        /// <summary>
        /// metric ton, including inner packaging
        /// </summary>
        public static Quantity MetricTonIncludingInnerPackaging(decimal value) => new() { Value = value, UnitCode = QuantityCode.MetricTonIncludingInnerPackaging };

        /// <summary>
        /// tonne kilometre
        /// </summary>
        public static Quantity TonneKilometre(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonneKilometre };

        /// <summary>
        /// kilogram of imported meat, less offal
        /// </summary>
        public static Quantity KilogramOfImportedMeatLessOffal(decimal value) => new() { Value = value, UnitCode = QuantityCode.KilogramOfImportedMeatLessOffal };

        /// <summary>
        /// tonne (metric ton)
        /// </summary>
        public static Quantity TonneMetricTon(decimal value) => new() { Value = value, UnitCode = QuantityCode.TonneMetricTon };

        /// <summary>
        /// ten pack
        /// </summary>
        public static Quantity TenPack(decimal value) => new() { Value = value, UnitCode = QuantityCode.TenPack };

        /// <summary>
        /// teeth per inch
        /// </summary>
        public static Quantity TeethPerInch(decimal value) => new() { Value = value, UnitCode = QuantityCode.TeethPerInch };

        /// <summary>
        /// ten pair
        /// </summary>
        public static Quantity TenPair(decimal value) => new() { Value = value, UnitCode = QuantityCode.TenPair };

        /// <summary>
        /// thousand cubic metre per day
        /// </summary>
        public static Quantity ThousandCubicMetrePerDay(decimal value) => new() { Value = value, UnitCode = QuantityCode.ThousandCubicMetrePerDay };

        /// <summary>
        /// trillion (EUR)
        /// </summary>
        public static Quantity TrillionEUR(decimal value) => new() { Value = value, UnitCode = QuantityCode.TrillionEUR };

        /// <summary>
        /// ten set
        /// </summary>
        public static Quantity TenSet(decimal value) => new() { Value = value, UnitCode = QuantityCode.TenSet };

        /// <summary>
        /// ten thousand sticks
        /// </summary>
        public static Quantity TenThousandSticks(decimal value) => new() { Value = value, UnitCode = QuantityCode.TenThousandSticks };

        /// <summary>
        /// treatment
        /// </summary>
        public static Quantity Treatment(decimal value) => new() { Value = value, UnitCode = QuantityCode.Treatment };

        /// <summary>
        /// tablet
        /// </summary>
        public static Quantity Tablet(decimal value) => new() { Value = value, UnitCode = QuantityCode.Tablet };

        /// <summary>
        /// telecommunication line in service average
        /// </summary>
        public static Quantity TelecommunicationLineInServiceAverage(decimal value) => new() { Value = value, UnitCode = QuantityCode.TelecommunicationLineInServiceAverage };

        /// <summary>
        /// telecommunication port
        /// </summary>
        public static Quantity TelecommunicationPort(decimal value) => new() { Value = value, UnitCode = QuantityCode.TelecommunicationPort };

        /// <summary>
        /// volt - ampere per kilogram
        /// </summary>
        public static Quantity VoltAmperePerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.VoltAmperePerKilogram };

        /// <summary>
        /// volt
        /// </summary>
        public static Quantity Volt(decimal value) => new() { Value = value, UnitCode = QuantityCode.Volt };

        /// <summary>
        /// percent volume
        /// </summary>
        public static Quantity PercentVolume(decimal value) => new() { Value = value, UnitCode = QuantityCode.PercentVolume };

        /// <summary>
        /// wet kilo
        /// </summary>
        public static Quantity WetKilo(decimal value) => new() { Value = value, UnitCode = QuantityCode.WetKilo };

        /// <summary>
        /// watt per kilogram
        /// </summary>
        public static Quantity WattPerKilogram(decimal value) => new() { Value = value, UnitCode = QuantityCode.WattPerKilogram };

        /// <summary>
        /// wet pound
        /// </summary>
        public static Quantity WetPound(decimal value) => new() { Value = value, UnitCode = QuantityCode.WetPound };

        /// <summary>
        /// cord
        /// </summary>
        public static Quantity Cord(decimal value) => new() { Value = value, UnitCode = QuantityCode.Cord };

        /// <summary>
        /// wet ton
        /// </summary>
        public static Quantity WetTon(decimal value) => new() { Value = value, UnitCode = QuantityCode.WetTon };

        /// <summary>
        /// weber
        /// </summary>
        public static Quantity Weber(decimal value) => new() { Value = value, UnitCode = QuantityCode.Weber };

        /// <summary>
        /// week
        /// </summary>
        public static Quantity Week(decimal value) => new() { Value = value, UnitCode = QuantityCode.Week };

        /// <summary>
        /// wine gallon
        /// </summary>
        public static Quantity WineGallon(decimal value) => new() { Value = value, UnitCode = QuantityCode.WineGallon };

        /// <summary>
        /// watt hour
        /// </summary>
        public static Quantity WattHour(decimal value) => new() { Value = value, UnitCode = QuantityCode.WattHour };

        /// <summary>
        /// working month
        /// </summary>
        public static Quantity WorkingMonth(decimal value) => new() { Value = value, UnitCode = QuantityCode.WorkingMonth };

        /// <summary>
        /// standard
        /// </summary>
        public static Quantity Standard(decimal value) => new() { Value = value, UnitCode = QuantityCode.Standard };

        /// <summary>
        /// watt
        /// </summary>
        public static Quantity Watt(decimal value) => new() { Value = value, UnitCode = QuantityCode.Watt };

        /// <summary>
        /// Gunter's chain
        /// </summary>
        public static Quantity GunterSChain(decimal value) => new() { Value = value, UnitCode = QuantityCode.GunterSChain };

        /// <summary>
        /// square yard
        /// </summary>
        public static Quantity SquareYard(decimal value) => new() { Value = value, UnitCode = QuantityCode.SquareYard };

        /// <summary>
        /// cubic yard
        /// </summary>
        public static Quantity CubicYard(decimal value) => new() { Value = value, UnitCode = QuantityCode.CubicYard };

        /// <summary>
        /// yard
        /// </summary>
        public static Quantity Yard(decimal value) => new() { Value = value, UnitCode = QuantityCode.Yard };

        /// <summary>
        /// hanging container
        /// </summary>
        public static Quantity HangingContainer(decimal value) => new() { Value = value, UnitCode = QuantityCode.HangingContainer };

        /// <summary>
        /// nanomole
        /// </summary>
        public static Quantity Nanomole(decimal value) => new() { Value = value, UnitCode = QuantityCode.Nanomole };

        /// <summary>
        /// page
        /// </summary>
        public static Quantity Page(decimal value) => new() { Value = value, UnitCode = QuantityCode.Page };

        /// <summary>
        /// mutually defined
        /// </summary>
        public static Quantity MutuallyDefined(decimal value) => new() { Value = value, UnitCode = QuantityCode.MutuallyDefined };
    }
}
