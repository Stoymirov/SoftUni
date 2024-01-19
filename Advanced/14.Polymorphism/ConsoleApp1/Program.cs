using Shapes;

public class StartUp
{
    static void Main(string[] args)
    {
        Shape shape = new Rectangle(10, 20);
        Shape circle = new Circle(30);

        Console.WriteLine(shape.CalculateArea());
        Console.WriteLine(shape.CalculatePerimeter());
        Console.WriteLine(circle.CalculatePerimeter());
        Console.WriteLine(circle.CalculateArea());
        Console.WriteLine(shape.Draw());
        Console.WriteLine(circle.Draw());
    }
}