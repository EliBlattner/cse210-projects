public class RectangleShape : PaperShapes
{
    private double width = 10;
    private double length = 20;

    public override double CalculateArea()
    {
        return length * width;
    }
}