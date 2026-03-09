namespace BasicPrograms.Topic1;

public class SumUsingRecursion
{
    public void SumUsingRecursion1()
    {
        Console.WriteLine("Enter the number:");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = Sum(number);
        Console.WriteLine(result);
    }

    private int Sum(int number)
    {        
        if (number != 0)
        {
            return (number % 10 + Sum(number / 10));
        }
        else
        {
            return 0;
        }
    }
}