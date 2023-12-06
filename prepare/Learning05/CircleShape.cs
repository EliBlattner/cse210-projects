using System.Formats.Asn1;

public class CircleShape : PaperShapes
{
    private double _radius = 3;

    public override double CalculateArea()
    {
        return _radius * _radius * Math.PI;
    }
}