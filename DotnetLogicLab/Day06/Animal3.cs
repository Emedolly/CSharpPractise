namespace CSharpPractise.DotnetLogicLab.Day06;

public class Animal3
{
    public virtual void MakeSound()
    {
        Console.WriteLine("I am doing my sound");
    }
}

public class Dog3 : Animal3
{
    public override void MakeSound()
    {
        Console.WriteLine("I am doing Dog job");
    }
}

public class Cat : Animal3
{
    public override void MakeSound()
    {
        Console.WriteLine("I am doing cat");
    }
}