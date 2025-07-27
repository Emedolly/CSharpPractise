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
/// <summary>
/// EX: 5 as input and output should be 78
/// </summary>
/// <param name="radius"></param>
    public void AreaOfCircle(double radius)
    {
        const double PI = 3.14;
        double area = PI * radius * radius;
        Console.WriteLine($"Area is {area}");
    }
}