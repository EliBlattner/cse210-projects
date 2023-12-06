using System.Formats.Asn1;

public class SquareShape : PaperShapes
{
    private double sideLength = 20;

    public override double CalculateArea()
    {
        return sideLength * sideLength;
    }

}