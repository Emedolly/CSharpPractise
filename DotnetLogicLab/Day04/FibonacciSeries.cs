namespace CSharpPractise.DotnetLogicLab.Day04;

public class FibonacciSeries
{
    private void Fibonacci(int number)
    {
        if (number <= 1)
        {
            Console.WriteLine("Invalid number");
        }
        else
        {
            int previous = 0;
            int next = 1;
            Console.WriteLine(previous + " ");
            Console.WriteLine(next + " ");
            for (int i = 3; i <= number; i++)
            {
                int current = previous + next;
                Console.WriteLine(current + " ");
                previous = next;
                next = current;
            }
        }
    }

    public int FibonacciRecursion(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
    }
}