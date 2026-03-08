namespace BasicPrograms.Topic1;

public class PositiveOrNot
{
    public void CheckNumberIsPositiveOrNot()
    {
        Console.WriteLine("Checking positive or negative number, enter a number");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < 0)
        {
            Console.WriteLine("Number is negative");
        }
        else
        {
            Console.WriteLine("Number is positive");
        }
    }
}