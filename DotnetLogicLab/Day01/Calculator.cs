namespace CSharpPractise.DotnetLogicLab;

public class Calculator
{
    public void EnterDigitsAndOperator(int num1, int num2, string operation)
    {
        int result = 0;
        switch (operation)
        {
            case "+":
               result = num1 + num2;
               break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                result = num1 / num2;
                break;
            default:
                break;
        }
        Console.WriteLine($"The {operation} of {num1} and {num2} is {result}");
    }
}