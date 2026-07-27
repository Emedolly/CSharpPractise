namespace CSharpPractise.DotnetLogicLab.Day02;

public class SumArray
{
    public void SumAndAverageOfArray()
    {
        int sum = 0;
        int[] array = new int[10];
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;
        array[5] = 6;
        array[6] = 7;
        array[7] = 8;
        array[8] = 9;
        array[9] = 10;
        foreach (var item in array)
        {
            sum += item;
        }
        decimal average = sum / array.Length;
        Console.WriteLine(sum);
        Console.WriteLine("average = " + average);

    }
}