namespace CSharpPractise.CsharpLessons.TopicWisePractice;

public class Beginner
{
    /// <summary>
    /// Variables and datatypes
    /// </summary>
    /// <param name="number1"></param>
    /// <param name="number2"></param>
    public void SwapNumbers(int number1, int number2)
    {
        Console.WriteLine($"Before swapping numbers from {number1} to {number2}");
        number1 = number1 + number2;
        number2 = number1 - number2;
        number1 = number1-number2;
        Console.WriteLine($"After swapping numbers from {number1} to {number2}");
        
    }
}