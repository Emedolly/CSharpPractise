namespace CSharpPractise.DotnetLogicLab.Day05;

public class Car
{
    private string model { get; set; }
    private string color { get; set; }
    private int year { get; set; }

    public Car(string model, string color, int year)
    {
        this.model = model;
        this.color = color;
        this.year = year;
    }

    public void Run()
    {
        Console.WriteLine($"Car {this.model} {this.color} {this.year}");
    }
}