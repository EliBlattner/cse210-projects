using System.Diagnostics;
using System.Drawing;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

public abstract class PaperShapes
{
    private string _paperColor;


    public PaperShapes()
    {
        Console.WriteLine("What is the color of the shape?");
        string color = Console.ReadLine();
        _paperColor = color;
    }

    public string GetColor()
    {
        return _paperColor;        
    }

    public void EndMessage()
    {
        Console.WriteLine($"Your shape is {_paperColor} and has an area of {CalculateArea()}.");
    }
    
    public abstract double CalculateArea();
}

