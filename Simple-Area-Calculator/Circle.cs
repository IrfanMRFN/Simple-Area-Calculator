namespace SimpleAreaCalculator;

public class Circle : IShape
{
    public double Radius { get; set; }
    public double Area => Math.PI * Math.Pow(Radius, 2);

    public Circle(double radius)
    {
        Radius = radius;
    }

    public void DisplayShapeInfo()
    {
        Console.WriteLine($"Circle - (Radius = {Radius}), Area = {Area}");
    }
}
