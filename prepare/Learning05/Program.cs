using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("welcome to the shape area calculator\n\n");
        Thread.Sleep(1000);
        Console.WriteLine("What kind of shape would you like to find the area of? (Square, Rectangle or Circle): ");
        string shapeType = Console.ReadLine();

        if (shapeType == "Square")
        {
            SquareShape squareShape1 = new SquareShape();
            squareShape1.EndMessage();

        }
        else if (shapeType == "Rectangle")
        {
            RectangleShape rectangleShape1 = new RectangleShape();
            rectangleShape1.EndMessage();
        }
        else if (shapeType == "Circle")
        {
            CircleShape circleShape1 = new CircleShape();
            circleShape1.EndMessage();
        }
    }
}