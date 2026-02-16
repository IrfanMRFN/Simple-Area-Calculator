namespace SimpleAreaCalculator;

public class Triangle : IShape
{
    public double Base { get; init; }
    public double Height { get; init; }
    public double Area => 0.5 * Base * Height;

    public Triangle(double triangleBase, double height)
    {
        Base = triangleBase;
        Height = height;
    }

    public void DisplayShapeInfo()
    {
        Console.WriteLine($"Triangle - (Base = {Base}, Height = {Height}), Area = {Area:F2}");
    }
}
