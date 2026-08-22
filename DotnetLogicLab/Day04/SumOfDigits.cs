namespace CSharpPractise.DotnetLogicLab.Day04;

public class SumOfDigits
{
    public int SumOfDigitsRecursion(int n)
    {
        if (n == 0) return 0;
        return (n % 10) + SumOfDigitsRecursion(n / 10);
    }
}