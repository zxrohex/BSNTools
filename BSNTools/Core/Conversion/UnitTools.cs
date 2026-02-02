using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using UnitsNet.Units;

namespace BSNTools.Core.Conversion
{
    public class UnitTools
    {
        public static Dictionary<string, double> GenerateInformationUnitTable(double valueInBits)
        {
            var unitTable = new Dictionary<string, double>();
            foreach (var unit in Enum.GetValues<UnitsNet.Units.InformationUnit>())
            {
                var abbreviation = UnitsNet.Information.GetAbbreviation(unit);
                var convertedValue = UnitsNet.Information.FromBits(valueInBits).As(unit);
                unitTable.Add(abbreviation, convertedValue);
            }
            return unitTable;
        }

        public static Dictionary<string, double> GenerateBitRateUnitTable(double valueInBitsPerSecond)
        {
            var unitTable = new Dictionary<string, double>();
            foreach (var unit in Enum.GetValues<UnitsNet.Units.BitRateUnit>())
            {
                var abbreviation = UnitsNet.BitRate.GetAbbreviation(unit);
                var convertedValue = UnitsNet.BitRate.FromBitsPerSecond(valueInBitsPerSecond).As(unit);
                unitTable.Add(abbreviation, convertedValue);
            }
            return unitTable;
        }


        /*public static Dictionary<string, double> GenerateUnitTable<TUnit>(double value, Func<double, TUnit, double> conversionFunc) where TUnit : Enum
        {
            var unitTable = new Dictionary<string, double>();
            foreach (var unit in Enum.GetValues<TUnit>())
            {
                var abbreviation = typeof(TUnit) == typeof(UnitsNet.Units.InformationUnit)
                    ? UnitsNet.Information.GetAbbreviation((UnitsNet.Units.InformationUnit)(object)unit)
                    : UnitsNet.BitRate.GetAbbreviation((UnitsNet.Units.BitRateUnit)(object)unit);
                var convertedValue = conversionFunc(value, unit);
                unitTable.Add(abbreviation, convertedValue);
            }
            return unitTable;
        }*/

        public static Dictionary<string, InformationUnit> GetInformationUnits()
        {
            var units = new Dictionary<string, InformationUnit>();
            foreach (var unit in Enum.GetValues<InformationUnit>())
            {
                var abbreviation = UnitsNet.Information.GetAbbreviation(unit);
                units.Add(abbreviation, unit);
            }
            return units;
        }
    }
}
