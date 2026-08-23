namespace CSharpPractise.DotnetLogicLab.Day05;

public class Rectangle
{
    private float height;
    private float width;

    public float Height
    {
        get{return height;}
        set{height=value;}
    }

    public float Width
    {
        get{return width;}
        set{width=value;}
    }

    public Rectangle(float height, float width)
    {
        this.height = height;
        this.width = width;
    }

    public float CalculateArea()
    {
        return this.Height * this.Width;
    }

    public float CalculatePerimeter()
    {
        return 2* (this.Height + this.Width);
    }

    public void Display()
    {
        Console.WriteLine("Rectangle");
        Console.WriteLine($"Area: {CalculateArea()}");
        Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
    }
}