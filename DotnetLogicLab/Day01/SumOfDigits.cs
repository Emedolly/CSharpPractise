namespace CSharpPractise.DotnetLogicLab;

public class SumOfDigits
{
    public void Sum(int num)
    {
        int sum = 0;
        while (num != 0)
        {
            int lastDigit = num % 10;
            sum = sum + lastDigit;
            num = num / 10;
        }
        Console.WriteLine(sum);
    }
}