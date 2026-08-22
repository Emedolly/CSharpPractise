namespace CSharpPractise.DotnetLogicLab.Day04;

public class Palindrome
{
    public bool IsPalindrome(string str, int start, int end)
    {
        if (start >= end) return true;
        if (str[start] != str[end]) return false;
        return IsPalindrome(str, start + 1, end - 1);
    }

    // Call:
    // Console.WriteLine(IsPalindrome("madam", 0, 4)); // True
    // Console.WriteLine(IsPalindrome("hello", 0, 4)); // False 
}