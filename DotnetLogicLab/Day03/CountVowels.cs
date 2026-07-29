namespace CSharpPractise.DotnetLogicLab.Day03;

public class CountVowels
{
    public void countVowelsAndConsonants()
    {
        string word = "programming";
        int countVowels = 0;
        int countConsonants = 0;
        for (int i = 0; i < word.Length; i++)
        {
            if ( word[i] == 'a'||word[i]=='e'|| word[i]=='i'||word[i]=='o'|| word[i]=='u')
            {
                countVowels++;
            }
            else
            {
                countConsonants++;
            }
        }
        Console.WriteLine(countVowels);
        Console.WriteLine(countConsonants);
    }
}