namespace CSharpPractise.DotnetLogicLab.Day02;

public class SecondLargestNumber
{
    public void SecondLargest(int[] array)
    {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int item in array)
        {
            if (item > largest)
            {
                secondLargest = largest;
                largest = item;
            }
            else if (item > secondLargest && item != largest)
            {
                secondLargest = item;
            }
        }

        Console.WriteLine("Largest: " + largest);
        Console.WriteLine("Second Largest: " + secondLargest);
    }

// Call:
    // SecondLargest(new int[] { 1, 5, 3, 9, 7 });
// Largest: 9, Second Largest: 7
}