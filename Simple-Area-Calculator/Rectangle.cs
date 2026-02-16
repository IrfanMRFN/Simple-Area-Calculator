namespace SimpleAreaCalculator;

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double Area => Width * Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public void DisplayShapeInfo()
    {
        Console.WriteLine($"Rectangle - (Width = {Width}, Height = {Height}), Area = {Area}");
    }
}
