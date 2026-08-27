namespace CSharpPractise.DotnetLogicLab.Day06;

public interface IFlyable
{
    void Fly();
}

public interface ISwimmable
{
    void Swim();
}

public class Duck : IFlyable, ISwimmable
{
    public void Fly()
    {
        Console.WriteLine("Fly");
    }

    public void Swim()
    {
        Console.WriteLine("Swim");
    }
}