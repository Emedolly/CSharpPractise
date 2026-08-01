namespace CSharpPractise.DotnetLogicLab.Day04;

public class FactorialRecursion
{
    private void FactorialNumber(int number)
    {
        int result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }
        Console.WriteLine(result);
    }

    public int FactorialNumberRecursion(int number)
    {
        if(number <=1){return 1;}
        return number * FactorialNumberRecursion(number - 1);
    }
}