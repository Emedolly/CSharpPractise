namespace CSharpPractise.DotnetLogicLab.Day02;

public class EvenOdd
{
    public void EvenOrOddInArray()
    {
        int[] array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int evenNumber=0, oddNumber=0;
        foreach (var item in array)
        {
            if (item % 2 == 0)
            {
                evenNumber++;
            }
            else
            {
                oddNumber++;
            }
        }
        Console.WriteLine(evenNumber);
        Console.WriteLine(oddNumber);
    }
}