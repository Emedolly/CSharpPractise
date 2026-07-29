namespace CSharpPractise.DotnetLogicLab.Day03;

public class CountOccurance
{
    public void CountOccuranceOfACharacter(string word, string targetCharacter)
    {
        int occurance = 0;
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i].ToString() == targetCharacter)
            {
                occurance++;
            }
        }
        Console.WriteLine(occurance);
    }
}