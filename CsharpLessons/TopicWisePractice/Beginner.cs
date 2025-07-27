using System.Runtime.ExceptionServices;

namespace CSharpPractise.CsharpLessons.TopicWisePractice;

public class Beginner
{
    #region Variables and datatypes
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
        number1 = number1 - number2;
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
    #endregion

    #region Operators

    /// <summary>
    /// check if a number is even or odd
    /// </summary>
    public void CheckEvenOrOddNumbers()
    {
        Console.WriteLine("Enter a  numebr");
        Int16 number = Int16.Parse(Console.ReadLine());
        Console.WriteLine((number % 2 == 0) ? "The number is even" : "The number is odd");
    }
    /// <summary>
    /// Find the largest of three numbers using ternary operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    public void FindLargetNumbers(int a, int b, int c)
    {
        // int max = Math.Max(a, Math.Max(b, c));
        int maxValue = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);
        Console.WriteLine($"Max value is {maxValue}");
    }
    #endregion

    #region Conditions(if,if else, switch)
    public void LeapYearCheck()
    {
        Console.WriteLine("Enter a year");
        int year = int.Parse(Console.ReadLine());
        if (year % 4 == 0)
        {
            Console.WriteLine($"The {year} is a leap year");
        }
        else
        {
            Console.WriteLine($"The {year} is not a leap year");
        }
    }

    public void Calculator()
    {
        Console.WriteLine("Enter a number");
        double number = double.Parse(Console.ReadLine());
        Console.WriteLine("choose + or - or * or / or %");
        char operation = char.Parse(Console.ReadLine());
        Console.WriteLine(("Enter second number"));
        double secondNumber = double.Parse(Console.ReadLine());
        double result = 0;
         
        switch (operation)
        {
            case '+':
                result = number + secondNumber;
                break;
            case '-':
                result = number - secondNumber;
                break;
            case '/':
                if (secondNumber == 0)
                {
                    Console.WriteLine("Enter any nbr apart from 0 as second number");
                }
                result = number / secondNumber;
                break;
            case '*':
                result = number * secondNumber;
                break;
            case '%':
                result = number % secondNumber;
                break;
            default:
                Console.WriteLine("Invalid operation");
                break;
        }
        Console.WriteLine($"The result is {result}");
    }
    #endregion
    
}