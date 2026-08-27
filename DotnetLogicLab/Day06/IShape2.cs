namespace CSharpPractise.DotnetLogicLab.Day06;

public interface IShape2
{
    double CalculateArea();
    double CalculatePerimeter();
}

public class Rectangle2 : IShape2
{
    public double Width, Height;

    public Rectangle2(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea() => Width * Height;
    public double CalculatePerimeter() => 2 * (Width + Height);
}

public class Circle2 : IShape2
{
    public double Radius;

    public Circle2(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea() => Math.PI * Radius * Radius;
    public double CalculatePerimeter() => 2 * Math.PI * Radius;
}

public class Triangle : IShape2
{
    public double Base, Height, SideA, SideB;

    public Triangle(double baseLength, double height, double sideA, double sideB)
    {
        Base = baseLength;
        Height = height;
        SideA = sideA;
        SideB = sideB;
    }

    public double CalculateArea() => 0.5 * Base * Height;
    public double CalculatePerimeter() => Base + SideA + SideB;
}