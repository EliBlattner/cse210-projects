using System;

public class Fraction
{
    private int _denominator;
    private int _numerator;

    
    public Fraction()
    {
        _denominator = 1;
        _numerator = 1;
    }

    public Fraction(int userNumerator)
    {
        _numerator = userNumerator;
        _denominator = 1;
    }

    public Fraction(int userNumerator, int userDenominator)
    {

    _numerator = userNumerator;
    _denominator = userDenominator;
    }

    public int GetTop()
    {
        return _numerator;
    }

    public int GetBottom()
    {
        return _denominator;
    }

    public string GetFractionString()
    {
        string fractionString = $"{_numerator}/{_denominator}";
        return fractionString;
    }

    public double GetDecimalValue()
    {
        double decimalValue = (double)_numerator / (double)_denominator;
        return decimalValue;
    }
}
