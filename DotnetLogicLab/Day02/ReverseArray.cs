namespace CSharpPractise.DotnetLogicLab.Day02;

public class ReverseArray
{
    public void ReverseOfAnArray()
    {
        int[] array = new[] {1,2,3,4};
        for (int i = array.Length-1; i >=0; i--)
        {
            Console.Write(array[i]);
        }
    }
}