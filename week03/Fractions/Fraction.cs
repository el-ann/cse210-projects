using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructor to initialize the fraction
    public Fraction()    
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int _top)
    {
        this._top = _top;
        this._bottom = 1;
    }

    public Fraction(int _top, int _bottom)
    {
        this._top = _top;
        this._bottom = _bottom;
    }

    // Method to display the fraction
    public void Display()
    {
        Console.WriteLine($"{_top}/{_bottom}");
    }

    // Method to get the value of the fraction
    public double GetValue()
    {
        return (double)_top / _bottom;
    }

    // Method to get the fraction string representation
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

     // Method to get the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }

    // Properties to get and set numerator and denominator
    public int Top
    {
        get { return _top; }
        set { _top = value; }
    }

    public int Bottom
    {
        get { return _bottom; }
        set { _bottom = value; }
    }
}
