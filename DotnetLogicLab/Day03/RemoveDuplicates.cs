namespace CSharpPractise.DotnetLogicLab.Day03;

public class RemoveDuplicates
{
    public void RemoveDuplicatesCharacters()
    {
        string word = "programming";
        HashSet<char> freq = new HashSet<char>();
        string result = "";
        foreach (var item in word)
        {
            if (!freq.Contains(item))
            {
                freq.Add(item);
                result += item;
            }
        }
        Console.WriteLine(result);
    }
}