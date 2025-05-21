using System;
namespace Fractions;
// This is the main entry point for the Fractions project.
public class Fractions
{
    private int _top;
    private int _bottom;
    // Constructor
    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fractions(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // fraction representation
    public string Fraction()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to get the top value
    public int GetTop()
    {
        return _top;
    }
    // method to set the top value
    public void SetTop(int top)
    {
        if (top > 0)
        {
            _top = top;
        }
        else
        {
            Console.WriteLine("Top value must be greater than 0.");
        }
    }

    // Method to get the bottom value
    public int GetBottom()
    {
        return _bottom;
    }
    // method to set the bottom value
    public void SetBottom(int bottom)
    {
        if (bottom > 0)
        {
            _bottom = bottom;
        }
        else
        {
            Console.WriteLine("Bottom value must be greater than 0.");
        }
    }

    // get fraction string methode
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // get decimal value
    public double GetDecimalValue()
    {
        if (_bottom != 0)
        {
            return (double)_top / _bottom;
        }
        else
        {
            Console.WriteLine("Bottom value cannot be zero.");
            return 0;
        }
    }

    

}