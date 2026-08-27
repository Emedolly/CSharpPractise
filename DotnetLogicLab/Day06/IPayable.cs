namespace CSharpPractise.DotnetLogicLab.Day06;

public interface IPayable
{
    void Pay(float amount);
}

public class Employee : IPayable
{
    public void Pay(float amount)
    {
        Console.WriteLine("Employee Pay");
    }
}

public class Freelancer : IPayable
{
    public void Pay(float amount)
    {
        Console.WriteLine("Freelancer Pay");
    }
}