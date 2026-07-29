namespace CSharpPractise.DotnetLogicLab.Day03;

public class CharacterFrequency
{
    public void CountCharacters()
    {
        string word = "Hello";
        Dictionary<char,int> freq = new Dictionary<char,int>();
        for (int i = 0; i < word.Length; i++)
        {
            if (freq.ContainsKey(word[i]))
            {
                freq[word[i]] = freq[word[i]] + 1;
            }
            else
            {
                freq[word[i]] = 1;
            }
        }

        foreach (var item in freq)
        {
            Console.WriteLine(item.Key + ":" + item.Value);
        }
    }
}