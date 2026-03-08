namespace BasicPrograms.Topic1;

public class PrintOddNum
{
    public void PrintOddNumbers()
    {
        Console.WriteLine("Enter strt of the range");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the end of the range");
        int end = int.Parse(Console.ReadLine());
        int[] numbers = new int[end- start + 1];
        for (int i = 0; i < numbers.Length ; i++)
        {
            numbers[i] = start + i;
        }
        
        foreach (var number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.WriteLine(number);
            }
        }
        Console.WriteLine("Done");
        // IEnumerable<int> numbers = Enumerable.Range(1, 10).Where(x=>x%2!=0);
        // foreach (int i in numbers)
        // {
        //     Console.WriteLine(i);
        // }
       
        
        
    }
}