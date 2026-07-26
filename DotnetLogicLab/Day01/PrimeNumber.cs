namespace CSharpPractise.DotnetLogicLab;

public class PrimeNumber
{
    public void VerifyPrimeNumber(int number)
    {
        bool isPrime = true;
        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine("The number is prime");
        }
        else
        {
            Console.WriteLine("The number is NOT prime");
        }
    }
}