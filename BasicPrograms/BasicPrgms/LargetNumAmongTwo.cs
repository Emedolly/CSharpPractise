namespace BasicPrograms.Topic1;

public class LargetNumAmongTwo
{
    public void FindLargetNumAmongTwo()
    {
        Console.WriteLine("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        if (firstNumber > secondNumber)
        {
            Console.WriteLine($"First number is greater than second number which is {firstNumber}");
        }
        else
        {
            Console.WriteLine($"Second number is greater than first number which is {secondNumber}");
        }
    }
}