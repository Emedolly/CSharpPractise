namespace BasicPrograms.Topic1;

public class PrintMultiples
{
    public void PrintMultiplesOfNumber()
    {
        int sum = 0;
        Console.WriteLine("Enter the number");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number");
        int b = int.Parse(Console.ReadLine());
        for (int i = a; i <= b; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                Console.WriteLine(i);
                sum += i;
            }
        }
        Console.WriteLine("The sum of all numbers is {0}", sum);
    }
}