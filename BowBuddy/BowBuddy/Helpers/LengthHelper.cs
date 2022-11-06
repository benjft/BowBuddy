using System;
using BowBuddy.Enums;

namespace BowBuddy.Helpers {
    public static class LengthHelper {
        private const double OneMeter = 1.0;
        private const double OneYard = 0.9144;
        private const double OneFoot = 0.3048;
        private const double OneInch = 0.0254;
        private const double OneCm = 0.01;
        private const double OneMm = 0.001;

        public static double AsMeters(this LengthUnits units) => units switch {
            LengthUnits.Millimeters => OneMm,
            LengthUnits.Centimeters => OneCm,
            LengthUnits.Inches => OneInch,
            LengthUnits.Feet => OneFoot,
            LengthUnits.Yards => OneYard,
            LengthUnits.Meters => OneMeter,
            _ => throw new NotImplementedException($"Distance units for {units.ToString()} not implemented")
        };

        public static double Convert(this LengthUnits toUnits, double length, LengthUnits fromUnits) =>
            length * fromUnits.AsMeters() / toUnits.AsMeters();
    }
}