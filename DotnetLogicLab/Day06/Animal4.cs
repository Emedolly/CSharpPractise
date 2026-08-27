namespace CSharpPractise.DotnetLogicLab.Day06;

public class Animal4
{
    private Animal3[] animals = new Animal3[]
    {
        new Dog3(),
        new Cat(),
        new Dog3()
    };

    public virtual void MakeSound()
    {
        foreach (Animal3 a in animals)
        {
            a.MakeSound();
        }
    }
}