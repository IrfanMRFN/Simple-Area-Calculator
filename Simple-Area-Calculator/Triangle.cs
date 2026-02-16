namespace SimpleAreaCalculator;

public class Triangle : IShape
{
    public double Base { get; set; }
    public double Height { get; set; }
    public double Area => 0.5 * Base * Height;

    public Triangle(double triangleBase, double height)
    {
        Base = triangleBase;
        Height = height;
    }

    public void DisplayShapeInfo()
    {
        Console.WriteLine($"Triangle - (Base = {Base}, Height = {Height}), Area = {Area}");
    }
}
