namespace SimpleAreaCalculator;

public class Circle : IShape
{
    public double Radius { get; init; }
    public double Area => Math.PI * (Radius * Radius);

    public Circle(double radius)
    {
        Radius = radius;
    }

    public void DisplayShapeInfo()
    {
        Console.WriteLine($"Circle - (Radius = {Radius}), Area = {Area:F2}");
    }
}
