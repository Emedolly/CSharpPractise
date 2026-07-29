namespace CSharpPractise.DotnetLogicLab.Day03;

public class StringAnagram
{
    public void StringAnagrams(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            Console.WriteLine("StringAnagram doesn't have the same length!");
        }
        else
        {
            char[] str1Arr = str1.ToCharArray();
            char[] str2Arr = str2.ToCharArray();
            Array.Sort(str1Arr);
            Array.Sort(str2Arr);
            string sortedStr1 = new string(str1Arr);
            string sortedStr2 = new string(str2Arr);
            if (sortedStr1 == sortedStr2)
            {
                Console.WriteLine("StringAnagram are the same!");
            }
            else
            {
                Console.WriteLine("StringAnagram  have the same length but not the same!");
            }
        }
    } 
 }