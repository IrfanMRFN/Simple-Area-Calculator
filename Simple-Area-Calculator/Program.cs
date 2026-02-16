namespace SimpleAreaCalculator;

public class Program
{
    public static void Main()
    {
        var shapes = new List<IShape>{
            new Circle(5),
            new Rectangle(4, 6),
            new Triangle(3, 8)
        };

        Console.WriteLine("Displaying shapes...");
        DisplayShapes(shapes);
    }

    private static void DisplayShapes(List<IShape> shapes)
    {
        foreach (IShape shape in shapes)
        {
            shape.DisplayShapeInfo();     

            if (shape.Area > 50)
            {
                Console.WriteLine("  -> [Warning] Large Shape Detected!");
            }       
        }
    }
}
