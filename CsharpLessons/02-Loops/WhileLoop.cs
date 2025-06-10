namespace CSharpPractise._02_Loops;

public class WhileLoop
{
    public void RunForLoop()
    {
        Console.Write("Enter the value of n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }

    public void RunWhileLoop()
    {
        Console.Write("Enter the value of n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        while (i <= n)
        {
            Console.WriteLine(i);
            i++;
        }
    }

    public void SumOfNumbers()
    {
        Console.Write("Enter the value of n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i <= n; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine("the sum of first " +n+ " is " + sum);
    }

    public void FactorialNumbers()
    {
        Console.Write("Enter the value of n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
        }
        Console.WriteLine("the factorial of first " +n+ " is " + factorial);
   }

    public void MultipleOfNumbers()
    {
        Console.WriteLine("Enter the number to be calculated");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int j = 1; j <= 10; j++)
        {
            Console.WriteLine("{0} * {1} = {2}", n, j, n * j);
        }
    }

    public int ReversedNumber(int number)
    {
        int reversed = 0;
        while (number > 0)
        {
            int digit = number % 10; //123%10 -> 3 
            reversed = reversed * 10 + digit; // 0*10 +3= 3
            number /= 10; //12=10 ->12.3 since number is an int it will delete the decimal 
        }

        return reversed;
            //ex: if you want ip as 200 outout as 002 then use the string format 
            //static string reverse(string num)
            //{return new string(num.reverse().toarray()); calling would be same 
            //}
    }

    public bool Palindrome(int number)
    {
        int originalNumber = number; //have to store the original num since temp contains the reversed and num will be 0 after the loop so have to store that in a variable to check.
        int temp = 0;
        while (number > 0)
        {
            int digit = number % 10;
            temp = temp*10+digit;
            number /= 10;
        }

        if (originalNumber == temp)
        {
            return true;
        }
        return false;
    }
}