namespace CSharpPractise.DotnetLogicLab.Day06;

public class Animal2
{
    public string Name;

    public Animal2(string name)
    {
        Name = name;   // ONLY this constructor sets Name properly
    }
}

public class Dog2 : Animal2
{
    public Dog2(string name, string breed):base(name)
    {
        Console.WriteLine($"Breed: {breed}");
    }
}