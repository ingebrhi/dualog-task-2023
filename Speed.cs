using System.Globalization;

class Speed : IFormattable {
    
    private double max_speed;

    public Speed(double speed) {
        if (speed < 0)
            throw new ArgumentOutOfRangeException(String.Format("{0} is less than zero.",
                                              speed));
        this.max_speed = speed;
   }

    public double Knots {
        get { return max_speed; }
    }

    public double M_sec {
        get { return max_speed * 0.514444; }
    }

    public override string ToString() {
        return this.ToString("KN", CultureInfo.CurrentCulture);
    }

    public string ToString(string format) {
        return this.ToString(format, CultureInfo.CurrentCulture);
    }

    public string ToString(string? format, IFormatProvider? provider) {
        if (String.IsNullOrEmpty(format)) format = "G";
        if (provider == null) provider = CultureInfo.CurrentCulture;

        switch (format.ToUpperInvariant()) {
            case "G":
            case "KN":
                return max_speed.ToString("F2", provider) + " KN";
            case "MS":
                return M_sec.ToString("F2", provider) + " MS";
            default:
                throw new FormatException(String.Format("The {0} format string is not supported.", format));
        }
    }
}
