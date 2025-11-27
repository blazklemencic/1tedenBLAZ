namespace _8teden_pravajalnik_valut
{
	public enum LengthUnit
	{
		METER,
		KILOMETER,
		CENTIMETER,
		INCH,
        FEET
	}

    class Length
    {
        private double valueM;

        public Length(double value, LengthUnit unit)
        {
            valueM = ToMeters(value, unit);
        }

        public static double ToMeters(double value, LengthUnit unit)
        {
            return unit switch
            {
                LengthUnit.METER => value,
                LengthUnit.KILOMETER => value * Math.Pow(10, 3),
                LengthUnit.CENTIMETER => value * Math.Pow(10, -2),
                LengthUnit.INCH => value * 0.0254,
                LengthUnit.FEET => value * 0.3048,
                _ => throw new ArgumentOutOfRangeException(nameof(unit))
            };
        }

        public static double FromMeters(double value, LengthUnit unit)
        {
            return unit switch
            {
                LengthUnit.METER => value,
                LengthUnit.KILOMETER => value * Math.Pow(10, -3),
                LengthUnit.CENTIMETER => value * Math.Pow(10, 2),
                LengthUnit.INCH => value / 0.0254,
                LengthUnit.FEET => value / 0.3048,
                _ => throw new ArgumentOutOfRangeException(nameof(unit))
            };
        }
    }
}