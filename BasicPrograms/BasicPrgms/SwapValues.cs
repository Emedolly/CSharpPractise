namespace BasicPrograms.Topic1;

public class SwapValues
{
    public void SwapTwoValues()
    {
        Console.WriteLine("Enter the first two numbers: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Before swapping values are {a} {b}");
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"After swapping values are {a} {b}");
        Console.ReadLine();
    }
}