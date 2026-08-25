namespace CSharpPractise.DotnetLogicLab.Day06;

public class Animal
{
    public void Name()
    {
        Console.WriteLine($"Name of animeal");
    }

    public void Eat()
    {
        Console.WriteLine($"Eating animal");
    }
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog Bark");
    }
}