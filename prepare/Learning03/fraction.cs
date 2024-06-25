using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Fraction
{
    private double _numerator;
    private double _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int top)
    {
        _numerator = top;
        _denominator = 1;
    }

    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    public double getTop ()
    {
        return _numerator;
    }

    public void setTop (int top)
    {
        _numerator = top;
    }

    public double getBottom ()
    {
        return _denominator;
    }

    public void setBottom (int bottom)
    {
        _denominator = bottom;
    }

    public string getFractionString ()
    {
        string strFract = _numerator + "/" + _denominator;
        return strFract;
    }

    public double getDecimalValue ()
    {
        double decVal = _numerator / _denominator;
        return decVal;
    }
}