namespace CSharpPractise.DotnetLogicLab.Day04;

public class ReverseString
{
    public string ReverseStringUsingRecursion(string str)
    {
        if (str.Length <= 1) return str;
        return ReverseStringUsingRecursion(str.Substring(1)) + str[0];
    }

// Call:
    //Console.WriteLine(ReverseString("hello")); // olleh
}