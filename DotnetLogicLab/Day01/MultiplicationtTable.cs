namespace CSharpPractise.DotnetLogicLab;

public class MultiplicationtTable
{
   public void Multiply(int num1)
   {
      for (int i = 1; i <= 10; i++)
      {
         int result = num1 * i;
         Console.WriteLine(result);
      }
   } 
}