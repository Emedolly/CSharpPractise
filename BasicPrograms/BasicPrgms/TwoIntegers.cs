namespace BasicPrograms.Topic1;

public class TwoIntegers
{
    public void AddTwoIntegers()
    {
        Console.WriteLine("Enter first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int b = int.Parse(Console.ReadLine());
        int c = a + b;
        Console.WriteLine("The addition two numbers are: " + c);
    }
}