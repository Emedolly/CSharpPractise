namespace CSharpPractise.DotnetLogicLab.Day03;

public class StringPalindrome
{
    public void PalindromeCheck()
    {
        string word = "madam";
        string reversedWord = string.Empty;
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord += word[i];
        }

        if (reversedWord == word)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not string Palindrome");
        }
    }
}