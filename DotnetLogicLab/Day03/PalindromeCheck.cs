namespace CSharpPractise.DotnetLogicLab.Day03;

public class PalindromeCheck
{
    public void PalindromeNumber()
    {
        int NumberToCheck = 12345;
        
        int temp = NumberToCheck;
        int reversedNumber = 0;
        while (temp > 0)
        {
            int lastdigit = temp % 10;
            reversedNumber = (reversedNumber *10) + lastdigit;
            temp /= 10;
        }

        if (NumberToCheck == reversedNumber)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not Palindrome");
        }

    }
}