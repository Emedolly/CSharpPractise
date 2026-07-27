namespace CSharpPractise.DotnetLogicLab.Day02;

public class ArrayMinMax
{
    public void MinAndMaxOfArray()
    {
        int[] array = new[] { 1, 2, 3, 4, 5 };
        int min = array[0];
        int max = array[0];
        bool isGreater = true;
        foreach (int i in array)
        {
            if(i < min)
            {
               min = i; 
            }
            else if (i > max)
            {
                max = i;
            }
        }
        Console.WriteLine(min);
        Console.WriteLine(max);
    }
}