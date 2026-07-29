namespace CSharpPractise.DotnetLogicLab.Day03;

public class ReverseString
{
   public void ReverseOfAString()
   {
      string word = "Hello";
      for (int s = word.Length - 1; s >= 0; s--)
      {
         Console.Write(word[s]+ "");
      }
   } 
}