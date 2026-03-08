namespace BasicPrograms.Topic1;

public class EvenOrOdd
{
    public void CheckEvenOrOdd()
    { 
        Console.WriteLine("Enter a number to check if even or odd");
        int i = Convert.ToInt32(Console.ReadLine());
        int result = i % 2;
        if (result == 0)
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }
    }
}